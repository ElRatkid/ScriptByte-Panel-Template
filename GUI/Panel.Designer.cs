
namespace Panel_Template
{
    partial class Panel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Panel));
            this.topPnl = new System.Windows.Forms.Panel();
            this.miniBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.exitBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.dragControl = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.targetTextBox = new Siticone.UI.WinForms.SiticoneTextBox();
            this.portTextBox = new Siticone.UI.WinForms.SiticoneTextBox();
            this.methodDropDown = new Siticone.UI.WinForms.SiticoneComboBox();
            this.timeDropDown = new Siticone.UI.WinForms.SiticoneComboBox();
            this.attackBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.browser = new System.Windows.Forms.WebBrowser();
            this.topPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPnl
            // 
            this.topPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.topPnl.Controls.Add(this.miniBtn);
            this.topPnl.Controls.Add(this.exitBtn);
            this.topPnl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.topPnl.Location = new System.Drawing.Point(-3, -1);
            this.topPnl.Name = "topPnl";
            this.topPnl.Size = new System.Drawing.Size(986, 43);
            this.topPnl.TabIndex = 0;
            // 
            // miniBtn
            // 
            this.miniBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.miniBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.miniBtn.BorderRadius = 4;
            this.miniBtn.BorderThickness = 2;
            this.miniBtn.CheckedState.Parent = this.miniBtn;
            this.miniBtn.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.miniBtn.CustomImages.Parent = this.miniBtn;
            this.miniBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.miniBtn.Font = new System.Drawing.Font("Sitka Text", 11.25F);
            this.miniBtn.ForeColor = System.Drawing.Color.White;
            this.miniBtn.HoveredState.Parent = this.miniBtn;
            this.miniBtn.Image = ((System.Drawing.Image)(resources.GetObject("miniBtn.Image")));
            this.miniBtn.ImageSize = new System.Drawing.Size(12, 12);
            this.miniBtn.Location = new System.Drawing.Point(887, 0);
            this.miniBtn.Name = "miniBtn";
            this.miniBtn.ShadowDecoration.Parent = this.miniBtn;
            this.miniBtn.Size = new System.Drawing.Size(45, 27);
            this.miniBtn.TabIndex = 22;
            this.miniBtn.Click += new System.EventHandler(this.miniBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.exitBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.exitBtn.BorderRadius = 4;
            this.exitBtn.BorderThickness = 2;
            this.exitBtn.CheckedState.Parent = this.exitBtn;
            this.exitBtn.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.exitBtn.CustomImages.Parent = this.exitBtn;
            this.exitBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.exitBtn.Font = new System.Drawing.Font("Sitka Text", 11.25F);
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.HoveredState.Parent = this.exitBtn;
            this.exitBtn.Image = ((System.Drawing.Image)(resources.GetObject("exitBtn.Image")));
            this.exitBtn.ImageSize = new System.Drawing.Size(12, 12);
            this.exitBtn.Location = new System.Drawing.Point(938, 0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.ShadowDecoration.Parent = this.exitBtn;
            this.exitBtn.Size = new System.Drawing.Size(45, 27);
            this.exitBtn.TabIndex = 23;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // dragControl
            // 
            this.dragControl.TargetControl = this.topPnl;
            // 
            // targetTextBox
            // 
            this.targetTextBox.Animated = false;
            this.targetTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.targetTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.targetTextBox.BorderThickness = 2;
            this.targetTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.targetTextBox.DefaultText = "";
            this.targetTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.targetTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.targetTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.targetTextBox.DisabledState.Parent = this.targetTextBox;
            this.targetTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.targetTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.targetTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.targetTextBox.FocusedState.Parent = this.targetTextBox;
            this.targetTextBox.ForeColor = System.Drawing.Color.White;
            this.targetTextBox.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.targetTextBox.HoveredState.Parent = this.targetTextBox;
            this.targetTextBox.Location = new System.Drawing.Point(4, 48);
            this.targetTextBox.Name = "targetTextBox";
            this.targetTextBox.PasswordChar = '\0';
            this.targetTextBox.PlaceholderForeColor = System.Drawing.Color.White;
            this.targetTextBox.PlaceholderText = "Target";
            this.targetTextBox.SelectedText = "";
            this.targetTextBox.ShadowDecoration.Parent = this.targetTextBox;
            this.targetTextBox.Size = new System.Drawing.Size(189, 36);
            this.targetTextBox.TabIndex = 28;
            // 
            // portTextBox
            // 
            this.portTextBox.Animated = false;
            this.portTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.portTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.portTextBox.BorderThickness = 2;
            this.portTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.portTextBox.DefaultText = "";
            this.portTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.portTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.portTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.portTextBox.DisabledState.Parent = this.portTextBox;
            this.portTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.portTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.portTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.portTextBox.FocusedState.Parent = this.portTextBox;
            this.portTextBox.ForeColor = System.Drawing.Color.White;
            this.portTextBox.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.portTextBox.HoveredState.Parent = this.portTextBox;
            this.portTextBox.Location = new System.Drawing.Point(4, 90);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.PasswordChar = '\0';
            this.portTextBox.PlaceholderForeColor = System.Drawing.Color.White;
            this.portTextBox.PlaceholderText = "Port";
            this.portTextBox.SelectedText = "";
            this.portTextBox.ShadowDecoration.Parent = this.portTextBox;
            this.portTextBox.Size = new System.Drawing.Size(189, 36);
            this.portTextBox.TabIndex = 29;
            // 
            // methodDropDown
            // 
            this.methodDropDown.Animated = true;
            this.methodDropDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.methodDropDown.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.methodDropDown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.methodDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.methodDropDown.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.methodDropDown.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.methodDropDown.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.methodDropDown.ForeColor = System.Drawing.Color.White;
            this.methodDropDown.HoveredState.Parent = this.methodDropDown;
            this.methodDropDown.ItemHeight = 30;
            this.methodDropDown.Items.AddRange(new object[] {
            "UDP",
            "UDP-MIX",
            "TCP",
            "TCP-MIX",
            "OVH",
            "DNS",
            "HTTP-BYPASS",
            "AUTO-BYPASS",
            "JS-SLOWPOST",
            "ARK-LIFT",
            "ZOOM",
            "PROXY-SPAM\t",
            "--games--",
            "CSGO-DOWN",
            "PUBG-SLAP",
            "2K-FREEZE\t",
            "AMONGUS",
            "ROBLOX",
            "FN-LAG\t",
            "OVH-GAME",
            "RUST-LAG\t",
            "COD-CRASH",
            "FIVEM-REQ",
            "--other--",
            "OPENVPN\t",
            "AMP-MIX\t",
            "CHARGEN",
            "REDSYN",
            "SOURCE",
            "S-ACK",
            "SYN-X",
            "X-ACK",
            "IPSEC",
            "PLEX",
            "SNMP",
            "MDNS",
            "SSDP",
            "STUN",
            "QOTD",
            "WSD",
            "TRIANGLE",
            "HYDRA-X",
            "NFO-NAT",
            "OVH-STRESS",
            "OVH-AMP",
            "OVH-X"});
            this.methodDropDown.ItemsAppearance.Parent = this.methodDropDown;
            this.methodDropDown.Location = new System.Drawing.Point(4, 132);
            this.methodDropDown.Name = "methodDropDown";
            this.methodDropDown.ShadowDecoration.Parent = this.methodDropDown;
            this.methodDropDown.Size = new System.Drawing.Size(189, 36);
            this.methodDropDown.TabIndex = 31;
            // 
            // timeDropDown
            // 
            this.timeDropDown.Animated = true;
            this.timeDropDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.timeDropDown.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.timeDropDown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.timeDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timeDropDown.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.timeDropDown.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.timeDropDown.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.timeDropDown.ForeColor = System.Drawing.Color.White;
            this.timeDropDown.HoveredState.Parent = this.timeDropDown;
            this.timeDropDown.ItemHeight = 30;
            this.timeDropDown.Items.AddRange(new object[] {
            "100",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000",
            "1200"});
            this.timeDropDown.ItemsAppearance.Parent = this.timeDropDown;
            this.timeDropDown.Location = new System.Drawing.Point(4, 174);
            this.timeDropDown.Name = "timeDropDown";
            this.timeDropDown.ShadowDecoration.Parent = this.timeDropDown;
            this.timeDropDown.Size = new System.Drawing.Size(189, 36);
            this.timeDropDown.TabIndex = 32;
            // 
            // attackBtn
            // 
            this.attackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.attackBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.attackBtn.BorderRadius = 4;
            this.attackBtn.BorderThickness = 2;
            this.attackBtn.CheckedState.Parent = this.attackBtn;
            this.attackBtn.CustomImages.Parent = this.attackBtn;
            this.attackBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.attackBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.attackBtn.ForeColor = System.Drawing.Color.White;
            this.attackBtn.HoveredState.Parent = this.attackBtn;
            this.attackBtn.Location = new System.Drawing.Point(4, 216);
            this.attackBtn.Name = "attackBtn";
            this.attackBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.attackBtn.ShadowDecoration.Parent = this.attackBtn;
            this.attackBtn.Size = new System.Drawing.Size(189, 37);
            this.attackBtn.TabIndex = 33;
            this.attackBtn.Text = "Attack";
            this.attackBtn.Click += new System.EventHandler(this.attackBtn_Click);
            // 
            // browser
            // 
            this.browser.Location = new System.Drawing.Point(173, 216);
            this.browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.browser.Name = "browser";
            this.browser.Size = new System.Drawing.Size(20, 20);
            this.browser.TabIndex = 34;
            // 
            // Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(981, 552);
            this.Controls.Add(this.attackBtn);
            this.Controls.Add(this.timeDropDown);
            this.Controls.Add(this.methodDropDown);
            this.Controls.Add(this.portTextBox);
            this.Controls.Add(this.targetTextBox);
            this.Controls.Add(this.topPnl);
            this.Controls.Add(this.browser);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel";
            this.Load += new System.EventHandler(this.Panel_Load);
            this.topPnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPnl;
        public Siticone.UI.WinForms.SiticoneButton miniBtn;
        public Siticone.UI.WinForms.SiticoneButton exitBtn;
        private Siticone.UI.WinForms.SiticoneDragControl dragControl;
        public Siticone.UI.WinForms.SiticoneTextBox targetTextBox;
        public Siticone.UI.WinForms.SiticoneTextBox portTextBox;
        private Siticone.UI.WinForms.SiticoneComboBox methodDropDown;
        private Siticone.UI.WinForms.SiticoneComboBox timeDropDown;
        public Siticone.UI.WinForms.SiticoneButton attackBtn;
        private System.Windows.Forms.WebBrowser browser;
    }
}

