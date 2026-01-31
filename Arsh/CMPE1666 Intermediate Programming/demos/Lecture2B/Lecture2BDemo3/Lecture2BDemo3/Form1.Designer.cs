namespace Lecture2BDemo3
{
    partial class Form1
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
            this.UI_Value1_Tbx = new System.Windows.Forms.TextBox();
            this.UI_Value2_Tbx = new System.Windows.Forms.TextBox();
            this.UI_Sum_Tbx = new System.Windows.Forms.TextBox();
            this.UI_Calculate_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Value 1 ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Value 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sum";
            // 
            // UI_Value1_Tbx
            // 
            this.UI_Value1_Tbx.Location = new System.Drawing.Point(184, 68);
            this.UI_Value1_Tbx.Name = "UI_Value1_Tbx";
            this.UI_Value1_Tbx.Size = new System.Drawing.Size(100, 20);
            this.UI_Value1_Tbx.TabIndex = 3;
            // 
            // UI_Value2_Tbx
            // 
            this.UI_Value2_Tbx.Location = new System.Drawing.Point(184, 102);
            this.UI_Value2_Tbx.Name = "UI_Value2_Tbx";
            this.UI_Value2_Tbx.Size = new System.Drawing.Size(100, 20);
            this.UI_Value2_Tbx.TabIndex = 4;
            // 
            // UI_Sum_Tbx
            // 
            this.UI_Sum_Tbx.Location = new System.Drawing.Point(184, 265);
            this.UI_Sum_Tbx.Name = "UI_Sum_Tbx";
            this.UI_Sum_Tbx.ReadOnly = true;
            this.UI_Sum_Tbx.Size = new System.Drawing.Size(100, 20);
            this.UI_Sum_Tbx.TabIndex = 5;
            // 
            // UI_Calculate_Btn
            // 
            this.UI_Calculate_Btn.Location = new System.Drawing.Point(93, 156);
            this.UI_Calculate_Btn.Name = "UI_Calculate_Btn";
            this.UI_Calculate_Btn.Size = new System.Drawing.Size(191, 67);
            this.UI_Calculate_Btn.TabIndex = 6;
            this.UI_Calculate_Btn.Text = "Calculate Sum";
            this.UI_Calculate_Btn.UseVisualStyleBackColor = true;
            this.UI_Calculate_Btn.Click += new System.EventHandler(this.UI_Calculate_Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 328);
            this.Controls.Add(this.UI_Calculate_Btn);
            this.Controls.Add(this.UI_Sum_Tbx);
            this.Controls.Add(this.UI_Value2_Tbx);
            this.Controls.Add(this.UI_Value1_Tbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UI_Value1_Tbx;
        private System.Windows.Forms.TextBox UI_Value2_Tbx;
        private System.Windows.Forms.TextBox UI_Sum_Tbx;
        private System.Windows.Forms.Button UI_Calculate_Btn;
    }
}

