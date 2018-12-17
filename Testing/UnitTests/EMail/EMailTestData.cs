using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;

namespace Testing.UnitTests.EMail
{
    /// <summary>
    /// Provide tests data for the email test theories
    /// </summary>
    public class EmailTestData : IEnumerable<object[]>
    {
        /// <summary>
        /// Enumerate test data for the theories
        /// </summary>
        /// <returns>An enumerable set of data</returns>
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { "joewalters999@gmail.com", true };
            yield return new object[] { "joewalters999~gmail.com", false };
        }

        /// <summary>
        /// Exposes the enumerator object
        /// </summary>
        /// <returns>An enumerable set of data</returns>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
