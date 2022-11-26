using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PageObject
{
    public class CustomersPage:BasePage
    {
        private static WebDriverWait wait;
        public CustomersPage(IWebDriver webDriver):base(webDriver)
        {
            wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
        }

        private IWebElement btnBankManagerLogin => wait.Until(e=> e.FindElement(By.XPath("//button[contains(text(),'Bank Manager Login')]")));

        public void ClickBtnBankManagerLogin() => btnBankManagerLogin.Click();

        private IWebElement btnCustomers => wait.Until(e => e.FindElement(By.XPath("//button[contains(text(),'Customers')]")));

        public void ClickBtnCustomers() => btnCustomers.Click();

        private IWebElement btnDelete => wait.Until(e => e.FindElement(By.XPath("//button[contains(text(),'Delete')]")));

        public void ClickBtnDelete() => btnDelete.Click();

        public int lentghOfCustomer => driver.FindElements(By.XPath("//tbody/tr[@class='ng-scope']")).ToList<IWebElement>().Count;

    }
}
