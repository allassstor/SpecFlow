using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageObject;
using TechTalk.SpecFlow;

namespace SpecFlowProject.Steps
{
    [Binding]
    public class DeleteCustomersSteps:BaseSteps
    {
        private CustomersPage customersPage;
        int expected_result;
        int actual_result;

        [Given(@"open XYZ Bank page")]
        public void GivenOpenXYZBankPage()
        {
            driver.Url = "https://www.globalsqa.com/angularJs-protractor/BankingProject";
            customersPage = new CustomersPage(driver);
        }
        
        [Given(@"click Bank Manager Login")]
        public void GivenClickBankManagerLogin()
        {
            customersPage.ClickBtnBankManagerLogin();
        }
        
        [Given(@"click on the Customers")]
        public void GivenClickOnTheCustomers()
        {
            customersPage.ClickBtnCustomers();
        }
        
        [When(@"delete the client by clicking on Delete")]
        public void WhenDeleteTheClientByClickingOnDelete()
        {
            expected_result = customersPage.lentghOfCustomer;
            customersPage.ClickBtnDelete();
            actual_result = customersPage.lentghOfCustomer;

        }
        
        [Then(@"the client is removed from the list")]
        public void ThenTheClientIsRemovedFromTheList()
        {
            Assert.AreNotEqual(expected_result, actual_result);

        }
    }
}
