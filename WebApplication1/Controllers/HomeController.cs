using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entities;
using WebApplication1.Models;
using WebApplication1.Servicies;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICalculate _calculate;
        private readonly ICalculate _calculate1;
        public HomeController(ICalculate calculate, ICalculate calculate1)
        {
            _calculate = calculate;
            _calculate1 = calculate1;
        }
        public string Index()
        {
            _calculate.Calculate(200);
            _calculate1.Calculate(200);
            return "Resault : ";
        }
        public IActionResult Index2()
        {
            return Ok();
        }
        public IActionResult Index3()
        {
            return NotFound();
        }
        public IActionResult Index4()
        {
            return BadRequest();
        }
        public IActionResult Employees()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee()
                {
                    Id = 1,
                    CityId = 1,
                    Firstname= "Foo",
                    Lastname= "Bar"

                },
                new Employee()
                {
                    Id = 2,
                    CityId = 2,
                    Firstname= "Foo2",
                    Lastname= "Bar2"

                },
                new Employee()
                {
                    Id = 3,
                    CityId = 3,
                    Firstname= "Fo3",
                    Lastname= "Ba3"

                }
            };
            List<string> cityes = new List<string>() { "Baku", "Ankara","Tehran" };
            var viewModel = new EmployeeViewModel
            {
                Employees = employees,
                Cityes = cityes
            };
            return View(viewModel);

        }
        public IActionResult GetEmployees(int id)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee()
                {
                    Id = 1,
                    CityId = 1,
                    Firstname= "Foo",
                    Lastname= "Bar"

                },
                new Employee()
                {
                    Id = 2,
                    CityId = 2,
                    Firstname= "Foo2",
                    Lastname= "Bar2"

                },
                new Employee()
                {
                    Id = 3,
                    CityId = 3,
                    Firstname= "Fo3",
                    Lastname= "Ba3"

                }
            };
            var employee=employees.FirstOrDefault(e=>e.Id==id);
            return Json(employee);

        }
        public IActionResult Market()
        {
            List<Drink> drinks = new List<Drink>()
            {
                new Drink()
                {
                    Id= 1,
                    Type="Drink",
                    Name="Beer",
                    Price="2.5 azn"

                },
                new Drink()
                {
                    Id= 2,
                    Type="Drink",
                    Name="Vodka",
                    Price="10.5 azn"

                },
                new Drink()
                {
                    Id= 3,
                    Type="Drink",
                    Name="Kvass",
                    Price="1.5 azn"

                }

            };
            List<HotMeal> hotMeals = new List<HotMeal>()
            {
                new HotMeal()
                {
                    Id=1,
                    Type="HotMeal",
                    Name="Garnier",
                    Price="5.5 azn"
                },
                new HotMeal()
                {
                    Id=2,
                    Type="HotMeal",
                    Name="Stuffing",
                    Price="5 azn"
                },
                new HotMeal()
                {
                    Id=1,
                    Type="HotMeal",
                    Name="Garnier tapestry",
                    Price="3 azn"
                }
            };
            List<FastFood> fastFoods = new List<FastFood>()
            {
                new FastFood()
                {
                    Id=1,
                    Type="FastFood",
                    Name="Pizza",
                    Price="7 azn"
                },
                new FastFood()
                {
                    Id=1,
                    Type="FastFood",
                    Name="Hotdog",
                    Price="3 azn"
                },
                new FastFood()
                {
                    Id=1,
                    Type="FastFood",
                    Name="Zickenburger",
                    Price="8 azn"
                }

            };
            var market = new HomeViewModel
            {
                Drinks = drinks,
                HotMeals = hotMeals,
                FastFoods = fastFoods
            };
            return View(market);
        }
        public IActionResult Drinks()
        {
            List<Drink> drinks = new List<Drink>()
            {
                new Drink()
                {
                    Id= 1,
                    Type="Drink",
                    Name="Beer",
                    Price="2.5 azn"

                },
                new Drink()
                {
                    Id= 2,
                    Type="Drink",
                    Name="Vodka",
                    Price="10.5 azn"

                },
                new Drink()
                {
                    Id= 3,
                    Type="Drink",
                    Name="Kvass",
                    Price="1.5 azn"

                }

            };
           
            return View(drinks);
        }
        public IActionResult FastFoods()
        {
            List<FastFood> fastFoods = new List<FastFood>()
            {
                new FastFood()
                {
                    Id=1,
                    Type="FastFood",
                    Name="Pizza",
                    Price="7 azn"
                },
                new FastFood()
                {
                    Id=2,
                    Type="FastFood",
                    Name="Hotdog",
                    Price="3 azn"
                },
                new FastFood()
                {
                    Id=3,
                    Type="FastFood",
                    Name="Zickenburger",
                    Price="8 azn"
                }

            };

            return View(fastFoods);
        }
        public IActionResult HotMeals()
        {
            List<HotMeal> hotMeals = new List<HotMeal>()
            {
                new HotMeal()
                {
                    Id=1,
                    Type="HotMeal",
                    Name="Garnier",
                    Price="5.5 azn"
                },
                new HotMeal()
                {
                    Id=2,
                    Type="HotMeal",
                    Name="Stuffing",
                    Price="5 azn"
                },
                new HotMeal()
                {
                    Id=3,
                    Type="HotMeal",
                    Name="Garnier tapestry",
                    Price="3 azn"
                }
            };

            return View(hotMeals);
        }
    }
}
