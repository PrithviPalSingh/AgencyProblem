using DataLayer.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.DataClasses
{
    public interface IInsurance
    {
        IInsurance GetInsuranceDetails(int insuranceID);

        List<IInsurance> GetAllInsurance(int userId);

        void CreateInsurance(BaseDM model);

        void DeleteInsurance(BaseDM model);
    }
}
