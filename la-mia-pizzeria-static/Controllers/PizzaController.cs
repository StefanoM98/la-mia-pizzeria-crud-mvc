﻿using la_mia_pizzeria_static.Database;
using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            using(PizzaContext db = new PizzaContext())
            {
                List<Pizza> pizze = db.pizze.ToList<Pizza>();

                return View("Index", pizze);
             }
        }

        public IActionResult Details(int id)
        {
            using(PizzaContext db = new PizzaContext())
            {
                Pizza? pizzaTrovata = db.pizze.Where(pizza=>pizza.Id==id).FirstOrDefault();
                if(pizzaTrovata == null) 
                {
                    return NotFound($"La pizza con {id} non è nel nostro menù");
                } else
                {
                    return View("DettagliPizza", pizzaTrovata);
                }
            }
        }
    }
}
