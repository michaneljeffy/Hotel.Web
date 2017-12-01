using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Quartz;

namespace Hotel.Web.Job
{
    public class CrawlerIndexJob:IJob
    {
        private Action<int> JobFinished;

        public event Action<int> JobFinishedEvent
        {
            add
            {
                JobFinished = value;
            }

            remove
            {
                if (JobFinished != null)
                {
                    JobFinished -= value;
                }
            }
        }
        
        public void Execute(IJobExecutionContext context)
        {
            int id = 0;
            this.JobFinished(id);
        }
    }
}