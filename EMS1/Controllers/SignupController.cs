using EMS1.Models;
using EMS1.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;


namespace EMS1.Controllers
{
    public class SignupController : Controller
    {
        private readonly AppDbContext _appDbContext;
        private readonly IEncryptionRepository _encryptionRepository;

        public SignupController(AppDbContext appDbContext, IEncryptionRepository encryptionRepository)
        {
            _appDbContext = appDbContext;
            _encryptionRepository = encryptionRepository;
        }

        public IActionResult Index(string Password)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                byte[] datasalt = _encryptionRepository.GenerateSalt();
                string HashPassword = _encryptionRepository.HashPassword(employee.Password, datasalt);
                //Encrypt Password
                var e = new Employee()
                {
                    FirstName = employee.FirstName,
                    LastName = employee.LastName,
                    Email = employee.Email,
                    Password = HashPassword
                };
                _appDbContext.Employees.Add(e);
                _appDbContext.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();

        }
    }
}


       
    

 
