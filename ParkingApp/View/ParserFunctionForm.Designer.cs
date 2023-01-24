namespace ParkingApp.View
{
    partial class ParkingFunctionForm
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
            this.parkingLogicPanel = new System.Windows.Forms.Panel();
            this.parkingTicketLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.recieptLabelOutput = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.digitLabel = new System.Windows.Forms.Label();
            this.licencePlateLabel = new System.Windows.Forms.Label();
            this.paymentDatePicker = new System.Windows.Forms.DateTimePicker();
            this.digitTextBox = new System.Windows.Forms.TextBox();
            this.licenceTextBoxt = new System.Windows.Forms.TextBox();
            this.parkingPanelPlaceholder = new System.Windows.Forms.Panel();
            this.loadFileButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.emptySpacingLabel2 = new System.Windows.Forms.Label();
            this.parkingListView = new System.Windows.Forms.ListView();
            this.licenseColumn = new System.Windows.Forms.ColumnHeader();
            this.paymentIDColumn = new System.Windows.Forms.ColumnHeader();
            this.paymentAmountColumn = new System.Windows.Forms.ColumnHeader();
            this.subtitleParkingLabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.parkingLogicPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.parkingPanelPlaceholder.SuspendLayout();
            this.SuspendLayout();
            // 
            // parkingLogicPanel
            // 
            this.parkingLogicPanel.AutoScroll = true;
            this.parkingLogicPanel.AutoScrollMargin = new System.Drawing.Size(0, 50);
            this.parkingLogicPanel.AutoScrollMinSize = new System.Drawing.Size(0, 50);
            this.parkingLogicPanel.AutoSize = true;
            this.parkingLogicPanel.BackColor = System.Drawing.Color.White;
            this.parkingLogicPanel.Controls.Add(this.parkingTicketLabel);
            this.parkingLogicPanel.Controls.Add(this.panel1);
            this.parkingLogicPanel.Controls.Add(this.dateLabel);
            this.parkingLogicPanel.Controls.Add(this.digitLabel);
            this.parkingLogicPanel.Controls.Add(this.licencePlateLabel);
            this.parkingLogicPanel.Controls.Add(this.paymentDatePicker);
            this.parkingLogicPanel.Controls.Add(this.digitTextBox);
            this.parkingLogicPanel.Controls.Add(this.licenceTextBoxt);
            this.parkingLogicPanel.Controls.Add(this.parkingPanelPlaceholder);
            this.parkingLogicPanel.Controls.Add(this.emptySpacingLabel2);
            this.parkingLogicPanel.Controls.Add(this.parkingListView);
            this.parkingLogicPanel.Controls.Add(this.subtitleParkingLabel);
            this.parkingLogicPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parkingLogicPanel.Location = new System.Drawing.Point(0, 0);
            this.parkingLogicPanel.Name = "parkingLogicPanel";
            this.parkingLogicPanel.Padding = new System.Windows.Forms.Padding(25);
            this.parkingLogicPanel.Size = new System.Drawing.Size(911, 823);
            this.parkingLogicPanel.TabIndex = 1;
            this.parkingLogicPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.parkingLogicPanel_Paint);
            // 
            // parkingTicketLabel
            // 
            this.parkingTicketLabel.AutoSize = true;
            this.parkingTicketLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.parkingTicketLabel.Location = new System.Drawing.Point(588, 111);
            this.parkingTicketLabel.Name = "parkingTicketLabel";
            this.parkingTicketLabel.Padding = new System.Windows.Forms.Padding(10);
            this.parkingTicketLabel.Size = new System.Drawing.Size(133, 52);
            this.parkingTicketLabel.TabIndex = 0;
            this.parkingTicketLabel.Text = "Message:";
            this.parkingTicketLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.recieptLabelOutput);
            this.panel1.Location = new System.Drawing.Point(440, 164);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 371);
            this.panel1.TabIndex = 42;
            // 
            // recieptLabelOutput
            // 
            this.recieptLabelOutput.AutoSize = true;
            this.recieptLabelOutput.Dock = System.Windows.Forms.DockStyle.Top;
            this.recieptLabelOutput.Location = new System.Drawing.Point(0, 0);
            this.recieptLabelOutput.Name = "recieptLabelOutput";
            this.recieptLabelOutput.Size = new System.Drawing.Size(0, 25);
            this.recieptLabelOutput.TabIndex = 0;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(33, 702);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(150, 25);
            this.dateLabel.TabIndex = 41;
            this.dateLabel.Text = "Date of payment:";
            // 
            // digitLabel
            // 
            this.digitLabel.AutoSize = true;
            this.digitLabel.Location = new System.Drawing.Point(33, 645);
            this.digitLabel.Name = "digitLabel";
            this.digitLabel.Size = new System.Drawing.Size(258, 25);
            this.digitLabel.TabIndex = 40;
            this.digitLabel.Text = "Last four digits of card number";
            // 
            // licencePlateLabel
            // 
            this.licencePlateLabel.AutoSize = true;
            this.licencePlateLabel.Location = new System.Drawing.Point(33, 601);
            this.licencePlateLabel.Name = "licencePlateLabel";
            this.licencePlateLabel.Size = new System.Drawing.Size(111, 25);
            this.licencePlateLabel.TabIndex = 39;
            this.licencePlateLabel.Text = "License Plate";
            // 
            // paymentDatePicker
            // 
            this.paymentDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.paymentDatePicker.Location = new System.Drawing.Point(322, 697);
            this.paymentDatePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.paymentDatePicker.Name = "paymentDatePicker";
            this.paymentDatePicker.Size = new System.Drawing.Size(300, 31);
            this.paymentDatePicker.TabIndex = 38;
            this.paymentDatePicker.Value = new System.DateTime(2019, 1, 24, 0, 0, 0, 0);
            // 
            // digitTextBox
            // 
            this.digitTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.digitTextBox.Location = new System.Drawing.Point(322, 643);
            this.digitTextBox.Name = "digitTextBox";
            this.digitTextBox.Size = new System.Drawing.Size(300, 31);
            this.digitTextBox.TabIndex = 37;
            // 
            // licenceTextBoxt
            // 
            this.licenceTextBoxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.licenceTextBoxt.Location = new System.Drawing.Point(322, 599);
            this.licenceTextBoxt.Name = "licenceTextBoxt";
            this.licenceTextBoxt.Size = new System.Drawing.Size(300, 31);
            this.licenceTextBoxt.TabIndex = 36;
            // 
            // parkingPanelPlaceholder
            // 
            this.parkingPanelPlaceholder.Controls.Add(this.loadFileButton);
            this.parkingPanelPlaceholder.Controls.Add(this.clearButton);
            this.parkingPanelPlaceholder.Controls.Add(this.searchButton);
            this.parkingPanelPlaceholder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.parkingPanelPlaceholder.Location = new System.Drawing.Point(25, 757);
            this.parkingPanelPlaceholder.Name = "parkingPanelPlaceholder";
            this.parkingPanelPlaceholder.Size = new System.Drawing.Size(861, 41);
            this.parkingPanelPlaceholder.TabIndex = 35;
            // 
            // loadFileButton
            // 
            this.loadFileButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.loadFileButton.Location = new System.Drawing.Point(207, 0);
            this.loadFileButton.Name = "loadFileButton";
            this.loadFileButton.Size = new System.Drawing.Size(144, 41);
            this.loadFileButton.TabIndex = 27;
            this.loadFileButton.Text = "Load JSON File";
            this.loadFileButton.UseVisualStyleBackColor = true;
            this.loadFileButton.Click += new System.EventHandler(this.loadFileButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.clearButton.Enabled = false;
            this.clearButton.Location = new System.Drawing.Point(109, 0);
            this.clearButton.Name = "clearButton";
            this.clearButton.Padding = new System.Windows.Forms.Padding(5);
            this.clearButton.Size = new System.Drawing.Size(98, 41);
            this.clearButton.TabIndex = 26;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearClick);
            // 
            // searchButton
            // 
            this.searchButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.searchButton.Enabled = false;
            this.searchButton.Location = new System.Drawing.Point(0, 0);
            this.searchButton.Name = "searchButton";
            this.searchButton.Padding = new System.Windows.Forms.Padding(5);
            this.searchButton.Size = new System.Drawing.Size(109, 41);
            this.searchButton.TabIndex = 25;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButtonClick);
            // 
            // emptySpacingLabel2
            // 
            this.emptySpacingLabel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.emptySpacingLabel2.Location = new System.Drawing.Point(25, 153);
            this.emptySpacingLabel2.Name = "emptySpacingLabel2";
            this.emptySpacingLabel2.Padding = new System.Windows.Forms.Padding(14, 15, 14, 15);
            this.emptySpacingLabel2.Size = new System.Drawing.Size(861, 10);
            this.emptySpacingLabel2.TabIndex = 32;
            // 
            // parkingListView
            // 
            this.parkingListView.AllowColumnReorder = true;
            this.parkingListView.BackColor = System.Drawing.Color.WhiteSmoke;
            this.parkingListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.licenseColumn,
            this.paymentIDColumn,
            this.paymentAmountColumn});
            this.parkingListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.parkingListView.Location = new System.Drawing.Point(25, 164);
            this.parkingListView.Margin = new System.Windows.Forms.Padding(25);
            this.parkingListView.MinimumSize = new System.Drawing.Size(70, 4);
            this.parkingListView.Name = "parkingListView";
            this.parkingListView.Size = new System.Drawing.Size(387, 371);
            this.parkingListView.TabIndex = 27;
            this.parkingListView.UseCompatibleStateImageBehavior = false;
            this.parkingListView.View = System.Windows.Forms.View.Details;
            this.parkingListView.SelectedIndexChanged += new System.EventHandler(this.parkingListViewSelectedIndexChanged);
            // 
            // licenseColumn
            // 
            this.licenseColumn.Text = "License Plate ID";
            this.licenseColumn.Width = 140;
            // 
            // paymentIDColumn
            // 
            this.paymentIDColumn.Text = "Payment ID";
            this.paymentIDColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.paymentIDColumn.Width = 120;
            // 
            // paymentAmountColumn
            // 
            this.paymentAmountColumn.Text = "Payment Amount";
            this.paymentAmountColumn.Width = 120;
            // 
            // subtitleParkingLabel
            // 
            this.subtitleParkingLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.subtitleParkingLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subtitleParkingLabel.Location = new System.Drawing.Point(25, 25);
            this.subtitleParkingLabel.Name = "subtitleParkingLabel";
            this.subtitleParkingLabel.Padding = new System.Windows.Forms.Padding(35);
            this.subtitleParkingLabel.Size = new System.Drawing.Size(861, 128);
            this.subtitleParkingLabel.TabIndex = 7;
            this.subtitleParkingLabel.Text = "Search Ticket";
            this.subtitleParkingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ParkingFunctionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 823);
            this.Controls.Add(this.parkingLogicPanel);
            this.Name = "ParkingFunctionForm";
            this.Text = "ParkingFunctionForm";
            this.parkingLogicPanel.ResumeLayout(false);
            this.parkingLogicPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.parkingPanelPlaceholder.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel parkingLogicPanel;
        private Label subtitleParkingLabel;
        private ListView parkingListView;
        private ColumnHeader licenseColumn;
        private ColumnHeader paymentIDColumn;
        private Panel parkingPanelPlaceholder;
        private Button clearButton;
        private Button searchButton;
        private Label emptySpacingLabel2;
        private TextBox licenceTextBoxt;
        private Label digitLabel;
        private Label licencePlateLabel;
        private DateTimePicker paymentDatePicker;
        private TextBox digitTextBox;
        private Label dateLabel;
        private Button loadFileButton;
        private OpenFileDialog openFileDialog1;
        private Panel panel1;
        private Label parkingTicketLabel;
        private Label recieptLabelOutput;
        private ColumnHeader paymentAmountColumn;
    }
}