using JuniorCodeTest.Models;

namespace JuniorCodeTest.Interfaces
{
	public interface IRandomUserApiService
	{
		Task<List<RequestedUsersModel>> GetRandomUserDataFromApi();
	}
}
