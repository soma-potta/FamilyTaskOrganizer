using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace Family.TaskOrganizer.Api.Models
{
    [BsonIgnoreExtraElements]
    public class Board
    {
        public Guid BoardId { get; set; }
        public string Name { get; set; }
        public List<string> FamilyMembers { get; set; }
        public List<WorkItem> WorkItems { get; set; }
    }
}
