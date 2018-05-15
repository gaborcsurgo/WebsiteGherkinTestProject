using System;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace GherkinTCs.StepDefs
{
    [Binding]
    public class DoclerWebsiteTestScenariosSteps
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;

        [Given(@"I am on the Home Page")]
        public void GivenIAmOnThe()
        {
            // Need to use an exact path because otherwise got this error: "OpenQA.Selenium.DriverServiceNotFoundException"
            // Please insert and change the Chrome driver's path from the project's 'packages' folder below: 
            driver = new ChromeDriver(@"C:\Users\EZCSUGA\source\repos\DoclerStudyTCs\packages\Selenium.Chrome.WebDriver.2.38\driver");
            string homePage = "http://uitest.duodecadits.com";
            driver.Navigate().GoToUrl(homePage + "/");
            driver.Manage().Window.Maximize();
        }

        [Given(@"I am at the Form Page")]
        public void GivenIAmAtThe()
        {
            driver = new ChromeDriver(@"C:\Users\EZCSUGA\source\repos\DoclerStudyTCs\packages\Selenium.Chrome.WebDriver.2.38\driver");
            string formPage = "http://uitest.duodecadits.com/form.html";
            driver.Navigate().GoToUrl(formPage);
            driver.Manage().Window.Maximize();
        }

        [When(@"I click the Home button")]
        public void WhenIClickThe()
        {
            driver.FindElement(By.Id("home")).Click();
        }

        [When(@"I click the UI Testing button")]
        public void WhenIClickTheUI()
        {
            driver.FindElement(By.Id("site")).Click();
        }

        [When(@"I click the Form button")]
        public void WhenIClickTheFormButton()
        {
            driver.FindElement(By.Id("form")).Click();
        }
        
        [When(@"I enter the (.*) in the input box")]
        public void WhenIEnterTheInTheInputBox(string name)
        {
            driver.FindElement(By.Id("hello-input")).SendKeys(name);

        }

        [When(@"I press the submit button")]
        public void WhenIPressTheSubmitButton()
        {
            driver.FindElement(By.Id("hello-submit")).Click();
        }
        
        [When(@"I click the Error button")]
        public void WhenIClickTheErrorButton()
        {
            driver.FindElement(By.Id("error"));
        }
        
        [Then(@"Navigated to Home Page")]
        public void ThenNavigatedToHomePage()
        {
            driver.FindElement(By.XPath("//a[contains(text(),'Home')]")).Click();
        }

        [Then(@"Navigated to Form Page")]
        public void ThenNavigatedToFormPage()
        {
            driver.FindElement(By.XPath("//a[contains(@href, '/form.html')]")).Click();
        }

        [Then(@"Navigated to Hello Page")]
        public void ThenNavigatedToHelloPage()
        {
            driver.FindElement(By.Id("hello-text")).Click();
        }

        [Then(@"Not Navigated to Error Page")]
        public void ThenNotNavigatedToErrorPage()
        {
            driver.FindElement(By.Id("error")).Click();
        }
        
        [Then(@"the title should be ""(.*)""")]
        public void ThenTheTitleShouldBe(string title)
        {
            Assert.AreEqual(title, driver.Title);
        }
        
        [Then(@"the company logo should be visible")]
        public void ThenTheCompanyLogoShouldBeVisible()
        {
            Assert.IsTrue(IsElementPresent(By.Id("dh_logo")));
        }
        
        [Then(@"the Home button should be in active status")]
        public void ThenTheHomeButtonShouldBeInActiveStatus()
        {
            IWebElement button = driver.FindElement(By.Id("home"));
            Assert.AreEqual(true, button.Enabled);
        }
        
        [Then(@"the text should be visible in h tag ""(.*)""")]
        public void ThenTheTextShouldBeVisibleInHTag(string h1text)
        {
            Assert.AreEqual(h1text, driver.FindElement(By.CssSelector("h1")).Text);
        }
        
        [Then(@"the text should be visible in p tag ""(.*)""")]
        public void ThenTheTextShouldBeVisibleInPTag(string ptext)
        {
            Assert.AreEqual(ptext, driver.FindElement(By.CssSelector("p.lead")).Text);
        }
        
        [Then(@"the Form button should be in active status")]
        public void ThenTheFormButtonShouldBeInActiveStatus()
        {
            IWebElement button = driver.FindElement(By.Id("form"));
            Assert.AreEqual(true, button.Enabled);
        }
            
        [Then(@"I should see the result (.*)")]
        public void ThenIShouldSeeThe(string result)
        {
            Assert.AreEqual(result, driver.FindElement(By.CssSelector("h1")).Text);
        }

        [Then(@"There should be one button and a box")]
        public void ThenThereShouldBeOneButtonAndABox()
        {
            driver.FindElement(By.Id("hello-input"));
            driver.FindElement(By.Id("hello-submit"));
        }
        
        [Then(@"I should get an error response")]
        public void ThenIShouldGetAErrorResponse()
        {
            Assert.AreEqual("404 Error: File not found :-)", driver.Title);
        }

        [Then(@"close the application")]
        public void ThenCloseTheApplication()
        {
            driver.Quit();
        }

        public bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}
