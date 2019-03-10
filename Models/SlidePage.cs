using System.Collections.Generic;
using System.Linq;

namespace hashcode2019.Models
{
    public class SlidePage
    {
        List<SlideImage> Images {get;set;}

        public SlidePage()
        {
            Images = new List<SlideImage>();
        }

        public List<string> GetTags()
        {
            var tags = new List<string>();
            
            Images.ForEach(
                img => tags.AddRange(img.Tags)
            );

            // tags.AddRange(Images.Select(img => img.Tags));

            return tags.Distinct().ToList();
        }
    }
}