
using Microsoft.AspNetCore.Mvc;
public class ProgramController : Controller
{
    List<CollegeProgram> programs =
    [
        new() { Id = 1, Name = "CSIT", Affiliation = "TU", Started = DateTime.Now },
        new() { Id = 2, Name = "BCA", Affiliation = "TU", Started = DateTime.Now.AddYears(-2) },
        new() { Id = 3, Name = "BIT", Affiliation = "TU", Started = DateTime.Now.AddMonths(-11) },
        new() { Id = 4, Name = "BIM", Affiliation = "PU", Started = DateTime.Now.AddDays(-200) }
    ];

    [HttpGet]
    public IActionResult Index()
    {
        return View(programs);
    }

    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Add(CollegeProgram program) // model binding
    {
        // Do something on program
        programs.Add(program);

        return RedirectToAction("Index");
    }
}