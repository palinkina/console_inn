using mantis_tests.Mantis;
using NUnit.Framework;
using System;
namespace mantis_tests
{
    [TestFixture]
    public class AddNewIssueTests : TestBase
    {
        [Test]
        public void AddNewIssue()
        {
            AccountData account = new AccountData()
            {
                Name = "administrator",
                Password = "root"
            };
            ProjectData project = new ProjectData()
            {
                Name = "Project!%)'!%",

            };
            IssueData issue = new IssueData()
            {
                Summary = "some short",
                Description = "some long",
                Category = "General",
            };
            app.Registration.Login(account);
            app.API.CreateNewIssue(account, project, issue);
        }
    }
}
