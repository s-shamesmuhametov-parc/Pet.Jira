﻿using Pet.Jira.Domain.Models.Issues;
using Pet.Jira.Domain.Models.Worklogs;
using System;

namespace Pet.Jira.Application.Worklogs.Dto
{
    internal class WorklogDto : IWorklog
    {
        public DateTime StartDate { get; set; }
        public DateTime CompleteDate { get; set; }
        public TimeSpan TimeSpent { get; set; }
        public IIssue Issue { get; set; }
        public string Author { get; set; }
    }
}
