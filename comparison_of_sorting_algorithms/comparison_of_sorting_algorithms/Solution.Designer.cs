namespace comparison_of_sorting_algorithms
{
    partial class Solution
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Sort_Name = new System.Windows.Forms.TextBox();
            this.min_time = new System.Windows.Forms.TextBox();
            this.max_time = new System.Windows.Forms.TextBox();
            this.average_time = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(41, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название алгоритма";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(44, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Минимальное время выполнения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(44, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Максимальное время выполнения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(44, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Среднее время выполенния";
            // 
            // Sort_Name
            // 
            this.Sort_Name.Location = new System.Drawing.Point(427, 48);
            this.Sort_Name.Name = "Sort_Name";
            this.Sort_Name.Size = new System.Drawing.Size(160, 20);
            this.Sort_Name.TabIndex = 4;
            // 
            // min_time
            // 
            this.min_time.Location = new System.Drawing.Point(427, 105);
            this.min_time.Name = "min_time";
            this.min_time.Size = new System.Drawing.Size(160, 20);
            this.min_time.TabIndex = 5;
            // 
            // max_time
            // 
            this.max_time.Location = new System.Drawing.Point(427, 164);
            this.max_time.Name = "max_time";
            this.max_time.Size = new System.Drawing.Size(160, 20);
            this.max_time.TabIndex = 6;
            // 
            // average_time
            // 
            this.average_time.Location = new System.Drawing.Point(427, 228);
            this.average_time.Name = "average_time";
            this.average_time.Size = new System.Drawing.Size(160, 20);
            this.average_time.TabIndex = 7;
            // 
            // Solution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 324);
            this.Controls.Add(this.average_time);
            this.Controls.Add(this.max_time);
            this.Controls.Add(this.min_time);
            this.Controls.Add(this.Sort_Name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Solution";
            this.Text = "Результаты";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Sort_Name;
        private System.Windows.Forms.TextBox min_time;
        private System.Windows.Forms.TextBox max_time;
        private System.Windows.Forms.TextBox average_time;
    }
}