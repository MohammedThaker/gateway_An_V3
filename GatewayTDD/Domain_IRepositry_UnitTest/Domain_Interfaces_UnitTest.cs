using Gateway_Domain.Entities;
using GatewayDomain.Interfaces;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatewayTDD.Domain_IRepositry_UnitTest
{
    public class Domain_Interfaces_UnitTest:Models
    {
        private readonly Mock<ICompanyRepository> _mock;
        public Domain_Interfaces_UnitTest()
        {
            _mock = new Mock<ICompanyRepository>();
        }



        [Fact]
        public async Task Domain_Interface_Comapny_AddAsync_Test_Method()
        {


            //Arrange
          
            _mock.Setup(repo => repo.AddAsync(It.IsAny<Company>())).ReturnsAsync(comp);

            //Acting
            ICompanyRepository repository = _mock.Object;
            var actualed_value =await repository.AddAsync(comp);

            //Asserting
            Assert.NotNull(actualed_value);
        }


        [Fact]

        public async Task Domain_Interface_Comapny_GetAsync_Test_Method()
        {


            //Arrange

            _mock.Setup(repo => repo.GetAllAsync()).ReturnsAsync(GetTestCompany);

            //Acting
            ICompanyRepository repository = _mock.Object;
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
            _mock.Setup(repo => repo.DeleteAsync(It.IsAny<Company>())).ReturnsAsync(comp);

            // Acting
            ICompanyRepository repository = _mock.Object;
            var actualed_value = await repository.DeleteAsync(comp);

            // Asserting

            Assert.NotNull(actualed_value); 
        }


    }
}
