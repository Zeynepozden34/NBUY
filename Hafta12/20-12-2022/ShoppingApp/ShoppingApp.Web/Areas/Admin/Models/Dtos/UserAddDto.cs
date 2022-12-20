using ShoppingApp.Entity.Concrete.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace ShoppingApp.Web.Areas.Admin.Models.Dtos
{
    public class UserAddDto
    {
        public UserDto UserDto { get; set; }
        public List<RoleDto> Roles { get; set; }

        [DisplayName("Rol")]
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        public IList<string> SelectedRoles { get; set; }

    }
}
