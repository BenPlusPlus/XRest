using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace XRest.Authentication
{
    public interface IOAuth2Authenticator
    {
        Task RefreshToken();
        OAuth2Token Token { get; }
    }
}

