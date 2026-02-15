namespace WinFormsApp_OOP_Lab1
{
    partial class EditForm
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
            NameTextBox = new TextBox();
            NameLabel = new Label();
            GenderLabel = new Label();
            HeightTextBox = new TextBox();
            label1 = new Label();
            WidthTextBox = new TextBox();
            WidthLabel = new Label();
            AgeLabel = new Label();
            AgeTextBox = new TextBox();
            CountryTextBox = new TextBox();
            CountryLabel = new Label();
            CityTextBox = new TextBox();
            CityLabel = new Label();
            HeaderLabel = new Label();
            SaveButton = new Button();
            ExitButton = new Button();
            GenderComboBox = new ComboBox();
            CurrentLabel = new Label();
            SuspendLayout();
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(155, 81);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(125, 27);
            NameTextBox.TabIndex = 0;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(98, 88);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(39, 20);
            NameLabel.TabIndex = 1;
            NameLabel.Text = "Имя";
            // 
            // GenderLabel
            // 
            GenderLabel.AutoSize = true;
            GenderLabel.Location = new Point(100, 139);
            GenderLabel.Name = "GenderLabel";
            GenderLabel.Size = new Size(37, 20);
            GenderLabel.TabIndex = 3;
            GenderLabel.Text = "Пол";
            // 
            // HeightTextBox
            // 
            HeightTextBox.Location = new Point(155, 191);
            HeightTextBox.Name = "HeightTextBox";
            HeightTextBox.Size = new Size(125, 27);
            HeightTextBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 194);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 5;
            label1.Text = "Рост";
            // 
            // WidthTextBox
            // 
            WidthTextBox.Location = new Point(479, 85);
            WidthTextBox.Name = "WidthTextBox";
            WidthTextBox.Size = new Size(125, 27);
            WidthTextBox.TabIndex = 6;
            // 
            // WidthLabel
            // 
            WidthLabel.AutoSize = true;
            WidthLabel.Location = new Point(440, 88);
            WidthLabel.Name = "WidthLabel";
            WidthLabel.Size = new Size(33, 20);
            WidthLabel.TabIndex = 7;
            WidthLabel.Text = "Вес";
            // 
            // AgeLabel
            // 
            AgeLabel.AutoSize = true;
            AgeLabel.Location = new Point(409, 143);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(64, 20);
            AgeLabel.TabIndex = 8;
            AgeLabel.Text = "Возраст";
            // 
            // AgeTextBox
            // 
            AgeTextBox.Location = new Point(479, 136);
            AgeTextBox.Name = "AgeTextBox";
            AgeTextBox.Size = new Size(125, 27);
            AgeTextBox.TabIndex = 9;
            // 
            // CountryTextBox
            // 
            CountryTextBox.Location = new Point(479, 187);
            CountryTextBox.Name = "CountryTextBox";
            CountryTextBox.Size = new Size(125, 27);
            CountryTextBox.TabIndex = 10;
            // 
            // CountryLabel
            // 
            CountryLabel.AutoSize = true;
            CountryLabel.Location = new Point(415, 194);
            CountryLabel.Name = "CountryLabel";
            CountryLabel.Size = new Size(58, 20);
            CountryLabel.TabIndex = 11;
            CountryLabel.Text = "Страна";
            // 
            // CityTextBox
            // 
            CityTextBox.Location = new Point(365, 262);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(125, 27);
            CityTextBox.TabIndex = 12;
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Location = new Point(215, 265);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(144, 20);
            CityLabel.TabIndex = 13;
            CityLabel.Text = "Город проживания";
            // 
            // HeaderLabel
            // 
            HeaderLabel.AutoSize = true;
            HeaderLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            HeaderLabel.Location = new Point(287, 33);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Size = new Size(203, 20);
            HeaderLabel.TabIndex = 14;
            HeaderLabel.Text = "Форма изменения данных";
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(455, 324);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(94, 29);
            SaveButton.TabIndex = 15;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(232, 324);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(94, 29);
            ExitButton.TabIndex = 16;
            ExitButton.Text = "Назад";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // GenderComboBox
            // 
            GenderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            GenderComboBox.FormattingEnabled = true;
            GenderComboBox.Items.AddRange(new object[] { "Муж", "Жен" });
            GenderComboBox.Location = new Point(155, 136);
            GenderComboBox.Name = "GenderComboBox";
            GenderComboBox.Size = new Size(125, 28);
            GenderComboBox.TabIndex = 17;
            // 
            // CurrentLabel
            // 
            CurrentLabel.AutoSize = true;
            CurrentLabel.Location = new Point(12, 50);
            CurrentLabel.Name = "CurrentLabel";
            CurrentLabel.Size = new Size(129, 20);
            CurrentLabel.TabIndex = 29;
            CurrentLabel.Text = "Индекс текущего:";
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CurrentLabel);
            Controls.Add(GenderComboBox);
            Controls.Add(ExitButton);
            Controls.Add(SaveButton);
            Controls.Add(HeaderLabel);
            Controls.Add(CityLabel);
            Controls.Add(CityTextBox);
            Controls.Add(CountryLabel);
            Controls.Add(CountryTextBox);
            Controls.Add(AgeTextBox);
            Controls.Add(AgeLabel);
            Controls.Add(WidthLabel);
            Controls.Add(WidthTextBox);
            Controls.Add(label1);
            Controls.Add(HeightTextBox);
            Controls.Add(GenderLabel);
            Controls.Add(NameLabel);
            Controls.Add(NameTextBox);
            Name = "EditForm";
            Text = "Редактирование данных";
            Load += EditForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NameTextBox;
        private Label NameLabel;
        private Label GenderLabel;
        private TextBox HeightTextBox;
        private Label label1;
        private TextBox WidthTextBox;
        private Label WidthLabel;
        private Label AgeLabel;
        private TextBox AgeTextBox;
        private TextBox CountryTextBox;
        private Label CountryLabel;
        private TextBox CityTextBox;
        private Label CityLabel;
        private Label HeaderLabel;
        private Button SaveButton;
        private Button ExitButton;
        private ComboBox GenderComboBox;
        private Label CurrentLabel;
    }
}