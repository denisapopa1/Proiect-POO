namespace memoryGame
{
    partial class FirstForm
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
            this.btnSart = new System.Windows.Forms.Button();
            this.Titlu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSart
            // 
            this.btnSart.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnSart.Font = new System.Drawing.Font("Bodoni MT Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSart.ForeColor = System.Drawing.Color.Navy;
            this.btnSart.Location = new System.Drawing.Point(334, 340);
            this.btnSart.Name = "btnSart";
            this.btnSart.Size = new System.Drawing.Size(209, 48);
            this.btnSart.TabIndex = 0;
            this.btnSart.Text = "START";
            this.btnSart.UseVisualStyleBackColor = false;
            this.btnSart.Click += new System.EventHandler(this.btnSart_Click);
            // 
            // Titlu
            // 
            this.Titlu.AutoSize = true;
            this.Titlu.BackColor = System.Drawing.Color.White;
            this.Titlu.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Titlu.Location = new System.Drawing.Point(189, 95);
            this.Titlu.Name = "Titlu";
            this.Titlu.Size = new System.Drawing.Size(500, 79);
            this.Titlu.TabIndex = 1;
            this.Titlu.Text = "MEMORY GAME";
            // 
            // FirstForm
            // 
            this.AcceptButton = this.btnSart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::memoryGame.Properties.Resources.fundal1;
            this.ClientSize = new System.Drawing.Size(867, 503);
            this.Controls.Add(this.Titlu);
            this.Controls.Add(this.btnSart);
            this.Name = "FirstForm";
            this.Text = "StartPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FirstForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSart;
        private System.Windows.Forms.Label Titlu;
    }
}

