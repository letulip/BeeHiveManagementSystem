namespace BeeHiveManagementSystem
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnWorkNextShift = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.combxJobList = new System.Windows.Forms.ComboBox();
            this.numudShifts = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAssingJobToBee = new System.Windows.Forms.Button();
            this.tbxReport = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numudShifts)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAssingJobToBee);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numudShifts);
            this.groupBox1.Controls.Add(this.combxJobList);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 106);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Worker Bee Assignment";
            // 
            // btnWorkNextShift
            // 
            this.btnWorkNextShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnWorkNextShift.Location = new System.Drawing.Point(360, 13);
            this.btnWorkNextShift.Name = "btnWorkNextShift";
            this.btnWorkNextShift.Size = new System.Drawing.Size(184, 97);
            this.btnWorkNextShift.TabIndex = 1;
            this.btnWorkNextShift.Text = "Work the next shift!";
            this.btnWorkNextShift.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Job";
            // 
            // combxJobList
            // 
            this.combxJobList.FormattingEnabled = true;
            this.combxJobList.Items.AddRange(new object[] {
            "Nectar collector",
            "Honey manufactoring",
            "Egg care",
            "Baby bee tutoring",
            "Hive maintenance",
            "Sting patrol"});
            this.combxJobList.Location = new System.Drawing.Point(10, 40);
            this.combxJobList.Name = "combxJobList";
            this.combxJobList.Size = new System.Drawing.Size(195, 24);
            this.combxJobList.TabIndex = 1;
            this.combxJobList.Text = "Choose job";
            // 
            // numudShifts
            // 
            this.numudShifts.Location = new System.Drawing.Point(212, 40);
            this.numudShifts.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numudShifts.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numudShifts.Name = "numudShifts";
            this.numudShifts.Size = new System.Drawing.Size(120, 22);
            this.numudShifts.TabIndex = 2;
            this.numudShifts.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Shifts";
            // 
            // btnAssingJobToBee
            // 
            this.btnAssingJobToBee.Location = new System.Drawing.Point(10, 71);
            this.btnAssingJobToBee.Name = "btnAssingJobToBee";
            this.btnAssingJobToBee.Size = new System.Drawing.Size(322, 23);
            this.btnAssingJobToBee.TabIndex = 4;
            this.btnAssingJobToBee.Text = "Assign this job to bee";
            this.btnAssingJobToBee.UseVisualStyleBackColor = true;
            // 
            // tbxReport
            // 
            this.tbxReport.Location = new System.Drawing.Point(13, 117);
            this.tbxReport.Multiline = true;
            this.tbxReport.Name = "tbxReport";
            this.tbxReport.Size = new System.Drawing.Size(531, 260);
            this.tbxReport.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 389);
            this.Controls.Add(this.tbxReport);
            this.Controls.Add(this.btnWorkNextShift);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Beehive Management System";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numudShifts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox combxJobList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnWorkNextShift;
        private System.Windows.Forms.Button btnAssingJobToBee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numudShifts;
        private System.Windows.Forms.TextBox tbxReport;
    }
}

