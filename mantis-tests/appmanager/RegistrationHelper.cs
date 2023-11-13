using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Hosting;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using System.Threading;

namespace mantis_tests
{
    public class RegistrationHelper : HelperBase
    {


        public RegistrationHelper(ApplicationManager manager) : base(manager)
        {
        }

        public void Register(AccountData acount)
        {
            OpenMainPage();
            OpenRegistrationForm();
            FillRegistrationForm(acount);
            SubmitRegistration();
        }


        public void OpenMainPage()
        {
            manager.Driver.Url = "http://localhost/mantisbt-2.26.0/login_page.php";
        }
        public void OpenRegistrationForm()
        {
            //driver.FindElements(By.CssSelector("span.bracket-link"))[0].Click();
           driver.FindElement(By.LinkText("Зарегистрировать новую учётную запись")).Click();
        }
        public void FillRegistrationForm(AccountData account)
        {
            driver.FindElement(By.Name("username")).SendKeys(account.Name);
            //driver.FindElement(By.Name("username")).SendKeys(account.Name);
            driver.FindElement(By.Name("email")).SendKeys(account.Email);
        }
        public void SubmitRegistration()
        {
            driver.FindElement(By.XPath("//input[@value='Зарегистрироваться']")).Click();
            //driver.FindElement(By.CssSelector("input.button")).Click();
        }

        public void Login(AccountData account)
        {

            Type(By.Name("username"), account.Name);
            driver.FindElement(By.XPath("//form[@id='login-form']/fieldset/input[2]")).Click();
            Type(By.Name("password"), account.Password);
            driver.FindElement(By.XPath("//form[@id='login-form']/fieldset/input[3]")).Click();
        }

    }
}
