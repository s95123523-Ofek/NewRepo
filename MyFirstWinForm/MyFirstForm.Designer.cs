namespace MyFirstWinForm
{
    partial class MyFirstForm
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
            this.BtnClickMe = new System.Windows.Forms.Button();
            this.TxtMyFirstTxt = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.tmrMyTimer = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnClickMe
            // 
            this.BtnClickMe.Location = new System.Drawing.Point(116, 54);
            this.BtnClickMe.Name = "BtnClickMe";
            this.BtnClickMe.Size = new System.Drawing.Size(1259, 544);
            this.BtnClickMe.TabIndex = 0;
            this.BtnClickMe.Text = "ClickMe";
            this.BtnClickMe.UseVisualStyleBackColor = true;
            this.BtnClickMe.Click += new System.EventHandler(this.BtnClickMe_Click);
            // 
            // TxtMyFirstTxt
            // 
            this.TxtMyFirstTxt.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TxtMyFirstTxt.Location = new System.Drawing.Point(601, 290);
            this.TxtMyFirstTxt.Name = "TxtMyFirstTxt";
            this.TxtMyFirstTxt.Size = new System.Drawing.Size(223, 20);
            this.TxtMyFirstTxt.TabIndex = 3;
            this.TxtMyFirstTxt.Text = "hello";
            this.TxtMyFirstTxt.TextChanged += new System.EventHandler(this.TxtMyFirstTxt_TextChanged);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(916, 432);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(155, 68);
            this.StartButton.TabIndex = 4;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.Start_Timer);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(1094, 432);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(169, 67);
            this.StopButton.TabIndex = 5;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.Stop_timer);
            // 
            // tmrMyTimer
            // 
            this.tmrMyTimer.Tick += new System.EventHandler(this.tmrMyTimer_Tick);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(1063, 337);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(35, 13);
            this.lblTime.TabIndex = 6;
            this.lblTime.Text = "label1";
            // 
            // MyFirstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1487, 871);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.TxtMyFirstTxt);
            this.Controls.Add(this.BtnClickMe);
            this.Name = "MyFirstForm";
            this.Text = "Blue Rules";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnClickMe;
        private System.Windows.Forms.TextBox TxtMyFirstTxt;
        private System.Windows.Forms.Timer Start;
        private System.Windows.Forms.Timer Stop;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Timer tmrMyTimer;
        private System.Windows.Forms.Label lblTime;
    }
}

