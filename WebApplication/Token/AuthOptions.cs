using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace WebApplication.Token
{
  public class AuthOptions
  {
    public const string ISSUER = "MyAuthServer";
    public const string AUDIENCE = "MyAuthClient";
    const string KEY = "mysupersecret_secretkey!123";
    public const int LifeTime = 60;

    public static SymmetricSecurityKey GetSymmetricSecurityKey()
    {
      return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(KEY));
    }
  }
}