using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngine
{
    public class SendMailNotification : IActivities
    {
        public void Execute()
        {
            Console.WriteLine("Sending mail notifications...");
        }
    }
}
