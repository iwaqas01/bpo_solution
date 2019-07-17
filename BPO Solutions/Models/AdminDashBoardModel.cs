using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BPO_Solutions.Models
{
    public class AdminDashBoardModel
    {
        public int Products { get; set; }

        public int NewUsers { get; set; }

        public int leads { get; set; }

        public int expense { get; set; }


        public int salariespadithismonth { get; set; }

        public int salariespadilastmonth { get; set; }

        public IEnumerable<Leads> _recentLeads { get; set; }

        public IEnumerable<LeadJoinModel> _last3leads { get; set; }

        public int totalexpensethismonth { get; set; }

        public int totalexpenselastmonth { get; set; }

        public IEnumerable<Employee> _employees { get; set; }


    }
}