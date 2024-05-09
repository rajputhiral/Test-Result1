using JuniorCodeTest.Interfaces;
using JuniorCodeTest.Models;

using Microsoft.AspNetCore.Components;


namespace JuniorCodeTest.Components.Pages
{
	public partial class Home : ComponentBase
	{
		public List<RequestedUsersModel> RandomUsers { get; set; } = [];

		[Inject]
		private IRandomUserApiService? RandomUserApiService { get; set; }


		protected override async Task OnInitializedAsync()
		{
			await base.OnInitializedAsync();

			try
			{
				await PopulateUserList();
			}
			catch (Exception ex)
			{

			}
		}

		async Task PopulateUserList()
		{
			var users = await RandomUserApiService.GetRandomUserDataFromApi();
			RandomUsers.AddRange(users);
		}
	}
}
