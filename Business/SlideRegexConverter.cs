using System.Linq;
using System.Text.RegularExpressions;
using hashcode2019.Models;

namespace hashcode2019.Business
{
    public class SlideRegexConverter
    {
        private string _alignmentGroupName = "alignment";
        private string _numberOfTagsGroupName = "numberOfTags";
        private string _tagsGroupName = "tags";
        public SlideImage Convert(string line)
        {
            
            var matches = Regex.Matches(line,
                    $"^(?<{_alignmentGroupName}>H|V) (?<{_numberOfTagsGroupName}>\\d+) (?<{_tagsGroupName}>.*)");
                    
            var match = matches.First();

            var slide = new SlideImage()
            {
                TypeImage = match.Groups[_alignmentGroupName].Value.Equals("H") ? TypeImage.Horizontal : TypeImage.Vertical,
                Tags = match.Groups[_tagsGroupName].Value.Split(' ').ToList<string>()
            }; 

            return slide;
        }
    }
}