using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MnemotestProject.View
{
    public class Template
    {
        public string Name { get; set; }
        public string ExposureTime { get; private set; }
        public string PostExposureTime { get; private set; }
        public string PreExposureTime { get; private set; }
        public string Difficult { get; private set; }
        public string ReproductionMode { get; private set; }
        public string RotateCount { get; private set; }
        public string Size { get; private set; }
        public string Attempts { get; private set; }
        public string Scatter { get; private set; }

        public Template(string name, string exposureTime, string postExposureTime, string preExposureTime, string difficult, string reproductionMode, string rotateCount, string size, string attempts, string scatter)
        {
            Name = name;
            ExposureTime = exposureTime;
            PostExposureTime = postExposureTime;
            PreExposureTime = preExposureTime;
            Difficult = difficult;
            ReproductionMode = reproductionMode;
            RotateCount = rotateCount;
            Size = size;
            Attempts = attempts;
            Scatter = scatter;
        }

        public Template(string exposureTime, string postExposureTime, string preExposureTime, string difficult, string reproductionMode, string rotateCount, string size, string attempts, string scatter)
        {
            Name = null;
            ExposureTime = exposureTime;
            PostExposureTime = postExposureTime;
            PreExposureTime = preExposureTime;
            Difficult = difficult;
            ReproductionMode = reproductionMode;
            RotateCount = rotateCount;
            Size = size;
            Attempts = attempts;
            Scatter = scatter;
        }
    }
}
