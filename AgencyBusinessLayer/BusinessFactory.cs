using Business.BClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class BusinessFactory
    {
        public IInsurance GetInsuranceObject(string s)
        {
            if (s == "M")
                return new MedicalInsurance();
            else if (s == "C")
                return new ChildrenInsurance();
            else if (s == "T")
                return new TravelInsurance();
            else
                return null;
        }
    }
}
