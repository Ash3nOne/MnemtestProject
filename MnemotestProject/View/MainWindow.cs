using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using MaterialSkin.Controls;
using MaterialSkin;
using MnemotestProject.Presenter;
using MnemotestProject.View;
using System.Reflection;
using System.Text.RegularExpressions;

namespace MnemotestProject
{
    public partial class MainWindow : MaterialForm, IViewMnemotest
    {
        private const int maxAge = 120;
        private const int resultParametersCount = 16;
        private TableLayoutPanel grid;
        private TableLayoutPanel resultTable;
        private List<Button> btns;
        private Stopwatch timer;
        private MnemotestPresenter presenter;
        private List<Template> templates;
        private List<TestResult> results;
        private bool IsLoading { get; set; }

        public string FirstName { get => NameTextBox.Text; set => NameTextBox.Text = value; }
        public string LastName { get => LastNameTextBox.Text; set => LastNameTextBox.Text = value; }
        public string FatherName { get => FatherNameTextBox.Text; set => FatherNameTextBox.Text = value; }
        public string InsurencePolicy { get => InsurencePolicyTextBox.Text; set => InsurencePolicyTextBox.Text = value; }
        public string Age { get => AgeComboBox.Text; set => AgeComboBox.Text = value; }
        public string Gender { get => MaleRadioButton.Checked ? "Мужчина" : "Женщина"; }
        public string ExposureTime { get => ExposureTimeTextBox.Text; set => ExposureTimeTextBox.Text = value; }
        public string PostExposureTime { get => PostExposureTimeTextBox.Text; set => PostExposureTimeTextBox.Text = value; }
        public string PreExposureTime { get => PreExposureTimeTextBox.Text; set => PreExposureTimeTextBox.Text = value; }
        public string Difficult { get => DifficultTextBox.Text; set => DifficultTextBox.Text = value; }
        public string RotateCount { get => RotateComboBox.Text; set => RotateComboBox.Text = value; }
        public string MatrixSize { get => SizeTextBox.Text; set => SizeTextBox.Text = value; }
        public string Attempts { get => AttemptsTextBox.Text; set => AttemptsTextBox.Text = value; }
        public string ReproductionMode { get => ReproductionModeComboBox.Text; set => ReproductionModeComboBox.Text = value; }
        public string Scatter { get => ScatterTextBox.Text; set => ScatterTextBox.Text = value; }

        public MainWindow()
        {
            InitializeComponent();

            presenter = new MnemotestPresenter(this);
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green500, Primary.Green800, Primary.BlueGrey500, Accent.Pink400, TextShade.BLACK);
            AddTemplates();
            for (int i = 0; i < maxAge; i++)
                AgeComboBox.Items.Add(i + 1);
            AgeComboBox.SelectedIndex = 0;
            ReproductionModeComboBox.SelectedIndex = 0;
        }

        private Button CreateButton(int i)
        {
            Button btn = new Button()
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                Tag = i,
                Name = "button" + i,
                FlatStyle = FlatStyle.Flat
            };
            btn.Click += Btn_Click;
            btn.FlatAppearance.BorderSize = 0;
            return btn;
        }

        private void AddTemplates()
        {
            try
            {
                templates = presenter.GetDefaultParameters();
                for (int i = 0; i < templates.Count; i++)
                    TemplateComboBox.Items.Add(templates[i].Name);
            }
            catch (Exception)
            {
                templates = null;
            }
        }

        async private void Btn_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Enabled == true)
            {
                ((Button)sender).BackColor = presenter.GetReproductionMode() ? Color.White : Color.Yellow;
                bool isOver = presenter.AddToAnswers(((Button)sender).Tag.ToString());
                ((Button)sender).Enabled = false;
                if (isOver)
                {
                    timer.Stop();
                    BackPanel.Enabled = false;
                    PrintResult();
                    await Task.Delay(presenter.GetPreExposureTime());
                    presenter.NextAttempt(timer);
                    BackPanel.Enabled = true;
                    if (presenter.AttemptsIsOver())
                        OpenResultWindow();
                    else
                        NewStep();
                }
            }

        }

        private void OpenResultWindow()
        {
            AverageCorrectAnswersLabel.Text = presenter.GetAverageCorrectAnswersCount();
            AverageInvalidAnswersLabel.Text = presenter.GetAverageInvalidAnswersCount();
            AverageTimeLabel.Text = presenter.GetAverageTime();
            DispersionCorrectAnswersLabel.Text = presenter.GetCorrectAnswersDispersion();
            DispersionInvalidAnswersLabel.Text = presenter.GetInvalidAnswersDispersion();
            DispersionTimeLabel.Text = presenter.GetTimeDispersion();
            BackPanel.Visible = false;
            ResultPanel.Visible = true;

        }

        private void PrintResult()
        {
            List<int> verifiedAnswers = presenter.GetVerifiedAnswers();
            List<int> answers = presenter.GetAnswers();
            for (int i = 0; i < verifiedAnswers.Count; i++)
            {
                if (verifiedAnswers[i] == 1)
                    btns[answers[i]].BackColor = Color.Green;
                else
                    btns[answers[i]].BackColor = Color.Red;
            }
        }

        private void AddTitles()
        {
            string text = "";
            for (int i = 0; i < resultParametersCount; i++)
            {
                switch (i)
                {
                    case 0:
                        text = "ФИО";
                        break;
                    case 1:
                        text = "Среднее число правильных ответов";
                        break;
                    case 2:
                        text = "Дисперсия правильных ответов";
                        break;
                    case 3:
                        text = "Среднее число неправильных ответов";
                        break;
                    case 4:
                        text = "Дисперсия неправильных ответов";
                        break;
                    case 5:
                        text = "Среднее время воспроизведения";
                        break;
                    case 6:
                        text = "Дисперсия времени воспроизведения";
                        break;
                    case 7:
                        text = "Время экспозиции";
                        break;
                    case 8:
                        text = "Время постэкспозиции";
                        break;
                    case 9:
                        text = "Время преэкспозиции";
                        break;
                    case 10:
                        text = "Количество закрашеваемых ячеек";
                        break;
                    case 11:
                        text = "Инверсия цвета";
                        break;
                    case 12:
                        text = "Угол поворота";
                        break;
                    case 13:
                        text = "Размер поля";
                        break;
                    case 14:
                        text = "Количество попыток";
                        break;
                    case 15:
                        text = "Разброс";
                        break;
                }

                resultTable.Controls.Add(new Label
                {
                    Dock = DockStyle.Fill,
                    BackColor = Color.LimeGreen,
                    Text = text,
                    Font = new Font("Microsoft Sans Serif", 14),
                    ForeColor = Color.White,
                }, 0, i);
                resultTable.RowStyles.Add(new RowStyle(SizeType.Absolute, (resultTable.Height / resultParametersCount) - 2));
                resultTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300));
            }
        }

        private void AddAllResultsTable()
        {

            resultTable = new TableLayoutPanel()
            {
                Parent = AllResultsPanel,
                Dock = DockStyle.Left,
                ColumnCount = 1,
                RowCount = 0,
                CellBorderStyle = TableLayoutPanelCellBorderStyle.Single,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                AutoScroll = false,
                Visible = false
            };
            SetDoubleBuffered.Set(resultTable);
        }

        private void InitForm()
        {
            grid = new TableLayoutPanel()
            {
                Parent = BackPanel,
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 1,
                CellBorderStyle = TableLayoutPanelCellBorderStyle.Single
            };


            presenter.CreateMnemotest();
            btns = new List<Button>();
            timer = new Stopwatch();
            grid.ColumnCount = presenter.GetSize();
            grid.RowCount = presenter.GetSize();
            for (int i = 0; i < presenter.GetSize(); i++)
            {
                grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100 / presenter.GetSize()));
                grid.RowStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100 / presenter.GetSize()));
            }
            for (int i = 0; i < presenter.GetSize() * presenter.GetSize(); i++)
            {
                btns.Add(CreateButton(i));
                grid.Controls.Add(btns[i]);
            }
            IsLoading = true;

        }

        private void ClearBoard()
        {
            foreach (var btn in btns)
                btn.BackColor = Color.White;

            foreach (var btn in btns)
                btn.Enabled = true;
        }


        private void ClearField()
        {
            foreach (var btn in btns)
                btn.BackColor = presenter.GetReproductionMode() ? Color.Yellow : Color.White;
        }

        private void FieldToAqua()
        {
            foreach (var btn in btns)
                btn.BackColor = Color.Aqua;
        }

        async private void NewStep()
        {
            ClearBoard();
            presenter.MatrixGeneration();
            BackPanel.Enabled = false;
            List<int> matrix = presenter.GetMatrix();
            for (int i = 0; i < presenter.GetSize() * presenter.GetSize(); i++)
            {
                if (matrix[i] == 1)
                    btns[i].BackColor = Color.Yellow;
            }
            await Task.Delay(presenter.GetExposureTime());
            presenter.RotateMatrixClockwise();
            FieldToAqua();
            await Task.Delay(presenter.GetPostExposureTime());
            ClearField();
            BackPanel.Enabled = true;
            timer.Reset();
            timer.Start();
        }

        private bool SettingsIsFilled()
        {
            if (!string.IsNullOrEmpty(ExposureTime) && !string.IsNullOrEmpty(PreExposureTime) && !string.IsNullOrEmpty(PostExposureTime) &&
                 !string.IsNullOrEmpty(Difficult) && !string.IsNullOrEmpty(RotateCount) && !string.IsNullOrEmpty(MatrixSize) && 
                 !string.IsNullOrEmpty(Attempts) && !string.IsNullOrEmpty(Scatter))
                return true;
            return false;
        }

        private bool PersonIsFilled()
        {
            MaterialMaskedTextBox temp = Clone(InsurencePolicyTextBox);
            temp.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            temp.Text = temp.Text.Replace(" ", "");
            if (!string.IsNullOrEmpty(FirstName) && !string.IsNullOrEmpty(LastName) && temp.Text.Length == 16 &&
                 (FemaleRadioButton.Checked != false || MaleRadioButton.Checked != false))
                return true;
            return false;
        }


        private bool IsFilled()
        {

            if (PersonIsFilled() && SettingsIsFilled())
                return true;
            else
                return false;

        }

        /// <summary>
        /// Клонирование Control.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="controlToClone"></param>
        /// <returns>Control</returns>
        private T Clone<T>(T controlToClone) where T : Control
        {
            T instance = Activator.CreateInstance<T>();

            Type control = controlToClone.GetType();
            PropertyInfo[] info = control.GetProperties();
            object p = control.InvokeMember("", System.Reflection.BindingFlags.CreateInstance, null, controlToClone, null);
            foreach (PropertyInfo pi in info)
            {
                if ((pi.CanWrite) && !(pi.Name == "WindowTarget") && !(pi.Name == "Capture"))
                {
                    pi.SetValue(instance, pi.GetValue(controlToClone, null), null);
                }
            }
            return instance;
        }

        async private void StartButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (SettingsIsCorrect() && PersonIsCorrect())
                {
                    WaitLabel.Visible = true;
                    await Task.Delay(100);
                    LoadingTimer.Start();
                    IsLoading = false;
                    InitForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }

        }

        private void DrawTestPanel()
        {
            BackPanel.Visible = true;
            MainTabControl.Visible = false;
            this.DrawerShowIconsWhenHidden = false;
            this.DrawerTabControl = null;
            StartPanel.Visible = false;
            DialogResult result = MessageBox.Show($"Время на запоминание - {presenter.GetExposureTime() / 1000} с.\nГотовы?", "Уведомление", MessageBoxButtons.OK);
            if (result == DialogResult.OK)
                NewStep();
        }

        private void PersonTextBox_Changed(object sender, EventArgs e)
        {
            if ((sender is MaterialTextBox) && (sender as MaterialTextBox).Text.Length == 1)
            {
                ((MaterialTextBox)sender).Text = ((MaterialTextBox)sender).Text.ToUpper();
                ((MaterialTextBox)sender).SelectionStart = ((MaterialTextBox)sender).Text.Length;
            }
            CheckTextBoxes();
        }

        private void InsurencePolicyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
                if (!string.IsNullOrEmpty(InsurencePolicyTextBox.Text))
                {
                    if (InsurencePolicyTextBox.SelectionLength > 0)
                    {
                        int StartPosDel = InsurencePolicyTextBox.SelectionStart;
                        int LenSelection = InsurencePolicyTextBox.SelectionLength;
                        InsurencePolicyTextBox.Text = InsurencePolicyTextBox.Text.Remove(StartPosDel, LenSelection);
                        InsurencePolicyTextBox.SelectionStart = InsurencePolicyTextBox.Text.Length;
                    }
                    else
                    {
                        InsurencePolicyTextBox.Text = InsurencePolicyTextBox.Text.Remove(InsurencePolicyTextBox.Text.Length - 1);
                        InsurencePolicyTextBox.SelectionStart = InsurencePolicyTextBox.Text.Length;
                    }
                }
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch))
                e.Handled = true;
        }

        private void PersonTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(e.KeyChar >= 'А' && e.KeyChar <= 'Я'))
                if (!(e.KeyChar >= 'а' && e.KeyChar <= 'я'))
                        e.Handled = true;
        }


        private bool SettingsIsCorrect()
        {
            int expTime = Convert.ToInt32(ExposureTime);
            int preExpTime = Convert.ToInt32(PreExposureTime);
            int postExpTime = Convert.ToInt32(PostExposureTime);
            int attempts = Convert.ToInt32(Attempts);

            int m = Convert.ToInt32(MatrixSize);
            int n = m * m;
            int diffucltTemp = Convert.ToInt32(Difficult);

            if (expTime == 0 || preExpTime == 0 || postExpTime == 0 || attempts == 0 || m == 0 || diffucltTemp == 0)
                throw new Exception("Параметры не могут быть нулевыми.");
            if (m > 15)
                throw new Exception("Размер поля не может быть больше 15х15.");
            if (diffucltTemp > n)
                throw new Exception("Количество закрашеваемых ячеек больше размера поля.");
            return true;
        }

        private bool PersonIsCorrect()
        {

            Regex.IsMatch(LastName, "^[А-Яа-я]+$");


            bool isLetter = Regex.IsMatch(LastName, "^[А-Яа-я]+$") && Regex.IsMatch(FirstName, "^[А-Яа-я]+$") && (Regex.IsMatch(FatherName, "^[А-Яа-я]+$") || FatherName == "");

           
            if (!isLetter)
                throw new Exception("Некорректные личные данные.");

            return true;
        }

        private void CheckTextBoxes()
        {
            try
            {
                if (IsFilled())
                {
                    StartButton.Enabled = true;
                    return;
                }
                StartButton.Enabled = false;
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }


        private void SettingTextBox_Changed(object sender, EventArgs e)
        {
            if (sender is MaterialTextBox)
            {
                if (((MaterialTextBox)sender).Text.Length >= 1 && ((MaterialTextBox)sender).Text[0] == '0')
                    ((MaterialTextBox)sender).Text = ((MaterialTextBox)sender).Text.Substring(1);
            }
            CheckTextBoxes();
        }

        private void SettingsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch))
                e.Handled = true;
        }

        private void RepeatsTextBox_Changed(object sender, EventArgs e)
        {
            if (((MaterialTextBox)sender).Text.Length > 1 && ((MaterialTextBox)sender).Text[0] == '0')
            {
                ((MaterialTextBox)sender).Text = ((MaterialTextBox)sender).Text.Substring(1);
                ((MaterialTextBox)sender).SelectionStart = ((MaterialTextBox)sender).Text.Length;
            }
            CheckTextBoxes();

        }

        private void SaveToDBButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (presenter.IsValidPerson())
                {
                    presenter.AddToDB();
                    SaveToDBButton.Enabled = false;
                    MessageBox.Show("Сохранено.", "Уведомление");
                }
                else
                    throw new Exception("Пользователь с таким полисом и другими личными данными уже имеется в базе данных. Результат сохранить невозможно. Для успешного сохранения данных введите корректные личные данные и полис.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            BackPanel.Controls.Clear();
            ResultPanel.Visible = false;
            MainTabControl.Visible = true;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = MainTabControl;
            StartPanel.Visible = true;
            SaveToDBButton.Enabled = true;
        }

        private void LoadingTimer_Tick(object sender, EventArgs e)
        {
            if (IsLoading)
            {
                LoadingTimer.Stop();
                WaitLabel.Visible = false;
                DrawTestPanel();
                IsLoading = false;
            }
        }

        private void TemplateToBoxes(int index)
        {
            if (index >= 0)
            {
                ExposureTime = templates[index].ExposureTime;
                PreExposureTime = templates[index].PreExposureTime;
                PostExposureTime = templates[index].PostExposureTime;
                Difficult = templates[index].Difficult;
                RotateCount = templates[index].RotateCount;
                MatrixSize = templates[index].Size;
                Attempts = templates[index].Attempts;
                ReproductionMode = templates[index].ReproductionMode;
                Scatter = templates[index].Scatter;
                Refresh();
            }
        }

        private void FillResultTable()
        {
            for (int col = 0; col < results.Count; col++)
            {
                resultTable.ColumnCount++;
                for (int row = 0; row < resultParametersCount; row++)
                {
                    resultTable.Controls.Add(new MaterialLabel
                    {
                        Dock = DockStyle.Fill,
                        Text = results[col].GetParameterForIndex(row),
                        FontType = MaterialSkinManager.fontType.H6
                    }, col + 1, row);
                    resultTable.RowStyles.Add(new RowStyle(SizeType.Absolute, (resultTable.Height / resultParametersCount) - 2));
                    resultTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200));
                }

            }


        }

        private void TemplateComboBox_TextChanged(object sender, EventArgs e)
        {
            TemplateToBoxes(TemplateComboBox.SelectedIndex - 1);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (resultTable != null)
                    resultTable.Dispose();
                results = presenter.GetAllTestResults(AllResultsInsurancePolicyTextBox.Text);
                AddAllResultsTable();
                AddTitles();
                FillResultTable();
                resultTable.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        private void SaveToExcelButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (resultTable == null)
                    throw new Exception("Нет данных для сохранения.");
                SaveFileDialog.DefaultExt = "*.xls";
                SaveFileDialog.Filter = "Excel files|*.xls";
                DialogResult dialogResult = SaveFileDialog.ShowDialog();

                if (dialogResult == DialogResult.OK)
                    presenter.AddToExcel(SaveFileDialog.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void AddTemplateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!SettingsIsFilled())
                    throw new Exception("Все поля с настройками должны быть заполнены.");
                if (SettingsIsCorrect())
                {
                    InputTemplateNameForm inputTemplateName = new InputTemplateNameForm(new Template(ExposureTime, PostExposureTime, PreExposureTime, Difficult, ReproductionMode, RotateCount, MatrixSize, Attempts, Scatter));
                    inputTemplateName.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка.");
            }
        }

        private void SettingsTimeTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
                (sender as MaterialTextBox).Text = "";
        }
    }
}
