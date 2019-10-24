using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PathToTheMaster.Web.Data.Entity
{
    public class Package
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public int AnalysisId { get; set; }

        [ForeignKey(nameof(AnalysisId))]
        public virtual Analysis Analysis { get; set; }
    }
}
