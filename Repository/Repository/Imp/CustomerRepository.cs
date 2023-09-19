using BussinessObject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository.Imp
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly FUCarRentingManagementContext _context;

        public CustomerRepository()
        {
            _context = new FUCarRentingManagementContext();
        }

        public Customer Login(string email, string password)
        {
            var customer = _context.Set<Customer>().FirstOrDefault(c => c.Email == email && c.Password == password);
            if (customer == null)
            {
                throw new Exception("Khong dang nhap THONG GA");
            }
            return customer;
        }
    }
}
