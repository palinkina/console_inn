using mantis_tests.Mantis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mantis_tests
{
    public class APIHelper : HelperBase
    {
        public APIHelper(ApplicationManager manager) : base(manager)
        {
        }

        public void CreateNewIssue(AccountData account, ProjectData project, IssueData issueData)
        {
            Mantis.MantisConnectPortTypeClient client = new Mantis.MantisConnectPortTypeClient();// объект, через который можно обращатсья к операциям
            Mantis.IssueData issue = new Mantis.IssueData();//создали обязательный параметр для mc_issue_add
            issue.summary = issueData.Summary; // текст
            issue.description = issueData.Description; //текст
            issue.category = issueData.Category;
            issue.project = new Mantis.ObjectRef();//поле issue.project имеет тип ObjectRef, поэтому создали
            issue.project.Id = project.Id;
            client.mc_issue_add(account.Name, account.Password, issue);//вызываем нужный метод 
        }
    }
}

//http://localhost/mantisbt-2.26.0/api/soap/mantisconnect.php?wsdl