namespace Lecture3Demo5
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
            this.UI_Display_Lbx = new System.Windows.Forms.ListBox();
            this.UI_MaxID_Btn = new System.Windows.Forms.Button();
            this.UI_MinID_Btn = new System.Windows.Forms.Button();
            this.UI_ModifyStudent_Btn = new System.Windows.Forms.Button();
            this.UI_MaxID_Tbx = new System.Windows.Forms.TextBox();
            this.UI_MinID_Tbx = new System.Windows.Forms.TextBox();
            this.UI_StudentID_Tbx = new System.Windows.Forms.TextBox();
            this.UI_FirstName_Tbx = new System.Windows.Forms.TextBox();
            this.UI_LastName_Tbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UI_Display_Lbx
            // 
            this.UI_Display_Lbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Display_Lbx.FormattingEnabled = true;
            this.UI_Display_Lbx.ItemHeight = 16;
            this.UI_Display_Lbx.Location = new System.Drawing.Point(12, 62);
            this.UI_Display_Lbx.Name = "UI_Display_Lbx";
            this.UI_Display_Lbx.Size = new System.Drawing.Size(209, 340);
            this.UI_Display_Lbx.TabIndex = 0;
            // 
            // UI_MaxID_Btn
            // 
            this.UI_MaxID_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_MaxID_Btn.Location = new System.Drawing.Point(240, 62);
            this.UI_MaxID_Btn.Name = "UI_MaxID_Btn";
            this.UI_MaxID_Btn.Size = new System.Drawing.Size(199, 53);
            this.UI_MaxID_Btn.TabIndex = 1;
            this.UI_MaxID_Btn.Text = "Find Max Id Student";
            this.UI_MaxID_Btn.UseVisualStyleBackColor = true;
            this.UI_MaxID_Btn.Click += new System.EventHandler(this.UI_MaxID_Btn_Click);
            // 
            // UI_MinID_Btn
            // 
            this.UI_MinID_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_MinID_Btn.Location = new System.Drawing.Point(240, 137);
            this.UI_MinID_Btn.Name = "UI_MinID_Btn";
            this.UI_MinID_Btn.Size = new System.Drawing.Size(199, 53);
            this.UI_MinID_Btn.TabIndex = 2;
            this.UI_MinID_Btn.Text = "Find Min Id Student";
            this.UI_MinID_Btn.UseVisualStyleBackColor = true;
            this.UI_MinID_Btn.Click += new System.EventHandler(this.UI_MinID_Btn_Click);
            // 
            // UI_ModifyStudent_Btn
            // 
            this.UI_ModifyStudent_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_ModifyStudent_Btn.Location = new System.Drawing.Point(253, 349);
            this.UI_ModifyStudent_Btn.Name = "UI_ModifyStudent_Btn";
            this.UI_ModifyStudent_Btn.Size = new System.Drawing.Size(186, 53);
            this.UI_ModifyStudent_Btn.TabIndex = 3;
            this.UI_ModifyStudent_Btn.Text = "Modify Student";
            this.UI_ModifyStudent_Btn.UseVisualStyleBackColor = true;
            // 
            // UI_MaxID_Tbx
            // 
            this.UI_MaxID_Tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_MaxID_Tbx.Location = new System.Drawing.Point(617, 79);
            this.UI_MaxID_Tbx.Name = "UI_MaxID_Tbx";
            this.UI_MaxID_Tbx.ReadOnly = true;
            this.UI_MaxID_Tbx.Size = new System.Drawing.Size(212, 22);
            this.UI_MaxID_Tbx.TabIndex = 4;
            // 
            // UI_MinID_Tbx
            // 
            this.UI_MinID_Tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_MinID_Tbx.Location = new System.Drawing.Point(617, 126);
            this.UI_MinID_Tbx.Name = "UI_MinID_Tbx";
            this.UI_MinID_Tbx.ReadOnly = true;
            this.UI_MinID_Tbx.Size = new System.Drawing.Size(212, 22);
            this.UI_MinID_Tbx.TabIndex = 5;
            // 
            // UI_StudentID_Tbx
            // 
            this.UI_StudentID_Tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_StudentID_Tbx.Location = new System.Drawing.Point(323, 221);
            this.UI_StudentID_Tbx.Name = "UI_StudentID_Tbx";
            this.UI_StudentID_Tbx.ReadOnly = true;
            this.UI_StudentID_Tbx.Size = new System.Drawing.Size(116, 22);
            this.UI_StudentID_Tbx.TabIndex = 7;
            // 
            // UI_FirstName_Tbx
            // 
            this.UI_FirstName_Tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_FirstName_Tbx.Location = new System.Drawing.Point(323, 260);
            this.UI_FirstName_Tbx.Name = "UI_FirstName_Tbx";
            this.UI_FirstName_Tbx.Size = new System.Drawing.Size(116, 22);
            this.UI_FirstName_Tbx.TabIndex = 8;
            // 
            // UI_LastName_Tbx
            // 
            this.UI_LastName_Tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_LastName_Tbx.Location = new System.Drawing.Point(323, 299);
            this.UI_LastName_Tbx.Name = "UI_LastName_Tbx";
            this.UI_LastName_Tbx.Size = new System.Drawing.Size(116, 22);
            this.UI_LastName_Tbx.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Student Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(237, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(232, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(503, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Max Id Student:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(507, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Min Id Student:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 470);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UI_LastName_Tbx);
            this.Controls.Add(this.UI_FirstName_Tbx);
            this.Controls.Add(this.UI_StudentID_Tbx);
            this.Controls.Add(this.UI_MinID_Tbx);
            this.Controls.Add(this.UI_MaxID_Tbx);
            this.Controls.Add(this.UI_ModifyStudent_Btn);
            this.Controls.Add(this.UI_MinID_Btn);
            this.Controls.Add(this.UI_MaxID_Btn);
            this.Controls.Add(this.UI_Display_Lbx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox UI_Display_Lbx;
        private System.Windows.Forms.Button UI_MaxID_Btn;
        private System.Windows.Forms.Button UI_MinID_Btn;
        private System.Windows.Forms.Button UI_ModifyStudent_Btn;
        private System.Windows.Forms.TextBox UI_MaxID_Tbx;
        private System.Windows.Forms.TextBox UI_MinID_Tbx;
        private System.Windows.Forms.TextBox UI_StudentID_Tbx;
        private System.Windows.Forms.TextBox UI_FirstName_Tbx;
        private System.Windows.Forms.TextBox UI_LastName_Tbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

