using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngine
{
    public class CallWebService : IActivities
    {
        public void Execute()
        {
            Console.WriteLine("Calling web service...");
        }
    }
}
