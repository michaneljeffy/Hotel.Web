using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel.Web.Job
{
    public class JobManage
    {
        public JobManage()
        {

        }

        public IJob GetJobInstance()
        {
            var job = new CrawlerIndexJob();
            var jobContext = new IJobExecutionContext();
            job.Execute();
            job.JobFinishedEvent += Job_JobFinishedEvent;
            return job;
        }

        private void Job_JobFinishedEvent(int obj)
        {
            throw new NotImplementedException();
        }
    }
}