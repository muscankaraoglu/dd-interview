using System;
using DD.Interview.Application.Abstractions.Repository;
using DD.Interview.Data.Context;
using DD.Interview.Domain.Users;
using Microsoft.AspNetCore.Identity;

namespace DD.Interview.Data.Repository
{
    public class AuthorizationRepository : IAuthorizationRepository
    {
        private readonly SignInManager<User> _signInManager;

        public AuthorizationRepository(SignInManager<User> context)
        {
            _signInManager = context;
        }

        public bool Authorize(string username, string password)
        {
            return _signInManager.PasswordSignInAsync(username, password, false, false).Result.Succeeded;
        }
    }
}

