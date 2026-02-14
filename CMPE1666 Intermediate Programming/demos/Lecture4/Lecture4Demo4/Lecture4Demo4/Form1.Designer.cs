namespace Lecture4Demo4
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
            this.UI_DisplayData_Lbx = new System.Windows.Forms.ListBox();
            this.UI_DisplayData_Btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UI_DisplayData_Lbx
            // 
            this.UI_DisplayData_Lbx.FormattingEnabled = true;
            this.UI_DisplayData_Lbx.Location = new System.Drawing.Point(13, 24);
            this.UI_DisplayData_Lbx.Name = "UI_DisplayData_Lbx";
            this.UI_DisplayData_Lbx.Size = new System.Drawing.Size(210, 199);
            this.UI_DisplayData_Lbx.TabIndex = 0;
            // 
            // UI_DisplayData_Btn
            // 
            this.UI_DisplayData_Btn.Location = new System.Drawing.Point(13, 240);
            this.UI_DisplayData_Btn.Name = "UI_DisplayData_Btn";
            this.UI_DisplayData_Btn.Size = new System.Drawing.Size(210, 41);
            this.UI_DisplayData_Btn.TabIndex = 1;
            this.UI_DisplayData_Btn.Text = "Display Data ";
            this.UI_DisplayData_Btn.UseVisualStyleBackColor = true;
            this.UI_DisplayData_Btn.Click += new System.EventHandler(this.UI_DisplayData_Btn_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 67);
            this.label1.TabIndex = 2;
            this.label1.Text = "Drag And Drop Your File Here";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.DragDrop += new System.Windows.Forms.DragEventHandler(this.label1_DragDrop);
            this.label1.DragEnter += new System.Windows.Forms.DragEventHandler(this.label1_DragEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 293);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UI_DisplayData_Btn);
            this.Controls.Add(this.UI_DisplayData_Lbx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox UI_DisplayData_Lbx;
        private System.Windows.Forms.Button UI_DisplayData_Btn;
        private System.Windows.Forms.Label label1;
    }
}

