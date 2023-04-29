using PodkarpackiLekarz.Shared.Identity;

namespace PodkarpackiLekarz.Core.Users;
public abstract class UserBase
{
    public Guid Id { get; private set; }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string Email { get; private set; }
    public string Password { get; private set; }
    public Role Role { get; private set; }

    public UserBase(
        Guid id,
        string firstName,
        string lastName,
        string email,        
        Role role)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Email = email;        
        Role = role;
    }

    public UserBase()
    {

    }

    public void SetPassword(string password)
    {
        Password = password;
    }
}
