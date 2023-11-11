using System;
using System.Collections.Generic;
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace addressbook_test_autoit
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
        [Test]
        public void TestGroupCreation()
        {
            List<GroupData> oldGroups = app.Groups.GetGroupList(); //запоменили старый список 
            GroupData newGroup = new GroupData()
            {
                Name = "test"
            };
            app.Groups.Add(newGroup);
            List<GroupData> newGroups = app.Groups.GetGroupList(); // получаев новый списк 
            oldGroups.Sort();
            newGroups.Sort();

            Assert.AreEqual(oldGroups, newGroups);

        }
    }
}
