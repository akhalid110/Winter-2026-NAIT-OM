namespace LE1QUE1
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
            this.UI_AddBall_Btn = new System.Windows.Forms.Button();
            this.UI_Rand_Rdo = new System.Windows.Forms.RadioButton();
            this.UI_Align_Rdo = new System.Windows.Forms.RadioButton();
            this.UI_ListBox = new System.Windows.Forms.ListBox();
            this.UI_Start_Btn = new System.Windows.Forms.Button();
            this.UI_Stop_Btn = new System.Windows.Forms.Button();
            this.UI_Move_Tmr = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // UI_AddBall_Btn
            // 
            this.UI_AddBall_Btn.Location = new System.Drawing.Point(12, 12);
            this.UI_AddBall_Btn.Name = "UI_AddBall_Btn";
            this.UI_AddBall_Btn.Size = new System.Drawing.Size(75, 23);
            this.UI_AddBall_Btn.TabIndex = 0;
            this.UI_AddBall_Btn.Text = "Add Balls";
            this.UI_AddBall_Btn.UseVisualStyleBackColor = true;
            // 
            // UI_Rand_Rdo
            // 
            this.UI_Rand_Rdo.AutoSize = true;
            this.UI_Rand_Rdo.Location = new System.Drawing.Point(128, 17);
            this.UI_Rand_Rdo.Name = "UI_Rand_Rdo";
            this.UI_Rand_Rdo.Size = new System.Drawing.Size(68, 17);
            this.UI_Rand_Rdo.TabIndex = 1;
            this.UI_Rand_Rdo.TabStop = true;
            this.UI_Rand_Rdo.Text = "Random ";
            this.UI_Rand_Rdo.UseVisualStyleBackColor = true;
            // 
            // UI_Align_Rdo
            // 
            this.UI_Align_Rdo.AutoSize = true;
            this.UI_Align_Rdo.Location = new System.Drawing.Point(225, 18);
            this.UI_Align_Rdo.Name = "UI_Align_Rdo";
            this.UI_Align_Rdo.Size = new System.Drawing.Size(69, 17);
            this.UI_Align_Rdo.TabIndex = 2;
            this.UI_Align_Rdo.TabStop = true;
            this.UI_Align_Rdo.Text = "Align Left";
            this.UI_Align_Rdo.UseVisualStyleBackColor = true;
            // 
            // UI_ListBox
            // 
            this.UI_ListBox.FormattingEnabled = true;
            this.UI_ListBox.Location = new System.Drawing.Point(13, 42);
            this.UI_ListBox.Name = "UI_ListBox";
            this.UI_ListBox.Size = new System.Drawing.Size(183, 303);
            this.UI_ListBox.TabIndex = 3;
            // 
            // UI_Start_Btn
            // 
            this.UI_Start_Btn.Location = new System.Drawing.Point(203, 134);
            this.UI_Start_Btn.Name = "UI_Start_Btn";
            this.UI_Start_Btn.Size = new System.Drawing.Size(136, 38);
            this.UI_Start_Btn.TabIndex = 4;
            this.UI_Start_Btn.Text = "Start";
            this.UI_Start_Btn.UseVisualStyleBackColor = true;
            // 
            // UI_Stop_Btn
            // 
            this.UI_Stop_Btn.Location = new System.Drawing.Point(203, 204);
            this.UI_Stop_Btn.Name = "UI_Stop_Btn";
            this.UI_Stop_Btn.Size = new System.Drawing.Size(136, 38);
            this.UI_Stop_Btn.TabIndex = 5;
            this.UI_Stop_Btn.Text = "Stop";
            this.UI_Stop_Btn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 367);
            this.Controls.Add(this.UI_Stop_Btn);
            this.Controls.Add(this.UI_Start_Btn);
            this.Controls.Add(this.UI_ListBox);
            this.Controls.Add(this.UI_Align_Rdo);
            this.Controls.Add(this.UI_Rand_Rdo);
            this.Controls.Add(this.UI_AddBall_Btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UI_AddBall_Btn;
        private System.Windows.Forms.RadioButton UI_Rand_Rdo;
        private System.Windows.Forms.RadioButton UI_Align_Rdo;
        private System.Windows.Forms.ListBox UI_ListBox;
        private System.Windows.Forms.Button UI_Start_Btn;
        private System.Windows.Forms.Button UI_Stop_Btn;
        private System.Windows.Forms.Timer UI_Move_Tmr;
    }
}

