namespace DigitalClock
{
    partial class DigitalClock
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
            this.label1 = new System.Windows.Forms.Label();
            this.ClockLabel = new System.Windows.Forms.Label();
            this.Clock = new System.Windows.Forms.Timer(this.components);
            this.WhiteButton = new System.Windows.Forms.Button();
            this.SkbButton = new System.Windows.Forms.Button();
            this.GreenButton = new System.Windows.Forms.Button();
            this.redButton = new System.Windows.Forms.Button();
            this.YellowButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // ClockLabel
            // 
            this.ClockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClockLabel.ForeColor = System.Drawing.Color.Red;
            this.ClockLabel.Location = new System.Drawing.Point(2, 5);
            this.ClockLabel.Name = "ClockLabel";
            this.ClockLabel.Size = new System.Drawing.Size(819, 401);
            this.ClockLabel.TabIndex = 1;
            this.ClockLabel.Text = "Loading...";
            this.ClockLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Clock
            // 
            this.Clock.Interval = 1000;
            this.Clock.Tick += new System.EventHandler(this.Clock_Tick);
            // 
            // WhiteButton
            // 
            this.WhiteButton.BackColor = System.Drawing.Color.White;
            this.WhiteButton.ForeColor = System.Drawing.Color.Transparent;
            this.WhiteButton.Location = new System.Drawing.Point(9, 409);
            this.WhiteButton.Name = "WhiteButton";
            this.WhiteButton.Size = new System.Drawing.Size(24, 23);
            this.WhiteButton.TabIndex = 2;
            this.WhiteButton.UseVisualStyleBackColor = false;
            this.WhiteButton.Click += new System.EventHandler(this.WhiteButton_Click);
            // 
            // SkbButton
            // 
            this.SkbButton.BackColor = System.Drawing.Color.SkyBlue;
            this.SkbButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SkbButton.Location = new System.Drawing.Point(101, 409);
            this.SkbButton.Name = "SkbButton";
            this.SkbButton.Size = new System.Drawing.Size(27, 23);
            this.SkbButton.TabIndex = 5;
            this.SkbButton.UseVisualStyleBackColor = false;
            this.SkbButton.Click += new System.EventHandler(this.SkbButton_Click);
            // 
            // GreenButton
            // 
            this.GreenButton.BackColor = System.Drawing.Color.Green;
            this.GreenButton.ForeColor = System.Drawing.Color.Transparent;
            this.GreenButton.Location = new System.Drawing.Point(71, 409);
            this.GreenButton.Name = "GreenButton";
            this.GreenButton.Size = new System.Drawing.Size(24, 23);
            this.GreenButton.TabIndex = 4;
            this.GreenButton.UseVisualStyleBackColor = false;
            this.GreenButton.Click += new System.EventHandler(this.GreenButton_Click);
            // 
            // redButton
            // 
            this.redButton.BackColor = System.Drawing.Color.Red;
            this.redButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.redButton.Location = new System.Drawing.Point(134, 409);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(27, 23);
            this.redButton.TabIndex = 6;
            this.redButton.UseVisualStyleBackColor = false;
            this.redButton.Click += new System.EventHandler(this.redButton_Click);
            // 
            // YellowButton
            // 
            this.YellowButton.BackColor = System.Drawing.Color.Yellow;
            this.YellowButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.YellowButton.Location = new System.Drawing.Point(39, 409);
            this.YellowButton.Name = "YellowButton";
            this.YellowButton.Size = new System.Drawing.Size(27, 23);
            this.YellowButton.TabIndex = 7;
            this.YellowButton.UseVisualStyleBackColor = false;
            this.YellowButton.Click += new System.EventHandler(this.YellowButton_Click);
            // 
            // DigitalClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(822, 444);
            this.Controls.Add(this.YellowButton);
            this.Controls.Add(this.redButton);
            this.Controls.Add(this.SkbButton);
            this.Controls.Add(this.GreenButton);
            this.Controls.Add(this.WhiteButton);
            this.Controls.Add(this.ClockLabel);
            this.Controls.Add(this.label1);
            this.Name = "DigitalClock";
            this.Text = "Digital Clock";
            this.Load += new System.EventHandler(this.Digital_Clock);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ClockLabel;
        private System.Windows.Forms.Timer Clock;
        private System.Windows.Forms.Button WhiteButton;
        private System.Windows.Forms.Button SkbButton;
        private System.Windows.Forms.Button GreenButton;
        private System.Windows.Forms.Button redButton;
        private System.Windows.Forms.Button YellowButton;
    }
}

