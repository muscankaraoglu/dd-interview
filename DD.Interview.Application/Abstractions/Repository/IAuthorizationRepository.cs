using System;
namespace DD.Interview.Application.Abstractions.Repository
{
	public interface IAuthorizationRepository
	{
        bool Authorize(string username, string password);
    }
}

