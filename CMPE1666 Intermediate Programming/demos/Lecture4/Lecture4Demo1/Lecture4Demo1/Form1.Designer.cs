namespace Lecture4Demo1
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
            this.UI_AddToList_Btn = new System.Windows.Forms.Button();
            this.UI_Save_Btn = new System.Windows.Forms.Button();
            this.UI_Display_Lbx = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UI_Input_Tbx
            // 
            this.UI_Input_Tbx.Location = new System.Drawing.Point(51, 36);
            this.UI_Input_Tbx.Name = "UI_Input_Tbx";
            this.UI_Input_Tbx.Size = new System.Drawing.Size(154, 20);
            this.UI_Input_Tbx.TabIndex = 0;
            // 
            // UI_AddToList_Btn
            // 
            this.UI_AddToList_Btn.Location = new System.Drawing.Point(51, 96);
            this.UI_AddToList_Btn.Name = "UI_AddToList_Btn";
            this.UI_AddToList_Btn.Size = new System.Drawing.Size(154, 45);
            this.UI_AddToList_Btn.TabIndex = 1;
            this.UI_AddToList_Btn.Text = "Add To List";
            this.UI_AddToList_Btn.UseVisualStyleBackColor = true;
            this.UI_AddToList_Btn.Click += new System.EventHandler(this.UI_AddToList_Btn_Click);
            // 
            // UI_Save_Btn
            // 
            this.UI_Save_Btn.Location = new System.Drawing.Point(51, 177);
            this.UI_Save_Btn.Name = "UI_Save_Btn";
            this.UI_Save_Btn.Size = new System.Drawing.Size(154, 45);
            this.UI_Save_Btn.TabIndex = 2;
            this.UI_Save_Btn.Text = "Save To File";
            this.UI_Save_Btn.UseVisualStyleBackColor = true;
            this.UI_Save_Btn.Click += new System.EventHandler(this.UI_Save_Btn_Click);
            // 
            // UI_Display_Lbx
            // 
            this.UI_Display_Lbx.FormattingEnabled = true;
            this.UI_Display_Lbx.Location = new System.Drawing.Point(224, 36);
            this.UI_Display_Lbx.Name = "UI_Display_Lbx";
            this.UI_Display_Lbx.Size = new System.Drawing.Size(193, 186);
            this.UI_Display_Lbx.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Text: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 240);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UI_Display_Lbx);
            this.Controls.Add(this.UI_Save_Btn);
            this.Controls.Add(this.UI_AddToList_Btn);
            this.Controls.Add(this.UI_Input_Tbx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UI_Input_Tbx;
        private System.Windows.Forms.Button UI_AddToList_Btn;
        private System.Windows.Forms.Button UI_Save_Btn;
        private System.Windows.Forms.ListBox UI_Display_Lbx;
        private System.Windows.Forms.Label label1;
    }
}

