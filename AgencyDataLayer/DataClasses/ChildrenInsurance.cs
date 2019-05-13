using System;
using System.Collections.Generic;
using System.Text;
using DataLayer.DataModel;

namespace DataLayer.DataClasses
{
    class ChildrenInsurance : IInsurance
    {
        public void CreateInsurance(BaseDM model)
        {
            throw new NotImplementedException();
        }

        public void DeleteInsurance(BaseDM model)
        {
            throw new NotImplementedException();
        }

        public List<IInsurance> GetAllInsurance(int userId)
        {
            throw new NotImplementedException();
        }

        public IInsurance GetInsuranceDetails(int insuranceID)
        {
            throw new NotImplementedException();
        }
    }
}
