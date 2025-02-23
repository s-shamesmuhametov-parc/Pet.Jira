﻿using System;

namespace Pet.Jira.Application.Worklogs.Dto
{
    public class AddedWorklogDto
    {
        public DateTime StartedAt { get; set; }
        public TimeSpan ElapsedTime { get; set; }
        public string IssueKey { get; set; }
        public string Comment { get; set; } = "Dev";

        public static AddedWorklogDto Create(WorklogCollectionItem worklog)
        {
            return new AddedWorklogDto
            {
                StartedAt = worklog.StartDate,
                IssueKey = worklog.Issue.Key,
                ElapsedTime = worklog.TimeSpent
            };
        }
    }
}
