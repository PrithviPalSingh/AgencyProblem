using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.DataModel
{
    public class BaseDM
    {
        public string InsuranceCode { get; set; }

        public string InsuranceName { get; set; }

        public string InsuranceDescription { get; set; }

        public char InsuranceType { get; set; }

        public int InsuranceDuration { get; set; }

        public double InsurancePrice { get; set; }
    }
}
