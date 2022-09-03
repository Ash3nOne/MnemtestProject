using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MnemotestProject.View
{
    public interface IInputTemplateNameForm
    {
        Template ParametersTemplate { get; set; }
        string TemplateName { get; set; }

    }
}
