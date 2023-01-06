using Microsoft.AspNetCore.Mvc;

namespace Login_auth_tutorial.Models
{
    public class Login
    {
        [BindProperty]
        public Credential Credential { get; set; }
    }
}
