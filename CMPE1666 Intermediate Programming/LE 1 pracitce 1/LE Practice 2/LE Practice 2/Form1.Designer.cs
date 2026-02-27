namespace LE_Practice_2
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
            this.UI_File_Lbx = new System.Windows.Forms.ListBox();
            this.UI_Drop_Lbl = new System.Windows.Forms.Label();
            this.UI_Employees_Lbx = new System.Windows.Forms.ListBox();
            this.UI_DisplayStructs_Btn = new System.Windows.Forms.Button();
            this.UI_ShuffleData_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UI_File_Lbx
            // 
            this.UI_File_Lbx.FormattingEnabled = true;
            this.UI_File_Lbx.Location = new System.Drawing.Point(26, 63);
            this.UI_File_Lbx.Name = "UI_File_Lbx";
            this.UI_File_Lbx.Size = new System.Drawing.Size(216, 264);
            this.UI_File_Lbx.TabIndex = 0;
            // 
            // UI_Drop_Lbl
            // 
            this.UI_Drop_Lbl.BackColor = System.Drawing.Color.Blue;
            this.UI_Drop_Lbl.ForeColor = System.Drawing.Color.White;
            this.UI_Drop_Lbl.Location = new System.Drawing.Point(23, 12);
            this.UI_Drop_Lbl.Name = "UI_Drop_Lbl";
            this.UI_Drop_Lbl.Size = new System.Drawing.Size(219, 34);
            this.UI_Drop_Lbl.TabIndex = 1;
            this.UI_Drop_Lbl.Text = "Drap and Drop Here ";
            // 
            // UI_Employees_Lbx
            // 
            this.UI_Employees_Lbx.FormattingEnabled = true;
            this.UI_Employees_Lbx.Location = new System.Drawing.Point(343, 63);
            this.UI_Employees_Lbx.Name = "UI_Employees_Lbx";
            this.UI_Employees_Lbx.Size = new System.Drawing.Size(216, 264);
            this.UI_Employees_Lbx.TabIndex = 2;
            // 
            // UI_DisplayStructs_Btn
            // 
            this.UI_DisplayStructs_Btn.Location = new System.Drawing.Point(343, 12);
            this.UI_DisplayStructs_Btn.Name = "UI_DisplayStructs_Btn";
            this.UI_DisplayStructs_Btn.Size = new System.Drawing.Size(107, 34);
            this.UI_DisplayStructs_Btn.TabIndex = 3;
            this.UI_DisplayStructs_Btn.Text = "Display Structs";
            this.UI_DisplayStructs_Btn.UseVisualStyleBackColor = true;
            // 
            // UI_ShuffleData_Btn
            // 
            this.UI_ShuffleData_Btn.Location = new System.Drawing.Point(452, 12);
            this.UI_ShuffleData_Btn.Name = "UI_ShuffleData_Btn";
            this.UI_ShuffleData_Btn.Size = new System.Drawing.Size(107, 34);
            this.UI_ShuffleData_Btn.TabIndex = 4;
            this.UI_ShuffleData_Btn.Text = "Shuffle Data";
            this.UI_ShuffleData_Btn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 353);
            this.Controls.Add(this.UI_ShuffleData_Btn);
            this.Controls.Add(this.UI_DisplayStructs_Btn);
            this.Controls.Add(this.UI_Employees_Lbx);
            this.Controls.Add(this.UI_Drop_Lbl);
            this.Controls.Add(this.UI_File_Lbx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox UI_File_Lbx;
        private System.Windows.Forms.Label UI_Drop_Lbl;
        private System.Windows.Forms.ListBox UI_Employees_Lbx;
        private System.Windows.Forms.Button UI_DisplayStructs_Btn;
        private System.Windows.Forms.Button UI_ShuffleData_Btn;
    }
}

