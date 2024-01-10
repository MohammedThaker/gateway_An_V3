using GatewayDomain.Common;
using GatewayDomain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Gateway_Domain.Entities
{
    public class Country: IBaseValidation
    {

        [Key]
        public int CountryId { get; set; }
        public string CountryName { get; set; } = null!;
        public string CountryCode { get; set; }=string.Empty;
        public string CountryDescription { get; set; }= string.Empty;

        public ICollection<ProviderCountry>? providercountrie {  get; set; }
        public async Task<string> isValid()
        {
            if (string.IsNullOrEmpty(CountryName))
            {
                return await Task.FromResult<string>("Country Name field is Required");
            }

            if (string.IsNullOrWhiteSpace(CountryCode))
            {
                return await Task.FromResult<string>("Please Enter a correct Country Code to be considered");
            }

           


            return await Task.FromResult<string>("");
        }
    }
}
