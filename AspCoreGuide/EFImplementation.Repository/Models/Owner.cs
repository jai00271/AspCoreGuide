namespace EFImplementation.Repository.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// there are two models decorated with the attribute Table(“tableName”). 
    /// This attribute will configure the corresponding table name in the database. 
    /// Also, every primary key has the decoration attribute Key that configures primary key of the table. 
    /// All the mandatory fields have the attribute [Required] and if you want to constrain the strings, 
    /// you can use the attribute [StringLength].
    /// </summary>
    [Table("owner")]
    public class Owner
    {
        [Key]
        public Guid OwnerId { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(60, ErrorMessage = "Name can't be longer than 60 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Date of birth is required")]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Address is required")]
        [StringLength(100, ErrorMessage = "Address cannot be loner then 100 characters")]
        public string Address { get; set; }
    }
}