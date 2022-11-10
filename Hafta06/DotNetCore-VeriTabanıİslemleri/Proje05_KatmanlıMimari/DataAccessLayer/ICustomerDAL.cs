using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Proje05_KatmanlıMimari.DataAccessLayer.Entities;

namespace Proje05_KatmanlıMimari.DataAccessLayer
{
    public interface ICustomerDAL
    {
        void CreateCustomer(Customer customer);
        List<Customer> GetAllCustomers();
        
        Customer getById(string id);

        void UpdateCustomer(Customer customer);
        void DeleteCustomer(int id);
    }
}