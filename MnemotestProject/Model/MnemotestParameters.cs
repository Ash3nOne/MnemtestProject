using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MnemotestProject
{
    public class MnemotestParameters
    {

        public int ExposureTime { get; }
        public int PostExposureTime { get; }
        public int PreExposureTime { get; }
        public int Difficult { get; }
        public bool ReproductionMode { get; }
        public int RotateCount { get; }
        public int Size { get; }
        public int Attempts { get; }
        public int Scatter { get; }


        public MnemotestParameters(int exposureTime, int postExposureTime, int preExposureTime, int difficult, bool reproductionMode, int rotateCount, int size, int attempts, int scatter)
        {
            PostExposureTime = postExposureTime;
            PreExposureTime = preExposureTime;
            Difficult = difficult;
            ReproductionMode = reproductionMode;
            Size = size;
            Attempts = attempts;
            ExposureTime = exposureTime;
            RotateCount = rotateCount;
            Scatter = scatter;
        }


    }
}
