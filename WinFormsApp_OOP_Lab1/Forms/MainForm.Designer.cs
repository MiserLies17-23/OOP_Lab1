namespace WinFormsApp_OOP_Lab1
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            NameTextBox = new TextBox();
            CountryTextBox = new TextBox();
            CityTextBox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            ChangeButton = new Button();
            HeightTextBox = new TextBox();
            WidthTextBox = new TextBox();
            AgeTextBox = new TextBox();
            GenderTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(273, 9);
            label1.Name = "label1";
            label1.Size = new Size(257, 25);
            label1.TabIndex = 0;
            label1.Text = "Лабораторная работа №1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(315, 45);
            label2.Name = "label2";
            label2.Size = new Size(161, 20);
            label2.TabIndex = 1;
            label2.Text = "Вариант 13: Человек";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(354, 92);
            label3.Name = "label3";
            label3.Size = new Size(119, 20);
            label3.TabIndex = 2;
            label3.Text = "Общие данные";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(260, 166);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.ReadOnly = true;
            NameTextBox.Size = new Size(125, 27);
            NameTextBox.TabIndex = 4;
            // 
            // CountryTextBox
            // 
            CountryTextBox.Location = new Point(436, 166);
            CountryTextBox.Name = "CountryTextBox";
            CountryTextBox.ReadOnly = true;
            CountryTextBox.Size = new Size(125, 27);
            CountryTextBox.TabIndex = 8;
            // 
            // CityTextBox
            // 
            CityTextBox.Location = new Point(609, 165);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.ReadOnly = true;
            CityTextBox.Size = new Size(125, 27);
            CityTextBox.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(122, 133);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 10;
            label4.Text = "Пол";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(304, 133);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 11;
            label5.Text = "Имя";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(379, 221);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 12;
            label6.Text = "Вес (кг)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(201, 221);
            label7.Name = "label7";
            label7.Size = new Size(71, 20);
            label7.TabIndex = 13;
            label7.Text = "Рост (см)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(472, 133);
            label8.Name = "label8";
            label8.Size = new Size(58, 20);
            label8.TabIndex = 14;
            label8.Text = "Страна";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(600, 133);
            label9.Name = "label9";
            label9.Size = new Size(144, 20);
            label9.TabIndex = 15;
            label9.Text = "Город проживания";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(545, 221);
            label10.Name = "label10";
            label10.Size = new Size(64, 20);
            label10.TabIndex = 16;
            label10.Text = "Возраст";
            // 
            // ChangeButton
            // 
            ChangeButton.Location = new Point(354, 316);
            ChangeButton.Name = "ChangeButton";
            ChangeButton.Size = new Size(94, 29);
            ChangeButton.TabIndex = 17;
            ChangeButton.Text = "Изменить";
            ChangeButton.UseVisualStyleBackColor = true;
            ChangeButton.Click += CreateButton_Click;
            // 
            // HeightTextBox
            // 
            HeightTextBox.Location = new Point(170, 244);
            HeightTextBox.Name = "HeightTextBox";
            HeightTextBox.ReadOnly = true;
            HeightTextBox.Size = new Size(125, 27);
            HeightTextBox.TabIndex = 22;
            // 
            // WidthTextBox
            // 
            WidthTextBox.Location = new Point(354, 244);
            WidthTextBox.Name = "WidthTextBox";
            WidthTextBox.ReadOnly = true;
            WidthTextBox.Size = new Size(125, 27);
            WidthTextBox.TabIndex = 23;
            // 
            // AgeTextBox
            // 
            AgeTextBox.Location = new Point(528, 244);
            AgeTextBox.Name = "AgeTextBox";
            AgeTextBox.ReadOnly = true;
            AgeTextBox.Size = new Size(125, 27);
            AgeTextBox.TabIndex = 24;
            // 
            // GenderTextBox
            // 
            GenderTextBox.Location = new Point(85, 165);
            GenderTextBox.Name = "GenderTextBox";
            GenderTextBox.ReadOnly = true;
            GenderTextBox.Size = new Size(125, 27);
            GenderTextBox.TabIndex = 25;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 450);
            Controls.Add(GenderTextBox);
            Controls.Add(AgeTextBox);
            Controls.Add(WidthTextBox);
            Controls.Add(HeightTextBox);
            Controls.Add(ChangeButton);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(CityTextBox);
            Controls.Add(CountryTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "MainForm";
            Load += CreateForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox NameTextBox;
        private TextBox CountryTextBox;
        private TextBox CityTextBox;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button ChangeButton;
        private TextBox HeightTextBox;
        private TextBox WidthTextBox;
        private TextBox AgeTextBox;
        private TextBox GenderTextBox;
    }
}
