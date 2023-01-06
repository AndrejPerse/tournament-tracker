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
    public partial class CreatePlayerForm : Form
    {
        private IPlayerRequester callingForm;

        public CreatePlayerForm(IPlayerRequester caller)
        {
            InitializeComponent();
            callingForm = caller;
        }

        private void createPlayerButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PlayerModel playerModel = new PlayerModel(
                    playerNameValue.Text,
                    playerLastNameValue.Text,
                    playerEmailValue.Text,
                    playerPhoneNumberValue.Text);

                GlobalConfig.Connection.CreatePlayer(playerModel);

                callingForm.PlayerComplete(playerModel);

                this.Close();
            }
            else
            {
                MessageBox.Show("Potrebno je izpolniti manjkajoča polja.");
            }
        }

        private bool ValidateForm()
        {
            bool isValid = true;

            if (playerNameValue.Text.Length == 0)
            {
                isValid = false;
            }

            if (playerLastNameValue.Text.Length == 0)
            {
                isValid = false;
            }

            if (playerEmailValue.Text.Length == 0)
            {
                isValid = false;
            }

            return isValid;
        }
    }
}
