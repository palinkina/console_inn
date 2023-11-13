using System.Collections.Generic;
using System.Linq;
using mantis_tests.tests;
using NUnit.Framework;
//
namespace mantis_tests
{
    [TestFixture]
    public class ProjectRemoveTests : AuthentificationBase
    {
        [Test]
        public void ProjectRemovingTest()
        {
            AccountData account = new AccountData()
            {
                Name = "administrator",
                Password = "root"
            };
            

            ProjectData project = new ProjectData("")
            {
                Name = "Project" + TestBase.GenerateRandomString(10)
            };

            List<ProjectData> oldProjects = app.API.GetProjects(account);
            //ProjectData toBeRemoved = oldProjects[1];

            if (oldProjects.Count == 0)
            {
                
                 
                    app.API.CreateNewProject(account, project);

                oldProjects.Add(project);
                //oldProjects.Add(project);
            }
            {
                app.Navigator.GoToControlProject();
                app.Project.Remove(0);
            }


            
            
            
            List<ProjectData> newProjects = app.API.GetProjects(account);
            Assert.AreEqual(oldProjects.Count() -1 , newProjects.Count());
        }
    }
}