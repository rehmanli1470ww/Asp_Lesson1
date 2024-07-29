﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.Entities;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        public static List<Employee> Employees { get; set; } = new List<Employee>
        {
             new Employee()
                {
                    Id = 1,
                    CityId = 1,
                    Firstname= "Cavid",
                    Lastname= "Atamaglanov"

                },
                new Employee()
                {
                    Id = 2,
                    CityId = 2,
                    Firstname= "Elvin",
                    Lastname= "Camalzade"

                },
                new Employee()
                {
                    Id = 3,
                    CityId = 3,
                    Firstname= "Ismail",
                    Lastname= "Seyidmemmedli"

                }

        };


        public IActionResult Index()
        {
            var vm = new EmployeeListViewModel
            {
                Employees = Employees
            };
            return View(vm);
        }
        [HttpGet]
        public IActionResult Add()
        {
            var vm = new EmployeeAddViewModel
            {
                Employee=new Employee(),
                Cities=new List<SelectListItem>
                {
                    new SelectListItem{Text="Baku",Value="10"},
                    new SelectListItem{Text="Xirdalan",Value="1"},
                    new SelectListItem{Text="Sumqayit",Value="50"}
                }
            };
            return View(vm);
        }
        [HttpPost]
        public IActionResult Add(EmployeeAddViewModel vm)
        {
            if (ModelState.IsValid)
            {
                vm.Employee.Id = (new Random()).Next(10, 1000);
                Employees.Add(vm.Employee);
                return RedirectToAction("Index");
            }
            return View(vm);
            
        }
        
        public IActionResult Delete(int id)
        {
            
            var item=Employees.SingleOrDefault(e=>e.Id == id);
            if (item != null)
            {
                Employees.Remove(item);
            }
            return RedirectToAction("Index");
        }
    }
}
