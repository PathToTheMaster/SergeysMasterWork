using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PathToTheMaster.Web.Data.Entity
{
    public class Laboratory
    {
        [Key]
        public int Id { get; set; }

        public int AddressesId { get; set; }

        [ForeignKey(nameof(AddressesId))]
        public virtual Addresses Addresses { get; set; }
    }
}
