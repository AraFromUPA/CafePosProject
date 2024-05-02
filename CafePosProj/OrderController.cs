using CafeApiProj.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeApiProj
{
    public class OrderController
    {
        private readonly AppDbContext _appDbContext;
        public OrderController(AppDbContext context)
        {
            _appDbContext = context;

        }
        public async Task<Guid> CreateOrderAsync( Guid customerId, Guid employeeId, List<OrderProduct> productsToAddToOrder)

        {
            var newOrder = new Order
            {
                //Id = orderId,
                CustomerId = customerId,
                EmployeeId = employeeId,
                OrderProducts = productsToAddToOrder
                
            };

            _appDbContext.Orders.Add(newOrder);

           
                await _appDbContext.SaveChangesAsync();
                return newOrder.Id;
           
        }

        public async Task<bool> DeleteOrder(Guid orderId)
        {
            try
            {
                var orderToDelete = _appDbContext.Orders.FirstOrDefault(orders => orders.Id == orderId);

                if (orderToDelete == null)
                {
                    return false;
                }

                _appDbContext.Orders.Remove(orderToDelete);
                await _appDbContext.SaveChangesAsync();

                var entry = _appDbContext.Entry(orderToDelete);
                if (entry.State == EntityState.Detached)
                {

                    return true;
                }
                else
                {

                    return false;
                }
            }
            catch (DbUpdateException)
            {

                throw new Exception("Ошибка при удалении заказа.");
            }
        }


        public async Task<Guid> AddCustomerAsync( string FirstName, string LastName)
        {
            try
            {
                var newCustomer = new Customer()
                {
                    
                    FirstName = FirstName,
                    LastName = LastName
                };
                _appDbContext.Customers.Add(newCustomer);
                await _appDbContext.SaveChangesAsync();
                return newCustomer.Id;
            }
            catch (DbUpdateException)
            {
                throw new Exception("Не удалось добавить клиента.");
            }
        }

        public async Task<bool> DeleteCustomer(Guid customerId)
        {
            try
            {
                var customerToDelete =  _appDbContext.Customers.FirstOrDefault(c => c.Id == customerId);
                if (customerToDelete == null)
                {
                    return false; 
                }
                _appDbContext.Customers.Remove(customerToDelete);
                await _appDbContext.SaveChangesAsync();

                
                var entry = _appDbContext.Entry(customerToDelete);
                return entry.State == EntityState.Detached;
            }
            catch (DbUpdateException)
            {
                throw new Exception("Не удалось удалить клиента.");
            }
        }

        public async Task<Guid> AddEmployeeAsync( string FirstName, string LastName)
        {
            try
            {
                var newEmployee = new Employee()
                {
                   
                    FirstName = FirstName,
                    LastName = LastName
                };
                _appDbContext.Employees.Add(newEmployee);
                await _appDbContext.SaveChangesAsync();
                return newEmployee.Id;
            }
            catch (DbUpdateException)
            {
                throw new Exception("Не удалось добавить сотрудника.");
            }
        } 
        public async Task<Guid> AddCategoryAsync( string CategoryName )
        {
            try
            {
                var newCategory = new ProductCategory()
                {
                  
                    Name = CategoryName
                };
                _appDbContext.ProductCategories.Add(newCategory);
                await _appDbContext.SaveChangesAsync();
                return newCategory.Id;
            }
            catch (DbUpdateException)
            {
                throw new Exception("Не удалось добавить сотрудника.");
            }
        }
        public async Task<Guid> AddProductAsync( string Name, int price, int article, Guid categoryId )
        {
            try
            {
                var newProduct = new Product()
                {
                    CategoryId = categoryId,
                    Price = price,
                    Name = Name,
                    Article = article
                };
                _appDbContext.Products.Add(newProduct);
                await _appDbContext.SaveChangesAsync();
                return newProduct.Id;
            }
            catch (DbUpdateException)
            {
                throw new Exception("Не удалось добавить сотрудника.");
            }
        }

        public async Task<bool> DeleteEmployee(Guid employeeId)
        {
            try
            {
                var employeeToDelete =  _appDbContext.Employees.FirstOrDefault(e => e.Id == employeeId);
                if (employeeToDelete == null)
                {
                    return false; 
                }
                _appDbContext.Employees.Remove(employeeToDelete);
                await _appDbContext.SaveChangesAsync();

                
                var entry = _appDbContext.Entry(employeeToDelete);
                return entry.State == EntityState.Detached;
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show($"Error deleting customer: {ex.Message}");
                throw;
            }

        }
        public async Task<bool> DeleteCategory(Guid employeeId)
        {
            try
            {
                var CategoryToDelete =  _appDbContext.ProductCategories.FirstOrDefault(e => e.Id == employeeId);
                if (CategoryToDelete == null)
                {
                    return false; 
                }
                _appDbContext.ProductCategories.Remove(CategoryToDelete);
                await _appDbContext.SaveChangesAsync();

                
                var entry = _appDbContext.Entry(CategoryToDelete);
                return entry.State == EntityState.Detached;
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show($"Error deleting customer: {ex.Message}");
                throw;
            }

        }
        public async Task<bool> DeleteProduct(Guid employeeId)
        {
            try
            {
                var productToDelete = _appDbContext.Products.FirstOrDefault(e => e.Id == employeeId);
                if (productToDelete == null)
                {
                    return false;
                }
                _appDbContext.Products.Remove(productToDelete);
                await _appDbContext.SaveChangesAsync();


                var entry = _appDbContext.Entry(productToDelete);
                return entry.State == EntityState.Detached;
            }
            catch (DbUpdateException ex)
            {
                Console.WriteLine($"Error deleting customer: {ex.Message}");
                throw;
            }

        }
    }
}