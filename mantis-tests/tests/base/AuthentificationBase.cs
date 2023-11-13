using mantis_tests;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
namespace mantis_tests.tests
{
    public class AuthentificationBase : TestBase
    {
        [SetUp]
        public void SetupLogin()
        {

            app.Registration.Login(new AccountData("administrator", "root"));

            //тесты для которых логин не требуетися будут наследоваться от testbase
        }
    }
}


