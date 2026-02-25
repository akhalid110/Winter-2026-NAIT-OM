namespace ICA06_DareenKN
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            UI_AddBalls_Btn = new Button();
            SuspendLayout();
            // 
            // UI_AddBalls_Btn
            // 
            UI_AddBalls_Btn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UI_AddBalls_Btn.BackColor = SystemColors.ScrollBar;
            UI_AddBalls_Btn.BackgroundImageLayout = ImageLayout.Center;
            UI_AddBalls_Btn.Font = new Font("MV Boli", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UI_AddBalls_Btn.Location = new Point(16, 9);
            UI_AddBalls_Btn.Margin = new Padding(3, 4, 3, 4);
            UI_AddBalls_Btn.MaximumSize = new Size(451, 64);
            UI_AddBalls_Btn.MinimumSize = new Size(451, 64);
            UI_AddBalls_Btn.Name = "UI_AddBalls_Btn";
            UI_AddBalls_Btn.Size = new Size(451, 64);
            UI_AddBalls_Btn.TabIndex = 2;
            UI_AddBalls_Btn.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 83);
            Controls.Add(UI_AddBalls_Btn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button UI_AddBalls_Btn;
    }
}
