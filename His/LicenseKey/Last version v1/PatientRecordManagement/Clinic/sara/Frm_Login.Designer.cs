namespace PatientRecordManagement.Auth
{
    partial class Frm_Login
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
            Kimtoo.ValidationProvider.ValidationObject validationObject1 = new Kimtoo.ValidationProvider.ValidationObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            Kimtoo.ValidationProvider.ValidationObject validationObject2 = new Kimtoo.ValidationProvider.ValidationObject();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Kimtoo.ValidationProvider.ValidationObject validationObject3 = new Kimtoo.ValidationProvider.ValidationObject();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Kimtoo.ValidationProvider.ValidationObject validationObject4 = new Kimtoo.ValidationProvider.ValidationObject();
            Kimtoo.ValidationProvider.ValidationObject validationObject5 = new Kimtoo.ValidationProvider.ValidationObject();
            Kimtoo.ValidationProvider.ValidationObject validationObject6 = new Kimtoo.ValidationProvider.ValidationObject();
            Kimtoo.ValidationProvider.ValidationObject validationObject10 = new Kimtoo.ValidationProvider.ValidationObject();
            Kimtoo.ValidationProvider.ValidationObject validationObject7 = new Kimtoo.ValidationProvider.ValidationObject();
            Kimtoo.ValidationProvider.ValidationObject validationObject9 = new Kimtoo.ValidationProvider.ValidationObject();
            Kimtoo.ValidationProvider.ValidationObject validationObject11 = new Kimtoo.ValidationProvider.ValidationObject();
            Kimtoo.ValidationProvider.ValidationObject validationObject8 = new Kimtoo.ValidationProvider.ValidationObject();
            Kimtoo.ValidationProvider.ValidationObject validationObject14 = new Kimtoo.ValidationProvider.ValidationObject();
            Kimtoo.ValidationProvider.ValidationObject validationObject13 = new Kimtoo.ValidationProvider.ValidationObject();
            Kimtoo.ValidationProvider.ValidationObject validationObject12 = new Kimtoo.ValidationProvider.ValidationObject();
            this.AppBar = new Bunifu.Utils.BunifuAppBar();
            this.Alert = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.validationProvider = new Kimtoo.ValidationProvider.ValidationProvider();
            this.txtEmail = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtPassword = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.btnSetup = new System.Windows.Forms.LinkLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuFormDock = new Bunifu.UI.WinForms.BunifuFormDock();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AppBar
            // 
            this.AppBar.BackColor = System.Drawing.Color.White;
            this.AppBar.ControlBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(170)))), ((int)(((byte)(152)))));
            this.AppBar.ControlBoxColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(42)))), ((int)(((byte)(41)))));
            this.AppBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.AppBar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.AppBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(170)))), ((int)(((byte)(152)))));
            this.AppBar.Icon = null;
            validationObject1.CustomErrorMessage = "";
            validationObject1.Optional = false;
            validationObject1.PropertyName = "Text";
            validationObject1.Regex = null;
            validationObject1.ValidationType = Kimtoo.ValidationProvider.ValidationTypes.None;
            this.validationProvider.SetLink(this.AppBar, validationObject1);
            this.AppBar.Location = new System.Drawing.Point(0, 0);
            this.AppBar.Name = "AppBar";
            this.AppBar.Size = new System.Drawing.Size(787, 46);
            this.AppBar.TabIndex = 7;
            this.AppBar.Title = "";
            this.AppBar.TitleMargin = new System.Windows.Forms.Padding(47, 12, 0, 0);
            // 
            // Alert
            // 
            this.Alert.AllowDragging = false;
            this.Alert.AllowMultipleViews = true;
            this.Alert.ClickToClose = true;
            this.Alert.DoubleClickToClose = true;
            this.Alert.DurationAfterIdle = 3000;
            this.Alert.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Alert.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Alert.ErrorOptions.ActionBorderRadius = 1;
            this.Alert.ErrorOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Alert.ErrorOptions.ActionForeColor = System.Drawing.Color.Black;
            this.Alert.ErrorOptions.BackColor = System.Drawing.Color.White;
            this.Alert.ErrorOptions.BorderColor = System.Drawing.Color.White;
            this.Alert.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(199)))));
            this.Alert.ErrorOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Alert.ErrorOptions.ForeColor = System.Drawing.Color.Black;
            this.Alert.ErrorOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon")));
            this.Alert.ErrorOptions.IconLeftMargin = 12;
            this.Alert.FadeCloseIcon = false;
            this.Alert.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner;
            this.Alert.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Alert.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Alert.InformationOptions.ActionBorderRadius = 1;
            this.Alert.InformationOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Alert.InformationOptions.ActionForeColor = System.Drawing.Color.Black;
            this.Alert.InformationOptions.BackColor = System.Drawing.Color.White;
            this.Alert.InformationOptions.BorderColor = System.Drawing.Color.White;
            this.Alert.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.Alert.InformationOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Alert.InformationOptions.ForeColor = System.Drawing.Color.Black;
            this.Alert.InformationOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon1")));
            this.Alert.InformationOptions.IconLeftMargin = 12;
            this.Alert.Margin = 10;
            this.Alert.MaximumSize = new System.Drawing.Size(0, 0);
            this.Alert.MaximumViews = 7;
            this.Alert.MessageRightMargin = 15;
            this.Alert.MinimumSize = new System.Drawing.Size(0, 0);
            this.Alert.ShowBorders = false;
            this.Alert.ShowCloseIcon = false;
            this.Alert.ShowIcon = true;
            this.Alert.ShowShadows = true;
            this.Alert.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Alert.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Alert.SuccessOptions.ActionBorderRadius = 1;
            this.Alert.SuccessOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Alert.SuccessOptions.ActionForeColor = System.Drawing.Color.Black;
            this.Alert.SuccessOptions.BackColor = System.Drawing.Color.White;
            this.Alert.SuccessOptions.BorderColor = System.Drawing.Color.White;
            this.Alert.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.Alert.SuccessOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Alert.SuccessOptions.ForeColor = System.Drawing.Color.Black;
            this.Alert.SuccessOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon2")));
            this.Alert.SuccessOptions.IconLeftMargin = 12;
            this.Alert.ViewsMargin = 7;
            this.Alert.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Alert.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Alert.WarningOptions.ActionBorderRadius = 1;
            this.Alert.WarningOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Alert.WarningOptions.ActionForeColor = System.Drawing.Color.Black;
            this.Alert.WarningOptions.BackColor = System.Drawing.Color.White;
            this.Alert.WarningOptions.BorderColor = System.Drawing.Color.White;
            this.Alert.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(143)))));
            this.Alert.WarningOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Alert.WarningOptions.ForeColor = System.Drawing.Color.Black;
            this.Alert.WarningOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon3")));
            this.Alert.WarningOptions.IconLeftMargin = 12;
            this.Alert.ZoomCloseIcon = true;
            // 
            // validationProvider
            // 
            this.validationProvider.ErrorColor = System.Drawing.Color.Crimson;
            // 
            // txtEmail
            // 
            this.txtEmail.AcceptsReturn = false;
            this.txtEmail.AcceptsTab = false;
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.AnimationSpeed = 200;
            this.txtEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtEmail.AutoSizeHeight = true;
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtEmail.BackgroundImage")));
            this.txtEmail.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(170)))), ((int)(((byte)(152)))));
            this.txtEmail.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(170)))), ((int)(((byte)(152)))));
            this.txtEmail.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(170)))), ((int)(((byte)(152)))));
            this.txtEmail.BorderColorIdle = System.Drawing.Color.GhostWhite;
            this.txtEmail.BorderRadius = 1;
            this.txtEmail.BorderThickness = 0;
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultFont = new System.Drawing.Font("Cairo", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.DefaultText = "";
            this.txtEmail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.txtEmail.HideSelection = true;
            this.txtEmail.IconLeft = null;
            this.txtEmail.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.IconPadding = 10;
            this.txtEmail.IconRight = null;
            this.txtEmail.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Lines = new string[0];
            validationObject2.CustomErrorMessage = "";
            validationObject2.Optional = false;
            validationObject2.PropertyName = "Text";
            validationObject2.Regex = resources.GetString("validationObject2.Regex");
            validationObject2.ValidationType = Kimtoo.ValidationProvider.ValidationTypes.Email;
            this.validationProvider.SetLink(this.txtEmail, validationObject2);
            this.txtEmail.Location = new System.Drawing.Point(375, 176);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtEmail.Modified = false;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(170)))), ((int)(((byte)(152)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtEmail.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(170)))), ((int)(((byte)(152)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtEmail.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(170)))), ((int)(((byte)(152)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtEmail.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.GhostWhite;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            stateProperties4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtEmail.OnIdleState = stateProperties4;
            this.txtEmail.Padding = new System.Windows.Forms.Padding(3);
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtEmail.PlaceholderText = "أدخل الإيميل الخاص بك";
            this.txtEmail.ReadOnly = false;
            this.txtEmail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(384, 41);
            this.txtEmail.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtEmail.TabIndex = 14;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmail.TextMarginBottom = 0;
            this.txtEmail.TextMarginLeft = 3;
            this.txtEmail.TextMarginTop = 1;
            this.txtEmail.TextPlaceholder = "أدخل الإيميل الخاص بك";
            this.txtEmail.UseSystemPasswordChar = false;
            this.txtEmail.WordWrap = true;
            // 
            // txtPassword
            // 
            this.txtPassword.AcceptsReturn = false;
            this.txtPassword.AcceptsTab = false;
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.AnimationSpeed = 200;
            this.txtPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPassword.AutoSizeHeight = true;
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtPassword.BackgroundImage")));
            this.txtPassword.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(170)))), ((int)(((byte)(152)))));
            this.txtPassword.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtPassword.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(170)))), ((int)(((byte)(152)))));
            this.txtPassword.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.txtPassword.BorderRadius = 1;
            this.txtPassword.BorderThickness = 0;
            this.txtPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtPassword.DefaultText = "";
            this.txtPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.txtPassword.HideSelection = true;
            this.txtPassword.IconLeft = null;
            this.txtPassword.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.IconPadding = 10;
            this.txtPassword.IconRight = null;
            this.txtPassword.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Lines = new string[0];
            validationObject3.CustomErrorMessage = "";
            validationObject3.Optional = false;
            validationObject3.PropertyName = "Text";
            validationObject3.Regex = "(?=.*[A-Za-z])(?=.*\\d)[A-Za-z\\d]{6,}$";
            validationObject3.ValidationType = Kimtoo.ValidationProvider.ValidationTypes.Password;
            this.validationProvider.SetLink(this.txtPassword, validationObject3);
            this.txtPassword.Location = new System.Drawing.Point(375, 256);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtPassword.Modified = false;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(170)))), ((int)(((byte)(152)))));
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPassword.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtPassword.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(170)))), ((int)(((byte)(152)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPassword.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            stateProperties8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            stateProperties8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPassword.OnIdleState = stateProperties8;
            this.txtPassword.Padding = new System.Windows.Forms.Padding(3);
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.ReadOnly = false;
            this.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(384, 39);
            this.txtPassword.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtPassword.TabIndex = 15;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.TextMarginBottom = 0;
            this.txtPassword.TextMarginLeft = 3;
            this.txtPassword.TextMarginTop = 1;
            this.txtPassword.TextPlaceholder = "Password";
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.WordWrap = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(170)))), ((int)(((byte)(152)))));
            this.btnCancel.FlatAppearance.BorderSize = 2;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Cairo", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(170)))), ((int)(((byte)(152)))));
            validationObject4.CustomErrorMessage = "";
            validationObject4.Optional = false;
            validationObject4.PropertyName = "Text";
            validationObject4.Regex = null;
            validationObject4.ValidationType = Kimtoo.ValidationProvider.ValidationTypes.None;
            this.validationProvider.SetLink(this.btnCancel, validationObject4);
            this.btnCancel.Location = new System.Drawing.Point(544, 367);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 40);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "إنهاء";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(170)))), ((int)(((byte)(152)))));
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(170)))), ((int)(((byte)(152)))));
            this.btnLogin.FlatAppearance.BorderSize = 2;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Cairo", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            validationObject5.CustomErrorMessage = "";
            validationObject5.Optional = false;
            validationObject5.PropertyName = "Text";
            validationObject5.Regex = null;
            validationObject5.ValidationType = Kimtoo.ValidationProvider.ValidationTypes.None;
            this.validationProvider.SetLink(this.btnLogin, validationObject5);
            this.btnLogin.Location = new System.Drawing.Point(657, 367);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(102, 40);
            this.btnLogin.TabIndex = 16;
            this.btnLogin.Text = "دخول  ➲";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cairo ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(170)))), ((int)(((byte)(152)))));
            validationObject6.CustomErrorMessage = "";
            validationObject6.Optional = false;
            validationObject6.PropertyName = "Text";
            validationObject6.Regex = null;
            validationObject6.ValidationType = Kimtoo.ValidationProvider.ValidationTypes.None;
            this.validationProvider.SetLink(this.label1, validationObject6);
            this.label1.Location = new System.Drawing.Point(497, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 40);
            this.label1.TabIndex = 18;
            this.label1.Text = "تسجيل الدخول";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.bunifuLabel2);
            this.panel1.Controls.Add(this.bunifuLabel1);
            this.panel1.Controls.Add(this.bunifuPictureBox1);
            validationObject10.CustomErrorMessage = "";
            validationObject10.Optional = false;
            validationObject10.PropertyName = "Text";
            validationObject10.Regex = null;
            validationObject10.ValidationType = Kimtoo.ValidationProvider.ValidationTypes.None;
            this.validationProvider.SetLink(this.panel1, validationObject10);
            this.panel1.Location = new System.Drawing.Point(-8, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 455);
            this.panel1.TabIndex = 19;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Lucida Fax", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.ForeColor = System.Drawing.Color.White;
            validationObject7.CustomErrorMessage = "";
            validationObject7.Optional = false;
            validationObject7.PropertyName = "Text";
            validationObject7.Regex = null;
            validationObject7.ValidationType = Kimtoo.ValidationProvider.ValidationTypes.None;
            this.validationProvider.SetLink(this.bunifuLabel2, validationObject7);
            this.bunifuLabel2.Location = new System.Drawing.Point(158, 55);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(62, 40);
            this.bunifuLabel2.TabIndex = 23;
            this.bunifuLabel2.Text = "HIS";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuLabel2.Click += new System.EventHandler(this.bunifuLabel2_Click);
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 0;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = false;
            validationObject9.CustomErrorMessage = "";
            validationObject9.Optional = false;
            validationObject9.PropertyName = "Text";
            validationObject9.Regex = null;
            validationObject9.ValidationType = Kimtoo.ValidationProvider.ValidationTypes.None;
            this.validationProvider.SetLink(this.bunifuPictureBox1, validationObject9);
            this.bunifuPictureBox1.Location = new System.Drawing.Point(99, 138);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(181, 181);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 1;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.bunifuPictureBox1.Click += new System.EventHandler(this.bunifuPictureBox1_Click);
            // 
            // btnSetup
            // 
            this.btnSetup.ActiveLinkColor = System.Drawing.Color.Teal;
            this.btnSetup.AutoSize = true;
            validationObject11.CustomErrorMessage = "";
            validationObject11.Optional = false;
            validationObject11.PropertyName = "Text";
            validationObject11.Regex = null;
            validationObject11.ValidationType = Kimtoo.ValidationProvider.ValidationTypes.None;
            this.validationProvider.SetLink(this.btnSetup, validationObject11);
            this.btnSetup.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(170)))), ((int)(((byte)(152)))));
            this.btnSetup.Location = new System.Drawing.Point(372, 394);
            this.btnSetup.Name = "btnSetup";
            this.btnSetup.Size = new System.Drawing.Size(89, 13);
            this.btnSetup.TabIndex = 20;
            this.btnSetup.TabStop = true;
            this.btnSetup.Text = "Setup database.";
            this.btnSetup.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(170)))), ((int)(((byte)(152)))));
            this.btnSetup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnSetup_LinkClicked);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(170)))), ((int)(((byte)(152)))));
            validationObject8.CustomErrorMessage = "";
            validationObject8.Optional = false;
            validationObject8.PropertyName = "Text";
            validationObject8.Regex = null;
            validationObject8.ValidationType = Kimtoo.ValidationProvider.ValidationTypes.None;
            this.validationProvider.SetLink(this.bunifuLabel1, validationObject8);
            this.bunifuLabel1.Location = new System.Drawing.Point(75, 101);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(228, 18);
            this.bunifuLabel1.TabIndex = 22;
            this.bunifuLabel1.Text = " Health Information System";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuLabel1.Click += new System.EventHandler(this.bunifuLabel1_Click);
            // 
            // bunifuFormDock
            // 
            this.bunifuFormDock.AllowFormDragging = true;
            this.bunifuFormDock.AllowFormDropShadow = true;
            this.bunifuFormDock.AllowFormResizing = false;
            this.bunifuFormDock.AllowHidingBottomRegion = true;
            this.bunifuFormDock.AllowOpacityChangesWhileDragging = false;
            this.bunifuFormDock.BorderOptions.BottomBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock.BorderOptions.BottomBorder.BorderThickness = 1;
            this.bunifuFormDock.BorderOptions.BottomBorder.ShowBorder = true;
            this.bunifuFormDock.BorderOptions.LeftBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock.BorderOptions.LeftBorder.BorderThickness = 1;
            this.bunifuFormDock.BorderOptions.LeftBorder.ShowBorder = true;
            this.bunifuFormDock.BorderOptions.RightBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock.BorderOptions.RightBorder.BorderThickness = 1;
            this.bunifuFormDock.BorderOptions.RightBorder.ShowBorder = true;
            this.bunifuFormDock.BorderOptions.TopBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock.BorderOptions.TopBorder.BorderThickness = 1;
            this.bunifuFormDock.BorderOptions.TopBorder.ShowBorder = true;
            this.bunifuFormDock.ContainerControl = this;
            this.bunifuFormDock.DockingIndicatorsColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(215)))), ((int)(((byte)(233)))));
            this.bunifuFormDock.DockingIndicatorsOpacity = 0.5D;
            this.bunifuFormDock.DockingOptions.DockAll = false;
            this.bunifuFormDock.DockingOptions.DockBottomLeft = false;
            this.bunifuFormDock.DockingOptions.DockBottomRight = false;
            this.bunifuFormDock.DockingOptions.DockFullScreen = false;
            this.bunifuFormDock.DockingOptions.DockLeft = false;
            this.bunifuFormDock.DockingOptions.DockRight = false;
            this.bunifuFormDock.DockingOptions.DockTopLeft = false;
            this.bunifuFormDock.DockingOptions.DockTopRight = false;
            this.bunifuFormDock.FormDraggingOpacity = 0.9D;
            this.bunifuFormDock.ParentForm = this;
            this.bunifuFormDock.ShowCursorChanges = true;
            this.bunifuFormDock.ShowDockingIndicators = false;
            this.bunifuFormDock.TitleBarOptions.AllowFormDragging = true;
            this.bunifuFormDock.TitleBarOptions.BunifuFormDock = this.bunifuFormDock;
            this.bunifuFormDock.TitleBarOptions.DoubleClickToExpandWindow = false;
            this.bunifuFormDock.TitleBarOptions.TitleBarControl = null;
            this.bunifuFormDock.TitleBarOptions.UseBackColorOnDockingIndicators = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            validationObject14.CustomErrorMessage = "";
            validationObject14.Optional = false;
            validationObject14.PropertyName = "Text";
            validationObject14.Regex = null;
            validationObject14.ValidationType = Kimtoo.ValidationProvider.ValidationTypes.None;
            this.validationProvider.SetLink(this.label2, validationObject14);
            this.label2.Location = new System.Drawing.Point(516, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 30);
            this.label2.TabIndex = 23;
            this.label2.Text = "أهلًا وسهلًا بك";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cairo", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            validationObject13.CustomErrorMessage = "";
            validationObject13.Optional = false;
            validationObject13.PropertyName = "Text";
            validationObject13.Regex = null;
            validationObject13.ValidationType = Kimtoo.ValidationProvider.ValidationTypes.None;
            this.validationProvider.SetLink(this.label3, validationObject13);
            this.label3.Location = new System.Drawing.Point(715, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 23);
            this.label3.TabIndex = 24;
            this.label3.Text = "الإيميل";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cairo", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            validationObject12.CustomErrorMessage = "";
            validationObject12.Optional = false;
            validationObject12.PropertyName = "Text";
            validationObject12.Regex = null;
            validationObject12.ValidationType = Kimtoo.ValidationProvider.ValidationTypes.None;
            this.validationProvider.SetLink(this.label4, validationObject12);
            this.label4.Location = new System.Drawing.Point(695, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 23);
            this.label4.TabIndex = 25;
            this.label4.Text = "كلمة المرور";
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(787, 437);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSetup);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.AppBar);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Bunifu.Utils.BunifuAppBar AppBar;
        public Kimtoo.ValidationProvider.ValidationProvider validationProvider;
        public Bunifu.UI.WinForms.BunifuSnackbar Alert;
        public Bunifu.UI.WinForms.BunifuFormDock bunifuFormDock;
        private System.Windows.Forms.Label label1;
        public Bunifu.UI.WinForms.BunifuTextBox txtEmail;
        public Bunifu.UI.WinForms.BunifuTextBox txtPassword;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel btnSetup;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}