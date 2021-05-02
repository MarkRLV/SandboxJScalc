using System.ComponentModel.DataAnnotations;

namespace SandboxJScalc.Models
{
    public class CommonInfo
    {
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)] 
        public decimal Amount1 { get; set; }
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public decimal Amount2 { get; set; }
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public decimal TotalAmount { get; set; }
    }
}
