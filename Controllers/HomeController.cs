﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DojoSurveyWithValidations.Models;

namespace DojoSurveyWithValidations.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [HttpGet("Add")]
    public IActionResult Add(){
        return View("Add");
    }

    [HttpPost("Create")]
    public IActionResult Create(Survey marrNgaView){

        if(ModelState.IsValid)
    {
        // do somethng!  maybe insert into db?  then we will redirect
        return View("Survey",marrNgaView);
    }
    else
    {
        // Oh no!  We need to return a ViewResponse to preserve the ModelState, and the errors it now contains!
        return View("Add");
    }
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
