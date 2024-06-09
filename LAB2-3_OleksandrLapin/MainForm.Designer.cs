namespace LAB2_3_OleksandrLapin
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.Label lblDataStatus;
        private System.Windows.Forms.TextBox txtCountriesStatus;
        private System.Windows.Forms.TextBox txtRatesTableAStatus;
        private System.Windows.Forms.TextBox txtRatesTableBStatus;
        private System.Windows.Forms.ComboBox cmbRegion;
        private System.Windows.Forms.ComboBox cmbSubRegion;
        private System.Windows.Forms.ListBox lstCountries;
        private System.Windows.Forms.Button btnLoadCountryData;
        private System.Windows.Forms.Label lblCountryName;
        private System.Windows.Forms.Label lblCountryOfficialName;
        private System.Windows.Forms.Label lblCountryNativeName;
        private System.Windows.Forms.Label lblCountryCurrencies;
        private System.Windows.Forms.DataGridView dgvCurrencies;
        private System.Windows.Forms.Label lblCapital;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.PictureBox pbFlag;
        private System.Windows.Forms.PictureBox pbCoatOfArms;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnLoadData = new Button();
            lblDataStatus = new Label();
            txtCountriesStatus = new TextBox();
            txtRatesTableAStatus = new TextBox();
            txtRatesTableBStatus = new TextBox();
            cmbRegion = new ComboBox();
            cmbSubRegion = new ComboBox();
            lstCountries = new ListBox();
            btnLoadCountryData = new Button();
            lblCountryName = new Label();
            lblCountryOfficialName = new Label();
            lblCountryNativeName = new Label();
            lblCountryCurrencies = new Label();
            dgvCurrencies = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            lblCapital = new Label();
            lblDateTime = new Label();
            lblTemperature = new Label();
            pbFlag = new PictureBox();
            pbCoatOfArms = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvCurrencies).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbFlag).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCoatOfArms).BeginInit();
            SuspendLayout();
            // 
            // btnLoadData
            // 
            btnLoadData.Location = new Point(10, 10);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new Size(200, 30);
            btnLoadData.TabIndex = 0;
            btnLoadData.Text = "Wczytaj bazowe dane z API";
            btnLoadData.Click += btnLoadData_Click;
            // 
            // lblDataStatus
            // 
            lblDataStatus.Location = new Point(10, 50);
            lblDataStatus.Name = "lblDataStatus";
            lblDataStatus.Size = new Size(200, 20);
            lblDataStatus.TabIndex = 1;
            lblDataStatus.Text = "Status Danych:";
            // 
            // txtCountriesStatus
            // 
            txtCountriesStatus.Location = new Point(10, 80);
            txtCountriesStatus.Name = "txtCountriesStatus";
            txtCountriesStatus.ReadOnly = true;
            txtCountriesStatus.Size = new Size(300, 27);
            txtCountriesStatus.TabIndex = 2;
            // 
            // txtRatesTableAStatus
            // 
            txtRatesTableAStatus.Location = new Point(10, 110);
            txtRatesTableAStatus.Name = "txtRatesTableAStatus";
            txtRatesTableAStatus.ReadOnly = true;
            txtRatesTableAStatus.Size = new Size(300, 27);
            txtRatesTableAStatus.TabIndex = 3;
            // 
            // txtRatesTableBStatus
            // 
            txtRatesTableBStatus.Location = new Point(10, 140);
            txtRatesTableBStatus.Name = "txtRatesTableBStatus";
            txtRatesTableBStatus.ReadOnly = true;
            txtRatesTableBStatus.Size = new Size(300, 27);
            txtRatesTableBStatus.TabIndex = 4;
            // 
            // cmbRegion
            // 
            cmbRegion.Location = new Point(10, 180);
            cmbRegion.Name = "cmbRegion";
            cmbRegion.Size = new Size(200, 28);
            cmbRegion.TabIndex = 5;
            cmbRegion.SelectedIndexChanged += cmbRegion_SelectedIndexChanged;
            // 
            // cmbSubRegion
            // 
            cmbSubRegion.Location = new Point(10, 220);
            cmbSubRegion.Name = "cmbSubRegion";
            cmbSubRegion.Size = new Size(200, 28);
            cmbSubRegion.TabIndex = 6;
            cmbSubRegion.SelectedIndexChanged += cmbSubRegion_SelectedIndexChanged;
            // 
            // lstCountries
            // 
            lstCountries.ItemHeight = 20;
            lstCountries.Location = new Point(10, 260);
            lstCountries.Name = "lstCountries";
            lstCountries.Size = new Size(300, 84);
            lstCountries.TabIndex = 7;
            // 
            // btnLoadCountryData
            // 
            btnLoadCountryData.Location = new Point(10, 370);
            btnLoadCountryData.Name = "btnLoadCountryData";
            btnLoadCountryData.Size = new Size(200, 30);
            btnLoadCountryData.TabIndex = 8;
            btnLoadCountryData.Text = "Wczytaj Dane";
            btnLoadCountryData.Click += btnLoadCountryData_Click;
            // 
            // lblCountryName
            // 
            lblCountryName.Location = new Point(320, 10);
            lblCountryName.Name = "lblCountryName";
            lblCountryName.Size = new Size(300, 30);
            lblCountryName.TabIndex = 9;
            lblCountryName.Text = "Country Name";
            // 
            // lblCountryOfficialName
            // 
            lblCountryOfficialName.Location = new Point(320, 50);
            lblCountryOfficialName.Name = "lblCountryOfficialName";
            lblCountryOfficialName.Size = new Size(300, 30);
            lblCountryOfficialName.TabIndex = 10;
            lblCountryOfficialName.Text = "Official Name";
            // 
            // lblCountryNativeName
            // 
            lblCountryNativeName.Location = new Point(320, 90);
            lblCountryNativeName.Name = "lblCountryNativeName";
            lblCountryNativeName.Size = new Size(300, 30);
            lblCountryNativeName.TabIndex = 11;
            lblCountryNativeName.Text = "Native Name";
            // 
            // lblCountryCurrencies
            // 
            lblCountryCurrencies.Location = new Point(320, 130);
            lblCountryCurrencies.Name = "lblCountryCurrencies";
            lblCountryCurrencies.Size = new Size(100, 30);
            lblCountryCurrencies.TabIndex = 12;
            lblCountryCurrencies.Text = "Waluty:";
            // 
            // dgvCurrencies
            // 
            dgvCurrencies.ColumnHeadersHeight = 29;
            dgvCurrencies.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dgvCurrencies.Location = new Point(320, 170);
            dgvCurrencies.Name = "dgvCurrencies";
            dgvCurrencies.RowHeadersWidth = 51;
            dgvCurrencies.Size = new Size(556, 100);
            dgvCurrencies.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Nazwa";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Symbol";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Polska Nazwa";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Kurs Wymiany";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // lblCapital
            // 
            lblCapital.Location = new Point(320, 280);
            lblCapital.Name = "lblCapital";
            lblCapital.Size = new Size(100, 30);
            lblCapital.TabIndex = 14;
            lblCapital.Text = "Stolica";
            // 
            // lblDateTime
            // 
            lblDateTime.Location = new Point(320, 320);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(300, 30);
            lblDateTime.TabIndex = 15;
            lblDateTime.Text = "TIme";
            // 
            // lblTemperature
            // 
            lblTemperature.Location = new Point(320, 360);
            lblTemperature.Name = "lblTemperature";
            lblTemperature.Size = new Size(100, 30);
            lblTemperature.TabIndex = 16;
            // 
            // pbFlag
            // 
            pbFlag.Location = new Point(620, 10);
            pbFlag.Name = "pbFlag";
            pbFlag.Size = new Size(100, 60);
            pbFlag.TabIndex = 17;
            pbFlag.TabStop = false;
            // 
            // pbCoatOfArms
            // 
            pbCoatOfArms.Location = new Point(620, 80);
            pbCoatOfArms.Name = "pbCoatOfArms";
            pbCoatOfArms.Size = new Size(100, 60);
            pbCoatOfArms.TabIndex = 18;
            pbCoatOfArms.TabStop = false;
            // 
            // MainForm
            // 
            ClientSize = new Size(921, 450);
            Controls.Add(btnLoadData);
            Controls.Add(lblDataStatus);
            Controls.Add(txtCountriesStatus);
            Controls.Add(txtRatesTableAStatus);
            Controls.Add(txtRatesTableBStatus);
            Controls.Add(cmbRegion);
            Controls.Add(cmbSubRegion);
            Controls.Add(lstCountries);
            Controls.Add(btnLoadCountryData);
            Controls.Add(lblCountryName);
            Controls.Add(lblCountryOfficialName);
            Controls.Add(lblCountryNativeName);
            Controls.Add(lblCountryCurrencies);
            Controls.Add(dgvCurrencies);
            Controls.Add(lblCapital);
            Controls.Add(lblDateTime);
            Controls.Add(lblTemperature);
            Controls.Add(pbFlag);
            Controls.Add(pbCoatOfArms);
            Name = "MainForm";
            Text = "Moja Aplikacja";
            ((System.ComponentModel.ISupportInitialize)dgvCurrencies).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbFlag).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCoatOfArms).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }

}
