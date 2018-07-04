﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {

        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Customers
        //public ActionResult Index()
        //{
        //    //var movie = new Movie() { Name = "Shrek!" };
        //    var customer = new List<Customer>

        //    {
        //        new Customer {Name = "JOhn Smith"},
        //        new Customer {Name = "Mary Williams"}
        //    };

        //    var viewModel = new RandomMovieViewModel
        //    {
        //       Customers = customer,
        //        //Customers = customers

        //    };
        //    return View(viewModel);
        //}
        public ActionResult Index()
        {
            var customers = _context.Customers.ToList();
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }



    }
}