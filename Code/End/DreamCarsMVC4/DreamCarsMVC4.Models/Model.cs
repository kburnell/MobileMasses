using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DreamCarsMVC4.Models.Enumerations;

namespace DreamCarsMVC4.Models {

    public class Model {

        public long ModelId { get; set; }

        [Required,StringLength(50)]
        public string Name { get; set; }

        [Required]
        public int Year { get; set; }

        [Required, Display(Name="Base Price"), DataType(DataType.Currency)]
        public decimal BasePrice { get; set; }

        public long EngineLocationTypeId { get; set; }

        [Display(Name = "Engine Location")]
        public EngineLocationType EngineLocation {
            get { return (EngineLocationType)EngineLocationTypeId; } 
            set { EngineLocationTypeId = (long) value; }
        }

        [Required, StringLength(50)]
        public string Image { get; set; }

        #region << Navigation Properties >>

        public long ManufacturerId { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }

        [Display(Name = "Engines")]
        public virtual IList<Engine> AvailableEngines { get; set; }

        #endregion
    }
}