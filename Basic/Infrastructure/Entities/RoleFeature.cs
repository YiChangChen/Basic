using System.ComponentModel.DataAnnotations;

namespace Basic.Infrastructure.Entities
{
    public class RoleFeature : Basic
    {
        [Key]
        public int RoleFeatureId { get; set; }
        public Role Role { get; set; }
        public Feature Feature { get; set; }
    }
}
