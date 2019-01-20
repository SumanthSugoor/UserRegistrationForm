namespace UserRegistrationForm.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.ComponentModel;

    public partial class MAS_USER
    {
        [Key]
        public int UserId { get; set; }


        [Required(ErrorMessage = "This field is required")]
        [StringLength(50)]
        public string UserName { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [StringLength(50)]
        public string Password { get; set; }

        [Compare("Password")]
        [DisplayName("Confirm Password")]
        [StringLength(50)]
        public string ConfirmPassword { get; set; }

        public bool IsAdmin { get; set; }
    }
}
