using System;
using TechTalk.SpecFlow;

namespace EighthTask.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        private IWebDriver driver;
        private void SetUpDriver()
        {
            driver = new ChromeDriver();
        }

        private void CloseDriver()
        {
            driver.Quit();
        }
        [Given(@"open the page")]
        public void GivenOpenThePage()
        {
            SetUpDriver();
            driver.Url = "https://www.saucedemo.com/";
        }

        [When(@"type '([^']*)' in the username field and '([^']*)' in the password field")]
        public void WhenTypeInTheUsernameFieldAndInThePasswordField(string username, string pwd)
        {
            driver.FindElement(By.Id("user-name")).SendKeys(username);
            driver.FindElement(By.Id("password")).SendKeys(pwd+Keys.Enter);
        }

        [Then(@"error message '([^']*)' should be present on page")]
        public void ThenErrorMessageShouldBePresentOnPage(string errorMessage)
        {
            IWebElement passwordError = driver.FindElement(By.CssSelector("#login_button_container > div > form > div.error-message-container.error > h3"));
            Assert.That(passwordError.Text, Is.EqualTo(errorMessage));

            CloseDriver();
        }
    }
}
