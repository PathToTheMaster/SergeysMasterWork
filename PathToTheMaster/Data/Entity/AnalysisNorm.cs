using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PathToTheMaster.Web.Data.Entity
{
    public class AnalysisNorm
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int AgeStart { get; set; }
        public int AgeEnd { get; set; }
        public bool Sex { get; set; }

    }
}
