/*using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace mantis_tests
{
    /// <summary>
    /// Сводное описание для AccountCreationTests
    /// </summary>
    [TestFixture]
    public class AccountCreationTests : TestBase
    {

        [TestFixtureSetUp] // выполнился один раз для всех тестовых методов в этом классе   
        public void setUpConfig()
        {
            app.Ftp.BackupFile("/config_inc.php");
            using (Stream localFile = File.Open("config_inc.php", FileMode.Open))
            {
                app.Ftp.Upload("/config_inc.php", localFile);
            }
        }

        [Test]
        public void AccountRegistrastionTest()
        {
            AccountData acount = new AccountData
            {
                Name = "testuser",
                Password = "password",
                Email = "testuser@localhost.localdomein"
            };
            app.Registration.Register(acount);
        }
        [TearDown]
        public void restoreConfig() // воостановить конф. файл "припрятанный" в самом начале 
        {
            app.Ftp.RestoreBackupFile("/config_inc.php");
        }
    }
}
*/