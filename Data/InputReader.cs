using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using hashcode2019.Business;

namespace hashcode2019.Data
{
    public class InputReader
    {
        public InputReader(string path)
        {
            if(string.IsNullOrEmpty(path))
                throw new ArgumentNullException("path");
            Path = path;
        }

        public List<Models.SlideImage> Read()
        {
            var converter = new SlideRegexConverter();
            var slideImages = new List<Models.SlideImage>();

            if(!File.Exists(Path))
                throw new Exception($"Le fichier n'existe pas dans le chemin spécifié : {Path}");
            
            using(var dataFileStream = new StreamReader(Path))
            {
                int numberOfLine = int.Parse(dataFileStream.ReadLine());

                while(!dataFileStream.EndOfStream)
                {
                    var lineRead = dataFileStream.ReadLine();

                    slideImages.Add(converter.Convert(line: lineRead));                   
                }
            }
            return slideImages;
        }

        public string Path { get; private set; }
    }
}