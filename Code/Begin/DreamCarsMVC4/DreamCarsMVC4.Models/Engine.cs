using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DreamCarsMVC4.Models {

    public class Engine {

        public long EngineId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Cylinders")]
        public int NumberOfCylinders { get; set; }

        [Required]
        public decimal Liters { get; set; }

        [Required]
        [Display(Name = "BHP")]
        public long BreakHorsepower { get; set; }

        #region << Navigation Properties >>

        [Display(Name = "Available Models")]
        public virtual IList<Model> AvailableOn { get; set; }

        #endregion
    }
}