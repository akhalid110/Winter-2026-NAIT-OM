namespace Lecture2BDemo6
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
            this.components = new System.ComponentModel.Container();
            this.UI_Timer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.UI_Display_Lbx = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // UI_Timer
            // 
            this.UI_Timer.Enabled = true;
            this.UI_Timer.Interval = 200;
            this.UI_Timer.Tick += new System.EventHandler(this.UI_Timer_Tick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(136, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 132);
            this.button1.TabIndex = 0;
            this.button1.Text = "STOP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UI_Display_Lbx
            // 
            this.UI_Display_Lbx.FormattingEnabled = true;
            this.UI_Display_Lbx.Location = new System.Drawing.Point(136, 83);
            this.UI_Display_Lbx.Name = "UI_Display_Lbx";
            this.UI_Display_Lbx.Size = new System.Drawing.Size(203, 134);
            this.UI_Display_Lbx.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 397);
            this.Controls.Add(this.UI_Display_Lbx);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer UI_Timer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox UI_Display_Lbx;
    }
}

