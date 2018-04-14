using System;
using System.Collections.Generic;

namespace Family.TaskOrganizer.Api.Models
{
    public class Board
    {
        public Guid BoardId { get; set; }
        public string Name { get; set; }
        public List<string> FamilyMembers { get; set; }
        public List<WorkItem> WorkItems { get; set; }
    }
}
