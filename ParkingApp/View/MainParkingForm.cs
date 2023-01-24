using System.Windows.Forms;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using ParkingApp.View;
using System.Reflection;

namespace ParkingApp
{
    public partial class MainParkingForm : Form
    {
        //  A single entry point class for client/view/frontend entities to have access to
        //  Business Service methods.

        private ParkingFunctionForm _parserLogicForm;
        private AboutForm _aboutForm;


        private Controller _controller;
  
        public MainParkingForm(Controller controller)
        {

            InitializeComponent();
            this._controller = controller;
            this.DoubleBuffered= true;
            this._aboutForm = _aboutForm = new AboutForm();
            this._parserLogicForm = new ParkingFunctionForm(this._controller,
                                                       this.openFileDialog1,
                                                       this.statusLabel);
            ButtonActive(this.parserButton);
            OpenSubForm(_parserLogicForm);


        }



        private void OpenSubForm(Form subform)
        {

            subform.TopLevel = false;
            this.mainWorkPanel.Tag = subform;
            this.mainWorkPanel.Controls.Add(subform);
            subform.FormBorderStyle = FormBorderStyle.None;
            subform.Dock = DockStyle.Fill;
            subform.BringToFront();
            subform.Show();

        }


        private void ParserButtonClick(object sender, EventArgs e)
        {
            ButtonActive(sender);
            OpenSubForm(_parserLogicForm);

        }
        private void AboutButtonClick(object sender, EventArgs e)
        {

            ButtonActive(sender);
            OpenSubForm(_aboutForm);



        }



        private void ButtonActive(object buttonValue) {

            ButtonInactive();
            if (buttonValue != null)
            {
                if (currrent_button != buttonValue)
                {
                    currrent_button =(System.Windows.Forms.Button) buttonValue;
                    currrent_button.BackColor = Color.FromArgb(234,234,234);


                }
            }
        }
        private void ButtonInactive()
        {
            foreach (Control prev_btn in menuPanel.Controls)
            {
                if (prev_btn.GetType() == typeof(System.Windows.Forms.Button))
                {
                    prev_btn.BackColor = Color.White;

                }
            }
        
        }

        private void brandLabel_Click(object sender, EventArgs e)
        {

        }
    }
}