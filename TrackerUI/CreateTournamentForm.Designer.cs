
namespace TrackerUI
{
    partial class CreateTournamentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTournamentForm));
            this.headerLabel = new System.Windows.Forms.Label();
            this.tournamentNameValue = new System.Windows.Forms.TextBox();
            this.tournamentNameLabel = new System.Windows.Forms.Label();
            this.entryFeeValue = new System.Windows.Forms.TextBox();
            this.entryFeeLabel = new System.Windows.Forms.Label();
            this.euroLabel = new System.Windows.Forms.Label();
            this.selectPlayerComboBox = new System.Windows.Forms.ComboBox();
            this.addPlayerButton = new System.Windows.Forms.Button();
            this.addNewPlayerButton = new System.Windows.Forms.Button();
            this.addPrizeButton = new System.Windows.Forms.Button();
            this.tournamentPlayersLabel = new System.Windows.Forms.Label();
            this.tournamentPlayersListBox = new System.Windows.Forms.ListBox();
            this.removePlayerButton = new System.Windows.Forms.Button();
            this.removePrizeButton = new System.Windows.Forms.Button();
            this.prizeListBox = new System.Windows.Forms.ListBox();
            this.prizeLabel = new System.Windows.Forms.Label();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.White;
            this.headerLabel.Location = new System.Drawing.Point(12, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(170, 37);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Ustvari turnir";
            // 
            // tournamentNameValue
            // 
            this.tournamentNameValue.Location = new System.Drawing.Point(19, 107);
            this.tournamentNameValue.Name = "tournamentNameValue";
            this.tournamentNameValue.Size = new System.Drawing.Size(335, 29);
            this.tournamentNameValue.TabIndex = 10;
            // 
            // tournamentNameLabel
            // 
            this.tournamentNameLabel.AutoSize = true;
            this.tournamentNameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentNameLabel.ForeColor = System.Drawing.Color.White;
            this.tournamentNameLabel.Location = new System.Drawing.Point(14, 74);
            this.tournamentNameLabel.Name = "tournamentNameLabel";
            this.tournamentNameLabel.Size = new System.Drawing.Size(120, 30);
            this.tournamentNameLabel.TabIndex = 9;
            this.tournamentNameLabel.Text = "Ime turnirja";
            // 
            // entryFeeValue
            // 
            this.entryFeeValue.Location = new System.Drawing.Point(130, 182);
            this.entryFeeValue.Name = "entryFeeValue";
            this.entryFeeValue.Size = new System.Drawing.Size(52, 29);
            this.entryFeeValue.TabIndex = 12;
            this.entryFeeValue.Text = "0";
            // 
            // entryFeeLabel
            // 
            this.entryFeeLabel.AutoSize = true;
            this.entryFeeLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryFeeLabel.ForeColor = System.Drawing.Color.White;
            this.entryFeeLabel.Location = new System.Drawing.Point(14, 178);
            this.entryFeeLabel.Name = "entryFeeLabel";
            this.entryFeeLabel.Size = new System.Drawing.Size(110, 30);
            this.entryFeeLabel.TabIndex = 11;
            this.entryFeeLabel.Text = "Vstopnina:";
            // 
            // euroLabel
            // 
            this.euroLabel.AutoSize = true;
            this.euroLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.euroLabel.ForeColor = System.Drawing.Color.White;
            this.euroLabel.Location = new System.Drawing.Point(188, 182);
            this.euroLabel.Name = "euroLabel";
            this.euroLabel.Size = new System.Drawing.Size(24, 30);
            this.euroLabel.TabIndex = 13;
            this.euroLabel.Text = "€";
            // 
            // selectPlayerComboBox
            // 
            this.selectPlayerComboBox.FormattingEnabled = true;
            this.selectPlayerComboBox.Location = new System.Drawing.Point(431, 409);
            this.selectPlayerComboBox.Name = "selectPlayerComboBox";
            this.selectPlayerComboBox.Size = new System.Drawing.Size(252, 29);
            this.selectPlayerComboBox.TabIndex = 14;
            // 
            // addPlayerButton
            // 
            this.addPlayerButton.BackColor = System.Drawing.Color.White;
            this.addPlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPlayerButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPlayerButton.Location = new System.Drawing.Point(689, 409);
            this.addPlayerButton.Name = "addPlayerButton";
            this.addPlayerButton.Size = new System.Drawing.Size(77, 29);
            this.addPlayerButton.TabIndex = 15;
            this.addPlayerButton.Text = "Dodaj";
            this.addPlayerButton.UseVisualStyleBackColor = false;
            this.addPlayerButton.Click += new System.EventHandler(this.addPlayerButton_Click);
            // 
            // addNewPlayerButton
            // 
            this.addNewPlayerButton.BackColor = System.Drawing.Color.White;
            this.addNewPlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewPlayerButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewPlayerButton.Location = new System.Drawing.Point(689, 444);
            this.addNewPlayerButton.Name = "addNewPlayerButton";
            this.addNewPlayerButton.Size = new System.Drawing.Size(160, 29);
            this.addNewPlayerButton.TabIndex = 16;
            this.addNewPlayerButton.Text = "Dodaj novega igralca";
            this.addNewPlayerButton.UseVisualStyleBackColor = false;
            this.addNewPlayerButton.Click += new System.EventHandler(this.addNewPlayerButton_Click);
            // 
            // addPrizeButton
            // 
            this.addPrizeButton.BackColor = System.Drawing.Color.White;
            this.addPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPrizeButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPrizeButton.Location = new System.Drawing.Point(19, 409);
            this.addPrizeButton.Name = "addPrizeButton";
            this.addPrizeButton.Size = new System.Drawing.Size(163, 29);
            this.addPrizeButton.TabIndex = 17;
            this.addPrizeButton.Text = "Dodaj nagrado";
            this.addPrizeButton.UseVisualStyleBackColor = false;
            this.addPrizeButton.Click += new System.EventHandler(this.addPrizeButton_Click);
            // 
            // tournamentPlayersLabel
            // 
            this.tournamentPlayersLabel.AutoSize = true;
            this.tournamentPlayersLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentPlayersLabel.ForeColor = System.Drawing.Color.White;
            this.tournamentPlayersLabel.Location = new System.Drawing.Point(426, 74);
            this.tournamentPlayersLabel.Name = "tournamentPlayersLabel";
            this.tournamentPlayersLabel.Size = new System.Drawing.Size(69, 30);
            this.tournamentPlayersLabel.TabIndex = 18;
            this.tournamentPlayersLabel.Text = "Igralci";
            // 
            // tournamentPlayersListBox
            // 
            this.tournamentPlayersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tournamentPlayersListBox.FormattingEnabled = true;
            this.tournamentPlayersListBox.ItemHeight = 21;
            this.tournamentPlayersListBox.Location = new System.Drawing.Point(431, 107);
            this.tournamentPlayersListBox.Name = "tournamentPlayersListBox";
            this.tournamentPlayersListBox.Size = new System.Drawing.Size(335, 296);
            this.tournamentPlayersListBox.TabIndex = 19;
            // 
            // removePlayerButton
            // 
            this.removePlayerButton.BackColor = System.Drawing.Color.White;
            this.removePlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removePlayerButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removePlayerButton.Location = new System.Drawing.Point(772, 107);
            this.removePlayerButton.Name = "removePlayerButton";
            this.removePlayerButton.Size = new System.Drawing.Size(77, 55);
            this.removePlayerButton.TabIndex = 20;
            this.removePlayerButton.Text = "Odstrani";
            this.removePlayerButton.UseVisualStyleBackColor = false;
            this.removePlayerButton.Click += new System.EventHandler(this.removePlayerButton_Click);
            // 
            // removePrizeButton
            // 
            this.removePrizeButton.BackColor = System.Drawing.Color.White;
            this.removePrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removePrizeButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removePrizeButton.Location = new System.Drawing.Point(193, 409);
            this.removePrizeButton.Name = "removePrizeButton";
            this.removePrizeButton.Size = new System.Drawing.Size(161, 29);
            this.removePrizeButton.TabIndex = 23;
            this.removePrizeButton.Text = "Odstrani";
            this.removePrizeButton.UseVisualStyleBackColor = false;
            this.removePrizeButton.Click += new System.EventHandler(this.removePrizeButton_Click);
            // 
            // prizeListBox
            // 
            this.prizeListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prizeListBox.FormattingEnabled = true;
            this.prizeListBox.ItemHeight = 21;
            this.prizeListBox.Location = new System.Drawing.Point(19, 292);
            this.prizeListBox.Name = "prizeListBox";
            this.prizeListBox.Size = new System.Drawing.Size(335, 107);
            this.prizeListBox.TabIndex = 22;
            // 
            // prizeLabel
            // 
            this.prizeLabel.AutoSize = true;
            this.prizeLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizeLabel.ForeColor = System.Drawing.Color.White;
            this.prizeLabel.Location = new System.Drawing.Point(14, 259);
            this.prizeLabel.Name = "prizeLabel";
            this.prizeLabel.Size = new System.Drawing.Size(93, 30);
            this.prizeLabel.TabIndex = 21;
            this.prizeLabel.Text = "Nagrade";
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.BackColor = System.Drawing.Color.White;
            this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTournamentButton.Location = new System.Drawing.Point(362, 500);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(174, 50);
            this.createTournamentButton.TabIndex = 24;
            this.createTournamentButton.Text = "Ustvari turnir";
            this.createTournamentButton.UseVisualStyleBackColor = false;
            this.createTournamentButton.Click += new System.EventHandler(this.createTournamentButton_Click);
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(899, 576);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.removePrizeButton);
            this.Controls.Add(this.prizeListBox);
            this.Controls.Add(this.prizeLabel);
            this.Controls.Add(this.removePlayerButton);
            this.Controls.Add(this.tournamentPlayersListBox);
            this.Controls.Add(this.tournamentPlayersLabel);
            this.Controls.Add(this.addPrizeButton);
            this.Controls.Add(this.addNewPlayerButton);
            this.Controls.Add(this.addPlayerButton);
            this.Controls.Add(this.selectPlayerComboBox);
            this.Controls.Add(this.euroLabel);
            this.Controls.Add(this.entryFeeValue);
            this.Controls.Add(this.entryFeeLabel);
            this.Controls.Add(this.tournamentNameValue);
            this.Controls.Add(this.tournamentNameLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CreateTournamentForm";
            this.Text = "Create Tournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.TextBox tournamentNameValue;
        private System.Windows.Forms.Label tournamentNameLabel;
        private System.Windows.Forms.TextBox entryFeeValue;
        private System.Windows.Forms.Label entryFeeLabel;
        private System.Windows.Forms.Label euroLabel;
        private System.Windows.Forms.ComboBox selectPlayerComboBox;
        private System.Windows.Forms.Button addPlayerButton;
        private System.Windows.Forms.Button addNewPlayerButton;
        private System.Windows.Forms.Button addPrizeButton;
        private System.Windows.Forms.Label tournamentPlayersLabel;
        private System.Windows.Forms.ListBox tournamentPlayersListBox;
        private System.Windows.Forms.Button removePlayerButton;
        private System.Windows.Forms.Button removePrizeButton;
        private System.Windows.Forms.ListBox prizeListBox;
        private System.Windows.Forms.Label prizeLabel;
        private System.Windows.Forms.Button createTournamentButton;
    }
}