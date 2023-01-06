
namespace TrackerUI
{
    partial class CreatePlayerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePlayerForm));
            this.playerNameValue = new System.Windows.Forms.TextBox();
            this.playerNameLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.playerLastNameValue = new System.Windows.Forms.TextBox();
            this.playerLastNameLabel = new System.Windows.Forms.Label();
            this.playerEmailValue = new System.Windows.Forms.TextBox();
            this.playerEmailLabel = new System.Windows.Forms.Label();
            this.playerPhoneNumberValue = new System.Windows.Forms.TextBox();
            this.playerPhoneNumberLabel = new System.Windows.Forms.Label();
            this.createPlayerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playerNameValue
            // 
            this.playerNameValue.Location = new System.Drawing.Point(19, 102);
            this.playerNameValue.Name = "playerNameValue";
            this.playerNameValue.Size = new System.Drawing.Size(294, 29);
            this.playerNameValue.TabIndex = 13;
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.AutoSize = true;
            this.playerNameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerNameLabel.ForeColor = System.Drawing.Color.White;
            this.playerNameLabel.Location = new System.Drawing.Point(19, 62);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Size = new System.Drawing.Size(48, 30);
            this.playerNameLabel.TabIndex = 12;
            this.playerNameLabel.Text = "Ime";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.White;
            this.headerLabel.Location = new System.Drawing.Point(12, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(185, 37);
            this.headerLabel.TabIndex = 11;
            this.headerLabel.Text = "Ustvari igralca";
            // 
            // playerLastNameValue
            // 
            this.playerLastNameValue.Location = new System.Drawing.Point(19, 181);
            this.playerLastNameValue.Name = "playerLastNameValue";
            this.playerLastNameValue.Size = new System.Drawing.Size(294, 29);
            this.playerLastNameValue.TabIndex = 15;
            // 
            // playerLastNameLabel
            // 
            this.playerLastNameLabel.AutoSize = true;
            this.playerLastNameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerLastNameLabel.ForeColor = System.Drawing.Color.White;
            this.playerLastNameLabel.Location = new System.Drawing.Point(19, 141);
            this.playerLastNameLabel.Name = "playerLastNameLabel";
            this.playerLastNameLabel.Size = new System.Drawing.Size(81, 30);
            this.playerLastNameLabel.TabIndex = 14;
            this.playerLastNameLabel.Text = "Priimek";
            // 
            // playerEmailValue
            // 
            this.playerEmailValue.Location = new System.Drawing.Point(19, 260);
            this.playerEmailValue.Name = "playerEmailValue";
            this.playerEmailValue.Size = new System.Drawing.Size(294, 29);
            this.playerEmailValue.TabIndex = 17;
            // 
            // playerEmailLabel
            // 
            this.playerEmailLabel.AutoSize = true;
            this.playerEmailLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerEmailLabel.ForeColor = System.Drawing.Color.White;
            this.playerEmailLabel.Location = new System.Drawing.Point(19, 220);
            this.playerEmailLabel.Name = "playerEmailLabel";
            this.playerEmailLabel.Size = new System.Drawing.Size(71, 30);
            this.playerEmailLabel.TabIndex = 16;
            this.playerEmailLabel.Text = "E-mail";
            // 
            // playerPhoneNumberValue
            // 
            this.playerPhoneNumberValue.Location = new System.Drawing.Point(19, 339);
            this.playerPhoneNumberValue.Name = "playerPhoneNumberValue";
            this.playerPhoneNumberValue.Size = new System.Drawing.Size(294, 29);
            this.playerPhoneNumberValue.TabIndex = 19;
            // 
            // playerPhoneNumberLabel
            // 
            this.playerPhoneNumberLabel.AutoSize = true;
            this.playerPhoneNumberLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerPhoneNumberLabel.ForeColor = System.Drawing.Color.White;
            this.playerPhoneNumberLabel.Location = new System.Drawing.Point(19, 299);
            this.playerPhoneNumberLabel.Name = "playerPhoneNumberLabel";
            this.playerPhoneNumberLabel.Size = new System.Drawing.Size(184, 30);
            this.playerPhoneNumberLabel.TabIndex = 18;
            this.playerPhoneNumberLabel.Text = "Telefonska številka";
            // 
            // createPlayerButton
            // 
            this.createPlayerButton.BackColor = System.Drawing.Color.White;
            this.createPlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPlayerButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPlayerButton.Location = new System.Drawing.Point(93, 423);
            this.createPlayerButton.Name = "createPlayerButton";
            this.createPlayerButton.Size = new System.Drawing.Size(178, 47);
            this.createPlayerButton.TabIndex = 20;
            this.createPlayerButton.Text = "Ustvari igralca";
            this.createPlayerButton.UseVisualStyleBackColor = false;
            this.createPlayerButton.Click += new System.EventHandler(this.createPlayerButton_Click);
            // 
            // CreatePlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(364, 501);
            this.Controls.Add(this.createPlayerButton);
            this.Controls.Add(this.playerPhoneNumberValue);
            this.Controls.Add(this.playerPhoneNumberLabel);
            this.Controls.Add(this.playerEmailValue);
            this.Controls.Add(this.playerEmailLabel);
            this.Controls.Add(this.playerLastNameValue);
            this.Controls.Add(this.playerLastNameLabel);
            this.Controls.Add(this.playerNameValue);
            this.Controls.Add(this.playerNameLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CreatePlayerForm";
            this.Text = "Create Player";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox playerNameValue;
        private System.Windows.Forms.Label playerNameLabel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.TextBox playerLastNameValue;
        private System.Windows.Forms.Label playerLastNameLabel;
        private System.Windows.Forms.TextBox playerEmailValue;
        private System.Windows.Forms.Label playerEmailLabel;
        private System.Windows.Forms.TextBox playerPhoneNumberValue;
        private System.Windows.Forms.Label playerPhoneNumberLabel;
        private System.Windows.Forms.Button createPlayerButton;
    }
}