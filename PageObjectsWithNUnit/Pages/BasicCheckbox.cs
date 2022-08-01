using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace PageObjectsWithNUnit.Pages
{
    public class BasicCheckbox
    {

        private string url = "https://demo.anhtester.com/basic-checkbox-demo.html";

        private IWebDriver driver;

        public BasicCheckbox(IWebDriver driver)
        {
            this.driver = driver;

            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "isAgeSelected")]
        private IWebElement checkBox;

        [FindsBy(How = How.Id, Using = "txtAge")]
        private IWebElement message;

        public void GoToPage()
        {
            driver.Navigate().GoToUrl(url);
        }

        public void CheckBox()
        {
            checkBox.Click();
        }

        public string GetMessage()
        {
            return message.Text;
        }
    }
}
