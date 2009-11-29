using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using System.Reflection;

namespace FastReflection
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="P"></typeparam>
    public class FastProperty<T, P> : IFastProperty<T,P>
    {
        /// <summary>
        /// Gets or sets the property.
        /// </summary>
        /// <value>The property.</value>
        public PropertyInfo Property { get; protected set; }

        /// <summary>
        /// Gets or sets the type of the parameter being passed in as the instance.
        /// </summary>
        /// <value>The type of the instance.</value>
        public Type InstanceType { get; private set; }

        /// <summary>
        /// Gets or sets the type of value being returned by the property.
        /// </summary>
        /// <value>The type of the return.</value>
        public Type ReturnType { get; private set; }

        /// <summary>
        /// Gets a value indicating whether this instance can read.
        /// </summary>
        /// <value><c>true</c> if this instance can read; otherwise, <c>false</c>.</value>
        public bool CanRead
        {
            get
            {
                return this.Property.CanRead;
            }
        }

        /// <summary>
        /// Gets a value indicating whether this instance can write.
        /// </summary>
        /// <value><c>true</c> if this instance can write; otherwise, <c>false</c>.</value>
        public bool CanWrite
        {
            get
            {
                return this.Property.CanWrite;
            }
        }

        /// <summary>
        /// Makes the fast property for the specified <see cref="System.Reflection.PropertyInfo">Property</see>.
        /// </summary>
        /// <param name="property">The property.</param>
        /// <returns></returns>
        public static FastProperty<T, P> Make(PropertyInfo property)
        {
            if (_Cache.ContainsKey(property))
            {
                return _Cache[property];
            }
            else
            {
                var instanceType = typeof(T);
                var returnType = typeof(P);

                // make sure that (T)instance is valid
                if (!instanceType.IsAssignableFrom(property.DeclaringType))
                {
                    throw new Exception(string.Format("The type {0} cannot be assigned to values of type {1}", property.DeclaringType.Name, typeof(T).Name));
                }

                // make sure that (P)value is valid
                if (!returnType.IsAssignableFrom(property.PropertyType))
                {
                    throw new Exception(string.Format("The type {0} cannot be assigned to values of type {1}", property.PropertyType.Name, typeof(P).Name));
                }

                // create our fast property instance
                FastProperty<T, P> fastProperty = new FastProperty<T, P>(property, instanceType, returnType);

                // add it to the cache
                _Cache.Add(property, fastProperty);

                return fastProperty;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FastProperty&lt;T, P&gt;"/> class.
        /// </summary>
        /// <param name="property">The property.</param>
        private FastProperty(PropertyInfo property, Type instanceType, Type returnType)
        {
            this.Property = property;
            this.InstanceType = instanceType;
            this.ReturnType = returnType;

            MakeDelegates();
        }

        /// <summary>
        /// Makes the  get/set delegates.
        /// </summary>
        private void MakeDelegates()
        {
            var instance = Expression.Parameter(this.InstanceType, "instance");
            var value = Expression.Parameter(this.ReturnType, "value");

            Expression getExpression = null;
            Expression setExpression = null;
            Expression instanceExpression = null;
            Expression valueExpression = null;

            // handle instance conversion
            if (this.InstanceType == this.Property.DeclaringType)
            {
                instanceExpression = instance;
            }
            else
            {
                instanceExpression = (this.Property.DeclaringType.IsValueType) ?
                    Expression.Convert(instance, this.Property.DeclaringType) :
                    Expression.TypeAs(instance, this.Property.DeclaringType);
            }

            // create the call to the get method
            if (this.Property.CanRead)
            {
                getExpression = Expression.Call(instanceExpression, this.Property.GetGetMethod());
            }

            // handle value conversion
            if (this.ReturnType == this.Property.PropertyType)
            {
                valueExpression = value;
            }
            else
            {
                if (this.Property.PropertyType.IsValueType)
                {
                    valueExpression = Expression.Convert(value, this.Property.PropertyType);

                    // convert the return value of the get method
                    if (getExpression != null)
                    {
                        getExpression = Expression.Convert(getExpression, this.ReturnType);
                    }
                }
                else
                {
                    valueExpression = Expression.TypeAs(value, this.Property.PropertyType);

                    // convert the return value of the get method
                    getExpression = Expression.TypeAs(getExpression, this.ReturnType);
                }
            }

            if (this.Property.CanRead)
            {
                this.Get = Expression.Lambda<Func<T, P>>(getExpression, instance).Compile();
            }

            if (this.Property.CanWrite)
            {
                // create the call to the set method
                setExpression = Expression.Call(instanceExpression, this.Property.GetSetMethod(), valueExpression);
                this.Set = Expression.Lambda<Action<T, P>>(setExpression, instance, value).Compile();
            }
        }

        /// <summary>
        /// Gets or sets the get.
        /// </summary>
        /// <value>The get.</value>
        public Func<T, P> Get { get; private set; }

        /// <summary>
        /// Gets or sets the set.
        /// </summary>
        /// <value>The set.</value>
        public Action<T, P> Set { get; private set; }

        /// <summary>
        /// A cache to store properties that have already been parsed
        /// </summary>
        private static readonly Dictionary<PropertyInfo, FastProperty<T, P>> _Cache = new Dictionary<PropertyInfo, FastProperty<T, P>>();

        /// <summary>
        /// Determines whether the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>.
        /// </summary>
        /// <param name="obj">The <see cref="T:System.Object"/> to compare with the current <see cref="T:System.Object"/>.</param>
        /// <returns>
        /// true if the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>; otherwise, false.
        /// </returns>
        /// <exception cref="T:System.NullReferenceException">The <paramref name="obj"/> parameter is null.</exception>
        public override bool Equals(object obj)
        {
            if (obj == null) throw new NullReferenceException();

            // check to see if we are comparing fast properties
            if (obj is IFastProperty)
            {
                var instance = obj as IFastProperty;

                return (
                    this.Property == instance.Property && 
                    this.ReturnType == instance.ReturnType && 
                    this.InstanceType == instance.InstanceType
                );
            }

            return false;
        }

        /// <summary>
        /// Serves as a hash function for a particular type.
        /// </summary>
        /// <returns>
        /// A hash code for the current <see cref="T:System.Object"/>.
        /// </returns>
        public override int GetHashCode()
        {
            return this.Property.GetHashCode();
        }

        /// <summary>
        /// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
        /// </returns>
        public override string ToString()
        {
            return string.Format("FastProperty<{0},{1}> - {2}.{3}", this.InstanceType.Name, this.ReturnType.Name, this.Property.DeclaringType.Name, this.Property.Name);
        }

        /// <summary>
        /// Gets the <see cref="System.Func"/> delegate used to access the getter for the property.
        /// </summary>
        /// <value>The get.</value>
        Func<T, P> IFastProperty<T, P>.Get
        {
            get { return this.Get; }
        }

        /// <summary>
        /// Gets the <see cref="System.Action"/> delegate used to access the setter for the property.
        /// </summary>
        /// <value>The set.</value>
        Action<T, P> IFastProperty<T, P>.Set
        {
            get { return this.Set; }
        }

        /// <summary>
        /// Gets the <see cref="PropertyInfo"/> the fast property is associated with
        /// </summary>
        /// <value>The property.</value>
        PropertyInfo IFastProperty.Property
        {
            get { return this.Property; }
        }

        /// <summary>
        /// Gets the type of the object being passed in as the instance when getting/setting the property
        /// </summary>
        /// <value>The type of the instance.</value>
        Type IFastProperty.InstanceType
        {
            get { return this.InstanceType; }
        }

        /// <summary>
        /// Gets the type of the object being passed in as the value when setting the property.
        /// </summary>
        /// <value>The type of the return.</value>
        Type IFastProperty.ReturnType
        {
            get { return this.ReturnType; }
        }


        /// <summary>
        /// Gets a value indicating whether this instance can read.
        /// </summary>
        /// <value><c>true</c> if this instance can read; otherwise, <c>false</c>.</value>
        bool IFastProperty.CanRead
        {
            get { return this.CanRead; }
        }

        /// <summary>
        /// Gets a value indicating whether this instance can write.
        /// </summary>
        /// <value><c>true</c> if this instance can write; otherwise, <c>false</c>.</value>
        bool IFastProperty.CanWrite
        {
            get { return this.CanWrite; }
        }
    }
}
