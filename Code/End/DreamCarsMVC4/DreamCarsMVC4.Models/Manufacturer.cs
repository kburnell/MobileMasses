using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DreamCarsMVC4.Models {

    public class Manufacturer {

        public long ManufacturerId { get; set; }

        [Required]
        [StringLength(40)]
        public string Name { get; set; }

        [Required]
        [StringLength(40)]
        public string Country { get; set; }

        [Required, StringLength(50)]
        public string Image { get; set; }

        #region << Navigation Properties >>

        public virtual IList<Model> Models { get; set; }

        #endregion
    }
}