using System.ComponentModel.DataAnnotations;

namespace Template_web.Core.Entities
{
    public class RoleModel
    {
        [Key]
        public required string Id { get; set; }
        required public string Name { get; set; }
    }
}