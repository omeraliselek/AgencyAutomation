using CastAutomation.MODEL.ORM.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastAutomation.MODEL.ORM.Entity
{
    public class AppUser:BaseEntity
    {
      
        public string FirstName { get; set; }
        public string LastName { get; set; }
 public DateTime DateOfBirth { get; set; }
     public string job { get; set; }
        public string Size { get; set; }
        public string Weight { get; set; }
        public string Biography { get; set; }
        public string MobilPhone { get; set; }
        public string HomePhone { get; set; }
        public string jobPhone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string instagram { get; set; }
        public string Website { get; set; }
}
}
