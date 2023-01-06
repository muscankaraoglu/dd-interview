using System;
namespace DD.Interview.Application.Abstractions
{
	public interface IAuthorizationService
	{
		string Authorize(string username, string password);
	}
}

