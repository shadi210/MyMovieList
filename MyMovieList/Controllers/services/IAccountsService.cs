using MyMovieList.Models;
namespace MyMovieList.Controllers.services
{
	public interface IAccountsService
	{
		Task<IEnumerable<users>> GetAll();
		users GetUser(string userEmail);
		void addUser(users user);
		void UpdateUser(String email, String pwd, String oldmail);
		void removeUser(string userEmail);
	}
}
