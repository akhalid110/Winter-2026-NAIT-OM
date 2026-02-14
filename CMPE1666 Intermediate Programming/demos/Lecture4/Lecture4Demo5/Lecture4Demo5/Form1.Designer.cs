namespace Lecture4Demo5
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
            this.UI_LoadData_Btn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // UI_Display_Lbx
            // 
            this.UI_Display_Lbx.FormattingEnabled = true;
            this.UI_Display_Lbx.Location = new System.Drawing.Point(13, 13);
            this.UI_Display_Lbx.Name = "UI_Display_Lbx";
            this.UI_Display_Lbx.Size = new System.Drawing.Size(280, 251);
            this.UI_Display_Lbx.TabIndex = 0;
            // 
            // UI_LoadData_Btn
            // 
            this.UI_LoadData_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_LoadData_Btn.Location = new System.Drawing.Point(13, 271);
            this.UI_LoadData_Btn.Name = "UI_LoadData_Btn";
            this.UI_LoadData_Btn.Size = new System.Drawing.Size(280, 48);
            this.UI_LoadData_Btn.TabIndex = 1;
            this.UI_LoadData_Btn.Text = "Load Data ";
            this.UI_LoadData_Btn.UseVisualStyleBackColor = true;
            this.UI_LoadData_Btn.Click += new System.EventHandler(this.UI_LoadData_Btn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 331);
            this.Controls.Add(this.UI_LoadData_Btn);
            this.Controls.Add(this.UI_Display_Lbx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox UI_Display_Lbx;
        private System.Windows.Forms.Button UI_LoadData_Btn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

