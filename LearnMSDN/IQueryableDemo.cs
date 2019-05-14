using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LearnMSDN
{
    /// <summary>
    /// Providese functionality to evaluate queries againt a specific data source wherein the type of the data is not specified.
    /// It is intended for implemenation by query provides.
    /// It is only supposed to be implemented by providers that also implement IQueryable<T>.
    /// If the provider does not also implement IQueryable<T>, the standard query operators cannot be used on the provider's data source.
    /// </summary>
    class IQueryableDemo:IQueryable
    {
        /// <summary>
        /// gets the type of the elements that are returned when the expression tree associated with this instance of IQueryable is executed.
        /// </summary>
        public Type ElementType
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets the ecpression treee that is associated with the instance of IQueryable
        /// </summary>
        public Expression Expression
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets the query provider that is associated with this datasource.
        /// </summary>
        public IQueryProvider Provider
        {
            get { throw new NotImplementedException(); }
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
