
namespace TrackerUI
{
    partial class TournamentViewerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentViewerForm));
            this.headerLabel = new System.Windows.Forms.Label();
            this.tournamentName = new System.Windows.Forms.Label();
            this.roundLabel = new System.Windows.Forms.Label();
            this.roundComboBox = new System.Windows.Forms.ComboBox();
            this.notPlayedOnlyCheckBox = new System.Windows.Forms.CheckBox();
            this.matchListBox = new System.Windows.Forms.ListBox();
            this.playerOneName = new System.Windows.Forms.Label();
            this.playerTwoName = new System.Windows.Forms.Label();
            this.playerOneScoreValue = new System.Windows.Forms.TextBox();
            this.playerTwoScoreValue = new System.Windows.Forms.TextBox();
            this.scoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.White;
            this.headerLabel.Location = new System.Drawing.Point(12, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(99, 37);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Turnir: ";
            // 
            // tournamentName
            // 
            this.tournamentName.AutoSize = true;
            this.tournamentName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentName.ForeColor = System.Drawing.Color.White;
            this.tournamentName.Location = new System.Drawing.Point(117, 9);
            this.tournamentName.Name = "tournamentName";
            this.tournamentName.Size = new System.Drawing.Size(184, 37);
            this.tournamentName.TabIndex = 1;
            this.tournamentName.Text = "<brez imena>";
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundLabel.ForeColor = System.Drawing.Color.White;
            this.roundLabel.Location = new System.Drawing.Point(14, 68);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(56, 30);
            this.roundLabel.TabIndex = 2;
            this.roundLabel.Text = "Krog";
            // 
            // roundComboBox
            // 
            this.roundComboBox.FormattingEnabled = true;
            this.roundComboBox.Location = new System.Drawing.Point(124, 72);
            this.roundComboBox.Name = "roundComboBox";
            this.roundComboBox.Size = new System.Drawing.Size(108, 29);
            this.roundComboBox.TabIndex = 3;
            this.roundComboBox.SelectedIndexChanged += new System.EventHandler(this.roundComboBox_SelectedIndexChanged);
            // 
            // notPlayedOnlyCheckBox
            // 
            this.notPlayedOnlyCheckBox.AutoSize = true;
            this.notPlayedOnlyCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notPlayedOnlyCheckBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notPlayedOnlyCheckBox.ForeColor = System.Drawing.Color.White;
            this.notPlayedOnlyCheckBox.Location = new System.Drawing.Point(19, 455);
            this.notPlayedOnlyCheckBox.Name = "notPlayedOnlyCheckBox";
            this.notPlayedOnlyCheckBox.Size = new System.Drawing.Size(184, 29);
            this.notPlayedOnlyCheckBox.TabIndex = 4;
            this.notPlayedOnlyCheckBox.Text = "Neodigrane tekme";
            this.notPlayedOnlyCheckBox.UseVisualStyleBackColor = true;
            this.notPlayedOnlyCheckBox.CheckedChanged += new System.EventHandler(this.notPlayedOnlyCheckBox_CheckedChanged);
            // 
            // matchListBox
            // 
            this.matchListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchListBox.FormattingEnabled = true;
            this.matchListBox.ItemHeight = 21;
            this.matchListBox.Location = new System.Drawing.Point(19, 153);
            this.matchListBox.Name = "matchListBox";
            this.matchListBox.Size = new System.Drawing.Size(266, 296);
            this.matchListBox.TabIndex = 5;
            this.matchListBox.SelectedIndexChanged += new System.EventHandler(this.matchListBox_SelectedIndexChanged);
            // 
            // playerOneName
            // 
            this.playerOneName.AutoSize = true;
            this.playerOneName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerOneName.ForeColor = System.Drawing.Color.White;
            this.playerOneName.Location = new System.Drawing.Point(328, 222);
            this.playerOneName.Name = "playerOneName";
            this.playerOneName.Size = new System.Drawing.Size(119, 30);
            this.playerOneName.TabIndex = 6;
            this.playerOneName.Text = "<igralec 1>";
            // 
            // playerTwoName
            // 
            this.playerTwoName.AutoSize = true;
            this.playerTwoName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerTwoName.ForeColor = System.Drawing.Color.White;
            this.playerTwoName.Location = new System.Drawing.Point(328, 271);
            this.playerTwoName.Name = "playerTwoName";
            this.playerTwoName.Size = new System.Drawing.Size(119, 30);
            this.playerTwoName.TabIndex = 7;
            this.playerTwoName.Text = "<igralec 2>";
            // 
            // playerOneScoreValue
            // 
            this.playerOneScoreValue.Location = new System.Drawing.Point(533, 223);
            this.playerOneScoreValue.Name = "playerOneScoreValue";
            this.playerOneScoreValue.Size = new System.Drawing.Size(35, 29);
            this.playerOneScoreValue.TabIndex = 8;
            // 
            // playerTwoScoreValue
            // 
            this.playerTwoScoreValue.Location = new System.Drawing.Point(533, 272);
            this.playerTwoScoreValue.Name = "playerTwoScoreValue";
            this.playerTwoScoreValue.Size = new System.Drawing.Size(35, 29);
            this.playerTwoScoreValue.TabIndex = 9;
            // 
            // scoreButton
            // 
            this.scoreButton.BackColor = System.Drawing.Color.White;
            this.scoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoreButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreButton.Location = new System.Drawing.Point(372, 322);
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Size = new System.Drawing.Size(158, 40);
            this.scoreButton.TabIndex = 10;
            this.scoreButton.Text = "Potrdi rezultat";
            this.scoreButton.UseVisualStyleBackColor = false;
            this.scoreButton.Click += new System.EventHandler(this.scoreButton_Click);
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(600, 548);
            this.Controls.Add(this.scoreButton);
            this.Controls.Add(this.playerTwoScoreValue);
            this.Controls.Add(this.playerOneScoreValue);
            this.Controls.Add(this.playerTwoName);
            this.Controls.Add(this.playerOneName);
            this.Controls.Add(this.matchListBox);
            this.Controls.Add(this.notPlayedOnlyCheckBox);
            this.Controls.Add(this.roundComboBox);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.tournamentName);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TournamentViewerForm";
            this.Text = "Tournament Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label tournamentName;
        private System.Windows.Forms.Label roundLabel;
        private System.Windows.Forms.ComboBox roundComboBox;
        private System.Windows.Forms.CheckBox notPlayedOnlyCheckBox;
        private System.Windows.Forms.ListBox matchListBox;
        private System.Windows.Forms.Label playerOneName;
        private System.Windows.Forms.Label playerTwoName;
        private System.Windows.Forms.TextBox playerOneScoreValue;
        private System.Windows.Forms.TextBox playerTwoScoreValue;
        private System.Windows.Forms.Button scoreButton;
    }
}

