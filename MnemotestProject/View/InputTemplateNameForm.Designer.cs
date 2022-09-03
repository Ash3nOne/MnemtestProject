namespace MnemotestProject.View
{
    partial class InputTemplateNameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TemplateNameTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.TemplateNameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.AddTemplateButton = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // TemplateNameTextBox
            // 
            this.TemplateNameTextBox.AnimateReadOnly = false;
            this.TemplateNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TemplateNameTextBox.Depth = 0;
            this.TemplateNameTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TemplateNameTextBox.Hint = "Имя шаблона";
            this.TemplateNameTextBox.LeadingIcon = null;
            this.TemplateNameTextBox.Location = new System.Drawing.Point(37, 94);
            this.TemplateNameTextBox.MaxLength = 40;
            this.TemplateNameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.TemplateNameTextBox.Multiline = false;
            this.TemplateNameTextBox.Name = "TemplateNameTextBox";
            this.TemplateNameTextBox.Size = new System.Drawing.Size(395, 50);
            this.TemplateNameTextBox.TabIndex = 0;
            this.TemplateNameTextBox.Text = "";
            this.TemplateNameTextBox.TrailingIcon = null;
            // 
            // TemplateNameLabel
            // 
            this.TemplateNameLabel.AutoSize = true;
            this.TemplateNameLabel.Depth = 0;
            this.TemplateNameLabel.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.TemplateNameLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.TemplateNameLabel.Location = new System.Drawing.Point(135, 46);
            this.TemplateNameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.TemplateNameLabel.Name = "TemplateNameLabel";
            this.TemplateNameLabel.Size = new System.Drawing.Size(204, 24);
            this.TemplateNameLabel.TabIndex = 1;
            this.TemplateNameLabel.Text = "Добавление шаблона";
            // 
            // AddTemplateButton
            // 
            this.AddTemplateButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddTemplateButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.AddTemplateButton.Depth = 0;
            this.AddTemplateButton.HighEmphasis = true;
            this.AddTemplateButton.Icon = null;
            this.AddTemplateButton.Location = new System.Drawing.Point(156, 175);
            this.AddTemplateButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddTemplateButton.MaximumSize = new System.Drawing.Size(158, 36);
            this.AddTemplateButton.MinimumSize = new System.Drawing.Size(158, 36);
            this.AddTemplateButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddTemplateButton.Name = "AddTemplateButton";
            this.AddTemplateButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.AddTemplateButton.Size = new System.Drawing.Size(158, 36);
            this.AddTemplateButton.TabIndex = 2;
            this.AddTemplateButton.Text = "Добавить";
            this.AddTemplateButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AddTemplateButton.UseAccentColor = false;
            this.AddTemplateButton.UseVisualStyleBackColor = true;
            this.AddTemplateButton.Click += new System.EventHandler(this.AddTemplateButton_Click);
            // 
            // InputTemplateNameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 251);
            this.Controls.Add(this.AddTemplateButton);
            this.Controls.Add(this.TemplateNameLabel);
            this.Controls.Add(this.TemplateNameTextBox);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(467, 251);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(467, 251);
            this.Name = "InputTemplateNameForm";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InputTemplateNameForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox TemplateNameTextBox;
        private MaterialSkin.Controls.MaterialLabel TemplateNameLabel;
        private MaterialSkin.Controls.MaterialButton AddTemplateButton;
    }
}