namespace Lecture2BDemo10
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
            this.UI_Name_Tbx = new System.Windows.Forms.TextBox();
            this.UI_Course_Tbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UI_Enrolled_Cbx = new System.Windows.Forms.CheckBox();
            this.UI_Output_Lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UI_Name_Tbx
            // 
            this.UI_Name_Tbx.Location = new System.Drawing.Point(122, 51);
            this.UI_Name_Tbx.Name = "UI_Name_Tbx";
            this.UI_Name_Tbx.Size = new System.Drawing.Size(186, 20);
            this.UI_Name_Tbx.TabIndex = 0;
            // 
            // UI_Course_Tbx
            // 
            this.UI_Course_Tbx.Location = new System.Drawing.Point(122, 97);
            this.UI_Course_Tbx.Name = "UI_Course_Tbx";
            this.UI_Course_Tbx.Size = new System.Drawing.Size(186, 20);
            this.UI_Course_Tbx.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Course:";
            // 
            // UI_Enrolled_Cbx
            // 
            this.UI_Enrolled_Cbx.AutoSize = true;
            this.UI_Enrolled_Cbx.Location = new System.Drawing.Point(84, 141);
            this.UI_Enrolled_Cbx.Name = "UI_Enrolled_Cbx";
            this.UI_Enrolled_Cbx.Size = new System.Drawing.Size(64, 17);
            this.UI_Enrolled_Cbx.TabIndex = 4;
            this.UI_Enrolled_Cbx.Text = "Enrolled";
            this.UI_Enrolled_Cbx.UseVisualStyleBackColor = true;
            this.UI_Enrolled_Cbx.CheckedChanged += new System.EventHandler(this.UI_Enrolled_Cbx_CheckedChanged);
            // 
            // UI_Output_Lbl
            // 
            this.UI_Output_Lbl.AutoSize = true;
            this.UI_Output_Lbl.Location = new System.Drawing.Point(84, 198);
            this.UI_Output_Lbl.Name = "UI_Output_Lbl";
            this.UI_Output_Lbl.Size = new System.Drawing.Size(0, 13);
            this.UI_Output_Lbl.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 270);
            this.Controls.Add(this.UI_Output_Lbl);
            this.Controls.Add(this.UI_Enrolled_Cbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UI_Course_Tbx);
            this.Controls.Add(this.UI_Name_Tbx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UI_Name_Tbx;
        private System.Windows.Forms.TextBox UI_Course_Tbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox UI_Enrolled_Cbx;
        private System.Windows.Forms.Label UI_Output_Lbl;
    }
}

