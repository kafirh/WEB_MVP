using System.ComponentModel.DataAnnotations;

namespace Template_web.Core.Entities
{
    public class UserRoleModel
    {
        [Key]
        public int Id { get; set; }
        public required string UserNik { get; set; }
        public required string RoleId { get; set; }
    }
}