namespace LabSimulation.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web.Mvc;

    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            Favorites = new HashSet<Favorite>();
        }

        public int ID { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name is Required")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z'\s]*$", ErrorMessage = "Characters only, start capital letter")]
        [StringLength(25, ErrorMessage = "Must be between 3 to 25 characters", MinimumLength = 3)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name is Required")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z'\s]*$", ErrorMessage = "Characters only, start capital letter")]
        [StringLength(25, ErrorMessage = "Must be between 3 to 25 characters", MinimumLength = 3)]
        public string LastName { get; set; }

        public string SchoolName { get; set; }

        [Display(Name = "User Name")]
        [Required(ErrorMessage = "User Name is Required")]
        [StringLength(50, ErrorMessage = "Must be between 3 to 30 characters", MinimumLength = 3)]
        [Remote("IsUserNameAvailable", "Users", AdditionalFields = "ID", ErrorMessage = "This User Name has been already exist", HttpMethod = "POST")]
        public string UserName { get; set; }

        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "Email is Required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [Remote("IsEmailAvailable", "Users", AdditionalFields = "ID", ErrorMessage = "This Email has been already exist", HttpMethod = "POST")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        [StringLength(38, ErrorMessage = "Must be between 5 and 38 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[@!#$%^&*+/._=]).{5,38}$", ErrorMessage = "Must be between 5 and 38 characters , contain capital letter , small letter , digit and special character(@!#$%^&*+/._= )")]
        public string Password { get; set; }

        public byte[] Image { get; set; }

        public bool IsConfirm { get; set; }

        public bool IsPremiumAccount { get; set; }

        public int? SchoolID { get; set; }

        public int? UserTypeID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Favorite> Favorites { get; set; }

        public virtual UserTypeAccount UserTypeAccount { get; set; }
    }
}
