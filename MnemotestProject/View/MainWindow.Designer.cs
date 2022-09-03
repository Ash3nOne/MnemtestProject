namespace MnemotestProject
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.BackPanel = new System.Windows.Forms.Panel();
            this.StartPanel = new System.Windows.Forms.Panel();
            this.MainTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.ReadyTabPage = new System.Windows.Forms.TabPage();
            this.WaitLabel = new MaterialSkin.Controls.MaterialLabel();
            this.StartButton = new MaterialSkin.Controls.MaterialButton();
            this.RulesLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.RulesLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.RulesTitleLabel = new MaterialSkin.Controls.MaterialLabel();
            this.PersonTabPage = new System.Windows.Forms.TabPage();
            this.InsurencePolicyTextBox = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.PersonTitleLabel = new MaterialSkin.Controls.MaterialLabel();
            this.AgeComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.FemaleRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.MaleRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.FatherNameTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.LastNameTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.NameTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.SettingsTabPage = new System.Windows.Forms.TabPage();
            this.AddTemplateButton = new MaterialSkin.Controls.MaterialButton();
            this.ScatterTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.TemplateComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.ReproductionModeComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.AttemptsTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.RotateComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.SizeTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.DifficultTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.PostExposureTimeTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.PreExposureTimeTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.ExposureTimeTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.SettingsTitleLabel = new MaterialSkin.Controls.MaterialLabel();
            this.ResultsTabPage = new System.Windows.Forms.TabPage();
            this.SaveToExcelButton = new MaterialSkin.Controls.MaterialButton();
            this.SearchButton = new MaterialSkin.Controls.MaterialButton();
            this.AllResultsInsurancePolicyTextBox = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.AllResultsTitle = new MaterialSkin.Controls.MaterialLabel();
            this.PanelForAllResultsPanel = new System.Windows.Forms.Panel();
            this.AllResultsPanel = new System.Windows.Forms.Panel();
            this.MenuImageList = new System.Windows.Forms.ImageList(this.components);
            this.ResultPanel = new System.Windows.Forms.Panel();
            this.QuitButton = new MaterialSkin.Controls.MaterialButton();
            this.SaveToDBButton = new MaterialSkin.Controls.MaterialButton();
            this.ResultTitleLabel = new MaterialSkin.Controls.MaterialLabel();
            this.ResultTable = new System.Windows.Forms.TableLayoutPanel();
            this.DispersionTimeLabel = new MaterialSkin.Controls.MaterialLabel();
            this.DispersionTimeTitle = new MaterialSkin.Controls.MaterialLabel();
            this.AverageInvalidAnswersLabel = new MaterialSkin.Controls.MaterialLabel();
            this.DispersionInvalidAnswersTitle = new MaterialSkin.Controls.MaterialLabel();
            this.AverageInvalidAnswersTitle = new MaterialSkin.Controls.MaterialLabel();
            this.AverageTimeLabel = new MaterialSkin.Controls.MaterialLabel();
            this.AverageTimeTitle = new MaterialSkin.Controls.MaterialLabel();
            this.DispersionCorrectAnswersLabel = new MaterialSkin.Controls.MaterialLabel();
            this.DispersionCorrectAnswersTitle = new MaterialSkin.Controls.MaterialLabel();
            this.AverageCorrectAnswersTitle = new MaterialSkin.Controls.MaterialLabel();
            this.AverageCorrectAnswersLabel = new MaterialSkin.Controls.MaterialLabel();
            this.DispersionInvalidAnswersLabel = new MaterialSkin.Controls.MaterialLabel();
            this.LoadingTimer = new System.Windows.Forms.Timer(this.components);
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.StartPanel.SuspendLayout();
            this.MainTabControl.SuspendLayout();
            this.ReadyTabPage.SuspendLayout();
            this.PersonTabPage.SuspendLayout();
            this.SettingsTabPage.SuspendLayout();
            this.ResultsTabPage.SuspendLayout();
            this.PanelForAllResultsPanel.SuspendLayout();
            this.ResultPanel.SuspendLayout();
            this.ResultTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackPanel
            // 
            this.BackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackPanel.Location = new System.Drawing.Point(3, 64);
            this.BackPanel.Name = "BackPanel";
            this.BackPanel.Size = new System.Drawing.Size(994, 833);
            this.BackPanel.TabIndex = 0;
            // 
            // StartPanel
            // 
            this.StartPanel.Controls.Add(this.MainTabControl);
            this.StartPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StartPanel.Location = new System.Drawing.Point(3, 64);
            this.StartPanel.Name = "StartPanel";
            this.StartPanel.Size = new System.Drawing.Size(994, 833);
            this.StartPanel.TabIndex = 1;
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.ReadyTabPage);
            this.MainTabControl.Controls.Add(this.PersonTabPage);
            this.MainTabControl.Controls.Add(this.SettingsTabPage);
            this.MainTabControl.Controls.Add(this.ResultsTabPage);
            this.MainTabControl.Depth = 0;
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.ImageList = this.MenuImageList;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.MainTabControl.Multiline = true;
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(994, 833);
            this.MainTabControl.TabIndex = 2;
            // 
            // ReadyTabPage
            // 
            this.ReadyTabPage.Controls.Add(this.WaitLabel);
            this.ReadyTabPage.Controls.Add(this.StartButton);
            this.ReadyTabPage.Controls.Add(this.RulesLabel2);
            this.ReadyTabPage.Controls.Add(this.RulesLabel1);
            this.ReadyTabPage.Controls.Add(this.RulesTitleLabel);
            this.ReadyTabPage.ImageKey = "icons8-галочка-32.png";
            this.ReadyTabPage.Location = new System.Drawing.Point(4, 39);
            this.ReadyTabPage.Name = "ReadyTabPage";
            this.ReadyTabPage.Size = new System.Drawing.Size(986, 790);
            this.ReadyTabPage.TabIndex = 2;
            this.ReadyTabPage.Text = "Запуск";
            this.ReadyTabPage.UseVisualStyleBackColor = true;
            // 
            // WaitLabel
            // 
            this.WaitLabel.AutoSize = true;
            this.WaitLabel.Depth = 0;
            this.WaitLabel.Font = new System.Drawing.Font("Roboto Light", 96F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.WaitLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H1;
            this.WaitLabel.Location = new System.Drawing.Point(272, 290);
            this.WaitLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.WaitLabel.Name = "WaitLabel";
            this.WaitLabel.Size = new System.Drawing.Size(467, 115);
            this.WaitLabel.TabIndex = 4;
            this.WaitLabel.Text = "Загрузка...";
            this.WaitLabel.Visible = false;
            // 
            // StartButton
            // 
            this.StartButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.StartButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.StartButton.Depth = 0;
            this.StartButton.Enabled = false;
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartButton.HighEmphasis = true;
            this.StartButton.Icon = null;
            this.StartButton.Location = new System.Drawing.Point(372, 474);
            this.StartButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.StartButton.MinimumSize = new System.Drawing.Size(220, 100);
            this.StartButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.StartButton.Name = "StartButton";
            this.StartButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.StartButton.Size = new System.Drawing.Size(220, 100);
            this.StartButton.TabIndex = 3;
            this.StartButton.Text = "Начать";
            this.StartButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.StartButton.UseAccentColor = false;
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // RulesLabel2
            // 
            this.RulesLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RulesLabel2.Depth = 0;
            this.RulesLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.RulesLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.RulesLabel2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.RulesLabel2.ImageKey = "(отсутствует)";
            this.RulesLabel2.Location = new System.Drawing.Point(25, 216);
            this.RulesLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.RulesLabel2.Name = "RulesLabel2";
            this.RulesLabel2.Size = new System.Drawing.Size(904, 200);
            this.RulesLabel2.TabIndex = 2;
            this.RulesLabel2.Text = "   Для начала, заполните вкладки с личными данными и настройками теста. После чег" +
    "о, кнопка \"Начать\" станет активной.";
            // 
            // RulesLabel1
            // 
            this.RulesLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RulesLabel1.Depth = 0;
            this.RulesLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.RulesLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.RulesLabel1.Location = new System.Drawing.Point(25, 67);
            this.RulesLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.RulesLabel1.Name = "RulesLabel1";
            this.RulesLabel1.Size = new System.Drawing.Size(924, 408);
            this.RulesLabel1.TabIndex = 1;
            this.RulesLabel1.Text = resources.GetString("RulesLabel1.Text");
            // 
            // RulesTitleLabel
            // 
            this.RulesTitleLabel.AutoSize = true;
            this.RulesTitleLabel.Depth = 0;
            this.RulesTitleLabel.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.RulesTitleLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.RulesTitleLabel.Location = new System.Drawing.Point(391, 16);
            this.RulesTitleLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.RulesTitleLabel.Name = "RulesTitleLabel";
            this.RulesTitleLabel.Size = new System.Drawing.Size(191, 41);
            this.RulesTitleLabel.TabIndex = 0;
            this.RulesTitleLabel.Text = "Инструкция";
            // 
            // PersonTabPage
            // 
            this.PersonTabPage.Controls.Add(this.InsurencePolicyTextBox);
            this.PersonTabPage.Controls.Add(this.PersonTitleLabel);
            this.PersonTabPage.Controls.Add(this.AgeComboBox);
            this.PersonTabPage.Controls.Add(this.FemaleRadioButton);
            this.PersonTabPage.Controls.Add(this.MaleRadioButton);
            this.PersonTabPage.Controls.Add(this.FatherNameTextBox);
            this.PersonTabPage.Controls.Add(this.LastNameTextBox);
            this.PersonTabPage.Controls.Add(this.NameTextBox);
            this.PersonTabPage.ImageKey = "icons8-лицо-в-профиль-32.png";
            this.PersonTabPage.Location = new System.Drawing.Point(4, 39);
            this.PersonTabPage.Name = "PersonTabPage";
            this.PersonTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.PersonTabPage.Size = new System.Drawing.Size(986, 790);
            this.PersonTabPage.TabIndex = 0;
            this.PersonTabPage.Text = "Личные данные";
            this.PersonTabPage.UseVisualStyleBackColor = true;
            // 
            // InsurencePolicyTextBox
            // 
            this.InsurencePolicyTextBox.AllowPromptAsInput = true;
            this.InsurencePolicyTextBox.AnimateReadOnly = false;
            this.InsurencePolicyTextBox.AsciiOnly = false;
            this.InsurencePolicyTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.InsurencePolicyTextBox.BeepOnError = false;
            this.InsurencePolicyTextBox.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.InsurencePolicyTextBox.Depth = 0;
            this.InsurencePolicyTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.InsurencePolicyTextBox.HidePromptOnLeave = false;
            this.InsurencePolicyTextBox.HideSelection = true;
            this.InsurencePolicyTextBox.Hint = "Полис";
            this.InsurencePolicyTextBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.InsurencePolicyTextBox.LeadingIcon = null;
            this.InsurencePolicyTextBox.Location = new System.Drawing.Point(20, 364);
            this.InsurencePolicyTextBox.Mask = "0000-0000-0000-0000";
            this.InsurencePolicyTextBox.MaxLength = 32767;
            this.InsurencePolicyTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.InsurencePolicyTextBox.Name = "InsurencePolicyTextBox";
            this.InsurencePolicyTextBox.PasswordChar = '\0';
            this.InsurencePolicyTextBox.PrefixSuffixText = null;
            this.InsurencePolicyTextBox.PromptChar = '_';
            this.InsurencePolicyTextBox.ReadOnly = false;
            this.InsurencePolicyTextBox.RejectInputOnFirstFailure = false;
            this.InsurencePolicyTextBox.ResetOnPrompt = true;
            this.InsurencePolicyTextBox.ResetOnSpace = true;
            this.InsurencePolicyTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.InsurencePolicyTextBox.SelectedText = "";
            this.InsurencePolicyTextBox.SelectionLength = 0;
            this.InsurencePolicyTextBox.SelectionStart = 0;
            this.InsurencePolicyTextBox.ShortcutsEnabled = true;
            this.InsurencePolicyTextBox.Size = new System.Drawing.Size(901, 48);
            this.InsurencePolicyTextBox.SkipLiterals = true;
            this.InsurencePolicyTextBox.TabIndex = 10;
            this.InsurencePolicyTextBox.TabStop = false;
            this.InsurencePolicyTextBox.Text = "    -    -    -";
            this.InsurencePolicyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.InsurencePolicyTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.InsurencePolicyTextBox.TrailingIcon = null;
            this.InsurencePolicyTextBox.UseSystemPasswordChar = false;
            this.InsurencePolicyTextBox.ValidatingType = null;
            this.InsurencePolicyTextBox.TextChanged += new System.EventHandler(this.PersonTextBox_Changed);
            // 
            // PersonTitleLabel
            // 
            this.PersonTitleLabel.AutoSize = true;
            this.PersonTitleLabel.Depth = 0;
            this.PersonTitleLabel.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.PersonTitleLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.PersonTitleLabel.Location = new System.Drawing.Point(343, 13);
            this.PersonTitleLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.PersonTitleLabel.Name = "PersonTitleLabel";
            this.PersonTitleLabel.Size = new System.Drawing.Size(259, 41);
            this.PersonTitleLabel.TabIndex = 9;
            this.PersonTitleLabel.Text = "Личные данные";
            // 
            // AgeComboBox
            // 
            this.AgeComboBox.AutoResize = false;
            this.AgeComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AgeComboBox.Depth = 0;
            this.AgeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.AgeComboBox.DropDownHeight = 174;
            this.AgeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AgeComboBox.DropDownWidth = 121;
            this.AgeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.AgeComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AgeComboBox.FormattingEnabled = true;
            this.AgeComboBox.Hint = "Возраст";
            this.AgeComboBox.IntegralHeight = false;
            this.AgeComboBox.ItemHeight = 43;
            this.AgeComboBox.Location = new System.Drawing.Point(20, 309);
            this.AgeComboBox.MaxDropDownItems = 4;
            this.AgeComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.AgeComboBox.Name = "AgeComboBox";
            this.AgeComboBox.Size = new System.Drawing.Size(105, 49);
            this.AgeComboBox.StartIndex = 0;
            this.AgeComboBox.TabIndex = 8;
            // 
            // FemaleRadioButton
            // 
            this.FemaleRadioButton.AutoSize = true;
            this.FemaleRadioButton.Depth = 0;
            this.FemaleRadioButton.Location = new System.Drawing.Point(138, 260);
            this.FemaleRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.FemaleRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.FemaleRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.FemaleRadioButton.Name = "FemaleRadioButton";
            this.FemaleRadioButton.Ripple = true;
            this.FemaleRadioButton.Size = new System.Drawing.Size(107, 37);
            this.FemaleRadioButton.TabIndex = 7;
            this.FemaleRadioButton.TabStop = true;
            this.FemaleRadioButton.Text = "Женщина";
            this.FemaleRadioButton.UseVisualStyleBackColor = true;
            this.FemaleRadioButton.CheckedChanged += new System.EventHandler(this.PersonTextBox_Changed);
            // 
            // MaleRadioButton
            // 
            this.MaleRadioButton.AutoSize = true;
            this.MaleRadioButton.Depth = 0;
            this.MaleRadioButton.Location = new System.Drawing.Point(20, 260);
            this.MaleRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.MaleRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.MaleRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.MaleRadioButton.Name = "MaleRadioButton";
            this.MaleRadioButton.Ripple = true;
            this.MaleRadioButton.Size = new System.Drawing.Size(105, 37);
            this.MaleRadioButton.TabIndex = 6;
            this.MaleRadioButton.TabStop = true;
            this.MaleRadioButton.Text = "Мужчина";
            this.MaleRadioButton.UseVisualStyleBackColor = true;
            this.MaleRadioButton.CheckedChanged += new System.EventHandler(this.PersonTextBox_Changed);
            // 
            // FatherNameTextBox
            // 
            this.FatherNameTextBox.AnimateReadOnly = false;
            this.FatherNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FatherNameTextBox.Depth = 0;
            this.FatherNameTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FatherNameTextBox.Hint = "Отчество (необязательно)";
            this.FatherNameTextBox.LeadingIcon = null;
            this.FatherNameTextBox.Location = new System.Drawing.Point(20, 197);
            this.FatherNameTextBox.MaxLength = 50;
            this.FatherNameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.FatherNameTextBox.Multiline = false;
            this.FatherNameTextBox.Name = "FatherNameTextBox";
            this.FatherNameTextBox.Size = new System.Drawing.Size(901, 50);
            this.FatherNameTextBox.TabIndex = 4;
            this.FatherNameTextBox.Text = "";
            this.FatherNameTextBox.TrailingIcon = null;
            this.FatherNameTextBox.TextChanged += new System.EventHandler(this.PersonTextBox_Changed);
            this.FatherNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PersonTextBox_KeyPress);
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.AnimateReadOnly = false;
            this.LastNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LastNameTextBox.Depth = 0;
            this.LastNameTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LastNameTextBox.Hint = "Фамилия";
            this.LastNameTextBox.LeadingIcon = null;
            this.LastNameTextBox.Location = new System.Drawing.Point(20, 85);
            this.LastNameTextBox.MaxLength = 50;
            this.LastNameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.LastNameTextBox.Multiline = false;
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(901, 50);
            this.LastNameTextBox.TabIndex = 3;
            this.LastNameTextBox.Text = "";
            this.LastNameTextBox.TrailingIcon = null;
            this.LastNameTextBox.TextChanged += new System.EventHandler(this.PersonTextBox_Changed);
            this.LastNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PersonTextBox_KeyPress);
            // 
            // NameTextBox
            // 
            this.NameTextBox.AnimateReadOnly = false;
            this.NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameTextBox.Depth = 0;
            this.NameTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.NameTextBox.Hint = "Имя";
            this.NameTextBox.LeadingIcon = null;
            this.NameTextBox.Location = new System.Drawing.Point(20, 141);
            this.NameTextBox.MaxLength = 50;
            this.NameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.NameTextBox.Multiline = false;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(901, 50);
            this.NameTextBox.TabIndex = 2;
            this.NameTextBox.Text = "";
            this.NameTextBox.TrailingIcon = null;
            this.NameTextBox.TextChanged += new System.EventHandler(this.PersonTextBox_Changed);
            this.NameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PersonTextBox_KeyPress);
            // 
            // SettingsTabPage
            // 
            this.SettingsTabPage.Controls.Add(this.AddTemplateButton);
            this.SettingsTabPage.Controls.Add(this.ScatterTextBox);
            this.SettingsTabPage.Controls.Add(this.TemplateComboBox);
            this.SettingsTabPage.Controls.Add(this.ReproductionModeComboBox);
            this.SettingsTabPage.Controls.Add(this.AttemptsTextBox);
            this.SettingsTabPage.Controls.Add(this.RotateComboBox);
            this.SettingsTabPage.Controls.Add(this.SizeTextBox);
            this.SettingsTabPage.Controls.Add(this.DifficultTextBox);
            this.SettingsTabPage.Controls.Add(this.PostExposureTimeTextBox);
            this.SettingsTabPage.Controls.Add(this.PreExposureTimeTextBox);
            this.SettingsTabPage.Controls.Add(this.ExposureTimeTextBox);
            this.SettingsTabPage.Controls.Add(this.SettingsTitleLabel);
            this.SettingsTabPage.ImageKey = "icons8-настройки-32.png";
            this.SettingsTabPage.Location = new System.Drawing.Point(4, 39);
            this.SettingsTabPage.Name = "SettingsTabPage";
            this.SettingsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SettingsTabPage.Size = new System.Drawing.Size(986, 790);
            this.SettingsTabPage.TabIndex = 1;
            this.SettingsTabPage.Text = "Настройки";
            this.SettingsTabPage.UseVisualStyleBackColor = true;
            // 
            // AddTemplateButton
            // 
            this.AddTemplateButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddTemplateButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.AddTemplateButton.Depth = 0;
            this.AddTemplateButton.HighEmphasis = true;
            this.AddTemplateButton.Icon = null;
            this.AddTemplateButton.Location = new System.Drawing.Point(20, 642);
            this.AddTemplateButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddTemplateButton.MinimumSize = new System.Drawing.Size(100, 48);
            this.AddTemplateButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddTemplateButton.Name = "AddTemplateButton";
            this.AddTemplateButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.AddTemplateButton.Size = new System.Drawing.Size(177, 48);
            this.AddTemplateButton.TabIndex = 22;
            this.AddTemplateButton.Text = "Сохранить шаблон";
            this.AddTemplateButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AddTemplateButton.UseAccentColor = false;
            this.AddTemplateButton.UseVisualStyleBackColor = true;
            this.AddTemplateButton.Click += new System.EventHandler(this.AddTemplateButton_Click);
            // 
            // ScatterTextBox
            // 
            this.ScatterTextBox.AnimateReadOnly = false;
            this.ScatterTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ScatterTextBox.Depth = 0;
            this.ScatterTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ScatterTextBox.Hint = "Разброс";
            this.ScatterTextBox.LeadingIcon = null;
            this.ScatterTextBox.Location = new System.Drawing.Point(20, 574);
            this.ScatterTextBox.MaxLength = 2;
            this.ScatterTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.ScatterTextBox.Multiline = false;
            this.ScatterTextBox.Name = "ScatterTextBox";
            this.ScatterTextBox.Size = new System.Drawing.Size(901, 50);
            this.ScatterTextBox.TabIndex = 21;
            this.ScatterTextBox.Text = "";
            this.ScatterTextBox.TrailingIcon = null;
            this.ScatterTextBox.TextChanged += new System.EventHandler(this.RepeatsTextBox_Changed);
            this.ScatterTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SettingsTimeTextBox_KeyDown);
            this.ScatterTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SettingsTextBox_KeyPress);
            // 
            // TemplateComboBox
            // 
            this.TemplateComboBox.AutoResize = false;
            this.TemplateComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TemplateComboBox.Depth = 0;
            this.TemplateComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.TemplateComboBox.DropDownHeight = 174;
            this.TemplateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TemplateComboBox.DropDownWidth = 121;
            this.TemplateComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.TemplateComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TemplateComboBox.FormattingEnabled = true;
            this.TemplateComboBox.Hint = "Шаблон параметров";
            this.TemplateComboBox.IntegralHeight = false;
            this.TemplateComboBox.ItemHeight = 43;
            this.TemplateComboBox.Items.AddRange(new object[] {
            "Свой"});
            this.TemplateComboBox.Location = new System.Drawing.Point(20, 73);
            this.TemplateComboBox.MaxDropDownItems = 4;
            this.TemplateComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.TemplateComboBox.Name = "TemplateComboBox";
            this.TemplateComboBox.Size = new System.Drawing.Size(377, 49);
            this.TemplateComboBox.StartIndex = 0;
            this.TemplateComboBox.TabIndex = 20;
            this.TemplateComboBox.SelectedIndexChanged += new System.EventHandler(this.TemplateComboBox_TextChanged);
            // 
            // ReproductionModeComboBox
            // 
            this.ReproductionModeComboBox.AutoResize = false;
            this.ReproductionModeComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ReproductionModeComboBox.Depth = 0;
            this.ReproductionModeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ReproductionModeComboBox.DropDownHeight = 174;
            this.ReproductionModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ReproductionModeComboBox.DropDownWidth = 121;
            this.ReproductionModeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ReproductionModeComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ReproductionModeComboBox.FormattingEnabled = true;
            this.ReproductionModeComboBox.Hint = "Инверсия цвета";
            this.ReproductionModeComboBox.IntegralHeight = false;
            this.ReproductionModeComboBox.ItemHeight = 43;
            this.ReproductionModeComboBox.Items.AddRange(new object[] {
            "Нет",
            "Да"});
            this.ReproductionModeComboBox.Location = new System.Drawing.Point(20, 352);
            this.ReproductionModeComboBox.MaxDropDownItems = 4;
            this.ReproductionModeComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.ReproductionModeComboBox.Name = "ReproductionModeComboBox";
            this.ReproductionModeComboBox.Size = new System.Drawing.Size(164, 49);
            this.ReproductionModeComboBox.StartIndex = 0;
            this.ReproductionModeComboBox.TabIndex = 19;
            // 
            // AttemptsTextBox
            // 
            this.AttemptsTextBox.AnimateReadOnly = false;
            this.AttemptsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AttemptsTextBox.Depth = 0;
            this.AttemptsTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.AttemptsTextBox.Hint = "Количество образов, шт";
            this.AttemptsTextBox.LeadingIcon = null;
            this.AttemptsTextBox.Location = new System.Drawing.Point(20, 518);
            this.AttemptsTextBox.MaxLength = 50;
            this.AttemptsTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.AttemptsTextBox.Multiline = false;
            this.AttemptsTextBox.Name = "AttemptsTextBox";
            this.AttemptsTextBox.Size = new System.Drawing.Size(901, 50);
            this.AttemptsTextBox.TabIndex = 17;
            this.AttemptsTextBox.Text = "";
            this.AttemptsTextBox.TrailingIcon = null;
            this.AttemptsTextBox.TextChanged += new System.EventHandler(this.SettingTextBox_Changed);
            this.AttemptsTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SettingsTimeTextBox_KeyDown);
            this.AttemptsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SettingsTextBox_KeyPress);
            // 
            // RotateComboBox
            // 
            this.RotateComboBox.AutoResize = false;
            this.RotateComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RotateComboBox.Depth = 0;
            this.RotateComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.RotateComboBox.DropDownHeight = 174;
            this.RotateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RotateComboBox.DropDownWidth = 121;
            this.RotateComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.RotateComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RotateComboBox.FormattingEnabled = true;
            this.RotateComboBox.Hint = "Угол поворота";
            this.RotateComboBox.IntegralHeight = false;
            this.RotateComboBox.ItemHeight = 43;
            this.RotateComboBox.Items.AddRange(new object[] {
            "0",
            "90",
            "180",
            "270"});
            this.RotateComboBox.Location = new System.Drawing.Point(20, 407);
            this.RotateComboBox.MaxDropDownItems = 4;
            this.RotateComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.RotateComboBox.Name = "RotateComboBox";
            this.RotateComboBox.Size = new System.Drawing.Size(164, 49);
            this.RotateComboBox.StartIndex = 0;
            this.RotateComboBox.TabIndex = 16;
            // 
            // SizeTextBox
            // 
            this.SizeTextBox.AnimateReadOnly = false;
            this.SizeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SizeTextBox.Depth = 0;
            this.SizeTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SizeTextBox.Hint = "Размер поля (<16, ввести одно число N, сгенерированное поле будет N*N)";
            this.SizeTextBox.LeadingIcon = null;
            this.SizeTextBox.Location = new System.Drawing.Point(20, 462);
            this.SizeTextBox.MaxLength = 2;
            this.SizeTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.SizeTextBox.Multiline = false;
            this.SizeTextBox.Name = "SizeTextBox";
            this.SizeTextBox.Size = new System.Drawing.Size(901, 50);
            this.SizeTextBox.TabIndex = 15;
            this.SizeTextBox.Text = "";
            this.SizeTextBox.TrailingIcon = null;
            this.SizeTextBox.TextChanged += new System.EventHandler(this.SettingTextBox_Changed);
            this.SizeTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SettingsTimeTextBox_KeyDown);
            this.SizeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SettingsTextBox_KeyPress);
            // 
            // DifficultTextBox
            // 
            this.DifficultTextBox.AnimateReadOnly = false;
            this.DifficultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DifficultTextBox.Depth = 0;
            this.DifficultTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DifficultTextBox.Hint = "Количество закрашеваемых ячеек";
            this.DifficultTextBox.LeadingIcon = null;
            this.DifficultTextBox.Location = new System.Drawing.Point(20, 296);
            this.DifficultTextBox.MaxLength = 50;
            this.DifficultTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.DifficultTextBox.Multiline = false;
            this.DifficultTextBox.Name = "DifficultTextBox";
            this.DifficultTextBox.Size = new System.Drawing.Size(901, 50);
            this.DifficultTextBox.TabIndex = 14;
            this.DifficultTextBox.Text = "";
            this.DifficultTextBox.TrailingIcon = null;
            this.DifficultTextBox.TextChanged += new System.EventHandler(this.SettingTextBox_Changed);
            this.DifficultTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SettingsTimeTextBox_KeyDown);
            this.DifficultTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SettingsTextBox_KeyPress);
            // 
            // PostExposureTimeTextBox
            // 
            this.PostExposureTimeTextBox.AnimateReadOnly = false;
            this.PostExposureTimeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PostExposureTimeTextBox.Depth = 0;
            this.PostExposureTimeTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PostExposureTimeTextBox.Hint = "Время постэкспозиции, мс";
            this.PostExposureTimeTextBox.LeadingIcon = null;
            this.PostExposureTimeTextBox.Location = new System.Drawing.Point(20, 240);
            this.PostExposureTimeTextBox.MaxLength = 5;
            this.PostExposureTimeTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.PostExposureTimeTextBox.Multiline = false;
            this.PostExposureTimeTextBox.Name = "PostExposureTimeTextBox";
            this.PostExposureTimeTextBox.Size = new System.Drawing.Size(901, 50);
            this.PostExposureTimeTextBox.TabIndex = 13;
            this.PostExposureTimeTextBox.Text = "";
            this.PostExposureTimeTextBox.TrailingIcon = null;
            this.PostExposureTimeTextBox.TextChanged += new System.EventHandler(this.SettingTextBox_Changed);
            this.PostExposureTimeTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SettingsTimeTextBox_KeyDown);
            this.PostExposureTimeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SettingsTextBox_KeyPress);
            // 
            // PreExposureTimeTextBox
            // 
            this.PreExposureTimeTextBox.AnimateReadOnly = false;
            this.PreExposureTimeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PreExposureTimeTextBox.Depth = 0;
            this.PreExposureTimeTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PreExposureTimeTextBox.Hint = "Время преэкспозиции, мс";
            this.PreExposureTimeTextBox.LeadingIcon = null;
            this.PreExposureTimeTextBox.Location = new System.Drawing.Point(20, 184);
            this.PreExposureTimeTextBox.MaxLength = 5;
            this.PreExposureTimeTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.PreExposureTimeTextBox.Multiline = false;
            this.PreExposureTimeTextBox.Name = "PreExposureTimeTextBox";
            this.PreExposureTimeTextBox.Size = new System.Drawing.Size(901, 50);
            this.PreExposureTimeTextBox.TabIndex = 12;
            this.PreExposureTimeTextBox.Text = "";
            this.PreExposureTimeTextBox.TrailingIcon = null;
            this.PreExposureTimeTextBox.TextChanged += new System.EventHandler(this.SettingTextBox_Changed);
            this.PreExposureTimeTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SettingsTimeTextBox_KeyDown);
            this.PreExposureTimeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SettingsTextBox_KeyPress);
            // 
            // ExposureTimeTextBox
            // 
            this.ExposureTimeTextBox.AnimateReadOnly = false;
            this.ExposureTimeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ExposureTimeTextBox.Depth = 0;
            this.ExposureTimeTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ExposureTimeTextBox.Hint = "Время экспозиции, мс";
            this.ExposureTimeTextBox.LeadingIcon = null;
            this.ExposureTimeTextBox.Location = new System.Drawing.Point(20, 128);
            this.ExposureTimeTextBox.MaxLength = 5;
            this.ExposureTimeTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.ExposureTimeTextBox.Multiline = false;
            this.ExposureTimeTextBox.Name = "ExposureTimeTextBox";
            this.ExposureTimeTextBox.Size = new System.Drawing.Size(901, 50);
            this.ExposureTimeTextBox.TabIndex = 11;
            this.ExposureTimeTextBox.Text = "";
            this.ExposureTimeTextBox.TrailingIcon = null;
            this.ExposureTimeTextBox.TextChanged += new System.EventHandler(this.SettingTextBox_Changed);
            this.ExposureTimeTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SettingsTimeTextBox_KeyDown);
            this.ExposureTimeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SettingsTextBox_KeyPress);
            // 
            // SettingsTitleLabel
            // 
            this.SettingsTitleLabel.AutoSize = true;
            this.SettingsTitleLabel.Depth = 0;
            this.SettingsTitleLabel.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.SettingsTitleLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.SettingsTitleLabel.Location = new System.Drawing.Point(271, 14);
            this.SettingsTitleLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.SettingsTitleLabel.Name = "SettingsTitleLabel";
            this.SettingsTitleLabel.Size = new System.Drawing.Size(417, 41);
            this.SettingsTitleLabel.TabIndex = 10;
            this.SettingsTitleLabel.Text = "Параметры тестирования";
            // 
            // ResultsTabPage
            // 
            this.ResultsTabPage.Controls.Add(this.SaveToExcelButton);
            this.ResultsTabPage.Controls.Add(this.SearchButton);
            this.ResultsTabPage.Controls.Add(this.AllResultsInsurancePolicyTextBox);
            this.ResultsTabPage.Controls.Add(this.AllResultsTitle);
            this.ResultsTabPage.Controls.Add(this.PanelForAllResultsPanel);
            this.ResultsTabPage.ImageKey = "icons8-задания-32.png";
            this.ResultsTabPage.Location = new System.Drawing.Point(4, 39);
            this.ResultsTabPage.Name = "ResultsTabPage";
            this.ResultsTabPage.Size = new System.Drawing.Size(986, 790);
            this.ResultsTabPage.TabIndex = 3;
            this.ResultsTabPage.Text = "Результаты";
            this.ResultsTabPage.UseVisualStyleBackColor = true;
            // 
            // SaveToExcelButton
            // 
            this.SaveToExcelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SaveToExcelButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.SaveToExcelButton.Depth = 0;
            this.SaveToExcelButton.HighEmphasis = true;
            this.SaveToExcelButton.Icon = null;
            this.SaveToExcelButton.Location = new System.Drawing.Point(741, 73);
            this.SaveToExcelButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SaveToExcelButton.MinimumSize = new System.Drawing.Size(158, 48);
            this.SaveToExcelButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SaveToExcelButton.Name = "SaveToExcelButton";
            this.SaveToExcelButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.SaveToExcelButton.Size = new System.Drawing.Size(169, 48);
            this.SaveToExcelButton.TabIndex = 13;
            this.SaveToExcelButton.Text = "Сохранить в Excel";
            this.SaveToExcelButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.SaveToExcelButton.UseAccentColor = false;
            this.SaveToExcelButton.UseVisualStyleBackColor = true;
            this.SaveToExcelButton.Click += new System.EventHandler(this.SaveToExcelButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SearchButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.SearchButton.Depth = 0;
            this.SearchButton.HighEmphasis = true;
            this.SearchButton.Icon = null;
            this.SearchButton.Location = new System.Drawing.Point(201, 73);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SearchButton.MinimumSize = new System.Drawing.Size(100, 48);
            this.SearchButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.SearchButton.Size = new System.Drawing.Size(100, 48);
            this.SearchButton.TabIndex = 12;
            this.SearchButton.Text = "Поиск";
            this.SearchButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.SearchButton.UseAccentColor = false;
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // AllResultsInsurancePolicyTextBox
            // 
            this.AllResultsInsurancePolicyTextBox.AllowPromptAsInput = true;
            this.AllResultsInsurancePolicyTextBox.AnimateReadOnly = false;
            this.AllResultsInsurancePolicyTextBox.AsciiOnly = false;
            this.AllResultsInsurancePolicyTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AllResultsInsurancePolicyTextBox.BeepOnError = false;
            this.AllResultsInsurancePolicyTextBox.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.AllResultsInsurancePolicyTextBox.Depth = 0;
            this.AllResultsInsurancePolicyTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.AllResultsInsurancePolicyTextBox.HidePromptOnLeave = false;
            this.AllResultsInsurancePolicyTextBox.HideSelection = true;
            this.AllResultsInsurancePolicyTextBox.Hint = "Полис";
            this.AllResultsInsurancePolicyTextBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.AllResultsInsurancePolicyTextBox.LeadingIcon = null;
            this.AllResultsInsurancePolicyTextBox.Location = new System.Drawing.Point(3, 73);
            this.AllResultsInsurancePolicyTextBox.Mask = "0000-0000-0000-0000";
            this.AllResultsInsurancePolicyTextBox.MaxLength = 32767;
            this.AllResultsInsurancePolicyTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.AllResultsInsurancePolicyTextBox.Name = "AllResultsInsurancePolicyTextBox";
            this.AllResultsInsurancePolicyTextBox.PasswordChar = '\0';
            this.AllResultsInsurancePolicyTextBox.PrefixSuffixText = null;
            this.AllResultsInsurancePolicyTextBox.PromptChar = '_';
            this.AllResultsInsurancePolicyTextBox.ReadOnly = false;
            this.AllResultsInsurancePolicyTextBox.RejectInputOnFirstFailure = false;
            this.AllResultsInsurancePolicyTextBox.ResetOnPrompt = true;
            this.AllResultsInsurancePolicyTextBox.ResetOnSpace = true;
            this.AllResultsInsurancePolicyTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AllResultsInsurancePolicyTextBox.SelectedText = "";
            this.AllResultsInsurancePolicyTextBox.SelectionLength = 0;
            this.AllResultsInsurancePolicyTextBox.SelectionStart = 0;
            this.AllResultsInsurancePolicyTextBox.ShortcutsEnabled = true;
            this.AllResultsInsurancePolicyTextBox.Size = new System.Drawing.Size(191, 48);
            this.AllResultsInsurancePolicyTextBox.SkipLiterals = true;
            this.AllResultsInsurancePolicyTextBox.TabIndex = 11;
            this.AllResultsInsurancePolicyTextBox.TabStop = false;
            this.AllResultsInsurancePolicyTextBox.Text = "    -    -    -";
            this.AllResultsInsurancePolicyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AllResultsInsurancePolicyTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.AllResultsInsurancePolicyTextBox.TrailingIcon = null;
            this.AllResultsInsurancePolicyTextBox.UseSystemPasswordChar = false;
            this.AllResultsInsurancePolicyTextBox.ValidatingType = null;
            // 
            // AllResultsTitle
            // 
            this.AllResultsTitle.AutoSize = true;
            this.AllResultsTitle.Depth = 0;
            this.AllResultsTitle.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.AllResultsTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.AllResultsTitle.Location = new System.Drawing.Point(300, 12);
            this.AllResultsTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.AllResultsTitle.Name = "AllResultsTitle";
            this.AllResultsTitle.Size = new System.Drawing.Size(365, 41);
            this.AllResultsTitle.TabIndex = 1;
            this.AllResultsTitle.Text = "Просмотр результатов";
            // 
            // PanelForAllResultsPanel
            // 
            this.PanelForAllResultsPanel.Controls.Add(this.AllResultsPanel);
            this.PanelForAllResultsPanel.Location = new System.Drawing.Point(3, 148);
            this.PanelForAllResultsPanel.Name = "PanelForAllResultsPanel";
            this.PanelForAllResultsPanel.Size = new System.Drawing.Size(907, 639);
            this.PanelForAllResultsPanel.TabIndex = 0;
            // 
            // AllResultsPanel
            // 
            this.AllResultsPanel.AutoScroll = true;
            this.AllResultsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AllResultsPanel.Location = new System.Drawing.Point(0, 0);
            this.AllResultsPanel.Name = "AllResultsPanel";
            this.AllResultsPanel.Size = new System.Drawing.Size(907, 639);
            this.AllResultsPanel.TabIndex = 0;
            // 
            // MenuImageList
            // 
            this.MenuImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("MenuImageList.ImageStream")));
            this.MenuImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.MenuImageList.Images.SetKeyName(0, "icons8-лицо-в-профиль-32.png");
            this.MenuImageList.Images.SetKeyName(1, "icons8-настройки-32.png");
            this.MenuImageList.Images.SetKeyName(2, "icons8-галочка-32.png");
            this.MenuImageList.Images.SetKeyName(3, "icons8-задания-32.png");
            // 
            // ResultPanel
            // 
            this.ResultPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ResultPanel.Controls.Add(this.QuitButton);
            this.ResultPanel.Controls.Add(this.SaveToDBButton);
            this.ResultPanel.Controls.Add(this.ResultTitleLabel);
            this.ResultPanel.Controls.Add(this.ResultTable);
            this.ResultPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultPanel.Location = new System.Drawing.Point(3, 64);
            this.ResultPanel.Name = "ResultPanel";
            this.ResultPanel.Size = new System.Drawing.Size(994, 833);
            this.ResultPanel.TabIndex = 1;
            this.ResultPanel.Visible = false;
            // 
            // QuitButton
            // 
            this.QuitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.QuitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.QuitButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.QuitButton.Depth = 0;
            this.QuitButton.HighEmphasis = true;
            this.QuitButton.Icon = null;
            this.QuitButton.Location = new System.Drawing.Point(629, 525);
            this.QuitButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.QuitButton.MinimumSize = new System.Drawing.Size(240, 50);
            this.QuitButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.QuitButton.Size = new System.Drawing.Size(240, 50);
            this.QuitButton.TabIndex = 4;
            this.QuitButton.Text = "Выход";
            this.QuitButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.QuitButton.UseAccentColor = false;
            this.QuitButton.UseVisualStyleBackColor = false;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // SaveToDBButton
            // 
            this.SaveToDBButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SaveToDBButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SaveToDBButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.SaveToDBButton.Depth = 0;
            this.SaveToDBButton.HighEmphasis = true;
            this.SaveToDBButton.Icon = null;
            this.SaveToDBButton.Location = new System.Drawing.Point(110, 525);
            this.SaveToDBButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SaveToDBButton.MinimumSize = new System.Drawing.Size(160, 50);
            this.SaveToDBButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SaveToDBButton.Name = "SaveToDBButton";
            this.SaveToDBButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.SaveToDBButton.Size = new System.Drawing.Size(230, 50);
            this.SaveToDBButton.TabIndex = 3;
            this.SaveToDBButton.Text = "Сохранить в базу данных";
            this.SaveToDBButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.SaveToDBButton.UseAccentColor = false;
            this.SaveToDBButton.UseVisualStyleBackColor = false;
            this.SaveToDBButton.Click += new System.EventHandler(this.SaveToDBButton_Click);
            // 
            // ResultTitleLabel
            // 
            this.ResultTitleLabel.AutoSize = true;
            this.ResultTitleLabel.Depth = 0;
            this.ResultTitleLabel.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ResultTitleLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            this.ResultTitleLabel.Location = new System.Drawing.Point(366, 11);
            this.ResultTitleLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ResultTitleLabel.Name = "ResultTitleLabel";
            this.ResultTitleLabel.Size = new System.Drawing.Size(266, 58);
            this.ResultTitleLabel.TabIndex = 2;
            this.ResultTitleLabel.Text = "Результаты";
            // 
            // ResultTable
            // 
            this.ResultTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultTable.ColumnCount = 2;
            this.ResultTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ResultTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ResultTable.Controls.Add(this.DispersionTimeLabel, 1, 5);
            this.ResultTable.Controls.Add(this.DispersionTimeTitle, 0, 5);
            this.ResultTable.Controls.Add(this.AverageInvalidAnswersLabel, 1, 2);
            this.ResultTable.Controls.Add(this.DispersionInvalidAnswersTitle, 0, 3);
            this.ResultTable.Controls.Add(this.AverageInvalidAnswersTitle, 0, 2);
            this.ResultTable.Controls.Add(this.AverageTimeLabel, 1, 4);
            this.ResultTable.Controls.Add(this.AverageTimeTitle, 0, 4);
            this.ResultTable.Controls.Add(this.DispersionCorrectAnswersLabel, 1, 1);
            this.ResultTable.Controls.Add(this.DispersionCorrectAnswersTitle, 0, 1);
            this.ResultTable.Controls.Add(this.AverageCorrectAnswersTitle, 0, 0);
            this.ResultTable.Controls.Add(this.AverageCorrectAnswersLabel, 1, 0);
            this.ResultTable.Controls.Add(this.DispersionInvalidAnswersLabel, 1, 3);
            this.ResultTable.Location = new System.Drawing.Point(4, 82);
            this.ResultTable.Name = "ResultTable";
            this.ResultTable.RowCount = 6;
            this.ResultTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ResultTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ResultTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ResultTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ResultTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ResultTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ResultTable.Size = new System.Drawing.Size(987, 327);
            this.ResultTable.TabIndex = 1;
            // 
            // DispersionTimeLabel
            // 
            this.DispersionTimeLabel.AutoSize = true;
            this.DispersionTimeLabel.Depth = 0;
            this.DispersionTimeLabel.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.DispersionTimeLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.DispersionTimeLabel.Location = new System.Drawing.Point(496, 270);
            this.DispersionTimeLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.DispersionTimeLabel.Name = "DispersionTimeLabel";
            this.DispersionTimeLabel.Size = new System.Drawing.Size(12, 24);
            this.DispersionTimeLabel.TabIndex = 13;
            this.DispersionTimeLabel.Text = "0";
            // 
            // DispersionTimeTitle
            // 
            this.DispersionTimeTitle.AutoSize = true;
            this.DispersionTimeTitle.Depth = 0;
            this.DispersionTimeTitle.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.DispersionTimeTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.DispersionTimeTitle.Location = new System.Drawing.Point(3, 270);
            this.DispersionTimeTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.DispersionTimeTitle.Name = "DispersionTimeTitle";
            this.DispersionTimeTitle.Size = new System.Drawing.Size(398, 24);
            this.DispersionTimeTitle.TabIndex = 13;
            this.DispersionTimeTitle.Text = "Дисперсия времени воспроизведения, сек";
            // 
            // AverageInvalidAnswersLabel
            // 
            this.AverageInvalidAnswersLabel.AutoSize = true;
            this.AverageInvalidAnswersLabel.Depth = 0;
            this.AverageInvalidAnswersLabel.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.AverageInvalidAnswersLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.AverageInvalidAnswersLabel.Location = new System.Drawing.Point(496, 108);
            this.AverageInvalidAnswersLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.AverageInvalidAnswersLabel.Name = "AverageInvalidAnswersLabel";
            this.AverageInvalidAnswersLabel.Size = new System.Drawing.Size(12, 24);
            this.AverageInvalidAnswersLabel.TabIndex = 7;
            this.AverageInvalidAnswersLabel.Text = "0";
            // 
            // DispersionInvalidAnswersTitle
            // 
            this.DispersionInvalidAnswersTitle.AutoSize = true;
            this.DispersionInvalidAnswersTitle.Depth = 0;
            this.DispersionInvalidAnswersTitle.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.DispersionInvalidAnswersTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.DispersionInvalidAnswersTitle.Location = new System.Drawing.Point(3, 162);
            this.DispersionInvalidAnswersTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.DispersionInvalidAnswersTitle.Name = "DispersionInvalidAnswersTitle";
            this.DispersionInvalidAnswersTitle.Size = new System.Drawing.Size(324, 24);
            this.DispersionInvalidAnswersTitle.TabIndex = 11;
            this.DispersionInvalidAnswersTitle.Text = "Дисперсия неправильных ответов";
            // 
            // AverageInvalidAnswersTitle
            // 
            this.AverageInvalidAnswersTitle.AutoSize = true;
            this.AverageInvalidAnswersTitle.Depth = 0;
            this.AverageInvalidAnswersTitle.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.AverageInvalidAnswersTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.AverageInvalidAnswersTitle.Location = new System.Drawing.Point(3, 108);
            this.AverageInvalidAnswersTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.AverageInvalidAnswersTitle.Name = "AverageInvalidAnswersTitle";
            this.AverageInvalidAnswersTitle.Size = new System.Drawing.Size(422, 24);
            this.AverageInvalidAnswersTitle.TabIndex = 3;
            this.AverageInvalidAnswersTitle.Text = "Среднее количество неправильных ответов:";
            // 
            // AverageTimeLabel
            // 
            this.AverageTimeLabel.AutoSize = true;
            this.AverageTimeLabel.Depth = 0;
            this.AverageTimeLabel.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.AverageTimeLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.AverageTimeLabel.Location = new System.Drawing.Point(496, 216);
            this.AverageTimeLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.AverageTimeLabel.Name = "AverageTimeLabel";
            this.AverageTimeLabel.Size = new System.Drawing.Size(12, 24);
            this.AverageTimeLabel.TabIndex = 8;
            this.AverageTimeLabel.Text = "0";
            // 
            // AverageTimeTitle
            // 
            this.AverageTimeTitle.AutoSize = true;
            this.AverageTimeTitle.Depth = 0;
            this.AverageTimeTitle.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.AverageTimeTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.AverageTimeTitle.Location = new System.Drawing.Point(3, 216);
            this.AverageTimeTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.AverageTimeTitle.Name = "AverageTimeTitle";
            this.AverageTimeTitle.Size = new System.Drawing.Size(355, 24);
            this.AverageTimeTitle.TabIndex = 3;
            this.AverageTimeTitle.Text = "Среднее время воспроизведения, сек";
            // 
            // DispersionCorrectAnswersLabel
            // 
            this.DispersionCorrectAnswersLabel.AutoSize = true;
            this.DispersionCorrectAnswersLabel.Depth = 0;
            this.DispersionCorrectAnswersLabel.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.DispersionCorrectAnswersLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.DispersionCorrectAnswersLabel.Location = new System.Drawing.Point(496, 54);
            this.DispersionCorrectAnswersLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.DispersionCorrectAnswersLabel.Name = "DispersionCorrectAnswersLabel";
            this.DispersionCorrectAnswersLabel.Size = new System.Drawing.Size(12, 24);
            this.DispersionCorrectAnswersLabel.TabIndex = 10;
            this.DispersionCorrectAnswersLabel.Text = "0";
            // 
            // DispersionCorrectAnswersTitle
            // 
            this.DispersionCorrectAnswersTitle.AutoSize = true;
            this.DispersionCorrectAnswersTitle.Depth = 0;
            this.DispersionCorrectAnswersTitle.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.DispersionCorrectAnswersTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.DispersionCorrectAnswersTitle.Location = new System.Drawing.Point(3, 54);
            this.DispersionCorrectAnswersTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.DispersionCorrectAnswersTitle.Name = "DispersionCorrectAnswersTitle";
            this.DispersionCorrectAnswersTitle.Size = new System.Drawing.Size(302, 24);
            this.DispersionCorrectAnswersTitle.TabIndex = 9;
            this.DispersionCorrectAnswersTitle.Text = "Дисперсия правильных ответов";
            // 
            // AverageCorrectAnswersTitle
            // 
            this.AverageCorrectAnswersTitle.AutoSize = true;
            this.AverageCorrectAnswersTitle.Depth = 0;
            this.AverageCorrectAnswersTitle.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.AverageCorrectAnswersTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.AverageCorrectAnswersTitle.Location = new System.Drawing.Point(3, 0);
            this.AverageCorrectAnswersTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.AverageCorrectAnswersTitle.Name = "AverageCorrectAnswersTitle";
            this.AverageCorrectAnswersTitle.Size = new System.Drawing.Size(400, 24);
            this.AverageCorrectAnswersTitle.TabIndex = 3;
            this.AverageCorrectAnswersTitle.Text = "Среднее количество правильных ответов:";
            // 
            // AverageCorrectAnswersLabel
            // 
            this.AverageCorrectAnswersLabel.AutoSize = true;
            this.AverageCorrectAnswersLabel.Depth = 0;
            this.AverageCorrectAnswersLabel.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.AverageCorrectAnswersLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.AverageCorrectAnswersLabel.Location = new System.Drawing.Point(496, 0);
            this.AverageCorrectAnswersLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.AverageCorrectAnswersLabel.Name = "AverageCorrectAnswersLabel";
            this.AverageCorrectAnswersLabel.Size = new System.Drawing.Size(12, 24);
            this.AverageCorrectAnswersLabel.TabIndex = 6;
            this.AverageCorrectAnswersLabel.Text = "0";
            // 
            // DispersionInvalidAnswersLabel
            // 
            this.DispersionInvalidAnswersLabel.AutoSize = true;
            this.DispersionInvalidAnswersLabel.Depth = 0;
            this.DispersionInvalidAnswersLabel.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.DispersionInvalidAnswersLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.DispersionInvalidAnswersLabel.Location = new System.Drawing.Point(496, 162);
            this.DispersionInvalidAnswersLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.DispersionInvalidAnswersLabel.Name = "DispersionInvalidAnswersLabel";
            this.DispersionInvalidAnswersLabel.Size = new System.Drawing.Size(12, 24);
            this.DispersionInvalidAnswersLabel.TabIndex = 12;
            this.DispersionInvalidAnswersLabel.Text = "0";
            // 
            // LoadingTimer
            // 
            this.LoadingTimer.Interval = 1000;
            this.LoadingTimer.Tick += new System.EventHandler(this.LoadingTimer_Tick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 900);
            this.Controls.Add(this.ResultPanel);
            this.Controls.Add(this.StartPanel);
            this.Controls.Add(this.BackPanel);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.MainTabControl;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 900);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 900);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мнемотест";
            this.StartPanel.ResumeLayout(false);
            this.MainTabControl.ResumeLayout(false);
            this.ReadyTabPage.ResumeLayout(false);
            this.ReadyTabPage.PerformLayout();
            this.PersonTabPage.ResumeLayout(false);
            this.PersonTabPage.PerformLayout();
            this.SettingsTabPage.ResumeLayout(false);
            this.SettingsTabPage.PerformLayout();
            this.ResultsTabPage.ResumeLayout(false);
            this.ResultsTabPage.PerformLayout();
            this.PanelForAllResultsPanel.ResumeLayout(false);
            this.ResultPanel.ResumeLayout(false);
            this.ResultPanel.PerformLayout();
            this.ResultTable.ResumeLayout(false);
            this.ResultTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BackPanel;
        private System.Windows.Forms.Panel StartPanel;
        private System.Windows.Forms.Panel ResultPanel;
        private System.Windows.Forms.TableLayoutPanel ResultTable;
        private MaterialSkin.Controls.MaterialTabControl MainTabControl;
        private System.Windows.Forms.TabPage PersonTabPage;
        private System.Windows.Forms.TabPage SettingsTabPage;
        private System.Windows.Forms.ImageList MenuImageList;
        private MaterialSkin.Controls.MaterialTextBox NameTextBox;
        private MaterialSkin.Controls.MaterialTextBox FatherNameTextBox;
        private MaterialSkin.Controls.MaterialTextBox LastNameTextBox;
        private MaterialSkin.Controls.MaterialRadioButton FemaleRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton MaleRadioButton;
        private MaterialSkin.Controls.MaterialComboBox AgeComboBox;
        private MaterialSkin.Controls.MaterialLabel PersonTitleLabel;
        private System.Windows.Forms.TabPage ReadyTabPage;
        private MaterialSkin.Controls.MaterialLabel RulesTitleLabel;
        private MaterialSkin.Controls.MaterialLabel RulesLabel1;
        private MaterialSkin.Controls.MaterialLabel RulesLabel2;
        private MaterialSkin.Controls.MaterialButton StartButton;
        private MaterialSkin.Controls.MaterialTextBox SizeTextBox;
        private MaterialSkin.Controls.MaterialTextBox DifficultTextBox;
        private MaterialSkin.Controls.MaterialTextBox PostExposureTimeTextBox;
        private MaterialSkin.Controls.MaterialTextBox PreExposureTimeTextBox;
        private MaterialSkin.Controls.MaterialTextBox ExposureTimeTextBox;
        private MaterialSkin.Controls.MaterialLabel SettingsTitleLabel;
        private MaterialSkin.Controls.MaterialComboBox RotateComboBox;
        private MaterialSkin.Controls.MaterialTextBox AttemptsTextBox;
        private MaterialSkin.Controls.MaterialMaskedTextBox InsurencePolicyTextBox;
        private MaterialSkin.Controls.MaterialLabel ResultTitleLabel;
        private MaterialSkin.Controls.MaterialLabel AverageInvalidAnswersTitle;
        private MaterialSkin.Controls.MaterialLabel AverageCorrectAnswersTitle;
        private MaterialSkin.Controls.MaterialLabel AverageTimeTitle;
        private MaterialSkin.Controls.MaterialLabel AverageCorrectAnswersLabel;
        private MaterialSkin.Controls.MaterialLabel AverageInvalidAnswersLabel;
        private MaterialSkin.Controls.MaterialLabel AverageTimeLabel;
        private MaterialSkin.Controls.MaterialLabel DispersionTimeLabel;
        private MaterialSkin.Controls.MaterialLabel DispersionTimeTitle;
        private MaterialSkin.Controls.MaterialLabel DispersionInvalidAnswersTitle;
        private MaterialSkin.Controls.MaterialLabel DispersionCorrectAnswersLabel;
        private MaterialSkin.Controls.MaterialLabel DispersionCorrectAnswersTitle;
        private MaterialSkin.Controls.MaterialLabel DispersionInvalidAnswersLabel;
        private MaterialSkin.Controls.MaterialButton QuitButton;
        private MaterialSkin.Controls.MaterialButton SaveToDBButton;
        private MaterialSkin.Controls.MaterialComboBox ReproductionModeComboBox;
        private System.Windows.Forms.Timer LoadingTimer;
        private MaterialSkin.Controls.MaterialLabel WaitLabel;
        private MaterialSkin.Controls.MaterialComboBox TemplateComboBox;
        private MaterialSkin.Controls.MaterialTextBox ScatterTextBox;
        private System.Windows.Forms.TabPage ResultsTabPage;
        private System.Windows.Forms.Panel PanelForAllResultsPanel;
        private System.Windows.Forms.Panel AllResultsPanel;
        private MaterialSkin.Controls.MaterialLabel AllResultsTitle;
        private MaterialSkin.Controls.MaterialButton SearchButton;
        private MaterialSkin.Controls.MaterialMaskedTextBox AllResultsInsurancePolicyTextBox;
        private MaterialSkin.Controls.MaterialButton SaveToExcelButton;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private MaterialSkin.Controls.MaterialButton AddTemplateButton;
    }
}

