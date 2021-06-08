using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace SandboxJScalc.Models
{
    public class CommonInfo
    {
        public int Amount1 { get; set; }
        public int Amount2 { get; set; }
        public int TotalAmount { get; set; }
        public List<SelectList> MonthList { get; set; }
        public List<SelectList> YearList { get; set; }
        public string PeriodCoveredMonth { get; set; }
        public string PeriodCoveredYear { get; set; }
    }
}
