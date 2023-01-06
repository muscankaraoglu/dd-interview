using System;
using DD.Interview.Application.Abstractions.Repository;
using DD.Interview.Data.Context;
using DD.Interview.Data.Repository;
using DD.Interview.Domain.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DD.Interview.Data
{
    public static class DataRegistration
    {
        public static void AddDatabase(this IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options => { options.UseInMemoryDatabase("DDInterview"); });
            services.AddScoped<IAuthorizationRepository, AuthorizationRepository>();
        }
    }
}

