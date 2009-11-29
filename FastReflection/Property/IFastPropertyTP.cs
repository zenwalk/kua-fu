using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace FastReflection
{
    public interface IFastProperty<T,P> : IFastProperty
    {
        /// <summary>
        /// Gets the <see cref="System.Func"/> delegate used to access the getter for the property.
        /// </summary>
        /// <value>The get.</value>
        Func<T, P> Get { get; }

        /// <summary>
        /// Gets the <see cref="System.Action"/> delegate used to access the setter for the property.
        /// </summary>
        /// <value>The set.</value>
        Action<T, P> Set { get; }
    }
}
