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
            GroupData newG = new GroupData()
            {
                Name = "test"
            };

            List<GroupData> oldGroups = app.Groups.GetGroupList();
            
           
            app.Groups.Add(newG);

            List<GroupData> newGroups = app.Groups.GetGroupList();
            //oldGroups.Add(newG);
            oldGroups.Sort();
            newGroups.Sort();
            Assert.AreEqual(oldGroups.Count + 1, newGroups.Count);
            //Assert.AreEqual(oldGroups, newGroups);
        }
    }
}
