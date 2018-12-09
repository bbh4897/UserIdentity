using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using UserIdentity.Identity;

namespace UserIdentity.Models
{
    public class Register
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }


    public class LoginModel
    {
        [Required]
        public string UserName { get; set; }
       
        [Required]
        public string Password { get; set; }
    }


    public class RoleEditModel
    {
        public IdentityRole Role { get; set; }
        public IEnumerable<AppIdentityUser> Members { get; set; }
        public IEnumerable<AppIdentityUser> NonMembers { get; set; }
    }


    public class RoleUpdateModel
    {
        public string RoleName { get; set; }
        public string RoleID { get; set; }
        public string[] IdsToAdd { get; set; }
        public string[] IdsToDelete { get; set; }
    }


}