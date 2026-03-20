using CustRegOnboarding.Domain;

namespace CustRegOnboarding.Application
{
    public class CustomerService
    {
        private readonly ICustomerRepository _repo;

        public CustomerService(ICustomerRepository repo)
        {
            _repo = repo;
        }

        public async Task<Customer> CreateAsync(Customer customer)
        {
            if (string.IsNullOrEmpty(customer.Email))
                throw new Exception("Email is required");

            await _repo.AddAsync(customer);
            return customer;
        }

        public async Task<List<Customer>> GetAllAsync()
        {
            return await _repo.GetAllAsync(); ;
        }
    }
}
