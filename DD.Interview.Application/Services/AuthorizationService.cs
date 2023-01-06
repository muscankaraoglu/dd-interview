using System;
using System.IdentityModel.Tokens.Jwt;
using System.Reflection;
using System.Security.Claims;
using System.Text;
using DD.Interview.Application.Abstractions;
using DD.Interview.Application.Abstractions.Repository;
using Microsoft.IdentityModel.Tokens;

namespace DD.Interview.Application.Services
{
	public class AuthorizationService : IAuthorizationService
	{
        private readonly IAuthorizationRepository _repository;

        public AuthorizationService(IAuthorizationRepository repository)
        {
            _repository = repository;
        }

        public string Authorize(string username, string password)
        {
            var result=  _repository.Authorize(username, password);

            JwtSecurityTokenHandler? tokenHandler = new();
            byte[]? key = Encoding.ASCII.GetBytes("12341234123412341234123412341234123412341234");
            SecurityTokenDescriptor? tokenDescriptor = new()
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                        new Claim(ClaimTypes.Name, username),
                        new Claim(ClaimTypes.Email, username)
                }),
                Expires = DateTime.UtcNow.AddDays(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature),
            };
            SecurityToken? token = tokenHandler.CreateToken(tokenDescriptor);
            string tokenResponse = tokenHandler.WriteToken(token);
            return tokenResponse;
        }
    }
}

