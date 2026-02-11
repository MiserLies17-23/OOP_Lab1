namespace WinFormsApp_OOP_Lab1
{
    partial class HelloForm
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
            HeaderLabel = new Label();
            VariantLabel = new Label();
            label1 = new Label();
            TaskLabel = new Label();
            pictureBox1 = new PictureBox();
            OkButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // HeaderLabel
            // 
            HeaderLabel.AutoSize = true;
            HeaderLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            HeaderLabel.Location = new Point(252, 9);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Size = new Size(257, 25);
            HeaderLabel.TabIndex = 1;
            HeaderLabel.Text = "Лабораторная работа №1";
            // 
            // VariantLabel
            // 
            VariantLabel.AutoSize = true;
            VariantLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            VariantLabel.Location = new Point(292, 43);
            VariantLabel.Name = "VariantLabel";
            VariantLabel.Size = new Size(195, 25);
            VariantLabel.TabIndex = 2;
            VariantLabel.Text = "Вариант 13: Человек";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(177, 77);
            label1.Name = "label1";
            label1.Size = new Size(437, 23);
            label1.TabIndex = 3;
            label1.Text = "Бригада 13: Пономарёв Павел, Толстоухова Вадим";
            // 
            // TaskLabel
            // 
            TaskLabel.AutoSize = true;
            TaskLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            TaskLabel.Location = new Point(327, 114);
            TaskLabel.Name = "TaskLabel";
            TaskLabel.Size = new Size(98, 28);
            TaskLabel.TabIndex = 4;
            TaskLabel.Text = "Задание:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Задание1;
            pictureBox1.Location = new Point(26, 145);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(762, 431);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // OkButton
            // 
            OkButton.Location = new Point(382, 582);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(56, 27);
            OkButton.TabIndex = 6;
            OkButton.Text = "Ок";
            OkButton.UseVisualStyleBackColor = true;
            OkButton.Click += OkButton_Click;
            // 
            // HelloForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 612);
            Controls.Add(OkButton);
            Controls.Add(pictureBox1);
            Controls.Add(TaskLabel);
            Controls.Add(label1);
            Controls.Add(VariantLabel);
            Controls.Add(HeaderLabel);
            Name = "HelloForm";
            Text = "HelloForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HeaderLabel;
        private Label VariantLabel;
        private Label label1;
        private Label TaskLabel;
        private PictureBox pictureBox1;
        private Button OkButton;
    }
}