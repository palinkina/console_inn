using System.Collections.Generic;
using System.ComponentModel;
using mantis_tests.tests;
using NUnit.Framework;
namespace mantis_tests
//
{
    [TestFixture]
    public class ProjectCreationTests : AuthentificationBase
    {
        [Test]
        public void ProjectCreationTest()
        {


            AccountData account = new AccountData()
            {
                Name = "administrator",
                Password = "root"
            };
            List<ProjectData> oldProjects = app.API.GetProjects(account);
            ProjectData project = new ProjectData("")
            {
                Name = "Project" + TestBase.GenerateRandomString(10)
            };
            // app.Navigator.GoToControlProject();
            app.API.CreateNewProject(account, project);
            List<ProjectData> newProjects = app.API.GetProjects(account);
            oldProjects.Add(project);
            oldProjects.Sort();
            newProjects.Sort();
            Assert.AreEqual(oldProjects, newProjects);
        }
    }
}
            

        
    



