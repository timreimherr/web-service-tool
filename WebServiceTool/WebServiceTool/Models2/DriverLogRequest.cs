using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebServiceTool.Models2
{
    public class DriverLogRequest : Credentials
    {
        public string DriverID { get; set; }
        public string OrganizationID { get; set; }
        public string ResourceID { get; set; }
        public bool Edits { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Limit { get; set; }
        public int Offset { get; set; }
    }
}
