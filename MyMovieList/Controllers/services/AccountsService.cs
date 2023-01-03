using Microsoft.EntityFrameworkCore;
using MyMovieList.Controllers.data;
using MyMovieList.Models;

namespace MyMovieList.Controllers.services
{
	public class AccountsService : IAccountsService
	{
		private readonly AppDbContext _context;

		public AccountsService(AppDbContext context) 
		{
			_context=context;
		}
		public void addUser(users user)
		{
			
			_context.Users.Add(user);
			_context.SaveChanges();


		}


        public List<users> Allusers()
        {
            var result =  _context.Users.ToList();
            return result;
        }


        public async Task<IEnumerable<users>> GetAll()
		{
			var result =await _context.Users.ToListAsync();
			return result;
		}

		public users GetUser(string userEmail)
		{
			users person = _context.Users.FirstOrDefault(b => b.userEmail == userEmail);
			return person;
		}

		public void removeUser(string userEmail)
		{
			_context.Remove(_context.Users.Single(a => a.userEmail == userEmail));
			_context.SaveChanges();
		}

		
		public void UpdateUser(String email, String pwd, String oldmail)
		{
			Console.WriteLine(email, pwd, oldmail);
			users person = _context.Users.FirstOrDefault(b => b.userEmail == oldmail);
			person.userEmail = email;
			person.password = pwd;
			_context.SaveChanges();
		}


	}
}
