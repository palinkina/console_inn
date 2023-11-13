using System.Collections.Generic;
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

            List<ProjectData> projects = new List<ProjectData>();
            projects = app.Project.GetProjects();


            ProjectData project = new ProjectData
            { Name = "Project" + TestBase.GenerateRandomString(10)
            };


            app.Navigator.GoToControlProject();
            app.Project.Create(project);
            List<ProjectData> newProjects = app.Project.GetProjects();
            projects.Add(project);
            projects.Sort();
            newProjects.Sort();
            Assert.AreEqual(projects, newProjects);
        }
    }
}