using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Testing.Code.EMail;
using Xunit;

namespace Testing.UnitTests.EMail
{
    /// <summary>
    /// Tests to check that email validation etc. works ok
    /// </summary>
    public class EMailUnitTests
    {
        /// <summary>
        /// Test a number of email scenarios to see if the emails are valid
        /// </summary>
        /// <param name="email">The email to test</param>
        /// <param name="valid">The expected result</param>
        [Theory]
        [ClassData(typeof(EmailTestData))]
        public void Check_Email_Validation(String email, Boolean valid)
        {
            // Arrange
            Boolean result = true;

            // Act
            if (valid)
                result = (new EMailChecker()).Valid(email); // Do the "valid" check
            else
                result = !(new EMailChecker()).Valid(email); // Do the "invalid" check

            // Assert
            Assert.True(result);
        }

        /// <summary>
        /// Is a given email valid?
        /// </summary>
        /// <param name="email">The email to check</param>
        [Theory]
        [InlineData("joe.walters@impellam.com")]
        public void Is_Email_Valid(String email)
            => Assert.True(
                (new EMailChecker()).Valid(email)
                );

        /// <summary>
        /// Is a given email invalid?
        /// </summary>
        /// <param name="email">The email to check</param>
        [Theory]
        [InlineData("joe.walters~impellam.com")]
        public void Is_Email_InValid(String email)
            => Assert.False(
                (new EMailChecker()).Valid(email)
                );
    }
}
