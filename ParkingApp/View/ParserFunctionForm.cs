using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingApp.View
{
    public partial class ParkingFunctionForm : Form
    {
        public ParkingFunctionForm(Controller controller, OpenFileDialog openFileDialog1,  Label StatusLabel)
        {
            this.DoubleBuffered = true;
            this.ControlBox = false;

            this._controller = controller;
            this._statusLabel = StatusLabel;
            this.openFileDialog = openFileDialog1;
            InitializeComponent();
        }



        private string _statusText = "Status: ";

        private Controller _controller;
        private OpenFileDialog openFileDialog;
        private Label _statusLabel;

        private void HandleEventSearch()
        {
            this.Invoke(new MethodInvoker(delegate () {
                this._statusLabel.Text = _statusText + "Searching...";
            }));

        }





        private void SearchButtonClick(object sender, EventArgs e)
        {
            

            HandleEventSearch();

            // get data some data I want from the JSON file
            List<Dictionary<string, string>> outputParseValue = _controller.Search(
                this.licenceTextBoxt.Text, 
                this.digitTextBox.Text,
                this.paymentDatePicker.Value);


            List<string> messages = new List<string>();
            int tempCounter = 0;
            int arr = outputParseValue.Count;

            if (arr == 0)
            {
                this._statusLabel.Text = _statusText + "Search returned no results!";
            }
            else {
                this._statusLabel.Text = _statusText + arr;

                foreach (Dictionary<string, string> pair in outputParseValue)
                {
                    messages.Add(pair["Message"]);
                    ListViewItem[] listViewItemsArray = new System.Windows.Forms.ListViewItem[arr];

                    HandleEventInsertToList(pair["LicenseplateID"], pair["PaymentID"], pair["PaymentAmount"],
                                listViewItemsArray,
                                tempCounter);
                    HandleEventEndSearch(listViewItemsArray);

                    tempCounter++;
                }

                this.recieptLabelOutput.Text = string.Join("\n", messages);
            }


        }

        private void HandleEventInsertToList(string v1, string v2, string v3, ListViewItem[] listViewItemsArray, int countItemsIntoList)
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
                             v1,
                             v2,
                             v3}, -1);
            listViewItemsArray[countItemsIntoList] = listViewItem1;
        }

        private void HandleEventEndSearch(ListViewItem[] listViewItemArray)
        {
            this.Invoke(new MethodInvoker(delegate () {
                this.parkingListView.Items.AddRange(listViewItemArray);
                listViewItemArray = new System.Windows.Forms.ListViewItem[0];

                this.clearButton.Enabled = true;
                //this._statusLabel.Text = _statusText + "Searched";
            }));

        }


        // known bug, lags when clearing a large list, over 500000 entries
        private void ClearList()
        {
            _controller.ClearModel();
            this.parkingListView.Items.Clear();
            this.clearButton.Enabled = false;
            this.searchButton.Enabled = false;

        }

        private void ClearClick(object sender, EventArgs e)
        {
            ClearList();
            this.recieptLabelOutput.Text = "";
            this._statusLabel.Text = _statusText + "Cleared";
    
        }

        private void parkingLogicPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loadFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _controller.LoadFile(openFileDialog.FileName);
            }
            this.searchButton.Enabled = true;
            this._statusLabel.Text = _statusText + "Loaded JSON";


        }

        private void parkingListViewSelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
