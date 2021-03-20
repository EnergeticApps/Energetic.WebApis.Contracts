namespace Energetic.WebApis.Contracts.Responses
{
    public class AuthenticationProvidersResponse
    {
        public AuthenticationProvidersResponse(
            bool canLoginWithFacebook = false,
            bool canLoginWithGithub = false,
            bool canLoginWithGoogle = false,
            bool canLoginWithLinkedIn = false,
            bool canLoginWithMicrosoft = false,
            bool canLoginWithTwitter = false)
        {
            FacebookEnabled = canLoginWithFacebook;
            GithubEnabled = canLoginWithGithub;
            GoogleEnabled = canLoginWithGoogle;
            LinkedInEnabled = canLoginWithLinkedIn;
            MicrosoftEnabled = canLoginWithMicrosoft;
            TwitterEnabled = canLoginWithTwitter;
        }
        public bool FacebookEnabled { get; set; }

        public bool GithubEnabled { get; set; }

        public bool GoogleEnabled { get; set; }

        public bool LinkedInEnabled { get; set; }

        public bool MicrosoftEnabled { get; set; }

        public bool TwitterEnabled { get; set; }
    }
}
