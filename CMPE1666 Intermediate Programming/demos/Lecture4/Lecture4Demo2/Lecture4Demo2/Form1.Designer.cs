namespace Lecture4Demo2
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
            this.UI_ValuesFromUser_Tbx = new System.Windows.Forms.TextBox();
            this.UI_SaveToFile_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UI_ValuesFromUser_Tbx
            // 
            this.UI_ValuesFromUser_Tbx.Location = new System.Drawing.Point(54, 31);
            this.UI_ValuesFromUser_Tbx.Multiline = true;
            this.UI_ValuesFromUser_Tbx.Name = "UI_ValuesFromUser_Tbx";
            this.UI_ValuesFromUser_Tbx.Size = new System.Drawing.Size(262, 172);
            this.UI_ValuesFromUser_Tbx.TabIndex = 0;
            // 
            // UI_SaveToFile_Btn
            // 
            this.UI_SaveToFile_Btn.Location = new System.Drawing.Point(54, 210);
            this.UI_SaveToFile_Btn.Name = "UI_SaveToFile_Btn";
            this.UI_SaveToFile_Btn.Size = new System.Drawing.Size(262, 44);
            this.UI_SaveToFile_Btn.TabIndex = 1;
            this.UI_SaveToFile_Btn.Text = "Save To File";
            this.UI_SaveToFile_Btn.UseVisualStyleBackColor = true;
            this.UI_SaveToFile_Btn.Click += new System.EventHandler(this.UI_SaveToFile_Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 266);
            this.Controls.Add(this.UI_SaveToFile_Btn);
            this.Controls.Add(this.UI_ValuesFromUser_Tbx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UI_ValuesFromUser_Tbx;
        private System.Windows.Forms.Button UI_SaveToFile_Btn;
    }
}

