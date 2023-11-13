using System;
using OpenQA.Selenium;
//

namespace mantis_tests
{
    public class NavigationHelper : HelperBase
    {
        public NavigationHelper(ApplicationManager manager) : base(manager)
        {
        }

        public void GoToControlProject()
        {
            driver.FindElement(By.LinkText("Управление")).Click();
            driver.FindElement(By.XPath("//a[contains(text(),'Проекты')]")).Click();
        }
    }
}
