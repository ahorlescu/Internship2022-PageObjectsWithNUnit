using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PageObjectsWithNUnit.Pages;

namespace PageObjectsWithNUnit.Tests
{
    [TestFixture]
    public class BasicFormTests
    {
        IWebDriver driver;
        BasicForm basicForm;
        BasicCheckbox basicCheckbox;

        [SetUp]
        public void Init()
        {
            driver = new ChromeDriver();
            driver.Manage().Cookies.DeleteAllCookies();

            basicForm = new BasicForm(driver);
            basicCheckbox = new BasicCheckbox(driver);
        }

        [Test]
        public void ValidateMessageIsDisplayedWhenUserEntersTextAndClickShowMessage()
        {
            // Arrange
            string message = "abcd";

            basicForm.GoToPage();
            basicForm.EnterMessage(message);

            // Act
            basicForm.ClickShowMessage();

            // Assert
            Assert.That(basicForm.GetDisplayedMessage(), Is.EqualTo(message));
        }

        [Test]
        public void ValidateMessageIsDisplayedWhenUserEntersTextAndClickShowMessageNoPageObjects()
        {
            // Arrange
            string message = "abcd";

            driver.Navigate().GoToUrl("https://www.seleniumeasy.com/test/basic-first-form-demo.html");
            driver.FindElement(By.Id("user-message")).SendKeys(message);

            // Act
            driver.FindElement(By.CssSelector("form[id='get-input'] > button")).Click();

            // Assert
            Assert.That(driver.FindElement(By.Id("display")).Text, Is.EqualTo(message));
        }

        [Test]
        public void ValidateCheckBox()
        {

            // Arrange
            basicCheckbox.GoToPage();

            // Act
            basicCheckbox.CheckBox();

            // Assert
            Assert.That(basicCheckbox.GetMessage(), Is.EqualTo("Success - Check box is checked"));
        }

        [TearDown]
        public void Cleanup()
        {
            driver.Quit();
        }
    }
}
