#region License Information (GPL v3)

/*
    ShareX - A program that allows you to take screenshots and share any file type
    Copyright (c) 2007-2018 ShareX Team

    This program is free software; you can redistribute it and/or
    modify it under the terms of the GNU General Public License
    as published by the Free Software Foundation; either version 2
    of the License, or (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program; if not, write to the Free Software
    Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.

    Optionally you can also view the license at <http://www.gnu.org/licenses/>.
*/

#endregion License Information (GPL v3)
namespace ShareX.UploadersLib
{
    partial class UploadersConfigForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UploadersConfigForm));
            this.txtRapidSharePremiumUserName = new System.Windows.Forms.TextBox();
            this.ttHelpTip = new System.Windows.Forms.ToolTip(this.components);
            this.mbCustomUploaderDestinationType = new ShareX.HelpersLib.MenuButton();
            this.cmsCustomUploaderDestinationType = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tpOtherUploaders = new System.Windows.Forms.TabPage();
            this.tcOtherUploaders = new System.Windows.Forms.TabControl();
            this.tpCustomUploaders = new System.Windows.Forms.TabPage();
            this.btnCustomUploaderURLSharingServiceTest = new System.Windows.Forms.Button();
            this.cbCustomUploaderURLSharingService = new System.Windows.Forms.ComboBox();
            this.lblCustomUploaderURLSharingService = new System.Windows.Forms.Label();
            this.pCustomUploader = new System.Windows.Forms.Panel();
            this.lblCustomUploaderName = new System.Windows.Forms.Label();
            this.cbCustomUploaderRequestType = new System.Windows.Forms.ComboBox();
            this.tcCustomUploaderResponseParse = new System.Windows.Forms.TabControl();
            this.tpCustomUploaderJsonParse = new System.Windows.Forms.TabPage();
            this.btnCustomUploaderJsonAddSyntax = new System.Windows.Forms.Button();
            this.btnCustomUploadJsonPathHelp = new System.Windows.Forms.Button();
            this.lblCustomUploaderJsonPathExample = new System.Windows.Forms.Label();
            this.lblCustomUploaderJsonPath = new System.Windows.Forms.Label();
            this.txtCustomUploaderJsonPath = new System.Windows.Forms.TextBox();
            this.tpCustomUploaderXmlParse = new System.Windows.Forms.TabPage();
            this.btnCustomUploaderXmlSyntaxAdd = new System.Windows.Forms.Button();
            this.btnCustomUploaderXPathHelp = new System.Windows.Forms.Button();
            this.lblCustomUploaderXPathExample = new System.Windows.Forms.Label();
            this.lblCustomUploaderXPath = new System.Windows.Forms.Label();
            this.txtCustomUploaderXPath = new System.Windows.Forms.TextBox();
            this.tpCustomUploaderRegexParse = new System.Windows.Forms.TabPage();
            this.btnCustomUploaderRegexHelp = new System.Windows.Forms.Button();
            this.btnCustomUploaderRegexAddSyntax = new System.Windows.Forms.Button();
            this.txtCustomUploaderRegexp = new System.Windows.Forms.TextBox();
            this.btnCustomUploaderRegexpUpdate = new System.Windows.Forms.Button();
            this.btnCustomUploaderRegexpAdd = new System.Windows.Forms.Button();
            this.btnCustomUploaderRegexpRemove = new System.Windows.Forms.Button();
            this.lvCustomUploaderRegexps = new ShareX.HelpersLib.MyListView();
            this.lvRegexpsColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblCustomUploaderURL = new System.Windows.Forms.Label();
            this.tcCustomUploaderArguments = new System.Windows.Forms.TabControl();
            this.tpCustomUploaderArguments = new System.Windows.Forms.TabPage();
            this.btnCustomUploaderArgUpdate = new System.Windows.Forms.Button();
            this.txtCustomUploaderArgName = new System.Windows.Forms.TextBox();
            this.txtCustomUploaderArgValue = new System.Windows.Forms.TextBox();
            this.btnCustomUploaderArgAdd = new System.Windows.Forms.Button();
            this.btnCustomUploaderArgRemove = new System.Windows.Forms.Button();
            this.lvCustomUploaderArguments = new ShareX.HelpersLib.MyListView();
            this.chCustomUploaderArgumentsName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCustomUploaderArgumentsValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpCustomUploaderHeaders = new System.Windows.Forms.TabPage();
            this.btnCustomUploaderHeaderUpdate = new System.Windows.Forms.Button();
            this.txtCustomUploaderHeaderName = new System.Windows.Forms.TextBox();
            this.txtCustomUploaderHeaderValue = new System.Windows.Forms.TextBox();
            this.btnCustomUploaderHeaderAdd = new System.Windows.Forms.Button();
            this.btnCustomUploaderHeaderRemove = new System.Windows.Forms.Button();
            this.lvCustomUploaderHeaders = new ShareX.HelpersLib.MyListView();
            this.chCustomUploaderHeadersName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCustomUploaderHeadersValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtCustomUploaderFileForm = new System.Windows.Forms.TextBox();
            this.lblCustomUploaderRequestType = new System.Windows.Forms.Label();
            this.lblCustomUploaderFileForm = new System.Windows.Forms.Label();
            this.txtCustomUploaderName = new System.Windows.Forms.TextBox();
            this.lblCustomUploaderThumbnailURL = new System.Windows.Forms.Label();
            this.txtCustomUploaderRequestURL = new System.Windows.Forms.TextBox();
            this.txtCustomUploaderURL = new System.Windows.Forms.TextBox();
            this.cbCustomUploaderResponseType = new System.Windows.Forms.ComboBox();
            this.txtCustomUploaderThumbnailURL = new System.Windows.Forms.TextBox();
            this.txtCustomUploaderDeletionURL = new System.Windows.Forms.TextBox();
            this.lblCustomUploaderRequestURL = new System.Windows.Forms.Label();
            this.lblCustomUploaderResponseType = new System.Windows.Forms.Label();
            this.lblCustomUploaderDeletionURL = new System.Windows.Forms.Label();
            this.btnCustomUploaderExamples = new System.Windows.Forms.Button();
            this.btnCustomUploaderHelp = new System.Windows.Forms.Button();
            this.lblCustomUploaderImageUploader = new System.Windows.Forms.Label();
            this.btnCustomUploaderFileUploaderTest = new System.Windows.Forms.Button();
            this.lblCustomUploaderFileUploader = new System.Windows.Forms.Label();
            this.btnCustomUploaderImageUploaderTest = new System.Windows.Forms.Button();
            this.lblCustomUploaderTestResult = new System.Windows.Forms.Label();
            this.cbCustomUploaderFileUploader = new System.Windows.Forms.ComboBox();
            this.btnCustomUploaderShowLastResponse = new System.Windows.Forms.Button();
            this.cbCustomUploaderURLShortener = new System.Windows.Forms.ComboBox();
            this.gbCustomUploaders = new System.Windows.Forms.GroupBox();
            this.btnCustomUploaderDuplicate = new System.Windows.Forms.Button();
            this.btnCustomUploadersExportAll = new System.Windows.Forms.Button();
            this.btnCustomUploaderClearUploaders = new System.Windows.Forms.Button();
            this.eiCustomUploaders = new ShareX.HelpersLib.ExportImportControl();
            this.lbCustomUploaderList = new System.Windows.Forms.ListBox();
            this.btnCustomUploaderRemove = new System.Windows.Forms.Button();
            this.btnCustomUploaderAdd = new System.Windows.Forms.Button();
            this.lblCustomUploaderTextUploader = new System.Windows.Forms.Label();
            this.btnCustomUploaderURLShortenerTest = new System.Windows.Forms.Button();
            this.cbCustomUploaderTextUploader = new System.Windows.Forms.ComboBox();
            this.lblCustomUploaderURLShortener = new System.Windows.Forms.Label();
            this.btnCustomUploaderTextUploaderTest = new System.Windows.Forms.Button();
            this.cbCustomUploaderImageUploader = new System.Windows.Forms.ComboBox();
            this.txtCustomUploaderLog = new System.Windows.Forms.RichTextBox();
            this.tpURLShorteners = new System.Windows.Forms.TabPage();
            this.tcURLShorteners = new System.Windows.Forms.TabControl();
            this.tpFileUploaders = new System.Windows.Forms.TabPage();
            this.tcFileUploaders = new System.Windows.Forms.TabControl();
            this.tpFTP = new System.Windows.Forms.TabPage();
            this.gbFTPAccount = new System.Windows.Forms.GroupBox();
            this.gbSFTP = new System.Windows.Forms.GroupBox();
            this.txtSFTPKeyPassphrase = new System.Windows.Forms.TextBox();
            this.btnSFTPKeyLocationBrowse = new System.Windows.Forms.Button();
            this.lblSFTPKeyPassphrase = new System.Windows.Forms.Label();
            this.txtSFTPKeyLocation = new System.Windows.Forms.TextBox();
            this.lblSFTPKeyLocation = new System.Windows.Forms.Label();
            this.cbFTPAppendRemoteDirectory = new System.Windows.Forms.CheckBox();
            this.btnFTPTest = new System.Windows.Forms.Button();
            this.lblFTPProtocol = new System.Windows.Forms.Label();
            this.lblFTPName = new System.Windows.Forms.Label();
            this.cbFTPRemoveFileExtension = new System.Windows.Forms.CheckBox();
            this.txtFTPName = new System.Windows.Forms.TextBox();
            this.lblFTPHost = new System.Windows.Forms.Label();
            this.eiFTP = new ShareX.HelpersLib.ExportImportControl();
            this.pFTPTransferMode = new System.Windows.Forms.Panel();
            this.rbFTPTransferModeActive = new System.Windows.Forms.RadioButton();
            this.rbFTPTransferModePassive = new System.Windows.Forms.RadioButton();
            this.btnFTPClient = new System.Windows.Forms.Button();
            this.txtFTPHost = new System.Windows.Forms.TextBox();
            this.pFTPProtocol = new System.Windows.Forms.Panel();
            this.rbFTPProtocolFTP = new System.Windows.Forms.RadioButton();
            this.rbFTPProtocolFTPS = new System.Windows.Forms.RadioButton();
            this.rbFTPProtocolSFTP = new System.Windows.Forms.RadioButton();
            this.lblFTPPort = new System.Windows.Forms.Label();
            this.lblFTPTransferMode = new System.Windows.Forms.Label();
            this.nudFTPPort = new System.Windows.Forms.NumericUpDown();
            this.lblFTPURLPreviewValue = new System.Windows.Forms.Label();
            this.lblFTPUsername = new System.Windows.Forms.Label();
            this.lblFTPURLPreview = new System.Windows.Forms.Label();
            this.txtFTPUsername = new System.Windows.Forms.TextBox();
            this.cbFTPURLPathProtocol = new System.Windows.Forms.ComboBox();
            this.lblFTPPassword = new System.Windows.Forms.Label();
            this.txtFTPURLPath = new System.Windows.Forms.TextBox();
            this.txtFTPPassword = new System.Windows.Forms.TextBox();
            this.lblFTPURLPath = new System.Windows.Forms.Label();
            this.lblFTPRemoteDirectory = new System.Windows.Forms.Label();
            this.txtFTPRemoteDirectory = new System.Windows.Forms.TextBox();
            this.gbFTPS = new System.Windows.Forms.GroupBox();
            this.btnFTPSCertificateLocationBrowse = new System.Windows.Forms.Button();
            this.txtFTPSCertificateLocation = new System.Windows.Forms.TextBox();
            this.lblFTPSCertificateLocation = new System.Windows.Forms.Label();
            this.cbFTPSEncryption = new System.Windows.Forms.ComboBox();
            this.lblFTPSEncryption = new System.Windows.Forms.Label();
            this.btnFTPDuplicate = new System.Windows.Forms.Button();
            this.btnFTPRemove = new System.Windows.Forms.Button();
            this.btnFTPAdd = new System.Windows.Forms.Button();
            this.cbFTPAccounts = new System.Windows.Forms.ComboBox();
            this.lblFTPAccounts = new System.Windows.Forms.Label();
            this.lblFTPFile = new System.Windows.Forms.Label();
            this.lblFTPText = new System.Windows.Forms.Label();
            this.lblFTPImage = new System.Windows.Forms.Label();
            this.cbFTPImage = new System.Windows.Forms.ComboBox();
            this.cbFTPFile = new System.Windows.Forms.ComboBox();
            this.cbFTPText = new System.Windows.Forms.ComboBox();
            this.tpJira = new System.Windows.Forms.TabPage();
            this.txtJiraIssuePrefix = new System.Windows.Forms.TextBox();
            this.lblJiraIssuePrefix = new System.Windows.Forms.Label();
            this.gbJiraServer = new System.Windows.Forms.GroupBox();
            this.txtJiraConfigHelp = new System.Windows.Forms.TextBox();
            this.txtJiraHost = new System.Windows.Forms.TextBox();
            this.lblJiraHost = new System.Windows.Forms.Label();
            this.oAuthJira = new ShareX.UploadersLib.OAuthControl();
            this.tpSeafile = new System.Windows.Forms.TabPage();
            this.cbSeafileAPIURL = new System.Windows.Forms.ComboBox();
            this.grpSeafileShareSettings = new System.Windows.Forms.GroupBox();
            this.txtSeafileSharePassword = new System.Windows.Forms.TextBox();
            this.lblSeafileSharePassword = new System.Windows.Forms.Label();
            this.nudSeafileExpireDays = new System.Windows.Forms.NumericUpDown();
            this.lblSeafileDaysToExpire = new System.Windows.Forms.Label();
            this.btnSeafileLibraryPasswordValidate = new System.Windows.Forms.Button();
            this.txtSeafileLibraryPassword = new System.Windows.Forms.TextBox();
            this.lblSeafileLibraryPassword = new System.Windows.Forms.Label();
            this.lvSeafileLibraries = new ShareX.HelpersLib.MyListView();
            this.colSeafileLibraryName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSeafileLibrarySize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSeafileLibraryEncrypted = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSeafilePathValidate = new System.Windows.Forms.Button();
            this.txtSeafileDirectoryPath = new System.Windows.Forms.TextBox();
            this.lblSeafileWritePermNotif = new System.Windows.Forms.Label();
            this.lblSeafilePath = new System.Windows.Forms.Label();
            this.txtSeafileUploadLocationRefresh = new System.Windows.Forms.Button();
            this.lblSeafileSelectLibrary = new System.Windows.Forms.Label();
            this.grpSeafileAccInfo = new System.Windows.Forms.GroupBox();
            this.btnRefreshSeafileAccInfo = new System.Windows.Forms.Button();
            this.txtSeafileAccInfoUsage = new System.Windows.Forms.TextBox();
            this.txtSeafileAccInfoEmail = new System.Windows.Forms.TextBox();
            this.lblSeafileAccInfoEmail = new System.Windows.Forms.Label();
            this.lblSeafileAccInfoUsage = new System.Windows.Forms.Label();
            this.btnSeafileCheckAuthToken = new System.Windows.Forms.Button();
            this.btnSeafileCheckAPIURL = new System.Windows.Forms.Button();
            this.grpSeafileObtainAuthToken = new System.Windows.Forms.GroupBox();
            this.btnSeafileGetAuthToken = new System.Windows.Forms.Button();
            this.txtSeafilePassword = new System.Windows.Forms.TextBox();
            this.txtSeafileUsername = new System.Windows.Forms.TextBox();
            this.lblSeafileUsername = new System.Windows.Forms.Label();
            this.lblSeafilePassword = new System.Windows.Forms.Label();
            this.cbSeafileIgnoreInvalidCert = new System.Windows.Forms.CheckBox();
            this.cbSeafileCreateShareableURL = new System.Windows.Forms.CheckBox();
            this.txtSeafileAuthToken = new System.Windows.Forms.TextBox();
            this.lblSeafileAuthToken = new System.Windows.Forms.Label();
            this.lblSeafileAPIURL = new System.Windows.Forms.Label();
            this.tpSharedFolder = new System.Windows.Forms.TabPage();
            this.lbSharedFolderAccounts = new System.Windows.Forms.ListBox();
            this.pgSharedFolderAccount = new System.Windows.Forms.PropertyGrid();
            this.btnSharedFolderDuplicate = new System.Windows.Forms.Button();
            this.btnSharedFolderRemove = new System.Windows.Forms.Button();
            this.btnSharedFolderAdd = new System.Windows.Forms.Button();
            this.lblSharedFolderFiles = new System.Windows.Forms.Label();
            this.lblSharedFolderText = new System.Windows.Forms.Label();
            this.cboSharedFolderFiles = new System.Windows.Forms.ComboBox();
            this.lblSharedFolderImages = new System.Windows.Forms.Label();
            this.cboSharedFolderText = new System.Windows.Forms.ComboBox();
            this.cboSharedFolderImages = new System.Windows.Forms.ComboBox();
            this.tpEmail = new System.Windows.Forms.TabPage();
            this.txtEmailAutomaticSendTo = new System.Windows.Forms.TextBox();
            this.cbEmailAutomaticSend = new System.Windows.Forms.CheckBox();
            this.lblEmailSmtpServer = new System.Windows.Forms.Label();
            this.lblEmailPassword = new System.Windows.Forms.Label();
            this.cbEmailRememberLastTo = new System.Windows.Forms.CheckBox();
            this.txtEmailFrom = new System.Windows.Forms.TextBox();
            this.txtEmailPassword = new System.Windows.Forms.TextBox();
            this.txtEmailDefaultBody = new System.Windows.Forms.TextBox();
            this.lblEmailFrom = new System.Windows.Forms.Label();
            this.txtEmailSmtpServer = new System.Windows.Forms.TextBox();
            this.lblEmailDefaultSubject = new System.Windows.Forms.Label();
            this.lblEmailDefaultBody = new System.Windows.Forms.Label();
            this.nudEmailSmtpPort = new System.Windows.Forms.NumericUpDown();
            this.lblEmailSmtpPort = new System.Windows.Forms.Label();
            this.txtEmailDefaultSubject = new System.Windows.Forms.TextBox();
            this.btnCopyShowFiles = new System.Windows.Forms.Button();
            this.tpTextUploaders = new System.Windows.Forms.TabPage();
            this.tcTextUploaders = new System.Windows.Forms.TabControl();
            this.tpImageUploaders = new System.Windows.Forms.TabPage();
            this.tcImageUploaders = new System.Windows.Forms.TabControl();
            this.tcUploaders = new System.Windows.Forms.TabControl();
            this.lblWidthHint = new System.Windows.Forms.Label();
            this.ttlvMain = new ShareX.HelpersLib.TabToListView();
            this.actRapidShareAccountType = new ShareX.UploadersLib.AccountTypeControl();
            this.tpOtherUploaders.SuspendLayout();
            this.tcOtherUploaders.SuspendLayout();
            this.tpCustomUploaders.SuspendLayout();
            this.pCustomUploader.SuspendLayout();
            this.tcCustomUploaderResponseParse.SuspendLayout();
            this.tpCustomUploaderJsonParse.SuspendLayout();
            this.tpCustomUploaderXmlParse.SuspendLayout();
            this.tpCustomUploaderRegexParse.SuspendLayout();
            this.tcCustomUploaderArguments.SuspendLayout();
            this.tpCustomUploaderArguments.SuspendLayout();
            this.tpCustomUploaderHeaders.SuspendLayout();
            this.gbCustomUploaders.SuspendLayout();
            this.tpURLShorteners.SuspendLayout();
            this.tcURLShorteners.SuspendLayout();
            this.tpFileUploaders.SuspendLayout();
            this.tcFileUploaders.SuspendLayout();
            this.tpFTP.SuspendLayout();
            this.gbFTPAccount.SuspendLayout();
            this.gbSFTP.SuspendLayout();
            this.pFTPTransferMode.SuspendLayout();
            this.pFTPProtocol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFTPPort)).BeginInit();
            this.gbFTPS.SuspendLayout();
            this.tpJira.SuspendLayout();
            this.gbJiraServer.SuspendLayout();
            this.tpSeafile.SuspendLayout();
            this.grpSeafileShareSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeafileExpireDays)).BeginInit();
            this.grpSeafileAccInfo.SuspendLayout();
            this.grpSeafileObtainAuthToken.SuspendLayout();
            this.tpSharedFolder.SuspendLayout();
            this.tpEmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEmailSmtpPort)).BeginInit();
            this.tpTextUploaders.SuspendLayout();
            this.tcTextUploaders.SuspendLayout();
            this.tcUploaders.SuspendLayout();
            this.SuspendLayout();
            // 
            // ttHelpTip
            // 
            this.ttHelpTip.AutomaticDelay = 0;
            this.ttHelpTip.AutoPopDelay = 30000;
            this.ttHelpTip.BackColor = System.Drawing.SystemColors.Window;
            this.ttHelpTip.InitialDelay = 500;
            this.ttHelpTip.IsBalloon = true;
            this.ttHelpTip.ReshowDelay = 100;
            this.ttHelpTip.UseAnimation = false;
            this.ttHelpTip.UseFading = false;
            // 
            // mbCustomUploaderDestinationType
            // 
            resources.ApplyResources(this.mbCustomUploaderDestinationType, "mbCustomUploaderDestinationType");
            this.mbCustomUploaderDestinationType.Menu = this.cmsCustomUploaderDestinationType;
            this.mbCustomUploaderDestinationType.Name = "mbCustomUploaderDestinationType";
            this.ttHelpTip.SetToolTip(this.mbCustomUploaderDestinationType, resources.GetString("mbCustomUploaderDestinationType.ToolTip"));
            this.mbCustomUploaderDestinationType.UseVisualStyleBackColor = true;
            // 
            // cmsCustomUploaderDestinationType
            // 
            this.cmsCustomUploaderDestinationType.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsCustomUploaderDestinationType.Name = "cmsCustomUploaderDestinationType";
            resources.ApplyResources(this.cmsCustomUploaderDestinationType, "cmsCustomUploaderDestinationType");
            // 
            // tpOtherUploaders
            // 
            this.tpOtherUploaders.BackColor = System.Drawing.SystemColors.Window;
            this.tpOtherUploaders.Controls.Add(this.tcOtherUploaders);
            resources.ApplyResources(this.tpOtherUploaders, "tpOtherUploaders");
            this.tpOtherUploaders.Name = "tpOtherUploaders";
            // 
            // tcOtherUploaders
            // 
            this.tcOtherUploaders.Controls.Add(this.tpCustomUploaders);
            resources.ApplyResources(this.tcOtherUploaders, "tcOtherUploaders");
            this.tcOtherUploaders.Name = "tcOtherUploaders";
            this.tcOtherUploaders.SelectedIndex = 0;
            // 
            // tpCustomUploaders
            // 
            this.tpCustomUploaders.BackColor = System.Drawing.SystemColors.Window;
            this.tpCustomUploaders.Controls.Add(this.btnCustomUploaderURLSharingServiceTest);
            this.tpCustomUploaders.Controls.Add(this.cbCustomUploaderURLSharingService);
            this.tpCustomUploaders.Controls.Add(this.lblCustomUploaderURLSharingService);
            this.tpCustomUploaders.Controls.Add(this.pCustomUploader);
            this.tpCustomUploaders.Controls.Add(this.btnCustomUploaderExamples);
            this.tpCustomUploaders.Controls.Add(this.btnCustomUploaderHelp);
            this.tpCustomUploaders.Controls.Add(this.lblCustomUploaderImageUploader);
            this.tpCustomUploaders.Controls.Add(this.btnCustomUploaderFileUploaderTest);
            this.tpCustomUploaders.Controls.Add(this.lblCustomUploaderFileUploader);
            this.tpCustomUploaders.Controls.Add(this.btnCustomUploaderImageUploaderTest);
            this.tpCustomUploaders.Controls.Add(this.lblCustomUploaderTestResult);
            this.tpCustomUploaders.Controls.Add(this.cbCustomUploaderFileUploader);
            this.tpCustomUploaders.Controls.Add(this.btnCustomUploaderShowLastResponse);
            this.tpCustomUploaders.Controls.Add(this.cbCustomUploaderURLShortener);
            this.tpCustomUploaders.Controls.Add(this.gbCustomUploaders);
            this.tpCustomUploaders.Controls.Add(this.lblCustomUploaderTextUploader);
            this.tpCustomUploaders.Controls.Add(this.btnCustomUploaderURLShortenerTest);
            this.tpCustomUploaders.Controls.Add(this.cbCustomUploaderTextUploader);
            this.tpCustomUploaders.Controls.Add(this.lblCustomUploaderURLShortener);
            this.tpCustomUploaders.Controls.Add(this.btnCustomUploaderTextUploaderTest);
            this.tpCustomUploaders.Controls.Add(this.cbCustomUploaderImageUploader);
            this.tpCustomUploaders.Controls.Add(this.txtCustomUploaderLog);
            resources.ApplyResources(this.tpCustomUploaders, "tpCustomUploaders");
            this.tpCustomUploaders.Name = "tpCustomUploaders";
            // 
            // btnCustomUploaderURLSharingServiceTest
            // 
            resources.ApplyResources(this.btnCustomUploaderURLSharingServiceTest, "btnCustomUploaderURLSharingServiceTest");
            this.btnCustomUploaderURLSharingServiceTest.Name = "btnCustomUploaderURLSharingServiceTest";
            this.btnCustomUploaderURLSharingServiceTest.UseVisualStyleBackColor = true;
            this.btnCustomUploaderURLSharingServiceTest.Click += new System.EventHandler(this.btnCustomUploaderURLSharingServiceTest_Click);
            // 
            // cbCustomUploaderURLSharingService
            // 
            this.cbCustomUploaderURLSharingService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCustomUploaderURLSharingService.FormattingEnabled = true;
            resources.ApplyResources(this.cbCustomUploaderURLSharingService, "cbCustomUploaderURLSharingService");
            this.cbCustomUploaderURLSharingService.Name = "cbCustomUploaderURLSharingService";
            this.cbCustomUploaderURLSharingService.SelectedIndexChanged += new System.EventHandler(this.cbCustomUploaderURLSharingService_SelectedIndexChanged);
            // 
            // lblCustomUploaderURLSharingService
            // 
            resources.ApplyResources(this.lblCustomUploaderURLSharingService, "lblCustomUploaderURLSharingService");
            this.lblCustomUploaderURLSharingService.Name = "lblCustomUploaderURLSharingService";
            // 
            // pCustomUploader
            // 
            this.pCustomUploader.Controls.Add(this.lblCustomUploaderName);
            this.pCustomUploader.Controls.Add(this.mbCustomUploaderDestinationType);
            this.pCustomUploader.Controls.Add(this.cbCustomUploaderRequestType);
            this.pCustomUploader.Controls.Add(this.tcCustomUploaderResponseParse);
            this.pCustomUploader.Controls.Add(this.lblCustomUploaderURL);
            this.pCustomUploader.Controls.Add(this.tcCustomUploaderArguments);
            this.pCustomUploader.Controls.Add(this.txtCustomUploaderFileForm);
            this.pCustomUploader.Controls.Add(this.lblCustomUploaderRequestType);
            this.pCustomUploader.Controls.Add(this.lblCustomUploaderFileForm);
            this.pCustomUploader.Controls.Add(this.txtCustomUploaderName);
            this.pCustomUploader.Controls.Add(this.lblCustomUploaderThumbnailURL);
            this.pCustomUploader.Controls.Add(this.txtCustomUploaderRequestURL);
            this.pCustomUploader.Controls.Add(this.txtCustomUploaderURL);
            this.pCustomUploader.Controls.Add(this.cbCustomUploaderResponseType);
            this.pCustomUploader.Controls.Add(this.txtCustomUploaderThumbnailURL);
            this.pCustomUploader.Controls.Add(this.txtCustomUploaderDeletionURL);
            this.pCustomUploader.Controls.Add(this.lblCustomUploaderRequestURL);
            this.pCustomUploader.Controls.Add(this.lblCustomUploaderResponseType);
            this.pCustomUploader.Controls.Add(this.lblCustomUploaderDeletionURL);
            resources.ApplyResources(this.pCustomUploader, "pCustomUploader");
            this.pCustomUploader.Name = "pCustomUploader";
            // 
            // lblCustomUploaderName
            // 
            resources.ApplyResources(this.lblCustomUploaderName, "lblCustomUploaderName");
            this.lblCustomUploaderName.Name = "lblCustomUploaderName";
            // 
            // cbCustomUploaderRequestType
            // 
            this.cbCustomUploaderRequestType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCustomUploaderRequestType.FormattingEnabled = true;
            resources.ApplyResources(this.cbCustomUploaderRequestType, "cbCustomUploaderRequestType");
            this.cbCustomUploaderRequestType.Name = "cbCustomUploaderRequestType";
            this.cbCustomUploaderRequestType.SelectedIndexChanged += new System.EventHandler(this.cbCustomUploaderRequestType_SelectedIndexChanged);
            // 
            // tcCustomUploaderResponseParse
            // 
            this.tcCustomUploaderResponseParse.Controls.Add(this.tpCustomUploaderJsonParse);
            this.tcCustomUploaderResponseParse.Controls.Add(this.tpCustomUploaderXmlParse);
            this.tcCustomUploaderResponseParse.Controls.Add(this.tpCustomUploaderRegexParse);
            resources.ApplyResources(this.tcCustomUploaderResponseParse, "tcCustomUploaderResponseParse");
            this.tcCustomUploaderResponseParse.Name = "tcCustomUploaderResponseParse";
            this.tcCustomUploaderResponseParse.SelectedIndex = 0;
            // 
            // tpCustomUploaderJsonParse
            // 
            this.tpCustomUploaderJsonParse.Controls.Add(this.btnCustomUploaderJsonAddSyntax);
            this.tpCustomUploaderJsonParse.Controls.Add(this.btnCustomUploadJsonPathHelp);
            this.tpCustomUploaderJsonParse.Controls.Add(this.lblCustomUploaderJsonPathExample);
            this.tpCustomUploaderJsonParse.Controls.Add(this.lblCustomUploaderJsonPath);
            this.tpCustomUploaderJsonParse.Controls.Add(this.txtCustomUploaderJsonPath);
            resources.ApplyResources(this.tpCustomUploaderJsonParse, "tpCustomUploaderJsonParse");
            this.tpCustomUploaderJsonParse.Name = "tpCustomUploaderJsonParse";
            this.tpCustomUploaderJsonParse.UseVisualStyleBackColor = true;
            // 
            // btnCustomUploaderJsonAddSyntax
            // 
            resources.ApplyResources(this.btnCustomUploaderJsonAddSyntax, "btnCustomUploaderJsonAddSyntax");
            this.btnCustomUploaderJsonAddSyntax.Name = "btnCustomUploaderJsonAddSyntax";
            this.btnCustomUploaderJsonAddSyntax.UseVisualStyleBackColor = true;
            this.btnCustomUploaderJsonAddSyntax.Click += new System.EventHandler(this.btnCustomUploaderJsonAddSyntax_Click);
            // 
            // btnCustomUploadJsonPathHelp
            // 
            resources.ApplyResources(this.btnCustomUploadJsonPathHelp, "btnCustomUploadJsonPathHelp");
            this.btnCustomUploadJsonPathHelp.Name = "btnCustomUploadJsonPathHelp";
            this.btnCustomUploadJsonPathHelp.UseVisualStyleBackColor = true;
            this.btnCustomUploadJsonPathHelp.Click += new System.EventHandler(this.btnCustomUploadJsonPathHelp_Click);
            // 
            // lblCustomUploaderJsonPathExample
            // 
            resources.ApplyResources(this.lblCustomUploaderJsonPathExample, "lblCustomUploaderJsonPathExample");
            this.lblCustomUploaderJsonPathExample.Name = "lblCustomUploaderJsonPathExample";
            // 
            // lblCustomUploaderJsonPath
            // 
            resources.ApplyResources(this.lblCustomUploaderJsonPath, "lblCustomUploaderJsonPath");
            this.lblCustomUploaderJsonPath.Name = "lblCustomUploaderJsonPath";
            // 
            // txtCustomUploaderJsonPath
            // 
            resources.ApplyResources(this.txtCustomUploaderJsonPath, "txtCustomUploaderJsonPath");
            this.txtCustomUploaderJsonPath.Name = "txtCustomUploaderJsonPath";
            this.txtCustomUploaderJsonPath.TextChanged += new System.EventHandler(this.txtCustomUploaderJsonPath_TextChanged);
            // 
            // tpCustomUploaderXmlParse
            // 
            this.tpCustomUploaderXmlParse.Controls.Add(this.btnCustomUploaderXmlSyntaxAdd);
            this.tpCustomUploaderXmlParse.Controls.Add(this.btnCustomUploaderXPathHelp);
            this.tpCustomUploaderXmlParse.Controls.Add(this.lblCustomUploaderXPathExample);
            this.tpCustomUploaderXmlParse.Controls.Add(this.lblCustomUploaderXPath);
            this.tpCustomUploaderXmlParse.Controls.Add(this.txtCustomUploaderXPath);
            resources.ApplyResources(this.tpCustomUploaderXmlParse, "tpCustomUploaderXmlParse");
            this.tpCustomUploaderXmlParse.Name = "tpCustomUploaderXmlParse";
            this.tpCustomUploaderXmlParse.UseVisualStyleBackColor = true;
            // 
            // btnCustomUploaderXmlSyntaxAdd
            // 
            resources.ApplyResources(this.btnCustomUploaderXmlSyntaxAdd, "btnCustomUploaderXmlSyntaxAdd");
            this.btnCustomUploaderXmlSyntaxAdd.Name = "btnCustomUploaderXmlSyntaxAdd";
            this.btnCustomUploaderXmlSyntaxAdd.UseVisualStyleBackColor = true;
            this.btnCustomUploaderXmlSyntaxAdd.Click += new System.EventHandler(this.btnCustomUploaderXmlSyntaxAdd_Click);
            // 
            // btnCustomUploaderXPathHelp
            // 
            resources.ApplyResources(this.btnCustomUploaderXPathHelp, "btnCustomUploaderXPathHelp");
            this.btnCustomUploaderXPathHelp.Name = "btnCustomUploaderXPathHelp";
            this.btnCustomUploaderXPathHelp.UseVisualStyleBackColor = true;
            this.btnCustomUploaderXPathHelp.Click += new System.EventHandler(this.btnCustomUploaderXPathHelp_Click);
            // 
            // lblCustomUploaderXPathExample
            // 
            resources.ApplyResources(this.lblCustomUploaderXPathExample, "lblCustomUploaderXPathExample");
            this.lblCustomUploaderXPathExample.Name = "lblCustomUploaderXPathExample";
            // 
            // lblCustomUploaderXPath
            // 
            resources.ApplyResources(this.lblCustomUploaderXPath, "lblCustomUploaderXPath");
            this.lblCustomUploaderXPath.Name = "lblCustomUploaderXPath";
            // 
            // txtCustomUploaderXPath
            // 
            resources.ApplyResources(this.txtCustomUploaderXPath, "txtCustomUploaderXPath");
            this.txtCustomUploaderXPath.Name = "txtCustomUploaderXPath";
            this.txtCustomUploaderXPath.TextChanged += new System.EventHandler(this.txtCustomUploaderXPath_TextChanged);
            // 
            // tpCustomUploaderRegexParse
            // 
            this.tpCustomUploaderRegexParse.Controls.Add(this.btnCustomUploaderRegexHelp);
            this.tpCustomUploaderRegexParse.Controls.Add(this.btnCustomUploaderRegexAddSyntax);
            this.tpCustomUploaderRegexParse.Controls.Add(this.txtCustomUploaderRegexp);
            this.tpCustomUploaderRegexParse.Controls.Add(this.btnCustomUploaderRegexpUpdate);
            this.tpCustomUploaderRegexParse.Controls.Add(this.btnCustomUploaderRegexpAdd);
            this.tpCustomUploaderRegexParse.Controls.Add(this.btnCustomUploaderRegexpRemove);
            this.tpCustomUploaderRegexParse.Controls.Add(this.lvCustomUploaderRegexps);
            resources.ApplyResources(this.tpCustomUploaderRegexParse, "tpCustomUploaderRegexParse");
            this.tpCustomUploaderRegexParse.Name = "tpCustomUploaderRegexParse";
            this.tpCustomUploaderRegexParse.UseVisualStyleBackColor = true;
            // 
            // btnCustomUploaderRegexHelp
            // 
            resources.ApplyResources(this.btnCustomUploaderRegexHelp, "btnCustomUploaderRegexHelp");
            this.btnCustomUploaderRegexHelp.Name = "btnCustomUploaderRegexHelp";
            this.btnCustomUploaderRegexHelp.UseVisualStyleBackColor = true;
            this.btnCustomUploaderRegexHelp.Click += new System.EventHandler(this.btnCustomUploaderRegexHelp_Click);
            // 
            // btnCustomUploaderRegexAddSyntax
            // 
            resources.ApplyResources(this.btnCustomUploaderRegexAddSyntax, "btnCustomUploaderRegexAddSyntax");
            this.btnCustomUploaderRegexAddSyntax.Name = "btnCustomUploaderRegexAddSyntax";
            this.btnCustomUploaderRegexAddSyntax.UseVisualStyleBackColor = true;
            this.btnCustomUploaderRegexAddSyntax.Click += new System.EventHandler(this.btnCustomUploaderRegexAddSyntax_Click);
            // 
            // txtCustomUploaderRegexp
            // 
            resources.ApplyResources(this.txtCustomUploaderRegexp, "txtCustomUploaderRegexp");
            this.txtCustomUploaderRegexp.Name = "txtCustomUploaderRegexp";
            this.txtCustomUploaderRegexp.TextChanged += new System.EventHandler(this.txtCustomUploaderRegexp_TextChanged);
            // 
            // btnCustomUploaderRegexpUpdate
            // 
            resources.ApplyResources(this.btnCustomUploaderRegexpUpdate, "btnCustomUploaderRegexpUpdate");
            this.btnCustomUploaderRegexpUpdate.Name = "btnCustomUploaderRegexpUpdate";
            this.btnCustomUploaderRegexpUpdate.UseVisualStyleBackColor = true;
            this.btnCustomUploaderRegexpUpdate.Click += new System.EventHandler(this.btnCustomUploaderRegexpEdit_Click);
            // 
            // btnCustomUploaderRegexpAdd
            // 
            resources.ApplyResources(this.btnCustomUploaderRegexpAdd, "btnCustomUploaderRegexpAdd");
            this.btnCustomUploaderRegexpAdd.Name = "btnCustomUploaderRegexpAdd";
            this.btnCustomUploaderRegexpAdd.UseVisualStyleBackColor = true;
            this.btnCustomUploaderRegexpAdd.Click += new System.EventHandler(this.btnCustomUploaderRegexpAdd_Click);
            // 
            // btnCustomUploaderRegexpRemove
            // 
            resources.ApplyResources(this.btnCustomUploaderRegexpRemove, "btnCustomUploaderRegexpRemove");
            this.btnCustomUploaderRegexpRemove.Name = "btnCustomUploaderRegexpRemove";
            this.btnCustomUploaderRegexpRemove.UseVisualStyleBackColor = true;
            this.btnCustomUploaderRegexpRemove.Click += new System.EventHandler(this.btnCustomUploaderRegexpRemove_Click);
            // 
            // lvCustomUploaderRegexps
            // 
            this.lvCustomUploaderRegexps.AllowDrop = true;
            this.lvCustomUploaderRegexps.AllowItemDrag = true;
            this.lvCustomUploaderRegexps.AutoFillColumn = true;
            this.lvCustomUploaderRegexps.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvRegexpsColumn});
            this.lvCustomUploaderRegexps.FullRowSelect = true;
            this.lvCustomUploaderRegexps.GridLines = true;
            this.lvCustomUploaderRegexps.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvCustomUploaderRegexps.HideSelection = false;
            resources.ApplyResources(this.lvCustomUploaderRegexps, "lvCustomUploaderRegexps");
            this.lvCustomUploaderRegexps.MultiSelect = false;
            this.lvCustomUploaderRegexps.Name = "lvCustomUploaderRegexps";
            this.lvCustomUploaderRegexps.UseCompatibleStateImageBehavior = false;
            this.lvCustomUploaderRegexps.View = System.Windows.Forms.View.Details;
            this.lvCustomUploaderRegexps.SelectedIndexChanged += new System.EventHandler(this.lvCustomUploaderRegexps_SelectedIndexChanged);
            // 
            // lvRegexpsColumn
            // 
            resources.ApplyResources(this.lvRegexpsColumn, "lvRegexpsColumn");
            // 
            // lblCustomUploaderURL
            // 
            resources.ApplyResources(this.lblCustomUploaderURL, "lblCustomUploaderURL");
            this.lblCustomUploaderURL.Name = "lblCustomUploaderURL";
            // 
            // tcCustomUploaderArguments
            // 
            this.tcCustomUploaderArguments.Controls.Add(this.tpCustomUploaderArguments);
            this.tcCustomUploaderArguments.Controls.Add(this.tpCustomUploaderHeaders);
            resources.ApplyResources(this.tcCustomUploaderArguments, "tcCustomUploaderArguments");
            this.tcCustomUploaderArguments.Name = "tcCustomUploaderArguments";
            this.tcCustomUploaderArguments.SelectedIndex = 0;
            // 
            // tpCustomUploaderArguments
            // 
            this.tpCustomUploaderArguments.Controls.Add(this.btnCustomUploaderArgUpdate);
            this.tpCustomUploaderArguments.Controls.Add(this.txtCustomUploaderArgName);
            this.tpCustomUploaderArguments.Controls.Add(this.txtCustomUploaderArgValue);
            this.tpCustomUploaderArguments.Controls.Add(this.btnCustomUploaderArgAdd);
            this.tpCustomUploaderArguments.Controls.Add(this.btnCustomUploaderArgRemove);
            this.tpCustomUploaderArguments.Controls.Add(this.lvCustomUploaderArguments);
            resources.ApplyResources(this.tpCustomUploaderArguments, "tpCustomUploaderArguments");
            this.tpCustomUploaderArguments.Name = "tpCustomUploaderArguments";
            this.tpCustomUploaderArguments.UseVisualStyleBackColor = true;
            // 
            // btnCustomUploaderArgUpdate
            // 
            resources.ApplyResources(this.btnCustomUploaderArgUpdate, "btnCustomUploaderArgUpdate");
            this.btnCustomUploaderArgUpdate.Name = "btnCustomUploaderArgUpdate";
            this.btnCustomUploaderArgUpdate.UseVisualStyleBackColor = true;
            this.btnCustomUploaderArgUpdate.Click += new System.EventHandler(this.btnCustomUploaderArgUpdate_Click);
            // 
            // txtCustomUploaderArgName
            // 
            resources.ApplyResources(this.txtCustomUploaderArgName, "txtCustomUploaderArgName");
            this.txtCustomUploaderArgName.Name = "txtCustomUploaderArgName";
            this.txtCustomUploaderArgName.TextChanged += new System.EventHandler(this.txtCustomUploaderArgName_TextChanged);
            // 
            // txtCustomUploaderArgValue
            // 
            resources.ApplyResources(this.txtCustomUploaderArgValue, "txtCustomUploaderArgValue");
            this.txtCustomUploaderArgValue.Name = "txtCustomUploaderArgValue";
            // 
            // btnCustomUploaderArgAdd
            // 
            resources.ApplyResources(this.btnCustomUploaderArgAdd, "btnCustomUploaderArgAdd");
            this.btnCustomUploaderArgAdd.Name = "btnCustomUploaderArgAdd";
            this.btnCustomUploaderArgAdd.UseVisualStyleBackColor = true;
            this.btnCustomUploaderArgAdd.Click += new System.EventHandler(this.btnCustomUploaderArgAdd_Click);
            // 
            // btnCustomUploaderArgRemove
            // 
            resources.ApplyResources(this.btnCustomUploaderArgRemove, "btnCustomUploaderArgRemove");
            this.btnCustomUploaderArgRemove.Name = "btnCustomUploaderArgRemove";
            this.btnCustomUploaderArgRemove.UseVisualStyleBackColor = true;
            this.btnCustomUploaderArgRemove.Click += new System.EventHandler(this.btnCustomUploaderArgRemove_Click);
            // 
            // lvCustomUploaderArguments
            // 
            this.lvCustomUploaderArguments.AllowDrop = true;
            this.lvCustomUploaderArguments.AllowItemDrag = true;
            this.lvCustomUploaderArguments.AutoFillColumn = true;
            this.lvCustomUploaderArguments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chCustomUploaderArgumentsName,
            this.chCustomUploaderArgumentsValue});
            this.lvCustomUploaderArguments.FullRowSelect = true;
            this.lvCustomUploaderArguments.GridLines = true;
            this.lvCustomUploaderArguments.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvCustomUploaderArguments.HideSelection = false;
            resources.ApplyResources(this.lvCustomUploaderArguments, "lvCustomUploaderArguments");
            this.lvCustomUploaderArguments.MultiSelect = false;
            this.lvCustomUploaderArguments.Name = "lvCustomUploaderArguments";
            this.lvCustomUploaderArguments.UseCompatibleStateImageBehavior = false;
            this.lvCustomUploaderArguments.View = System.Windows.Forms.View.Details;
            this.lvCustomUploaderArguments.SelectedIndexChanged += new System.EventHandler(this.lvCustomUploaderArguments_SelectedIndexChanged);
            // 
            // chCustomUploaderArgumentsName
            // 
            resources.ApplyResources(this.chCustomUploaderArgumentsName, "chCustomUploaderArgumentsName");
            // 
            // chCustomUploaderArgumentsValue
            // 
            resources.ApplyResources(this.chCustomUploaderArgumentsValue, "chCustomUploaderArgumentsValue");
            // 
            // tpCustomUploaderHeaders
            // 
            this.tpCustomUploaderHeaders.Controls.Add(this.btnCustomUploaderHeaderUpdate);
            this.tpCustomUploaderHeaders.Controls.Add(this.txtCustomUploaderHeaderName);
            this.tpCustomUploaderHeaders.Controls.Add(this.txtCustomUploaderHeaderValue);
            this.tpCustomUploaderHeaders.Controls.Add(this.btnCustomUploaderHeaderAdd);
            this.tpCustomUploaderHeaders.Controls.Add(this.btnCustomUploaderHeaderRemove);
            this.tpCustomUploaderHeaders.Controls.Add(this.lvCustomUploaderHeaders);
            resources.ApplyResources(this.tpCustomUploaderHeaders, "tpCustomUploaderHeaders");
            this.tpCustomUploaderHeaders.Name = "tpCustomUploaderHeaders";
            this.tpCustomUploaderHeaders.UseVisualStyleBackColor = true;
            // 
            // btnCustomUploaderHeaderUpdate
            // 
            resources.ApplyResources(this.btnCustomUploaderHeaderUpdate, "btnCustomUploaderHeaderUpdate");
            this.btnCustomUploaderHeaderUpdate.Name = "btnCustomUploaderHeaderUpdate";
            this.btnCustomUploaderHeaderUpdate.UseVisualStyleBackColor = true;
            this.btnCustomUploaderHeaderUpdate.Click += new System.EventHandler(this.btnCustomUploaderHeaderUpdate_Click);
            // 
            // txtCustomUploaderHeaderName
            // 
            resources.ApplyResources(this.txtCustomUploaderHeaderName, "txtCustomUploaderHeaderName");
            this.txtCustomUploaderHeaderName.Name = "txtCustomUploaderHeaderName";
            this.txtCustomUploaderHeaderName.TextChanged += new System.EventHandler(this.txtCustomUploaderHeaderName_TextChanged);
            // 
            // txtCustomUploaderHeaderValue
            // 
            resources.ApplyResources(this.txtCustomUploaderHeaderValue, "txtCustomUploaderHeaderValue");
            this.txtCustomUploaderHeaderValue.Name = "txtCustomUploaderHeaderValue";
            // 
            // btnCustomUploaderHeaderAdd
            // 
            resources.ApplyResources(this.btnCustomUploaderHeaderAdd, "btnCustomUploaderHeaderAdd");
            this.btnCustomUploaderHeaderAdd.Name = "btnCustomUploaderHeaderAdd";
            this.btnCustomUploaderHeaderAdd.UseVisualStyleBackColor = true;
            this.btnCustomUploaderHeaderAdd.Click += new System.EventHandler(this.btnCustomUploaderHeaderAdd_Click);
            // 
            // btnCustomUploaderHeaderRemove
            // 
            resources.ApplyResources(this.btnCustomUploaderHeaderRemove, "btnCustomUploaderHeaderRemove");
            this.btnCustomUploaderHeaderRemove.Name = "btnCustomUploaderHeaderRemove";
            this.btnCustomUploaderHeaderRemove.UseVisualStyleBackColor = true;
            this.btnCustomUploaderHeaderRemove.Click += new System.EventHandler(this.btnCustomUploaderHeaderRemove_Click);
            // 
            // lvCustomUploaderHeaders
            // 
            this.lvCustomUploaderHeaders.AllowDrop = true;
            this.lvCustomUploaderHeaders.AllowItemDrag = true;
            this.lvCustomUploaderHeaders.AutoFillColumn = true;
            this.lvCustomUploaderHeaders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chCustomUploaderHeadersName,
            this.chCustomUploaderHeadersValue});
            this.lvCustomUploaderHeaders.FullRowSelect = true;
            this.lvCustomUploaderHeaders.GridLines = true;
            this.lvCustomUploaderHeaders.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvCustomUploaderHeaders.HideSelection = false;
            resources.ApplyResources(this.lvCustomUploaderHeaders, "lvCustomUploaderHeaders");
            this.lvCustomUploaderHeaders.MultiSelect = false;
            this.lvCustomUploaderHeaders.Name = "lvCustomUploaderHeaders";
            this.lvCustomUploaderHeaders.UseCompatibleStateImageBehavior = false;
            this.lvCustomUploaderHeaders.View = System.Windows.Forms.View.Details;
            this.lvCustomUploaderHeaders.SelectedIndexChanged += new System.EventHandler(this.lvCustomUploaderHeaders_SelectedIndexChanged);
            // 
            // chCustomUploaderHeadersName
            // 
            resources.ApplyResources(this.chCustomUploaderHeadersName, "chCustomUploaderHeadersName");
            // 
            // chCustomUploaderHeadersValue
            // 
            resources.ApplyResources(this.chCustomUploaderHeadersValue, "chCustomUploaderHeadersValue");
            // 
            // txtCustomUploaderFileForm
            // 
            resources.ApplyResources(this.txtCustomUploaderFileForm, "txtCustomUploaderFileForm");
            this.txtCustomUploaderFileForm.Name = "txtCustomUploaderFileForm";
            this.txtCustomUploaderFileForm.TextChanged += new System.EventHandler(this.txtCustomUploaderFileForm_TextChanged);
            // 
            // lblCustomUploaderRequestType
            // 
            resources.ApplyResources(this.lblCustomUploaderRequestType, "lblCustomUploaderRequestType");
            this.lblCustomUploaderRequestType.Name = "lblCustomUploaderRequestType";
            // 
            // lblCustomUploaderFileForm
            // 
            resources.ApplyResources(this.lblCustomUploaderFileForm, "lblCustomUploaderFileForm");
            this.lblCustomUploaderFileForm.Name = "lblCustomUploaderFileForm";
            // 
            // txtCustomUploaderName
            // 
            resources.ApplyResources(this.txtCustomUploaderName, "txtCustomUploaderName");
            this.txtCustomUploaderName.Name = "txtCustomUploaderName";
            this.txtCustomUploaderName.TextChanged += new System.EventHandler(this.txtCustomUploaderName_TextChanged);
            // 
            // lblCustomUploaderThumbnailURL
            // 
            resources.ApplyResources(this.lblCustomUploaderThumbnailURL, "lblCustomUploaderThumbnailURL");
            this.lblCustomUploaderThumbnailURL.Name = "lblCustomUploaderThumbnailURL";
            // 
            // txtCustomUploaderRequestURL
            // 
            resources.ApplyResources(this.txtCustomUploaderRequestURL, "txtCustomUploaderRequestURL");
            this.txtCustomUploaderRequestURL.Name = "txtCustomUploaderRequestURL";
            this.txtCustomUploaderRequestURL.TextChanged += new System.EventHandler(this.txtCustomUploaderRequestURL_TextChanged);
            // 
            // txtCustomUploaderURL
            // 
            resources.ApplyResources(this.txtCustomUploaderURL, "txtCustomUploaderURL");
            this.txtCustomUploaderURL.Name = "txtCustomUploaderURL";
            this.txtCustomUploaderURL.TextChanged += new System.EventHandler(this.txtCustomUploaderURL_TextChanged);
            this.txtCustomUploaderURL.Enter += new System.EventHandler(this.txtCustomUploaderURL_Enter);
            // 
            // cbCustomUploaderResponseType
            // 
            this.cbCustomUploaderResponseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCustomUploaderResponseType.FormattingEnabled = true;
            resources.ApplyResources(this.cbCustomUploaderResponseType, "cbCustomUploaderResponseType");
            this.cbCustomUploaderResponseType.Name = "cbCustomUploaderResponseType";
            this.cbCustomUploaderResponseType.SelectedIndexChanged += new System.EventHandler(this.cbCustomUploaderResponseType_SelectedIndexChanged);
            // 
            // txtCustomUploaderThumbnailURL
            // 
            resources.ApplyResources(this.txtCustomUploaderThumbnailURL, "txtCustomUploaderThumbnailURL");
            this.txtCustomUploaderThumbnailURL.Name = "txtCustomUploaderThumbnailURL";
            this.txtCustomUploaderThumbnailURL.TextChanged += new System.EventHandler(this.txtCustomUploaderThumbnailURL_TextChanged);
            this.txtCustomUploaderThumbnailURL.Enter += new System.EventHandler(this.txtCustomUploaderThumbnailURL_Enter);
            // 
            // txtCustomUploaderDeletionURL
            // 
            resources.ApplyResources(this.txtCustomUploaderDeletionURL, "txtCustomUploaderDeletionURL");
            this.txtCustomUploaderDeletionURL.Name = "txtCustomUploaderDeletionURL";
            this.txtCustomUploaderDeletionURL.TextChanged += new System.EventHandler(this.txtCustomUploaderDeletionURL_TextChanged);
            this.txtCustomUploaderDeletionURL.Enter += new System.EventHandler(this.txtCustomUploaderDeletionURL_Enter);
            // 
            // lblCustomUploaderRequestURL
            // 
            resources.ApplyResources(this.lblCustomUploaderRequestURL, "lblCustomUploaderRequestURL");
            this.lblCustomUploaderRequestURL.Name = "lblCustomUploaderRequestURL";
            // 
            // lblCustomUploaderResponseType
            // 
            resources.ApplyResources(this.lblCustomUploaderResponseType, "lblCustomUploaderResponseType");
            this.lblCustomUploaderResponseType.Name = "lblCustomUploaderResponseType";
            // 
            // lblCustomUploaderDeletionURL
            // 
            resources.ApplyResources(this.lblCustomUploaderDeletionURL, "lblCustomUploaderDeletionURL");
            this.lblCustomUploaderDeletionURL.Name = "lblCustomUploaderDeletionURL";
            // 
            // btnCustomUploaderExamples
            // 
            resources.ApplyResources(this.btnCustomUploaderExamples, "btnCustomUploaderExamples");
            this.btnCustomUploaderExamples.Name = "btnCustomUploaderExamples";
            this.btnCustomUploaderExamples.UseVisualStyleBackColor = true;
            this.btnCustomUploaderExamples.Click += new System.EventHandler(this.btnCustomUploaderExamples_Click);
            // 
            // btnCustomUploaderHelp
            // 
            resources.ApplyResources(this.btnCustomUploaderHelp, "btnCustomUploaderHelp");
            this.btnCustomUploaderHelp.Name = "btnCustomUploaderHelp";
            this.btnCustomUploaderHelp.UseVisualStyleBackColor = true;
            this.btnCustomUploaderHelp.Click += new System.EventHandler(this.btnCustomUploaderHelp_Click);
            // 
            // lblCustomUploaderImageUploader
            // 
            resources.ApplyResources(this.lblCustomUploaderImageUploader, "lblCustomUploaderImageUploader");
            this.lblCustomUploaderImageUploader.Name = "lblCustomUploaderImageUploader";
            // 
            // btnCustomUploaderFileUploaderTest
            // 
            resources.ApplyResources(this.btnCustomUploaderFileUploaderTest, "btnCustomUploaderFileUploaderTest");
            this.btnCustomUploaderFileUploaderTest.Name = "btnCustomUploaderFileUploaderTest";
            this.btnCustomUploaderFileUploaderTest.UseVisualStyleBackColor = true;
            this.btnCustomUploaderFileUploaderTest.Click += new System.EventHandler(this.btnCustomUploaderFileUploaderTest_Click);
            // 
            // lblCustomUploaderFileUploader
            // 
            resources.ApplyResources(this.lblCustomUploaderFileUploader, "lblCustomUploaderFileUploader");
            this.lblCustomUploaderFileUploader.Name = "lblCustomUploaderFileUploader";
            // 
            // btnCustomUploaderImageUploaderTest
            // 
            resources.ApplyResources(this.btnCustomUploaderImageUploaderTest, "btnCustomUploaderImageUploaderTest");
            this.btnCustomUploaderImageUploaderTest.Name = "btnCustomUploaderImageUploaderTest";
            this.btnCustomUploaderImageUploaderTest.UseVisualStyleBackColor = true;
            this.btnCustomUploaderImageUploaderTest.Click += new System.EventHandler(this.btnCustomUploaderImageUploaderTest_Click);
            // 
            // lblCustomUploaderTestResult
            // 
            resources.ApplyResources(this.lblCustomUploaderTestResult, "lblCustomUploaderTestResult");
            this.lblCustomUploaderTestResult.Name = "lblCustomUploaderTestResult";
            // 
            // cbCustomUploaderFileUploader
            // 
            this.cbCustomUploaderFileUploader.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCustomUploaderFileUploader.FormattingEnabled = true;
            resources.ApplyResources(this.cbCustomUploaderFileUploader, "cbCustomUploaderFileUploader");
            this.cbCustomUploaderFileUploader.Name = "cbCustomUploaderFileUploader";
            this.cbCustomUploaderFileUploader.SelectedIndexChanged += new System.EventHandler(this.cbCustomUploaderFileUploader_SelectedIndexChanged);
            // 
            // btnCustomUploaderShowLastResponse
            // 
            resources.ApplyResources(this.btnCustomUploaderShowLastResponse, "btnCustomUploaderShowLastResponse");
            this.btnCustomUploaderShowLastResponse.Name = "btnCustomUploaderShowLastResponse";
            this.btnCustomUploaderShowLastResponse.UseVisualStyleBackColor = true;
            this.btnCustomUploaderShowLastResponse.Click += new System.EventHandler(this.btnCustomUploaderShowLastResponse_Click);
            // 
            // cbCustomUploaderURLShortener
            // 
            this.cbCustomUploaderURLShortener.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCustomUploaderURLShortener.FormattingEnabled = true;
            resources.ApplyResources(this.cbCustomUploaderURLShortener, "cbCustomUploaderURLShortener");
            this.cbCustomUploaderURLShortener.Name = "cbCustomUploaderURLShortener";
            this.cbCustomUploaderURLShortener.SelectedIndexChanged += new System.EventHandler(this.cbCustomUploaderURLShortener_SelectedIndexChanged);
            // 
            // gbCustomUploaders
            // 
            this.gbCustomUploaders.Controls.Add(this.btnCustomUploaderDuplicate);
            this.gbCustomUploaders.Controls.Add(this.btnCustomUploadersExportAll);
            this.gbCustomUploaders.Controls.Add(this.btnCustomUploaderClearUploaders);
            this.gbCustomUploaders.Controls.Add(this.eiCustomUploaders);
            this.gbCustomUploaders.Controls.Add(this.lbCustomUploaderList);
            this.gbCustomUploaders.Controls.Add(this.btnCustomUploaderRemove);
            this.gbCustomUploaders.Controls.Add(this.btnCustomUploaderAdd);
            resources.ApplyResources(this.gbCustomUploaders, "gbCustomUploaders");
            this.gbCustomUploaders.Name = "gbCustomUploaders";
            this.gbCustomUploaders.TabStop = false;
            // 
            // btnCustomUploaderDuplicate
            // 
            resources.ApplyResources(this.btnCustomUploaderDuplicate, "btnCustomUploaderDuplicate");
            this.btnCustomUploaderDuplicate.Name = "btnCustomUploaderDuplicate";
            this.btnCustomUploaderDuplicate.UseVisualStyleBackColor = true;
            this.btnCustomUploaderDuplicate.Click += new System.EventHandler(this.btnCustomUploaderDuplicate_Click);
            // 
            // btnCustomUploadersExportAll
            // 
            resources.ApplyResources(this.btnCustomUploadersExportAll, "btnCustomUploadersExportAll");
            this.btnCustomUploadersExportAll.Name = "btnCustomUploadersExportAll";
            this.btnCustomUploadersExportAll.UseVisualStyleBackColor = true;
            this.btnCustomUploadersExportAll.Click += new System.EventHandler(this.btnCustomUploadersExportAll_Click);
            // 
            // btnCustomUploaderClearUploaders
            // 
            resources.ApplyResources(this.btnCustomUploaderClearUploaders, "btnCustomUploaderClearUploaders");
            this.btnCustomUploaderClearUploaders.Name = "btnCustomUploaderClearUploaders";
            this.btnCustomUploaderClearUploaders.UseVisualStyleBackColor = true;
            this.btnCustomUploaderClearUploaders.Click += new System.EventHandler(this.btnCustomUploaderClearUploaders_Click);
            // 
            // eiCustomUploaders
            // 
            this.eiCustomUploaders.CustomFilter = "ShareX custom uploader (*.sxcu)|*.sxcu";
            this.eiCustomUploaders.DefaultFileName = null;
            this.eiCustomUploaders.ExportIgnoreDefaultValue = true;
            this.eiCustomUploaders.ExportIgnoreNull = true;
            resources.ApplyResources(this.eiCustomUploaders, "eiCustomUploaders");
            this.eiCustomUploaders.Name = "eiCustomUploaders";
            this.eiCustomUploaders.ObjectType = null;
            this.eiCustomUploaders.ExportRequested += new ShareX.HelpersLib.ExportImportControl.ExportEventHandler(this.eiCustomUploaders_ExportRequested);
            this.eiCustomUploaders.ImportRequested += new ShareX.HelpersLib.ExportImportControl.ImportEventHandler(this.eiCustomUploaders_ImportRequested);
            // 
            // lbCustomUploaderList
            // 
            this.lbCustomUploaderList.FormattingEnabled = true;
            resources.ApplyResources(this.lbCustomUploaderList, "lbCustomUploaderList");
            this.lbCustomUploaderList.Name = "lbCustomUploaderList";
            this.lbCustomUploaderList.SelectedIndexChanged += new System.EventHandler(this.lbCustomUploaderList_SelectedIndexChanged);
            // 
            // btnCustomUploaderRemove
            // 
            resources.ApplyResources(this.btnCustomUploaderRemove, "btnCustomUploaderRemove");
            this.btnCustomUploaderRemove.Name = "btnCustomUploaderRemove";
            this.btnCustomUploaderRemove.UseVisualStyleBackColor = true;
            this.btnCustomUploaderRemove.Click += new System.EventHandler(this.btnCustomUploaderRemove_Click);
            // 
            // btnCustomUploaderAdd
            // 
            resources.ApplyResources(this.btnCustomUploaderAdd, "btnCustomUploaderAdd");
            this.btnCustomUploaderAdd.Name = "btnCustomUploaderAdd";
            this.btnCustomUploaderAdd.UseVisualStyleBackColor = true;
            this.btnCustomUploaderAdd.Click += new System.EventHandler(this.btnCustomUploaderAdd_Click);
            // 
            // lblCustomUploaderTextUploader
            // 
            resources.ApplyResources(this.lblCustomUploaderTextUploader, "lblCustomUploaderTextUploader");
            this.lblCustomUploaderTextUploader.Name = "lblCustomUploaderTextUploader";
            // 
            // btnCustomUploaderURLShortenerTest
            // 
            resources.ApplyResources(this.btnCustomUploaderURLShortenerTest, "btnCustomUploaderURLShortenerTest");
            this.btnCustomUploaderURLShortenerTest.Name = "btnCustomUploaderURLShortenerTest";
            this.btnCustomUploaderURLShortenerTest.UseVisualStyleBackColor = true;
            this.btnCustomUploaderURLShortenerTest.Click += new System.EventHandler(this.btnCustomUploaderURLShortenerTest_Click);
            // 
            // cbCustomUploaderTextUploader
            // 
            this.cbCustomUploaderTextUploader.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCustomUploaderTextUploader.FormattingEnabled = true;
            resources.ApplyResources(this.cbCustomUploaderTextUploader, "cbCustomUploaderTextUploader");
            this.cbCustomUploaderTextUploader.Name = "cbCustomUploaderTextUploader";
            this.cbCustomUploaderTextUploader.SelectedIndexChanged += new System.EventHandler(this.cbCustomUploaderTextUploader_SelectedIndexChanged);
            // 
            // lblCustomUploaderURLShortener
            // 
            resources.ApplyResources(this.lblCustomUploaderURLShortener, "lblCustomUploaderURLShortener");
            this.lblCustomUploaderURLShortener.Name = "lblCustomUploaderURLShortener";
            // 
            // btnCustomUploaderTextUploaderTest
            // 
            resources.ApplyResources(this.btnCustomUploaderTextUploaderTest, "btnCustomUploaderTextUploaderTest");
            this.btnCustomUploaderTextUploaderTest.Name = "btnCustomUploaderTextUploaderTest";
            this.btnCustomUploaderTextUploaderTest.UseVisualStyleBackColor = true;
            this.btnCustomUploaderTextUploaderTest.Click += new System.EventHandler(this.btnCustomUploaderTextUploaderTest_Click);
            // 
            // cbCustomUploaderImageUploader
            // 
            this.cbCustomUploaderImageUploader.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCustomUploaderImageUploader.FormattingEnabled = true;
            resources.ApplyResources(this.cbCustomUploaderImageUploader, "cbCustomUploaderImageUploader");
            this.cbCustomUploaderImageUploader.Name = "cbCustomUploaderImageUploader";
            this.cbCustomUploaderImageUploader.SelectedIndexChanged += new System.EventHandler(this.cbCustomUploaderImageUploader_SelectedIndexChanged);
            // 
            // txtCustomUploaderLog
            // 
            resources.ApplyResources(this.txtCustomUploaderLog, "txtCustomUploaderLog");
            this.txtCustomUploaderLog.Name = "txtCustomUploaderLog";
            this.txtCustomUploaderLog.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.txtCustomUploaderLog_LinkClicked);
            // 
            // tpURLShorteners
            // 
            this.tpURLShorteners.BackColor = System.Drawing.SystemColors.Window;
            this.tpURLShorteners.Controls.Add(this.tcURLShorteners);
            resources.ApplyResources(this.tpURLShorteners, "tpURLShorteners");
            this.tpURLShorteners.Name = "tpURLShorteners";
            // 
            // tcURLShorteners
            // 
           resources.ApplyResources(this.tcURLShorteners, "tcURLShorteners");
            this.tcURLShorteners.Name = "tcURLShorteners";
            this.tcURLShorteners.SelectedIndex = 0;
            // 
            // tpFileUploaders
            // 
            this.tpFileUploaders.BackColor = System.Drawing.SystemColors.Window;
            this.tpFileUploaders.Controls.Add(this.tcFileUploaders);
            resources.ApplyResources(this.tpFileUploaders, "tpFileUploaders");
            this.tpFileUploaders.Name = "tpFileUploaders";
            // 
            // tcFileUploaders
            // 
            this.tcFileUploaders.Controls.Add(this.tpFTP);
            this.tcFileUploaders.Controls.Add(this.tpJira);
            this.tcFileUploaders.Controls.Add(this.tpSeafile);
            this.tcFileUploaders.Controls.Add(this.tpSharedFolder);
            this.tcFileUploaders.Controls.Add(this.tpEmail);
            resources.ApplyResources(this.tcFileUploaders, "tcFileUploaders");
            this.tcFileUploaders.Multiline = true;
            this.tcFileUploaders.Name = "tcFileUploaders";
            this.tcFileUploaders.SelectedIndex = 0;
            // 
            // tpFTP
            // 
            this.tpFTP.BackColor = System.Drawing.SystemColors.Window;
            this.tpFTP.Controls.Add(this.gbFTPAccount);
            this.tpFTP.Controls.Add(this.btnFTPDuplicate);
            this.tpFTP.Controls.Add(this.btnFTPRemove);
            this.tpFTP.Controls.Add(this.btnFTPAdd);
            this.tpFTP.Controls.Add(this.cbFTPAccounts);
            this.tpFTP.Controls.Add(this.lblFTPAccounts);
            this.tpFTP.Controls.Add(this.lblFTPFile);
            this.tpFTP.Controls.Add(this.lblFTPText);
            this.tpFTP.Controls.Add(this.lblFTPImage);
            this.tpFTP.Controls.Add(this.cbFTPImage);
            this.tpFTP.Controls.Add(this.cbFTPFile);
            this.tpFTP.Controls.Add(this.cbFTPText);
            resources.ApplyResources(this.tpFTP, "tpFTP");
            this.tpFTP.Name = "tpFTP";
            // 
            // gbFTPAccount
            // 
            this.gbFTPAccount.Controls.Add(this.gbSFTP);
            this.gbFTPAccount.Controls.Add(this.cbFTPAppendRemoteDirectory);
            this.gbFTPAccount.Controls.Add(this.btnFTPTest);
            this.gbFTPAccount.Controls.Add(this.lblFTPProtocol);
            this.gbFTPAccount.Controls.Add(this.lblFTPName);
            this.gbFTPAccount.Controls.Add(this.cbFTPRemoveFileExtension);
            this.gbFTPAccount.Controls.Add(this.txtFTPName);
            this.gbFTPAccount.Controls.Add(this.lblFTPHost);
            this.gbFTPAccount.Controls.Add(this.eiFTP);
            this.gbFTPAccount.Controls.Add(this.pFTPTransferMode);
            this.gbFTPAccount.Controls.Add(this.btnFTPClient);
            this.gbFTPAccount.Controls.Add(this.txtFTPHost);
            this.gbFTPAccount.Controls.Add(this.pFTPProtocol);
            this.gbFTPAccount.Controls.Add(this.lblFTPPort);
            this.gbFTPAccount.Controls.Add(this.lblFTPTransferMode);
            this.gbFTPAccount.Controls.Add(this.nudFTPPort);
            this.gbFTPAccount.Controls.Add(this.lblFTPURLPreviewValue);
            this.gbFTPAccount.Controls.Add(this.lblFTPUsername);
            this.gbFTPAccount.Controls.Add(this.lblFTPURLPreview);
            this.gbFTPAccount.Controls.Add(this.txtFTPUsername);
            this.gbFTPAccount.Controls.Add(this.cbFTPURLPathProtocol);
            this.gbFTPAccount.Controls.Add(this.lblFTPPassword);
            this.gbFTPAccount.Controls.Add(this.txtFTPURLPath);
            this.gbFTPAccount.Controls.Add(this.txtFTPPassword);
            this.gbFTPAccount.Controls.Add(this.lblFTPURLPath);
            this.gbFTPAccount.Controls.Add(this.lblFTPRemoteDirectory);
            this.gbFTPAccount.Controls.Add(this.txtFTPRemoteDirectory);
            this.gbFTPAccount.Controls.Add(this.gbFTPS);
            resources.ApplyResources(this.gbFTPAccount, "gbFTPAccount");
            this.gbFTPAccount.Name = "gbFTPAccount";
            this.gbFTPAccount.TabStop = false;
            // 
            // gbSFTP
            // 
            this.gbSFTP.Controls.Add(this.txtSFTPKeyPassphrase);
            this.gbSFTP.Controls.Add(this.btnSFTPKeyLocationBrowse);
            this.gbSFTP.Controls.Add(this.lblSFTPKeyPassphrase);
            this.gbSFTP.Controls.Add(this.txtSFTPKeyLocation);
            this.gbSFTP.Controls.Add(this.lblSFTPKeyLocation);
            resources.ApplyResources(this.gbSFTP, "gbSFTP");
            this.gbSFTP.Name = "gbSFTP";
            this.gbSFTP.TabStop = false;
            // 
            // txtSFTPKeyPassphrase
            // 
            resources.ApplyResources(this.txtSFTPKeyPassphrase, "txtSFTPKeyPassphrase");
            this.txtSFTPKeyPassphrase.Name = "txtSFTPKeyPassphrase";
            this.txtSFTPKeyPassphrase.UseSystemPasswordChar = true;
            this.txtSFTPKeyPassphrase.TextChanged += new System.EventHandler(this.txtSFTPKeyPassphrase_TextChanged);
            // 
            // btnSFTPKeyLocationBrowse
            // 
            resources.ApplyResources(this.btnSFTPKeyLocationBrowse, "btnSFTPKeyLocationBrowse");
            this.btnSFTPKeyLocationBrowse.Name = "btnSFTPKeyLocationBrowse";
            this.btnSFTPKeyLocationBrowse.UseVisualStyleBackColor = true;
            this.btnSFTPKeyLocationBrowse.Click += new System.EventHandler(this.btnSFTPKeyLocationBrowse_Click);
            // 
            // lblSFTPKeyPassphrase
            // 
            resources.ApplyResources(this.lblSFTPKeyPassphrase, "lblSFTPKeyPassphrase");
            this.lblSFTPKeyPassphrase.Name = "lblSFTPKeyPassphrase";
            // 
            // txtSFTPKeyLocation
            // 
            resources.ApplyResources(this.txtSFTPKeyLocation, "txtSFTPKeyLocation");
            this.txtSFTPKeyLocation.Name = "txtSFTPKeyLocation";
            this.txtSFTPKeyLocation.TextChanged += new System.EventHandler(this.txtSFTPKeyLocation_TextChanged);
            // 
            // lblSFTPKeyLocation
            // 
            resources.ApplyResources(this.lblSFTPKeyLocation, "lblSFTPKeyLocation");
            this.lblSFTPKeyLocation.Name = "lblSFTPKeyLocation";
            // 
            // cbFTPAppendRemoteDirectory
            // 
            resources.ApplyResources(this.cbFTPAppendRemoteDirectory, "cbFTPAppendRemoteDirectory");
            this.cbFTPAppendRemoteDirectory.Name = "cbFTPAppendRemoteDirectory";
            this.cbFTPAppendRemoteDirectory.UseVisualStyleBackColor = true;
            this.cbFTPAppendRemoteDirectory.CheckedChanged += new System.EventHandler(this.cbFTPAppendRemoteDirectory_CheckedChanged);
            // 
            // btnFTPTest
            // 
            resources.ApplyResources(this.btnFTPTest, "btnFTPTest");
            this.btnFTPTest.Name = "btnFTPTest";
            this.btnFTPTest.UseVisualStyleBackColor = true;
            this.btnFTPTest.Click += new System.EventHandler(this.btnFTPTest_Click);
            // 
            // lblFTPProtocol
            // 
            resources.ApplyResources(this.lblFTPProtocol, "lblFTPProtocol");
            this.lblFTPProtocol.Name = "lblFTPProtocol";
            // 
            // lblFTPName
            // 
            resources.ApplyResources(this.lblFTPName, "lblFTPName");
            this.lblFTPName.Name = "lblFTPName";
            // 
            // cbFTPRemoveFileExtension
            // 
            resources.ApplyResources(this.cbFTPRemoveFileExtension, "cbFTPRemoveFileExtension");
            this.cbFTPRemoveFileExtension.Name = "cbFTPRemoveFileExtension";
            this.cbFTPRemoveFileExtension.UseVisualStyleBackColor = true;
            this.cbFTPRemoveFileExtension.CheckedChanged += new System.EventHandler(this.cbFTPRemoveFileExtension_CheckedChanged);
            // 
            // txtFTPName
            // 
            resources.ApplyResources(this.txtFTPName, "txtFTPName");
            this.txtFTPName.Name = "txtFTPName";
            this.txtFTPName.TextChanged += new System.EventHandler(this.txtFTPName_TextChanged);
            // 
            // lblFTPHost
            // 
            resources.ApplyResources(this.lblFTPHost, "lblFTPHost");
            this.lblFTPHost.Name = "lblFTPHost";
            // 
            // eiFTP
            // 
            this.eiFTP.DefaultFileName = null;
            resources.ApplyResources(this.eiFTP, "eiFTP");
            this.eiFTP.Name = "eiFTP";
            this.eiFTP.ObjectType = null;
            this.eiFTP.ExportRequested += new ShareX.HelpersLib.ExportImportControl.ExportEventHandler(this.eiFTP_ExportRequested);
            this.eiFTP.ImportRequested += new ShareX.HelpersLib.ExportImportControl.ImportEventHandler(this.eiFTP_ImportRequested);
            // 
            // pFTPTransferMode
            // 
            resources.ApplyResources(this.pFTPTransferMode, "pFTPTransferMode");
            this.pFTPTransferMode.Controls.Add(this.rbFTPTransferModeActive);
            this.pFTPTransferMode.Controls.Add(this.rbFTPTransferModePassive);
            this.pFTPTransferMode.Name = "pFTPTransferMode";
            // 
            // rbFTPTransferModeActive
            // 
            resources.ApplyResources(this.rbFTPTransferModeActive, "rbFTPTransferModeActive");
            this.rbFTPTransferModeActive.Name = "rbFTPTransferModeActive";
            this.rbFTPTransferModeActive.UseVisualStyleBackColor = true;
            this.rbFTPTransferModeActive.CheckedChanged += new System.EventHandler(this.rbFTPTransferModeActive_CheckedChanged);
            // 
            // rbFTPTransferModePassive
            // 
            resources.ApplyResources(this.rbFTPTransferModePassive, "rbFTPTransferModePassive");
            this.rbFTPTransferModePassive.Checked = true;
            this.rbFTPTransferModePassive.Name = "rbFTPTransferModePassive";
            this.rbFTPTransferModePassive.TabStop = true;
            this.rbFTPTransferModePassive.UseVisualStyleBackColor = true;
            this.rbFTPTransferModePassive.CheckedChanged += new System.EventHandler(this.rbFTPTransferModePassive_CheckedChanged);
            // 
            // btnFTPClient
            // 
            resources.ApplyResources(this.btnFTPClient, "btnFTPClient");
            this.btnFTPClient.Name = "btnFTPClient";
            this.btnFTPClient.UseVisualStyleBackColor = true;
            this.btnFTPClient.Click += new System.EventHandler(this.btnFTPClient_Click);
            // 
            // txtFTPHost
            // 
            resources.ApplyResources(this.txtFTPHost, "txtFTPHost");
            this.txtFTPHost.Name = "txtFTPHost";
            this.txtFTPHost.TextChanged += new System.EventHandler(this.txtFTPHost_TextChanged);
            // 
            // pFTPProtocol
            // 
            resources.ApplyResources(this.pFTPProtocol, "pFTPProtocol");
            this.pFTPProtocol.Controls.Add(this.rbFTPProtocolFTP);
            this.pFTPProtocol.Controls.Add(this.rbFTPProtocolFTPS);
            this.pFTPProtocol.Controls.Add(this.rbFTPProtocolSFTP);
            this.pFTPProtocol.Name = "pFTPProtocol";
            // 
            // rbFTPProtocolFTP
            // 
            resources.ApplyResources(this.rbFTPProtocolFTP, "rbFTPProtocolFTP");
            this.rbFTPProtocolFTP.Checked = true;
            this.rbFTPProtocolFTP.Name = "rbFTPProtocolFTP";
            this.rbFTPProtocolFTP.TabStop = true;
            this.rbFTPProtocolFTP.UseVisualStyleBackColor = true;
            this.rbFTPProtocolFTP.CheckedChanged += new System.EventHandler(this.rbFTPProtocolFTP_CheckedChanged);
            // 
            // rbFTPProtocolFTPS
            // 
            resources.ApplyResources(this.rbFTPProtocolFTPS, "rbFTPProtocolFTPS");
            this.rbFTPProtocolFTPS.Name = "rbFTPProtocolFTPS";
            this.rbFTPProtocolFTPS.UseVisualStyleBackColor = true;
            this.rbFTPProtocolFTPS.CheckedChanged += new System.EventHandler(this.rbFTPProtocolFTPS_CheckedChanged);
            // 
            // rbFTPProtocolSFTP
            // 
            resources.ApplyResources(this.rbFTPProtocolSFTP, "rbFTPProtocolSFTP");
            this.rbFTPProtocolSFTP.Name = "rbFTPProtocolSFTP";
            this.rbFTPProtocolSFTP.UseVisualStyleBackColor = true;
            this.rbFTPProtocolSFTP.CheckedChanged += new System.EventHandler(this.rbFTPProtocolSFTP_CheckedChanged);
            // 
            // lblFTPPort
            // 
            resources.ApplyResources(this.lblFTPPort, "lblFTPPort");
            this.lblFTPPort.Name = "lblFTPPort";
            // 
            // lblFTPTransferMode
            // 
            resources.ApplyResources(this.lblFTPTransferMode, "lblFTPTransferMode");
            this.lblFTPTransferMode.Name = "lblFTPTransferMode";
            // 
            // nudFTPPort
            // 
            resources.ApplyResources(this.nudFTPPort, "nudFTPPort");
            this.nudFTPPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudFTPPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFTPPort.Name = "nudFTPPort";
            this.nudFTPPort.Value = new decimal(new int[] {
            21,
            0,
            0,
            0});
            this.nudFTPPort.ValueChanged += new System.EventHandler(this.nudFTPPort_ValueChanged);
            // 
            // lblFTPURLPreviewValue
            // 
            resources.ApplyResources(this.lblFTPURLPreviewValue, "lblFTPURLPreviewValue");
            this.lblFTPURLPreviewValue.Name = "lblFTPURLPreviewValue";
            // 
            // lblFTPUsername
            // 
            resources.ApplyResources(this.lblFTPUsername, "lblFTPUsername");
            this.lblFTPUsername.Name = "lblFTPUsername";
            // 
            // lblFTPURLPreview
            // 
            resources.ApplyResources(this.lblFTPURLPreview, "lblFTPURLPreview");
            this.lblFTPURLPreview.Name = "lblFTPURLPreview";
            // 
            // txtFTPUsername
            // 
            resources.ApplyResources(this.txtFTPUsername, "txtFTPUsername");
            this.txtFTPUsername.Name = "txtFTPUsername";
            this.txtFTPUsername.TextChanged += new System.EventHandler(this.txtFTPUsername_TextChanged);
            // 
            // cbFTPURLPathProtocol
            // 
            this.cbFTPURLPathProtocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFTPURLPathProtocol.FormattingEnabled = true;
            resources.ApplyResources(this.cbFTPURLPathProtocol, "cbFTPURLPathProtocol");
            this.cbFTPURLPathProtocol.Name = "cbFTPURLPathProtocol";
            this.cbFTPURLPathProtocol.SelectedIndexChanged += new System.EventHandler(this.cbFTPURLPathProtocol_SelectedIndexChanged);
            // 
            // lblFTPPassword
            // 
            resources.ApplyResources(this.lblFTPPassword, "lblFTPPassword");
            this.lblFTPPassword.Name = "lblFTPPassword";
            // 
            // txtFTPURLPath
            // 
            resources.ApplyResources(this.txtFTPURLPath, "txtFTPURLPath");
            this.txtFTPURLPath.Name = "txtFTPURLPath";
            this.txtFTPURLPath.TextChanged += new System.EventHandler(this.txtFTPURLPath_TextChanged);
            // 
            // txtFTPPassword
            // 
            resources.ApplyResources(this.txtFTPPassword, "txtFTPPassword");
            this.txtFTPPassword.Name = "txtFTPPassword";
            this.txtFTPPassword.UseSystemPasswordChar = true;
            this.txtFTPPassword.TextChanged += new System.EventHandler(this.txtFTPPassword_TextChanged);
            // 
            // lblFTPURLPath
            // 
            resources.ApplyResources(this.lblFTPURLPath, "lblFTPURLPath");
            this.lblFTPURLPath.Name = "lblFTPURLPath";
            // 
            // lblFTPRemoteDirectory
            // 
            resources.ApplyResources(this.lblFTPRemoteDirectory, "lblFTPRemoteDirectory");
            this.lblFTPRemoteDirectory.Name = "lblFTPRemoteDirectory";
            // 
            // txtFTPRemoteDirectory
            // 
            resources.ApplyResources(this.txtFTPRemoteDirectory, "txtFTPRemoteDirectory");
            this.txtFTPRemoteDirectory.Name = "txtFTPRemoteDirectory";
            this.txtFTPRemoteDirectory.TextChanged += new System.EventHandler(this.txtFTPRemoteDirectory_TextChanged);
            // 
            // gbFTPS
            // 
            this.gbFTPS.Controls.Add(this.btnFTPSCertificateLocationBrowse);
            this.gbFTPS.Controls.Add(this.txtFTPSCertificateLocation);
            this.gbFTPS.Controls.Add(this.lblFTPSCertificateLocation);
            this.gbFTPS.Controls.Add(this.cbFTPSEncryption);
            this.gbFTPS.Controls.Add(this.lblFTPSEncryption);
            resources.ApplyResources(this.gbFTPS, "gbFTPS");
            this.gbFTPS.Name = "gbFTPS";
            this.gbFTPS.TabStop = false;
            // 
            // btnFTPSCertificateLocationBrowse
            // 
            resources.ApplyResources(this.btnFTPSCertificateLocationBrowse, "btnFTPSCertificateLocationBrowse");
            this.btnFTPSCertificateLocationBrowse.Name = "btnFTPSCertificateLocationBrowse";
            this.btnFTPSCertificateLocationBrowse.UseVisualStyleBackColor = true;
            this.btnFTPSCertificateLocationBrowse.Click += new System.EventHandler(this.btnFTPSCertificateLocationBrowse_Click);
            // 
            // txtFTPSCertificateLocation
            // 
            resources.ApplyResources(this.txtFTPSCertificateLocation, "txtFTPSCertificateLocation");
            this.txtFTPSCertificateLocation.Name = "txtFTPSCertificateLocation";
            this.txtFTPSCertificateLocation.TextChanged += new System.EventHandler(this.txtFTPSCertificateLocation_TextChanged);
            // 
            // lblFTPSCertificateLocation
            // 
            resources.ApplyResources(this.lblFTPSCertificateLocation, "lblFTPSCertificateLocation");
            this.lblFTPSCertificateLocation.Name = "lblFTPSCertificateLocation";
            // 
            // cbFTPSEncryption
            // 
            this.cbFTPSEncryption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFTPSEncryption.FormattingEnabled = true;
            resources.ApplyResources(this.cbFTPSEncryption, "cbFTPSEncryption");
            this.cbFTPSEncryption.Name = "cbFTPSEncryption";
            this.cbFTPSEncryption.SelectedIndexChanged += new System.EventHandler(this.cbFTPSEncryption_SelectedIndexChanged);
            // 
            // lblFTPSEncryption
            // 
            resources.ApplyResources(this.lblFTPSEncryption, "lblFTPSEncryption");
            this.lblFTPSEncryption.Name = "lblFTPSEncryption";
            // 
            // btnFTPDuplicate
            // 
            resources.ApplyResources(this.btnFTPDuplicate, "btnFTPDuplicate");
            this.btnFTPDuplicate.Name = "btnFTPDuplicate";
            this.btnFTPDuplicate.UseVisualStyleBackColor = true;
            this.btnFTPDuplicate.Click += new System.EventHandler(this.btnFTPDuplicate_Click);
            // 
            // btnFTPRemove
            // 
            resources.ApplyResources(this.btnFTPRemove, "btnFTPRemove");
            this.btnFTPRemove.Name = "btnFTPRemove";
            this.btnFTPRemove.UseVisualStyleBackColor = true;
            this.btnFTPRemove.Click += new System.EventHandler(this.btnFTPRemove_Click);
            // 
            // btnFTPAdd
            // 
            resources.ApplyResources(this.btnFTPAdd, "btnFTPAdd");
            this.btnFTPAdd.Name = "btnFTPAdd";
            this.btnFTPAdd.UseVisualStyleBackColor = true;
            this.btnFTPAdd.Click += new System.EventHandler(this.btnFTPAdd_Click);
            // 
            // cbFTPAccounts
            // 
            this.cbFTPAccounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFTPAccounts.FormattingEnabled = true;
            resources.ApplyResources(this.cbFTPAccounts, "cbFTPAccounts");
            this.cbFTPAccounts.Name = "cbFTPAccounts";
            this.cbFTPAccounts.SelectedIndexChanged += new System.EventHandler(this.cbFTPAccounts_SelectedIndexChanged);
            // 
            // lblFTPAccounts
            // 
            resources.ApplyResources(this.lblFTPAccounts, "lblFTPAccounts");
            this.lblFTPAccounts.Name = "lblFTPAccounts";
            // 
            // lblFTPFile
            // 
            resources.ApplyResources(this.lblFTPFile, "lblFTPFile");
            this.lblFTPFile.Name = "lblFTPFile";
            // 
            // lblFTPText
            // 
            resources.ApplyResources(this.lblFTPText, "lblFTPText");
            this.lblFTPText.Name = "lblFTPText";
            // 
            // lblFTPImage
            // 
            resources.ApplyResources(this.lblFTPImage, "lblFTPImage");
            this.lblFTPImage.Name = "lblFTPImage";
            // 
            // cbFTPImage
            // 
            this.cbFTPImage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFTPImage.FormattingEnabled = true;
            resources.ApplyResources(this.cbFTPImage, "cbFTPImage");
            this.cbFTPImage.Name = "cbFTPImage";
            this.cbFTPImage.SelectedIndexChanged += new System.EventHandler(this.cbFTPImage_SelectedIndexChanged);
            // 
            // cbFTPFile
            // 
            this.cbFTPFile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFTPFile.FormattingEnabled = true;
            resources.ApplyResources(this.cbFTPFile, "cbFTPFile");
            this.cbFTPFile.Name = "cbFTPFile";
            this.cbFTPFile.SelectedIndexChanged += new System.EventHandler(this.cbFTPFile_SelectedIndexChanged);
            // 
            // cbFTPText
            // 
            this.cbFTPText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFTPText.FormattingEnabled = true;
            resources.ApplyResources(this.cbFTPText, "cbFTPText");
            this.cbFTPText.Name = "cbFTPText";
            this.cbFTPText.SelectedIndexChanged += new System.EventHandler(this.cbFTPText_SelectedIndexChanged);
            // 
            // tpJira
            // 
            this.tpJira.BackColor = System.Drawing.SystemColors.Window;
            this.tpJira.Controls.Add(this.txtJiraIssuePrefix);
            this.tpJira.Controls.Add(this.lblJiraIssuePrefix);
            this.tpJira.Controls.Add(this.gbJiraServer);
            this.tpJira.Controls.Add(this.oAuthJira);
            resources.ApplyResources(this.tpJira, "tpJira");
            this.tpJira.Name = "tpJira";
            // 
            // txtJiraIssuePrefix
            // 
            resources.ApplyResources(this.txtJiraIssuePrefix, "txtJiraIssuePrefix");
            this.txtJiraIssuePrefix.Name = "txtJiraIssuePrefix";
            this.txtJiraIssuePrefix.TextChanged += new System.EventHandler(this.txtJiraIssuePrefix_TextChanged);
            // 
            // lblJiraIssuePrefix
            // 
            resources.ApplyResources(this.lblJiraIssuePrefix, "lblJiraIssuePrefix");
            this.lblJiraIssuePrefix.Name = "lblJiraIssuePrefix";
            // 
            // gbJiraServer
            // 
            this.gbJiraServer.Controls.Add(this.txtJiraConfigHelp);
            this.gbJiraServer.Controls.Add(this.txtJiraHost);
            this.gbJiraServer.Controls.Add(this.lblJiraHost);
            resources.ApplyResources(this.gbJiraServer, "gbJiraServer");
            this.gbJiraServer.Name = "gbJiraServer";
            this.gbJiraServer.TabStop = false;
            // 
            // txtJiraConfigHelp
            // 
            this.txtJiraConfigHelp.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.txtJiraConfigHelp, "txtJiraConfigHelp");
            this.txtJiraConfigHelp.Name = "txtJiraConfigHelp";
            this.txtJiraConfigHelp.ReadOnly = true;
            // 
            // txtJiraHost
            // 
            resources.ApplyResources(this.txtJiraHost, "txtJiraHost");
            this.txtJiraHost.Name = "txtJiraHost";
            this.txtJiraHost.TextChanged += new System.EventHandler(this.txtJiraHost_TextChanged);
            // 
            // lblJiraHost
            // 
            resources.ApplyResources(this.lblJiraHost, "lblJiraHost");
            this.lblJiraHost.Name = "lblJiraHost";
            // 
            // oAuthJira
            // 
            resources.ApplyResources(this.oAuthJira, "oAuthJira");
            this.oAuthJira.Name = "oAuthJira";
            this.oAuthJira.OpenButtonClicked += new ShareX.UploadersLib.OAuthControl.OpenButtonClickedEventHandler(this.oAuthJira_OpenButtonClicked);
            this.oAuthJira.CompleteButtonClicked += new ShareX.UploadersLib.OAuthControl.CompleteButtonClickedEventHandler(this.oAuthJira_CompleteButtonClicked);
            this.oAuthJira.ClearButtonClicked += new ShareX.UploadersLib.OAuthControl.ClearButtonclickedEventHandler(this.oAuthJira_ClearButtonClicked);
            this.oAuthJira.RefreshButtonClicked += new ShareX.UploadersLib.OAuthControl.RefreshButtonClickedEventHandler(this.oAuthJira_RefreshButtonClicked);
            // 
            // tpSeafile
            // 
            this.tpSeafile.BackColor = System.Drawing.SystemColors.Window;
            this.tpSeafile.Controls.Add(this.cbSeafileAPIURL);
            this.tpSeafile.Controls.Add(this.grpSeafileShareSettings);
            this.tpSeafile.Controls.Add(this.btnSeafileLibraryPasswordValidate);
            this.tpSeafile.Controls.Add(this.txtSeafileLibraryPassword);
            this.tpSeafile.Controls.Add(this.lblSeafileLibraryPassword);
            this.tpSeafile.Controls.Add(this.lvSeafileLibraries);
            this.tpSeafile.Controls.Add(this.btnSeafilePathValidate);
            this.tpSeafile.Controls.Add(this.txtSeafileDirectoryPath);
            this.tpSeafile.Controls.Add(this.lblSeafileWritePermNotif);
            this.tpSeafile.Controls.Add(this.lblSeafilePath);
            this.tpSeafile.Controls.Add(this.txtSeafileUploadLocationRefresh);
            this.tpSeafile.Controls.Add(this.lblSeafileSelectLibrary);
            this.tpSeafile.Controls.Add(this.grpSeafileAccInfo);
            this.tpSeafile.Controls.Add(this.btnSeafileCheckAuthToken);
            this.tpSeafile.Controls.Add(this.btnSeafileCheckAPIURL);
            this.tpSeafile.Controls.Add(this.grpSeafileObtainAuthToken);
            this.tpSeafile.Controls.Add(this.cbSeafileIgnoreInvalidCert);
            this.tpSeafile.Controls.Add(this.cbSeafileCreateShareableURL);
            this.tpSeafile.Controls.Add(this.txtSeafileAuthToken);
            this.tpSeafile.Controls.Add(this.lblSeafileAuthToken);
            this.tpSeafile.Controls.Add(this.lblSeafileAPIURL);
            resources.ApplyResources(this.tpSeafile, "tpSeafile");
            this.tpSeafile.Name = "tpSeafile";
            // 
            // cbSeafileAPIURL
            // 
            this.cbSeafileAPIURL.FormattingEnabled = true;
            this.cbSeafileAPIURL.Items.AddRange(new object[] {
            resources.GetString("cbSeafileAPIURL.Items"),
            resources.GetString("cbSeafileAPIURL.Items1")});
            resources.ApplyResources(this.cbSeafileAPIURL, "cbSeafileAPIURL");
            this.cbSeafileAPIURL.Name = "cbSeafileAPIURL";
            this.cbSeafileAPIURL.TextChanged += new System.EventHandler(this.cbSeafileAPIURL_TextChanged);
            // 
            // grpSeafileShareSettings
            // 
            this.grpSeafileShareSettings.Controls.Add(this.txtSeafileSharePassword);
            this.grpSeafileShareSettings.Controls.Add(this.lblSeafileSharePassword);
            this.grpSeafileShareSettings.Controls.Add(this.nudSeafileExpireDays);
            this.grpSeafileShareSettings.Controls.Add(this.lblSeafileDaysToExpire);
            resources.ApplyResources(this.grpSeafileShareSettings, "grpSeafileShareSettings");
            this.grpSeafileShareSettings.Name = "grpSeafileShareSettings";
            this.grpSeafileShareSettings.TabStop = false;
            // 
            // txtSeafileSharePassword
            // 
            resources.ApplyResources(this.txtSeafileSharePassword, "txtSeafileSharePassword");
            this.txtSeafileSharePassword.Name = "txtSeafileSharePassword";
            this.txtSeafileSharePassword.UseSystemPasswordChar = true;
            this.txtSeafileSharePassword.TextChanged += new System.EventHandler(this.txtSeafileSharePassword_TextChanged);
            // 
            // lblSeafileSharePassword
            // 
            resources.ApplyResources(this.lblSeafileSharePassword, "lblSeafileSharePassword");
            this.lblSeafileSharePassword.Name = "lblSeafileSharePassword";
            // 
            // nudSeafileExpireDays
            // 
            resources.ApplyResources(this.nudSeafileExpireDays, "nudSeafileExpireDays");
            this.nudSeafileExpireDays.Maximum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.nudSeafileExpireDays.Name = "nudSeafileExpireDays";
            this.nudSeafileExpireDays.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.nudSeafileExpireDays.ValueChanged += new System.EventHandler(this.nudSeafileExpireDays_ValueChanged);
            // 
            // lblSeafileDaysToExpire
            // 
            resources.ApplyResources(this.lblSeafileDaysToExpire, "lblSeafileDaysToExpire");
            this.lblSeafileDaysToExpire.Name = "lblSeafileDaysToExpire";
            // 
            // btnSeafileLibraryPasswordValidate
            // 
            resources.ApplyResources(this.btnSeafileLibraryPasswordValidate, "btnSeafileLibraryPasswordValidate");
            this.btnSeafileLibraryPasswordValidate.Name = "btnSeafileLibraryPasswordValidate";
            this.btnSeafileLibraryPasswordValidate.UseVisualStyleBackColor = true;
            this.btnSeafileLibraryPasswordValidate.Click += new System.EventHandler(this.btnSeafileLibraryPasswordValidate_Click);
            // 
            // txtSeafileLibraryPassword
            // 
            resources.ApplyResources(this.txtSeafileLibraryPassword, "txtSeafileLibraryPassword");
            this.txtSeafileLibraryPassword.Name = "txtSeafileLibraryPassword";
            this.txtSeafileLibraryPassword.UseSystemPasswordChar = true;
            this.txtSeafileLibraryPassword.TextChanged += new System.EventHandler(this.txtSeafileLibraryPassword_TextChanged);
            // 
            // lblSeafileLibraryPassword
            // 
            resources.ApplyResources(this.lblSeafileLibraryPassword, "lblSeafileLibraryPassword");
            this.lblSeafileLibraryPassword.Name = "lblSeafileLibraryPassword";
            // 
            // lvSeafileLibraries
            // 
            this.lvSeafileLibraries.AllowColumnSort = true;
            this.lvSeafileLibraries.AutoFillColumn = true;
            this.lvSeafileLibraries.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSeafileLibraryName,
            this.colSeafileLibrarySize,
            this.colSeafileLibraryEncrypted});
            this.lvSeafileLibraries.DisableDeselect = true;
            this.lvSeafileLibraries.FullRowSelect = true;
            this.lvSeafileLibraries.HideSelection = false;
            resources.ApplyResources(this.lvSeafileLibraries, "lvSeafileLibraries");
            this.lvSeafileLibraries.Name = "lvSeafileLibraries";
            this.lvSeafileLibraries.UseCompatibleStateImageBehavior = false;
            this.lvSeafileLibraries.View = System.Windows.Forms.View.Details;
            this.lvSeafileLibraries.SelectedIndexChanged += new System.EventHandler(this.lvSeafileLibraries_SelectedIndexChanged);
            // 
            // colSeafileLibraryName
            // 
            resources.ApplyResources(this.colSeafileLibraryName, "colSeafileLibraryName");
            // 
            // colSeafileLibrarySize
            // 
            resources.ApplyResources(this.colSeafileLibrarySize, "colSeafileLibrarySize");
            // 
            // colSeafileLibraryEncrypted
            // 
            resources.ApplyResources(this.colSeafileLibraryEncrypted, "colSeafileLibraryEncrypted");
            // 
            // btnSeafilePathValidate
            // 
            resources.ApplyResources(this.btnSeafilePathValidate, "btnSeafilePathValidate");
            this.btnSeafilePathValidate.Name = "btnSeafilePathValidate";
            this.btnSeafilePathValidate.UseVisualStyleBackColor = true;
            this.btnSeafilePathValidate.Click += new System.EventHandler(this.btnSeafilePathValidate_Click);
            // 
            // txtSeafileDirectoryPath
            // 
            resources.ApplyResources(this.txtSeafileDirectoryPath, "txtSeafileDirectoryPath");
            this.txtSeafileDirectoryPath.Name = "txtSeafileDirectoryPath";
            this.txtSeafileDirectoryPath.TextChanged += new System.EventHandler(this.txtSeafileDirectoryPath_TextChanged);
            // 
            // lblSeafileWritePermNotif
            // 
            resources.ApplyResources(this.lblSeafileWritePermNotif, "lblSeafileWritePermNotif");
            this.lblSeafileWritePermNotif.Name = "lblSeafileWritePermNotif";
            // 
            // lblSeafilePath
            // 
            resources.ApplyResources(this.lblSeafilePath, "lblSeafilePath");
            this.lblSeafilePath.Name = "lblSeafilePath";
            // 
            // txtSeafileUploadLocationRefresh
            // 
            resources.ApplyResources(this.txtSeafileUploadLocationRefresh, "txtSeafileUploadLocationRefresh");
            this.txtSeafileUploadLocationRefresh.Name = "txtSeafileUploadLocationRefresh";
            this.txtSeafileUploadLocationRefresh.UseVisualStyleBackColor = true;
            this.txtSeafileUploadLocationRefresh.Click += new System.EventHandler(this.txtSeafileUploadLocationRefresh_Click);
            // 
            // lblSeafileSelectLibrary
            // 
            resources.ApplyResources(this.lblSeafileSelectLibrary, "lblSeafileSelectLibrary");
            this.lblSeafileSelectLibrary.Name = "lblSeafileSelectLibrary";
            // 
            // grpSeafileAccInfo
            // 
            this.grpSeafileAccInfo.Controls.Add(this.btnRefreshSeafileAccInfo);
            this.grpSeafileAccInfo.Controls.Add(this.txtSeafileAccInfoUsage);
            this.grpSeafileAccInfo.Controls.Add(this.txtSeafileAccInfoEmail);
            this.grpSeafileAccInfo.Controls.Add(this.lblSeafileAccInfoEmail);
            this.grpSeafileAccInfo.Controls.Add(this.lblSeafileAccInfoUsage);
            resources.ApplyResources(this.grpSeafileAccInfo, "grpSeafileAccInfo");
            this.grpSeafileAccInfo.Name = "grpSeafileAccInfo";
            this.grpSeafileAccInfo.TabStop = false;
            // 
            // btnRefreshSeafileAccInfo
            // 
            resources.ApplyResources(this.btnRefreshSeafileAccInfo, "btnRefreshSeafileAccInfo");
            this.btnRefreshSeafileAccInfo.Name = "btnRefreshSeafileAccInfo";
            this.btnRefreshSeafileAccInfo.UseVisualStyleBackColor = true;
            this.btnRefreshSeafileAccInfo.Click += new System.EventHandler(this.btnRefreshSeafileAccInfo_Click);
            // 
            // txtSeafileAccInfoUsage
            // 
            resources.ApplyResources(this.txtSeafileAccInfoUsage, "txtSeafileAccInfoUsage");
            this.txtSeafileAccInfoUsage.Name = "txtSeafileAccInfoUsage";
            this.txtSeafileAccInfoUsage.ReadOnly = true;
            // 
            // txtSeafileAccInfoEmail
            // 
            resources.ApplyResources(this.txtSeafileAccInfoEmail, "txtSeafileAccInfoEmail");
            this.txtSeafileAccInfoEmail.Name = "txtSeafileAccInfoEmail";
            this.txtSeafileAccInfoEmail.ReadOnly = true;
            // 
            // lblSeafileAccInfoEmail
            // 
            resources.ApplyResources(this.lblSeafileAccInfoEmail, "lblSeafileAccInfoEmail");
            this.lblSeafileAccInfoEmail.Name = "lblSeafileAccInfoEmail";
            // 
            // lblSeafileAccInfoUsage
            // 
            resources.ApplyResources(this.lblSeafileAccInfoUsage, "lblSeafileAccInfoUsage");
            this.lblSeafileAccInfoUsage.Name = "lblSeafileAccInfoUsage";
            // 
            // btnSeafileCheckAuthToken
            // 
            resources.ApplyResources(this.btnSeafileCheckAuthToken, "btnSeafileCheckAuthToken");
            this.btnSeafileCheckAuthToken.Name = "btnSeafileCheckAuthToken";
            this.btnSeafileCheckAuthToken.UseVisualStyleBackColor = true;
            this.btnSeafileCheckAuthToken.Click += new System.EventHandler(this.btnSeafileCheckAuthToken_Click);
            // 
            // btnSeafileCheckAPIURL
            // 
            resources.ApplyResources(this.btnSeafileCheckAPIURL, "btnSeafileCheckAPIURL");
            this.btnSeafileCheckAPIURL.Name = "btnSeafileCheckAPIURL";
            this.btnSeafileCheckAPIURL.UseVisualStyleBackColor = true;
            this.btnSeafileCheckAPIURL.Click += new System.EventHandler(this.btnSeafileCheckAPIURL_Click);
            // 
            // grpSeafileObtainAuthToken
            // 
            this.grpSeafileObtainAuthToken.Controls.Add(this.btnSeafileGetAuthToken);
            this.grpSeafileObtainAuthToken.Controls.Add(this.txtSeafilePassword);
            this.grpSeafileObtainAuthToken.Controls.Add(this.txtSeafileUsername);
            this.grpSeafileObtainAuthToken.Controls.Add(this.lblSeafileUsername);
            this.grpSeafileObtainAuthToken.Controls.Add(this.lblSeafilePassword);
            resources.ApplyResources(this.grpSeafileObtainAuthToken, "grpSeafileObtainAuthToken");
            this.grpSeafileObtainAuthToken.Name = "grpSeafileObtainAuthToken";
            this.grpSeafileObtainAuthToken.TabStop = false;
            // 
            // btnSeafileGetAuthToken
            // 
            resources.ApplyResources(this.btnSeafileGetAuthToken, "btnSeafileGetAuthToken");
            this.btnSeafileGetAuthToken.Name = "btnSeafileGetAuthToken";
            this.btnSeafileGetAuthToken.UseVisualStyleBackColor = true;
            this.btnSeafileGetAuthToken.Click += new System.EventHandler(this.btnSeafileGetAuthToken_Click);
            // 
            // txtSeafilePassword
            // 
            resources.ApplyResources(this.txtSeafilePassword, "txtSeafilePassword");
            this.txtSeafilePassword.Name = "txtSeafilePassword";
            this.txtSeafilePassword.UseSystemPasswordChar = true;
            this.txtSeafilePassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSeafilePassword_KeyUp);
            // 
            // txtSeafileUsername
            // 
            resources.ApplyResources(this.txtSeafileUsername, "txtSeafileUsername");
            this.txtSeafileUsername.Name = "txtSeafileUsername";
            // 
            // lblSeafileUsername
            // 
            resources.ApplyResources(this.lblSeafileUsername, "lblSeafileUsername");
            this.lblSeafileUsername.Name = "lblSeafileUsername";
            // 
            // lblSeafilePassword
            // 
            resources.ApplyResources(this.lblSeafilePassword, "lblSeafilePassword");
            this.lblSeafilePassword.Name = "lblSeafilePassword";
            // 
            // cbSeafileIgnoreInvalidCert
            // 
            resources.ApplyResources(this.cbSeafileIgnoreInvalidCert, "cbSeafileIgnoreInvalidCert");
            this.cbSeafileIgnoreInvalidCert.Name = "cbSeafileIgnoreInvalidCert";
            this.cbSeafileIgnoreInvalidCert.UseVisualStyleBackColor = true;
            this.cbSeafileIgnoreInvalidCert.CheckedChanged += new System.EventHandler(this.cbSeafileIgnoreInvalidCert_CheckedChanged);
            // 
            // cbSeafileCreateShareableURL
            // 
            resources.ApplyResources(this.cbSeafileCreateShareableURL, "cbSeafileCreateShareableURL");
            this.cbSeafileCreateShareableURL.Name = "cbSeafileCreateShareableURL";
            this.cbSeafileCreateShareableURL.UseVisualStyleBackColor = true;
            this.cbSeafileCreateShareableURL.CheckedChanged += new System.EventHandler(this.cbSeafileCreateShareableURL_CheckedChanged);
            // 
            // txtSeafileAuthToken
            // 
            resources.ApplyResources(this.txtSeafileAuthToken, "txtSeafileAuthToken");
            this.txtSeafileAuthToken.Name = "txtSeafileAuthToken";
            this.txtSeafileAuthToken.TextChanged += new System.EventHandler(this.txtSeafileAuthToken_TextChanged);
            // 
            // lblSeafileAuthToken
            // 
            resources.ApplyResources(this.lblSeafileAuthToken, "lblSeafileAuthToken");
            this.lblSeafileAuthToken.Name = "lblSeafileAuthToken";
            // 
            // lblSeafileAPIURL
            // 
            resources.ApplyResources(this.lblSeafileAPIURL, "lblSeafileAPIURL");
            this.lblSeafileAPIURL.Name = "lblSeafileAPIURL";
            // 
            // tpSharedFolder
            // 
            this.tpSharedFolder.BackColor = System.Drawing.SystemColors.Window;
            this.tpSharedFolder.Controls.Add(this.lbSharedFolderAccounts);
            this.tpSharedFolder.Controls.Add(this.pgSharedFolderAccount);
            this.tpSharedFolder.Controls.Add(this.btnSharedFolderDuplicate);
            this.tpSharedFolder.Controls.Add(this.btnSharedFolderRemove);
            this.tpSharedFolder.Controls.Add(this.btnSharedFolderAdd);
            this.tpSharedFolder.Controls.Add(this.lblSharedFolderFiles);
            this.tpSharedFolder.Controls.Add(this.lblSharedFolderText);
            this.tpSharedFolder.Controls.Add(this.cboSharedFolderFiles);
            this.tpSharedFolder.Controls.Add(this.lblSharedFolderImages);
            this.tpSharedFolder.Controls.Add(this.cboSharedFolderText);
            this.tpSharedFolder.Controls.Add(this.cboSharedFolderImages);
            resources.ApplyResources(this.tpSharedFolder, "tpSharedFolder");
            this.tpSharedFolder.Name = "tpSharedFolder";
            // 
            // lbSharedFolderAccounts
            // 
            this.lbSharedFolderAccounts.FormattingEnabled = true;
            resources.ApplyResources(this.lbSharedFolderAccounts, "lbSharedFolderAccounts");
            this.lbSharedFolderAccounts.Name = "lbSharedFolderAccounts";
            this.lbSharedFolderAccounts.SelectedIndexChanged += new System.EventHandler(this.lbSharedFolderAccounts_SelectedIndexChanged);
            // 
            // pgSharedFolderAccount
            // 
            resources.ApplyResources(this.pgSharedFolderAccount, "pgSharedFolderAccount");
            this.pgSharedFolderAccount.Name = "pgSharedFolderAccount";
            this.pgSharedFolderAccount.PropertySort = System.Windows.Forms.PropertySort.NoSort;
            this.pgSharedFolderAccount.ToolbarVisible = false;
            this.pgSharedFolderAccount.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.pgSharedFolderAccount_PropertyValueChanged);
            // 
            // btnSharedFolderDuplicate
            // 
            resources.ApplyResources(this.btnSharedFolderDuplicate, "btnSharedFolderDuplicate");
            this.btnSharedFolderDuplicate.Name = "btnSharedFolderDuplicate";
            this.btnSharedFolderDuplicate.UseVisualStyleBackColor = true;
            this.btnSharedFolderDuplicate.Click += new System.EventHandler(this.btnSharedFolderDuplicate_Click);
            // 
            // btnSharedFolderRemove
            // 
            resources.ApplyResources(this.btnSharedFolderRemove, "btnSharedFolderRemove");
            this.btnSharedFolderRemove.Name = "btnSharedFolderRemove";
            this.btnSharedFolderRemove.UseVisualStyleBackColor = true;
            this.btnSharedFolderRemove.Click += new System.EventHandler(this.btnSharedFolderRemove_Click);
            // 
            // btnSharedFolderAdd
            // 
            resources.ApplyResources(this.btnSharedFolderAdd, "btnSharedFolderAdd");
            this.btnSharedFolderAdd.Name = "btnSharedFolderAdd";
            this.btnSharedFolderAdd.UseVisualStyleBackColor = true;
            this.btnSharedFolderAdd.Click += new System.EventHandler(this.btnSharedFolderAdd_Click);
            // 
            // lblSharedFolderFiles
            // 
            resources.ApplyResources(this.lblSharedFolderFiles, "lblSharedFolderFiles");
            this.lblSharedFolderFiles.Name = "lblSharedFolderFiles";
            // 
            // lblSharedFolderText
            // 
            resources.ApplyResources(this.lblSharedFolderText, "lblSharedFolderText");
            this.lblSharedFolderText.Name = "lblSharedFolderText";
            // 
            // cboSharedFolderFiles
            // 
            this.cboSharedFolderFiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSharedFolderFiles.FormattingEnabled = true;
            resources.ApplyResources(this.cboSharedFolderFiles, "cboSharedFolderFiles");
            this.cboSharedFolderFiles.Name = "cboSharedFolderFiles";
            this.cboSharedFolderFiles.SelectedIndexChanged += new System.EventHandler(this.cboSharedFolderFiles_SelectedIndexChanged);
            // 
            // lblSharedFolderImages
            // 
            resources.ApplyResources(this.lblSharedFolderImages, "lblSharedFolderImages");
            this.lblSharedFolderImages.Name = "lblSharedFolderImages";
            // 
            // cboSharedFolderText
            // 
            this.cboSharedFolderText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSharedFolderText.FormattingEnabled = true;
            resources.ApplyResources(this.cboSharedFolderText, "cboSharedFolderText");
            this.cboSharedFolderText.Name = "cboSharedFolderText";
            this.cboSharedFolderText.SelectedIndexChanged += new System.EventHandler(this.cboSharedFolderText_SelectedIndexChanged);
            // 
            // cboSharedFolderImages
            // 
            this.cboSharedFolderImages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSharedFolderImages.FormattingEnabled = true;
            resources.ApplyResources(this.cboSharedFolderImages, "cboSharedFolderImages");
            this.cboSharedFolderImages.Name = "cboSharedFolderImages";
            this.cboSharedFolderImages.SelectedIndexChanged += new System.EventHandler(this.cboSharedFolderImages_SelectedIndexChanged);
            // 
            // tpEmail
            // 
            this.tpEmail.BackColor = System.Drawing.SystemColors.Window;
            this.tpEmail.Controls.Add(this.txtEmailAutomaticSendTo);
            this.tpEmail.Controls.Add(this.cbEmailAutomaticSend);
            this.tpEmail.Controls.Add(this.lblEmailSmtpServer);
            this.tpEmail.Controls.Add(this.lblEmailPassword);
            this.tpEmail.Controls.Add(this.cbEmailRememberLastTo);
            this.tpEmail.Controls.Add(this.txtEmailFrom);
            this.tpEmail.Controls.Add(this.txtEmailPassword);
            this.tpEmail.Controls.Add(this.txtEmailDefaultBody);
            this.tpEmail.Controls.Add(this.lblEmailFrom);
            this.tpEmail.Controls.Add(this.txtEmailSmtpServer);
            this.tpEmail.Controls.Add(this.lblEmailDefaultSubject);
            this.tpEmail.Controls.Add(this.lblEmailDefaultBody);
            this.tpEmail.Controls.Add(this.nudEmailSmtpPort);
            this.tpEmail.Controls.Add(this.lblEmailSmtpPort);
            this.tpEmail.Controls.Add(this.txtEmailDefaultSubject);
            resources.ApplyResources(this.tpEmail, "tpEmail");
            this.tpEmail.Name = "tpEmail";
            // 
            // txtEmailAutomaticSendTo
            // 
            resources.ApplyResources(this.txtEmailAutomaticSendTo, "txtEmailAutomaticSendTo");
            this.txtEmailAutomaticSendTo.Name = "txtEmailAutomaticSendTo";
            this.txtEmailAutomaticSendTo.TextChanged += new System.EventHandler(this.txtEmailAutomaticSendTo_TextChanged);
            // 
            // cbEmailAutomaticSend
            // 
            resources.ApplyResources(this.cbEmailAutomaticSend, "cbEmailAutomaticSend");
            this.cbEmailAutomaticSend.Name = "cbEmailAutomaticSend";
            this.cbEmailAutomaticSend.UseVisualStyleBackColor = true;
            this.cbEmailAutomaticSend.CheckedChanged += new System.EventHandler(this.cbEmailAutomaticSend_CheckedChanged);
            // 
            // lblEmailSmtpServer
            // 
            resources.ApplyResources(this.lblEmailSmtpServer, "lblEmailSmtpServer");
            this.lblEmailSmtpServer.Name = "lblEmailSmtpServer";
            // 
            // lblEmailPassword
            // 
            resources.ApplyResources(this.lblEmailPassword, "lblEmailPassword");
            this.lblEmailPassword.Name = "lblEmailPassword";
            // 
            // cbEmailRememberLastTo
            // 
            resources.ApplyResources(this.cbEmailRememberLastTo, "cbEmailRememberLastTo");
            this.cbEmailRememberLastTo.Name = "cbEmailRememberLastTo";
            this.cbEmailRememberLastTo.UseVisualStyleBackColor = true;
            this.cbEmailRememberLastTo.CheckedChanged += new System.EventHandler(this.cbRememberLastToEmail_CheckedChanged);
            // 
            // txtEmailFrom
            // 
            resources.ApplyResources(this.txtEmailFrom, "txtEmailFrom");
            this.txtEmailFrom.Name = "txtEmailFrom";
            this.txtEmailFrom.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtEmailPassword
            // 
            resources.ApplyResources(this.txtEmailPassword, "txtEmailPassword");
            this.txtEmailPassword.Name = "txtEmailPassword";
            this.txtEmailPassword.UseSystemPasswordChar = true;
            this.txtEmailPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtEmailDefaultBody
            // 
            resources.ApplyResources(this.txtEmailDefaultBody, "txtEmailDefaultBody");
            this.txtEmailDefaultBody.Name = "txtEmailDefaultBody";
            this.txtEmailDefaultBody.TextChanged += new System.EventHandler(this.txtDefaultBody_TextChanged);
            // 
            // lblEmailFrom
            // 
            resources.ApplyResources(this.lblEmailFrom, "lblEmailFrom");
            this.lblEmailFrom.Name = "lblEmailFrom";
            // 
            // txtEmailSmtpServer
            // 
            resources.ApplyResources(this.txtEmailSmtpServer, "txtEmailSmtpServer");
            this.txtEmailSmtpServer.Name = "txtEmailSmtpServer";
            this.txtEmailSmtpServer.TextChanged += new System.EventHandler(this.txtSmtpServer_TextChanged);
            // 
            // lblEmailDefaultSubject
            // 
            resources.ApplyResources(this.lblEmailDefaultSubject, "lblEmailDefaultSubject");
            this.lblEmailDefaultSubject.Name = "lblEmailDefaultSubject";
            // 
            // lblEmailDefaultBody
            // 
            resources.ApplyResources(this.lblEmailDefaultBody, "lblEmailDefaultBody");
            this.lblEmailDefaultBody.Name = "lblEmailDefaultBody";
            // 
            // nudEmailSmtpPort
            // 
            resources.ApplyResources(this.nudEmailSmtpPort, "nudEmailSmtpPort");
            this.nudEmailSmtpPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudEmailSmtpPort.Name = "nudEmailSmtpPort";
            this.nudEmailSmtpPort.Value = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudEmailSmtpPort.ValueChanged += new System.EventHandler(this.nudSmtpPort_ValueChanged);
            // 
            // lblEmailSmtpPort
            // 
            resources.ApplyResources(this.lblEmailSmtpPort, "lblEmailSmtpPort");
            this.lblEmailSmtpPort.Name = "lblEmailSmtpPort";
            // 
            // txtEmailDefaultSubject
            // 
            resources.ApplyResources(this.txtEmailDefaultSubject, "txtEmailDefaultSubject");
            this.txtEmailDefaultSubject.Name = "txtEmailDefaultSubject";
            this.txtEmailDefaultSubject.TextChanged += new System.EventHandler(this.txtDefaultSubject_TextChanged);
            // 
            // btnCopyShowFiles
            // 
            resources.ApplyResources(this.btnCopyShowFiles, "btnCopyShowFiles");
            this.btnCopyShowFiles.Name = "btnCopyShowFiles";
            // 
            // tpTextUploaders
            // 
            this.tpTextUploaders.BackColor = System.Drawing.SystemColors.Window;
            this.tpTextUploaders.Controls.Add(this.tcTextUploaders);
            resources.ApplyResources(this.tpTextUploaders, "tpTextUploaders");
            this.tpTextUploaders.Name = "tpTextUploaders";
            // 
            // tcTextUploaders
            // 
            resources.ApplyResources(this.tcTextUploaders, "tcTextUploaders");
            this.tcTextUploaders.Name = "tcTextUploaders";
            this.tcTextUploaders.SelectedIndex = 0;
            // 
            // tcImageUploaders
            // 
            resources.ApplyResources(this.tcImageUploaders, "tcImageUploaders");
            this.tcImageUploaders.Name = "tcImageUploaders";
            this.tcImageUploaders.SelectedIndex = 0;
            // 
            // tcUploaders
            // 
            this.tcUploaders.Controls.Add(this.tpImageUploaders);
            this.tcUploaders.Controls.Add(this.tpTextUploaders);
            this.tcUploaders.Controls.Add(this.tpFileUploaders);
            this.tcUploaders.Controls.Add(this.tpURLShorteners);
            this.tcUploaders.Controls.Add(this.tpOtherUploaders);
            resources.ApplyResources(this.tcUploaders, "tcUploaders");
            this.tcUploaders.Name = "tcUploaders";
            this.tcUploaders.SelectedIndex = 0;
            // 
            // lblWidthHint
            // 
            this.lblWidthHint.BackColor = System.Drawing.SystemColors.Highlight;
            resources.ApplyResources(this.lblWidthHint, "lblWidthHint");
            this.lblWidthHint.Name = "lblWidthHint";
            // 
            // ttlvMain
            // 
            resources.ApplyResources(this.ttlvMain, "ttlvMain");
            this.ttlvMain.ImageList = null;
            this.ttlvMain.ListViewSize = 180;
            this.ttlvMain.MainTabControl = null;
            this.ttlvMain.Name = "ttlvMain";
            // 
            // actRapidShareAccountType
            // 
            resources.ApplyResources(this.actRapidShareAccountType, "actRapidShareAccountType");
            this.actRapidShareAccountType.Name = "actRapidShareAccountType";
            this.actRapidShareAccountType.SelectedAccountType = ShareX.UploadersLib.AccountType.Anonymous;
            // 
            // UploadersConfigForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.lblWidthHint);
            this.Controls.Add(this.tcUploaders);
            this.Controls.Add(this.ttlvMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UploadersConfigForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Shown += new System.EventHandler(this.UploadersConfigForm_Shown);
            this.Resize += new System.EventHandler(this.UploadersConfigForm_Resize);
            this.tpOtherUploaders.ResumeLayout(false);
            this.tcOtherUploaders.ResumeLayout(false);
            this.tpCustomUploaders.ResumeLayout(false);
            this.tpCustomUploaders.PerformLayout();
            this.pCustomUploader.ResumeLayout(false);
            this.pCustomUploader.PerformLayout();
            this.tcCustomUploaderResponseParse.ResumeLayout(false);
            this.tpCustomUploaderJsonParse.ResumeLayout(false);
            this.tpCustomUploaderJsonParse.PerformLayout();
            this.tpCustomUploaderXmlParse.ResumeLayout(false);
            this.tpCustomUploaderXmlParse.PerformLayout();
            this.tpCustomUploaderRegexParse.ResumeLayout(false);
            this.tpCustomUploaderRegexParse.PerformLayout();
            this.tcCustomUploaderArguments.ResumeLayout(false);
            this.tpCustomUploaderArguments.ResumeLayout(false);
            this.tpCustomUploaderArguments.PerformLayout();
            this.tpCustomUploaderHeaders.ResumeLayout(false);
            this.tpCustomUploaderHeaders.PerformLayout();
            this.gbCustomUploaders.ResumeLayout(false);
            this.tpURLShorteners.ResumeLayout(false);
            this.tcURLShorteners.ResumeLayout(false);
            this.tpFileUploaders.ResumeLayout(false);
            this.tcFileUploaders.ResumeLayout(false);
            this.tpFTP.ResumeLayout(false);
            this.tpFTP.PerformLayout();
            this.gbFTPAccount.ResumeLayout(false);
            this.gbFTPAccount.PerformLayout();
            this.gbSFTP.ResumeLayout(false);
            this.gbSFTP.PerformLayout();
            this.pFTPTransferMode.ResumeLayout(false);
            this.pFTPTransferMode.PerformLayout();
            this.pFTPProtocol.ResumeLayout(false);
            this.pFTPProtocol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFTPPort)).EndInit();
            this.gbFTPS.ResumeLayout(false);
            this.gbFTPS.PerformLayout();
            this.tpJira.ResumeLayout(false);
            this.tpJira.PerformLayout();
            this.gbJiraServer.ResumeLayout(false);
            this.gbJiraServer.PerformLayout();
            this.tpSeafile.ResumeLayout(false);
            this.tpSeafile.PerformLayout();
            this.grpSeafileShareSettings.ResumeLayout(false);
            this.grpSeafileShareSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeafileExpireDays)).EndInit();
            this.grpSeafileAccInfo.ResumeLayout(false);
            this.grpSeafileAccInfo.PerformLayout();
            this.grpSeafileObtainAuthToken.ResumeLayout(false);
            this.grpSeafileObtainAuthToken.PerformLayout();
            this.tpSharedFolder.ResumeLayout(false);
            this.tpSharedFolder.PerformLayout();
            this.tpEmail.ResumeLayout(false);
            this.tpEmail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEmailSmtpPort)).EndInit();
            this.tpTextUploaders.ResumeLayout(false);
            this.tcTextUploaders.ResumeLayout(false);
            this.tcUploaders.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion Windows Form Designer generated code

        private System.Windows.Forms.TextBox txtRapidSharePremiumUserName;
        private AccountTypeControl actRapidShareAccountType;
        private System.Windows.Forms.ToolTip ttHelpTip;
        private ShareX.HelpersLib.TabToListView ttlvMain;
        private System.Windows.Forms.TabPage tpOtherUploaders;
        private System.Windows.Forms.TabControl tcOtherUploaders;
        private System.Windows.Forms.Button btnCustomUploaderHelp;
        private System.Windows.Forms.Label lblCustomUploaderImageUploader;
        private System.Windows.Forms.Button btnCustomUploaderFileUploaderTest;
        private System.Windows.Forms.Label lblCustomUploaderFileUploader;
        private System.Windows.Forms.Button btnCustomUploaderImageUploaderTest;
        private System.Windows.Forms.Label lblCustomUploaderTestResult;
        private System.Windows.Forms.TextBox txtCustomUploaderDeletionURL;
        private System.Windows.Forms.ComboBox cbCustomUploaderFileUploader;
        private System.Windows.Forms.Label lblCustomUploaderDeletionURL;
        private System.Windows.Forms.Button btnCustomUploaderShowLastResponse;
        private System.Windows.Forms.Label lblCustomUploaderResponseType;
        private System.Windows.Forms.ComboBox cbCustomUploaderURLShortener;
        private System.Windows.Forms.GroupBox gbCustomUploaders;
        private System.Windows.Forms.ListBox lbCustomUploaderList;
        private System.Windows.Forms.Button btnCustomUploaderRemove;
        private System.Windows.Forms.TextBox txtCustomUploaderName;
        private System.Windows.Forms.Button btnCustomUploaderAdd;
        private System.Windows.Forms.Label lblCustomUploaderTextUploader;
        private System.Windows.Forms.Label lblCustomUploaderRequestURL;
        private System.Windows.Forms.Button btnCustomUploaderURLShortenerTest;
        private System.Windows.Forms.Button btnCustomUploaderRegexpUpdate;
        private System.Windows.Forms.TextBox txtCustomUploaderRegexp;
        private ShareX.HelpersLib.MyListView lvCustomUploaderRegexps;
        private System.Windows.Forms.ColumnHeader lvRegexpsColumn;
        private System.Windows.Forms.Button btnCustomUploaderRegexpRemove;
        private System.Windows.Forms.Button btnCustomUploaderRegexpAdd;
        private System.Windows.Forms.ComboBox cbCustomUploaderTextUploader;
        private System.Windows.Forms.TextBox txtCustomUploaderThumbnailURL;
        private System.Windows.Forms.Label lblCustomUploaderURLShortener;
        private System.Windows.Forms.ComboBox cbCustomUploaderResponseType;
        private System.Windows.Forms.Button btnCustomUploaderTextUploaderTest;
        private System.Windows.Forms.TextBox txtCustomUploaderURL;
        private System.Windows.Forms.ComboBox cbCustomUploaderImageUploader;
        private System.Windows.Forms.TextBox txtCustomUploaderRequestURL;
        private System.Windows.Forms.RichTextBox txtCustomUploaderLog;
        private System.Windows.Forms.Label lblCustomUploaderThumbnailURL;
        private System.Windows.Forms.Label lblCustomUploaderFileForm;
        private System.Windows.Forms.Label lblCustomUploaderRequestType;
        private System.Windows.Forms.ComboBox cbCustomUploaderRequestType;
        private System.Windows.Forms.TextBox txtCustomUploaderFileForm;
        private System.Windows.Forms.Label lblCustomUploaderURL;
        private System.Windows.Forms.Button btnCustomUploaderArgUpdate;
        private System.Windows.Forms.TextBox txtCustomUploaderArgValue;
        private System.Windows.Forms.Button btnCustomUploaderArgRemove;
        private ShareX.HelpersLib.MyListView lvCustomUploaderArguments;
        private System.Windows.Forms.ColumnHeader chCustomUploaderArgumentsName;
        private System.Windows.Forms.ColumnHeader chCustomUploaderArgumentsValue;
        private System.Windows.Forms.Button btnCustomUploaderArgAdd;
        private System.Windows.Forms.TextBox txtCustomUploaderArgName;
        private System.Windows.Forms.TabPage tpURLShorteners;
        private System.Windows.Forms.TabControl tcURLShorteners;
        internal System.Windows.Forms.TabPage tpFileUploaders;
        private System.Windows.Forms.TabControl tcFileUploaders;
        private System.Windows.Forms.Button btnCopyShowFiles;
        internal System.Windows.Forms.TabPage tpFTP;
        private System.Windows.Forms.Button btnFTPClient;
        private System.Windows.Forms.Label lblFTPFile;
        private System.Windows.Forms.Label lblFTPText;
        private System.Windows.Forms.Label lblFTPImage;
        private System.Windows.Forms.ComboBox cbFTPImage;
        private System.Windows.Forms.ComboBox cbFTPFile;
        private System.Windows.Forms.ComboBox cbFTPText;
        private System.Windows.Forms.TextBox txtJiraIssuePrefix;
        private System.Windows.Forms.Label lblJiraIssuePrefix;
        private System.Windows.Forms.GroupBox gbJiraServer;
        private System.Windows.Forms.TextBox txtJiraConfigHelp;
        private System.Windows.Forms.TextBox txtJiraHost;
        private System.Windows.Forms.Label lblJiraHost;
        private OAuthControl oAuthJira;
        private System.Windows.Forms.Label lblEmailSmtpServer;
        private System.Windows.Forms.Label lblEmailPassword;
        private System.Windows.Forms.CheckBox cbEmailRememberLastTo;
        private System.Windows.Forms.TextBox txtEmailFrom;
        private System.Windows.Forms.TextBox txtEmailPassword;
        private System.Windows.Forms.TextBox txtEmailDefaultBody;
        private System.Windows.Forms.Label lblEmailFrom;
        private System.Windows.Forms.TextBox txtEmailSmtpServer;
        private System.Windows.Forms.Label lblEmailDefaultSubject;
        private System.Windows.Forms.Label lblEmailDefaultBody;
        private System.Windows.Forms.NumericUpDown nudEmailSmtpPort;
        private System.Windows.Forms.Label lblEmailSmtpPort;
        private System.Windows.Forms.TextBox txtEmailDefaultSubject;
        private System.Windows.Forms.Label lblSharedFolderFiles;
        private System.Windows.Forms.Label lblSharedFolderText;
        private System.Windows.Forms.Label lblSharedFolderImages;
        private System.Windows.Forms.ComboBox cboSharedFolderFiles;
        private System.Windows.Forms.ComboBox cboSharedFolderText;
        private System.Windows.Forms.ComboBox cboSharedFolderImages;
        private System.Windows.Forms.TabPage tpTextUploaders;
        private System.Windows.Forms.TabPage tpImageUploaders;
        private System.Windows.Forms.TabControl tcTextUploaders;
        private System.Windows.Forms.TabControl tcImageUploaders;
        private System.Windows.Forms.TabControl tcUploaders;
        private ShareX.HelpersLib.ExportImportControl eiCustomUploaders;
        private ShareX.HelpersLib.ExportImportControl eiFTP;
        private System.Windows.Forms.Label lblWidthHint;
        private System.Windows.Forms.Button btnCustomUploaderExamples;
        private System.Windows.Forms.Button btnCustomUploaderClearUploaders;
        private System.Windows.Forms.Button btnSeafileCheckAuthToken;
        private System.Windows.Forms.Button btnSeafileCheckAPIURL;
        private System.Windows.Forms.GroupBox grpSeafileObtainAuthToken;
        private System.Windows.Forms.Button btnSeafileGetAuthToken;
        private System.Windows.Forms.TextBox txtSeafilePassword;
        private System.Windows.Forms.TextBox txtSeafileUsername;
        private System.Windows.Forms.Label lblSeafileUsername;
        private System.Windows.Forms.Label lblSeafilePassword;
        private System.Windows.Forms.CheckBox cbSeafileIgnoreInvalidCert;
        private System.Windows.Forms.CheckBox cbSeafileCreateShareableURL;
        private System.Windows.Forms.TextBox txtSeafileAuthToken;
        private System.Windows.Forms.Label lblSeafileAuthToken;
        private System.Windows.Forms.Label lblSeafileAPIURL;
        private System.Windows.Forms.GroupBox grpSeafileAccInfo;
        private System.Windows.Forms.Button btnRefreshSeafileAccInfo;
        private System.Windows.Forms.TextBox txtSeafileAccInfoUsage;
        private System.Windows.Forms.TextBox txtSeafileAccInfoEmail;
        private System.Windows.Forms.Label lblSeafileAccInfoEmail;
        private System.Windows.Forms.Label lblSeafileAccInfoUsage;
        private System.Windows.Forms.Button txtSeafileUploadLocationRefresh;
        private System.Windows.Forms.Label lblSeafileSelectLibrary;
        private System.Windows.Forms.Label lblSeafileWritePermNotif;
        private HelpersLib.MyListView lvSeafileLibraries;
        private System.Windows.Forms.ColumnHeader colSeafileLibraryName;
        private System.Windows.Forms.Button btnSeafilePathValidate;
        private System.Windows.Forms.TextBox txtSeafileDirectoryPath;
        private System.Windows.Forms.Label lblSeafilePath;
        private System.Windows.Forms.ColumnHeader colSeafileLibrarySize;
        private System.Windows.Forms.ColumnHeader colSeafileLibraryEncrypted;
        private System.Windows.Forms.Button btnSeafileLibraryPasswordValidate;
        private System.Windows.Forms.TextBox txtSeafileLibraryPassword;
        private System.Windows.Forms.Label lblSeafileLibraryPassword;
        private System.Windows.Forms.GroupBox grpSeafileShareSettings;
        private System.Windows.Forms.TextBox txtSeafileSharePassword;
        private System.Windows.Forms.Label lblSeafileSharePassword;
        private System.Windows.Forms.NumericUpDown nudSeafileExpireDays;
        private System.Windows.Forms.Label lblSeafileDaysToExpire;
        private System.Windows.Forms.ComboBox cbSeafileAPIURL;
        private System.Windows.Forms.TabControl tcCustomUploaderArguments;
        private System.Windows.Forms.TabPage tpCustomUploaderArguments;
        private System.Windows.Forms.TabPage tpCustomUploaderHeaders;
        private System.Windows.Forms.Button btnCustomUploaderHeaderUpdate;
        private System.Windows.Forms.TextBox txtCustomUploaderHeaderName;
        private System.Windows.Forms.TextBox txtCustomUploaderHeaderValue;
        private System.Windows.Forms.Button btnCustomUploaderHeaderAdd;
        private System.Windows.Forms.Button btnCustomUploaderHeaderRemove;
        private HelpersLib.MyListView lvCustomUploaderHeaders;
        private System.Windows.Forms.ColumnHeader chCustomUploaderHeadersName;
        private System.Windows.Forms.ColumnHeader chCustomUploaderHeadersValue;
        private System.Windows.Forms.TabControl tcCustomUploaderResponseParse;
        private System.Windows.Forms.TabPage tpCustomUploaderRegexParse;
        private System.Windows.Forms.Button btnCustomUploaderRegexAddSyntax;
        private System.Windows.Forms.TabPage tpCustomUploaderJsonParse;
        private System.Windows.Forms.Label lblCustomUploaderJsonPathExample;
        private System.Windows.Forms.Label lblCustomUploaderJsonPath;
        private System.Windows.Forms.TextBox txtCustomUploaderJsonPath;
        private System.Windows.Forms.TabPage tpCustomUploaderXmlParse;
        private System.Windows.Forms.Button btnCustomUploaderJsonAddSyntax;
        private System.Windows.Forms.Button btnCustomUploadJsonPathHelp;
        private System.Windows.Forms.Button btnCustomUploaderXmlSyntaxAdd;
        private System.Windows.Forms.Button btnCustomUploaderXPathHelp;
        private System.Windows.Forms.Label lblCustomUploaderXPathExample;
        private System.Windows.Forms.Label lblCustomUploaderXPath;
        private System.Windows.Forms.TextBox txtCustomUploaderXPath;
        private System.Windows.Forms.Button btnCustomUploaderRegexHelp;
        private System.Windows.Forms.Button btnCustomUploadersExportAll;
        internal System.Windows.Forms.TabPage tpJira;
        internal System.Windows.Forms.TabPage tpSeafile;
        internal System.Windows.Forms.TabPage tpSharedFolder;
        internal System.Windows.Forms.TabPage tpEmail;
        internal System.Windows.Forms.TabPage tpCustomUploaders;
        private System.Windows.Forms.TextBox txtEmailAutomaticSendTo;
        private System.Windows.Forms.CheckBox cbEmailAutomaticSend;
        private HelpersLib.MenuButton mbCustomUploaderDestinationType;
        private System.Windows.Forms.ContextMenuStrip cmsCustomUploaderDestinationType;
        private System.Windows.Forms.Panel pFTPTransferMode;
        private System.Windows.Forms.RadioButton rbFTPTransferModeActive;
        private System.Windows.Forms.RadioButton rbFTPTransferModePassive;
        private System.Windows.Forms.Panel pFTPProtocol;
        private System.Windows.Forms.RadioButton rbFTPProtocolFTP;
        private System.Windows.Forms.RadioButton rbFTPProtocolFTPS;
        private System.Windows.Forms.RadioButton rbFTPProtocolSFTP;
        private System.Windows.Forms.Label lblFTPTransferMode;
        private System.Windows.Forms.Label lblFTPURLPreviewValue;
        private System.Windows.Forms.Label lblFTPURLPreview;
        private System.Windows.Forms.ComboBox cbFTPURLPathProtocol;
        private System.Windows.Forms.TextBox txtFTPURLPath;
        private System.Windows.Forms.Label lblFTPURLPath;
        private System.Windows.Forms.TextBox txtFTPRemoteDirectory;
        private System.Windows.Forms.Label lblFTPRemoteDirectory;
        private System.Windows.Forms.Button btnFTPRemove;
        private System.Windows.Forms.Button btnFTPAdd;
        private System.Windows.Forms.ComboBox cbFTPAccounts;
        private System.Windows.Forms.Label lblFTPAccounts;
        private System.Windows.Forms.TextBox txtFTPPassword;
        private System.Windows.Forms.Label lblFTPPassword;
        private System.Windows.Forms.TextBox txtFTPUsername;
        private System.Windows.Forms.Label lblFTPUsername;
        private System.Windows.Forms.NumericUpDown nudFTPPort;
        private System.Windows.Forms.Label lblFTPPort;
        private System.Windows.Forms.TextBox txtFTPHost;
        private System.Windows.Forms.Label lblFTPHost;
        private System.Windows.Forms.TextBox txtFTPName;
        private System.Windows.Forms.Label lblFTPName;
        private System.Windows.Forms.Label lblFTPProtocol;
        private System.Windows.Forms.CheckBox cbFTPRemoveFileExtension;
        private System.Windows.Forms.CheckBox cbFTPAppendRemoteDirectory;
        private System.Windows.Forms.Button btnFTPDuplicate;
        private System.Windows.Forms.Button btnFTPTest;
        private System.Windows.Forms.GroupBox gbFTPAccount;
        private System.Windows.Forms.GroupBox gbFTPS;
        private System.Windows.Forms.TextBox txtFTPSCertificateLocation;
        private System.Windows.Forms.Label lblFTPSCertificateLocation;
        private System.Windows.Forms.ComboBox cbFTPSEncryption;
        private System.Windows.Forms.Label lblFTPSEncryption;
        private System.Windows.Forms.Button btnFTPSCertificateLocationBrowse;
        private System.Windows.Forms.GroupBox gbSFTP;
        private System.Windows.Forms.TextBox txtSFTPKeyLocation;
        private System.Windows.Forms.Label lblSFTPKeyLocation;
        private System.Windows.Forms.TextBox txtSFTPKeyPassphrase;
        private System.Windows.Forms.Button btnSFTPKeyLocationBrowse;
        private System.Windows.Forms.Label lblSFTPKeyPassphrase;
        private System.Windows.Forms.Button btnCustomUploaderDuplicate;
        private System.Windows.Forms.Panel pCustomUploader;
        private System.Windows.Forms.Button btnCustomUploaderURLSharingServiceTest;
        private System.Windows.Forms.ComboBox cbCustomUploaderURLSharingService;
        private System.Windows.Forms.Label lblCustomUploaderURLSharingService;
        private System.Windows.Forms.Label lblCustomUploaderName;
        private System.Windows.Forms.Button btnSharedFolderDuplicate;
        private System.Windows.Forms.Button btnSharedFolderRemove;
        private System.Windows.Forms.Button btnSharedFolderAdd;
        private System.Windows.Forms.PropertyGrid pgSharedFolderAccount;
        private System.Windows.Forms.ListBox lbSharedFolderAccounts;
    }
}