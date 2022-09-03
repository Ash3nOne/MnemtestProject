using MaterialSkin;
using MaterialSkin.Controls;
using MnemotestProject.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MnemotestProject.View
{
    public partial class InputTemplateNameForm : MaterialForm, IInputTemplateNameForm
    {
        private InputTemplateNameFormPresenter presenter;
        private Template parametersTemplate;
        public Template ParametersTemplate { get => parametersTemplate; set => parametersTemplate = value; }
        public string TemplateName { get => TemplateNameTextBox.Text; set => TemplateName = value; }

        public InputTemplateNameForm(Template parameters)
        {
            InitializeComponent();
            ParametersTemplate = parameters;
            presenter = new InputTemplateNameFormPresenter(this);
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green500, Primary.Green800, Primary.BlueGrey500, Accent.Pink400, TextShade.BLACK);
        }



        private void AddTemplateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(TemplateNameTextBox.Text))
                {
                    throw new Exception("Имя не может быть пустым");
                }
                presenter.AddTemplateToDB();
                MessageBox.Show("Успешно. Шаблон появится после перезагрузки приложения.", "Уведомление");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

    }
}
