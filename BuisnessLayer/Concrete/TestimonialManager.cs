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
    public class TestimonialManager:ITestimonialService
    {
        ITestimonialDal _itestimonialDal;
        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _itestimonialDal = testimonialDal;
        }

        public void TAdd(Testimonial item)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Testimonial item)
        {
            throw new NotImplementedException();
        }

        public Testimonial TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Testimonial> TGetList()
        {
            return _itestimonialDal.GetList();
        }

        public void TUpdate(Testimonial item)
        {
            throw new NotImplementedException();
        }
    }
}
