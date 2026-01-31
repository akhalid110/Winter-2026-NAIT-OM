namespace Lecture3Demo3
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
            this.UI_Display_Tbx = new System.Windows.Forms.TextBox();
            this.UI_Display_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UI_Display_Tbx
            // 
            this.UI_Display_Tbx.Location = new System.Drawing.Point(22, 23);
            this.UI_Display_Tbx.Multiline = true;
            this.UI_Display_Tbx.Name = "UI_Display_Tbx";
            this.UI_Display_Tbx.ReadOnly = true;
            this.UI_Display_Tbx.Size = new System.Drawing.Size(395, 192);
            this.UI_Display_Tbx.TabIndex = 0;
            // 
            // UI_Display_Btn
            // 
            this.UI_Display_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Display_Btn.Location = new System.Drawing.Point(67, 221);
            this.UI_Display_Btn.Name = "UI_Display_Btn";
            this.UI_Display_Btn.Size = new System.Drawing.Size(298, 69);
            this.UI_Display_Btn.TabIndex = 1;
            this.UI_Display_Btn.Text = "Display Value";
            this.UI_Display_Btn.UseVisualStyleBackColor = true;
            this.UI_Display_Btn.Click += new System.EventHandler(this.UI_Display_Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 313);
            this.Controls.Add(this.UI_Display_Btn);
            this.Controls.Add(this.UI_Display_Tbx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UI_Display_Tbx;
        private System.Windows.Forms.Button UI_Display_Btn;
    }
}

