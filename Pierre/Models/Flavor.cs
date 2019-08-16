
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;


namespace Pierre.Models
{
    [Table("Flavors")]
    public class Flavor
    {
        [Key]
        public int FlavorId { get; set; }
        public string Description { get; set; }

        public virtual ApplicationUser User { get; set; }

        public ICollection<TreatFlavor> Treats { get; }


        public Flavor()
        {
            this.Treats = new HashSet<TreatFlavor>();
        }
    }

}









