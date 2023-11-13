using mantis_tests.Mantis;
using System;
using System.Collections.Generic;
using mantis_tests.tests;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.FtpClient;
using System.IO;
using System.ComponentModel;
using System.ServiceModel.Configuration;

namespace mantis_tests
{
    public class APIHelper : HelperBase
    {
        public APIHelper(ApplicationManager manager) : base(manager)
        {
        }

        public void CreateNewIssue(AccountData account, ProjectData project, IssueData issueData)
        {
            Mantis.MantisConnectPortTypeClient client = new Mantis.MantisConnectPortTypeClient();// объект, через который можно обращатсья к операциям
            Mantis.IssueData issue = new Mantis.IssueData();//создали обязательный параметр для mc_issue_add
            issue.summary = issueData.Summary; // текст
            issue.description = issueData.Description; //текст
            issue.category = issueData.Category;
            issue.project = new Mantis.ObjectRef();//поле issue.project имеет тип ObjectRef, поэтому создали
            issue.project.id = project.Id;
            client.mc_issue_add(account.Name, account.Password, issue);//вызываем нужный метод 
        }

        public List<ProjectData> GetProjects(AccountData account)
        {
            {
                List<ProjectData> projects = new List<ProjectData>();
                Mantis.MantisConnectPortTypeClient client = new Mantis.MantisConnectPortTypeClient();
                Mantis.ProjectData[] projectsoInBT = client.mc_projects_get_user_accessible(account.Name, account.Password);
                foreach (Mantis.ProjectData item in projectsoInBT)
                {
                    projects.Add(new ProjectData(item.name)
                    {
                        Id = item.id,
                        Name = item.name
                    });
                }
                return projects;

            }
        }

        public void CreateNewProject(AccountData account, ProjectData project)
        {
            Mantis.MantisConnectPortTypeClient client = new Mantis.MantisConnectPortTypeClient();
            Mantis.ProjectData projectCreation = new Mantis.ProjectData();
            projectCreation.name = project.Name;

            client.mc_project_add(account.Name, account.Password, projectCreation);
        }
        /*public List<ProjectData> GetProjects()
        {
            List<ProjectData> projects = new List<ProjectData>();
            manager.Navigator.GoToControlProject();
            ICollection<IWebElement> elements = driver.FindElements(By.XPath("//tbody//tr//a"));
            foreach (IWebElement element in elements)
            {
                projects.Add(new ProjectData(element.Text));
            }

            return projects;

        }*/
    }
}

//http://localhost/mantisbt-2.26.0/api/soap/mantisconnect.php?wsdl