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
    public class Test_IProviderCompanyRepository:Models
    {
        private readonly Mock<IProviderCompanyRepository> _mock;
        public Test_IProviderCompanyRepository()
        {
            _mock = new Mock<IProviderCompanyRepository>();
        }

        [Fact]
        public async Task Domain_Interface_ProviderCompany_AddAsync_Test_Method()
        {


            //Arrange

            _mock.Setup(repo => repo.AddAsync(It.IsAny<ProviderCompany>())).ReturnsAsync(providercompany);

            //Acting
            IProviderCompanyRepository repository = _mock.Object;
            var actualed_value = await repository.AddAsync(providercompany);

            //Asserting
            Assert.NotNull(actualed_value);
        }


        [Fact]

        public async Task Domain_Interface_ProviderCompany_GetAsync_Test_Method()
        {


            //Arrange

            _mock.Setup(repo => repo.GetAllAsync()).ReturnsAsync(GetTestProviderCompany);

            //Acting
            IProviderCompanyRepository repository = _mock.Object;
            var actualed_value = await repository.GetAllAsync();

            //Asserting
            Assert.NotNull(actualed_value);
            _mock.Verify(r => r.GetAllAsync(), Times.Once());

            Assert.Equal(3, actualed_value.Count());

        }
        [Fact]
        public async Task Domain_Interface_ProviderCompany_DeleteAsync_Test_Method()
        {
            // Arrange
            _mock.Setup(repo => repo.DeleteAsync(It.IsAny<ProviderCompany>())).ReturnsAsync(providercompany);

            // Acting
            IProviderCompanyRepository repository = _mock.Object;
            var actualed_value = await repository.DeleteAsync(providercompany);

            // Asserting

            Assert.NotNull(actualed_value);
        }


    }
}

