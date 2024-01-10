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
    public class Test_ICurrencyRepository:Models
    {
        private readonly Mock<ICurrencyRepository> _mock;
        public Test_ICurrencyRepository()
        {
            _mock = new Mock<ICurrencyRepository>();
        }



        [Fact]
        public async Task Domain_Interface_Currency_AddAsync_Test_Method()
        {


            //Arrange

            _mock.Setup(repo => repo.AddAsync(It.IsAny<Currency>())).ReturnsAsync(curr);

            //Acting
            ICurrencyRepository repository = _mock.Object;
            var actualed_value = await repository.AddAsync(curr);

            //Asserting
            Assert.NotNull(actualed_value);
        }


        [Fact]

        public async Task Domain_Interface_Currency_GetAsync_Test_Method()
        {


            //Arrange

            _mock.Setup(repo => repo.GetAllAsync()).ReturnsAsync(GetTestCurrency);

            //Acting
            ICurrencyRepository repository = _mock.Object;
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
            _mock.Setup(repo => repo.DeleteAsync(It.IsAny<Currency>())).ReturnsAsync(curr);

            // Acting
            ICurrencyRepository repository = _mock.Object;
            var actualed_value = await repository.DeleteAsync(curr);

            // Asserting

            Assert.NotNull(actualed_value);
        }


    }
}
