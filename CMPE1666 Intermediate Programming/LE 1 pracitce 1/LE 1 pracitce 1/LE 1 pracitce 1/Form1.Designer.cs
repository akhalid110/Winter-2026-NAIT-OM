namespace LE_1_pracitce_1
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
            this.UI_BallSize_Gpb = new System.Windows.Forms.GroupBox();
            this.UI_Small_Rdo = new System.Windows.Forms.RadioButton();
            this.UI_Medium_Rdo = new System.Windows.Forms.RadioButton();
            this.UI_Large_Rdo = new System.Windows.Forms.RadioButton();
            this.UI_RandColor_Btn = new System.Windows.Forms.Button();
            this.UI_RedColor_Btn = new System.Windows.Forms.Button();
            this.UI_Timer = new System.Windows.Forms.Timer(this.components);
            this.UI_BallSize_Gpb.SuspendLayout();
            this.SuspendLayout();
            // 
            // UI_BallSize_Gpb
            // 
            this.UI_BallSize_Gpb.Controls.Add(this.UI_Large_Rdo);
            this.UI_BallSize_Gpb.Controls.Add(this.UI_Medium_Rdo);
            this.UI_BallSize_Gpb.Controls.Add(this.UI_Small_Rdo);
            this.UI_BallSize_Gpb.Location = new System.Drawing.Point(13, 13);
            this.UI_BallSize_Gpb.Name = "UI_BallSize_Gpb";
            this.UI_BallSize_Gpb.Size = new System.Drawing.Size(114, 104);
            this.UI_BallSize_Gpb.TabIndex = 0;
            this.UI_BallSize_Gpb.TabStop = false;
            this.UI_BallSize_Gpb.Text = "Ball Size ";
            // 
            // UI_Small_Rdo
            // 
            this.UI_Small_Rdo.AutoSize = true;
            this.UI_Small_Rdo.Location = new System.Drawing.Point(7, 20);
            this.UI_Small_Rdo.Name = "UI_Small_Rdo";
            this.UI_Small_Rdo.Size = new System.Drawing.Size(50, 17);
            this.UI_Small_Rdo.TabIndex = 0;
            this.UI_Small_Rdo.TabStop = true;
            this.UI_Small_Rdo.Text = "Small";
            this.UI_Small_Rdo.UseVisualStyleBackColor = true;
            // 
            // UI_Medium_Rdo
            // 
            this.UI_Medium_Rdo.AutoSize = true;
            this.UI_Medium_Rdo.Location = new System.Drawing.Point(7, 43);
            this.UI_Medium_Rdo.Name = "UI_Medium_Rdo";
            this.UI_Medium_Rdo.Size = new System.Drawing.Size(65, 17);
            this.UI_Medium_Rdo.TabIndex = 1;
            this.UI_Medium_Rdo.TabStop = true;
            this.UI_Medium_Rdo.Text = "Medium ";
            this.UI_Medium_Rdo.UseVisualStyleBackColor = true;
            // 
            // UI_Large_Rdo
            // 
            this.UI_Large_Rdo.AutoSize = true;
            this.UI_Large_Rdo.Location = new System.Drawing.Point(7, 66);
            this.UI_Large_Rdo.Name = "UI_Large_Rdo";
            this.UI_Large_Rdo.Size = new System.Drawing.Size(52, 17);
            this.UI_Large_Rdo.TabIndex = 2;
            this.UI_Large_Rdo.TabStop = true;
            this.UI_Large_Rdo.Text = "Large";
            this.UI_Large_Rdo.UseVisualStyleBackColor = true;
            // 
            // UI_RandColor_Btn
            // 
            this.UI_RandColor_Btn.Location = new System.Drawing.Point(174, 33);
            this.UI_RandColor_Btn.Name = "UI_RandColor_Btn";
            this.UI_RandColor_Btn.Size = new System.Drawing.Size(172, 40);
            this.UI_RandColor_Btn.TabIndex = 1;
            this.UI_RandColor_Btn.Text = "Change Colors To Random";
            this.UI_RandColor_Btn.UseVisualStyleBackColor = true;
            // 
            // UI_RedColor_Btn
            // 
            this.UI_RedColor_Btn.Location = new System.Drawing.Point(174, 92);
            this.UI_RedColor_Btn.Name = "UI_RedColor_Btn";
            this.UI_RedColor_Btn.Size = new System.Drawing.Size(172, 40);
            this.UI_RedColor_Btn.TabIndex = 2;
            this.UI_RedColor_Btn.Text = "Change Colors To Red";
            this.UI_RedColor_Btn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 175);
            this.Controls.Add(this.UI_RedColor_Btn);
            this.Controls.Add(this.UI_RandColor_Btn);
            this.Controls.Add(this.UI_BallSize_Gpb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.UI_BallSize_Gpb.ResumeLayout(false);
            this.UI_BallSize_Gpb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox UI_BallSize_Gpb;
        private System.Windows.Forms.RadioButton UI_Large_Rdo;
        private System.Windows.Forms.RadioButton UI_Medium_Rdo;
        private System.Windows.Forms.RadioButton UI_Small_Rdo;
        private System.Windows.Forms.Button UI_RandColor_Btn;
        private System.Windows.Forms.Button UI_RedColor_Btn;
        private System.Windows.Forms.Timer UI_Timer;
    }
}

