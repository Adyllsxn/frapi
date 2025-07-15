namespace frapi.Source.Core.Model;
public class PrivateUserModel
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required(ErrorMessage = "Name is required")]
    [StringLength(100, ErrorMessage = "Name can't be longer than 100 characters")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Invalid email format")]
    [StringLength(150, ErrorMessage = "Email can't be longer than 150 characters")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "password is required")]
    [StringLength(100, ErrorMessage = "password can't be longer than 50 characters")]
    public string PasswordHash { get; set; } = string.Empty;
}
