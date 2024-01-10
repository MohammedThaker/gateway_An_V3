using GatewayDomain.Entities;
using GatewayDomain.Interfaces;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatewayTDD.Domain_IRepositry_UnitTest
{
    public class Test_IProviderRepository:Models
    {
        private readonly Mock<IProviderRepository> _mock;
        public Test_IProviderRepository()
        {
            _mock = new Mock<IProviderRepository>();
        }



        [Fact]
        public async Task Domain_Interface_Provider_AddAsync_Test_Method()
        {


            //Arrange

            _mock.Setup(repo => repo.AddAsync(It.IsAny<Provider>())).ReturnsAsync(provid);

            //Acting
            IProviderRepository repository = _mock.Object;
            var actualed_value = await repository.AddAsync(provid);

            //Asserting
            Assert.NotNull(actualed_value);
        }


        [Fact]

        public async Task Domain_Interface_Provider_GetAsync_Test_Method()
        {


            //Arrange

            _mock.Setup(repo => repo.GetAllAsync()).ReturnsAsync(GetTestProvider);

            //Acting
            IProviderRepository repository = _mock.Object;
            var actualed_value = await repository.GetAllAsync();

            //Asserting
            Assert.NotNull(actualed_value);
            _mock.Verify(r => r.GetAllAsync(), Times.Once());

            Assert.Equal(3, actualed_value.Count());

        }
        [Fact]
        public async Task Domain_Interface_Currency_DeleteAsync_Test_Method()
        {
            // Arrange
            _mock.Setup(repo => repo.DeleteAsync(It.IsAny<Provider>())).ReturnsAsync(provid);

            // Acting
            IProviderRepository repository = _mock.Object;
            var actualed_value = await repository.DeleteAsync(provid);

            // Asserting

            Assert.NotNull(actualed_value);
        }

    }
}
