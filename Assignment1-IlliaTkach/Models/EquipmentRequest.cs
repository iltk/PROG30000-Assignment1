using System.ComponentModel.DataAnnotations;

namespace Assignment1_IlliaTkach.Models;

public class EquipmentRequest
{

    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;

    [Required]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;

    [Required]
    [RegularExpression(@"^\d{3}-\d{3}-\d{4}$", ErrorMessage = "Phone number must match the format xxx-xxx-xxxx (e.g., 905-922-2222).")]
    [Display(Name = "Phone Number ")]
    public string PhoneNumber { get; set; } = string.Empty;

    [Required]
    [Display(Name = "Role Type ")]
    public RoleType? RoleType { get; set; } 
    
    [Required]
    [Display(Name = "Equipment Type ")]
    public EquipmentType? EquipmentType { get; set; } 
    
    [Required]
    [Display(Name = "Request Details")]
    public string RequestDetails { get; set; } = string.Empty;

    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "Duration must be a positive number greater than zero.")]
    public int Duration { get; set; }

}