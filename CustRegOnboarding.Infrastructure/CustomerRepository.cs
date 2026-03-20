using CustRegOnboarding.Domain;
using CustRegOnboarding.Application;
using Microsoft.EntityFrameworkCore;


namespace CustRegOnboarding.Infrastructure
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AppDbContext _context;

        public CustomerRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Customer customer)
        {
            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();
        }

        public async Task<Customer> GetByIdAsync(Guid id)
            => await _context.Customers.FindAsync(id);

        public async Task<List<Customer>> GetAllAsync()
            => await _context.Customers.ToListAsync();
    }
}
