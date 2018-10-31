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

using ShareX.HelpersLib;
using ShareX.UploadersLib.FileUploaders;
using ShareX.UploadersLib.ImageUploaders;
using ShareX.UploadersLib.Properties;
using ShareX.UploadersLib.TextUploaders;
using ShareX.UploadersLib.URLShorteners;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShareX.UploadersLib
{
    public partial class UploadersConfigForm : Form
    {
        public static bool IsInstanceActive => instance != null && !instance.IsDisposed;

        private static UploadersConfigForm instance;

        public UploadersConfig Config { get; private set; }

        private ImageList uploadersImageList;
        private URLType customUploaderURLType = URLType.URL;

        private UploadersConfigForm(UploadersConfig config)
        {
            Config = config;
            InitializeComponent();
            InitializeControls();
        }

        public static UploadersConfigForm GetFormInstance(UploadersConfig config)
        {
            if (!IsInstanceActive)
            {
                instance = new UploadersConfigForm(config);
            }

            return instance;
        }

        private void UploadersConfigForm_Shown(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private void UploadersConfigForm_Resize(object sender, EventArgs e)
        {
            Refresh();
        }

        private void InitializeControls()
        {
            Icon = ShareXResources.Icon;

            if (!string.IsNullOrEmpty(Config.FilePath))
            {
                Text += " - " + Config.FilePath;
            }

            AddIconToTabs();

            ttlvMain.ImageList = uploadersImageList;
            ttlvMain.MainTabControl = tcUploaders;
            ttlvMain.FocusListView();

            CodeMenuItem codeMenuItemInput = new CodeMenuItem("$input$", "Text/URL input");
            CodeMenuItem codeMenuItemFilename = new CodeMenuItem("$filename$", "File name");

            CodeMenu.Create<CodeMenuEntryFilename>(txtCustomUploaderArgValue,
                new CodeMenuEntryFilename[] { CodeMenuEntryFilename.n, CodeMenuEntryFilename.t, CodeMenuEntryFilename.pn },
                new CodeMenuItem[] { codeMenuItemInput, codeMenuItemFilename });
            CodeMenu.Create<CodeMenuEntryFilename>(txtCustomUploaderHeaderValue,
                new CodeMenuEntryFilename[] { CodeMenuEntryFilename.n, CodeMenuEntryFilename.t, CodeMenuEntryFilename.pn },
                new CodeMenuItem[] { codeMenuItemInput, codeMenuItemFilename });

            // FTP
            cbFTPURLPathProtocol.Items.AddRange(Helpers.GetEnumDescriptions<BrowserProtocol>());
            cbFTPSEncryption.Items.AddRange(Enum.GetNames(typeof(FTPSEncryption)));
            eiFTP.ObjectType = typeof(FTPAccount);

            // Custom uploader
            txtCustomUploaderLog.AddContextMenu();
            eiCustomUploaders.ObjectType = typeof(CustomUploaderItem);
            CustomUploaderAddDestinationTypes();
            cbCustomUploaderRequestType.Items.AddRange(Enum.GetNames(typeof(CustomUploaderRequestType)));
            cbCustomUploaderResponseType.Items.AddRange(Helpers.GetLocalizedEnumDescriptions<ResponseType>());
        }

        private void AddIconToTabs()
        {
            uploadersImageList = new ImageList();
            uploadersImageList.ColorDepth = ColorDepth.Depth32Bit;

            foreach (IUploaderService uploaderService in UploaderFactory.AllServices)
            {
                TabPage tp = uploaderService.GetUploadersConfigTabPage(this);

                if (tp != null && string.IsNullOrEmpty(tp.ImageKey))
                {
                    Icon icon = uploaderService.ServiceIcon;

                    if (icon != null)
                    {
                        uploadersImageList.Images.Add(tp.Name, icon);
                        tp.ImageKey = tp.Name;
                    }
                    else
                    {
                        Image img = uploaderService.ServiceImage;

                        if (img != null)
                        {
                            uploadersImageList.Images.Add(tp.Name, img);
                            tp.ImageKey = tp.Name;
                        }
                    }
                }
            }
        }

        public void NavigateToTabPage(TabPage tp)
        {
            if (tp != null)
            {
                ttlvMain.NavigateToTabPage(tp);
            }
        }

        private void LoadSettings()
        {
            LoadImageUploaderSettings();
            LoadTextUploaderSettings();
            LoadFileUploaderSettings();
            LoadURLShortenerSettings();
            LoadOtherUploaderSettings();
        }

        private void LoadImageUploaderSettings()
        {
        }

        private void LoadTextUploaderSettings()
        {
        }

        private void LoadFileUploaderSettings()
        {
            #region FTP

            if (Config.FTPAccountList == null)
            {
                Config.FTPAccountList = new List<FTPAccount>();
            }

            FTPUpdateControls();

            if (Config.FTPAccountList.Count == 0)
            {
                FTPClearFields();
            }
            else
            {
                cbFTPAccounts.SelectedIndex = cbFTPImage.SelectedIndex;
                FTPUpdateEnabledStates();
            }

            #endregion FTP

            #region Email

            txtEmailSmtpServer.Text = Config.EmailSmtpServer;
            nudEmailSmtpPort.SetValue(Config.EmailSmtpPort);
            txtEmailFrom.Text = Config.EmailFrom;
            txtEmailPassword.Text = Config.EmailPassword;
            cbEmailRememberLastTo.Checked = Config.EmailRememberLastTo;
            txtEmailDefaultSubject.Text = Config.EmailDefaultSubject;
            txtEmailDefaultBody.Text = Config.EmailDefaultBody;
            cbEmailAutomaticSend.Checked = Config.EmailAutomaticSend;
            txtEmailAutomaticSendTo.Enabled = Config.EmailAutomaticSend;
            txtEmailAutomaticSendTo.Text = Config.EmailAutomaticSendTo;

            #endregion Email

            #region Shared folder

            if (Config.LocalhostAccountList == null)
            {
                Config.LocalhostAccountList = new List<LocalhostAccount>();
            }

            SharedFolderUpdateControls();

            #endregion Shared folder

            #region Jira

            txtJiraHost.Text = Config.JiraHost;
            txtJiraIssuePrefix.Text = Config.JiraIssuePrefix;

            try
            {
                txtJiraConfigHelp.Text = string.Format(@"How to configure your Jira server:

- Go to 'Administration' -> 'Add-ons'
- Select 'Application Links'

- Add a new 'Application Link' with following settings:
    - Server URL: {0}
    - Application Name: {1}
    - Application Type: Generic Application

- Now, you have to configure Incoming Authentication
        - Consumer Key: {2}
        - Consumer Name: {1}
        - Public Key (without quotes): '{3}'

- You can now authenticate to Jira", Links.URL_WEBSITE, "ShareX", APIKeys.JiraConsumerKey, Jira.PublicKey);
            }
            catch (Exception e)
            {
                DebugHelper.WriteException(e);
            }

            if (OAuthInfo.CheckOAuth(Config.JiraOAuthInfo))
            {
                oAuthJira.Status = OAuthLoginStatus.LoginSuccessful;
            }

            #endregion Jira

            #region Seafile

            cbSeafileAPIURL.Text = Config.SeafileAPIURL;
            txtSeafileAuthToken.Text = Config.SeafileAuthToken;
            txtSeafileDirectoryPath.Text = Config.SeafilePath;
            txtSeafileLibraryPassword.Text = Config.SeafileEncryptedLibraryPassword;
            txtSeafileLibraryPassword.ReadOnly = Config.SeafileIsLibraryEncrypted;
            btnSeafileLibraryPasswordValidate.Enabled = !Config.SeafileIsLibraryEncrypted;
            cbSeafileCreateShareableURL.Checked = Config.SeafileCreateShareableURL;
            cbSeafileIgnoreInvalidCert.Checked = Config.SeafileIgnoreInvalidCert;
            nudSeafileExpireDays.SetValue(Config.SeafileShareDaysToExpire);
            txtSeafileSharePassword.Text = Config.SeafileSharePassword;
            txtSeafileAccInfoEmail.Text = Config.SeafileAccInfoEmail;
            txtSeafileAccInfoUsage.Text = Config.SeafileAccInfoUsage;

            #endregion Seafile
      
        }

        private void LoadURLShortenerSettings()
        {
        }

        private void LoadOtherUploaderSettings()
        {
            #region Custom uploaders

            CustomUploaderLoadTab();

            #endregion Custom uploaders
        }

        #region Image uploaders

        #endregion Image uploaders

        #region Text uploaders

        #endregion Text uploaders

        #region File uploaders

        #region FTP

        private void cbFTPImage_SelectedIndexChanged(object sender, EventArgs e)
        {
            Config.FTPSelectedImage = cbFTPImage.SelectedIndex;
        }

        private void cbFTPText_SelectedIndexChanged(object sender, EventArgs e)
        {
            Config.FTPSelectedText = cbFTPText.SelectedIndex;
        }

        private void cbFTPFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            Config.FTPSelectedFile = cbFTPFile.SelectedIndex;
        }

        private void cbFTPAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            FTPLoadSelectedAccount();
        }

        private void btnFTPAdd_Click(object sender, EventArgs e)
        {
            FTPAddAccount(new FTPAccount());

            cbFTPAccounts.SelectedIndex = cbFTPAccounts.Items.Count - 1;

            txtFTPName.Focus();
        }

        private void btnFTPRemove_Click(object sender, EventArgs e)
        {
            int selected = cbFTPAccounts.SelectedIndex;

            if (selected > -1)
            {
                cbFTPAccounts.Items.RemoveAt(selected);
                Config.FTPAccountList.RemoveAt(selected);

                if (cbFTPAccounts.Items.Count > 0)
                {
                    cbFTPAccounts.SelectedIndex = selected == cbFTPAccounts.Items.Count ? cbFTPAccounts.Items.Count - 1 : selected;
                }
                else
                {
                    FTPClearFields();
                    btnFTPAdd.Focus();
                }

                FTPUpdateControls();
            }
        }

        private void btnFTPDuplicate_Click(object sender, EventArgs e)
        {
            FTPAccount account = FTPGetSelectedAccount();
            if (account != null)
            {
                FTPAccount clone = account.Clone();
                FTPAddAccount(clone);

                cbFTPAccounts.SelectedIndex = cbFTPAccounts.Items.Count - 1;
            }
        }

        private void txtFTPName_TextChanged(object sender, EventArgs e)
        {
            FTPAccount account = FTPGetSelectedAccount();
            if (account != null)
            {
                account.Name = txtFTPName.Text;
                FTPRefreshNames();
            }
        }

        private void rbFTPProtocolFTP_CheckedChanged(object sender, EventArgs e)
        {
            FTPAccount account = FTPGetSelectedAccount();
            if (account != null)
            {
                account.Protocol = FTPProtocol.FTP;
                FTPUpdateEnabledStates();
            }
        }

        private void rbFTPProtocolFTPS_CheckedChanged(object sender, EventArgs e)
        {
            FTPAccount account = FTPGetSelectedAccount();
            if (account != null)
            {
                account.Protocol = FTPProtocol.FTPS;
                FTPUpdateEnabledStates();
            }
        }

        private void rbFTPProtocolSFTP_CheckedChanged(object sender, EventArgs e)
        {
            FTPAccount account = FTPGetSelectedAccount();
            if (account != null)
            {
                account.Protocol = FTPProtocol.SFTP;
                FTPUpdateEnabledStates();
            }
        }

        private void txtFTPHost_TextChanged(object sender, EventArgs e)
        {
            FTPAccount account = FTPGetSelectedAccount();
            if (account != null)
            {
                account.Host = txtFTPHost.Text;
                FTPUpdateURLPreview();
                FTPRefreshNames();
            }
        }

        private void nudFTPPort_ValueChanged(object sender, EventArgs e)
        {
            FTPAccount account = FTPGetSelectedAccount();
            if (account != null)
            {
                account.Port = (int)nudFTPPort.Value;
                FTPUpdateURLPreview();
            }
        }

        private void txtFTPUsername_TextChanged(object sender, EventArgs e)
        {
            FTPAccount account = FTPGetSelectedAccount();
            if (account != null)
            {
                account.Username = txtFTPUsername.Text;
            }
        }

        private void txtFTPPassword_TextChanged(object sender, EventArgs e)
        {
            FTPAccount account = FTPGetSelectedAccount();
            if (account != null)
            {
                account.Password = txtFTPPassword.Text;
            }
        }

        private void rbFTPTransferModePassive_CheckedChanged(object sender, EventArgs e)
        {
            FTPAccount account = FTPGetSelectedAccount();
            if (account != null)
            {
                account.IsActive = false;
            }
        }

        private void rbFTPTransferModeActive_CheckedChanged(object sender, EventArgs e)
        {
            FTPAccount account = FTPGetSelectedAccount();
            if (account != null)
            {
                account.IsActive = true;
            }
        }

        private void txtFTPRemoteDirectory_TextChanged(object sender, EventArgs e)
        {
            FTPAccount account = FTPGetSelectedAccount();
            if (account != null)
            {
                account.SubFolderPath = txtFTPRemoteDirectory.Text;
                FTPUpdateURLPreview();
            }
        }

        private void cbFTPURLPathProtocol_SelectedIndexChanged(object sender, EventArgs e)
        {
            FTPAccount account = FTPGetSelectedAccount();
            if (account != null)
            {
                account.BrowserProtocol = (BrowserProtocol)cbFTPURLPathProtocol.SelectedIndex;
                FTPUpdateURLPreview();
            }
        }

        private void txtFTPURLPath_TextChanged(object sender, EventArgs e)
        {
            FTPAccount account = FTPGetSelectedAccount();
            if (account != null)
            {
                account.HttpHomePath = txtFTPURLPath.Text;
                FTPUpdateURLPreview();
            }
        }

        private void cbFTPAppendRemoteDirectory_CheckedChanged(object sender, EventArgs e)
        {
            FTPAccount account = FTPGetSelectedAccount();
            if (account != null)
            {
                account.HttpHomePathAutoAddSubFolderPath = cbFTPAppendRemoteDirectory.Checked;
                FTPUpdateURLPreview();
            }
        }

        private void cbFTPRemoveFileExtension_CheckedChanged(object sender, EventArgs e)
        {
            FTPAccount account = FTPGetSelectedAccount();
            if (account != null)
            {
                account.HttpHomePathNoExtension = cbFTPRemoveFileExtension.Checked;
                FTPUpdateURLPreview();
            }
        }

        private void cbFTPSEncryption_SelectedIndexChanged(object sender, EventArgs e)
        {
            FTPAccount account = FTPGetSelectedAccount();
            if (account != null)
            {
                account.FTPSEncryption = (FTPSEncryption)cbFTPSEncryption.SelectedIndex;
            }
        }

        private void txtFTPSCertificateLocation_TextChanged(object sender, EventArgs e)
        {
            FTPAccount account = FTPGetSelectedAccount();
            if (account != null)
            {
                account.FTPSCertificateLocation = txtFTPSCertificateLocation.Text;
            }
        }

        private void btnFTPSCertificateLocationBrowse_Click(object sender, EventArgs e)
        {
            FTPAccount account = FTPGetSelectedAccount();
            if (account != null)
            {
                using (OpenFileDialog dlg = new OpenFileDialog())
                {
                    dlg.Title = Resources.CertFileNameEditor_EditValue_Browse_for_a_certificate_file___;
                    dlg.Filter = "Certificate file (*.cer)|*.cer";
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        txtFTPSCertificateLocation.Text = dlg.FileName;
                    }
                }
            }
        }

        private void txtSFTPKeyLocation_TextChanged(object sender, EventArgs e)
        {
            FTPAccount account = FTPGetSelectedAccount();
            if (account != null)
            {
                account.Keypath = txtSFTPKeyLocation.Text;
            }
        }

        private void btnSFTPKeyLocationBrowse_Click(object sender, EventArgs e)
        {
            FTPAccount account = FTPGetSelectedAccount();
            if (account != null)
            {
                using (OpenFileDialog dlg = new OpenFileDialog())
                {
                    dlg.Title = Resources.KeyFileNameEditor_EditValue_Browse_for_a_key_file___;
                    dlg.Filter = "Key file (*.*)|*.*";
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        txtSFTPKeyLocation.Text = dlg.FileName;
                    }
                }
            }
        }

        private void txtSFTPKeyPassphrase_TextChanged(object sender, EventArgs e)
        {
            FTPAccount account = FTPGetSelectedAccount();
            if (account != null)
            {
                account.Passphrase = txtSFTPKeyPassphrase.Text;
            }
        }

        private async void btnFTPTest_Click(object sender, EventArgs e)
        {
            FTPAccount account = FTPGetSelectedAccount();

            if (account != null)
            {
                await FTPTestAccountAsync(account);
            }
            else
            {
                MessageBox.Show(Resources.UploadersConfigForm_FTPOpenClient_Unable_to_find_valid_FTP_account_, "ShareX", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnFTPClient_Click(object sender, EventArgs e)
        {
            FTPAccount account = FTPGetSelectedAccount();

            if (account != null)
            {
                FTPOpenClient(account);
            }
            else
            {
                MessageBox.Show(Resources.UploadersConfigForm_FTPOpenClient_Unable_to_find_valid_FTP_account_, "ShareX", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private object eiFTP_ExportRequested()
        {
            return FTPGetSelectedAccount();
        }

        private void eiFTP_ImportRequested(object obj)
        {
            FTPAddAccount(obj as FTPAccount);
        }

        #endregion FTP

        #region Email

        private void txtSmtpServer_TextChanged(object sender, EventArgs e)
        {
            Config.EmailSmtpServer = txtEmailSmtpServer.Text;
        }

        private void nudSmtpPort_ValueChanged(object sender, EventArgs e)
        {
            Config.EmailSmtpPort = (int)nudEmailSmtpPort.Value;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            Config.EmailFrom = txtEmailFrom.Text;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            Config.EmailPassword = txtEmailPassword.Text;
        }

        private void cbRememberLastToEmail_CheckedChanged(object sender, EventArgs e)
        {
            Config.EmailRememberLastTo = cbEmailRememberLastTo.Checked;
        }

        private void txtDefaultSubject_TextChanged(object sender, EventArgs e)
        {
            Config.EmailDefaultSubject = txtEmailDefaultSubject.Text;
        }

        private void txtDefaultBody_TextChanged(object sender, EventArgs e)
        {
            Config.EmailDefaultBody = txtEmailDefaultBody.Text;
        }

        private void cbEmailAutomaticSend_CheckedChanged(object sender, EventArgs e)
        {
            Config.EmailAutomaticSend = cbEmailAutomaticSend.Checked;
            txtEmailAutomaticSendTo.Enabled = Config.EmailAutomaticSend;
        }

        private void txtEmailAutomaticSendTo_TextChanged(object sender, EventArgs e)
        {
            Config.EmailAutomaticSendTo = txtEmailAutomaticSendTo.Text;
        }

        #endregion Email

        #region Jira

        private void txtJiraHost_TextChanged(object sender, EventArgs e)
        {
            Config.JiraHost = txtJiraHost.Text;
        }

        private void txtJiraIssuePrefix_TextChanged(object sender, EventArgs e)
        {
            Config.JiraIssuePrefix = txtJiraIssuePrefix.Text;
        }

        private void oAuthJira_OpenButtonClicked()
        {
            JiraAuthOpen();
        }

        private void oAuthJira_CompleteButtonClicked(string code)
        {
            JiraAuthComplete(code);
        }

        private void oAuthJira_ClearButtonClicked()
        {
            Config.JiraOAuthInfo = null;
        }

        private void oAuthJira_RefreshButtonClicked()
        {
            MessageBox.Show(Resources.UploadersConfigForm_oAuthJira_RefreshButtonClicked_Refresh_authorization_is_not_supported_, "ShareX", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion Jira

        #region Shared folder

        private void cboSharedFolderImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            Config.LocalhostSelectedImages = cboSharedFolderImages.SelectedIndex;
        }

        private void cboSharedFolderText_SelectedIndexChanged(object sender, EventArgs e)
        {
            Config.LocalhostSelectedText = cboSharedFolderText.SelectedIndex;
        }

        private void cboSharedFolderFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            Config.LocalhostSelectedFiles = cboSharedFolderFiles.SelectedIndex;
        }

        private void btnSharedFolderAdd_Click(object sender, EventArgs e)
        {
            LocalhostAccount acc = new LocalhostAccount();
            SharedFolderAddItem(acc);
        }

        private void btnSharedFolderRemove_Click(object sender, EventArgs e)
        {
            int index = lbSharedFolderAccounts.SelectedIndex;
            SharedFolderRemoveItem(index);
        }

        private void btnSharedFolderDuplicate_Click(object sender, EventArgs e)
        {
            LocalhostAccount account = (LocalhostAccount)lbSharedFolderAccounts.Items[lbSharedFolderAccounts.SelectedIndex];
            LocalhostAccount clone = account.Clone();
            SharedFolderAddItem(clone);
        }

        private void lbSharedFolderAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            SharedFolderUpdateEnabledStates();

            if (lbSharedFolderAccounts.SelectedIndex > -1)
            {
                pgSharedFolderAccount.SelectedObject = lbSharedFolderAccounts.Items[lbSharedFolderAccounts.SelectedIndex];
            }
        }

        private void pgSharedFolderAccount_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            SharedFolderUpdateControls();

            if (lbSharedFolderAccounts.SelectedIndex > -1)
            {
                lbSharedFolderAccounts.Items[lbSharedFolderAccounts.SelectedIndex] = pgSharedFolderAccount.SelectedObject;
            }
        }

        #endregion Shared folder

        #region Seafile

        private void cbSeafileAPIURL_TextChanged(object sender, EventArgs e)
        {
            Config.SeafileAPIURL = cbSeafileAPIURL.Text;
        }

        private void btnSeafileCheckAPIURL_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbSeafileAPIURL.Text))
            {
                return;
            }

            Seafile sf = new Seafile(cbSeafileAPIURL.Text, null, null);
            bool checkReturned = sf.CheckAPIURL();

            if (checkReturned)
            {
                MessageBox.Show(Resources.UploadersConfigForm_TestFTPAccount_Connected_, "ShareX", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(Resources.UploadersConfigForm_Error, "ShareX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSeafileAuthToken_TextChanged(object sender, EventArgs e)
        {
            Config.SeafileAuthToken = txtSeafileAuthToken.Text;
        }

        private void btnSeafileCheckAuthToken_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSeafileAuthToken.Text) || string.IsNullOrEmpty(cbSeafileAPIURL.Text))
            {
                return;
            }

            Seafile sf = new Seafile(cbSeafileAPIURL.Text, txtSeafileAuthToken.Text, null);
            bool checkReturned = sf.CheckAuthToken();

            if (checkReturned)
            {
                MessageBox.Show(Resources.UploadersConfigForm_Login_successful, "ShareX", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(Resources.UploadersConfigForm_Error, "ShareX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSeafilePassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                btnSeafileGetAuthToken.PerformClick();
            }
        }

        private void btnSeafileGetAuthToken_Click(object sender, EventArgs e)
        {
            string username = txtSeafileUsername.Text;
            string password = txtSeafilePassword.Text;

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                try
                {
                    Seafile sf = new Seafile(cbSeafileAPIURL.Text, null, null);
                    string authToken = sf.GetAuthToken(username, password);

                    if (!string.IsNullOrEmpty(authToken))
                    {
                        txtSeafileUsername.Text = "";
                        txtSeafilePassword.Text = "";
                        Config.SeafileAuthToken = authToken;
                        txtSeafileAuthToken.Text = authToken;
                        btnRefreshSeafileAccInfo.PerformClick();
                        Config.SeafileRepoID = sf.GetOrMakeDefaultLibrary(authToken);
                        txtSeafileUploadLocationRefresh.PerformClick();
                        MessageBox.Show(Resources.UploadersConfigForm_Login_successful, "ShareX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(Resources.UploadersConfigForm_Login_failed, "ShareX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    DebugHelper.WriteException(ex);
                    ex.ShowError();
                }
            }
        }

        private void cbSeafileCreateShareableURL_CheckedChanged(object sender, EventArgs e)
        {
            Config.SeafileCreateShareableURL = cbSeafileCreateShareableURL.Checked;
        }

        private void cbSeafileIgnoreInvalidCert_CheckedChanged(object sender, EventArgs e)
        {
            Config.SeafileIgnoreInvalidCert = cbSeafileIgnoreInvalidCert.Checked;
        }

        private void btnRefreshSeafileAccInfo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSeafileAuthToken.Text) || string.IsNullOrEmpty(cbSeafileAPIURL.Text))
            {
                return;
            }

            Seafile sf = new Seafile(cbSeafileAPIURL.Text, txtSeafileAuthToken.Text, null);
            SeafileCheckAccInfoResponse SeafileCheckAccInfoResponse = sf.GetAccountInfo();

            if (SeafileCheckAccInfoResponse == null)
            {
                MessageBox.Show(Resources.UploadersConfigForm_Login_failed, "ShareX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            txtSeafileAccInfoEmail.Text = SeafileCheckAccInfoResponse.email;
            txtSeafileAccInfoUsage.Text = SeafileCheckAccInfoResponse.usage.ToSizeString() + " / " + SeafileCheckAccInfoResponse.total.ToSizeString();
        }

        private void txtSeafileUploadLocationRefresh_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSeafileAuthToken.Text) || string.IsNullOrEmpty(cbSeafileAPIURL.Text))
            {
                return;
            }
            lvSeafileLibraries.Items.Clear();

            Seafile sf = new Seafile(cbSeafileAPIURL.Text, txtSeafileAuthToken.Text, null);
            List<SeafileLibraryObj> SeafileLibraries = sf.GetLibraries();

            foreach (SeafileLibraryObj SeafileLibrary in SeafileLibraries)
            {
                if (SeafileLibrary.permission == "rw")
                {
                    ListViewItem libraryItem = lvSeafileLibraries.Items.Add(SeafileLibrary.name);
                    libraryItem.Name = SeafileLibrary.id;
                    libraryItem.Tag = SeafileLibrary;
                    libraryItem.SubItems.Add(SeafileLibrary.size.ToSizeString());
                    if (SeafileLibrary.encrypted)
                    {
                        libraryItem.SubItems.Add("\u221A");
                    }
                    if (SeafileLibrary.id == Config.SeafileRepoID)
                    {
                        libraryItem.Selected = true;
                    }
                }
            }
        }

        private void lvSeafileLibraries_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selIndex = lvSeafileLibraries.SelectedIndex;
            if (selIndex > -1)
            {
                ListViewItem selectedItem = lvSeafileLibraries.Items[selIndex];
                Config.SeafileRepoID = selectedItem.Name;
                SeafileLibraryObj SealileLibraryInfo = (SeafileLibraryObj)selectedItem.Tag;
                if (SealileLibraryInfo.encrypted)
                {
                    Config.SeafileIsLibraryEncrypted = true;
                    txtSeafileLibraryPassword.ReadOnly = false;
                    btnSeafileLibraryPasswordValidate.Enabled = true;
                }
                else
                {
                    Config.SeafileIsLibraryEncrypted = false;
                    txtSeafileLibraryPassword.ReadOnly = true;
                    txtSeafileLibraryPassword.Text = "";
                    Config.SeafileEncryptedLibraryPassword = "";
                    btnSeafileLibraryPasswordValidate.Enabled = false;
                }
            }
        }

        private void txtSeafileDirectoryPath_TextChanged(object sender, EventArgs e)
        {
            Config.SeafilePath = txtSeafileDirectoryPath.Text;
        }

        private void btnSeafilePathValidate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Config.SeafilePath) || string.IsNullOrEmpty(Config.SeafileAPIURL) || string.IsNullOrEmpty(Config.SeafileAuthToken) || string.IsNullOrEmpty(Config.SeafileRepoID))
            {
                return;
            }

            Seafile sf = new Seafile(cbSeafileAPIURL.Text, txtSeafileAuthToken.Text, Config.SeafileRepoID);
            bool checkReturned = sf.ValidatePath(txtSeafileDirectoryPath.Text);

            if (checkReturned)
            {
                MessageBox.Show(Resources.UploadersConfigForm_TestFTPAccount_Connected_, "ShareX", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(Resources.UploadersConfigForm_Error, "ShareX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSeafileLibraryPassword_TextChanged(object sender, EventArgs e)
        {
            if (Config.SeafileIsLibraryEncrypted)
            {
                Config.SeafileEncryptedLibraryPassword = txtSeafileLibraryPassword.Text;
            }
        }

        private void btnSeafileLibraryPasswordValidate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Config.SeafileEncryptedLibraryPassword) || string.IsNullOrEmpty(Config.SeafileAPIURL) || string.IsNullOrEmpty(Config.SeafileAuthToken) || string.IsNullOrEmpty(Config.SeafileRepoID))
            {
                return;
            }

            Seafile sf = new Seafile(cbSeafileAPIURL.Text, txtSeafileAuthToken.Text, Config.SeafileRepoID);
            bool checkReturned = sf.DecryptLibrary(txtSeafileLibraryPassword.Text);

            if (checkReturned)
            {
                MessageBox.Show(Resources.UploadersConfigForm_TestFTPAccount_Connected_, "ShareX", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(Resources.UploadersConfigForm_Error, "ShareX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nudSeafileExpireDays_ValueChanged(object sender, EventArgs e)
        {
            Config.SeafileShareDaysToExpire = (int)nudSeafileExpireDays.Value;
        }

        private void txtSeafileSharePassword_TextChanged(object sender, EventArgs e)
        {
            Config.SeafileSharePassword = txtSeafileSharePassword.Text;
        }

        #endregion Seafile

        #endregion File uploaders

        #region URL shorteners

        #endregion URL shorteners

        #region Other uploaders

        #region Custom uploaders

        private void btnCustomUploaderAdd_Click(object sender, EventArgs e)
        {
            CustomUploaderAdd();
            lbCustomUploaderList.SelectedIndex = lbCustomUploaderList.Items.Count - 1;
            txtCustomUploaderName.Focus();
        }

        private void btnCustomUploaderRemove_Click(object sender, EventArgs e)
        {
            int selected = lbCustomUploaderList.SelectedIndex;

            if (selected > -1)
            {
                lbCustomUploaderList.Items.RemoveAt(selected);
                Config.CustomUploadersList.RemoveAt(selected);

                if (lbCustomUploaderList.Items.Count > 0)
                {
                    lbCustomUploaderList.SelectedIndex = selected == lbCustomUploaderList.Items.Count ? lbCustomUploaderList.Items.Count - 1 : selected;
                }
                else
                {
                    CustomUploaderClearFields();
                    btnCustomUploaderAdd.Focus();
                }

                CustomUploaderFixSelectedUploader(selected);
                CustomUploaderUpdateList();
            }
        }

        private void btnCustomUploaderDuplicate_Click(object sender, EventArgs e)
        {
            CustomUploaderItem uploader = CustomUploaderGetSelected();
            if (uploader != null)
            {
                CustomUploaderItem clone = uploader.Copy();
                CustomUploaderAdd(clone);
                lbCustomUploaderList.SelectedIndex = lbCustomUploaderList.Items.Count - 1;
            }
        }

        private void lbCustomUploaderList_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomUploaderLoadSelected();
        }

        private void btnCustomUploaderClearUploaders_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Resources.UploadersConfigForm_Remove_all_custom_uploaders_Confirmation, "ShareX",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CustomUploaderClearUploaders();
            }
        }

        private object eiCustomUploaders_ExportRequested()
        {
            CustomUploaderItem uploader = CustomUploaderGetSelected();

            if (uploader != null)
            {
                if (string.IsNullOrEmpty(uploader.RequestURL))
                {
                    MessageBox.Show(Resources.UploadersConfigForm_eiCustomUploaders_ExportRequested_RequestURLMustBeConfigured, "ShareX - " + Resources.UploadersConfigForm_Error,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }

                if (uploader.DestinationType == CustomUploaderDestinationType.None)
                {
                    MessageBox.Show(Resources.UploadersConfigForm_eiCustomUploaders_ExportRequested_DestinationTypeMustBeConfigured, "ShareX - " + Resources.UploadersConfigForm_Error,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }

                eiCustomUploaders.DefaultFileName = uploader.GetFileName();
            }

            return uploader;
        }

        private void eiCustomUploaders_ImportRequested(object obj)
        {
            CustomUploaderAdd(obj as CustomUploaderItem);
            CustomUploaderUpdateStates();
        }

        private void btnCustomUploadersExportAll_Click(object sender, EventArgs e)
        {
            CustomUploaderExportAll();
        }

        private void txtCustomUploaderName_TextChanged(object sender, EventArgs e)
        {
            CustomUploaderItem uploader = CustomUploaderGetSelected();
            if (uploader != null) uploader.Name = txtCustomUploaderName.Text;

            CustomUploaderRefreshNames();
        }

        private void cbCustomUploaderRequestType_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomUploaderItem uploader = CustomUploaderGetSelected();
            if (uploader != null) uploader.RequestType = (CustomUploaderRequestType)cbCustomUploaderRequestType.SelectedIndex;

            CustomUploaderUpdateRequestState();
        }

        private void txtCustomUploaderRequestURL_TextChanged(object sender, EventArgs e)
        {
            CustomUploaderItem uploader = CustomUploaderGetSelected();
            if (uploader != null) uploader.RequestURL = txtCustomUploaderRequestURL.Text;

            CustomUploaderRefreshNames();
        }

        private void txtCustomUploaderFileForm_TextChanged(object sender, EventArgs e)
        {
            CustomUploaderItem uploader = CustomUploaderGetSelected();
            if (uploader != null) uploader.FileFormName = txtCustomUploaderFileForm.Text;
        }

        private void txtCustomUploaderArgName_TextChanged(object sender, EventArgs e)
        {
            CustomUploaderUpdateArgumentsState();
        }

        private void btnCustomUploaderArgAdd_Click(object sender, EventArgs e)
        {
            string name = txtCustomUploaderArgName.Text;

            if (!string.IsNullOrEmpty(name))
            {
                CustomUploaderItem uploader = CustomUploaderGetSelected();
                if (uploader != null)
                {
                    if (uploader.Arguments == null) uploader.Arguments = new Dictionary<string, string>();

                    if (uploader.Arguments.ContainsKey(name))
                    {
                        MessageBox.Show(Resources.UploadersConfigForm_An_argument_with_the_same_name_already_exists, "ShareX",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        string value = txtCustomUploaderArgValue.Text;
                        lvCustomUploaderArguments.Items.Add(name).SubItems.Add(value);
                        uploader.Arguments.Add(name, value);

                        lvCustomUploaderArguments.SelectedItems.Clear();
                        txtCustomUploaderArgName.Text = "";
                        txtCustomUploaderArgValue.Text = "";
                        txtCustomUploaderArgName.Focus();
                    }
                }
            }
        }

        private void btnCustomUploaderArgRemove_Click(object sender, EventArgs e)
        {
            if (lvCustomUploaderArguments.SelectedItems.Count > 0)
            {
                CustomUploaderItem uploader = CustomUploaderGetSelected();
                if (uploader != null) uploader.Arguments.Remove(lvCustomUploaderArguments.SelectedItems[0].Text);

                lvCustomUploaderArguments.SelectedItems[0].Remove();
            }
        }

        private void btnCustomUploaderArgUpdate_Click(object sender, EventArgs e)
        {
            if (lvCustomUploaderArguments.SelectedItems.Count > 0)
            {
                string name = txtCustomUploaderArgName.Text;

                if (!string.IsNullOrEmpty(name))
                {
                    string value = txtCustomUploaderArgValue.Text;

                    CustomUploaderItem uploader = CustomUploaderGetSelected();
                    if (uploader != null)
                    {
                        uploader.Arguments.Remove(lvCustomUploaderArguments.SelectedItems[0].Text);
                        uploader.Arguments.Add(name, value);
                    }

                    lvCustomUploaderArguments.SelectedItems[0].Text = name;
                    lvCustomUploaderArguments.SelectedItems[0].SubItems[1].Text = value;
                }
            }
        }

        private void lvCustomUploaderArguments_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = "";
            string value = "";

            if (lvCustomUploaderArguments.SelectedItems.Count > 0)
            {
                name = lvCustomUploaderArguments.SelectedItems[0].Text;
                value = lvCustomUploaderArguments.SelectedItems[0].SubItems[1].Text;
            }

            txtCustomUploaderArgName.Text = name;
            txtCustomUploaderArgValue.Text = value;

            CustomUploaderUpdateArgumentsState();
        }

        private void txtCustomUploaderHeaderName_TextChanged(object sender, EventArgs e)
        {
            CustomUploaderUpdateHeadersState();
        }

        private void btnCustomUploaderHeaderAdd_Click(object sender, EventArgs e)
        {
            string name = txtCustomUploaderHeaderName.Text;

            if (!string.IsNullOrEmpty(name))
            {
                CustomUploaderItem uploader = CustomUploaderGetSelected();
                if (uploader != null)
                {
                    if (uploader.Headers == null) uploader.Headers = new Dictionary<string, string>();

                    if (uploader.Headers.ContainsKey(name))
                    {
                        MessageBox.Show(Resources.UploadersConfigForm_A_header_with_the_same_name_already_exists, "ShareX",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        string value = txtCustomUploaderHeaderValue.Text;
                        lvCustomUploaderHeaders.Items.Add(name).SubItems.Add(value);
                        uploader.Headers.Add(name, value);

                        lvCustomUploaderHeaders.SelectedItems.Clear();
                        txtCustomUploaderHeaderName.Text = "";
                        txtCustomUploaderHeaderValue.Text = "";
                        txtCustomUploaderHeaderName.Focus();
                    }
                }
            }
        }

        private void btnCustomUploaderHeaderRemove_Click(object sender, EventArgs e)
        {
            if (lvCustomUploaderHeaders.SelectedItems.Count > 0)
            {
                CustomUploaderItem uploader = CustomUploaderGetSelected();
                if (uploader != null) uploader.Headers.Remove(lvCustomUploaderHeaders.SelectedItems[0].Text);

                lvCustomUploaderHeaders.SelectedItems[0].Remove();
            }
        }

        private void btnCustomUploaderHeaderUpdate_Click(object sender, EventArgs e)
        {
            if (lvCustomUploaderHeaders.SelectedItems.Count > 0)
            {
                string name = txtCustomUploaderHeaderName.Text;

                if (!string.IsNullOrEmpty(name))
                {
                    string value = txtCustomUploaderHeaderValue.Text;

                    CustomUploaderItem uploader = CustomUploaderGetSelected();
                    if (uploader != null)
                    {
                        uploader.Headers.Remove(lvCustomUploaderHeaders.SelectedItems[0].Text);
                        uploader.Headers.Add(name, value);
                    }

                    lvCustomUploaderHeaders.SelectedItems[0].Text = name;
                    lvCustomUploaderHeaders.SelectedItems[0].SubItems[1].Text = value;
                }
            }
        }

        private void lvCustomUploaderHeaders_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = "";
            string value = "";

            if (lvCustomUploaderHeaders.SelectedItems.Count > 0)
            {
                name = lvCustomUploaderHeaders.SelectedItems[0].Text;
                value = lvCustomUploaderHeaders.SelectedItems[0].SubItems[1].Text;
            }

            txtCustomUploaderHeaderName.Text = name;
            txtCustomUploaderHeaderValue.Text = value;

            CustomUploaderUpdateHeadersState();
        }

        private void cbCustomUploaderResponseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomUploaderItem uploader = CustomUploaderGetSelected();
            if (uploader != null) uploader.ResponseType = (ResponseType)cbCustomUploaderResponseType.SelectedIndex;
        }

        private void txtCustomUploaderJsonPath_TextChanged(object sender, EventArgs e)
        {
            CustomUploaderUpdateResponseState();
        }

        private void btnCustomUploadJsonPathHelp_Click(object sender, EventArgs e)
        {
            URLHelpers.OpenURL("http://goessner.net/articles/JsonPath/");
        }

        private void btnCustomUploaderJsonAddSyntax_Click(object sender, EventArgs e)
        {
            string syntax = txtCustomUploaderJsonPath.Text;

            if (!string.IsNullOrEmpty(syntax))
            {
                if (syntax.StartsWith("$."))
                {
                    syntax = syntax.Substring(2);
                }

                AddTextToActiveURLField($"$json:{syntax}$");
            }
        }

        private void txtCustomUploaderXPath_TextChanged(object sender, EventArgs e)
        {
            CustomUploaderUpdateResponseState();
        }

        private void btnCustomUploaderXPathHelp_Click(object sender, EventArgs e)
        {
            URLHelpers.OpenURL("https://www.w3schools.com/xml/xpath_syntax.asp");
        }

        private void btnCustomUploaderXmlSyntaxAdd_Click(object sender, EventArgs e)
        {
            string syntax = txtCustomUploaderXPath.Text;

            if (!string.IsNullOrEmpty(syntax))
            {
                AddTextToActiveURLField($"$xml:{syntax}$");
            }
        }

        private void txtCustomUploaderRegexp_TextChanged(object sender, EventArgs e)
        {
            CustomUploaderUpdateResponseState();
        }

        private void btnCustomUploaderRegexpAdd_Click(object sender, EventArgs e)
        {
            string regexp = txtCustomUploaderRegexp.Text;

            if (!string.IsNullOrEmpty(regexp))
            {
                lvCustomUploaderRegexps.Items.Add(regexp);
                txtCustomUploaderRegexp.Text = "";
                txtCustomUploaderRegexp.Focus();

                CustomUploaderItem uploader = CustomUploaderGetSelected();
                if (uploader != null)
                {
                    if (uploader.RegexList == null) uploader.RegexList = new List<string>();
                    uploader.RegexList.Add(regexp);
                }
            }
        }

        private void btnCustomUploaderRegexpRemove_Click(object sender, EventArgs e)
        {
            int index = lvCustomUploaderRegexps.SelectedIndex;
            if (index > -1)
            {
                lvCustomUploaderRegexps.Items.RemoveAt(index);

                CustomUploaderItem uploader = CustomUploaderGetSelected();
                if (uploader != null) uploader.RegexList.RemoveAt(index);
            }
        }

        private void btnCustomUploaderRegexpEdit_Click(object sender, EventArgs e)
        {
            string regexp = txtCustomUploaderRegexp.Text;
            if (!string.IsNullOrEmpty(regexp))
            {
                int index = lvCustomUploaderRegexps.SelectedIndex;
                if (index > -1)
                {
                    lvCustomUploaderRegexps.Items[index].Text = regexp;

                    CustomUploaderItem uploader = CustomUploaderGetSelected();
                    if (uploader != null) uploader.RegexList[index] = regexp;
                }
            }
        }

        private void btnCustomUploaderRegexHelp_Click(object sender, EventArgs e)
        {
            URLHelpers.OpenURL("http://regexone.com");
        }

        private void lvCustomUploaderRegexps_SelectedIndexChanged(object sender, EventArgs e)
        {
            string regex = "";

            if (lvCustomUploaderRegexps.SelectedItems.Count > 0)
            {
                regex = lvCustomUploaderRegexps.SelectedItems[0].Text;
            }

            txtCustomUploaderRegexp.Text = regex;

            CustomUploaderUpdateResponseState();
        }

        private void btnCustomUploaderRegexAddSyntax_Click(object sender, EventArgs e)
        {
            if (lvCustomUploaderRegexps.SelectedIndices.Count > 0)
            {
                int selectedIndex = lvCustomUploaderRegexps.SelectedIndices[0];
                string regex = lvCustomUploaderRegexps.Items[selectedIndex].Text;

                if (!string.IsNullOrEmpty(regex))
                {
                    string syntax;
                    Match match = Regex.Match(regex, @"\((?:\?<(.+?)>)?.+?\)");

                    if (match.Success)
                    {
                        if (match.Groups.Count > 1 && !string.IsNullOrEmpty(match.Groups[1].Value))
                        {
                            syntax = string.Format("$regex:{0}|{1}$", selectedIndex + 1, match.Groups[1].Value);
                        }
                        else
                        {
                            syntax = string.Format("$regex:{0}|1$", selectedIndex + 1);
                        }
                    }
                    else
                    {
                        syntax = string.Format("$regex:{0}$", selectedIndex + 1);
                    }

                    AddTextToActiveURLField(syntax);
                }
            }
        }

        private void txtCustomUploaderURL_Enter(object sender, EventArgs e)
        {
            customUploaderURLType = URLType.URL;
        }

        private void txtCustomUploaderURL_TextChanged(object sender, EventArgs e)
        {
            CustomUploaderItem uploader = CustomUploaderGetSelected();
            if (uploader != null) uploader.URL = txtCustomUploaderURL.Text;
        }

        private void txtCustomUploaderThumbnailURL_Enter(object sender, EventArgs e)
        {
            customUploaderURLType = URLType.ThumbnailURL;
        }

        private void txtCustomUploaderThumbnailURL_TextChanged(object sender, EventArgs e)
        {
            CustomUploaderItem uploader = CustomUploaderGetSelected();
            if (uploader != null) uploader.ThumbnailURL = txtCustomUploaderThumbnailURL.Text;
        }

        private void txtCustomUploaderDeletionURL_Enter(object sender, EventArgs e)
        {
            customUploaderURLType = URLType.DeletionURL;
        }

        private void txtCustomUploaderDeletionURL_TextChanged(object sender, EventArgs e)
        {
            CustomUploaderItem uploader = CustomUploaderGetSelected();
            if (uploader != null) uploader.DeletionURL = txtCustomUploaderDeletionURL.Text;
        }

        private void AddTextToActiveURLField(string text)
        {
            TextBox tb;

            switch (customUploaderURLType)
            {
                default:
                case URLType.URL:
                    tb = txtCustomUploaderURL;
                    break;
                case URLType.ThumbnailURL:
                    tb = txtCustomUploaderThumbnailURL;
                    break;
                case URLType.DeletionURL:
                    tb = txtCustomUploaderDeletionURL;
                    break;
            }

            tb.AppendText(text);
        }

        private void cbCustomUploaderImageUploader_SelectedIndexChanged(object sender, EventArgs e)
        {
            Config.CustomImageUploaderSelected = cbCustomUploaderImageUploader.SelectedIndex;
        }

        private async void btnCustomUploaderImageUploaderTest_Click(object sender, EventArgs e)
        {
            if (Config.CustomUploadersList.IsValidIndex(Config.CustomImageUploaderSelected))
            {
                await TestCustomUploader(CustomUploaderDestinationType.ImageUploader, Config.CustomUploadersList[Config.CustomImageUploaderSelected]);
            }
        }

        private void cbCustomUploaderTextUploader_SelectedIndexChanged(object sender, EventArgs e)
        {
            Config.CustomTextUploaderSelected = cbCustomUploaderTextUploader.SelectedIndex;
        }

        private async void btnCustomUploaderTextUploaderTest_Click(object sender, EventArgs e)
        {
            if (Config.CustomUploadersList.IsValidIndex(Config.CustomTextUploaderSelected))
            {
                await TestCustomUploader(CustomUploaderDestinationType.TextUploader, Config.CustomUploadersList[Config.CustomTextUploaderSelected]);
            }
        }

        private void cbCustomUploaderFileUploader_SelectedIndexChanged(object sender, EventArgs e)
        {
            Config.CustomFileUploaderSelected = cbCustomUploaderFileUploader.SelectedIndex;
        }

        private async void btnCustomUploaderFileUploaderTest_Click(object sender, EventArgs e)
        {
            if (Config.CustomUploadersList.IsValidIndex(Config.CustomFileUploaderSelected))
            {
                await TestCustomUploader(CustomUploaderDestinationType.FileUploader, Config.CustomUploadersList[Config.CustomFileUploaderSelected]);
            }
        }

        private void cbCustomUploaderURLShortener_SelectedIndexChanged(object sender, EventArgs e)
        {
            Config.CustomURLShortenerSelected = cbCustomUploaderURLShortener.SelectedIndex;
        }

        private async void btnCustomUploaderURLShortenerTest_Click(object sender, EventArgs e)
        {
            if (Config.CustomUploadersList.IsValidIndex(Config.CustomURLShortenerSelected))
            {
                await TestCustomUploader(CustomUploaderDestinationType.URLShortener, Config.CustomUploadersList[Config.CustomURLShortenerSelected]);
            }
        }

        private void cbCustomUploaderURLSharingService_SelectedIndexChanged(object sender, EventArgs e)
        {
            Config.CustomURLSharingServiceSelected = cbCustomUploaderURLSharingService.SelectedIndex;
        }

        private async void btnCustomUploaderURLSharingServiceTest_Click(object sender, EventArgs e)
        {
            if (Config.CustomUploadersList.IsValidIndex(Config.CustomURLSharingServiceSelected))
            {
                await TestCustomUploader(CustomUploaderDestinationType.URLSharingService, Config.CustomUploadersList[Config.CustomURLSharingServiceSelected]);
            }
        }

        private void btnCustomUploaderShowLastResponse_Click(object sender, EventArgs e)
        {
            string response = btnCustomUploaderShowLastResponse.Tag as string;

            if (!string.IsNullOrEmpty(response))
            {
                using (ResponseForm form = new ResponseForm(response))
                {
                    form.ShowDialog();
                }
            }
        }

        private void txtCustomUploaderLog_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            URLHelpers.OpenURL(e.LinkText);
        }

        private void btnCustomUploaderExamples_Click(object sender, EventArgs e)
        {
            URLHelpers.OpenURL(Links.URL_CUSTOM_UPLOADERS);
        }

        private void btnCustomUploaderHelp_Click(object sender, EventArgs e)
        {
            URLHelpers.OpenURL(Links.URL_CUSTOM_UPLOADER);
        }

        #endregion Custom uploaders

        #endregion Other uploaders
    }
}