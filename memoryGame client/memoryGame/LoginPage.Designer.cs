namespace memoryGame
{
    partial class LoginPage
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
            this.HelloThing = new System.Windows.Forms.Label();
            this.YourName = new System.Windows.Forms.Label();
            this.btnLog = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // HelloThing
            // 
            this.HelloThing.AutoSize = true;
            this.HelloThing.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelloThing.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.HelloThing.Location = new System.Drawing.Point(274, 74);
            this.HelloThing.Name = "HelloThing";
            this.HelloThing.Size = new System.Drawing.Size(254, 86);
            this.HelloThing.TabIndex = 0;
            this.HelloThing.Text = "HELLO!";
            // 
            // YourName
            // 
            this.YourName.AutoSize = true;
            this.YourName.Font = new System.Drawing.Font("Segoe UI", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.YourName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.YourName.Location = new System.Drawing.Point(241, 172);
            this.YourName.Name = "YourName";
            this.YourName.Size = new System.Drawing.Size(308, 48);
            this.YourName.TabIndex = 1;
            this.YourName.Text = "Enter your name:";
            // 
            // btnLog
            // 
            this.btnLog.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLog.Location = new System.Drawing.Point(670, 395);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(118, 43);
            this.btnLog.TabIndex = 2;
            this.btnLog.Text = "Log in!";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(279, 267);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 33);
            this.textBox1.TabIndex = 3;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.YourName);
            this.Controls.Add(this.HelloThing);
            this.Name = "LoginPage";
            this.Text = "LoginPage";
            //this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginPage_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HelloThing;
        private System.Windows.Forms.Label YourName;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.TextBox textBox1;
    }
}