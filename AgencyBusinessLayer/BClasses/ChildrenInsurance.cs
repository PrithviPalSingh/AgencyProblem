using System;
using System.Collections.Generic;
using System.Text;
using Business.Entities;

namespace Business.BClasses
{
    class ChildrenInsurance : IInsurance
    {
        public void CreateInsurance(BaseEntity model)
        {
            throw new NotImplementedException();
        }

        public void DeleteInsurance(BaseEntity model)
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
