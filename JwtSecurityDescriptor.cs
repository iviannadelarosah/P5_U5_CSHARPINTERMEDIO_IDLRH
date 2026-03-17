using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;

internal class JwtSecurityDescriptor
{
    public JwtSecurityDescriptor()
    {
    }

    public ClaimsIdentity Subject { get; internal set; }
    public DateTime Expires { get; internal set; }
    public SigningCredentials SigningCredentials { get; internal set; }
}