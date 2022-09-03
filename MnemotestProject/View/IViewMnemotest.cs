using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MnemotestProject.View
{
    public interface IViewMnemotest
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string FatherName { get; set; }
        string InsurencePolicy { get; set; }
        string Age { get; set; }
        string Gender { get; }
        string ExposureTime { get; set; }
        string PostExposureTime { get; set; }
        string PreExposureTime { get; set; }
        string Difficult { get; set; }
        string ReproductionMode { get; set; }
        string RotateCount { get; set; }
        string MatrixSize { get; set; }
        string Attempts { get; set; }
        string Scatter { get; set; }

    }
}
