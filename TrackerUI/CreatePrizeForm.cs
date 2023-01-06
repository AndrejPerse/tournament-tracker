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
using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        private IPrizeRequester callingForm;

        public CreatePrizeForm(IPrizeRequester caller)
        {
            InitializeComponent();
            callingForm = caller;
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel prizeModel = new PrizeModel(
                    prizePlaceValue.Text,
                    prizeNameValue.Text,
                    prizeMoneyValue.Text,
                    prizeMaterialValue.Text);

                GlobalConfig.Connection.CreatePrize(prizeModel);

                callingForm.PrizeComplete(prizeModel);

                this.Close();
            }
            else
            {
                MessageBox.Show("Vnešeni podatki so napačni. Preveri in popravi.");
            }
        }

        private bool ValidateForm()
        {
            bool isValid = true;
            int prizePlace = 0;
            bool prizePlaceValidNumber = int.TryParse(prizePlaceValue.Text, out prizePlace);

            if (prizePlaceValidNumber == false)
            {
                isValid = false;
            }

            if (prizePlace < 1)
            {
                isValid = false;
            }

            if (prizeNameValue.Text.Length == 0)
            {
                isValid = false;
            }

            int prizeMoney = 0;
            bool prizeMoneyValidNumber = int.TryParse(prizeMoneyValue.Text, out prizeMoney);

            if (prizeMoneyValue.Text.Length == 0 && prizeMaterialValue.Text.Length == 0)
            {
                isValid = false;
            }
            else if (prizeMaterialValue.Text.Length == 0 && prizeMoneyValidNumber == false)
            {
                isValid = false;
            }
            else if (prizeMoneyValidNumber == true && prizeMoney <= 0)
            {
                isValid = false;
            }

            return isValid;
        }
    }
}
