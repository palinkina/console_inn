using System.Collections.Generic;
using System.Linq;
using mantis_tests.tests;
using NUnit.Framework;

namespace mantis_tests
{
    [TestFixture]
    public class ProjectRemoveTests : AuthentificationBase
    {
        [Test]
        public void ProjectRemovingTest()
        {

            List<ProjectData> projects = new List<ProjectData>();
            projects = app.Project.GetProjects();
            if (projects.Count == 0)
            {
                ProjectData newProject = new ProjectData("Project" + TestBase.GenerateRandomString(10));

                app.Navigator.GoToControlProject();
                app.Project.Create(newProject);
                projects = app.Project.GetProjects();
            }

            app.Project.Remove();
            List<ProjectData> newProjects = app.Project.GetProjects();
            Assert.AreEqual(projects.Count() - 1, newProjects.Count());
        }
    }
}