using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data = DataLayer.DataClasses;

namespace AgencyBusinessLayer.BClasses
{
    public class Products
    {
        public IList<BaseEntity> GetProducts()
        {
            Data.Products dp = new Data.Products();
            var dataModel = dp.GetProducts();
            IList<BaseEntity> baseEntity = new List<BaseEntity>();
            foreach (var item in dataModel)
            {
                BaseEntity bn = new BaseEntity();
                bn.InsuranceCode = item.InsuranceCode;
                bn.InsuranceDescription = item.InsuranceDescription;
                bn.InsuranceDuration = item.InsuranceDuration;
                bn.InsuranceName = item.InsuranceName;
                bn.InsurancePrice = item.InsurancePrice;
                bn.InsuranceType = item.InsuranceType;
                baseEntity.Add(bn);
            }

            return baseEntity;
        }
    }
}
