namespace Employees
{
    partial class MainForm
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
            this.employeesGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.filterDropDown = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employeesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // employeesGridView
            // 
            this.employeesGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.employeesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesGridView.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.employeesGridView.Location = new System.Drawing.Point(12, 33);
            this.employeesGridView.Name = "employeesGridView";
            this.employeesGridView.RowHeadersVisible = false;
            this.employeesGridView.Size = new System.Drawing.Size(603, 405);
            this.employeesGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Фильтрация по должности:";
            // 
            // filterDropDown
            // 
            this.filterDropDown.FormattingEnabled = true;
            this.filterDropDown.Location = new System.Drawing.Point(165, 6);
            this.filterDropDown.Name = "filterDropDown";
            this.filterDropDown.Size = new System.Drawing.Size(121, 21);
            this.filterDropDown.TabIndex = 2;
            this.filterDropDown.SelectedIndexChanged += new System.EventHandler(this.filterDropDown_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(621, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Добавить сотрудника";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.addEmployee_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(621, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Удалить сотрудника";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.deleteEmployee_Click);
            // 
            // buttonReport
            // 
            this.buttonReport.Location = new System.Drawing.Point(621, 415);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(167, 23);
            this.buttonReport.TabIndex = 5;
            this.buttonReport.Text = "Отчет";
            this.buttonReport.UseVisualStyleBackColor = true;
            this.buttonReport.Click += new System.EventHandler(this.getReport_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonReport);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.filterDropDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.employeesGridView);
            this.Name = "MainForm";
            this.Text = "Управление сотрудниками";
            ((System.ComponentModel.ISupportInitialize)(this.employeesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView employeesGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox filterDropDown;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonReport;
    }
}