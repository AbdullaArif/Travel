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
    public class GuideManager : IGuideService
    {
        IGuideDal _guideDal;

        public GuideManager(IGuideDal guideDal)
        {
            _guideDal = guideDal;
        }

        public void TAdd(Guide item)
        {
           _guideDal.Insert(item);
        }

        public void TChangeToFalseByGuide(int id)
        {
           _guideDal.ChangeToFalseByGuide(id);
        }

        public void TChangeToTrueByGuide(int id)
        {
            _guideDal.ChangeToTrueByGuide(id);
        }

        public void TDelete(Guide item)
        {
          _guideDal.Delete(item);
        }

        public Guide TGetById(int id)
        {
          return  _guideDal.GetById(id);
        }

        public List<Guide> TGetList()
        {
           return _guideDal.GetList();
        }

        public void TUpdate(Guide item)
        {
            _guideDal.Update(item);
        }
    }
}
