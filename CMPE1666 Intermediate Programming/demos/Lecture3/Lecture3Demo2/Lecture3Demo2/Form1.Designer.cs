namespace Lecture3Demo2
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
            this.UI_ValuesList_Lbx = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UI_NewValue_Tbx = new System.Windows.Forms.TextBox();
            this.UI_Count_Tbx = new System.Windows.Forms.TextBox();
            this.UI_AddToList_btn = new System.Windows.Forms.Button();
            this.UI_SendToListBox_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UI_ValuesList_Lbx
            // 
            this.UI_ValuesList_Lbx.FormattingEnabled = true;
            this.UI_ValuesList_Lbx.Location = new System.Drawing.Point(13, 51);
            this.UI_ValuesList_Lbx.Name = "UI_ValuesList_Lbx";
            this.UI_ValuesList_Lbx.Size = new System.Drawing.Size(229, 225);
            this.UI_ValuesList_Lbx.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "List of Values";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(265, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "New Value: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(265, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "List Count: ";
            // 
            // UI_NewValue_Tbx
            // 
            this.UI_NewValue_Tbx.Location = new System.Drawing.Point(361, 66);
            this.UI_NewValue_Tbx.Name = "UI_NewValue_Tbx";
            this.UI_NewValue_Tbx.Size = new System.Drawing.Size(100, 20);
            this.UI_NewValue_Tbx.TabIndex = 4;
            // 
            // UI_Count_Tbx
            // 
            this.UI_Count_Tbx.Location = new System.Drawing.Point(353, 173);
            this.UI_Count_Tbx.Name = "UI_Count_Tbx";
            this.UI_Count_Tbx.Size = new System.Drawing.Size(100, 20);
            this.UI_Count_Tbx.TabIndex = 5;
            // 
            // UI_AddToList_btn
            // 
            this.UI_AddToList_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_AddToList_btn.Location = new System.Drawing.Point(268, 100);
            this.UI_AddToList_btn.Name = "UI_AddToList_btn";
            this.UI_AddToList_btn.Size = new System.Drawing.Size(185, 58);
            this.UI_AddToList_btn.TabIndex = 6;
            this.UI_AddToList_btn.Text = "Add to List";
            this.UI_AddToList_btn.UseVisualStyleBackColor = true;
            this.UI_AddToList_btn.Click += new System.EventHandler(this.UI_AddToList_btn_Click);
            // 
            // UI_SendToListBox_btn
            // 
            this.UI_SendToListBox_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_SendToListBox_btn.Location = new System.Drawing.Point(268, 199);
            this.UI_SendToListBox_btn.Name = "UI_SendToListBox_btn";
            this.UI_SendToListBox_btn.Size = new System.Drawing.Size(185, 58);
            this.UI_SendToListBox_btn.TabIndex = 7;
            this.UI_SendToListBox_btn.Text = "Send To ListBox";
            this.UI_SendToListBox_btn.UseVisualStyleBackColor = true;
            this.UI_SendToListBox_btn.Click += new System.EventHandler(this.UI_SendToListBox_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 283);
            this.Controls.Add(this.UI_SendToListBox_btn);
            this.Controls.Add(this.UI_AddToList_btn);
            this.Controls.Add(this.UI_Count_Tbx);
            this.Controls.Add(this.UI_NewValue_Tbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UI_ValuesList_Lbx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox UI_ValuesList_Lbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UI_NewValue_Tbx;
        private System.Windows.Forms.TextBox UI_Count_Tbx;
        private System.Windows.Forms.Button UI_AddToList_btn;
        private System.Windows.Forms.Button UI_SendToListBox_btn;
    }
}

