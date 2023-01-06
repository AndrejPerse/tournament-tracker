using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class TournamentViewerForm : Form
    {
        private TournamentModel tournament;
        BindingList<int> rounds = new BindingList<int>();
        BindingList<MatchModel> displayedMatches = new BindingList<MatchModel>();

        public TournamentViewerForm(TournamentModel tournamentModel)
        {
            InitializeComponent();

            tournament = tournamentModel;

            //TournamentLogic.UpdateTournamentResults(tournament);

            InitializeLists();

            LoadFormData();

            LoadRounds();
        }

        private void LoadFormData()
        {
            tournamentName.Text = tournament.TournamentName;
        }

        private void InitializeLists()
        {
            roundComboBox.DataSource = rounds;

            matchListBox.DataSource = displayedMatches;
            matchListBox.DisplayMember = "DisplayName";
        }

        private void LoadRounds()
        {
            rounds.Clear();

            int currentRound = 1;
            rounds.Add(currentRound);

            foreach (List<MatchModel> matches in tournament.Rounds)
            {
                if (matches.First().MatchRound > currentRound)
                {
                    currentRound = matches.First().MatchRound;
                    rounds.Add(currentRound);
                }
            }

            LoadMatches(1);
        }

        private void roundComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatches((int)roundComboBox.SelectedItem);
        }

        private void LoadMatches(int round)
        {
            // selectedIndexChanged kept firing, so this is for stopping it
            this.matchListBox.SelectedIndexChanged -= matchListBox_SelectedIndexChanged;

            foreach (List<MatchModel> matches in tournament.Rounds)
            {
                if (matches.First().MatchRound == round)
                {
                    displayedMatches.Clear();
                    foreach (MatchModel match in matches)
                    {
                        if (match.Winner == null || !notPlayedOnlyCheckBox.Checked)
                        {
                            displayedMatches.Add(match);
                        }
                    }
                }
            }

            // enabling it back
            this.matchListBox.SelectedIndexChanged += matchListBox_SelectedIndexChanged;
            
            if (displayedMatches.Count > 0)
            {
                LoadMatch(displayedMatches.First());
            }

            DisplayMatchInfo();
        }

        private void DisplayMatchInfo()
        {
            bool isVisible = (displayedMatches.Count > 0);

            playerOneName.Visible = isVisible;
            playerOneScoreValue.Visible = isVisible;
            playerTwoName.Visible = isVisible;
            playerTwoScoreValue.Visible = isVisible;
            scoreButton.Visible = isVisible;
        }

        private void LoadMatch(MatchModel match)
        {
            for (int i = 0; i < match.Entries.Count; i++)
            {
                if (i == 0)
                {
                    if (match.Entries[0].PlayerCompeting != null)
                    {
                        playerOneName.Text = match.Entries[0].PlayerCompeting.FullName;
                        playerOneScoreValue.Text = match.Entries[0].Score.ToString();

                        playerTwoName.Text = "BYE";
                        playerTwoScoreValue.Text = "";
                    }
                    else
                    {
                        playerOneName.Text = "To Be Determined";
                        playerOneScoreValue.Text = "";
                    }
                }
                
                if (i == 1)
                {
                    if (match.Entries[1].PlayerCompeting != null)
                    {
                        playerTwoName.Text = match.Entries[1].PlayerCompeting.FullName;
                        playerTwoScoreValue.Text = match.Entries[1].Score.ToString();
                    }
                    else
                    {
                        playerTwoName.Text = "To Be Determined";
                        playerTwoScoreValue.Text = "";
                    }
                }
            }
        }

        private void matchListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatch((MatchModel)matchListBox.SelectedItem);
        }

        private void notPlayedOnlyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            LoadMatches((int)roundComboBox.SelectedItem);
        }

        private bool ValidateForm()
        {
            bool isValid = true;

            bool scoreOneValidNumber = int.TryParse(playerOneScoreValue.Text, out int playerOneScore);
            bool scoreTwoValidNumber = int.TryParse(playerTwoScoreValue.Text, out int playerTwoScore);

            if (!scoreOneValidNumber || !scoreTwoValidNumber)
            {
                isValid = false;
            }

            if (playerOneScore == 0 && playerTwoScore == 0)
            {
                isValid = false;
            }

            if (playerOneScore == playerTwoScore)
            {
                isValid = false;
            }

            return isValid;
        }

        private void scoreButton_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                MessageBox.Show("Vnesi pravilne podatke.");
                return;
            }

            MatchModel match = (MatchModel)matchListBox.SelectedItem;
            int playerOneScore = 0;
            int playerTwoScore = 0;

            for (int i = 0; i < match.Entries.Count; i++)
            {
                if (i == 0)
                {
                    if (match.Entries[0].PlayerCompeting != null)
                    {
                        bool scoreValidNumber = int.TryParse(playerOneScoreValue.Text, out playerOneScore);

                        if (scoreValidNumber)
                        {
                            match.Entries[0].Score = playerOneScore;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Rezultat za prvega igralca ni veljaven.");
                        return;
                    }
                }

                if (i == 1)
                {
                    if (match.Entries[1].PlayerCompeting != null)
                    {
                        bool scoreValidNumber = int.TryParse(playerTwoScoreValue.Text, out playerTwoScore);

                        if (scoreValidNumber)
                        {
                            match.Entries[1].Score = playerTwoScore;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Rezultat za drugega igralca ni veljaven.");
                        return;
                    }
                }
            }

            try
            {
                TournamentLogic.UpdateTournamentResults(tournament);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Napaka: { ex.Message}");
                return;
            }

            LoadMatches((int)roundComboBox.SelectedItem);
        }
    }
}