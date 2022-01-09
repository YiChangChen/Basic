using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Basic.Infrastructure.Entities
{
    public class FeatureGroup : Basic
    {
        [Key]
        public int FeatureGroupId { get; set; }
        public string FeatureGroupName { get; set; }
        public bool IsActive { get; set; }
    }
}
