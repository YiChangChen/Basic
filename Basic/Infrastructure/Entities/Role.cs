using System.ComponentModel.DataAnnotations;

namespace Basic.Infrastructure.Entities
{
    public class Role : Basic
    {
        [Key]
        public int RoleId { get; set; }
        public string RoleCode { get; set; }
        public string RoleName { get; set; }
        public bool IsActive { get; set; }
    }
}
