using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgencyProblem.Models
{
    public class BaseModel
    {
        public string InsuranceCode { get; set; }

        public string InsuranceName { get; set; }

        public string  InsuranceDescription { get; set; }

        public char InsuranceType { get; set; }

        public int InsuranceDuration { get; set; }

        public double InsurancePrice { get; set; }
    }
}