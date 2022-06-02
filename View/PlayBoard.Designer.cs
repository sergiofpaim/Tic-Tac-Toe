namespace TicTacToe
{
    partial class PlayBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayBoard));
            this.b = new System.Windows.Forms.Button();
            this.gameName = new System.Windows.Forms.Label();
            this.button1x1 = new System.Windows.Forms.Button();
            this.button1x2 = new System.Windows.Forms.Button();
            this.button1x3 = new System.Windows.Forms.Button();
            this.button2x3 = new System.Windows.Forms.Button();
            this.button2x2 = new System.Windows.Forms.Button();
            this.button2x1 = new System.Windows.Forms.Button();
            this.button3x3 = new System.Windows.Forms.Button();
            this.button3x2 = new System.Windows.Forms.Button();
            this.button3x1 = new System.Windows.Forms.Button();
            this.restart = new System.Windows.Forms.Button();
            this.winner = new System.Windows.Forms.Label();
            this.about = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b
            // 
            this.b.Location = new System.Drawing.Point(0, 0);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(75, 23);
            this.b.TabIndex = 0;
            // 
            // gameName
            // 
            this.gameName.AutoSize = true;
            this.gameName.Font = new System.Drawing.Font("Segoe UI Emoji", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gameName.Location = new System.Drawing.Point(93, 18);
            this.gameName.Name = "gameName";
            this.gameName.Size = new System.Drawing.Size(159, 33);
            this.gameName.TabIndex = 0;
            this.gameName.Text = "TIC-TAC-TOE";
            // 
            // button1x1
            // 
            this.button1x1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1x1.ForeColor = System.Drawing.Color.Black;
            this.button1x1.Location = new System.Drawing.Point(48, 97);
            this.button1x1.Name = "button1x1";
            this.button1x1.Size = new System.Drawing.Size(80, 80);
            this.button1x1.TabIndex = 1;
            this.button1x1.Tag = "0,0";
            this.button1x1.UseVisualStyleBackColor = true;
            this.button1x1.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // button1x2
            // 
            this.button1x2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1x2.ForeColor = System.Drawing.Color.Black;
            this.button1x2.Location = new System.Drawing.Point(134, 97);
            this.button1x2.Name = "button1x2";
            this.button1x2.Size = new System.Drawing.Size(80, 80);
            this.button1x2.TabIndex = 2;
            this.button1x2.Tag = "0,1";
            this.button1x2.UseVisualStyleBackColor = true;
            this.button1x2.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // button1x3
            // 
            this.button1x3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1x3.ForeColor = System.Drawing.Color.Black;
            this.button1x3.Location = new System.Drawing.Point(220, 97);
            this.button1x3.Name = "button1x3";
            this.button1x3.Size = new System.Drawing.Size(80, 80);
            this.button1x3.TabIndex = 3;
            this.button1x3.Tag = "0,2";
            this.button1x3.UseVisualStyleBackColor = true;
            this.button1x3.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // button2x3
            // 
            this.button2x3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2x3.ForeColor = System.Drawing.Color.Black;
            this.button2x3.Location = new System.Drawing.Point(220, 183);
            this.button2x3.Name = "button2x3";
            this.button2x3.Size = new System.Drawing.Size(80, 80);
            this.button2x3.TabIndex = 6;
            this.button2x3.Tag = "1,2";
            this.button2x3.UseVisualStyleBackColor = true;
            this.button2x3.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // button2x2
            // 
            this.button2x2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2x2.ForeColor = System.Drawing.Color.Black;
            this.button2x2.Location = new System.Drawing.Point(134, 183);
            this.button2x2.Name = "button2x2";
            this.button2x2.Size = new System.Drawing.Size(80, 80);
            this.button2x2.TabIndex = 5;
            this.button2x2.Tag = "1,1";
            this.button2x2.UseVisualStyleBackColor = true;
            this.button2x2.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // button2x1
            // 
            this.button2x1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2x1.ForeColor = System.Drawing.Color.Black;
            this.button2x1.Location = new System.Drawing.Point(48, 183);
            this.button2x1.Name = "button2x1";
            this.button2x1.Size = new System.Drawing.Size(80, 80);
            this.button2x1.TabIndex = 4;
            this.button2x1.Tag = "1,0";
            this.button2x1.UseVisualStyleBackColor = true;
            this.button2x1.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // button3x3
            // 
            this.button3x3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3x3.ForeColor = System.Drawing.Color.Black;
            this.button3x3.Location = new System.Drawing.Point(220, 269);
            this.button3x3.Name = "button3x3";
            this.button3x3.Size = new System.Drawing.Size(80, 80);
            this.button3x3.TabIndex = 9;
            this.button3x3.Tag = "2,2";
            this.button3x3.UseVisualStyleBackColor = true;
            this.button3x3.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // button3x2
            // 
            this.button3x2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3x2.ForeColor = System.Drawing.Color.Black;
            this.button3x2.Location = new System.Drawing.Point(134, 269);
            this.button3x2.Name = "button3x2";
            this.button3x2.Size = new System.Drawing.Size(80, 80);
            this.button3x2.TabIndex = 8;
            this.button3x2.Tag = "2,1";
            this.button3x2.UseVisualStyleBackColor = true;
            this.button3x2.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // button3x1
            // 
            this.button3x1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3x1.ForeColor = System.Drawing.Color.Black;
            this.button3x1.Location = new System.Drawing.Point(48, 269);
            this.button3x1.Name = "button3x1";
            this.button3x1.Size = new System.Drawing.Size(80, 80);
            this.button3x1.TabIndex = 7;
            this.button3x1.Tag = "2,0";
            this.button3x1.UseVisualStyleBackColor = true;
            this.button3x1.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // restart
            // 
            this.restart.Location = new System.Drawing.Point(134, 362);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(80, 29);
            this.restart.TabIndex = 10;
            this.restart.Text = "Restart";
            this.restart.UseVisualStyleBackColor = true;
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // winner
            // 
            this.winner.AutoSize = true;
            this.winner.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.winner.Location = new System.Drawing.Point(137, 63);
            this.winner.Name = "winner";
            this.winner.Size = new System.Drawing.Size(0, 31);
            this.winner.TabIndex = 13;
            // 
            // about
            // 
            this.about.BackgroundImage = global::TicTacToe.Properties.Resources.about;
            this.about.Location = new System.Drawing.Point(315, 401);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(30, 30);
            this.about.TabIndex = 14;
            this.about.UseVisualStyleBackColor = true;
            this.about.Click += new System.EventHandler(this.About_Click);
            // 
            // PlayBoard
            // 
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(357, 443);
            this.Controls.Add(this.about);
            this.Controls.Add(this.winner);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.button3x3);
            this.Controls.Add(this.button3x2);
            this.Controls.Add(this.button3x1);
            this.Controls.Add(this.button2x3);
            this.Controls.Add(this.button2x2);
            this.Controls.Add(this.button2x1);
            this.Controls.Add(this.button1x3);
            this.Controls.Add(this.button1x2);
            this.Controls.Add(this.button1x1);
            this.Controls.Add(this.gameName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PlayBoard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button b;
        private Label gameName;
        private Button button1x1;
        private Button button1x2;
        private Button button1x3;
        private Button button2x3;
        private Button button2x2;
        private Button button2x1;
        private Button button3x3;
        private Button button3x2;
        private Button button3x1;
        private Button restart;
        private Label winner;
        private Button about;
    }
}