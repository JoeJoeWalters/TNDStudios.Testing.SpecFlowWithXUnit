using System;
using TechTalk.SpecFlow;
using Testing.UnitTests.EMail;
using Xunit;

namespace Testing.Releases.v1_0_1.Change_1
{
    /// <summary>
    /// SpecFlow scenario for when an email is entered 
    /// and should be valid
    /// </summary>
    [Binding]
    [Scope(Tag = "ValidEmailCheck", Feature = "Email Entry On Scheduling Tab 1")]
    public class Scenario_Emails_When_Checked_Should_Be_Valid
    {
        /// <summary>
        /// EMail unit test reference to forward on tests 
        /// to the appropriate unit test
        /// </summary>
        private static EMailUnitTests unitTests;

        [BeforeScenario("Emails when checked should be valid")]
        public static void Before()
            => unitTests = new EMailUnitTests();

        [AfterScenario("Emails when checked should be valid")]
        public static void After()
            => unitTests = null;

        [Given(@"I have a saved search")]
        public void GivenIHaveASavedSearch()
        {
            Assert.True(true);
            //ScenarioContext.Current.Pending();
        }

        [Given(@"I have entered a valid email (.*) in to the scheduling tab")]
        public void GivenIHaveEnteredAValidEmailInToTheSchedulingTab(String email)
            => unitTests.Is_Email_Valid(email);

        [Then(@"The email will be marked as valid")]
        public void ThenTheEmailWillBeMarkedAsValid()
        {
            //ScenarioContext.Current.Pending();
        }
    }

    /// <summary>
    /// SpecFlow scenario for when an email is entered 
    /// and should be invalid
    /// </summary>
    [Binding]
    [Scope(Tag = "InvalidEmailCheck", Feature = "Email Entry On Scheduling Tab 1")]
    public class Scenario_Emails_When_Checked_Should_Be_Invalid
    {
        /// <summary>
        /// EMail unit test reference to forward on tests 
        /// to the appropriate unit test
        /// </summary>
        private static EMailUnitTests unitTests;

        [BeforeScenario("Emails when checked should be invalid")]
        public static void Before()
            => unitTests = new EMailUnitTests();

        [AfterScenario("Emails when checked should be invalid")]
        public static void After()
            => unitTests = null;

        [Given(@"I have a saved search")]
        public void GivenIHaveASavedSearch()
        {
            Assert.True(true);
            //ScenarioContext.Current.Pending();
        }

        [Given(@"I have entered an invalid email (.*) in to the scheduling tab")]
        public void GivenIHaveEnteredAnInvalidEmailInToTheSchedulingTab(String email)
        => unitTests.Is_Email_InValid(email);

        [Then(@"The email will be marked as invalid")]
        public void ThenTheEmailWillBeMarkedAsInvalid()
        {
            //ScenarioContext.Current.Pending();
        }


    }
}
