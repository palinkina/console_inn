using System.Collections.Generic;
using OpenQA.Selenium;
//

namespace mantis_tests
{
    public class ProjectHelper : HelperBase
    {
        public ProjectHelper(ApplicationManager manager) : base(manager)
        {
        }
        public void Create(ProjectData project)
        {
            CreateNewProject();
            driver.FindElement(By.XPath("//input[@id='project-name']")).SendKeys(project.Name);
            ConfirmCreationProject();

        }
        public void Remove(int v)
        {
            GoToProject(v);
            DeleteProjectButton();
            ConfirmProjectDelition();
        }

        public void GoToProject(int i)
        {
            driver.FindElement(By.XPath("(//tbody//tr//td//a)[1]")).Click();
        }
        public void DeleteProjectButton()
        {
            driver.FindElement(By.XPath("//form[@id='manage-proj-update-form']/div/div[3]/button[2]")).Click();
        }
        public void ConfirmProjectDelition()
        {
            driver.FindElement(By.XPath("//input[@value='Удалить проект']")).Click();
        }

        public ProjectHelper CreateNewProject()
        {
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();
            return this;
        }
        public ProjectHelper ConfirmCreationProject()
        {
            driver.FindElement(By.XPath("//div[3]/input")).Click();
            return this;
        }
        public List<ProjectData> GetProjects()
        {
            List<ProjectData> projects = new List<ProjectData>();
            manager.Navigator.GoToControlProject();
            ICollection<IWebElement> elements = driver.FindElements(By.XPath("//tbody//tr//a"));
            foreach (IWebElement element in elements)
            {
                projects.Add(new ProjectData(element.Text));
            }

            return projects;

        }
       /* public int GetProjectCount()
        {
            //return driver.FindElements(By.CssSelector("span.group")).Count;
           // return driver.FindElement(By.CssSelector("i.fa.fa-check.fa-lg")).Count;
        }
       */
    }
}