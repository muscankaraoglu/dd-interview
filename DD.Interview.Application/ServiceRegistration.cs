using System;
using DD.Interview.Application.Abstractions;
using DD.Interview.Application.Services;
using Microsoft.Extensions.DependencyInjection;
namespace DD.Interview.Application
{
	public static class ServiceRegistration
	{
		public static void AddApplicationServices(this IServiceCollection services)
		{
			services.AddScoped<IAuthorizationService, AuthorizationService>();
		}
	}
}

