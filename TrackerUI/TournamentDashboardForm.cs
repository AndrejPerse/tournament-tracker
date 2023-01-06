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
    public partial class TournamentDashboardForm : Form
    {
        List<TournamentModel> tournaments = GlobalConfig.Connection.GetTournament_All();

        public TournamentDashboardForm()
        {
            InitializeComponent();
            InitializeLists();
        }

        private void InitializeLists()
        {
            tournamentComboBox.DataSource = tournaments;
            tournamentComboBox.DisplayMember = "TournamentName";
        }

        private void createTournamentButton_Click(object sender, EventArgs e)
        {
            CreateTournamentForm form = new CreateTournamentForm();
            form.Show();
        }

        private void loadTournamentButton_Click(object sender, EventArgs e)
        {
            TournamentModel tournament = (TournamentModel)tournamentComboBox.SelectedItem;

            if (tournament == null)
            {
                return;
            }

            TournamentViewerForm form = new TournamentViewerForm(tournament);
            form.Show();
        }
    }
}
