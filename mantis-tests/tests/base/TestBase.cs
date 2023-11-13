using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System;
using System.Text;
//

namespace mantis_tests

{
    public class TestBase 
    {
        public static bool PERFORM_LONG_UI_CHECS = true;// если хотим, чтобы тесты работали быстрее , тогда false
        protected ApplicationManager app;


        [TestFixtureSetUp]
        public void SetupApplicationManager()
        {

            app = ApplicationManager.GetInstance();

        }


        public static Random rnd = new Random();
        public static string GenerateRandomString(int max)
        {
            Random rnd = new Random();
            int l = Convert.ToInt32(rnd.NextDouble() * max);
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < l; i++)
            {
                builder.Append(Convert.ToChar(32 + Convert.ToInt32(rnd.NextDouble() * 10)));
            }
            return builder.ToString();
        }
    }
}


