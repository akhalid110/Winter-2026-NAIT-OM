namespace Lecture4Demo3
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
            this.UI_LoadFile1_Btn = new System.Windows.Forms.Button();
            this.UI_LoadFile2_Btn = new System.Windows.Forms.Button();
            this.UI_DisplayFile1_Lbx = new System.Windows.Forms.ListBox();
            this.UI_DisplayFile2_Tbx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UI_LoadFile1_Btn
            // 
            this.UI_LoadFile1_Btn.Location = new System.Drawing.Point(22, 257);
            this.UI_LoadFile1_Btn.Name = "UI_LoadFile1_Btn";
            this.UI_LoadFile1_Btn.Size = new System.Drawing.Size(207, 59);
            this.UI_LoadFile1_Btn.TabIndex = 0;
            this.UI_LoadFile1_Btn.Text = "Load File 1 Data";
            this.UI_LoadFile1_Btn.UseVisualStyleBackColor = true;
            this.UI_LoadFile1_Btn.Click += new System.EventHandler(this.UI_LoadFile1_Btn_Click);
            // 
            // UI_LoadFile2_Btn
            // 
            this.UI_LoadFile2_Btn.Location = new System.Drawing.Point(256, 258);
            this.UI_LoadFile2_Btn.Name = "UI_LoadFile2_Btn";
            this.UI_LoadFile2_Btn.Size = new System.Drawing.Size(207, 59);
            this.UI_LoadFile2_Btn.TabIndex = 1;
            this.UI_LoadFile2_Btn.Text = "Load File 1 Data";
            this.UI_LoadFile2_Btn.UseVisualStyleBackColor = true;
            this.UI_LoadFile2_Btn.Click += new System.EventHandler(this.UI_LoadFile2_Btn_Click);
            // 
            // UI_DisplayFile1_Lbx
            // 
            this.UI_DisplayFile1_Lbx.FormattingEnabled = true;
            this.UI_DisplayFile1_Lbx.Location = new System.Drawing.Point(12, 13);
            this.UI_DisplayFile1_Lbx.Name = "UI_DisplayFile1_Lbx";
            this.UI_DisplayFile1_Lbx.Size = new System.Drawing.Size(226, 238);
            this.UI_DisplayFile1_Lbx.TabIndex = 2;
            // 
            // UI_DisplayFile2_Tbx
            // 
            this.UI_DisplayFile2_Tbx.Location = new System.Drawing.Point(256, 24);
            this.UI_DisplayFile2_Tbx.Multiline = true;
            this.UI_DisplayFile2_Tbx.Name = "UI_DisplayFile2_Tbx";
            this.UI_DisplayFile2_Tbx.Size = new System.Drawing.Size(207, 164);
            this.UI_DisplayFile2_Tbx.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 329);
            this.Controls.Add(this.UI_DisplayFile2_Tbx);
            this.Controls.Add(this.UI_DisplayFile1_Lbx);
            this.Controls.Add(this.UI_LoadFile2_Btn);
            this.Controls.Add(this.UI_LoadFile1_Btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UI_LoadFile1_Btn;
        private System.Windows.Forms.Button UI_LoadFile2_Btn;
        private System.Windows.Forms.ListBox UI_DisplayFile1_Lbx;
        private System.Windows.Forms.TextBox UI_DisplayFile2_Tbx;
    }
}

