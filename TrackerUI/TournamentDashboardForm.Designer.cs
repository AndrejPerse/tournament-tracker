
namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentDashboardForm));
            this.tournamentComboBox = new System.Windows.Forms.ComboBox();
            this.tournamentListLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.loadTournamentButton = new System.Windows.Forms.Button();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tournamentComboBox
            // 
            this.tournamentComboBox.FormattingEnabled = true;
            this.tournamentComboBox.Location = new System.Drawing.Point(59, 107);
            this.tournamentComboBox.Name = "tournamentComboBox";
            this.tournamentComboBox.Size = new System.Drawing.Size(332, 29);
            this.tournamentComboBox.TabIndex = 6;
            // 
            // tournamentListLabel
            // 
            this.tournamentListLabel.AutoSize = true;
            this.tournamentListLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentListLabel.ForeColor = System.Drawing.Color.White;
            this.tournamentListLabel.Location = new System.Drawing.Point(141, 74);
            this.tournamentListLabel.Name = "tournamentListLabel";
            this.tournamentListLabel.Size = new System.Drawing.Size(168, 30);
            this.tournamentListLabel.TabIndex = 5;
            this.tournamentListLabel.Text = "Seznam turnirjev";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.White;
            this.headerLabel.Location = new System.Drawing.Point(121, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(209, 37);
            this.headerLabel.TabIndex = 4;
            this.headerLabel.Text = "Nadzor turnirjev";
            // 
            // loadTournamentButton
            // 
            this.loadTournamentButton.BackColor = System.Drawing.Color.White;
            this.loadTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadTournamentButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadTournamentButton.Location = new System.Drawing.Point(146, 163);
            this.loadTournamentButton.Name = "loadTournamentButton";
            this.loadTournamentButton.Size = new System.Drawing.Size(160, 29);
            this.loadTournamentButton.TabIndex = 17;
            this.loadTournamentButton.Text = "Odpri turnir";
            this.loadTournamentButton.UseVisualStyleBackColor = false;
            this.loadTournamentButton.Click += new System.EventHandler(this.loadTournamentButton_Click);
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.BackColor = System.Drawing.Color.White;
            this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTournamentButton.Location = new System.Drawing.Point(146, 274);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(160, 29);
            this.createTournamentButton.TabIndex = 18;
            this.createTournamentButton.Text = "Ustvari turnir";
            this.createTournamentButton.UseVisualStyleBackColor = false;
            this.createTournamentButton.Click += new System.EventHandler(this.createTournamentButton_Click);
            // 
            // TournamentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(450, 351);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.loadTournamentButton);
            this.Controls.Add(this.tournamentComboBox);
            this.Controls.Add(this.tournamentListLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TournamentDashboardForm";
            this.Text = "TournamentDashboardForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox tournamentComboBox;
        private System.Windows.Forms.Label tournamentListLabel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button loadTournamentButton;
        private System.Windows.Forms.Button createTournamentButton;
    }
}