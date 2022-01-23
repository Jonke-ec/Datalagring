using EntityFramework_WPF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_WPF.Services {

    internal interface ISubjectService {
        bool Create(string errandtitle, string description, string status, int customerid);
        IEnumerable<Subject> GetAll();
    }


    internal class SubjectService : ISubjectService {

        private readonly SqlContext _context = new();
        Customer customer = new Customer();

        public bool Create(string errandtitle, string description, string status, int customerid) {


            var subject = _context.Subjects.Where(x => x.CustomerId == customer.Id).FirstOrDefault();
            if (subject == null) {
                _context.Subjects.Add(new Subject {
                    CustomerId = customerid,
                    ErrandTitle = errandtitle,
                    Description = description,
                    Status = status,
                    ErrandDate = DateTime.Now
                });
                _context.SaveChanges();
                return true;
            }
            return false;
        }


        public IEnumerable<Subject> GetAll() {
            return _context.Subjects;
        }
    }
}
