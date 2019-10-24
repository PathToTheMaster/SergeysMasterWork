using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PathToTheMaster.Web.Data.Entity
{
    public class Addresses
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int CityId { get; set; }

        [ForeignKey(nameof(CityId))]
        public virtual City City { get; set; }
    }
}
