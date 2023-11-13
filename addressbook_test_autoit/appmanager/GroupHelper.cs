using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using NUnit.Framework;
using System.Text;
using System.Net;
using AutoItX3Lib;
using System.Threading.Tasks;



namespace addressbook_test_autoit
{
    public class GroupHelper : HelperBase
    {
        public static string GROUPWINTITLE = "Group editor";
        public static string DELITEGROUPTITLE = "Delete group";
        public GroupHelper(ApplicationManager manager) : base(manager)
        {
           

        }
        public void Add(GroupData newGroup)
        {
            OpenGroupsDialogue();
            aux.ControlClick(GROUPWINTITLE, "", "WindowsForms10.BUTTON.app.0.2c908d53");
            aux.Send(newGroup.Name);
            aux.Send("{ENTER}");
            ClousGroupsDialogue();
            
        }
        public void Remove(GroupData newGroup)
        {
            OpenGroupsDialogue();
            //aux.Send("{END}");
            aux.ControlTreeView(GROUPWINTITLE, newGroup.Name, "WindowsForms10.SysTreeView32.app.0.2c908d51", "Select", "#0|#0", "");
            aux.ControlClick(GROUPWINTITLE, "", "WindowsForms10.BUTTON.app.0.2c908d51");
            aux.WinWait(DELITEGROUPTITLE);
            aux.ControlClick(DELITEGROUPTITLE, "", "WindowsForms10.BUTTON.app.0.2c908d53");
            //aux.ControlClick(DELITEGROUPTITLE, "", "WindowsForms10.BUTTON.app.0.2c908d53");
            ClousGroupsDialogue();
        }
        public void Modification(GroupData newGroup, int g)
        {

            OpenGroupsDialogue();
            aux.ControlTreeView(GROUPWINTITLE, "", "WindowsForms10.SysTreeView32.app.0.2c908d51", "Select", "#0|#"+ g, "");
            aux.ControlClick(GROUPWINTITLE, "", "WindowsForms10.BUTTON.app.0.2c908d52");
            aux.Send(newGroup.Name);
            aux.Send("{ENTER}");
            ClousGroupsDialogue();
        }
        private void ClousGroupsDialogue()
        {
            aux.ControlClick(GROUPWINTITLE, "", "WindowsForms10.BUTTON.app.0.2c908d54");
            aux.WinWait(WINTITLE);
          
        }

        private void OpenGroupsDialogue()
        {
            aux.ControlClick(WINTITLE, "", "WindowsForms10.BUTTON.app.0.2c908d512");
            aux.WinWait(GROUPWINTITLE);
        }




        public List<GroupData> GetGroupList()
        {
            List<GroupData> list = new List<GroupData>();
            OpenGroupsDialogue();
            string count = aux.ControlTreeView(GROUPWINTITLE, "", "WindowsForms10.SysTreeView32.app.0.2c908d51",
               "GetItemCount", "#0", "");//четвертый параметр - команда.
                                         //+ доп. параметр для команды. например путь либо порядковый нмоер. 6 параметр не нужон?
                                         // всегжда возвращает строку

            for (int i = 0; i < int.Parse(count); i++)// счетчик кол-в элементов 
            {
                string item = aux.ControlTreeView(GROUPWINTITLE, "", 
                    "WindowsForms10.SysTreeView32.app.0.2c908d51",
                "GetText", "#0|#" + i, "");
                list.Add(new GroupData()
                {
                    Name = item
                });
            }
            ClousGroupsDialogue();
            return list;
        }


    }
}