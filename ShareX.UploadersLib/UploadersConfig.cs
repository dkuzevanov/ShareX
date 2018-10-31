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

using CG.Web.MegaApiClient;
using ShareX.HelpersLib;
using ShareX.UploadersLib.FileUploaders;
using ShareX.UploadersLib.ImageUploaders;
using ShareX.UploadersLib.TextUploaders;
using ShareX.UploadersLib.URLShorteners;
using System.Collections.Generic;

namespace ShareX.UploadersLib
{
    public class UploadersConfig : SettingsBase<UploadersConfig>
    {
        #region Image uploaders

        #endregion Image uploaders

        #region Text uploaders

        #endregion Text uploaders

        #region File uploaders

        #region FTP

        public List<FTPAccount> FTPAccountList = new List<FTPAccount>();
        public int FTPSelectedImage = 0;
        public int FTPSelectedText = 0;
        public int FTPSelectedFile = 0;

        #endregion FTP

        #region Shared folder

        public List<LocalhostAccount> LocalhostAccountList = new List<LocalhostAccount>();
        public int LocalhostSelectedImages = 0;
        public int LocalhostSelectedText = 0;
        public int LocalhostSelectedFiles = 0;

        #endregion Shared folder

        #region Email

        public string EmailSmtpServer = "smtp.gmail.com";
        public int EmailSmtpPort = 587;
        public string EmailFrom = "...@gmail.com";
        public string EmailPassword = "";
        public bool EmailRememberLastTo = true;
        public string EmailLastTo = "";
        public string EmailDefaultSubject = "Sending email from ShareX";
        public string EmailDefaultBody = "Screenshot is attached.";
        public bool EmailAutomaticSend = false;
        public string EmailAutomaticSendTo = "";

        #endregion Email

        #region Jira

        public string JiraHost = "http://";
        public string JiraIssuePrefix = "PROJECT-";
        public OAuthInfo JiraOAuthInfo = null;

        #endregion Jira

        #region Seafile

        public string SeafileAPIURL = "";
        public string SeafileAuthToken = "";
        public string SeafileRepoID = "";
        public string SeafilePath = "/";
        public bool SeafileIsLibraryEncrypted = false;
        public string SeafileEncryptedLibraryPassword = "";
        public bool SeafileCreateShareableURL = true;
        public bool SeafileIgnoreInvalidCert = false;
        public int SeafileShareDaysToExpire = 0;
        public string SeafileSharePassword = "";
        public string SeafileAccInfoEmail = "";
        public string SeafileAccInfoUsage = "";

        #endregion Seafile

        #endregion File uploaders

        #region URL shorteners

        #endregion URL shorteners

        #region Other uploaders

        #region Custom uploaders

        public List<CustomUploaderItem> CustomUploadersList = new List<CustomUploaderItem>();
        public int CustomImageUploaderSelected = 0;
        public int CustomTextUploaderSelected = 0;
        public int CustomFileUploaderSelected = 0;
        public int CustomURLShortenerSelected = 0;
        public int CustomURLSharingServiceSelected = 0;

        #endregion Custom uploaders

        #endregion Other uploaders
    }
}