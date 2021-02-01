
namespace Lohotron
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
            this.StartButton = new System.Windows.Forms.Button();
            this.TextLabel = new System.Windows.Forms.Label();
            this.t1 = new System.Windows.Forms.TextBox();
            this.t2 = new System.Windows.Forms.TextBox();
            this.t3 = new System.Windows.Forms.TextBox();
            this.t4 = new System.Windows.Forms.TextBox();
            this.t5 = new System.Windows.Forms.TextBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(184, 332);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(191, 48);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Let\'s roll!";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // TextLabel
            // 
            this.TextLabel.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TextLabel.Location = new System.Drawing.Point(109, 45);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(343, 28);
            this.TextLabel.TabIndex = 1;
            this.TextLabel.Text = "Choose your Destiny!";
            this.TextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // t1
            // 
            this.t1.Location = new System.Drawing.Point(113, 117);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(35, 27);
            this.t1.TabIndex = 2;
            this.t1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.t1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t1_KeyPress);
            // 
            // t2
            // 
            this.t2.Location = new System.Drawing.Point(189, 117);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(35, 27);
            this.t2.TabIndex = 3;
            this.t2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.t2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t2_KeyPress);
            // 
            // t3
            // 
            this.t3.Location = new System.Drawing.Point(265, 117);
            this.t3.Name = "t3";
            this.t3.Size = new System.Drawing.Size(35, 27);
            this.t3.TabIndex = 4;
            this.t3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.t3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t3_KeyPress);
            // 
            // t4
            // 
            this.t4.Location = new System.Drawing.Point(341, 117);
            this.t4.Name = "t4";
            this.t4.Size = new System.Drawing.Size(35, 27);
            this.t4.TabIndex = 5;
            this.t4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.t4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t4_KeyPress);
            // 
            // t5
            // 
            this.t5.Location = new System.Drawing.Point(417, 117);
            this.t5.Name = "t5";
            this.t5.Size = new System.Drawing.Size(35, 27);
            this.t5.TabIndex = 6;
            this.t5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.t5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t5_KeyPress);
            // 
            // ResultLabel
            // 
            this.ResultLabel.BackColor = System.Drawing.SystemColors.Menu;
            this.ResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultLabel.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.ResultLabel.Location = new System.Drawing.Point(50, 167);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(461, 150);
            this.ResultLabel.TabIndex = 7;
            this.ResultLabel.Text = "Введите номера от 1 до 25. И скрестите пальцы:)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(561, 421);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.t5);
            this.Controls.Add(this.t4);
            this.Controls.Add(this.t3);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.t1);
            this.Controls.Add(this.TextLabel);
            this.Controls.Add(this.StartButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label TextLabel;
        private System.Windows.Forms.TextBox t1;
        private System.Windows.Forms.TextBox t2;
        private System.Windows.Forms.TextBox t3;
        private System.Windows.Forms.TextBox t4;
        private System.Windows.Forms.TextBox t5;
        private System.Windows.Forms.Label ResultLabel;
    }
}

