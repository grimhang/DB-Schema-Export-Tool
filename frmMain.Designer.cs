﻿using System.ComponentModel;
using System.Windows.Forms;

namespace DB_Schema_Export_Tool
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            this.lstObjectTypesToScript = new System.Windows.Forms.ListBox();
            this.mnuHelp = new System.Windows.Forms.MenuItem();
            this.mnuHelpAbout = new System.Windows.Forms.MenuItem();
            this.lblTableDataToExport = new System.Windows.Forms.Label();
            this.lblServerOutputDirectoryNamePrefix = new System.Windows.Forms.Label();
            this.lblProgress = new System.Windows.Forms.Label();
            this.txtServerOutputDirectoryNamePrefix = new System.Windows.Forms.TextBox();
            this.chkExportServerSettingsLoginsAndJobs = new System.Windows.Forms.CheckBox();
            this.lblSelectDefaultDBs = new System.Windows.Forms.Label();
            this.cmdSelectDefaultDMSDBs = new System.Windows.Forms.Button();
            this.cmdSelectDefaultMTSDBs = new System.Windows.Forms.Button();
            this.lblOutputDirectoryNamePrefix = new System.Windows.Forms.Label();
            this.txtOutputDirectoryNamePrefix = new System.Windows.Forms.TextBox();
            this.cboTableNamesToExportSortOrder = new System.Windows.Forms.ComboBox();
            this.cmdRefreshDBList = new System.Windows.Forms.Button();
            this.lstTableNamesToExportData = new System.Windows.Forms.ListBox();
            this.lblOutputDirectoryPath = new System.Windows.Forms.Label();
            this.lstDatabasesToProcess = new System.Windows.Forms.ListBox();
            this.mnuFileSep1 = new System.Windows.Forms.MenuItem();
            this.fraStatus = new System.Windows.Forms.GroupBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.pbarProgress = new System.Windows.Forms.ProgressBar();
            this.MainMenuControl = new System.Windows.Forms.MainMenu(this.components);
            this.mnuFile = new System.Windows.Forms.MenuItem();
            this.mnuFileSelectOutputDirectory = new System.Windows.Forms.MenuItem();
            this.mnuFileLoadOptions = new System.Windows.Forms.MenuItem();
            this.mnuFileSaveOptions = new System.Windows.Forms.MenuItem();
            this.mnuFileSep2 = new System.Windows.Forms.MenuItem();
            this.mnuFileExit = new System.Windows.Forms.MenuItem();
            this.mnuEdit = new System.Windows.Forms.MenuItem();
            this.mnuEditStart = new System.Windows.Forms.MenuItem();
            this.mnuEditIncludeSystemObjects = new System.Windows.Forms.MenuItem();
            this.mnuEditSep1 = new System.Windows.Forms.MenuItem();
            this.mnuEditScriptObjectsThreaded = new System.Windows.Forms.MenuItem();
            this.mnuEditPauseAfterEachDatabase = new System.Windows.Forms.MenuItem();
            this.mnuEditIncludeTimestampInScriptFileHeader = new System.Windows.Forms.MenuItem();
            this.mnuEditSep2 = new System.Windows.Forms.MenuItem();
            this.mnuEditIncludeTableRowCounts = new System.Windows.Forms.MenuItem();
            this.mnuEditAutoSelectDefaultTableNames = new System.Windows.Forms.MenuItem();
            this.mnuEditSep3 = new System.Windows.Forms.MenuItem();
            this.mnuEditWarnOnHighTableRowCount = new System.Windows.Forms.MenuItem();
            this.mnuEditSaveDataAsInsertIntoStatements = new System.Windows.Forms.MenuItem();
            this.mnuEditSep4 = new System.Windows.Forms.MenuItem();
            this.mnuEditResetOptions = new System.Windows.Forms.MenuItem();
            this.fraControls = new System.Windows.Forms.GroupBox();
            this.cmdGo = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            this.cmdAbort = new System.Windows.Forms.Button();
            this.cmdPauseUnpause = new System.Windows.Forms.Button();
            this.txtOutputDirectoryPath = new System.Windows.Forms.TextBox();
            this.fraObjectTypesToScript = new System.Windows.Forms.GroupBox();
            this.fraOutputOptions = new System.Windows.Forms.GroupBox();
            this.chkSkipSchemaExport = new System.Windows.Forms.CheckBox();
            this.chkUsePgInsert = new System.Windows.Forms.CheckBox();
            this.chkUsePgDump = new System.Windows.Forms.CheckBox();
            this.chkCreateDirectoryForEachDB = new System.Windows.Forms.CheckBox();
            this.cmdUpdateTableNames = new System.Windows.Forms.Button();
            this.fraConnectionSettings = new System.Windows.Forms.GroupBox();
            this.chkPostgreSQL = new System.Windows.Forms.CheckBox();
            this.lblServerName = new System.Windows.Forms.Label();
            this.chkUseIntegratedAuthentication = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.fraStatus.SuspendLayout();
            this.fraControls.SuspendLayout();
            this.fraObjectTypesToScript.SuspendLayout();
            this.fraOutputOptions.SuspendLayout();
            this.fraConnectionSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstObjectTypesToScript
            // 
            this.lstObjectTypesToScript.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstObjectTypesToScript.ItemHeight = 19;
            this.lstObjectTypesToScript.Location = new System.Drawing.Point(10, 26);
            this.lstObjectTypesToScript.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstObjectTypesToScript.Name = "lstObjectTypesToScript";
            this.lstObjectTypesToScript.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstObjectTypesToScript.Size = new System.Drawing.Size(280, 175);
            this.lstObjectTypesToScript.TabIndex = 0;
            this.lstObjectTypesToScript.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstObjectTypesToScript_KeyDown);
            this.lstObjectTypesToScript.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lstObjectTypesToScript_KeyPress);
            // 
            // mnuHelp
            // 
            this.mnuHelp.Index = 2;
            this.mnuHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuHelpAbout});
            this.mnuHelp.Text = "&Help";
            // 
            // mnuHelpAbout
            // 
            this.mnuHelpAbout.Index = 0;
            this.mnuHelpAbout.Text = "&About";
            this.mnuHelpAbout.Click += new System.EventHandler(this.mnuHelpAbout_Click);
            // 
            // lblTableDataToExport
            // 
            this.lblTableDataToExport.BackColor = System.Drawing.SystemColors.Control;
            this.lblTableDataToExport.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTableDataToExport.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableDataToExport.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTableDataToExport.Location = new System.Drawing.Point(436, 87);
            this.lblTableDataToExport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTableDataToExport.Name = "lblTableDataToExport";
            this.lblTableDataToExport.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTableDataToExport.Size = new System.Drawing.Size(214, 22);
            this.lblTableDataToExport.TabIndex = 7;
            this.lblTableDataToExport.Text = "Table Data to Export";
            // 
            // lblServerOutputDirectoryNamePrefix
            // 
            this.lblServerOutputDirectoryNamePrefix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblServerOutputDirectoryNamePrefix.BackColor = System.Drawing.SystemColors.Control;
            this.lblServerOutputDirectoryNamePrefix.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblServerOutputDirectoryNamePrefix.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerOutputDirectoryNamePrefix.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblServerOutputDirectoryNamePrefix.Location = new System.Drawing.Point(436, 424);
            this.lblServerOutputDirectoryNamePrefix.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServerOutputDirectoryNamePrefix.Name = "lblServerOutputDirectoryNamePrefix";
            this.lblServerOutputDirectoryNamePrefix.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblServerOutputDirectoryNamePrefix.Size = new System.Drawing.Size(191, 22);
            this.lblServerOutputDirectoryNamePrefix.TabIndex = 17;
            this.lblServerOutputDirectoryNamePrefix.Text = "Output Directory Prefix";
            // 
            // lblProgress
            // 
            this.lblProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProgress.BackColor = System.Drawing.SystemColors.Control;
            this.lblProgress.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblProgress.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgress.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblProgress.Location = new System.Drawing.Point(406, 16);
            this.lblProgress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblProgress.Size = new System.Drawing.Size(780, 33);
            this.lblProgress.TabIndex = 1;
            // 
            // txtServerOutputDirectoryNamePrefix
            // 
            this.txtServerOutputDirectoryNamePrefix.AcceptsReturn = true;
            this.txtServerOutputDirectoryNamePrefix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtServerOutputDirectoryNamePrefix.BackColor = System.Drawing.SystemColors.Window;
            this.txtServerOutputDirectoryNamePrefix.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtServerOutputDirectoryNamePrefix.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServerOutputDirectoryNamePrefix.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtServerOutputDirectoryNamePrefix.Location = new System.Drawing.Point(644, 422);
            this.txtServerOutputDirectoryNamePrefix.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtServerOutputDirectoryNamePrefix.MaxLength = 0;
            this.txtServerOutputDirectoryNamePrefix.Name = "txtServerOutputDirectoryNamePrefix";
            this.txtServerOutputDirectoryNamePrefix.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtServerOutputDirectoryNamePrefix.Size = new System.Drawing.Size(193, 26);
            this.txtServerOutputDirectoryNamePrefix.TabIndex = 18;
            this.txtServerOutputDirectoryNamePrefix.Text = "ServerSchema__";
            // 
            // chkExportServerSettingsLoginsAndJobs
            // 
            this.chkExportServerSettingsLoginsAndJobs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkExportServerSettingsLoginsAndJobs.BackColor = System.Drawing.SystemColors.Control;
            this.chkExportServerSettingsLoginsAndJobs.Checked = true;
            this.chkExportServerSettingsLoginsAndJobs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkExportServerSettingsLoginsAndJobs.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkExportServerSettingsLoginsAndJobs.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkExportServerSettingsLoginsAndJobs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkExportServerSettingsLoginsAndJobs.Location = new System.Drawing.Point(440, 392);
            this.chkExportServerSettingsLoginsAndJobs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkExportServerSettingsLoginsAndJobs.Name = "chkExportServerSettingsLoginsAndJobs";
            this.chkExportServerSettingsLoginsAndJobs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkExportServerSettingsLoginsAndJobs.Size = new System.Drawing.Size(389, 28);
            this.chkExportServerSettingsLoginsAndJobs.TabIndex = 16;
            this.chkExportServerSettingsLoginsAndJobs.Text = "Export server settings, logins, and jobs";
            this.chkExportServerSettingsLoginsAndJobs.UseVisualStyleBackColor = false;
            // 
            // lblSelectDefaultDBs
            // 
            this.lblSelectDefaultDBs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSelectDefaultDBs.BackColor = System.Drawing.SystemColors.Control;
            this.lblSelectDefaultDBs.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSelectDefaultDBs.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectDefaultDBs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSelectDefaultDBs.Location = new System.Drawing.Point(16, 334);
            this.lblSelectDefaultDBs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectDefaultDBs.Name = "lblSelectDefaultDBs";
            this.lblSelectDefaultDBs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSelectDefaultDBs.Size = new System.Drawing.Size(136, 26);
            this.lblSelectDefaultDBs.TabIndex = 15;
            this.lblSelectDefaultDBs.Text = "Select default:";
            // 
            // cmdSelectDefaultDMSDBs
            // 
            this.cmdSelectDefaultDMSDBs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdSelectDefaultDMSDBs.BackColor = System.Drawing.SystemColors.Control;
            this.cmdSelectDefaultDMSDBs.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdSelectDefaultDMSDBs.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSelectDefaultDMSDBs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdSelectDefaultDMSDBs.Location = new System.Drawing.Point(156, 331);
            this.cmdSelectDefaultDMSDBs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdSelectDefaultDMSDBs.Name = "cmdSelectDefaultDMSDBs";
            this.cmdSelectDefaultDMSDBs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdSelectDefaultDMSDBs.Size = new System.Drawing.Size(124, 35);
            this.cmdSelectDefaultDMSDBs.TabIndex = 14;
            this.cmdSelectDefaultDMSDBs.Text = "DMS DBs";
            this.cmdSelectDefaultDMSDBs.UseVisualStyleBackColor = false;
            this.cmdSelectDefaultDMSDBs.Click += new System.EventHandler(this.cmdSelectDefaultDMSDBs_Click);
            // 
            // cmdSelectDefaultMTSDBs
            // 
            this.cmdSelectDefaultMTSDBs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdSelectDefaultMTSDBs.BackColor = System.Drawing.SystemColors.Control;
            this.cmdSelectDefaultMTSDBs.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdSelectDefaultMTSDBs.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSelectDefaultMTSDBs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdSelectDefaultMTSDBs.Location = new System.Drawing.Point(294, 331);
            this.cmdSelectDefaultMTSDBs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdSelectDefaultMTSDBs.Name = "cmdSelectDefaultMTSDBs";
            this.cmdSelectDefaultMTSDBs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdSelectDefaultMTSDBs.Size = new System.Drawing.Size(124, 35);
            this.cmdSelectDefaultMTSDBs.TabIndex = 13;
            this.cmdSelectDefaultMTSDBs.Text = "MTS DBs";
            this.cmdSelectDefaultMTSDBs.UseVisualStyleBackColor = false;
            this.cmdSelectDefaultMTSDBs.Click += new System.EventHandler(this.cmdSelectDefaultMTSDBs_Click);
            // 
            // lblOutputDirectoryNamePrefix
            // 
            this.lblOutputDirectoryNamePrefix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblOutputDirectoryNamePrefix.BackColor = System.Drawing.SystemColors.Control;
            this.lblOutputDirectoryNamePrefix.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblOutputDirectoryNamePrefix.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputDirectoryNamePrefix.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblOutputDirectoryNamePrefix.Location = new System.Drawing.Point(16, 424);
            this.lblOutputDirectoryNamePrefix.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOutputDirectoryNamePrefix.Name = "lblOutputDirectoryNamePrefix";
            this.lblOutputDirectoryNamePrefix.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblOutputDirectoryNamePrefix.Size = new System.Drawing.Size(191, 22);
            this.lblOutputDirectoryNamePrefix.TabIndex = 8;
            this.lblOutputDirectoryNamePrefix.Text = "Output Directory Prefix";
            // 
            // txtOutputDirectoryNamePrefix
            // 
            this.txtOutputDirectoryNamePrefix.AcceptsReturn = true;
            this.txtOutputDirectoryNamePrefix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtOutputDirectoryNamePrefix.BackColor = System.Drawing.SystemColors.Window;
            this.txtOutputDirectoryNamePrefix.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOutputDirectoryNamePrefix.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutputDirectoryNamePrefix.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtOutputDirectoryNamePrefix.Location = new System.Drawing.Point(224, 422);
            this.txtOutputDirectoryNamePrefix.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOutputDirectoryNamePrefix.MaxLength = 0;
            this.txtOutputDirectoryNamePrefix.Name = "txtOutputDirectoryNamePrefix";
            this.txtOutputDirectoryNamePrefix.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtOutputDirectoryNamePrefix.Size = new System.Drawing.Size(193, 26);
            this.txtOutputDirectoryNamePrefix.TabIndex = 9;
            this.txtOutputDirectoryNamePrefix.Text = "DBSchema__";
            // 
            // cboTableNamesToExportSortOrder
            // 
            this.cboTableNamesToExportSortOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboTableNamesToExportSortOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTableNamesToExportSortOrder.FormattingEnabled = true;
            this.cboTableNamesToExportSortOrder.Location = new System.Drawing.Point(442, 331);
            this.cboTableNamesToExportSortOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboTableNamesToExportSortOrder.Name = "cboTableNamesToExportSortOrder";
            this.cboTableNamesToExportSortOrder.Size = new System.Drawing.Size(262, 26);
            this.cboTableNamesToExportSortOrder.TabIndex = 6;
            this.cboTableNamesToExportSortOrder.SelectedIndexChanged += new System.EventHandler(this.cboTableNamesToExportSortOrder_SelectedIndexChanged);
            // 
            // cmdRefreshDBList
            // 
            this.cmdRefreshDBList.BackColor = System.Drawing.SystemColors.Control;
            this.cmdRefreshDBList.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdRefreshDBList.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRefreshDBList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdRefreshDBList.Location = new System.Drawing.Point(10, 82);
            this.cmdRefreshDBList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdRefreshDBList.Name = "cmdRefreshDBList";
            this.cmdRefreshDBList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdRefreshDBList.Size = new System.Drawing.Size(244, 35);
            this.cmdRefreshDBList.TabIndex = 2;
            this.cmdRefreshDBList.Text = "Refresh &Database List";
            this.cmdRefreshDBList.UseVisualStyleBackColor = false;
            this.cmdRefreshDBList.Click += new System.EventHandler(this.cmdRefreshDBList_Click);
            // 
            // lstTableNamesToExportData
            // 
            this.lstTableNamesToExportData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstTableNamesToExportData.ItemHeight = 18;
            this.lstTableNamesToExportData.Location = new System.Drawing.Point(440, 126);
            this.lstTableNamesToExportData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstTableNamesToExportData.Name = "lstTableNamesToExportData";
            this.lstTableNamesToExportData.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstTableNamesToExportData.Size = new System.Drawing.Size(724, 166);
            this.lstTableNamesToExportData.TabIndex = 5;
            this.lstTableNamesToExportData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstTableNamesToExportData_KeyDown);
            this.lstTableNamesToExportData.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lstTableNamesToExportData_KeyPress);
            // 
            // lblOutputDirectoryPath
            // 
            this.lblOutputDirectoryPath.BackColor = System.Drawing.SystemColors.Control;
            this.lblOutputDirectoryPath.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblOutputDirectoryPath.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputDirectoryPath.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblOutputDirectoryPath.Location = new System.Drawing.Point(14, 22);
            this.lblOutputDirectoryPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOutputDirectoryPath.Name = "lblOutputDirectoryPath";
            this.lblOutputDirectoryPath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblOutputDirectoryPath.Size = new System.Drawing.Size(229, 22);
            this.lblOutputDirectoryPath.TabIndex = 0;
            this.lblOutputDirectoryPath.Text = "Output Directory Path";
            // 
            // lstDatabasesToProcess
            // 
            this.lstDatabasesToProcess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstDatabasesToProcess.ItemHeight = 18;
            this.lstDatabasesToProcess.Location = new System.Drawing.Point(16, 126);
            this.lstDatabasesToProcess.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstDatabasesToProcess.Name = "lstDatabasesToProcess";
            this.lstDatabasesToProcess.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstDatabasesToProcess.Size = new System.Drawing.Size(400, 166);
            this.lstDatabasesToProcess.TabIndex = 3;
            this.lstDatabasesToProcess.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstDatabasesToProcess_KeyDown);
            this.lstDatabasesToProcess.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lstDatabasesToProcess_KeyPress);
            // 
            // mnuFileSep1
            // 
            this.mnuFileSep1.Index = 1;
            this.mnuFileSep1.Text = "-";
            // 
            // fraStatus
            // 
            this.fraStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fraStatus.BackColor = System.Drawing.SystemColors.Control;
            this.fraStatus.Controls.Add(this.lblMessage);
            this.fraStatus.Controls.Add(this.lblProgress);
            this.fraStatus.Controls.Add(this.pbarProgress);
            this.fraStatus.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fraStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fraStatus.Location = new System.Drawing.Point(15, 713);
            this.fraStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fraStatus.Name = "fraStatus";
            this.fraStatus.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fraStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fraStatus.Size = new System.Drawing.Size(1202, 100);
            this.fraStatus.TabIndex = 9;
            this.fraStatus.TabStop = false;
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMessage.BackColor = System.Drawing.SystemColors.Control;
            this.lblMessage.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblMessage.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMessage.Location = new System.Drawing.Point(11, 61);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMessage.Size = new System.Drawing.Size(1176, 28);
            this.lblMessage.TabIndex = 3;
            // 
            // pbarProgress
            // 
            this.pbarProgress.Location = new System.Drawing.Point(14, 20);
            this.pbarProgress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbarProgress.Name = "pbarProgress";
            this.pbarProgress.Size = new System.Drawing.Size(376, 28);
            this.pbarProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbarProgress.TabIndex = 0;
            // 
            // MainMenuControl
            // 
            this.MainMenuControl.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuFile,
            this.mnuEdit,
            this.mnuHelp});
            // 
            // mnuFile
            // 
            this.mnuFile.Index = 0;
            this.mnuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuFileSelectOutputDirectory,
            this.mnuFileSep1,
            this.mnuFileLoadOptions,
            this.mnuFileSaveOptions,
            this.mnuFileSep2,
            this.mnuFileExit});
            this.mnuFile.Text = "&File";
            // 
            // mnuFileSelectOutputDirectory
            // 
            this.mnuFileSelectOutputDirectory.Index = 0;
            this.mnuFileSelectOutputDirectory.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
            this.mnuFileSelectOutputDirectory.Text = "Select &Output Directory ...";
            this.mnuFileSelectOutputDirectory.Click += new System.EventHandler(this.mnuFileSelectOutputDirectory_Click);
            // 
            // mnuFileLoadOptions
            // 
            this.mnuFileLoadOptions.Index = 2;
            this.mnuFileLoadOptions.Shortcut = System.Windows.Forms.Shortcut.CtrlL;
            this.mnuFileLoadOptions.Text = "&Load Options ...";
            this.mnuFileLoadOptions.Click += new System.EventHandler(this.mnuFileLoadOptions_Click);
            // 
            // mnuFileSaveOptions
            // 
            this.mnuFileSaveOptions.Index = 3;
            this.mnuFileSaveOptions.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
            this.mnuFileSaveOptions.Text = "&Save Options ...";
            this.mnuFileSaveOptions.Click += new System.EventHandler(this.mnuFileSaveOptions_Click);
            // 
            // mnuFileSep2
            // 
            this.mnuFileSep2.Index = 4;
            this.mnuFileSep2.Text = "-";
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Index = 5;
            this.mnuFileExit.Text = "E&xit";
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
            // 
            // mnuEdit
            // 
            this.mnuEdit.Index = 1;
            this.mnuEdit.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuEditStart,
            this.mnuEditIncludeSystemObjects,
            this.mnuEditSep1,
            this.mnuEditScriptObjectsThreaded,
            this.mnuEditPauseAfterEachDatabase,
            this.mnuEditIncludeTimestampInScriptFileHeader,
            this.mnuEditSep2,
            this.mnuEditIncludeTableRowCounts,
            this.mnuEditAutoSelectDefaultTableNames,
            this.mnuEditSep3,
            this.mnuEditWarnOnHighTableRowCount,
            this.mnuEditSaveDataAsInsertIntoStatements,
            this.mnuEditSep4,
            this.mnuEditResetOptions});
            this.mnuEdit.Text = "&Edit";
            // 
            // mnuEditStart
            // 
            this.mnuEditStart.Index = 0;
            this.mnuEditStart.Shortcut = System.Windows.Forms.Shortcut.CtrlG;
            this.mnuEditStart.Text = "&Export DB Schema";
            this.mnuEditStart.Click += new System.EventHandler(this.mnuEditStart_Click);
            // 
            // mnuEditIncludeSystemObjects
            // 
            this.mnuEditIncludeSystemObjects.Index = 1;
            this.mnuEditIncludeSystemObjects.Text = "Include System &Objects";
            this.mnuEditIncludeSystemObjects.Click += new System.EventHandler(this.mnuEditIncludeSystemObjects_Click);
            // 
            // mnuEditSep1
            // 
            this.mnuEditSep1.Index = 2;
            this.mnuEditSep1.Text = "-";
            // 
            // mnuEditScriptObjectsThreaded
            // 
            this.mnuEditScriptObjectsThreaded.Index = 3;
            this.mnuEditScriptObjectsThreaded.Text = "Script Objects in Separate &Thread";
            this.mnuEditScriptObjectsThreaded.Click += new System.EventHandler(this.mnuEditScriptObjectsThreaded_Click);
            // 
            // mnuEditPauseAfterEachDatabase
            // 
            this.mnuEditPauseAfterEachDatabase.Index = 4;
            this.mnuEditPauseAfterEachDatabase.Text = "&Pause after each Database";
            this.mnuEditPauseAfterEachDatabase.Click += new System.EventHandler(this.mnuEditPauseAfterEachDatabase_Click);
            // 
            // mnuEditIncludeTimestampInScriptFileHeader
            // 
            this.mnuEditIncludeTimestampInScriptFileHeader.Index = 5;
            this.mnuEditIncludeTimestampInScriptFileHeader.Text = "Include Timestamp in Script File Header";
            this.mnuEditIncludeTimestampInScriptFileHeader.Click += new System.EventHandler(this.mnuEditIncludeTimestampInScriptFileHeader_Click);
            // 
            // mnuEditSep2
            // 
            this.mnuEditSep2.Index = 6;
            this.mnuEditSep2.Text = "-";
            // 
            // mnuEditIncludeTableRowCounts
            // 
            this.mnuEditIncludeTableRowCounts.Checked = true;
            this.mnuEditIncludeTableRowCounts.Index = 7;
            this.mnuEditIncludeTableRowCounts.Text = "Obtain Table Row &Counts";
            this.mnuEditIncludeTableRowCounts.Click += new System.EventHandler(this.mnuEditIncludeTableRowCounts_Click);
            // 
            // mnuEditAutoSelectDefaultTableNames
            // 
            this.mnuEditAutoSelectDefaultTableNames.Checked = true;
            this.mnuEditAutoSelectDefaultTableNames.Index = 8;
            this.mnuEditAutoSelectDefaultTableNames.Text = "&Auto-select Default Table Names";
            this.mnuEditAutoSelectDefaultTableNames.Click += new System.EventHandler(this.mnuEditAutoSelectDefaultTableNames_Click);
            // 
            // mnuEditSep3
            // 
            this.mnuEditSep3.Index = 9;
            this.mnuEditSep3.Text = "-";
            // 
            // mnuEditWarnOnHighTableRowCount
            // 
            this.mnuEditWarnOnHighTableRowCount.Checked = true;
            this.mnuEditWarnOnHighTableRowCount.Index = 10;
            this.mnuEditWarnOnHighTableRowCount.Text = "&Warn If High Table Row Count";
            this.mnuEditWarnOnHighTableRowCount.Click += new System.EventHandler(this.mnuEditWarnOnHighTableRowCount_Click);
            // 
            // mnuEditSaveDataAsInsertIntoStatements
            // 
            this.mnuEditSaveDataAsInsertIntoStatements.Checked = true;
            this.mnuEditSaveDataAsInsertIntoStatements.Index = 11;
            this.mnuEditSaveDataAsInsertIntoStatements.Text = "Save Data As &Insert Into Statements";
            this.mnuEditSaveDataAsInsertIntoStatements.Click += new System.EventHandler(this.mnuEditSaveDataAsInsertIntoStatements_Click);
            // 
            // mnuEditSep4
            // 
            this.mnuEditSep4.Index = 12;
            this.mnuEditSep4.Text = "-";
            // 
            // mnuEditResetOptions
            // 
            this.mnuEditResetOptions.Index = 13;
            this.mnuEditResetOptions.Text = "&Reset Options to Defaults";
            this.mnuEditResetOptions.Click += new System.EventHandler(this.mnuEditResetOptions_Click);
            // 
            // fraControls
            // 
            this.fraControls.Controls.Add(this.cmdGo);
            this.fraControls.Controls.Add(this.cmdExit);
            this.fraControls.Controls.Add(this.cmdAbort);
            this.fraControls.Controls.Add(this.cmdPauseUnpause);
            this.fraControls.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fraControls.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fraControls.Location = new System.Drawing.Point(824, 6);
            this.fraControls.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fraControls.Name = "fraControls";
            this.fraControls.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fraControls.Size = new System.Drawing.Size(160, 117);
            this.fraControls.TabIndex = 7;
            this.fraControls.TabStop = false;
            this.fraControls.Text = "Controls";
            // 
            // cmdGo
            // 
            this.cmdGo.BackColor = System.Drawing.SystemColors.Control;
            this.cmdGo.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdGo.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdGo.Location = new System.Drawing.Point(10, 22);
            this.cmdGo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdGo.Name = "cmdGo";
            this.cmdGo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdGo.Size = new System.Drawing.Size(136, 35);
            this.cmdGo.TabIndex = 0;
            this.cmdGo.Text = "&Go";
            this.cmdGo.UseVisualStyleBackColor = false;
            this.cmdGo.Click += new System.EventHandler(this.cmdGo_Click);
            // 
            // cmdExit
            // 
            this.cmdExit.BackColor = System.Drawing.SystemColors.Control;
            this.cmdExit.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdExit.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdExit.Location = new System.Drawing.Point(10, 66);
            this.cmdExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdExit.Size = new System.Drawing.Size(136, 35);
            this.cmdExit.TabIndex = 1;
            this.cmdExit.Text = "E&xit";
            this.cmdExit.UseVisualStyleBackColor = false;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // cmdAbort
            // 
            this.cmdAbort.BackColor = System.Drawing.SystemColors.Control;
            this.cmdAbort.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdAbort.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAbort.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdAbort.Location = new System.Drawing.Point(10, 66);
            this.cmdAbort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdAbort.Name = "cmdAbort";
            this.cmdAbort.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdAbort.Size = new System.Drawing.Size(136, 35);
            this.cmdAbort.TabIndex = 5;
            this.cmdAbort.Text = "&Abort";
            this.cmdAbort.UseVisualStyleBackColor = false;
            this.cmdAbort.Click += new System.EventHandler(this.cmdAbort_Click);
            // 
            // cmdPauseUnpause
            // 
            this.cmdPauseUnpause.BackColor = System.Drawing.SystemColors.Control;
            this.cmdPauseUnpause.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdPauseUnpause.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPauseUnpause.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdPauseUnpause.Location = new System.Drawing.Point(10, 22);
            this.cmdPauseUnpause.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdPauseUnpause.Name = "cmdPauseUnpause";
            this.cmdPauseUnpause.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdPauseUnpause.Size = new System.Drawing.Size(136, 35);
            this.cmdPauseUnpause.TabIndex = 4;
            this.cmdPauseUnpause.Text = "&Pause";
            this.cmdPauseUnpause.UseVisualStyleBackColor = false;
            this.cmdPauseUnpause.Click += new System.EventHandler(this.cmdPauseUnpause_Click);
            // 
            // txtOutputDirectoryPath
            // 
            this.txtOutputDirectoryPath.AcceptsReturn = true;
            this.txtOutputDirectoryPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutputDirectoryPath.BackColor = System.Drawing.SystemColors.Window;
            this.txtOutputDirectoryPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOutputDirectoryPath.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutputDirectoryPath.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtOutputDirectoryPath.Location = new System.Drawing.Point(14, 44);
            this.txtOutputDirectoryPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOutputDirectoryPath.MaxLength = 0;
            this.txtOutputDirectoryPath.Name = "txtOutputDirectoryPath";
            this.txtOutputDirectoryPath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtOutputDirectoryPath.Size = new System.Drawing.Size(1008, 26);
            this.txtOutputDirectoryPath.TabIndex = 1;
            this.txtOutputDirectoryPath.Text = "C:\\Temp\\";
            // 
            // fraObjectTypesToScript
            // 
            this.fraObjectTypesToScript.Controls.Add(this.lstObjectTypesToScript);
            this.fraObjectTypesToScript.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fraObjectTypesToScript.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fraObjectTypesToScript.Location = new System.Drawing.Point(490, 6);
            this.fraObjectTypesToScript.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fraObjectTypesToScript.Name = "fraObjectTypesToScript";
            this.fraObjectTypesToScript.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fraObjectTypesToScript.Size = new System.Drawing.Size(316, 231);
            this.fraObjectTypesToScript.TabIndex = 6;
            this.fraObjectTypesToScript.TabStop = false;
            this.fraObjectTypesToScript.Text = "Objects to Script";
            // 
            // fraOutputOptions
            // 
            this.fraOutputOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fraOutputOptions.BackColor = System.Drawing.SystemColors.Control;
            this.fraOutputOptions.Controls.Add(this.chkSkipSchemaExport);
            this.fraOutputOptions.Controls.Add(this.chkUsePgInsert);
            this.fraOutputOptions.Controls.Add(this.chkUsePgDump);
            this.fraOutputOptions.Controls.Add(this.lblTableDataToExport);
            this.fraOutputOptions.Controls.Add(this.lblServerOutputDirectoryNamePrefix);
            this.fraOutputOptions.Controls.Add(this.txtServerOutputDirectoryNamePrefix);
            this.fraOutputOptions.Controls.Add(this.chkExportServerSettingsLoginsAndJobs);
            this.fraOutputOptions.Controls.Add(this.lblSelectDefaultDBs);
            this.fraOutputOptions.Controls.Add(this.cmdSelectDefaultDMSDBs);
            this.fraOutputOptions.Controls.Add(this.cmdSelectDefaultMTSDBs);
            this.fraOutputOptions.Controls.Add(this.lblOutputDirectoryNamePrefix);
            this.fraOutputOptions.Controls.Add(this.txtOutputDirectoryNamePrefix);
            this.fraOutputOptions.Controls.Add(this.cboTableNamesToExportSortOrder);
            this.fraOutputOptions.Controls.Add(this.cmdRefreshDBList);
            this.fraOutputOptions.Controls.Add(this.chkCreateDirectoryForEachDB);
            this.fraOutputOptions.Controls.Add(this.cmdUpdateTableNames);
            this.fraOutputOptions.Controls.Add(this.lstTableNamesToExportData);
            this.fraOutputOptions.Controls.Add(this.txtOutputDirectoryPath);
            this.fraOutputOptions.Controls.Add(this.lblOutputDirectoryPath);
            this.fraOutputOptions.Controls.Add(this.lstDatabasesToProcess);
            this.fraOutputOptions.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fraOutputOptions.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fraOutputOptions.Location = new System.Drawing.Point(16, 245);
            this.fraOutputOptions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fraOutputOptions.Name = "fraOutputOptions";
            this.fraOutputOptions.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fraOutputOptions.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fraOutputOptions.Size = new System.Drawing.Size(1202, 459);
            this.fraOutputOptions.TabIndex = 8;
            this.fraOutputOptions.TabStop = false;
            this.fraOutputOptions.Text = "Output Options";
            // 
            // chkSkipSchemaExport
            // 
            this.chkSkipSchemaExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkSkipSchemaExport.BackColor = System.Drawing.SystemColors.Control;
            this.chkSkipSchemaExport.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkSkipSchemaExport.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSkipSchemaExport.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkSkipSchemaExport.Location = new System.Drawing.Point(920, 323);
            this.chkSkipSchemaExport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkSkipSchemaExport.Name = "chkSkipSchemaExport";
            this.chkSkipSchemaExport.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkSkipSchemaExport.Size = new System.Drawing.Size(216, 28);
            this.chkSkipSchemaExport.TabIndex = 21;
            this.chkSkipSchemaExport.Text = "Skip schema export";
            this.chkSkipSchemaExport.UseVisualStyleBackColor = false;
            // 
            // chkUsePgInsert
            // 
            this.chkUsePgInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkUsePgInsert.BackColor = System.Drawing.SystemColors.Control;
            this.chkUsePgInsert.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkUsePgInsert.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUsePgInsert.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkUsePgInsert.Location = new System.Drawing.Point(762, 359);
            this.chkUsePgInsert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkUsePgInsert.Name = "chkUsePgInsert";
            this.chkUsePgInsert.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkUsePgInsert.Size = new System.Drawing.Size(149, 28);
            this.chkUsePgInsert.TabIndex = 20;
            this.chkUsePgInsert.Text = "Use PgInsert";
            this.chkUsePgInsert.UseVisualStyleBackColor = false;
            // 
            // chkUsePgDump
            // 
            this.chkUsePgDump.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkUsePgDump.BackColor = System.Drawing.SystemColors.Control;
            this.chkUsePgDump.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkUsePgDump.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUsePgDump.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkUsePgDump.Location = new System.Drawing.Point(762, 323);
            this.chkUsePgDump.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkUsePgDump.Name = "chkUsePgDump";
            this.chkUsePgDump.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkUsePgDump.Size = new System.Drawing.Size(149, 28);
            this.chkUsePgDump.TabIndex = 19;
            this.chkUsePgDump.Text = "Use pg_dump";
            this.chkUsePgDump.UseVisualStyleBackColor = false;
            // 
            // chkCreateDirectoryForEachDB
            // 
            this.chkCreateDirectoryForEachDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkCreateDirectoryForEachDB.BackColor = System.Drawing.SystemColors.Control;
            this.chkCreateDirectoryForEachDB.Checked = true;
            this.chkCreateDirectoryForEachDB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCreateDirectoryForEachDB.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkCreateDirectoryForEachDB.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCreateDirectoryForEachDB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkCreateDirectoryForEachDB.Location = new System.Drawing.Point(18, 392);
            this.chkCreateDirectoryForEachDB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkCreateDirectoryForEachDB.Name = "chkCreateDirectoryForEachDB";
            this.chkCreateDirectoryForEachDB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkCreateDirectoryForEachDB.Size = new System.Drawing.Size(278, 28);
            this.chkCreateDirectoryForEachDB.TabIndex = 7;
            this.chkCreateDirectoryForEachDB.Text = "Create directory for each DB";
            this.chkCreateDirectoryForEachDB.UseVisualStyleBackColor = false;
            // 
            // cmdUpdateTableNames
            // 
            this.cmdUpdateTableNames.BackColor = System.Drawing.SystemColors.Control;
            this.cmdUpdateTableNames.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdUpdateTableNames.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdUpdateTableNames.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdUpdateTableNames.Location = new System.Drawing.Point(686, 79);
            this.cmdUpdateTableNames.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdUpdateTableNames.Name = "cmdUpdateTableNames";
            this.cmdUpdateTableNames.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdUpdateTableNames.Size = new System.Drawing.Size(244, 35);
            this.cmdUpdateTableNames.TabIndex = 4;
            this.cmdUpdateTableNames.Text = "Refresh &Table Names";
            this.cmdUpdateTableNames.UseVisualStyleBackColor = false;
            this.cmdUpdateTableNames.Click += new System.EventHandler(this.cmdUpdateTableNames_Click);
            // 
            // fraConnectionSettings
            // 
            this.fraConnectionSettings.BackColor = System.Drawing.SystemColors.Control;
            this.fraConnectionSettings.Controls.Add(this.chkPostgreSQL);
            this.fraConnectionSettings.Controls.Add(this.lblServerName);
            this.fraConnectionSettings.Controls.Add(this.chkUseIntegratedAuthentication);
            this.fraConnectionSettings.Controls.Add(this.txtPassword);
            this.fraConnectionSettings.Controls.Add(this.txtUsername);
            this.fraConnectionSettings.Controls.Add(this.txtServerName);
            this.fraConnectionSettings.Controls.Add(this.lblPassword);
            this.fraConnectionSettings.Controls.Add(this.lblUsername);
            this.fraConnectionSettings.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fraConnectionSettings.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fraConnectionSettings.Location = new System.Drawing.Point(16, 6);
            this.fraConnectionSettings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fraConnectionSettings.Name = "fraConnectionSettings";
            this.fraConnectionSettings.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fraConnectionSettings.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fraConnectionSettings.Size = new System.Drawing.Size(456, 231);
            this.fraConnectionSettings.TabIndex = 5;
            this.fraConnectionSettings.TabStop = false;
            this.fraConnectionSettings.Text = "Connection Settings";
            // 
            // chkPostgreSQL
            // 
            this.chkPostgreSQL.BackColor = System.Drawing.SystemColors.Control;
            this.chkPostgreSQL.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkPostgreSQL.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPostgreSQL.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkPostgreSQL.Location = new System.Drawing.Point(16, 56);
            this.chkPostgreSQL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkPostgreSQL.Name = "chkPostgreSQL";
            this.chkPostgreSQL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkPostgreSQL.Size = new System.Drawing.Size(226, 28);
            this.chkPostgreSQL.TabIndex = 7;
            this.chkPostgreSQL.Text = "PostgreSQL";
            this.chkPostgreSQL.UseVisualStyleBackColor = false;
            this.chkPostgreSQL.CheckedChanged += new System.EventHandler(this.chkPostgreSQL_CheckedChanged);
            // 
            // lblServerName
            // 
            this.lblServerName.BackColor = System.Drawing.SystemColors.Control;
            this.lblServerName.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblServerName.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblServerName.Location = new System.Drawing.Point(16, 22);
            this.lblServerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblServerName.Size = new System.Drawing.Size(214, 22);
            this.lblServerName.TabIndex = 0;
            this.lblServerName.Text = "Server Name";
            // 
            // chkUseIntegratedAuthentication
            // 
            this.chkUseIntegratedAuthentication.BackColor = System.Drawing.SystemColors.Control;
            this.chkUseIntegratedAuthentication.Checked = true;
            this.chkUseIntegratedAuthentication.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUseIntegratedAuthentication.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkUseIntegratedAuthentication.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUseIntegratedAuthentication.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkUseIntegratedAuthentication.Location = new System.Drawing.Point(10, 161);
            this.chkUseIntegratedAuthentication.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkUseIntegratedAuthentication.Name = "chkUseIntegratedAuthentication";
            this.chkUseIntegratedAuthentication.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkUseIntegratedAuthentication.Size = new System.Drawing.Size(360, 28);
            this.chkUseIntegratedAuthentication.TabIndex = 2;
            this.chkUseIntegratedAuthentication.Text = "Integrated authentication";
            this.chkUseIntegratedAuthentication.UseVisualStyleBackColor = false;
            this.chkUseIntegratedAuthentication.CheckedChanged += new System.EventHandler(this.chkUseIntegratedAuthentication_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.AcceptsReturn = true;
            this.txtPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPassword.Location = new System.Drawing.Point(240, 125);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.MaxLength = 0;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPassword.Size = new System.Drawing.Size(204, 26);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.Text = "mt4fun";
            // 
            // txtUsername
            // 
            this.txtUsername.AcceptsReturn = true;
            this.txtUsername.BackColor = System.Drawing.SystemColors.Window;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtUsername.Location = new System.Drawing.Point(240, 94);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsername.MaxLength = 0;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUsername.Size = new System.Drawing.Size(204, 26);
            this.txtUsername.TabIndex = 4;
            this.txtUsername.Text = "mtuser";
            // 
            // txtServerName
            // 
            this.txtServerName.AcceptsReturn = true;
            this.txtServerName.BackColor = System.Drawing.SystemColors.Window;
            this.txtServerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtServerName.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServerName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtServerName.Location = new System.Drawing.Point(240, 20);
            this.txtServerName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtServerName.MaxLength = 0;
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtServerName.Size = new System.Drawing.Size(204, 26);
            this.txtServerName.TabIndex = 1;
            this.txtServerName.Text = "localhost";
            // 
            // lblPassword
            // 
            this.lblPassword.BackColor = System.Drawing.SystemColors.Control;
            this.lblPassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPassword.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPassword.Location = new System.Drawing.Point(14, 125);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPassword.Size = new System.Drawing.Size(120, 22);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.BackColor = System.Drawing.SystemColors.Control;
            this.lblUsername.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblUsername.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUsername.Location = new System.Drawing.Point(14, 96);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUsername.Size = new System.Drawing.Size(120, 28);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Username";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 828);
            this.Controls.Add(this.fraStatus);
            this.Controls.Add(this.fraControls);
            this.Controls.Add(this.fraObjectTypesToScript);
            this.Controls.Add(this.fraOutputOptions);
            this.Controls.Add(this.fraConnectionSettings);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Menu = this.MainMenuControl;
            this.Name = "frmMain";
            this.Text = "DB Schema Export Tool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.fraStatus.ResumeLayout(false);
            this.fraControls.ResumeLayout(false);
            this.fraObjectTypesToScript.ResumeLayout(false);
            this.fraOutputOptions.ResumeLayout(false);
            this.fraOutputOptions.PerformLayout();
            this.fraConnectionSettings.ResumeLayout(false);
            this.fraConnectionSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal ListBox lstObjectTypesToScript;
        internal MenuItem mnuHelp;
        internal MenuItem mnuHelpAbout;
        internal Label lblTableDataToExport;
        internal Label lblServerOutputDirectoryNamePrefix;
        internal Label lblProgress;
        internal TextBox txtServerOutputDirectoryNamePrefix;
        internal CheckBox chkExportServerSettingsLoginsAndJobs;
        internal Label lblSelectDefaultDBs;
        internal Button cmdSelectDefaultDMSDBs;
        internal Button cmdSelectDefaultMTSDBs;
        internal Label lblOutputDirectoryNamePrefix;
        internal TextBox txtOutputDirectoryNamePrefix;
        internal ComboBox cboTableNamesToExportSortOrder;
        internal Button cmdRefreshDBList;
        internal ListBox lstTableNamesToExportData;
        internal Label lblOutputDirectoryPath;
        internal ListBox lstDatabasesToProcess;
        internal MenuItem mnuFileSep1;
        internal GroupBox fraStatus;
        internal ProgressBar pbarProgress;
        internal MainMenu MainMenuControl;
        internal MenuItem mnuFile;
        internal MenuItem mnuFileSelectOutputDirectory;
        internal MenuItem mnuFileLoadOptions;
        internal MenuItem mnuFileSaveOptions;
        internal MenuItem mnuFileSep2;
        internal MenuItem mnuFileExit;
        internal MenuItem mnuEdit;
        internal MenuItem mnuEditStart;
        internal MenuItem mnuEditIncludeSystemObjects;
        internal MenuItem mnuEditSep1;
        internal MenuItem mnuEditScriptObjectsThreaded;
        internal MenuItem mnuEditPauseAfterEachDatabase;
        internal MenuItem mnuEditIncludeTimestampInScriptFileHeader;
        internal MenuItem mnuEditSep2;
        internal MenuItem mnuEditIncludeTableRowCounts;
        internal MenuItem mnuEditAutoSelectDefaultTableNames;
        internal MenuItem mnuEditSep3;
        internal MenuItem mnuEditWarnOnHighTableRowCount;
        internal MenuItem mnuEditSaveDataAsInsertIntoStatements;
        internal MenuItem mnuEditSep4;
        internal MenuItem mnuEditResetOptions;
        internal GroupBox fraControls;
        internal Button cmdGo;
        internal Button cmdExit;
        internal Button cmdAbort;
        internal Button cmdPauseUnpause;
        internal TextBox txtOutputDirectoryPath;
        internal GroupBox fraObjectTypesToScript;
        internal GroupBox fraOutputOptions;
        internal CheckBox chkCreateDirectoryForEachDB;
        internal Button cmdUpdateTableNames;
        internal GroupBox fraConnectionSettings;
        internal CheckBox chkPostgreSQL;
        internal Label lblServerName;
        internal CheckBox chkUseIntegratedAuthentication;
        internal TextBox txtPassword;
        internal TextBox txtUsername;
        internal TextBox txtServerName;
        internal Label lblPassword;
        internal Label lblUsername;
        internal Label lblMessage;
        internal CheckBox chkUsePgInsert;
        internal CheckBox chkUsePgDump;
        internal CheckBox chkSkipSchemaExport;
    }
}

