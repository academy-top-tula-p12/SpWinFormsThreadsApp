namespace SpWinFormsThreadsApp
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
            btnThreadRedStart = new Button();
            btnThreadBlueStart = new Button();
            btnThreadRedStop = new Button();
            btnThreadBlueStop = new Button();
            SuspendLayout();
            // 
            // btnThreadRedStart
            // 
            btnThreadRedStart.Location = new Point(12, 10);
            btnThreadRedStart.Name = "btnThreadRedStart";
            btnThreadRedStart.Size = new Size(138, 40);
            btnThreadRedStart.TabIndex = 0;
            btnThreadRedStart.Text = "Red Start";
            btnThreadRedStart.UseVisualStyleBackColor = true;
            btnThreadRedStart.Click += btnThreadRed_Click;
            // 
            // btnThreadBlueStart
            // 
            btnThreadBlueStart.Location = new Point(378, 10);
            btnThreadBlueStart.Name = "btnThreadBlueStart";
            btnThreadBlueStart.Size = new Size(126, 40);
            btnThreadBlueStart.TabIndex = 0;
            btnThreadBlueStart.Text = "Blue Start";
            btnThreadBlueStart.UseVisualStyleBackColor = true;
            btnThreadBlueStart.Click += btnThreadBlue_Click;
            // 
            // btnThreadRedStop
            // 
            btnThreadRedStop.Enabled = false;
            btnThreadRedStop.Location = new Point(166, 10);
            btnThreadRedStop.Name = "btnThreadRedStop";
            btnThreadRedStop.Size = new Size(138, 40);
            btnThreadRedStop.TabIndex = 0;
            btnThreadRedStop.Text = "Red Stop";
            btnThreadRedStop.UseVisualStyleBackColor = true;
            btnThreadRedStop.Click += btnThreadRedStop_Click;
            // 
            // btnThreadBlueStop
            // 
            btnThreadBlueStop.Location = new Point(521, 10);
            btnThreadBlueStop.Name = "btnThreadBlueStop";
            btnThreadBlueStop.Size = new Size(126, 40);
            btnThreadBlueStop.TabIndex = 0;
            btnThreadBlueStop.Text = "Blue Stop";
            btnThreadBlueStop.UseVisualStyleBackColor = true;
            btnThreadBlueStop.Click += btnThreadBlueStop_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 406);
            Controls.Add(btnThreadBlueStop);
            Controls.Add(btnThreadBlueStart);
            Controls.Add(btnThreadRedStop);
            Controls.Add(btnThreadRedStart);
            Font = new Font("Segoe UI", 18F);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button btnThreadRedStart;
        private Button btnThreadBlueStart;
        private Button btnThreadRedStop;
        private Button btnThreadBlueStop;
    }
}
