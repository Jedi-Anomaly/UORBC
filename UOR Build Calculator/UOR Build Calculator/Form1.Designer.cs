namespace UOR_Build_Calculator
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbStatStr = new System.Windows.Forms.TextBox();
            this.tbStatDex = new System.Windows.Forms.TextBox();
            this.tbStatInt = new System.Windows.Forms.TextBox();
            this.btnSkillInfo = new System.Windows.Forms.Button();
            this.tbBuildName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnExportBuild = new System.Windows.Forms.Button();
            this.tbExportPath = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblStatTot = new System.Windows.Forms.Label();
            this.lblIntErr = new System.Windows.Forms.Label();
            this.lblDexErr = new System.Windows.Forms.Label();
            this.lblStrErr = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbStatTotal = new System.Windows.Forms.TextBox();
            this.lblMana = new System.Windows.Forms.Label();
            this.lblStam = new System.Windows.Forms.Label();
            this.lblHits = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnClearBuild = new System.Windows.Forms.Button();
            this.lblBlast = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblHealtime = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbDisarm = new System.Windows.Forms.CheckBox();
            this.cbStun = new System.Windows.Forms.CheckBox();
            this.cbParablow = new System.Windows.Forms.CheckBox();
            this.cbCrush = new System.Windows.Forms.CheckBox();
            this.cbConcussion = new System.Windows.Forms.CheckBox();
            this.comboPremade = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnPremade = new System.Windows.Forms.Button();
            this.Skill_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Skill_Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Alchemy",
            "Anatomy",
            "Animal Lore",
            "Animal Taming",
            "Archery",
            "Arms Lore",
            "Begging",
            "Blacksmithy",
            "Bowcraft/Fletching",
            "Camping",
            "Carpentry",
            "Cartography",
            "Cooking",
            "Detecting Hidden",
            "Discordance",
            "Evaluating Intelligence",
            "Fencing",
            "Fishing",
            "Forensic Evaluation",
            "Healing",
            "Herding",
            "Hiding",
            "Inscription",
            "Item Identification",
            "Lockpicking",
            "Lumberjacking",
            "Mace Fighting",
            "Magery",
            "Meditation",
            "Mining",
            "Musicianship",
            "Parrying",
            "Peacemaking",
            "Poisoning",
            "Provocation",
            "Remove Trap",
            "Resisting Spells",
            "Snooping",
            "Spirit Speak",
            "Stealing",
            "Stealth",
            "Swordsmanship",
            "Tactics",
            "Tailoring",
            "Taste Identification",
            "Tinkering",
            "Tracking",
            "Veterinary",
            "Wrestling"});
            this.comboBox1.Location = new System.Drawing.Point(4, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(197, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select a Skill to add to your build:";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(6, 67);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(193, 45);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolTip1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.toolTip1.ToolTipTitle = "Skill Value";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(4, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add Skill to Build";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnAddSkill_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Skill_Name,
            this.Skill_Value});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(221, 4);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(244, 196);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            this.dataGridView1.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellLeave);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(3, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Current Skill Total:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(4, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Strength";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(4, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Dexterity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(4, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Intelligence";
            // 
            // tbStatStr
            // 
            this.tbStatStr.Location = new System.Drawing.Point(71, 20);
            this.tbStatStr.Name = "tbStatStr";
            this.tbStatStr.Size = new System.Drawing.Size(31, 20);
            this.tbStatStr.TabIndex = 12;
            this.tbStatStr.Text = "10";
            this.tbStatStr.TextChanged += new System.EventHandler(this.tbStatStr_TextChanged);
            // 
            // tbStatDex
            // 
            this.tbStatDex.Location = new System.Drawing.Point(71, 46);
            this.tbStatDex.Name = "tbStatDex";
            this.tbStatDex.Size = new System.Drawing.Size(31, 20);
            this.tbStatDex.TabIndex = 13;
            this.tbStatDex.Text = "10";
            this.tbStatDex.TextChanged += new System.EventHandler(this.tbStatDex_TextChanged);
            // 
            // tbStatInt
            // 
            this.tbStatInt.Location = new System.Drawing.Point(71, 72);
            this.tbStatInt.Name = "tbStatInt";
            this.tbStatInt.Size = new System.Drawing.Size(31, 20);
            this.tbStatInt.TabIndex = 14;
            this.tbStatInt.Text = "10";
            this.tbStatInt.TextChanged += new System.EventHandler(this.tbStatInt_TextChanged);
            // 
            // btnSkillInfo
            // 
            this.btnSkillInfo.Location = new System.Drawing.Point(4, 118);
            this.btnSkillInfo.Name = "btnSkillInfo";
            this.btnSkillInfo.Size = new System.Drawing.Size(195, 23);
            this.btnSkillInfo.TabIndex = 15;
            this.btnSkillInfo.Text = "Skill Information";
            this.btnSkillInfo.UseVisualStyleBackColor = true;
            this.btnSkillInfo.Click += new System.EventHandler(this.btnSkillInfo_Click);
            // 
            // tbBuildName
            // 
            this.tbBuildName.Location = new System.Drawing.Point(4, 72);
            this.tbBuildName.Name = "tbBuildName";
            this.tbBuildName.Size = new System.Drawing.Size(195, 20);
            this.tbBuildName.TabIndex = 16;
            this.tbBuildName.TextChanged += new System.EventHandler(this.tbBuildName_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Name your build:";
            // 
            // btnExportBuild
            // 
            this.btnExportBuild.Location = new System.Drawing.Point(4, 97);
            this.btnExportBuild.Name = "btnExportBuild";
            this.btnExportBuild.Size = new System.Drawing.Size(195, 23);
            this.btnExportBuild.TabIndex = 18;
            this.btnExportBuild.Text = "Export Build";
            this.btnExportBuild.UseVisualStyleBackColor = true;
            this.btnExportBuild.Click += new System.EventHandler(this.btnExportBuild_Click);
            // 
            // tbExportPath
            // 
            this.tbExportPath.Location = new System.Drawing.Point(4, 33);
            this.tbExportPath.Name = "tbExportPath";
            this.tbExportPath.Size = new System.Drawing.Size(195, 20);
            this.tbExportPath.TabIndex = 19;
            this.tbExportPath.Text = "Click to designate export path";
            this.tbExportPath.Click += new System.EventHandler(this.tbExportPath_Click);
            this.tbExportPath.TextChanged += new System.EventHandler(this.tbExportPath_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Export Path";
            // 
            // webBrowser1
            // 
            this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser1.Location = new System.Drawing.Point(471, 12);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(917, 545);
            this.webBrowser1.TabIndex = 22;
            this.webBrowser1.Url = new System.Uri("", System.UriKind.Relative);
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblStatTot);
            this.groupBox1.Controls.Add(this.lblIntErr);
            this.groupBox1.Controls.Add(this.lblDexErr);
            this.groupBox1.Controls.Add(this.lblStrErr);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbStatTotal);
            this.groupBox1.Controls.Add(this.tbStatStr);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbStatDex);
            this.groupBox1.Controls.Add(this.tbStatInt);
            this.groupBox1.Location = new System.Drawing.Point(8, 209);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 127);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stats";
            // 
            // lblStatTot
            // 
            this.lblStatTot.AutoSize = true;
            this.lblStatTot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblStatTot.Location = new System.Drawing.Point(108, 101);
            this.lblStatTot.Name = "lblStatTot";
            this.lblStatTot.Size = new System.Drawing.Size(0, 13);
            this.lblStatTot.TabIndex = 20;
            // 
            // lblIntErr
            // 
            this.lblIntErr.AutoSize = true;
            this.lblIntErr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblIntErr.Location = new System.Drawing.Point(108, 75);
            this.lblIntErr.Name = "lblIntErr";
            this.lblIntErr.Size = new System.Drawing.Size(0, 13);
            this.lblIntErr.TabIndex = 19;
            // 
            // lblDexErr
            // 
            this.lblDexErr.AutoSize = true;
            this.lblDexErr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblDexErr.Location = new System.Drawing.Point(108, 49);
            this.lblDexErr.Name = "lblDexErr";
            this.lblDexErr.Size = new System.Drawing.Size(0, 13);
            this.lblDexErr.TabIndex = 18;
            // 
            // lblStrErr
            // 
            this.lblStrErr.AutoSize = true;
            this.lblStrErr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblStrErr.Location = new System.Drawing.Point(108, 23);
            this.lblStrErr.Name = "lblStrErr";
            this.lblStrErr.Size = new System.Drawing.Size(0, 13);
            this.lblStrErr.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label8.Location = new System.Drawing.Point(4, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Total";
            // 
            // tbStatTotal
            // 
            this.tbStatTotal.Enabled = false;
            this.tbStatTotal.Location = new System.Drawing.Point(71, 98);
            this.tbStatTotal.Name = "tbStatTotal";
            this.tbStatTotal.Size = new System.Drawing.Size(31, 20);
            this.tbStatTotal.TabIndex = 16;
            this.tbStatTotal.Text = "30";
            this.tbStatTotal.TextChanged += new System.EventHandler(this.tbStatTotal_TextChanged);
            // 
            // lblMana
            // 
            this.lblMana.AutoSize = true;
            this.lblMana.Location = new System.Drawing.Point(166, 52);
            this.lblMana.Name = "lblMana";
            this.lblMana.Size = new System.Drawing.Size(40, 13);
            this.lblMana.TabIndex = 28;
            this.lblMana.Text = "Mana: ";
            this.lblMana.Click += new System.EventHandler(this.lblMana_Click);
            // 
            // lblStam
            // 
            this.lblStam.AutoSize = true;
            this.lblStam.Location = new System.Drawing.Point(166, 33);
            this.lblStam.Name = "lblStam";
            this.lblStam.Size = new System.Drawing.Size(37, 13);
            this.lblStam.TabIndex = 27;
            this.lblStam.Text = "Stam: ";
            this.lblStam.Click += new System.EventHandler(this.lblStam_Click);
            // 
            // lblHits
            // 
            this.lblHits.AutoSize = true;
            this.lblHits.Location = new System.Drawing.Point(166, 14);
            this.lblHits.Name = "lblHits";
            this.lblHits.Size = new System.Drawing.Size(31, 13);
            this.lblHits.TabIndex = 26;
            this.lblHits.Text = "Hits: ";
            this.lblHits.Click += new System.EventHandler(this.lblHits_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.trackBar1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnSkillInfo);
            this.groupBox2.Location = new System.Drawing.Point(8, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(207, 199);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Skills";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnClearBuild);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.tbBuildName);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btnExportBuild);
            this.groupBox3.Controls.Add(this.tbExportPath);
            this.groupBox3.Location = new System.Drawing.Point(8, 342);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(207, 167);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Export";
            // 
            // btnClearBuild
            // 
            this.btnClearBuild.Location = new System.Drawing.Point(124, 138);
            this.btnClearBuild.Name = "btnClearBuild";
            this.btnClearBuild.Size = new System.Drawing.Size(75, 23);
            this.btnClearBuild.TabIndex = 30;
            this.btnClearBuild.Text = "Clear Build";
            this.btnClearBuild.UseVisualStyleBackColor = true;
            this.btnClearBuild.Click += new System.EventHandler(this.btnClearBuild_Click);
            // 
            // lblBlast
            // 
            this.lblBlast.AutoSize = true;
            this.lblBlast.Location = new System.Drawing.Point(6, 33);
            this.lblBlast.Name = "lblBlast";
            this.lblBlast.Size = new System.Drawing.Size(100, 13);
            this.lblBlast.TabIndex = 26;
            this.lblBlast.Text = "min/max mind blast:";
            this.lblBlast.Click += new System.EventHandler(this.lblBlast_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblHealtime);
            this.groupBox4.Controls.Add(this.lblMana);
            this.groupBox4.Controls.Add(this.lblWeight);
            this.groupBox4.Controls.Add(this.lblStam);
            this.groupBox4.Controls.Add(this.lblBlast);
            this.groupBox4.Controls.Add(this.lblHits);
            this.groupBox4.Location = new System.Drawing.Point(221, 307);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(244, 202);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Other Info";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // lblHealtime
            // 
            this.lblHealtime.AutoSize = true;
            this.lblHealtime.Location = new System.Drawing.Point(6, 52);
            this.lblHealtime.Name = "lblHealtime";
            this.lblHealtime.Size = new System.Drawing.Size(93, 13);
            this.lblHealtime.TabIndex = 31;
            this.lblHealtime.Text = "bandage self time:";
            this.lblHealtime.Click += new System.EventHandler(this.lblHealtime_Click);
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(6, 15);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(109, 13);
            this.lblWeight.TabIndex = 30;
            this.lblWeight.Text = "max carrying capcity: ";
            this.lblWeight.Click += new System.EventHandler(this.lblWeight_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Gray;
            this.groupBox5.Controls.Add(this.cbDisarm);
            this.groupBox5.Controls.Add(this.cbStun);
            this.groupBox5.Controls.Add(this.cbParablow);
            this.groupBox5.Controls.Add(this.cbCrush);
            this.groupBox5.Controls.Add(this.cbConcussion);
            this.groupBox5.Location = new System.Drawing.Point(221, 209);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(244, 90);
            this.groupBox5.TabIndex = 27;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Special Abilities";
            // 
            // cbDisarm
            // 
            this.cbDisarm.AutoSize = true;
            this.cbDisarm.Enabled = false;
            this.cbDisarm.Location = new System.Drawing.Point(9, 69);
            this.cbDisarm.Name = "cbDisarm";
            this.cbDisarm.Size = new System.Drawing.Size(58, 17);
            this.cbDisarm.TabIndex = 31;
            this.cbDisarm.Text = "Disarm";
            this.cbDisarm.UseVisualStyleBackColor = true;
            this.cbDisarm.CheckedChanged += new System.EventHandler(this.cbDisarm_CheckedChanged);
            // 
            // cbStun
            // 
            this.cbStun.AutoSize = true;
            this.cbStun.Enabled = false;
            this.cbStun.Location = new System.Drawing.Point(9, 55);
            this.cbStun.Name = "cbStun";
            this.cbStun.Size = new System.Drawing.Size(82, 17);
            this.cbStun.TabIndex = 30;
            this.cbStun.Text = "Stun Punch";
            this.cbStun.UseVisualStyleBackColor = true;
            this.cbStun.CheckedChanged += new System.EventHandler(this.cbStun_CheckedChanged);
            // 
            // cbParablow
            // 
            this.cbParablow.AutoSize = true;
            this.cbParablow.Enabled = false;
            this.cbParablow.Location = new System.Drawing.Point(9, 41);
            this.cbParablow.Name = "cbParablow";
            this.cbParablow.Size = new System.Drawing.Size(100, 17);
            this.cbParablow.TabIndex = 27;
            this.cbParablow.Text = "Paralyzing Blow";
            this.cbParablow.UseVisualStyleBackColor = true;
            this.cbParablow.CheckedChanged += new System.EventHandler(this.cbParablow_CheckedChanged);
            // 
            // cbCrush
            // 
            this.cbCrush.AutoSize = true;
            this.cbCrush.Enabled = false;
            this.cbCrush.Location = new System.Drawing.Point(9, 27);
            this.cbCrush.Name = "cbCrush";
            this.cbCrush.Size = new System.Drawing.Size(93, 17);
            this.cbCrush.TabIndex = 29;
            this.cbCrush.Text = "Crushing Blow";
            this.cbCrush.UseVisualStyleBackColor = true;
            this.cbCrush.CheckedChanged += new System.EventHandler(this.cbCrush_CheckedChanged);
            // 
            // cbConcussion
            // 
            this.cbConcussion.AutoSize = true;
            this.cbConcussion.Enabled = false;
            this.cbConcussion.Location = new System.Drawing.Point(9, 13);
            this.cbConcussion.Name = "cbConcussion";
            this.cbConcussion.Size = new System.Drawing.Size(107, 17);
            this.cbConcussion.TabIndex = 28;
            this.cbConcussion.Text = "Concussion Blow";
            this.cbConcussion.UseVisualStyleBackColor = true;
            this.cbConcussion.CheckedChanged += new System.EventHandler(this.cbConcussion_CheckedChanged);
            // 
            // comboPremade
            // 
            this.comboPremade.FormattingEnabled = true;
            this.comboPremade.Items.AddRange(new object[] {
            "Axe Mage",
            "Bard Mage",
            "Crafter",
            "Fishing Archer",
            "Tamer",
            "Thief",
            "Alchemist Scribe"});
            this.comboPremade.Location = new System.Drawing.Point(9, 14);
            this.comboPremade.Name = "comboPremade";
            this.comboPremade.Size = new System.Drawing.Size(166, 21);
            this.comboPremade.TabIndex = 28;
            this.comboPremade.SelectedIndexChanged += new System.EventHandler(this.comboPremade_SelectedIndexChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnPremade);
            this.groupBox6.Controls.Add(this.comboPremade);
            this.groupBox6.Location = new System.Drawing.Point(221, 515);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(244, 42);
            this.groupBox6.TabIndex = 29;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Premade Templates";
            // 
            // btnPremade
            // 
            this.btnPremade.Location = new System.Drawing.Point(184, 14);
            this.btnPremade.Name = "btnPremade";
            this.btnPremade.Size = new System.Drawing.Size(48, 21);
            this.btnPremade.TabIndex = 29;
            this.btnPremade.Text = "Load";
            this.btnPremade.UseVisualStyleBackColor = true;
            this.btnPremade.Click += new System.EventHandler(this.btnPremade_Click);
            // 
            // Skill_Name
            // 
            this.Skill_Name.HeaderText = "Skill Name";
            this.Skill_Name.Name = "Skill_Name";
            this.Skill_Name.ReadOnly = true;
            // 
            // Skill_Value
            // 
            this.Skill_Value.HeaderText = "Skill Value";
            this.Skill_Value.Name = "Skill_Value";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1400, 569);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "UOR Build Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbStatStr;
        private System.Windows.Forms.TextBox tbStatDex;
        private System.Windows.Forms.TextBox tbStatInt;
        private System.Windows.Forms.Button btnSkillInfo;
        private System.Windows.Forms.TextBox tbBuildName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnExportBuild;
        private System.Windows.Forms.TextBox tbExportPath;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.WebBrowser webBrowser1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox tbStatTotal;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label lblStrErr;
		private System.Windows.Forms.Label lblIntErr;
		private System.Windows.Forms.Label lblDexErr;
		private System.Windows.Forms.Label lblStatTot;
		private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblMana;
        private System.Windows.Forms.Label lblStam;
        private System.Windows.Forms.Label lblHits;
        private System.Windows.Forms.Label lblBlast;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox cbParablow;
        private System.Windows.Forms.CheckBox cbCrush;
        private System.Windows.Forms.CheckBox cbConcussion;
        private System.Windows.Forms.CheckBox cbDisarm;
        private System.Windows.Forms.CheckBox cbStun;
        private System.Windows.Forms.ComboBox comboPremade;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnPremade;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblHealtime;
        private System.Windows.Forms.Button btnClearBuild;
        private System.Windows.Forms.DataGridViewTextBoxColumn Skill_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Skill_Value;
    }
}

