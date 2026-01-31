namespace Lecture2BDemo1
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
            this.UI_Display_Lbl = new System.Windows.Forms.Label();
            this.UI_Change_Btn = new System.Windows.Forms.Button();
            this.UI_Input_Tbx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UI_Display_Lbl
            // 
            this.UI_Display_Lbl.AutoSize = true;
            this.UI_Display_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Display_Lbl.Location = new System.Drawing.Point(101, 145);
            this.UI_Display_Lbl.Name = "UI_Display_Lbl";
            this.UI_Display_Lbl.Size = new System.Drawing.Size(182, 25);
            this.UI_Display_Lbl.TabIndex = 0;
            this.UI_Display_Lbl.Text = "Initial Label Value";
            // 
            // UI_Change_Btn
            // 
            this.UI_Change_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Change_Btn.Location = new System.Drawing.Point(106, 221);
            this.UI_Change_Btn.Name = "UI_Change_Btn";
            this.UI_Change_Btn.Size = new System.Drawing.Size(177, 76);
            this.UI_Change_Btn.TabIndex = 1;
            this.UI_Change_Btn.Text = "Change Label Value";
            this.UI_Change_Btn.UseVisualStyleBackColor = true;
            this.UI_Change_Btn.Click += new System.EventHandler(this.UI_Change_Btn_Click);
            // 
            // UI_Input_Tbx
            // 
            this.UI_Input_Tbx.Location = new System.Drawing.Point(106, 80);
            this.UI_Input_Tbx.Name = "UI_Input_Tbx";
            this.UI_Input_Tbx.Size = new System.Drawing.Size(177, 20);
            this.UI_Input_Tbx.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 333);
            this.Controls.Add(this.UI_Input_Tbx);
            this.Controls.Add(this.UI_Change_Btn);
            this.Controls.Add(this.UI_Display_Lbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UI_Display_Lbl;
        private System.Windows.Forms.Button UI_Change_Btn;
        private System.Windows.Forms.TextBox UI_Input_Tbx;
    }
}

