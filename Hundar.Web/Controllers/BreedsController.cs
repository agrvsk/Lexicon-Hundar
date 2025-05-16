using Hundar.Web.Models;
using Hundar.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace Hundar.Web.Controllers;

public class BreedsController : Controller
{
    public static BreedService breedService = new BreedService();

    [Route("/")]
    public IActionResult Index()
    {
        var model = breedService.getAllBreeds();
        return View(model);
    }
    [HttpGet("Create")]
    public IActionResult InsertBreed()
    {
        return View();
    }
    [HttpPost("Create")]
    public IActionResult InsertBreed(Breed breed)
    {
        if (!ModelState.IsValid)
        {
            return View();
        }
        breedService.addBreed(breed);
        return RedirectToAction("Index");
    }
}
