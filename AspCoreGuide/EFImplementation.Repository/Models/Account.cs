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
    [Table("account")]
    public class Account
    {
        [Key]
        public Guid AccountId { get; set; }

        [Required(ErrorMessage = "Date created is required")]
        public DateTime DateCreated { get; set; }

        [Required(ErrorMessage = "Account type is required")]
        public string AccountType { get; set; }

        [Required(ErrorMessage = "Owner Id is required")]
        public Guid OwnerId { get; set; }
    }
}