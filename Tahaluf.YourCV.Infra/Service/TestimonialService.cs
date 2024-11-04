using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.YourCV.Core.Data;
using Tahaluf.YourCV.Core.Repository;
using Tahaluf.YourCV.Core.Service;

namespace Tahaluf.YourCV.Infra.Service
{
    public class TestimonialService : ITestimonialService
    {
        private readonly ITestimonialRepository _testimonialService;

        public TestimonialService(ITestimonialRepository testimonialRepository)
        {
            _testimonialService = testimonialRepository;
        }

        public bool CreateTestimonial(Testimonial testimonial)
        {
            return _testimonialService.CreateTestimonial(testimonial);
        }

        public bool DeleteTestimonial(int id)
        {
            return _testimonialService.DeleteTestimonial(id);
        }

        public IEnumerable<Testimonial> GetAllTestimonial()
        {
            return _testimonialService.GetAllTestimonial();
        }

        public Testimonial GetTestimonial(int id)
        {
            return _testimonialService.GetTestimonial(id);
        }

        public Testimonial GetTestimonialByWebsiteId(int websiteInfoId)
        {
            return _testimonialService.GetTestimonialByWebsiteId(websiteInfoId);
        }

        public bool UpdateTestimonial(Testimonial testimonial)
        {
            return _testimonialService.UpdateTestimonial(testimonial);
        }
    }
}
