using System;

namespace Family.TaskOrganizer.Api.Models
{
    public class WorkItem
    {
        public Guid TaskId { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public string AssignedTo { get; set; }
        public Status Status { get; set; }
    }
}
