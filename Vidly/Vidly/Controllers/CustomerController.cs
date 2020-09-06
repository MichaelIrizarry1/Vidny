﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vidly.Data;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext _context;

        public CustomerController(ApplicationDbContext context)
        {
            _context = context;
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public IActionResult Index()
        {
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();
            return View(customers);
        }

        [Route("Customer/{id}")]
        public ActionResult Details(int id)
        {
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);
            if (customer == null)
            {
                return NotFound();

            }
            return View(customer);
        }

        [Route("Customer/New")]
        public ActionResult New()
        {
            var membershipType = _context.MembershipType;
            var viewModel = new CustomerMembershipTypeViewModel()
            {
                MembershipTypes = membershipType
            };
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return RedirectToAction("Index","Customer");
        }

        [Route("customer/edit/{id}")]
        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
            {
                return NotFound();

            }

            var viewModel = new CustomerMembershipTypeViewModel()
            {
                MembershipTypes = _context.MembershipType,
                Customer = customer
            };
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Update(Customer customer)
        {
            var customerToUpdate = _context.Customers.SingleOrDefault(c => c.Id == customer.Id);

            if (customerToUpdate == null)
            {
                return NotFound();
            }
            else
            {
                customerToUpdate.Name = customer.Name;
                customerToUpdate.Birthdate = customer.Birthdate;
                customerToUpdate.IsSubscribedToNewsLetter = customer.IsSubscribedToNewsLetter;
                customerToUpdate.MembershipTypeId = customer.MembershipTypeId;

            }

            _context.SaveChanges();

            return RedirectToAction("index","Customer");
        }
        


    }
}
