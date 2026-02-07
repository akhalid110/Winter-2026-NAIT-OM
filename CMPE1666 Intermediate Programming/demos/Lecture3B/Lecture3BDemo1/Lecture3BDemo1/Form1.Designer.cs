namespace Lecture3BDemo1
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
            this.UI_InitialValues_Tbx = new System.Windows.Forms.TextBox();
            this.UI_ShuffledValues_Tbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UI_Reload_Btn = new System.Windows.Forms.Button();
            this.UI_Shuffle_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UI_InitialValues_Tbx
            // 
            this.UI_InitialValues_Tbx.Location = new System.Drawing.Point(15, 47);
            this.UI_InitialValues_Tbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UI_InitialValues_Tbx.Multiline = true;
            this.UI_InitialValues_Tbx.Name = "UI_InitialValues_Tbx";
            this.UI_InitialValues_Tbx.ReadOnly = true;
            this.UI_InitialValues_Tbx.Size = new System.Drawing.Size(150, 113);
            this.UI_InitialValues_Tbx.TabIndex = 1;
            // 
            // UI_ShuffledValues_Tbx
            // 
            this.UI_ShuffledValues_Tbx.Location = new System.Drawing.Point(343, 47);
            this.UI_ShuffledValues_Tbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UI_ShuffledValues_Tbx.Multiline = true;
            this.UI_ShuffledValues_Tbx.Name = "UI_ShuffledValues_Tbx";
            this.UI_ShuffledValues_Tbx.ReadOnly = true;
            this.UI_ShuffledValues_Tbx.Size = new System.Drawing.Size(150, 113);
            this.UI_ShuffledValues_Tbx.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Initial Values";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(381, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Shuffled Values";
            // 
            // UI_Reload_Btn
            // 
            this.UI_Reload_Btn.Location = new System.Drawing.Point(42, 177);
            this.UI_Reload_Btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UI_Reload_Btn.Name = "UI_Reload_Btn";
            this.UI_Reload_Btn.Size = new System.Drawing.Size(85, 35);
            this.UI_Reload_Btn.TabIndex = 0;
            this.UI_Reload_Btn.Text = "Reload Left Textbox";
            this.UI_Reload_Btn.UseVisualStyleBackColor = true;
            this.UI_Reload_Btn.Click += new System.EventHandler(this.UI_Reload_Btn_Click);
            // 
            // UI_Shuffle_Btn
            // 
            this.UI_Shuffle_Btn.Location = new System.Drawing.Point(377, 177);
            this.UI_Shuffle_Btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UI_Shuffle_Btn.Name = "UI_Shuffle_Btn";
            this.UI_Shuffle_Btn.Size = new System.Drawing.Size(85, 35);
            this.UI_Shuffle_Btn.TabIndex = 5;
            this.UI_Shuffle_Btn.Text = "Shuffle Values";
            this.UI_Shuffle_Btn.UseVisualStyleBackColor = true;
            this.UI_Shuffle_Btn.Click += new System.EventHandler(this.UI_Shuffle_Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.UI_Shuffle_Btn);
            this.Controls.Add(this.UI_Reload_Btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UI_ShuffledValues_Tbx);
            this.Controls.Add(this.UI_InitialValues_Tbx);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UI_InitialValues_Tbx;
        private System.Windows.Forms.TextBox UI_ShuffledValues_Tbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button UI_Reload_Btn;
        private System.Windows.Forms.Button UI_Shuffle_Btn;
    }
}

