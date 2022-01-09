using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Basic.Infrastructure.Entities
{
    public class Menu : Basic
    {
        [Key]
        public int MenuId { get; set; }
        public string MenuCode { get; set; }
        public string MenuName { get; set; }
        public Feature Feature { get; set; }
        public Menu ParentId { get; set; }
        public string LinkUrl { get; set; }
    }
}
