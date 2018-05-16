using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using static Details.GeneralDetails;
using OpenQA.Selenium.Support.UI;

namespace AddCredit
{
    [TestFixture]
    class AddCreditMainTests : Details.GeneralDetails.AddCreditDetails
    {
        static void Main(string[] args)
        {
        }

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [Test, Order(1)]
        public void LogInParlay()
        {


            // LOG IN Parlay
            IWebDriver driver = new ChromeDriver();

            driver.Url = BaseUrl;
            log.Info("Navigate to Parlay");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10)); 

            wait.Until(ExpectedConditions.ElementIsVisible(By.Name("username")));
            driver.FindElement(By.Name("username")).SendKeys(Username);
            log.InfoFormat("Insert username -", Username);

            wait.Until(ExpectedConditions.ElementIsVisible(By.Name("password")));
            driver.FindElement(By.Name("password")).SendKeys(Password);
            log.InfoFormat("Insert password -", Password);

            IWebElement loginBtn = driver.FindElement(By.Id("submitBtn"));
            loginBtn.Click();
            log.Info("Log In User");

            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='players']/span")));
            driver.FindElement(By.XPath("//*[@id='players']/span")).Click();
            log.InfoFormat("Click PLayers");

            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='players']/ul/li/a")));
            driver.FindElement(By.XPath("//*[@id='players']/ul/li/a")).Click();
            log.InfoFormat("Click Search Players");

            wait.Until(ExpectedConditions.ElementIsVisible(By.Name("text")));
            driver.FindElement(By.Name("text")).SendKeys(UsernameToCredit);
            log.InfoFormat("Insert Username to Search");
            log.InfoFormat(UsernameToCredit);

            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='formContainer']/table/tbody/tr/td[2]/input")));
            driver.FindElement(By.XPath("//*[@id='formContainer']/table/tbody/tr/td[2]/input")).Click();
            log.InfoFormat("Click Submit Button");

            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='players']/ul/li[17]/a")));
            driver.FindElement(By.XPath("//*[@id='players']/ul/li[17]/a")).Click();
            log.InfoFormat("Click Adjust Balance");

            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='manualDaysUnqualExpires']")));
            driver.FindElement(By.XPath("//*[@id='manualDaysUnqualExpires']")).Click();
            log.InfoFormat("Click Unqualified Expiry");

            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='manualDaysUnqualExpires']/option[9]")));
            driver.FindElement(By.XPath("//*[@id='manualDaysUnqualExpires']/option[9]")).Click();
            log.InfoFormat("Select 365 Days");

            //*[@id='manualDaysQualExpires']/option[9]
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='manualDaysQualExpires']/option[9]")));
            driver.FindElement(By.XPath("//*[@id='manualDaysQualExpires']/option[9]")).Click();
            log.InfoFormat("Click and select 365 Qualified Expiry");


            //*[@id="adjustBalanceForm"]/table/tbody/tr/td[2]/label[2]/input
            wait.Until(ExpectedConditions.ElementIsVisible(By.Name("strAmount")));
            driver.FindElement(By.Name("strAmount")).Clear();
            driver.FindElement(By.Name("strAmount")).SendKeys(Ammount);
            log.InfoFormat("Click And Add Ammount");

            //*[@id='manualSpendType']/option[6]
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='manualSpendType']/option[6]")));
            driver.FindElement(By.XPath("//*[@id='manualSpendType']/option[6]")).Click();
            log.InfoFormat("Click Transaction Purpose and select Testing");

            //*[@id="adjustBalanceForm"]/table/tbody/tr/td[2]/label[5]/textarea
            wait.Until(ExpectedConditions.ElementIsVisible(By.Name("comment")));
            driver.FindElement(By.Name("comment")).SendKeys(Comments);
            log.InfoFormat("Click And select Comment");

            //*[@id='adjustBalanceForm']/table/tbody/tr/td[3]/input
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='adjustBalanceForm']/table/tbody/tr/td[3]/input")));
            driver.FindElement(By.XPath("//*[@id='adjustBalanceForm']/table/tbody/tr/td[3]/input")).Click();
            log.InfoFormat("Click Submit button");
            Thread.Sleep(60 * 1000);

            driver.Quit();
            log.Info("finish add amount test ");
        }

    }
}
