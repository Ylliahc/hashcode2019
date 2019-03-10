using System.Collections.Generic;

namespace hashcode2019.Models
{
    public class SlidePage
    {
        List<SlideImage> Images {get;set;}

        public SlidePage()
        {
            Images = new List<SlideImage>();
        }
    }
}