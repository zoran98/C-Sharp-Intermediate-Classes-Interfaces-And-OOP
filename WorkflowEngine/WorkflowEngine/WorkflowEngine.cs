using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngine
{
    public class WorkflowEngine
    {

        public readonly IList<IActivities> _activities;

        public WorkflowEngine()
        {
            _activities = new List<IActivities>();
        }

        public void RegisterActivity(IActivities activity)
        {
            _activities.Add(activity);
        }

        public void Run()
        {
            foreach (var activity in _activities)
            {
                activity.Execute();
            }
        }
    }
}
