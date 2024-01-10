using Gateway_Domain.Entities;
using GatewayDomain.Entities;
using GatewayDomain.Interfaces;
using Moq;
using GatewayTDD;

namespace GatewayTDD.Domain_IRepositry_UnitTest
{
    public class Test_IProductRepository:Models
    {
        private readonly Mock<IProductRepository> _mock;
        
        public Test_IProductRepository()
        {
            _mock = new Mock<IProductRepository>();

        }

        [Fact]
        public async Task Domain_Interface_Products_AddAsync_Test_Method()
        {

            _mock.Setup(repo => repo.AddAsync(It.IsAny<Product>())).ReturnsAsync(pro);

            IProductRepository repository = _mock.Object;
            var actualed_value = await repository.AddAsync(pro);

            Assert.Equal(pro, actualed_value);
        }
        [Fact]

        public async Task Domain_Interface_Comapny_GetAsync_Test_Method()
        {


            //Arrange

            _mock.Setup(repo => repo.GetAllAsync()).ReturnsAsync(GetTestProducts);

            //Acting
            IProductRepository repository = _mock.Object;
            var actualed_value = await repository.GetAllAsync();

            //Asserting
            Assert.NotNull(actualed_value);
            _mock.Verify(r => r.GetAllAsync(), Times.Once());

            Assert.Equal(3, actualed_value.Count());

        }
        [Fact]
        public async Task Domain_Interface_Comapny_DeleteAsync_Test_Method()
        {
            // Arrange
            _mock.Setup(repo => repo.DeleteAsync(It.IsAny<Product>())).ReturnsAsync(pro);

            // Acting
            IProductRepository repository = _mock.Object;
            var actualed_value = await repository.DeleteAsync(pro);

            // Asserting

            Assert.NotNull(actualed_value);
        }
    }
    }
