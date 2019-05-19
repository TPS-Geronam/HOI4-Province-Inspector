using System.Drawing;
using System.Windows.Forms;

namespace H4ProvinceEditor {
    partial class mainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.selectImageButton = new System.Windows.Forms.Button();
            this.pathToImageBox = new System.Windows.Forms.TextBox();
            this.helpButton = new System.Windows.Forms.Button();
            this.pathToDefinitionBox = new System.Windows.Forms.TextBox();
            this.definitionButton = new System.Windows.Forms.Button();
            this.defWarningLabel = new System.Windows.Forms.Label();
            this.provIdBox = new System.Windows.Forms.TextBox();
            this.provColorBox = new System.Windows.Forms.TextBox();
            this.provIDLabel = new System.Windows.Forms.Label();
            this.provRGBLabel = new System.Windows.Forms.Label();
            this.provTypeLabel = new System.Windows.Forms.Label();
            this.provTypeBox = new System.Windows.Forms.TextBox();
            this.provCoastalLabel = new System.Windows.Forms.Label();
            this.provCoastalBox = new System.Windows.Forms.TextBox();
            this.provContinentLabel = new System.Windows.Forms.Label();
            this.provContinentBox = new System.Windows.Forms.TextBox();
            this.provTerrainLabel = new System.Windows.Forms.Label();
            this.provTerrainBox = new System.Windows.Forms.TextBox();
            this.backupProvImageCheckbox = new System.Windows.Forms.CheckBox();
            this.backupDefinitionCheckbox = new System.Windows.Forms.CheckBox();
            this.openResourcesButton = new System.Windows.Forms.Button();
            this.blurryErrorLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTabControl = new System.Windows.Forms.TabControl();
            this.searchTab = new System.Windows.Forms.TabPage();
            this.searchErrorLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchRGBBox = new System.Windows.Forms.TextBox();
            this.searchIDBox = new System.Windows.Forms.TextBox();
            this.searchIDLabel = new System.Windows.Forms.Label();
            this.searchRGBLabel = new System.Windows.Forms.Label();
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.searchIDRadio = new System.Windows.Forms.RadioButton();
            this.searchRGBRadio = new System.Windows.Forms.RadioButton();
            this.genTab = new System.Windows.Forms.TabPage();
            this.genResultButton = new System.Windows.Forms.Button();
            this.genResult = new System.Windows.Forms.TextBox();
            this.genContinentLabel = new System.Windows.Forms.Label();
            this.genContinentNumeric = new System.Windows.Forms.NumericUpDown();
            this.genCoastalCheck = new System.Windows.Forms.CheckBox();
            this.genTypeLabel = new System.Windows.Forms.Label();
            this.genTerrainLabel = new System.Windows.Forms.Label();
            this.genTerrainCombo = new System.Windows.Forms.ComboBox();
            this.genTypeCombo = new System.Windows.Forms.ComboBox();
            this.genRGBButton = new System.Windows.Forms.Button();
            this.genRGBLabel = new System.Windows.Forms.Label();
            this.genIDButton = new System.Windows.Forms.Button();
            this.genRGBBox = new System.Windows.Forms.TextBox();
            this.genIDLabel = new System.Windows.Forms.Label();
            this.genIDBox = new System.Windows.Forms.TextBox();
            this.imageDisplay = new H4ProvinceEditor.ImageDisplay();
            this.genErrorLabel = new System.Windows.Forms.Label();
            this.toolTabControl.SuspendLayout();
            this.searchTab.SuspendLayout();
            this.searchGroupBox.SuspendLayout();
            this.genTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genContinentNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // selectImageButton
            // 
            this.selectImageButton.Location = new System.Drawing.Point(242, 392);
            this.selectImageButton.Name = "selectImageButton";
            this.selectImageButton.Size = new System.Drawing.Size(110, 22);
            this.selectImageButton.TabIndex = 1;
            this.selectImageButton.Text = "Select Image";
            this.selectImageButton.UseVisualStyleBackColor = true;
            this.selectImageButton.Click += new System.EventHandler(this.SelectImageButton_Click);
            // 
            // pathToImageBox
            // 
            this.pathToImageBox.Location = new System.Drawing.Point(12, 393);
            this.pathToImageBox.Name = "pathToImageBox";
            this.pathToImageBox.ReadOnly = true;
            this.pathToImageBox.Size = new System.Drawing.Size(224, 20);
            this.pathToImageBox.TabIndex = 2;
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(1020, 563);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(25, 22);
            this.helpButton.TabIndex = 3;
            this.helpButton.Text = "?";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // pathToDefinitionBox
            // 
            this.pathToDefinitionBox.Location = new System.Drawing.Point(12, 419);
            this.pathToDefinitionBox.Name = "pathToDefinitionBox";
            this.pathToDefinitionBox.ReadOnly = true;
            this.pathToDefinitionBox.Size = new System.Drawing.Size(224, 20);
            this.pathToDefinitionBox.TabIndex = 4;
            // 
            // definitionButton
            // 
            this.definitionButton.Location = new System.Drawing.Point(242, 418);
            this.definitionButton.Name = "definitionButton";
            this.definitionButton.Size = new System.Drawing.Size(110, 22);
            this.definitionButton.TabIndex = 5;
            this.definitionButton.Text = "Select Definition";
            this.definitionButton.UseVisualStyleBackColor = true;
            this.definitionButton.Click += new System.EventHandler(this.DefinitionButton_Click);
            // 
            // defWarningLabel
            // 
            this.defWarningLabel.AutoSize = true;
            this.defWarningLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.defWarningLabel.Location = new System.Drawing.Point(11, 504);
            this.defWarningLabel.Name = "defWarningLabel";
            this.defWarningLabel.Size = new System.Drawing.Size(0, 13);
            this.defWarningLabel.TabIndex = 6;
            // 
            // provIdBox
            // 
            this.provIdBox.Location = new System.Drawing.Point(815, 415);
            this.provIdBox.Name = "provIdBox";
            this.provIdBox.ReadOnly = true;
            this.provIdBox.Size = new System.Drawing.Size(100, 20);
            this.provIdBox.TabIndex = 7;
            // 
            // provColorBox
            // 
            this.provColorBox.Location = new System.Drawing.Point(936, 415);
            this.provColorBox.Name = "provColorBox";
            this.provColorBox.ReadOnly = true;
            this.provColorBox.Size = new System.Drawing.Size(100, 20);
            this.provColorBox.TabIndex = 8;
            // 
            // provIDLabel
            // 
            this.provIDLabel.AutoSize = true;
            this.provIDLabel.Location = new System.Drawing.Point(812, 399);
            this.provIDLabel.Name = "provIDLabel";
            this.provIDLabel.Size = new System.Drawing.Size(21, 13);
            this.provIDLabel.TabIndex = 10;
            this.provIDLabel.Text = "ID:";
            // 
            // provRGBLabel
            // 
            this.provRGBLabel.AutoSize = true;
            this.provRGBLabel.Location = new System.Drawing.Point(933, 399);
            this.provRGBLabel.Name = "provRGBLabel";
            this.provRGBLabel.Size = new System.Drawing.Size(33, 13);
            this.provRGBLabel.TabIndex = 11;
            this.provRGBLabel.Text = "RGB:";
            // 
            // provTypeLabel
            // 
            this.provTypeLabel.AutoSize = true;
            this.provTypeLabel.Location = new System.Drawing.Point(812, 451);
            this.provTypeLabel.Name = "provTypeLabel";
            this.provTypeLabel.Size = new System.Drawing.Size(34, 13);
            this.provTypeLabel.TabIndex = 13;
            this.provTypeLabel.Text = "Type:";
            // 
            // provTypeBox
            // 
            this.provTypeBox.Location = new System.Drawing.Point(815, 467);
            this.provTypeBox.Name = "provTypeBox";
            this.provTypeBox.ReadOnly = true;
            this.provTypeBox.Size = new System.Drawing.Size(100, 20);
            this.provTypeBox.TabIndex = 12;
            // 
            // provCoastalLabel
            // 
            this.provCoastalLabel.AutoSize = true;
            this.provCoastalLabel.Location = new System.Drawing.Point(933, 451);
            this.provCoastalLabel.Name = "provCoastalLabel";
            this.provCoastalLabel.Size = new System.Drawing.Size(45, 13);
            this.provCoastalLabel.TabIndex = 15;
            this.provCoastalLabel.Text = "Coastal:";
            // 
            // provCoastalBox
            // 
            this.provCoastalBox.Location = new System.Drawing.Point(936, 467);
            this.provCoastalBox.Name = "provCoastalBox";
            this.provCoastalBox.ReadOnly = true;
            this.provCoastalBox.Size = new System.Drawing.Size(100, 20);
            this.provCoastalBox.TabIndex = 14;
            // 
            // provContinentLabel
            // 
            this.provContinentLabel.AutoSize = true;
            this.provContinentLabel.Location = new System.Drawing.Point(933, 504);
            this.provContinentLabel.Name = "provContinentLabel";
            this.provContinentLabel.Size = new System.Drawing.Size(55, 13);
            this.provContinentLabel.TabIndex = 19;
            this.provContinentLabel.Text = "Continent:";
            // 
            // provContinentBox
            // 
            this.provContinentBox.Location = new System.Drawing.Point(936, 520);
            this.provContinentBox.Name = "provContinentBox";
            this.provContinentBox.ReadOnly = true;
            this.provContinentBox.Size = new System.Drawing.Size(100, 20);
            this.provContinentBox.TabIndex = 18;
            // 
            // provTerrainLabel
            // 
            this.provTerrainLabel.AutoSize = true;
            this.provTerrainLabel.Location = new System.Drawing.Point(812, 504);
            this.provTerrainLabel.Name = "provTerrainLabel";
            this.provTerrainLabel.Size = new System.Drawing.Size(43, 13);
            this.provTerrainLabel.TabIndex = 17;
            this.provTerrainLabel.Text = "Terrain:";
            // 
            // provTerrainBox
            // 
            this.provTerrainBox.Location = new System.Drawing.Point(815, 520);
            this.provTerrainBox.Name = "provTerrainBox";
            this.provTerrainBox.ReadOnly = true;
            this.provTerrainBox.Size = new System.Drawing.Size(100, 20);
            this.provTerrainBox.TabIndex = 16;
            // 
            // backupProvImageCheckbox
            // 
            this.backupProvImageCheckbox.AutoSize = true;
            this.backupProvImageCheckbox.Checked = true;
            this.backupProvImageCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.backupProvImageCheckbox.Location = new System.Drawing.Point(12, 450);
            this.backupProvImageCheckbox.Name = "backupProvImageCheckbox";
            this.backupProvImageCheckbox.Size = new System.Drawing.Size(155, 17);
            this.backupProvImageCheckbox.TabIndex = 20;
            this.backupProvImageCheckbox.Text = "Backup image to resources";
            this.backupProvImageCheckbox.UseVisualStyleBackColor = true;
            this.backupProvImageCheckbox.CheckedChanged += new System.EventHandler(this.BackupProvImageCheckbox_CheckedChanged);
            // 
            // backupDefinitionCheckbox
            // 
            this.backupDefinitionCheckbox.AutoSize = true;
            this.backupDefinitionCheckbox.Checked = true;
            this.backupDefinitionCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.backupDefinitionCheckbox.Location = new System.Drawing.Point(12, 473);
            this.backupDefinitionCheckbox.Name = "backupDefinitionCheckbox";
            this.backupDefinitionCheckbox.Size = new System.Drawing.Size(169, 17);
            this.backupDefinitionCheckbox.TabIndex = 21;
            this.backupDefinitionCheckbox.Text = "Backup definition to resources";
            this.backupDefinitionCheckbox.UseVisualStyleBackColor = true;
            this.backupDefinitionCheckbox.CheckedChanged += new System.EventHandler(this.BackupDefinitionCheckbox_CheckedChanged);
            // 
            // openResourcesButton
            // 
            this.openResourcesButton.Location = new System.Drawing.Point(242, 450);
            this.openResourcesButton.Name = "openResourcesButton";
            this.openResourcesButton.Size = new System.Drawing.Size(110, 22);
            this.openResourcesButton.TabIndex = 22;
            this.openResourcesButton.Text = "Browse Resources";
            this.openResourcesButton.UseVisualStyleBackColor = true;
            this.openResourcesButton.Click += new System.EventHandler(this.OpenResourcesButton_Click);
            // 
            // blurryErrorLabel
            // 
            this.blurryErrorLabel.AutoSize = true;
            this.blurryErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.blurryErrorLabel.Location = new System.Drawing.Point(812, 552);
            this.blurryErrorLabel.Name = "blurryErrorLabel";
            this.blurryErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.blurryErrorLabel.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            // 
            // toolTabControl
            // 
            this.toolTabControl.Controls.Add(this.searchTab);
            this.toolTabControl.Controls.Add(this.genTab);
            this.toolTabControl.Location = new System.Drawing.Point(364, 392);
            this.toolTabControl.Name = "toolTabControl";
            this.toolTabControl.SelectedIndex = 0;
            this.toolTabControl.Size = new System.Drawing.Size(442, 183);
            this.toolTabControl.TabIndex = 24;
            // 
            // searchTab
            // 
            this.searchTab.Controls.Add(this.searchErrorLabel);
            this.searchTab.Controls.Add(this.searchButton);
            this.searchTab.Controls.Add(this.searchRGBBox);
            this.searchTab.Controls.Add(this.searchIDBox);
            this.searchTab.Controls.Add(this.searchIDLabel);
            this.searchTab.Controls.Add(this.searchRGBLabel);
            this.searchTab.Controls.Add(this.searchGroupBox);
            this.searchTab.Location = new System.Drawing.Point(4, 22);
            this.searchTab.Name = "searchTab";
            this.searchTab.Padding = new System.Windows.Forms.Padding(3);
            this.searchTab.Size = new System.Drawing.Size(434, 157);
            this.searchTab.TabIndex = 0;
            this.searchTab.Text = "Search";
            this.searchTab.UseVisualStyleBackColor = true;
            // 
            // searchErrorLabel
            // 
            this.searchErrorLabel.AutoSize = true;
            this.searchErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.searchErrorLabel.Location = new System.Drawing.Point(8, 63);
            this.searchErrorLabel.Name = "searchErrorLabel";
            this.searchErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.searchErrorLabel.TabIndex = 25;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(243, 92);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(185, 22);
            this.searchButton.TabIndex = 25;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // searchRGBBox
            // 
            this.searchRGBBox.Location = new System.Drawing.Point(132, 30);
            this.searchRGBBox.Name = "searchRGBBox";
            this.searchRGBBox.Size = new System.Drawing.Size(100, 20);
            this.searchRGBBox.TabIndex = 26;
            // 
            // searchIDBox
            // 
            this.searchIDBox.Location = new System.Drawing.Point(11, 30);
            this.searchIDBox.Name = "searchIDBox";
            this.searchIDBox.Size = new System.Drawing.Size(100, 20);
            this.searchIDBox.TabIndex = 25;
            // 
            // searchIDLabel
            // 
            this.searchIDLabel.AutoSize = true;
            this.searchIDLabel.Location = new System.Drawing.Point(8, 14);
            this.searchIDLabel.Name = "searchIDLabel";
            this.searchIDLabel.Size = new System.Drawing.Size(21, 13);
            this.searchIDLabel.TabIndex = 27;
            this.searchIDLabel.Text = "ID:";
            // 
            // searchRGBLabel
            // 
            this.searchRGBLabel.AutoSize = true;
            this.searchRGBLabel.Location = new System.Drawing.Point(129, 14);
            this.searchRGBLabel.Name = "searchRGBLabel";
            this.searchRGBLabel.Size = new System.Drawing.Size(33, 13);
            this.searchRGBLabel.TabIndex = 28;
            this.searchRGBLabel.Text = "RGB:";
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Controls.Add(this.searchIDRadio);
            this.searchGroupBox.Controls.Add(this.searchRGBRadio);
            this.searchGroupBox.Location = new System.Drawing.Point(243, 14);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Size = new System.Drawing.Size(185, 72);
            this.searchGroupBox.TabIndex = 31;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "Search for...";
            // 
            // searchIDRadio
            // 
            this.searchIDRadio.AutoSize = true;
            this.searchIDRadio.Location = new System.Drawing.Point(18, 45);
            this.searchIDRadio.Name = "searchIDRadio";
            this.searchIDRadio.Size = new System.Drawing.Size(84, 17);
            this.searchIDRadio.TabIndex = 30;
            this.searchIDRadio.TabStop = true;
            this.searchIDRadio.Text = "ID with RGB";
            this.searchIDRadio.UseVisualStyleBackColor = true;
            // 
            // searchRGBRadio
            // 
            this.searchRGBRadio.AutoSize = true;
            this.searchRGBRadio.Location = new System.Drawing.Point(18, 22);
            this.searchRGBRadio.Name = "searchRGBRadio";
            this.searchRGBRadio.Size = new System.Drawing.Size(84, 17);
            this.searchRGBRadio.TabIndex = 29;
            this.searchRGBRadio.TabStop = true;
            this.searchRGBRadio.Text = "RGB with ID";
            this.searchRGBRadio.UseVisualStyleBackColor = true;
            // 
            // genTab
            // 
            this.genTab.Controls.Add(this.genErrorLabel);
            this.genTab.Controls.Add(this.genResultButton);
            this.genTab.Controls.Add(this.genResult);
            this.genTab.Controls.Add(this.genContinentLabel);
            this.genTab.Controls.Add(this.genContinentNumeric);
            this.genTab.Controls.Add(this.genCoastalCheck);
            this.genTab.Controls.Add(this.genTypeLabel);
            this.genTab.Controls.Add(this.genTerrainLabel);
            this.genTab.Controls.Add(this.genTerrainCombo);
            this.genTab.Controls.Add(this.genTypeCombo);
            this.genTab.Controls.Add(this.genRGBButton);
            this.genTab.Controls.Add(this.genRGBLabel);
            this.genTab.Controls.Add(this.genIDButton);
            this.genTab.Controls.Add(this.genRGBBox);
            this.genTab.Controls.Add(this.genIDLabel);
            this.genTab.Controls.Add(this.genIDBox);
            this.genTab.Location = new System.Drawing.Point(4, 22);
            this.genTab.Name = "genTab";
            this.genTab.Padding = new System.Windows.Forms.Padding(3);
            this.genTab.Size = new System.Drawing.Size(434, 157);
            this.genTab.TabIndex = 1;
            this.genTab.Text = "Generator";
            this.genTab.UseVisualStyleBackColor = true;
            // 
            // genResultButton
            // 
            this.genResultButton.Location = new System.Drawing.Point(307, 106);
            this.genResultButton.Name = "genResultButton";
            this.genResultButton.Size = new System.Drawing.Size(100, 22);
            this.genResultButton.TabIndex = 37;
            this.genResultButton.Text = "Get result";
            this.genResultButton.UseVisualStyleBackColor = true;
            this.genResultButton.Click += new System.EventHandler(this.GenResultButton_Click);
            // 
            // genResult
            // 
            this.genResult.Location = new System.Drawing.Point(11, 107);
            this.genResult.Name = "genResult";
            this.genResult.ReadOnly = true;
            this.genResult.Size = new System.Drawing.Size(285, 20);
            this.genResult.TabIndex = 35;
            // 
            // genContinentLabel
            // 
            this.genContinentLabel.AutoSize = true;
            this.genContinentLabel.Location = new System.Drawing.Point(343, 56);
            this.genContinentLabel.Name = "genContinentLabel";
            this.genContinentLabel.Size = new System.Drawing.Size(52, 13);
            this.genContinentLabel.TabIndex = 34;
            this.genContinentLabel.Text = "Continent";
            // 
            // genContinentNumeric
            // 
            this.genContinentNumeric.Location = new System.Drawing.Point(345, 71);
            this.genContinentNumeric.Name = "genContinentNumeric";
            this.genContinentNumeric.ReadOnly = true;
            this.genContinentNumeric.Size = new System.Drawing.Size(62, 20);
            this.genContinentNumeric.TabIndex = 33;
            // 
            // genCoastalCheck
            // 
            this.genCoastalCheck.AutoSize = true;
            this.genCoastalCheck.Location = new System.Drawing.Point(346, 30);
            this.genCoastalCheck.Name = "genCoastalCheck";
            this.genCoastalCheck.Size = new System.Drawing.Size(61, 17);
            this.genCoastalCheck.TabIndex = 32;
            this.genCoastalCheck.Text = "Coastal";
            this.genCoastalCheck.UseVisualStyleBackColor = true;
            // 
            // genTypeLabel
            // 
            this.genTypeLabel.AutoSize = true;
            this.genTypeLabel.Location = new System.Drawing.Point(253, 14);
            this.genTypeLabel.Name = "genTypeLabel";
            this.genTypeLabel.Size = new System.Drawing.Size(31, 13);
            this.genTypeLabel.TabIndex = 31;
            this.genTypeLabel.Text = "Type";
            // 
            // genTerrainLabel
            // 
            this.genTerrainLabel.AutoSize = true;
            this.genTerrainLabel.Location = new System.Drawing.Point(253, 56);
            this.genTerrainLabel.Name = "genTerrainLabel";
            this.genTerrainLabel.Size = new System.Drawing.Size(43, 13);
            this.genTerrainLabel.TabIndex = 30;
            this.genTerrainLabel.Text = "Terrain:";
            // 
            // genTerrainCombo
            // 
            this.genTerrainCombo.FormattingEnabled = true;
            this.genTerrainCombo.Items.AddRange(new object[] {
            "plains",
            "hills",
            "urban",
            "forest",
            "ocean",
            "mountain",
            "marsh",
            "jungle",
            "desert",
            "lakes"});
            this.genTerrainCombo.Location = new System.Drawing.Point(256, 71);
            this.genTerrainCombo.Name = "genTerrainCombo";
            this.genTerrainCombo.Size = new System.Drawing.Size(70, 21);
            this.genTerrainCombo.TabIndex = 29;
            // 
            // genTypeCombo
            // 
            this.genTypeCombo.FormattingEnabled = true;
            this.genTypeCombo.Items.AddRange(new object[] {
            "land",
            "sea",
            "lake"});
            this.genTypeCombo.Location = new System.Drawing.Point(256, 29);
            this.genTypeCombo.Name = "genTypeCombo";
            this.genTypeCombo.Size = new System.Drawing.Size(70, 21);
            this.genTypeCombo.TabIndex = 28;
            // 
            // genRGBButton
            // 
            this.genRGBButton.Location = new System.Drawing.Point(132, 71);
            this.genRGBButton.Name = "genRGBButton";
            this.genRGBButton.Size = new System.Drawing.Size(100, 22);
            this.genRGBButton.TabIndex = 27;
            this.genRGBButton.Text = "Get possible RGB";
            this.genRGBButton.UseVisualStyleBackColor = true;
            this.genRGBButton.Click += new System.EventHandler(this.GenRGBButton_Click);
            // 
            // genRGBLabel
            // 
            this.genRGBLabel.AutoSize = true;
            this.genRGBLabel.Location = new System.Drawing.Point(8, 56);
            this.genRGBLabel.Name = "genRGBLabel";
            this.genRGBLabel.Size = new System.Drawing.Size(33, 13);
            this.genRGBLabel.TabIndex = 26;
            this.genRGBLabel.Text = "RGB:";
            // 
            // genIDButton
            // 
            this.genIDButton.Location = new System.Drawing.Point(132, 29);
            this.genIDButton.Name = "genIDButton";
            this.genIDButton.Size = new System.Drawing.Size(100, 22);
            this.genIDButton.TabIndex = 25;
            this.genIDButton.Text = "Get possible ID";
            this.genIDButton.UseVisualStyleBackColor = true;
            this.genIDButton.Click += new System.EventHandler(this.GenIDButton_Click);
            // 
            // genRGBBox
            // 
            this.genRGBBox.Location = new System.Drawing.Point(11, 72);
            this.genRGBBox.Name = "genRGBBox";
            this.genRGBBox.ReadOnly = true;
            this.genRGBBox.Size = new System.Drawing.Size(100, 20);
            this.genRGBBox.TabIndex = 25;
            // 
            // genIDLabel
            // 
            this.genIDLabel.AutoSize = true;
            this.genIDLabel.Location = new System.Drawing.Point(8, 14);
            this.genIDLabel.Name = "genIDLabel";
            this.genIDLabel.Size = new System.Drawing.Size(21, 13);
            this.genIDLabel.TabIndex = 26;
            this.genIDLabel.Text = "ID:";
            // 
            // genIDBox
            // 
            this.genIDBox.Location = new System.Drawing.Point(11, 30);
            this.genIDBox.Name = "genIDBox";
            this.genIDBox.ReadOnly = true;
            this.genIDBox.Size = new System.Drawing.Size(100, 20);
            this.genIDBox.TabIndex = 25;
            // 
            // imageDisplay
            // 
            this.imageDisplay.Image = null;
            this.imageDisplay.Location = new System.Drawing.Point(14, 11);
            this.imageDisplay.Name = "imageDisplay";
            this.imageDisplay.Size = new System.Drawing.Size(1022, 376);
            this.imageDisplay.TabIndex = 0;
            this.imageDisplay.TabStop = false;
            this.imageDisplay.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ImageDisplay_MouseDown);
            // 
            // genErrorLabel
            // 
            this.genErrorLabel.AutoSize = true;
            this.genErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.genErrorLabel.Location = new System.Drawing.Point(8, 135);
            this.genErrorLabel.Name = "genErrorLabel";
            this.genErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.genErrorLabel.TabIndex = 25;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 587);
            this.Controls.Add(this.toolTabControl);
            this.Controls.Add(this.blurryErrorLabel);
            this.Controls.Add(this.openResourcesButton);
            this.Controls.Add(this.backupDefinitionCheckbox);
            this.Controls.Add(this.backupProvImageCheckbox);
            this.Controls.Add(this.provTerrainBox);
            this.Controls.Add(this.provTerrainLabel);
            this.Controls.Add(this.provContinentBox);
            this.Controls.Add(this.provContinentLabel);
            this.Controls.Add(this.provCoastalBox);
            this.Controls.Add(this.provCoastalLabel);
            this.Controls.Add(this.provTypeBox);
            this.Controls.Add(this.provTypeLabel);
            this.Controls.Add(this.provRGBLabel);
            this.Controls.Add(this.provIDLabel);
            this.Controls.Add(this.provColorBox);
            this.Controls.Add(this.provIdBox);
            this.Controls.Add(this.defWarningLabel);
            this.Controls.Add(this.definitionButton);
            this.Controls.Add(this.pathToDefinitionBox);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.pathToImageBox);
            this.Controls.Add(this.selectImageButton);
            this.Controls.Add(this.imageDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "Province Inspector";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolTabControl.ResumeLayout(false);
            this.searchTab.ResumeLayout(false);
            this.searchTab.PerformLayout();
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            this.genTab.ResumeLayout(false);
            this.genTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genContinentNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button selectImageButton;
        private TextBox pathToImageBox;
        private Button helpButton;
        private TextBox pathToDefinitionBox;
        private Button definitionButton;
        private Label defWarningLabel;
        private TextBox provIdBox;
        private TextBox provColorBox;
        private ImageDisplay imageDisplay;
        private Label provIDLabel;
        private Label provRGBLabel;
        private Label provTypeLabel;
        private TextBox provTypeBox;
        private Label provCoastalLabel;
        private TextBox provCoastalBox;
        private Label provContinentLabel;
        private TextBox provContinentBox;
        private Label provTerrainLabel;
        private TextBox provTerrainBox;
        private CheckBox backupProvImageCheckbox;
        private CheckBox backupDefinitionCheckbox;
        private Button openResourcesButton;
        private Label blurryErrorLabel;
        private Button button1;
        private TabControl toolTabControl;
        private TabPage searchTab;
        private RadioButton searchIDRadio;
        private RadioButton searchRGBRadio;
        private Button searchButton;
        private TextBox searchRGBBox;
        private TextBox searchIDBox;
        private Label searchIDLabel;
        private Label searchRGBLabel;
        private GroupBox searchGroupBox;
        private TabPage genTab;
        private Label searchErrorLabel;
        private Button genIDButton;
        private Label genIDLabel;
        private TextBox genIDBox;
        private Button genRGBButton;
        private Label genRGBLabel;
        private TextBox genRGBBox;
        private ComboBox genTypeCombo;
        private Label genTypeLabel;
        private Label genTerrainLabel;
        private ComboBox genTerrainCombo;
        private NumericUpDown genContinentNumeric;
        private CheckBox genCoastalCheck;
        private Label genContinentLabel;
        private Button genResultButton;
        private TextBox genResult;
        private Label genErrorLabel;
    }

    public class ImageDisplay : PictureBox {
        private int zmLevel = 1;
        private Point zmPt = new Point(512, 187);

        public ImageDisplay() {
            this.MouseWheel += new MouseEventHandler(ImageDisplay_MouseWheel);
            this.MouseUp += new MouseEventHandler(ImageDisplay_MouseUp);
        }

        void ImageDisplay_MouseUp(object sender, MouseEventArgs e) {
            if(this.zmLevel == 1 && e.Button == MouseButtons.Right) {
                this.zmPt.X = e.X;
                this.zmPt.Y = e.Y;
            }
        }

        void ImageDisplay_MouseWheel(object sender, MouseEventArgs e) {
            if(e.Delta > 0) {
                if(zmLevel < 20) {
                    zmLevel += 1;
                }
            } else {
                if(e.Delta < 1) {
                    if(zmLevel > 1) {
                        zmLevel -= 1;
                    }
                }
            }

            this.Invalidate();
        }


        new public Image Image {
            get {
                return base.Image;
            }
            set {
                zmLevel = 1;
                base.Image = value;
            }
        }


        protected override void OnPaint(PaintEventArgs pe) {
            //base.OnPaint(pe);
            if(this.Image != null) {
                Point loc;
                Size sz;
                if(zmLevel != 1) {
                    sz = new Size(this.Image.Width / zmLevel, this.Image.Height / zmLevel);
                    // center on zmPt. Casts are needed so integer divide doesn't occur (intermediate double result)
                    loc = new Point((int)(this.Image.Width * (zmPt.X / (double)this.ClientRectangle.Width)) - sz.Width / 2,
                                     (int)(this.Image.Height * (zmPt.Y / (double)this.ClientRectangle.Height)) - sz.Height / 2);
                } else {
                    loc = new Point(0, 0);
                    sz = this.Image.Size;
                }
                Rectangle rectSrc = new Rectangle(loc, sz);
                // now draw the rect of the source picture in the entire client rect of MyPictureBox
                pe.Graphics.DrawImage(this.Image, this.ClientRectangle, rectSrc, GraphicsUnit.Pixel);
            }
        }
    }
}