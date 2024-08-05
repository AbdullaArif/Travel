using BuisnessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.Concrete
{
    public class FeatureMainManager:IFeatureMainService
    {
        IFeatureMainDal _featureMainDal;

        public FeatureMainManager(IFeatureMainDal featureMainDal)
        {
            _featureMainDal = featureMainDal;
        }

        public void TAdd(FeatureMain item)
        {
            throw new NotImplementedException();
        }

        public void TDelete(FeatureMain item)
        {
            throw new NotImplementedException();
        }

        public FeatureMain TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<FeatureMain> TGetList()
        {
            return _featureMainDal.GetList();
        }

        public void TUpdate(FeatureMain item)
        {
            throw new NotImplementedException();
        }
    }
}
