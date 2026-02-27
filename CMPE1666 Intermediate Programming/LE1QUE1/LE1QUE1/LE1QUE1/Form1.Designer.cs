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
            this.UI_Smaller_Btn = new System.Windows.Forms.Button();
            this.UI_Bigger_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UI_AddBall_Btn
            // 
            this.UI_AddBall_Btn.Location = new System.Drawing.Point(16, 15);
            this.UI_AddBall_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.UI_AddBall_Btn.Name = "UI_AddBall_Btn";
            this.UI_AddBall_Btn.Size = new System.Drawing.Size(100, 28);
            this.UI_AddBall_Btn.TabIndex = 0;
            this.UI_AddBall_Btn.Text = "Add Balls";
            this.UI_AddBall_Btn.UseVisualStyleBackColor = true;
            // 
            // UI_Rand_Rdo
            // 
            this.UI_Rand_Rdo.AutoSize = true;
            this.UI_Rand_Rdo.Location = new System.Drawing.Point(171, 21);
            this.UI_Rand_Rdo.Margin = new System.Windows.Forms.Padding(4);
            this.UI_Rand_Rdo.Name = "UI_Rand_Rdo";
            this.UI_Rand_Rdo.Size = new System.Drawing.Size(83, 20);
            this.UI_Rand_Rdo.TabIndex = 1;
            this.UI_Rand_Rdo.TabStop = true;
            this.UI_Rand_Rdo.Text = "Random ";
            this.UI_Rand_Rdo.UseVisualStyleBackColor = true;
            // 
            // UI_Align_Rdo
            // 
            this.UI_Align_Rdo.AutoSize = true;
            this.UI_Align_Rdo.Location = new System.Drawing.Point(300, 22);
            this.UI_Align_Rdo.Margin = new System.Windows.Forms.Padding(4);
            this.UI_Align_Rdo.Name = "UI_Align_Rdo";
            this.UI_Align_Rdo.Size = new System.Drawing.Size(82, 20);
            this.UI_Align_Rdo.TabIndex = 2;
            this.UI_Align_Rdo.TabStop = true;
            this.UI_Align_Rdo.Text = "Align Left";
            this.UI_Align_Rdo.UseVisualStyleBackColor = true;
            // 
            // UI_ListBox
            // 
            this.UI_ListBox.FormattingEnabled = true;
            this.UI_ListBox.ItemHeight = 16;
            this.UI_ListBox.Location = new System.Drawing.Point(17, 52);
            this.UI_ListBox.Margin = new System.Windows.Forms.Padding(4);
            this.UI_ListBox.Name = "UI_ListBox";
            this.UI_ListBox.Size = new System.Drawing.Size(243, 372);
            this.UI_ListBox.TabIndex = 3;
            // 
            // UI_Start_Btn
            // 
            this.UI_Start_Btn.Location = new System.Drawing.Point(268, 52);
            this.UI_Start_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.UI_Start_Btn.Name = "UI_Start_Btn";
            this.UI_Start_Btn.Size = new System.Drawing.Size(181, 47);
            this.UI_Start_Btn.TabIndex = 4;
            this.UI_Start_Btn.Text = "Start";
            this.UI_Start_Btn.UseVisualStyleBackColor = true;
            this.UI_Start_Btn.Click += new System.EventHandler(this.UI_Start_Btn_Click);
            // 
            // UI_Stop_Btn
            // 
            this.UI_Stop_Btn.Location = new System.Drawing.Point(268, 132);
            this.UI_Stop_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.UI_Stop_Btn.Name = "UI_Stop_Btn";
            this.UI_Stop_Btn.Size = new System.Drawing.Size(181, 47);
            this.UI_Stop_Btn.TabIndex = 5;
            this.UI_Stop_Btn.Text = "Stop";
            this.UI_Stop_Btn.UseVisualStyleBackColor = true;
            // 
            // UI_Smaller_Btn
            // 
            this.UI_Smaller_Btn.Location = new System.Drawing.Point(268, 229);
            this.UI_Smaller_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.UI_Smaller_Btn.Name = "UI_Smaller_Btn";
            this.UI_Smaller_Btn.Size = new System.Drawing.Size(181, 47);
            this.UI_Smaller_Btn.TabIndex = 6;
            this.UI_Smaller_Btn.Text = "Smaller size ";
            this.UI_Smaller_Btn.UseVisualStyleBackColor = true;
            // 
            // UI_Bigger_Btn
            // 
            this.UI_Bigger_Btn.Location = new System.Drawing.Point(268, 308);
            this.UI_Bigger_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.UI_Bigger_Btn.Name = "UI_Bigger_Btn";
            this.UI_Bigger_Btn.Size = new System.Drawing.Size(181, 47);
            this.UI_Bigger_Btn.TabIndex = 7;
            this.UI_Bigger_Btn.Text = "Bigger size ";
            this.UI_Bigger_Btn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 452);
            this.Controls.Add(this.UI_Bigger_Btn);
            this.Controls.Add(this.UI_Smaller_Btn);
            this.Controls.Add(this.UI_Stop_Btn);
            this.Controls.Add(this.UI_Start_Btn);
            this.Controls.Add(this.UI_ListBox);
            this.Controls.Add(this.UI_Align_Rdo);
            this.Controls.Add(this.UI_Rand_Rdo);
            this.Controls.Add(this.UI_AddBall_Btn);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button UI_Smaller_Btn;
        private System.Windows.Forms.Button UI_Bigger_Btn;
    }
}

