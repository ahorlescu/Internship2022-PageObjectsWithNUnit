using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace PageObjectsWithNUnit.Pages
{
    public class BasicForm
    {
        private string url = "https://www.seleniumeasy.com/test/basic-first-form-demo.html";

        private IWebDriver driver;

        public BasicForm(IWebDriver driver)
        {
            this.driver = driver;

            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "user-message")]
        private IWebElement messageTextBox;

        [FindsBy(How = How.CssSelector, Using = "form[id='get-input'] > button")]
        private IWebElement showMessageButton;

        [FindsBy(How = How.Id, Using = "display")]
        private IWebElement displayedMessage;

        public void GoToPage()
        {
            driver.Navigate().GoToUrl(url);
        }

        public void EnterMessage(string message)
        {
            messageTextBox.SendKeys(message);
        }

        public BasicForm ClickShowMessage()
        {
            showMessageButton.Click();
            return this;
        }

        public string GetDisplayedMessage()
        {
            return displayedMessage.Text;
        }
    }
}
