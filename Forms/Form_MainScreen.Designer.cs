namespace PGS
{
    partial class Form_MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MainScreen));
            this.mainTabsPage = new System.Windows.Forms.TabControl();
            this.gamesPage = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.configPage = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.useDefaultFolderCB = new System.Windows.Forms.CheckBox();
            this.createShortcutCB = new System.Windows.Forms.CheckBox();
            this.defaultFolderPathTB = new System.Windows.Forms.TextBox();
            this.selectDefaultFolderBTN = new System.Windows.Forms.Button();
            this.globalSettingsGB = new System.Windows.Forms.GroupBox();
            this.saveRestoreIconsCB = new System.Windows.Forms.CheckBox();
            this.disableTimerCountCB = new System.Windows.Forms.CheckBox();
            this.immeLunchGameCB = new System.Windows.Forms.CheckBox();
            this.timerCountNUD = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.primaryScreenCB = new System.Windows.Forms.ComboBox();
            this.screenSettingsGB = new System.Windows.Forms.GroupBox();
            this.applyScreenBTN = new System.Windows.Forms.Button();
            this.identifyScreenBTN = new System.Windows.Forms.Button();
            this.preferredScreenCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mainTabsPage.SuspendLayout();
            this.gamesPage.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.configPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.globalSettingsGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timerCountNUD)).BeginInit();
            this.screenSettingsGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabsPage
            // 
            this.mainTabsPage.Controls.Add(this.gamesPage);
            this.mainTabsPage.Controls.Add(this.configPage);
            this.mainTabsPage.Location = new System.Drawing.Point(12, 12);
            this.mainTabsPage.Name = "mainTabsPage";
            this.mainTabsPage.SelectedIndex = 0;
            this.mainTabsPage.Size = new System.Drawing.Size(854, 520);
            this.mainTabsPage.TabIndex = 0;
            // 
            // gamesPage
            // 
            this.gamesPage.Controls.Add(this.groupBox3);
            this.gamesPage.Controls.Add(this.groupBox2);
            this.gamesPage.Location = new System.Drawing.Point(4, 29);
            this.gamesPage.Name = "gamesPage";
            this.gamesPage.Padding = new System.Windows.Forms.Padding(3);
            this.gamesPage.Size = new System.Drawing.Size(846, 487);
            this.gamesPage.TabIndex = 0;
            this.gamesPage.Text = "Games";
            this.gamesPage.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Location = new System.Drawing.Point(15, 319);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(825, 162);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add New Game";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(229, 130);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(423, 26);
            this.textBox4.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(11, 75);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(207, 35);
            this.button4.TabIndex = 5;
            this.button4.Text = "Select Shortcut Folder";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(664, 121);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 30);
            this.button3.TabIndex = 4;
            this.button3.Text = "Add Game";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(247, 75);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(572, 26);
            this.textBox3.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(247, 34);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(572, 26);
            this.textBox2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Game Arguments";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(11, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(207, 34);
            this.button2.TabIndex = 0;
            this.button2.Text = "Select Executable";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(834, 289);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Game List";
            // 
            // configPage
            // 
            this.configPage.Controls.Add(this.groupBox1);
            this.configPage.Controls.Add(this.globalSettingsGB);
            this.configPage.Controls.Add(this.primaryScreenCB);
            this.configPage.Controls.Add(this.screenSettingsGB);
            this.configPage.Location = new System.Drawing.Point(4, 29);
            this.configPage.Name = "configPage";
            this.configPage.Padding = new System.Windows.Forms.Padding(3);
            this.configPage.Size = new System.Drawing.Size(846, 487);
            this.configPage.TabIndex = 1;
            this.configPage.Text = "Config";
            this.configPage.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.useDefaultFolderCB);
            this.groupBox1.Controls.Add(this.createShortcutCB);
            this.groupBox1.Controls.Add(this.defaultFolderPathTB);
            this.groupBox1.Controls.Add(this.selectDefaultFolderBTN);
            this.groupBox1.Location = new System.Drawing.Point(15, 360);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(814, 121);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game Shotcuts";
            // 
            // useDefaultFolderCB
            // 
            this.useDefaultFolderCB.AutoSize = true;
            this.useDefaultFolderCB.Location = new System.Drawing.Point(251, 32);
            this.useDefaultFolderCB.Name = "useDefaultFolderCB";
            this.useDefaultFolderCB.Size = new System.Drawing.Size(169, 24);
            this.useDefaultFolderCB.TabIndex = 3;
            this.useDefaultFolderCB.Text = "Use Default Folder";
            this.useDefaultFolderCB.UseVisualStyleBackColor = true;
            // 
            // createShortcutCB
            // 
            this.createShortcutCB.AutoSize = true;
            this.createShortcutCB.Location = new System.Drawing.Point(30, 32);
            this.createShortcutCB.Name = "createShortcutCB";
            this.createShortcutCB.Size = new System.Drawing.Size(156, 24);
            this.createShortcutCB.TabIndex = 2;
            this.createShortcutCB.Text = "Create Shortcuts";
            this.createShortcutCB.UseVisualStyleBackColor = true;
            // 
            // defaultFolderPathTB
            // 
            this.defaultFolderPathTB.Location = new System.Drawing.Point(30, 81);
            this.defaultFolderPathTB.Name = "defaultFolderPathTB";
            this.defaultFolderPathTB.Size = new System.Drawing.Size(557, 26);
            this.defaultFolderPathTB.TabIndex = 1;
            // 
            // selectDefaultFolderBTN
            // 
            this.selectDefaultFolderBTN.Location = new System.Drawing.Point(612, 73);
            this.selectDefaultFolderBTN.Name = "selectDefaultFolderBTN";
            this.selectDefaultFolderBTN.Size = new System.Drawing.Size(196, 38);
            this.selectDefaultFolderBTN.TabIndex = 0;
            this.selectDefaultFolderBTN.Text = "Select Folder";
            this.selectDefaultFolderBTN.UseVisualStyleBackColor = true;
            // 
            // globalSettingsGB
            // 
            this.globalSettingsGB.Controls.Add(this.saveRestoreIconsCB);
            this.globalSettingsGB.Controls.Add(this.disableTimerCountCB);
            this.globalSettingsGB.Controls.Add(this.immeLunchGameCB);
            this.globalSettingsGB.Controls.Add(this.timerCountNUD);
            this.globalSettingsGB.Controls.Add(this.label2);
            this.globalSettingsGB.Location = new System.Drawing.Point(19, 200);
            this.globalSettingsGB.Name = "globalSettingsGB";
            this.globalSettingsGB.Size = new System.Drawing.Size(810, 123);
            this.globalSettingsGB.TabIndex = 5;
            this.globalSettingsGB.TabStop = false;
            this.globalSettingsGB.Text = "Global Options";
            // 
            // saveRestoreIconsCB
            // 
            this.saveRestoreIconsCB.AutoSize = true;
            this.saveRestoreIconsCB.Location = new System.Drawing.Point(26, 77);
            this.saveRestoreIconsCB.Name = "saveRestoreIconsCB";
            this.saveRestoreIconsCB.Size = new System.Drawing.Size(299, 24);
            this.saveRestoreIconsCB.TabIndex = 7;
            this.saveRestoreIconsCB.Text = "Save/Restore Desktop Icons Position";
            this.saveRestoreIconsCB.UseVisualStyleBackColor = true;
            // 
            // disableTimerCountCB
            // 
            this.disableTimerCountCB.AutoSize = true;
            this.disableTimerCountCB.Location = new System.Drawing.Point(398, 32);
            this.disableTimerCountCB.Name = "disableTimerCountCB";
            this.disableTimerCountCB.Size = new System.Drawing.Size(216, 24);
            this.disableTimerCountCB.TabIndex = 6;
            this.disableTimerCountCB.Text = "Disable Timer Countdown";
            this.disableTimerCountCB.UseVisualStyleBackColor = true;
            // 
            // immeLunchGameCB
            // 
            this.immeLunchGameCB.AutoSize = true;
            this.immeLunchGameCB.Location = new System.Drawing.Point(398, 77);
            this.immeLunchGameCB.Name = "immeLunchGameCB";
            this.immeLunchGameCB.Size = new System.Drawing.Size(225, 24);
            this.immeLunchGameCB.TabIndex = 5;
            this.immeLunchGameCB.Text = "Immediately Launch Game";
            this.immeLunchGameCB.UseVisualStyleBackColor = true;
            // 
            // timerCountNUD
            // 
            this.timerCountNUD.Location = new System.Drawing.Point(195, 34);
            this.timerCountNUD.Name = "timerCountNUD";
            this.timerCountNUD.Size = new System.Drawing.Size(91, 26);
            this.timerCountNUD.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Timer Countdown";
            // 
            // primaryScreenCB
            // 
            this.primaryScreenCB.FormattingEnabled = true;
            this.primaryScreenCB.Location = new System.Drawing.Point(266, 88);
            this.primaryScreenCB.Name = "primaryScreenCB";
            this.primaryScreenCB.Size = new System.Drawing.Size(550, 28);
            this.primaryScreenCB.TabIndex = 4;
            // 
            // screenSettingsGB
            // 
            this.screenSettingsGB.Controls.Add(this.applyScreenBTN);
            this.screenSettingsGB.Controls.Add(this.identifyScreenBTN);
            this.screenSettingsGB.Controls.Add(this.preferredScreenCB);
            this.screenSettingsGB.Controls.Add(this.label1);
            this.screenSettingsGB.Controls.Add(this.label3);
            this.screenSettingsGB.Location = new System.Drawing.Point(19, 20);
            this.screenSettingsGB.Name = "screenSettingsGB";
            this.screenSettingsGB.Size = new System.Drawing.Size(810, 174);
            this.screenSettingsGB.TabIndex = 2;
            this.screenSettingsGB.TabStop = false;
            this.screenSettingsGB.Text = "Screen Settings";
            // 
            // applyScreenBTN
            // 
            this.applyScreenBTN.Location = new System.Drawing.Point(625, 115);
            this.applyScreenBTN.Name = "applyScreenBTN";
            this.applyScreenBTN.Size = new System.Drawing.Size(172, 38);
            this.applyScreenBTN.TabIndex = 5;
            this.applyScreenBTN.Text = "Apply Setting";
            this.applyScreenBTN.UseVisualStyleBackColor = true;
            // 
            // identifyScreenBTN
            // 
            this.identifyScreenBTN.Image = global::PGS.Properties.Resources.monitor;
            this.identifyScreenBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.identifyScreenBTN.Location = new System.Drawing.Point(427, 115);
            this.identifyScreenBTN.Name = "identifyScreenBTN";
            this.identifyScreenBTN.Size = new System.Drawing.Size(172, 38);
            this.identifyScreenBTN.TabIndex = 4;
            this.identifyScreenBTN.Text = "Identify Screens";
            this.identifyScreenBTN.UseVisualStyleBackColor = true;
            // 
            // preferredScreenCB
            // 
            this.preferredScreenCB.FormattingEnabled = true;
            this.preferredScreenCB.Location = new System.Drawing.Point(247, 29);
            this.preferredScreenCB.Name = "preferredScreenCB";
            this.preferredScreenCB.Size = new System.Drawing.Size(550, 28);
            this.preferredScreenCB.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Primary Screen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Preferred Gaming Screen";
            // 
            // Form_MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 544);
            this.Controls.Add(this.mainTabsPage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_MainScreen";
            this.Text = "PSG Unchained v1.0";
            this.Load += new System.EventHandler(this.Form_MainScreen_Load);
            this.mainTabsPage.ResumeLayout(false);
            this.gamesPage.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.configPage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.globalSettingsGB.ResumeLayout(false);
            this.globalSettingsGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timerCountNUD)).EndInit();
            this.screenSettingsGB.ResumeLayout(false);
            this.screenSettingsGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabsPage;
        private System.Windows.Forms.TabPage gamesPage;
        private System.Windows.Forms.TabPage configPage;
        private System.Windows.Forms.GroupBox screenSettingsGB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox primaryScreenCB;
        private System.Windows.Forms.ComboBox preferredScreenCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button identifyScreenBTN;
        private System.Windows.Forms.Button applyScreenBTN;
        private System.Windows.Forms.GroupBox globalSettingsGB;
        private System.Windows.Forms.NumericUpDown timerCountNUD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox saveRestoreIconsCB;
        private System.Windows.Forms.CheckBox disableTimerCountCB;
        private System.Windows.Forms.CheckBox immeLunchGameCB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox defaultFolderPathTB;
        private System.Windows.Forms.Button selectDefaultFolderBTN;
        private System.Windows.Forms.CheckBox useDefaultFolderCB;
        private System.Windows.Forms.CheckBox createShortcutCB;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button4;
    }
}