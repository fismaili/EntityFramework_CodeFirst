using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EntityFramework_CodeFirst.Models;

namespace EntityFramework_CodeFirst.Controllers
{
    public class StudentsController : Controller
    {
        private readonly SchoolContext context;

        public StudentsController(SchoolContext context)
        {
            this.context = context;
        }
        public async Task<IActionResult> Students()
        {
            return View(await context.Students.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("StudentId,StudentName,DateOfBirth")] Student student)
        {
            if (ModelState.IsValid)
            {
                context.Add(student);
                await context.SaveChangesAsync();
                return RedirectToAction(nameof(Students));
            }
            return View(student);
        }
    }
}