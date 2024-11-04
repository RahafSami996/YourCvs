using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.YourCV.Core.Data;

namespace Tahaluf.YourCV.Core.Repository
{
    public interface ITestimonialRepository
    {
        bool CreateTestimonial(Testimonial testimonial);
        Testimonial GetTestimonial(int id);
        Testimonial GetTestimonialByWebsiteId(int websiteInfoId); 
        IEnumerable<Testimonial> GetAllTestimonial();
        bool UpdateTestimonial(Testimonial testimonial);
        bool DeleteTestimonial(int id);
    }
}
