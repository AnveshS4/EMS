using EMS1.Models;
using EMS1.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace EMS1.Controllers
{
    public class LoginController : Controller
    {
        private readonly AppDbContext _appDbContext;
        private readonly IEncryptionRepository _encryptionRepository;
        public LoginController(AppDbContext appDbContext, IEncryptionRepository encryptionRepository)
        {
            _appDbContext = appDbContext;
            _encryptionRepository = encryptionRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(UserLogin user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // Get the current user based on the provided email
                    Employee employee = _appDbContext.Employees
                        .Where(i => i.Email == user.Email)
                        .FirstOrDefault();

                    // Check if the user exists
                    if (employee != null)
                    {
                        // Hash the provided password to compare with the stored hashed password
                        byte[] datasalt = _encryptionRepository.GenerateSalt();

                        string hashedInputPassword = _encryptionRepository.HashPassword(user.Password,datasalt);

                        // Verify the password
                        if (employee.Password == hashedInputPassword)
                        {
                            // Password is correct, set up authentication (e.g., set session, cookie, etc.)
                            // For example:
                            HttpContext.Session.SetString("UserEmail", employee.Email);

                            // Redirect to a secured area or home page
                            return RedirectToAction("Index", "Home");
                        }
                        else
                        {
                            // Password is incorrect
                            ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                        }
                    }
                    else
                    {
                        // User does not exist
                        ModelState.AddModelError(string.Empty, "User not found.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception (implement logging here)
                ModelState.AddModelError(string.Empty, "An error occurred while processing your request.");
            }

            // If we reach here, something went wrong; redisplay the login form
            return View();
        }

        // Method to hash the password (use a secure hashing algorithm in production)
        
    }
}