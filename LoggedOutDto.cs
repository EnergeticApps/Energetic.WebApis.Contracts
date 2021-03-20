



namespace Serious.WebApis.Contracts
{
    public class LoggedOutResponse
    {
        public string PostLogoutRedirectUri { get; set; }
        public string ClientName { get; set; }
        public string SignOutIframeUrl { get; set; }

        public bool AutomaticRedirectAfterSignOut { get; set; } = false;

        public string LogoutId { get; set; }
        public bool TriggerExternalSignout => ExternalAuthenticationScheme is { };
        public string ExternalAuthenticationScheme { get; set; }
    }
}