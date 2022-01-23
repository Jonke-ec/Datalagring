using EntityFramework_WPF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_WPF.Services {

    internal interface ICustomerService {

        bool Create(string firstname, string lastname, string email, int phonenumber, string address, int postalcode, string city, string country);
        IEnumerable<Customer> GetAll();
    }

    internal class CustomerService : ICustomerService {

        private readonly SqlContext _context = new();

        public bool Create(string firstname, string lastname, string email, int phonenumber, string address, int postalcode, string city, string country) {

            var customer = _context.Customers.Where(x => x.Email == email).FirstOrDefault();
            if (customer == null) {
                _context.Customers.Add(new Customer {
                    FirstName = firstname,
                    LastName = lastname,
                    Email = email,
                    PhoneNumber = phonenumber,
                    Address = address,
                    Postalcode = postalcode,
                    City = city,
                    Country = country
                });
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public IEnumerable<Customer> GetAll() {

            return _context.Customers;
        }
    }
}
