using Gateway_Domain.Entities;
using GatewayDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatewayTDD
{
    public class Models
    {



  public  Product pro = new Product
        {
            CompanyId = 1,
            ProductDescription = "New Proudect",
            ProductName = "Test",

        };

        public ProviderCompany providercompany = new ProviderCompany
        {
            Id = 1,
            CompanyId = 1,
        Code = "Test",
            ProviderId = 1,

        };

        public Provider provid = new Provider
        {
        ProviderId = 1,
        ProviderName = "Test",  
         Password = "password",
        ProviderEmail = "Test",
        ProviderCode = "Test",
    

        };

        public Currency curr = new Currency
        {
           CurrencyId= 1,
           CurrencyArabicName= "Reall",
           CurrencyCode = "222",
           IsActive=true,
           DeletedOn= DateTime.Now,


        };
        public Company comp = new Company
        {
            CompanyId = 1,
            CompanyArabicName = "A",
            CompanyEnglishName = "B",
            CompanyAddress = "any"
        };

        public static List<Company> GetTestCompany()
        {
            var Company = new List<Company>();
            Company.Add(new Company()
            {
                CompanyId = 1,
                CompanyArabicName = "A",
                CompanyEnglishName = "B",
                CompanyAddress = "any"
            });
            Company.Add(new Company()
            {
                CompanyId = 1,
                CompanyArabicName = "A",
                CompanyEnglishName = "B",
                CompanyAddress = "any"
            });
            Company.Add(new Company()
            {
                CompanyId = 1,
                CompanyArabicName = "A",
                CompanyEnglishName = "B",
                CompanyAddress = "any"
            });
            return Company;
        }
        public static List<Product> GetTestProducts()
        {
            var Products = new List<Product>();
            Products.Add(new Product()
            {
                CompanyId = 1,
                ProductDescription = "New Proudect",
                ProductName = "Test",
            });
            Products.Add(new Product()
            {
                CompanyId = 1,
                ProductDescription = "New Proudect",
                ProductName = "Test",
            });
            Products.Add(new Product()
            {
                CompanyId = 1,
                ProductDescription = "New Proudect",
                ProductName = "Test",
            });
            return Products;
        }

        public static List<Currency> GetTestCurrency()
        {
            var Currency = new List<Currency>();
            Currency.Add(new Currency()
            {
                CurrencyId = 1,
                CurrencyArabicName = "Reall",
                CurrencyCode = "222",
                IsActive = true,
                DeletedOn = DateTime.Now,

            });
            Currency.Add(new Currency()
            {
                CurrencyId = 1,
                CurrencyArabicName = "Reall",
                CurrencyCode = "222",
                IsActive = true,
                DeletedOn = DateTime.Now,

            });
            Currency.Add(new Currency()
            {
                CurrencyId = 1,
                CurrencyArabicName = "Reall",
                CurrencyCode = "222",
                IsActive = true,
                DeletedOn = DateTime.Now,

            });
            return Currency;
        }



        public static List<Provider> GetTestProvider()
        {
            var Provider = new List<Provider>();
            Provider.Add(new Provider()
            {
                ProviderId = 1,
                ProviderName = "Test",
                Password = "password",
                ProviderEmail = "Test",
                ProviderCode = "Test",
            });
            Provider.Add(new Provider()
            {
                ProviderId = 1,
                ProviderName = "Test",
                Password = "password",
                ProviderEmail = "Test",
                ProviderCode = "Test",
            });
            Provider.Add(new Provider()
            {
                ProviderId = 1,
                ProviderName = "Test",
                Password = "password",
                ProviderEmail = "Test",
                ProviderCode = "Test",
            });
            return Provider;
        }

        public static List<ProviderCompany> GetTestProviderCompany()
        {
            var ProviderCompany = new List<ProviderCompany>();
            ProviderCompany.Add(new ProviderCompany()
            {
                CompanyId = 1,
                Code = "Test",
                ProviderId = 1,
            });
            ProviderCompany.Add(new ProviderCompany()
            {
                CompanyId = 1,
                Code = "Test",
                ProviderId = 1,
            });
            ProviderCompany.Add(new ProviderCompany()
            {
                CompanyId = 1,
                Code = "Test",
                ProviderId = 1,
            });
            return ProviderCompany;
        }




    }
}
