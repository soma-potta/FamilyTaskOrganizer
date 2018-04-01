using System;

namespace Family.TaskOrganizer.Api.Models
{
    public class FamilyMember
    {
        public Guid FamilyMemberId  { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
