namespace New_Pong
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
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.gamefield = new System.Windows.Forms.PictureBox();
            this.p2score = new System.Windows.Forms.Label();
            this.p1score = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gamefield)).BeginInit();
            this.SuspendLayout();
            // 
            // gamefield
            // 
            this.gamefield.Location = new System.Drawing.Point(2, 3);
            this.gamefield.Name = "gamefield";
            this.gamefield.Size = new System.Drawing.Size(1220, 686);
            this.gamefield.TabIndex = 0;
            this.gamefield.TabStop = false;
            this.gamefield.Paint += new System.Windows.Forms.PaintEventHandler(this.gamefield_Paint);
            // 
            // p2score
            // 
            this.p2score.AutoSize = true;
            this.p2score.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.p2score.Location = new System.Drawing.Point(12, 23);
            this.p2score.Name = "p2score";
            this.p2score.Size = new System.Drawing.Size(22, 25);
            this.p2score.TabIndex = 2;
            this.p2score.Text = "0";
            // 
            // p1score
            // 
            this.p1score.AutoSize = true;
            this.p1score.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.p1score.Location = new System.Drawing.Point(12, 633);
            this.p1score.Name = "p1score";
            this.p1score.Size = new System.Drawing.Size(22, 25);
            this.p1score.TabIndex = 3;
            this.p1score.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1222, 688);
            this.Controls.Add(this.p1score);
            this.Controls.Add(this.p2score);
            this.Controls.Add(this.gamefield);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1240, 735);
            this.MinimumSize = new System.Drawing.Size(1240, 735);
            this.Name = "Form1";
            this.Text = "Pong";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.gamefield)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox gamefield;
        private System.Windows.Forms.Label p2score;
        private System.Windows.Forms.Label p1score;
    }
}

