using Business.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.BClasses
{
    public interface IInsurance
    {
        IInsurance GetInsuranceDetails(int insuranceID);

        List<IInsurance> GetAllInsurance(int userId);

        void CreateInsurance(BaseEntity model);

        void DeleteInsurance(BaseEntity model);
    }
}
