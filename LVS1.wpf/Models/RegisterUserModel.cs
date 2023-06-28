using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Security;
using System.Text.RegularExpressions;
using CommunityToolkit.Mvvm.ComponentModel;

namespace LVS1.wpf.Models.Validators;

public class RegisterUserModel : ObservableValidator
{
    [Required, MinLength(4)]
    public string FirstName { get; set; }
    [Required, MinLength(4)]
    public string Surname { get; set; }
    [Required, EmailAddress, MinLength(4), MaxLength(256)]
    public string Email { get; set; }
    [Required, MinLength(5), MaxLength(256), PasswordPropertyText]
    public string Password { get; set; }
}