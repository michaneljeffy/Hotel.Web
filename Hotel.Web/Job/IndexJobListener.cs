using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Quartz;

namespace Hotel.Web.Job
{
    public class IndexJobListener : IJobListener
    {
        public string Name => throw new NotImplementedException();

        public virtual void JobExecutionVetoed(IJobExecutionContext context)
        {
            throw new NotImplementedException();
        }

        public virtual void JobToBeExecuted(IJobExecutionContext context)
        {
            throw new NotImplementedException();
        }

        public virtual void JobWasExecuted(IJobExecutionContext context, JobExecutionException jobException)
        {
            context.Scheduler.PauseAll();
        }
    }
}