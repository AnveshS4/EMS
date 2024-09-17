
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EMS1.Models;
using System.Linq;
using System.Threading.Tasks;
using EMS1.Models;

public class WorkController : Controller
{
    private readonly AppDbContext _context;

    public WorkController(AppDbContext context)
    {
        _context = context;
    }

    
    public IActionResult Create()
    {
        ViewData["Employees"] = _context.Employees.ToList();
        return View();
    }

    
    [HttpPost]

    public async Task<IActionResult> Create([Bind("WorkId,Description,EndDate,")] Work work)
    {
        if (ModelState.IsValid)
        {
            _context.Add(work);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        ViewData["Employees"] = _context.Employees.ToList();
        return View(work);
    }


        
   }

