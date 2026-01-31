namespace Lecture2BDemo4
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
            this.UI_Input_Tbx = new System.Windows.Forms.TextBox();
            this.UI_Display_Tbx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UI_Input_Tbx
            // 
            this.UI_Input_Tbx.Location = new System.Drawing.Point(154, 79);
            this.UI_Input_Tbx.Name = "UI_Input_Tbx";
            this.UI_Input_Tbx.Size = new System.Drawing.Size(139, 20);
            this.UI_Input_Tbx.TabIndex = 0;
            this.UI_Input_Tbx.TextChanged += new System.EventHandler(this.UI_Input_Tbx_TextChanged);
            // 
            // UI_Display_Tbx
            // 
            this.UI_Display_Tbx.Location = new System.Drawing.Point(154, 153);
            this.UI_Display_Tbx.Name = "UI_Display_Tbx";
            this.UI_Display_Tbx.Size = new System.Drawing.Size(139, 20);
            this.UI_Display_Tbx.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 321);
            this.Controls.Add(this.UI_Display_Tbx);
            this.Controls.Add(this.UI_Input_Tbx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UI_Input_Tbx;
        private System.Windows.Forms.TextBox UI_Display_Tbx;
    }
}

