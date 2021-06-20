using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Threading.Tasks;
using AspNetCore.Backend.Api.Infrastructure;
using AspNetCore.Backend.Api.ViewModels.Account;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace AspNetCore.Backend.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        [HttpPost]
        [Route("login")]
        public async Task<ActionResult<LoginResponseModel>> Login([FromBody] LoginRequestModel model)
        {
            var identity = await GetIdentity(model.Email, model.Password);
            if (identity == null)
            {
                return new BadRequestResult();
            }

            var now = DateTime.UtcNow;

            var jwt = new JwtSecurityToken(
                issuer: JwtAuthOptions.Issuer,
                audience: JwtAuthOptions.Audience,
                notBefore: now,
                claims: identity.Claims,
                expires: now.Add(TimeSpan.FromMinutes(JwtAuthOptions.Lifetime)),
                signingCredentials: new SigningCredentials(JwtAuthOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256));
            var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);

            return new LoginResponseModel
            {
                AccessToken = encodedJwt
            };
        }

        [HttpPost]
        [Route("add")]
        public async Task<ActionResult<CreateUserResponseModel>> Add(CreateUserRequestModel model)
        {
            var responseModel = new CreateUserResponseModel
            {
                Id = 1
            };
            return await Task.FromResult(responseModel);
        }

        private async Task<ClaimsIdentity> GetIdentity(string email, string password)
        {
            var user = new
            {
                Email = email,
                Id = 1
            };

            var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Email, user.Email),
                    new Claim(ClaimTypes.Role, "User"),
                    new Claim(ClaimTypes.Sid, user.Id.ToString())
                };
            var claimsIdentity = new ClaimsIdentity(claims, "Token");
            return await Task.FromResult(claimsIdentity);
        }
    }
}
