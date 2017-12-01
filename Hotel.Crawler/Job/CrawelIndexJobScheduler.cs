using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.Crawler.Job;

namespace Hotel.Crawler.Job
{
    public class CrawelIndexJobScheduler
    {
        public static void Start()
        {
            IScheduler scheduler = StdSchedulerFactory.GetDefaultScheduler();
            scheduler.Start();
            IJobDetail job = JobBuilder.Create<CrawlerIndexJob>().Build();
            ITrigger trigger = TriggerBuilder.Create()
              .WithIdentity("triggerName", "groupName")
              .WithSimpleSchedule(t =>
                t.WithIntervalInSeconds(5)
                 .RepeatForever())
                 .Build();
            
            scheduler.ScheduleJob(job, trigger);
        }
    }
}
