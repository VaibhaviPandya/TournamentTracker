using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }
        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel(
                    placeNameValue.Text,
                    placeNumberValue.Text,
                    prizeAmountValue.Text,
                    prizePercentageValue.Text);

                foreach (IDataConnection db in GlobalConfig.Connections)
                {
                    db.CreatePrize(model);
                }
                placeNameValue.Text="",
                placeNumberValue.Text="",
                prizeAmountValue.Text="0",
                prizePercentageValu.Text="0";
            }
            else
            {
                Messagebox.Show("invalid information");
            }
               // model.PlaceName = placeNameValue.Text;
            }
        }
        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber=0;
            bool placeNumberValidNumber = int.TryParse(placeNameValue.Text, out placeNumber);
            if (placeNumberValidNumber == false)
            {
                output = false;
            }
            if(placeNumber < 1)
            {
                output=false;
            }
            if (placeNumberValue.Text.Length==0)
            {
                output = false;
            }
            decimal priceAmount = 0;
            int pricePercentage = 0;

            bool priceAmountValid = decimal.TryParse(priceAmountValue.Text, out priceAmount);
            bool pricePercentageValid = int.TryParse(pricePercentageValue.Text, out pricePercentage);
              
            if(priceAmountValid== false || pricePercentageValid == false)
            {
                output =false;
            }
            if (priceAmount<= 0 && pricePercentage<= 0)
            {
                output = false;
            }
            if (pricePercentage < 0 || pricePercentage >100)
            {
                output = false;
            }
            
            return output;

        }
    }
}
