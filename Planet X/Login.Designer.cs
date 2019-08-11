namespace Planet_X
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btnCreateGame = new System.Windows.Forms.Button();
            this.btnJoinGame = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.lblIncorrectDetails = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblLudo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreateGame
            // 
            this.btnCreateGame.BackColor = System.Drawing.Color.DimGray;
            this.btnCreateGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateGame.ForeColor = System.Drawing.Color.Black;
            this.btnCreateGame.Location = new System.Drawing.Point(503, 339);
            this.btnCreateGame.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateGame.Name = "btnCreateGame";
            this.btnCreateGame.Size = new System.Drawing.Size(88, 23);
            this.btnCreateGame.TabIndex = 37;
            this.btnCreateGame.Text = "Return";
            this.btnCreateGame.UseVisualStyleBackColor = false;
            // 
            // btnJoinGame
            // 
            this.btnJoinGame.BackColor = System.Drawing.Color.DimGray;
            this.btnJoinGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnJoinGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJoinGame.ForeColor = System.Drawing.Color.Black;
            this.btnJoinGame.Location = new System.Drawing.Point(101, 268);
            this.btnJoinGame.Margin = new System.Windows.Forms.Padding(2);
            this.btnJoinGame.Name = "btnJoinGame";
            this.btnJoinGame.Size = new System.Drawing.Size(97, 25);
            this.btnJoinGame.TabIndex = 36;
            this.btnJoinGame.Text = "Login";
            this.btnJoinGame.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Maroon;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Location = new System.Drawing.Point(569, 11);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(22, 20);
            this.btnClose.TabIndex = 35;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Location = new System.Drawing.Point(76, 194);
            this.txtUserPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.PasswordChar = '*';
            this.txtUserPassword.Size = new System.Drawing.Size(172, 20);
            this.txtUserPassword.TabIndex = 34;
            // 
            // lblIncorrectDetails
            // 
            this.lblIncorrectDetails.AutoSize = true;
            this.lblIncorrectDetails.BackColor = System.Drawing.Color.Transparent;
            this.lblIncorrectDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncorrectDetails.ForeColor = System.Drawing.Color.Gold;
            this.lblIncorrectDetails.Location = new System.Drawing.Point(73, 223);
            this.lblIncorrectDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIncorrectDetails.Name = "lblIncorrectDetails";
            this.lblIncorrectDetails.Size = new System.Drawing.Size(175, 13);
            this.lblIncorrectDetails.TabIndex = 33;
            this.lblIncorrectDetails.Text = "User name or password is incorrect.";
            this.lblIncorrectDetails.Visible = false;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Red;
            this.lblPassword.Location = new System.Drawing.Point(73, 175);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(82, 17);
            this.lblPassword.TabIndex = 32;
            this.lblPassword.Text = "Password:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.Red;
            this.lblUserName.Location = new System.Drawing.Point(73, 126);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(93, 17);
            this.lblUserName.TabIndex = 31;
            this.lblUserName.Text = "User Name:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(76, 145);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(172, 20);
            this.txtUserName.TabIndex = 30;
            // 
            // lblLudo
            // 
            this.lblLudo.AutoSize = true;
            this.lblLudo.BackColor = System.Drawing.Color.Transparent;
            this.lblLudo.Font = new System.Drawing.Font("Rockwell Extra Bold", 22F, System.Drawing.FontStyle.Bold);
            this.lblLudo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblLudo.Location = new System.Drawing.Point(95, 44);
            this.lblLudo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLudo.Name = "lblLudo";
            this.lblLudo.Size = new System.Drawing.Size(119, 35);
            this.lblLudo.TabIndex = 29;
            this.lblLudo.Text = "Login";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(607, 373);
            this.Controls.Add(this.btnCreateGame);
            this.Controls.Add(this.btnJoinGame);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtUserPassword);
            this.Controls.Add(this.lblIncorrectDetails);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblLudo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateGame;
        private System.Windows.Forms.Button btnJoinGame;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtUserPassword;
        private System.Windows.Forms.Label lblIncorrectDetails;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblLudo;
    }
}