using System;
using System.Collections.Generic;

namespace hashcode2019.Models
{
    public class SlideImage
    {
        public string Id {get;set;}
        public TypeImage TypeImage {get;set;}
        public List<string> Tags{get;set;}
    }
}