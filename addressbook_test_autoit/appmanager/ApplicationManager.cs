using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using AutoItX3Lib;

namespace addressbook_test_autoit
{
    public class ApplicationManager
    {
        public static string WINTITLE = "Free Address Book";// константа для названия окна
        private AutoItX3 aux;
        private GroupHelper groupHelper;
        public ApplicationManager()

        {
            aux = new AutoItX3();
            aux.Run(@"C:\Users\palin\source\repos\addressbook\AddressBook.exe", "", aux.SW_SHOW); //два последних необязательно, но если пользовательскитй последняя обязательно и константа
            aux.WinWait(WINTITLE);
            aux.WinActivate(WINTITLE);
            aux.WinWaitActive(WINTITLE);
            groupHelper = new GroupHelper(this); // this ссылка на AM, чтобы GH мог обращаться к АМ и др. помощщникам
        }

        public void Stop()
        {
            aux.ControlClick(WINTITLE, "", "WindowsForms10.BUTTON.app.0.2c908d510"); //название окна, текс кнопки(необязательный), идентификатор кнопки (локатор) 
        }


        public AutoItX3 Aux
        {
            get
            {
                return aux;
            }
        }

        public GroupHelper Groups
        {
            get
            {
                return groupHelper;
            }
        }
    }
}
