using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace FastReflection
{
    public interface IFastProperty
    {
        /// <summary>
        /// Gets the <see cref="PropertyInfo"/> the fast property is associated with
        /// </summary>
        /// <value>The property.</value>
        PropertyInfo Property { get; }

        /// <summary>
        /// Gets the type of the object being passed in as the instance when getting/setting the property
        /// </summary>
        /// <value>The type of the instance.</value>
        Type InstanceType { get; }

        /// <summary>
        /// Gets the type of the object being passed in as the value when setting the property.
        /// </summary>
        /// <value>The type of the return.</value>
        Type ReturnType { get; }

        /// <summary>
        /// Gets a value indicating whether this instance can read.
        /// </summary>
        /// <value><c>true</c> if this instance can read; otherwise, <c>false</c>.</value>
        bool CanRead { get; }

        /// <summary>
        /// Gets a value indicating whether this instance can write.
        /// </summary>
        /// <value><c>true</c> if this instance can write; otherwise, <c>false</c>.</value>
        bool CanWrite { get; }
    }
}
