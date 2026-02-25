namespace Lab01_OOP
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
            UI_Lst_Status = new ListBox();
            SuspendLayout();
            // 
            // UI_Lst_Status
            // 
            UI_Lst_Status.FormattingEnabled = true;
            UI_Lst_Status.ItemHeight = 15;
            UI_Lst_Status.Location = new Point(12, 12);
            UI_Lst_Status.Name = "UI_Lst_Status";
            UI_Lst_Status.Size = new Size(312, 319);
            UI_Lst_Status.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 346);
            Controls.Add(UI_Lst_Status);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox UI_Lst_Status;
    }
}
