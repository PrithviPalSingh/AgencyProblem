using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Entities
{
    public class BaseEntity
    {
        public string InsuranceCode { get; set; }

        public string InsuranceName { get; set; }

        public string InsuranceDescription { get; set; }

        public char InsuranceType { get; set; }

        public int InsuranceDuration { get; set; }

        public double InsurancePrice { get; set; }
    }
}
