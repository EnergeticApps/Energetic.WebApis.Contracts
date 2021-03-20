using System.Collections.Generic;
using System.Linq;

namespace Serious.Dtos
{
    public class LoginDto : LoginInputDto
    {
        public bool AllowRememberLogin { get; set; } = true;
        public bool EnableLocalLogin { get; set; } = true;

        public IEnumerable<ExternalAuthenticationProviderDto> ExternalProviders { get; set; } = Enumerable.Empty<ExternalAuthenticationProviderDto>();
        public IEnumerable<ExternalAuthenticationProviderDto> VisibleExternalProviders => ExternalProviders.Where(x => !string.IsNullOrWhiteSpace(x.DisplayName));

        public bool HasSingleExternalLoginOnly => EnableLocalLogin == false && ExternalProviders?.Count() == 1;
        public string? ExternalLoginScheme => HasSingleExternalLoginOnly ? ExternalProviders?.SingleOrDefault()?.AuthenticationScheme : null;
    }
}