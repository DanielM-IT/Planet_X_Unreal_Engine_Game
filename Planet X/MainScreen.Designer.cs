namespace Planet_X
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.btnClose = new System.Windows.Forms.Button();
            this.lblGameLobby = new System.Windows.Forms.Label();
            this.btnCreateGame = new System.Windows.Forms.Button();
            this.btnJoinGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Maroon;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Location = new System.Drawing.Point(575, 11);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(22, 20);
            this.btnClose.TabIndex = 29;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // lblGameLobby
            // 
            this.lblGameLobby.AutoSize = true;
            this.lblGameLobby.BackColor = System.Drawing.Color.Transparent;
            this.lblGameLobby.Font = new System.Drawing.Font("Rockwell Extra Bold", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblGameLobby.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblGameLobby.Location = new System.Drawing.Point(75, 66);
            this.lblGameLobby.Name = "lblGameLobby";
            this.lblGameLobby.Size = new System.Drawing.Size(174, 32);
            this.lblGameLobby.TabIndex = 28;
            this.lblGameLobby.Text = "PLANET X";
            // 
            // btnCreateGame
            // 
            this.btnCreateGame.BackColor = System.Drawing.Color.DimGray;
            this.btnCreateGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateGame.ForeColor = System.Drawing.Color.Black;
            this.btnCreateGame.Location = new System.Drawing.Point(91, 225);
            this.btnCreateGame.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateGame.Name = "btnCreateGame";
            this.btnCreateGame.Size = new System.Drawing.Size(139, 31);
            this.btnCreateGame.TabIndex = 27;
            this.btnCreateGame.Text = "Create New";
            this.btnCreateGame.UseVisualStyleBackColor = false;
            // 
            // btnJoinGame
            // 
            this.btnJoinGame.BackColor = System.Drawing.Color.DimGray;
            this.btnJoinGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnJoinGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJoinGame.ForeColor = System.Drawing.Color.Black;
            this.btnJoinGame.Location = new System.Drawing.Point(91, 167);
            this.btnJoinGame.Margin = new System.Windows.Forms.Padding(2);
            this.btnJoinGame.Name = "btnJoinGame";
            this.btnJoinGame.Size = new System.Drawing.Size(139, 31);
            this.btnJoinGame.TabIndex = 26;
            this.btnJoinGame.Text = "Login";
            this.btnJoinGame.UseVisualStyleBackColor = false;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(610, 374);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblGameLobby);
            this.Controls.Add(this.btnCreateGame);
            this.Controls.Add(this.btnJoinGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Planet X";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblGameLobby;
        private System.Windows.Forms.Button btnCreateGame;
        private System.Windows.Forms.Button btnJoinGame;
    }
}

