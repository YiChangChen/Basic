using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Basic.Infrastructure.Entities
{
    public class Feature : Basic
    {
        [Key]
        public int FeatureId { get; set; }
        public string FeatureCode { get; set; }
        public string FeatureName { get; set; }
        public bool IsActive { get; set; }
        public FeatureGroup FeatureGroup { get; set; }
    }
}
