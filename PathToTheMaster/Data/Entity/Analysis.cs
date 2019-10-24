using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PathToTheMaster.Web.Data.Entity
{
    public class Analysis
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int AnalysisNormId { get; set; }
        public int GroupId { get; set; }

        [ForeignKey(nameof(AnalysisNormId))]
        public  virtual AnalysisNorm AnalysisNorm { get; set; }

        [ForeignKey(nameof(GroupId))]
        public virtual Group Group { get; set; }
    }
}
