using MnemotestProject.Model;
using MnemotestProject.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MnemotestProject.Presenter
{
    public sealed class InputTemplateNameFormPresenter
    {
        private IInputTemplateNameForm view;

        public InputTemplateNameFormPresenter(IInputTemplateNameForm inputTemplateNameView)
        {
            view = inputTemplateNameView;
        }

        public void AddTemplateToDB()
        {
            int exposureTime = Convert.ToInt32(view.ParametersTemplate.ExposureTime);
            int postExposureTime = Convert.ToInt32(view.ParametersTemplate.PostExposureTime);
            int preExposureTime = Convert.ToInt32(view.ParametersTemplate.PreExposureTime);
            int difficult = Convert.ToInt32(view.ParametersTemplate.Difficult);
            int rotateCount = Convert.ToInt32(view.ParametersTemplate.RotateCount == "90" ? "1" : (view.ParametersTemplate.RotateCount == "180" ? "2" : (view.ParametersTemplate.RotateCount == "270" ? "3" : "0")));
            int size = Convert.ToInt32(view.ParametersTemplate.Size);
            int attempts = Convert.ToInt32(view.ParametersTemplate.Attempts);
            bool reproductionMode = view.ParametersTemplate.ReproductionMode == "Да";
            int scatter = Convert.ToInt32(view.ParametersTemplate.Scatter);
            MnemotestParameters parameters = new MnemotestParameters(exposureTime, postExposureTime, preExposureTime, difficult, reproductionMode, rotateCount, size, attempts, scatter);
            MnemotestDB.AddTemplateToDB(view.TemplateName, parameters);
        }

    }
}
