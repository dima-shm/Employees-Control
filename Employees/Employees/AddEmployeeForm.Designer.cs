using System;

namespace Employees
{
    partial class AddEmployeeForm
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.labelBirthYear = new System.Windows.Forms.Label();
            this.labelSalary = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxPosition = new System.Windows.Forms.TextBox();
            this.numericBirthYear = new System.Windows.Forms.NumericUpDown();
            this.numericSalary = new System.Windows.Forms.NumericUpDown();
            this.buttonAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericBirthYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(13, 13);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Имя";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(12, 39);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(56, 13);
            this.labelSurname.TabIndex = 1;
            this.labelSurname.Text = "Фамилия";
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(12, 65);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(65, 13);
            this.labelPosition.TabIndex = 2;
            this.labelPosition.Text = "Должность";
            // 
            // labelBirthYear
            // 
            this.labelBirthYear.AutoSize = true;
            this.labelBirthYear.Location = new System.Drawing.Point(12, 90);
            this.labelBirthYear.Name = "labelBirthYear";
            this.labelBirthYear.Size = new System.Drawing.Size(78, 13);
            this.labelBirthYear.TabIndex = 3;
            this.labelBirthYear.Text = "Год рождения";
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Location = new System.Drawing.Point(13, 116);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(55, 13);
            this.labelSalary.TabIndex = 4;
            this.labelSalary.Text = "Зарплата";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(170, 10);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(120, 20);
            this.textBoxName.TabIndex = 5;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(170, 36);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(120, 20);
            this.textBoxSurname.TabIndex = 6;
            // 
            // textBoxPosition
            // 
            this.textBoxPosition.Location = new System.Drawing.Point(170, 62);
            this.textBoxPosition.Name = "textBoxPosition";
            this.textBoxPosition.Size = new System.Drawing.Size(120, 20);
            this.textBoxPosition.TabIndex = 7;
            // 
            // numericBirthYear
            // 
            this.numericBirthYear.Location = new System.Drawing.Point(170, 88);
            this.numericBirthYear.Maximum = new decimal(new int[] {
            2019,
            0,
            0,
            0});
            this.numericBirthYear.Minimum = new decimal(new int[] {
            1940,
            0,
            0,
            0});
            this.numericBirthYear.Name = "numericBirthYear";
            this.numericBirthYear.Size = new System.Drawing.Size(120, 20);
            this.numericBirthYear.TabIndex = 8;
            this.numericBirthYear.Value = new decimal(new int[] {
            1940,
            0,
            0,
            0});
            // 
            // numericSalary
            // 
            this.numericSalary.Location = new System.Drawing.Point(170, 114);
            this.numericSalary.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericSalary.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericSalary.Name = "numericSalary";
            this.numericSalary.Size = new System.Drawing.Size(120, 20);
            this.numericSalary.TabIndex = 9;
            this.numericSalary.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(215, 151);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 186);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.numericSalary);
            this.Controls.Add(this.numericBirthYear);
            this.Controls.Add(this.textBoxPosition);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelSalary);
            this.Controls.Add(this.labelBirthYear);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelName);
            this.Name = "AddEmployeeForm";
            this.Text = "Добавление новго сотрудника";
            ((System.ComponentModel.ISupportInitialize)(this.numericBirthYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Label labelBirthYear;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxPosition;
        private System.Windows.Forms.NumericUpDown numericBirthYear;
        private System.Windows.Forms.NumericUpDown numericSalary;
        private System.Windows.Forms.Button buttonAdd;
    }
}