using CustRegOnboarding.Application;
using CustRegOnboarding.Domain;
using Moq;

namespace CustRegOnboarding.Test
{
    public class CustomerServiceTests
    {
        [Fact]
        public async Task Should_Create_Customer()
        {
            var mockRepo = new Mock<ICustomerRepository>();
            var service = new CustomerService(mockRepo.Object);

            var customer = new Customer { Email = "test@test.com" };

            var result = await service.CreateAsync(customer);

            Assert.NotNull(result);
        }
    }
}
