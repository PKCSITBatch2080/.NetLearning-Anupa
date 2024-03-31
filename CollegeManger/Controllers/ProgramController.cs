using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

public class ProgramController : Controller
{
    public IActionResult Index()
    {
        CollegeProgram c1 = new CollegeProgram() { Name = "CSIT", Affiliation = "Tu", Started = DateTime.Now };
        CollegeProgram c2 = new CollegeProgram() { Name = "CSIT", Affiliation = "Tu", Started = DateTime.Now.AddDays(-280) };
        CollegeProgram c3 = new CollegeProgram() { Name = "BCA", Affiliation = "Tu", Started = DateTime.Now.AddYears(-2) };
        CollegeProgram c4 = new CollegeProgram() { Name = "BIT", Affiliation = "Tu", Started = DateTime.Now.AddMonths(-1) };

        List<CollegeProgram> programs = new List<CollegeProgram>() { c1, c2, c3, c4 };
        return View(programs);
    }
}
