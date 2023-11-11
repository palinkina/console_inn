using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace addressbook_test_autoit
{
    public class GroupModificationTests : TestBase
    {
        [Test]
        public void GroupModificationTest()
        {
            List<GroupData> oldGroups = app.Groups.GetGroupList();
            //GroupData group = oldGroups[0];
            GroupData group = new GroupData()
            {
                Name = "new_test"
            };
            app.Groups.Modification(group, 0);

            List<GroupData> newGroups = app.Groups.GetGroupList();
            oldGroups[0].Name = group.Name;
            //oldGroups.Add(newGroup);
            oldGroups.Sort();
            newGroups.Sort();
            Assert.AreEqual(oldGroups.Count, newGroups.Count);
        }
    }
}
