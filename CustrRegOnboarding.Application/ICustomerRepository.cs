using CustRegOnboarding.Domain;

namespace CustRegOnboarding.Application
{
    public interface ICustomerRepository
    {
        Task AddAsync(Customer customer);
        Task<Customer> GetByIdAsync(Guid id);
        Task<List<Customer>> GetAllAsync();
    }
}
