﻿namespace OSCVRCWiz
{
    partial class VoiceWizardWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VoiceWizardWindow));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.speechTTSButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TTSButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.hideVRCTextButton = new System.Windows.Forms.Button();
            this.logClearButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxRate = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxPitch = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxVolume = new System.Windows.Forms.ComboBox();
            this.textBoxDelay = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonDelayHere = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxErase = new System.Windows.Forms.TextBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label18 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.buttonActivationWord = new System.Windows.Forms.Button();
            this.textBoxActivationWord = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(477, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(432, 500);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // speechTTSButton
            // 
            this.speechTTSButton.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.speechTTSButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.speechTTSButton.Location = new System.Drawing.Point(28, 45);
            this.speechTTSButton.Name = "speechTTSButton";
            this.speechTTSButton.Size = new System.Drawing.Size(443, 222);
            this.speechTTSButton.TabIndex = 5;
            this.speechTTSButton.Text = "Speech To Text To Speech";
            this.speechTTSButton.UseVisualStyleBackColor = true;
            this.speechTTSButton.Click += new System.EventHandler(this.speechTTSButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(335, 27);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "Read this aloud.";
            // 
            // TTSButton
            // 
            this.TTSButton.Location = new System.Drawing.Point(369, 12);
            this.TTSButton.Name = "TTSButton";
            this.TTSButton.Size = new System.Drawing.Size(102, 27);
            this.TTSButton.TabIndex = 10;
            this.TTSButton.Text = "TTS";
            this.TTSButton.UseVisualStyleBackColor = true;
            this.TTSButton.Click += new System.EventHandler(this.TTSButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Normal",
            "Angry",
            "Happy",
            "Sad"});
            this.comboBox1.Location = new System.Drawing.Point(28, 360);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(187, 28);
            this.comboBox1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Style";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Voice";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Sara",
            "Jenny",
            "Guy",
            "Amber",
            "Ana",
            "Aria",
            "Ashley",
            "Brandon",
            "Christopher",
            "Cora",
            "Elizabeth",
            "Eric",
            "Jacob",
            "Michelle",
            "Monica",
            "Davis",
            "Natasha (AU)",
            "William (AU)",
            "Clara (CA)",
            "Liam (CA)",
            "Sonia (UK)",
            "Ryan (UK)",
            "Abbi (UK)",
            "Bella (UK)",
            "Hollie (UK)",
            "Olivia (UK)",
            "Maisie (UK)",
            "Alfie (UK)",
            "Elliot (UK)",
            "Ethan (UK)",
            "Noah (UK)",
            "Oliver (UK)",
            "Thomas (UK)",
            "Dalia [Spanish] (MX)",
            "Jorge [Spanish] (MX)",
            "Brigitte [French]",
            "Jerome [French]",
            "Amala [German]",
            "Christoph [German]"});
            this.comboBox2.Location = new System.Drawing.Point(28, 306);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(187, 28);
            this.comboBox2.TabIndex = 13;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // hideVRCTextButton
            // 
            this.hideVRCTextButton.Location = new System.Drawing.Point(320, 437);
            this.hideVRCTextButton.Name = "hideVRCTextButton";
            this.hideVRCTextButton.Size = new System.Drawing.Size(114, 57);
            this.hideVRCTextButton.TabIndex = 16;
            this.hideVRCTextButton.Text = "Hide VRC Text Display";
            this.hideVRCTextButton.UseVisualStyleBackColor = true;
            this.hideVRCTextButton.Click += new System.EventHandler(this.hideVRCTextButton_Click);
            // 
            // logClearButton
            // 
            this.logClearButton.Location = new System.Drawing.Point(320, 399);
            this.logClearButton.Name = "logClearButton";
            this.logClearButton.Size = new System.Drawing.Size(114, 32);
            this.logClearButton.TabIndex = 17;
            this.logClearButton.Text = "Log Clear";
            this.logClearButton.UseVisualStyleBackColor = true;
            this.logClearButton.Click += new System.EventHandler(this.logClearButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Rate";
            // 
            // comboBoxRate
            // 
            this.comboBoxRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRate.FormattingEnabled = true;
            this.comboBoxRate.Items.AddRange(new object[] {
            "x-slow",
            "slow",
            "medium",
            "fast",
            "x-fast",
            "default"});
            this.comboBoxRate.Location = new System.Drawing.Point(28, 422);
            this.comboBoxRate.Name = "comboBoxRate";
            this.comboBoxRate.Size = new System.Drawing.Size(187, 28);
            this.comboBoxRate.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(247, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Pitch";
            // 
            // comboBoxPitch
            // 
            this.comboBoxPitch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPitch.FormattingEnabled = true;
            this.comboBoxPitch.Items.AddRange(new object[] {
            "x-low",
            "low",
            "medium",
            "high",
            "x-high",
            "default"});
            this.comboBoxPitch.Location = new System.Drawing.Point(247, 306);
            this.comboBoxPitch.Name = "comboBoxPitch";
            this.comboBoxPitch.Size = new System.Drawing.Size(187, 28);
            this.comboBoxPitch.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(247, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Volume";
            // 
            // comboBoxVolume
            // 
            this.comboBoxVolume.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVolume.FormattingEnabled = true;
            this.comboBoxVolume.Items.AddRange(new object[] {
            "x-soft",
            "medium",
            "loud",
            "x-loud",
            "default"});
            this.comboBoxVolume.Location = new System.Drawing.Point(247, 361);
            this.comboBoxVolume.Name = "comboBoxVolume";
            this.comboBoxVolume.Size = new System.Drawing.Size(187, 28);
            this.comboBoxVolume.TabIndex = 22;
            // 
            // textBoxDelay
            // 
            this.textBoxDelay.Location = new System.Drawing.Point(27, 51);
            this.textBoxDelay.Name = "textBoxDelay";
            this.textBoxDelay.Size = new System.Drawing.Size(125, 27);
            this.textBoxDelay.TabIndex = 24;
            this.textBoxDelay.Text = "250";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(23, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Delay Debug (ms)";
            // 
            // buttonDelayHere
            // 
            this.buttonDelayHere.Location = new System.Drawing.Point(158, 49);
            this.buttonDelayHere.Name = "buttonDelayHere";
            this.buttonDelayHere.Size = new System.Drawing.Size(94, 29);
            this.buttonDelayHere.TabIndex = 26;
            this.buttonDelayHere.Text = "Change";
            this.buttonDelayHere.UseVisualStyleBackColor = true;
            this.buttonDelayHere.Click += new System.EventHandler(this.buttonDelayHere_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(920, 539);
            this.tabControl1.TabIndex = 27;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.CadetBlue;
            this.tabPage1.Controls.Add(this.logClearButton);
            this.tabPage1.Controls.Add(this.speechTTSButton);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.hideVRCTextButton);
            this.tabPage1.Controls.Add(this.TTSButton);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.comboBoxVolume);
            this.tabPage1.Controls.Add(this.comboBox2);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.comboBoxRate);
            this.tabPage1.Controls.Add(this.comboBoxPitch);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(912, 506);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main Menu";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.CadetBlue;
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.textBoxErase);
            this.tabPage2.Controls.Add(this.checkBox6);
            this.tabPage2.Controls.Add(this.checkBox5);
            this.tabPage2.Controls.Add(this.checkBox1);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.checkBox2);
            this.tabPage2.Controls.Add(this.checkBox4);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.buttonActivationWord);
            this.tabPage2.Controls.Add(this.textBoxActivationWord);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.buttonDelayHere);
            this.tabPage2.Controls.Add(this.textBoxDelay);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(912, 506);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 43;
            this.button1.Text = "Change";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonErase_Click);
            // 
            // textBoxErase
            // 
            this.textBoxErase.Location = new System.Drawing.Point(27, 417);
            this.textBoxErase.Name = "textBoxErase";
            this.textBoxErase.Size = new System.Drawing.Size(125, 27);
            this.textBoxErase.TabIndex = 42;
            this.textBoxErase.Text = "5000";
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.checkBox6.Location = new System.Drawing.Point(27, 387);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(209, 24);
            this.checkBox6.TabIndex = 41;
            this.checkBox6.Text = "Erase Text After Delay (ms)";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Checked = true;
            this.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.checkBox5.Location = new System.Drawing.Point(27, 216);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(251, 24);
            this.checkBox5.TabIndex = 40;
            this.checkBox5.Text = "Voice Recognition Profanity Filter";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.Location = new System.Drawing.Point(27, 276);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(291, 24);
            this.checkBox1.TabIndex = 24;
            this.checkBox1.Text = "Send OSC Messages to VRC Avatar Text";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(467, 168);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(128, 20);
            this.label18.TabIndex = 39;
            this.label18.Text = "(restart necessary)";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.checkBox2.Location = new System.Drawing.Point(27, 246);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(190, 24);
            this.checkBox2.TabIndex = 25;
            this.checkBox2.Text = "Output Transcript in Log";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(27, 134);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(208, 24);
            this.checkBox4.TabIndex = 38;
            this.checkBox4.Text = "Enabled (restart necessary)";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(23, 111);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(167, 20);
            this.label17.TabIndex = 36;
            this.label17.Text = "STTTS Activation Phrase";
            // 
            // buttonActivationWord
            // 
            this.buttonActivationWord.Location = new System.Drawing.Point(367, 166);
            this.buttonActivationWord.Name = "buttonActivationWord";
            this.buttonActivationWord.Size = new System.Drawing.Size(94, 29);
            this.buttonActivationWord.TabIndex = 37;
            this.buttonActivationWord.Text = "Change";
            this.buttonActivationWord.UseVisualStyleBackColor = true;
            this.buttonActivationWord.Click += new System.EventHandler(this.buttonActivationWord_Click);
            // 
            // textBoxActivationWord
            // 
            this.textBoxActivationWord.Location = new System.Drawing.Point(27, 166);
            this.textBoxActivationWord.Name = "textBoxActivationWord";
            this.textBoxActivationWord.Size = new System.Drawing.Size(334, 27);
            this.textBoxActivationWord.TabIndex = 35;
            this.textBoxActivationWord.Text = "Quote";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(27, 336);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(125, 27);
            this.textBox4.TabIndex = 33;
            this.textBox4.Text = "Ctrl + G";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(255, 474);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(337, 20);
            this.label13.TabIndex = 30;
            this.label13.Text = "https://github.com/VRCWizard/TTS-Voice-Wizard";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(158, 339);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 20);
            this.label12.TabIndex = 28;
            this.label12.Text = "Unchangeable";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(23, 313);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 20);
            this.label11.TabIndex = 27;
            this.label11.Text = "STTTS Shortcut";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.CadetBlue;
            this.tabPage3.Controls.Add(this.checkBox3);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.button6);
            this.tabPage3.Controls.Add(this.textBox3);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Controls.Add(this.textBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(912, 506);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Provider";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(27, 229);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(219, 24);
            this.checkBox3.TabIndex = 35;
            this.checkBox3.Text = "Remember Key and Region?";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(249, 461);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(271, 20);
            this.label15.TabIndex = 34;
            this.label15.Text = "https://azure.microsoft.com/en-us/free/";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(12, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 25);
            this.label10.TabIndex = 33;
            this.label10.Text = "Microsoft Azure ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 20);
            this.label9.TabIndex = 31;
            this.label9.Text = "Region";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(393, 165);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(94, 29);
            this.button6.TabIndex = 32;
            this.button6.Text = "Change";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(31, 166);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(356, 27);
            this.textBox3.TabIndex = 30;
            this.textBox3.Text = "eastus";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "Key";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(393, 97);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 29);
            this.button5.TabIndex = 29;
            this.button5.Text = "Change";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(31, 97);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(356, 27);
            this.textBox2.TabIndex = 27;
            // 
            // VoiceWizardWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(949, 563);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "VoiceWizardWindow";
            this.Text = "TTS Voice Wizard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private RichTextBox richTextBox1;
        private TextBox textBox1;
        private Button TTSButton;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private ComboBox comboBox2;
        private Button hideVRCTextButton;
        private Button logClearButton;
        private Label label4;
        private ComboBox comboBoxRate;
        private Label label5;
        private ComboBox comboBoxPitch;
        private Label label6;
        private ComboBox comboBoxVolume;
        private TextBox textBoxDelay;
        private Label label7;
        private Button buttonDelayHere;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label label8;
        private Button button5;
        private TextBox textBox2;
        private Label label10;
        private Label label9;
        private Button button6;
        private TextBox textBox3;
        private CheckBox checkBox1;
        private Label label11;
        private Label label13;
        private Label label12;
        private TextBox textBox4;
        private Label label15;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private Label label17;
        private Button buttonActivationWord;
        private TextBox textBoxActivationWord;
        private CheckBox checkBox4;
        private Label label18;
        public Button speechTTSButton;
        private CheckBox checkBox5;
        public CheckBox checkBox6;
        private Button button1;
        private TextBox textBoxErase;
    }
}