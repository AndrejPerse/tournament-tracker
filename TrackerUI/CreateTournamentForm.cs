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
    public partial class CreateTournamentForm : Form, IPrizeRequester, IPlayerRequester
    {
        List<PlayerModel> availablePlayers = GlobalConfig.Connection.GetPlayer_All();
        List<PlayerModel> selectedPlayers = new List<PlayerModel>();
        List<PrizeModel> selectedPrizes = new List<PrizeModel>();

        public CreateTournamentForm()
        {
            InitializeComponent();
            InitializeLists();
        }

        private void InitializeLists()
        {
            selectPlayerComboBox.DataSource = null;
            selectPlayerComboBox.DataSource = availablePlayers;
            selectPlayerComboBox.DisplayMember = "FullName";

            tournamentPlayersListBox.DataSource = null;
            tournamentPlayersListBox.DataSource = selectedPlayers;
            tournamentPlayersListBox.DisplayMember = "FullName";

            prizeListBox.DataSource = null;
            prizeListBox.DataSource = selectedPrizes;
            prizeListBox.DisplayMember = "DisplayName";
        }

        private void addPlayerButton_Click(object sender, EventArgs e)
        {
            PlayerModel player = (PlayerModel)selectPlayerComboBox.SelectedItem;

            if (player != null)
            {
                availablePlayers.Remove(player);
                selectedPlayers.Add(player);

                InitializeLists();
            }
        }

        private void removePlayerButton_Click(object sender, EventArgs e)
        {
            PlayerModel player = (PlayerModel)tournamentPlayersListBox.SelectedItem;

            if (player != null)
            {
                selectedPlayers.Remove(player);
                availablePlayers.Add(player);

                InitializeLists();
            }
        }

        private void addNewPlayerButton_Click(object sender, EventArgs e)
        {
            CreatePlayerForm form = new CreatePlayerForm(this);
            form.Show();
        }

        public void PlayerComplete(PlayerModel model)
        {
            selectedPlayers.Add(model);
            InitializeLists();
        }

        private void addPrizeButton_Click(object sender, EventArgs e)
        {
            // Call the CreatePrizeForm
            CreatePrizeForm form = new CreatePrizeForm(this);
            form.Show();
        }

        // Get back from the form a PrizeModel
        public void PrizeComplete(PrizeModel model)
        {
            // Take the PrizeModel and put it into our list of selected prizes
            selectedPrizes.Add(model);
            InitializeLists();
        }

        private void removePrizeButton_Click(object sender, EventArgs e)
        {
            PrizeModel prize = (PrizeModel)prizeListBox.SelectedItem;

            if (prize != null)
            {
                selectedPrizes.Remove(prize);

                InitializeLists();
            }
        }

        private void createTournamentButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                TournamentModel tournamentModel = new TournamentModel(
                    tournamentNameValue.Text,
                    float.Parse(entryFeeValue.Text),
                    selectedPlayers,
                    selectedPrizes);

                // Create matches
                TournamentLogic.CreateRounds(tournamentModel);

                // Create Tournament Entry, Tournament Prize Entries, Tournament Player Entries
                GlobalConfig.Connection.CreateTournament(tournamentModel);

                //tournamentModel.AlertParticipantsNewRound();

                // Open Tournament Viewer of created Tournament
                TournamentViewerForm form = new TournamentViewerForm(tournamentModel);
                form.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Potrebno je izpolniti/popraviti manjkajoča polja.");
            }
        }

        private bool ValidateForm()
        {
            bool isValid = true;

            if (tournamentNameValue.Text.Length == 0)
            {
                isValid = false;
            }

            float entryFee = 0;
            bool entryFeeValidNumber = float.TryParse(entryFeeValue.Text, out entryFee);

            if (entryFeeValidNumber == false)
            {
                isValid = false;
            }

            return isValid;
        }
    }
}
