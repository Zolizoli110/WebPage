namespace WebApplication4.Models;

public partial class UserModel
{
    public UserModel(string email, string firstName, string lastName, bool isAdmin)
    {
        this.Email = email;
        this.FirstName = firstName;
        this.LastName = lastName;
        this.IsAdmin = isAdmin;
    }
    private string Email { get; }
    private string FirstName { get; }
    private string LastName { get; }
    private bool IsAdmin { get; }
    
}