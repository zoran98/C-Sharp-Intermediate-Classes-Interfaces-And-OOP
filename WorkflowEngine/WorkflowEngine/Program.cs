using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            var workflow = new WorkflowEngine();
            workflow.RegisterActivity(new Upload());
            workflow.RegisterActivity(new CallWebService());
            workflow.RegisterActivity(new SendMailNotification());
            workflow.RegisterActivity(new StatusChange());
            workflow.Run();
        }
    }
}
