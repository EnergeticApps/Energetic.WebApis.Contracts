namespace Energetic.WebApis.Contracts.Commands
{
    public class LoginCommand
    {
        public string EmailOrUsername { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;

        public bool RememberMe { get; set; }

        public string ReturnUrl { get; set; } = string.Empty;
    }
}