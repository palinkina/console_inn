using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System;
using System.Threading;
using mantis_tests.appmanager;
using System.Text;
using mantis_tests.tests;
//using OpenQA.Selenium.DevTools.V117.Audits;

namespace mantis_tests
{
    public class ApplicationManager
    {
        protected IWebDriver driver;
        protected string baseURL;

        protected ProjectHelper projectHelper;
        private static ThreadLocal<ApplicationManager> app = new ThreadLocal<ApplicationManager>();



        

        private ApplicationManager()
        {
            driver = new FirefoxDriver();
            baseURL = "http://localhost/mantisbt-1.3.20/login_page.php";
            //verificationErrors = new StringBuilder();
            Registration = new RegistrationHelper(this);

            Project = new ProjectHelper(this);
            Registration = new RegistrationHelper(this);
            Navigator = new NavigationHelper(this);
            Ftp = new FtpHelper(this);
            API = new APIHelper(this);

        }
        ~ApplicationManager()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }


        public static ApplicationManager GetInstance()
        {
            if (! app.IsValueCreated)
            {
                ApplicationManager newInstance = new ApplicationManager();
                newInstance.driver.Url = "http://localhost/mantisbt-2.26.0/login_page.php";
                app.Value = newInstance;
            }
            return app.Value;
        }
        public IWebDriver Driver
        {
            get
            {
                return driver;
            }
        }

        public object ContactHelp { get;  set; }
        public RegistrationHelper Registration { get; set; }
        public FtpHelper Ftp { get; set; }
        public NavigationHelper Navigator { get; set; }
        public ProjectHelper Project { get; set; }
        public  APIHelper  API { get;  set; }

    }
}
