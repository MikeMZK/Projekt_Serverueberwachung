namespace Client
{
    partial class frmClient
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cpbCPU = new CircularProgressBar.CircularProgressBar();
            this.btnLogin = new System.Windows.Forms.Button();
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.gbProperties = new System.Windows.Forms.GroupBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.tpPerformance = new System.Windows.Forms.TabPage();
            this.tbcPerfMenu = new System.Windows.Forms.TabControl();
            this.tabCPU = new System.Windows.Forms.TabPage();
            this.ctCores = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ctCPU = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabDisk = new System.Windows.Forms.TabPage();
            this.ctDiskR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ctDiskWork = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabRAM = new System.Windows.Forms.TabPage();
            this.ctRAM = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tbNetwork = new System.Windows.Forms.TabPage();
            this.tpInformation = new System.Windows.Forms.TabPage();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.lblOS = new System.Windows.Forms.Label();
            this.lblAccountName = new System.Windows.Forms.Label();
            this.lblComputerName = new System.Windows.Forms.Label();
            this.lblMacAddress = new System.Windows.Forms.Label();
            this.lblBios = new System.Windows.Forms.Label();
            this.lblMainboard = new System.Windows.Forms.Label();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.cpbDisk = new CircularProgressBar.CircularProgressBar();
            this.cpbNetwork = new CircularProgressBar.CircularProgressBar();
            this.cpbRAM = new CircularProgressBar.CircularProgressBar();
            this.ctDiskW = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gbLogin.SuspendLayout();
            this.gbProperties.SuspendLayout();
            this.tpPerformance.SuspendLayout();
            this.tbcPerfMenu.SuspendLayout();
            this.tabCPU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctCores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctCPU)).BeginInit();
            this.tabDisk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctDiskR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctDiskWork)).BeginInit();
            this.tabRAM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctRAM)).BeginInit();
            this.tpInformation.SuspendLayout();
            this.tcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctDiskW)).BeginInit();
            this.SuspendLayout();
            // 
            // cpbCPU
            // 
            this.cpbCPU.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cpbCPU.AnimationSpeed = 500;
            this.cpbCPU.BackColor = System.Drawing.Color.Transparent;
            this.cpbCPU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cpbCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.cpbCPU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cpbCPU.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cpbCPU.InnerMargin = 2;
            this.cpbCPU.InnerWidth = -1;
            this.cpbCPU.Location = new System.Drawing.Point(9, 27);
            this.cpbCPU.MarqueeAnimationSpeed = 2000;
            this.cpbCPU.Name = "cpbCPU";
            this.cpbCPU.OuterColor = System.Drawing.Color.Gray;
            this.cpbCPU.OuterMargin = -25;
            this.cpbCPU.OuterWidth = 26;
            this.cpbCPU.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cpbCPU.ProgressWidth = 25;
            this.cpbCPU.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.cpbCPU.Size = new System.Drawing.Size(150, 150);
            this.cpbCPU.StartAngle = 270;
            this.cpbCPU.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbCPU.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cpbCPU.SubscriptText = "";
            this.cpbCPU.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbCPU.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cpbCPU.SuperscriptText = "";
            this.cpbCPU.TabIndex = 1;
            this.cpbCPU.Text = "CPU";
            this.cpbCPU.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.cpbCPU.Value = 68;
            this.cpbCPU.Visible = false;
            this.cpbCPU.Click += new System.EventHandler(this.cpbCPU_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(12, 144);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(174, 27);
            this.btnLogin.TabIndex = 17;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // gbLogin
            // 
            this.gbLogin.Controls.Add(this.lblInfo);
            this.gbLogin.Controls.Add(this.txtUsername);
            this.gbLogin.Controls.Add(this.txtPassword);
            this.gbLogin.Controls.Add(this.lblPassword);
            this.gbLogin.Controls.Add(this.lblUsername);
            this.gbLogin.Location = new System.Drawing.Point(19, 33);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(229, 88);
            this.gbLogin.TabIndex = 16;
            this.gbLogin.TabStop = false;
            this.gbLogin.Text = "Login";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(11, 70);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(188, 13);
            this.lblInfo.TabIndex = 11;
            this.lblInfo.Text = "Username: Admin    - Password: admin";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(67, 19);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(121, 20);
            this.txtUsername.TabIndex = 7;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(67, 45);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(121, 20);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(11, 48);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(11, 22);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 10;
            this.lblUsername.Text = "Username";
            // 
            // gbProperties
            // 
            this.gbProperties.Controls.Add(this.txtIP);
            this.gbProperties.Controls.Add(this.txtPort);
            this.gbProperties.Controls.Add(this.lblPort);
            this.gbProperties.Controls.Add(this.lblIP);
            this.gbProperties.Location = new System.Drawing.Point(280, 33);
            this.gbProperties.Name = "gbProperties";
            this.gbProperties.Size = new System.Drawing.Size(229, 88);
            this.gbProperties.TabIndex = 15;
            this.gbProperties.TabStop = false;
            this.gbProperties.Text = "Properties";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(63, 19);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(121, 20);
            this.txtIP.TabIndex = 7;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(63, 45);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(43, 20);
            this.txtPort.TabIndex = 8;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(11, 48);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(26, 13);
            this.lblPort.TabIndex = 9;
            this.lblPort.Text = "Port";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(11, 22);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(17, 13);
            this.lblIP.TabIndex = 10;
            this.lblIP.Text = "IP";
            // 
            // tpPerformance
            // 
            this.tpPerformance.Controls.Add(this.tbcPerfMenu);
            this.tpPerformance.Location = new System.Drawing.Point(4, 22);
            this.tpPerformance.Name = "tpPerformance";
            this.tpPerformance.Padding = new System.Windows.Forms.Padding(3);
            this.tpPerformance.Size = new System.Drawing.Size(781, 436);
            this.tpPerformance.TabIndex = 1;
            this.tpPerformance.Text = "Performance";
            this.tpPerformance.UseVisualStyleBackColor = true;
            this.tpPerformance.Enter += new System.EventHandler(this.tpPerformance_Enter);
            this.tpPerformance.Leave += new System.EventHandler(this.tpPerformance_Leave);
            // 
            // tbcPerfMenu
            // 
            this.tbcPerfMenu.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tbcPerfMenu.Controls.Add(this.tabCPU);
            this.tbcPerfMenu.Controls.Add(this.tabDisk);
            this.tbcPerfMenu.Controls.Add(this.tabRAM);
            this.tbcPerfMenu.Controls.Add(this.tbNetwork);
            this.tbcPerfMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcPerfMenu.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tbcPerfMenu.ItemSize = new System.Drawing.Size(150, 150);
            this.tbcPerfMenu.Location = new System.Drawing.Point(3, 3);
            this.tbcPerfMenu.Multiline = true;
            this.tbcPerfMenu.Name = "tbcPerfMenu";
            this.tbcPerfMenu.SelectedIndex = 0;
            this.tbcPerfMenu.Size = new System.Drawing.Size(775, 430);
            this.tbcPerfMenu.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tbcPerfMenu.TabIndex = 0;
            // 
            // tabCPU
            // 
            this.tabCPU.Controls.Add(this.ctCores);
            this.tabCPU.Controls.Add(this.ctCPU);
            this.tabCPU.Location = new System.Drawing.Point(304, 4);
            this.tabCPU.Name = "tabCPU";
            this.tabCPU.Padding = new System.Windows.Forms.Padding(3);
            this.tabCPU.Size = new System.Drawing.Size(467, 422);
            this.tabCPU.TabIndex = 1;
            this.tabCPU.Text = "CPU";
            this.tabCPU.UseVisualStyleBackColor = true;
            // 
            // ctCores
            // 
            chartArea1.Name = "ChartArea1";
            this.ctCores.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ctCores.Legends.Add(legend1);
            this.ctCores.Location = new System.Drawing.Point(12, 132);
            this.ctCores.Name = "ctCores";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ctCores.Series.Add(series1);
            this.ctCores.Size = new System.Drawing.Size(452, 120);
            this.ctCores.TabIndex = 1;
            this.ctCores.Text = "Cores";
            // 
            // ctCPU
            // 
            chartArea2.Name = "ChartArea1";
            this.ctCPU.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ctCPU.Legends.Add(legend2);
            this.ctCPU.Location = new System.Drawing.Point(12, 6);
            this.ctCPU.Name = "ctCPU";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "CPU";
            this.ctCPU.Series.Add(series2);
            this.ctCPU.Size = new System.Drawing.Size(452, 120);
            this.ctCPU.TabIndex = 0;
            this.ctCPU.Text = "CPU";
            // 
            // tabDisk
            // 
            this.tabDisk.Controls.Add(this.ctDiskW);
            this.tabDisk.Controls.Add(this.ctDiskR);
            this.tabDisk.Controls.Add(this.ctDiskWork);
            this.tabDisk.Location = new System.Drawing.Point(304, 4);
            this.tabDisk.Name = "tabDisk";
            this.tabDisk.Padding = new System.Windows.Forms.Padding(3);
            this.tabDisk.Size = new System.Drawing.Size(467, 422);
            this.tabDisk.TabIndex = 2;
            this.tabDisk.Text = "Disk";
            this.tabDisk.UseVisualStyleBackColor = true;
            // 
            // ctDiskR
            // 
            chartArea4.Name = "ChartArea1";
            this.ctDiskR.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.ctDiskR.Legends.Add(legend4);
            this.ctDiskR.Location = new System.Drawing.Point(0, 166);
            this.ctDiskR.Name = "ctDiskR";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.ctDiskR.Series.Add(series4);
            this.ctDiskR.Size = new System.Drawing.Size(468, 162);
            this.ctDiskR.TabIndex = 1;
            this.ctDiskR.Text = "ctDiskRead";
            // 
            // ctDiskWork
            // 
            chartArea5.Name = "ChartArea1";
            this.ctDiskWork.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.ctDiskWork.Legends.Add(legend5);
            this.ctDiskWork.Location = new System.Drawing.Point(0, 0);
            this.ctDiskWork.Name = "ctDiskWork";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.ctDiskWork.Series.Add(series5);
            this.ctDiskWork.Size = new System.Drawing.Size(468, 162);
            this.ctDiskWork.TabIndex = 0;
            this.ctDiskWork.Text = "ctDiskWorkload";
            // 
            // tabRAM
            // 
            this.tabRAM.Controls.Add(this.ctRAM);
            this.tabRAM.Location = new System.Drawing.Point(304, 4);
            this.tabRAM.Name = "tabRAM";
            this.tabRAM.Padding = new System.Windows.Forms.Padding(3);
            this.tabRAM.Size = new System.Drawing.Size(467, 422);
            this.tabRAM.TabIndex = 3;
            this.tabRAM.Text = "RAM";
            this.tabRAM.UseVisualStyleBackColor = true;
            // 
            // ctRAM
            // 
            chartArea6.Name = "ChartArea1";
            this.ctRAM.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.ctRAM.Legends.Add(legend6);
            this.ctRAM.Location = new System.Drawing.Point(4, 3);
            this.ctRAM.Name = "ctRAM";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.ctRAM.Series.Add(series6);
            this.ctRAM.Size = new System.Drawing.Size(458, 202);
            this.ctRAM.TabIndex = 0;
            this.ctRAM.Text = "RAM ";
            // 
            // tbNetwork
            // 
            this.tbNetwork.Location = new System.Drawing.Point(304, 4);
            this.tbNetwork.Name = "tbNetwork";
            this.tbNetwork.Padding = new System.Windows.Forms.Padding(3);
            this.tbNetwork.Size = new System.Drawing.Size(467, 422);
            this.tbNetwork.TabIndex = 4;
            this.tbNetwork.Text = "Network";
            this.tbNetwork.UseVisualStyleBackColor = true;
            // 
            // tpInformation
            // 
            this.tpInformation.Controls.Add(this.lblLanguage);
            this.tpInformation.Controls.Add(this.lblOS);
            this.tpInformation.Controls.Add(this.lblAccountName);
            this.tpInformation.Controls.Add(this.lblComputerName);
            this.tpInformation.Controls.Add(this.lblMacAddress);
            this.tpInformation.Controls.Add(this.lblBios);
            this.tpInformation.Controls.Add(this.lblMainboard);
            this.tpInformation.Location = new System.Drawing.Point(4, 22);
            this.tpInformation.Name = "tpInformation";
            this.tpInformation.Padding = new System.Windows.Forms.Padding(3);
            this.tpInformation.Size = new System.Drawing.Size(781, 436);
            this.tpInformation.TabIndex = 0;
            this.tpInformation.Text = "Informations";
            this.tpInformation.UseVisualStyleBackColor = true;
            this.tpInformation.Enter += new System.EventHandler(this.tpInformation_Enter);
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(16, 111);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(61, 13);
            this.lblLanguage.TabIndex = 24;
            this.lblLanguage.Text = "Language: ";
            // 
            // lblOS
            // 
            this.lblOS.AutoSize = true;
            this.lblOS.Location = new System.Drawing.Point(16, 95);
            this.lblOS.Name = "lblOS";
            this.lblOS.Size = new System.Drawing.Size(28, 13);
            this.lblOS.TabIndex = 23;
            this.lblOS.Text = "OS: ";
            // 
            // lblAccountName
            // 
            this.lblAccountName.AutoSize = true;
            this.lblAccountName.Location = new System.Drawing.Point(16, 77);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(81, 13);
            this.lblAccountName.TabIndex = 22;
            this.lblAccountName.Text = "Account Name:";
            // 
            // lblComputerName
            // 
            this.lblComputerName.AutoSize = true;
            this.lblComputerName.Location = new System.Drawing.Point(16, 60);
            this.lblComputerName.Name = "lblComputerName";
            this.lblComputerName.Size = new System.Drawing.Size(86, 13);
            this.lblComputerName.TabIndex = 21;
            this.lblComputerName.Text = "Computer Name:";
            // 
            // lblMacAddress
            // 
            this.lblMacAddress.AutoSize = true;
            this.lblMacAddress.Location = new System.Drawing.Point(16, 43);
            this.lblMacAddress.Name = "lblMacAddress";
            this.lblMacAddress.Size = new System.Drawing.Size(69, 13);
            this.lblMacAddress.TabIndex = 20;
            this.lblMacAddress.Text = "MacAddress:";
            // 
            // lblBios
            // 
            this.lblBios.AutoSize = true;
            this.lblBios.Location = new System.Drawing.Point(16, 25);
            this.lblBios.Name = "lblBios";
            this.lblBios.Size = new System.Drawing.Size(30, 13);
            this.lblBios.TabIndex = 19;
            this.lblBios.Text = "Bios:";
            // 
            // lblMainboard
            // 
            this.lblMainboard.AutoSize = true;
            this.lblMainboard.Location = new System.Drawing.Point(16, 8);
            this.lblMainboard.Name = "lblMainboard";
            this.lblMainboard.Size = new System.Drawing.Size(60, 13);
            this.lblMainboard.TabIndex = 18;
            this.lblMainboard.Text = "Mainboard:";
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpInformation);
            this.tcMain.Controls.Add(this.tpPerformance);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(789, 462);
            this.tcMain.TabIndex = 2;
            this.tcMain.Visible = false;
            // 
            // cpbDisk
            // 
            this.cpbDisk.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cpbDisk.AnimationSpeed = 500;
            this.cpbDisk.BackColor = System.Drawing.Color.Transparent;
            this.cpbDisk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cpbDisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.cpbDisk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cpbDisk.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cpbDisk.InnerMargin = 2;
            this.cpbDisk.InnerWidth = -1;
            this.cpbDisk.Location = new System.Drawing.Point(11, 177);
            this.cpbDisk.MarqueeAnimationSpeed = 2000;
            this.cpbDisk.Name = "cpbDisk";
            this.cpbDisk.OuterColor = System.Drawing.Color.Gray;
            this.cpbDisk.OuterMargin = -25;
            this.cpbDisk.OuterWidth = 26;
            this.cpbDisk.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cpbDisk.ProgressWidth = 25;
            this.cpbDisk.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.cpbDisk.Size = new System.Drawing.Size(150, 150);
            this.cpbDisk.StartAngle = 270;
            this.cpbDisk.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbDisk.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cpbDisk.SubscriptText = "";
            this.cpbDisk.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbDisk.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cpbDisk.SuperscriptText = "";
            this.cpbDisk.TabIndex = 3;
            this.cpbDisk.Text = "Disk";
            this.cpbDisk.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.cpbDisk.Value = 68;
            this.cpbDisk.Visible = false;
            this.cpbDisk.Click += new System.EventHandler(this.cpbDisk_Click);
            // 
            // cpbNetwork
            // 
            this.cpbNetwork.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cpbNetwork.AnimationSpeed = 500;
            this.cpbNetwork.BackColor = System.Drawing.Color.Transparent;
            this.cpbNetwork.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cpbNetwork.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.cpbNetwork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cpbNetwork.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cpbNetwork.InnerMargin = 2;
            this.cpbNetwork.InnerWidth = -1;
            this.cpbNetwork.Location = new System.Drawing.Point(11, 475);
            this.cpbNetwork.MarqueeAnimationSpeed = 2000;
            this.cpbNetwork.Name = "cpbNetwork";
            this.cpbNetwork.OuterColor = System.Drawing.Color.Gray;
            this.cpbNetwork.OuterMargin = -25;
            this.cpbNetwork.OuterWidth = 26;
            this.cpbNetwork.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cpbNetwork.ProgressWidth = 25;
            this.cpbNetwork.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.cpbNetwork.Size = new System.Drawing.Size(150, 150);
            this.cpbNetwork.StartAngle = 270;
            this.cpbNetwork.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbNetwork.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cpbNetwork.SubscriptText = "";
            this.cpbNetwork.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbNetwork.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cpbNetwork.SuperscriptText = "";
            this.cpbNetwork.TabIndex = 4;
            this.cpbNetwork.Text = "Network";
            this.cpbNetwork.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.cpbNetwork.Value = 68;
            this.cpbNetwork.Visible = false;
            this.cpbNetwork.Click += new System.EventHandler(this.cpbNetwork_Click);
            // 
            // cpbRAM
            // 
            this.cpbRAM.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cpbRAM.AnimationSpeed = 500;
            this.cpbRAM.BackColor = System.Drawing.Color.Transparent;
            this.cpbRAM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cpbRAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.cpbRAM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cpbRAM.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cpbRAM.InnerMargin = 2;
            this.cpbRAM.InnerWidth = -1;
            this.cpbRAM.Location = new System.Drawing.Point(11, 328);
            this.cpbRAM.MarqueeAnimationSpeed = 2000;
            this.cpbRAM.Name = "cpbRAM";
            this.cpbRAM.OuterColor = System.Drawing.Color.Gray;
            this.cpbRAM.OuterMargin = -25;
            this.cpbRAM.OuterWidth = 26;
            this.cpbRAM.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cpbRAM.ProgressWidth = 25;
            this.cpbRAM.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.cpbRAM.Size = new System.Drawing.Size(150, 150);
            this.cpbRAM.StartAngle = 270;
            this.cpbRAM.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbRAM.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cpbRAM.SubscriptText = "";
            this.cpbRAM.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbRAM.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cpbRAM.SuperscriptText = "";
            this.cpbRAM.TabIndex = 5;
            this.cpbRAM.Text = "RAM";
            this.cpbRAM.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.cpbRAM.Value = 68;
            this.cpbRAM.Visible = false;
            this.cpbRAM.Click += new System.EventHandler(this.cpbRAM_Click);
            // 
            // ctDiskW
            // 
            chartArea3.Name = "ChartArea1";
            this.ctDiskW.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.ctDiskW.Legends.Add(legend3);
            this.ctDiskW.Location = new System.Drawing.Point(1, 324);
            this.ctDiskW.Name = "ctDiskW";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.ctDiskW.Series.Add(series3);
            this.ctDiskW.Size = new System.Drawing.Size(468, 162);
            this.ctDiskW.TabIndex = 2;
            this.ctDiskW.Text = "Write";
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 462);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.cpbNetwork);
            this.Controls.Add(this.gbLogin);
            this.Controls.Add(this.cpbDisk);
            this.Controls.Add(this.gbProperties);
            this.Controls.Add(this.cpbRAM);
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.cpbCPU);
            this.Name = "frmClient";
            this.Text = "Client";
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            this.gbProperties.ResumeLayout(false);
            this.gbProperties.PerformLayout();
            this.tpPerformance.ResumeLayout(false);
            this.tbcPerfMenu.ResumeLayout(false);
            this.tabCPU.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ctCores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctCPU)).EndInit();
            this.tabDisk.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ctDiskR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctDiskWork)).EndInit();
            this.tabRAM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ctRAM)).EndInit();
            this.tpInformation.ResumeLayout(false);
            this.tpInformation.PerformLayout();
            this.tcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ctDiskW)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CircularProgressBar.CircularProgressBar cpbCPU;
        private System.Windows.Forms.TabPage tpPerformance;
        private System.Windows.Forms.TabControl tbcPerfMenu;
        private System.Windows.Forms.TabPage tabCPU;
        private System.Windows.Forms.TabPage tpInformation;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.GroupBox gbProperties;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TabPage tabDisk;
        private System.Windows.Forms.TabPage tabRAM;
        private System.Windows.Forms.TabPage tbNetwork;
        private CircularProgressBar.CircularProgressBar cpbDisk;
        private CircularProgressBar.CircularProgressBar cpbNetwork;
        private CircularProgressBar.CircularProgressBar cpbRAM;
        private System.Windows.Forms.Label lblOS;
        private System.Windows.Forms.Label lblAccountName;
        private System.Windows.Forms.Label lblComputerName;
        private System.Windows.Forms.Label lblMacAddress;
        private System.Windows.Forms.Label lblBios;
        private System.Windows.Forms.Label lblMainboard;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.DataVisualization.Charting.Chart ctCores;
        private System.Windows.Forms.DataVisualization.Charting.Chart ctCPU;
        private System.Windows.Forms.DataVisualization.Charting.Chart ctDiskR;
        private System.Windows.Forms.DataVisualization.Charting.Chart ctDiskWork;
        private System.Windows.Forms.DataVisualization.Charting.Chart ctRAM;
        private System.Windows.Forms.DataVisualization.Charting.Chart ctDiskW;
    }
}

