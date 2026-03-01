using Microsoft.AspNetCore.Identity;

namespace FarmManagement.UI.Web;

public class IdentitySeeder
{
    private readonly UserManager<IdentityUser> _userManager;

    public IdentitySeeder(UserManager<IdentityUser> userManager)
    {
        _userManager = userManager;
    }

    public void Seed()
    {
        var userEmails = new[] { "lars@kdg.be", "anna@kdg.be", "bob@kdg.be", "chef@kdg.be", "test@kdg.be" };

        foreach (var email in userEmails)
        {
            var user = new IdentityUser(email) { Email = email, EmailConfirmed = true };
    
           
            var result = _userManager.CreateAsync(user, "Password123!").GetAwaiter().GetResult();
        }
    }
}