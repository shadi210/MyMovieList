using Azure.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyMovieList.Controllers.data;
using MyMovieList.Controllers.services;
using MyMovieList.Models;

namespace MyMovieList.Controllers
{
    public class AccountsController : Controller
    {
     

        
            private readonly IAccountsService _service;
            public AccountsController(IAccountsService service)
            {
                _service = service;
            }


        



        public async Task<IActionResult> Index()
            {
			var data = await _service.GetAll();
               
                return View(data);
            }





		




		[HttpPost]
		public ActionResult create(string emailadd,string pwdadd )

		{
            users u=new users();
            u.userEmail=emailadd;
            u.password=pwdadd;
            u.isAdmin=false;
			_service.addUser(u);
			return RedirectToAction("Index");
		}

        [HttpPost]
		public ActionResult update(String email, String pwd,String oldmail)
		{
			
            _service.UpdateUser(email, pwd, oldmail);
			return RedirectToAction("Index");
		}

        [HttpPost]
		public ActionResult delete(String mail)
        {
            _service.removeUser(mail);
            return RedirectToAction("Index");
        }


        public ActionResult login(string un, string psw)
        {
            users p = _service.GetUser(un);

            if (((p != null))& (String.Compare(p.userEmail, un) == 0 && String.Compare(p.password, psw) == 0))
                {
                    if (p.isAdmin== true)

                    return RedirectToAction("Index");

                    else return RedirectToAction("Index","movie");

                }

            

                else return RedirectToAction("erreur", "Accounts");
                

		}



		public ActionResult erreur
            ()
		{
			return(View());



		}








	}

}

