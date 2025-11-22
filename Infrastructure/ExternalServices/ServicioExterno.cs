using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.ExternalServices
{
    public class ExchangeRateResponseDto
    {
        public required string Base { get; set; }
        public required string Date { get; set; }
        public required Dictionary<string, decimal> Rates { get; set; }
    }

}
