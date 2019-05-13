using DataLayer.DataClasses;
using System;

namespace DataLayer
{
    public class DataFactory
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
