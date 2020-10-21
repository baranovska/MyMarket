using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyMarket.Domain.Entities
{
    public class ServiceItem : EntityBase
    {
        [Required(ErrorMessage = "Enter the name of the store")]

        [Display(Name = "Name of the store")]
        public override string Title { get; set; }

        [Display(Name = "Hours of work")]
        public override string Subtitle { get; set; }

        [Display(Name = "Full description of the store")]
        public override string Text { get; set; }
    }
}
