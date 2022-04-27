namespace Näyttöpaja
{
    partial class Main
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
            this.etusivuPanel = new System.Windows.Forms.Panel();
            this.loginBtn = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.LoginButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.welcomePanel = new System.Windows.Forms.Panel();
            this.sendPalaute = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.PalauteBox = new System.Windows.Forms.RichTextBox();
            this.WelcomeText = new System.Windows.Forms.Label();
            this.createPanel = new System.Windows.Forms.Panel();
            this.signupLanguageCombo = new System.Windows.Forms.ComboBox();
            this.signupCourseTimes = new System.Windows.Forms.GroupBox();
            this.signupTentti1 = new System.Windows.Forms.RadioButton();
            this.signupTentti3 = new System.Windows.Forms.RadioButton();
            this.signupTentti2 = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.signupCourseSelection = new System.Windows.Forms.CheckedListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.signupDatePicker = new System.Windows.Forms.DateTimePicker();
            this.signupReadyButton = new System.Windows.Forms.Button();
            this.singupBackButton = new System.Windows.Forms.Button();
            this.signupEmailBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.signupRepeatPassBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.signupPasswordBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.signupLastnameBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.signupNameBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.etusivuPanel.SuspendLayout();
            this.loginPanel.SuspendLayout();
            this.welcomePanel.SuspendLayout();
            this.createPanel.SuspendLayout();
            this.signupCourseTimes.SuspendLayout();
            this.SuspendLayout();
            // 
            // etusivuPanel
            // 
            this.etusivuPanel.Controls.Add(this.loginBtn);
            this.etusivuPanel.Controls.Add(this.createButton);
            this.etusivuPanel.Controls.Add(this.label2);
            this.etusivuPanel.Controls.Add(this.label1);
            this.etusivuPanel.Location = new System.Drawing.Point(13, 13);
            this.etusivuPanel.Name = "etusivuPanel";
            this.etusivuPanel.Size = new System.Drawing.Size(655, 433);
            this.etusivuPanel.TabIndex = 0;
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(89, 58);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(90, 23);
            this.loginBtn.TabIndex = 3;
            this.loginBtn.Text = "Kirjaudu sisään";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(8, 58);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 2;
            this.createButton.Text = "Luo tunnus";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(452, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kirjaudu sisään jatkaaksesi jos sinulla ei ole tunnuksia voit luoda ne.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tervetuloa";
            // 
            // loginPanel
            // 
            this.loginPanel.Controls.Add(this.LoginButton);
            this.loginPanel.Controls.Add(this.BackButton);
            this.loginPanel.Controls.Add(this.label5);
            this.loginPanel.Controls.Add(this.PassBox);
            this.loginPanel.Controls.Add(this.label4);
            this.loginPanel.Controls.Add(this.NameBox);
            this.loginPanel.Controls.Add(this.label3);
            this.loginPanel.Location = new System.Drawing.Point(12, 12);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(656, 434);
            this.loginPanel.TabIndex = 1;
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(89, 128);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 6;
            this.LoginButton.Text = "Kirjaudu";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(8, 128);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 5;
            this.BackButton.Text = "Takaisin";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Salasana";
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(8, 102);
            this.PassBox.Name = "PassBox";
            this.PassBox.PasswordChar = '*';
            this.PassBox.Size = new System.Drawing.Size(100, 20);
            this.PassBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nimi";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(8, 55);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(100, 20);
            this.NameBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kirjautuminen";
            // 
            // welcomePanel
            // 
            this.welcomePanel.Controls.Add(this.sendPalaute);
            this.welcomePanel.Controls.Add(this.label14);
            this.welcomePanel.Controls.Add(this.PalauteBox);
            this.welcomePanel.Controls.Add(this.WelcomeText);
            this.welcomePanel.Location = new System.Drawing.Point(13, 13);
            this.welcomePanel.Name = "welcomePanel";
            this.welcomePanel.Size = new System.Drawing.Size(655, 433);
            this.welcomePanel.TabIndex = 2;
            // 
            // sendPalaute
            // 
            this.sendPalaute.Location = new System.Drawing.Point(549, 295);
            this.sendPalaute.Name = "sendPalaute";
            this.sendPalaute.Size = new System.Drawing.Size(103, 23);
            this.sendPalaute.TabIndex = 25;
            this.sendPalaute.Text = "Lähetä palautetta";
            this.sendPalaute.UseVisualStyleBackColor = true;
            this.sendPalaute.Click += new System.EventHandler(this.sendPalaute_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(395, 41);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 18);
            this.label14.TabIndex = 24;
            this.label14.Text = "Palaute";
            // 
            // PalauteBox
            // 
            this.PalauteBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PalauteBox.Location = new System.Drawing.Point(398, 65);
            this.PalauteBox.Name = "PalauteBox";
            this.PalauteBox.Size = new System.Drawing.Size(255, 224);
            this.PalauteBox.TabIndex = 23;
            this.PalauteBox.Text = "";
            // 
            // WelcomeText
            // 
            this.WelcomeText.AutoSize = true;
            this.WelcomeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeText.Location = new System.Drawing.Point(3, 0);
            this.WelcomeText.Name = "WelcomeText";
            this.WelcomeText.Size = new System.Drawing.Size(113, 26);
            this.WelcomeText.TabIndex = 0;
            this.WelcomeText.Text = "Tervetuloa";
            // 
            // createPanel
            // 
            this.createPanel.Controls.Add(this.signupLanguageCombo);
            this.createPanel.Controls.Add(this.signupCourseTimes);
            this.createPanel.Controls.Add(this.label13);
            this.createPanel.Controls.Add(this.signupCourseSelection);
            this.createPanel.Controls.Add(this.label12);
            this.createPanel.Controls.Add(this.signupDatePicker);
            this.createPanel.Controls.Add(this.signupReadyButton);
            this.createPanel.Controls.Add(this.singupBackButton);
            this.createPanel.Controls.Add(this.signupEmailBox);
            this.createPanel.Controls.Add(this.label11);
            this.createPanel.Controls.Add(this.signupRepeatPassBox);
            this.createPanel.Controls.Add(this.label10);
            this.createPanel.Controls.Add(this.signupPasswordBox);
            this.createPanel.Controls.Add(this.label9);
            this.createPanel.Controls.Add(this.signupLastnameBox);
            this.createPanel.Controls.Add(this.label8);
            this.createPanel.Controls.Add(this.signupNameBox);
            this.createPanel.Controls.Add(this.label7);
            this.createPanel.Controls.Add(this.label6);
            this.createPanel.Location = new System.Drawing.Point(12, 12);
            this.createPanel.Name = "createPanel";
            this.createPanel.Size = new System.Drawing.Size(656, 434);
            this.createPanel.TabIndex = 3;
            // 
            // signupLanguageCombo
            // 
            this.signupLanguageCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.signupLanguageCombo.FormattingEnabled = true;
            this.signupLanguageCombo.Items.AddRange(new object[] {
            "JavaScript",
            "C#"});
            this.signupLanguageCombo.Location = new System.Drawing.Point(189, 268);
            this.signupLanguageCombo.Name = "signupLanguageCombo";
            this.signupLanguageCombo.Size = new System.Drawing.Size(200, 21);
            this.signupLanguageCombo.TabIndex = 22;
            // 
            // signupCourseTimes
            // 
            this.signupCourseTimes.Controls.Add(this.signupTentti1);
            this.signupCourseTimes.Controls.Add(this.signupTentti3);
            this.signupCourseTimes.Controls.Add(this.signupTentti2);
            this.signupCourseTimes.Location = new System.Drawing.Point(189, 161);
            this.signupCourseTimes.Name = "signupCourseTimes";
            this.signupCourseTimes.Size = new System.Drawing.Size(200, 100);
            this.signupCourseTimes.TabIndex = 21;
            this.signupCourseTimes.TabStop = false;
            this.signupCourseTimes.Text = "Tenttiajankohdat";
            // 
            // signupTentti1
            // 
            this.signupTentti1.AutoSize = true;
            this.signupTentti1.Checked = true;
            this.signupTentti1.Location = new System.Drawing.Point(6, 19);
            this.signupTentti1.Name = "signupTentti1";
            this.signupTentti1.Size = new System.Drawing.Size(73, 17);
            this.signupTentti1.TabIndex = 18;
            this.signupTentti1.TabStop = true;
            this.signupTentti1.Text = "26.4.2022";
            this.signupTentti1.UseVisualStyleBackColor = true;
            // 
            // signupTentti3
            // 
            this.signupTentti3.AutoSize = true;
            this.signupTentti3.Location = new System.Drawing.Point(6, 59);
            this.signupTentti3.Name = "signupTentti3";
            this.signupTentti3.Size = new System.Drawing.Size(79, 17);
            this.signupTentti3.TabIndex = 20;
            this.signupTentti3.Text = "18.12.2022";
            this.signupTentti3.UseVisualStyleBackColor = true;
            // 
            // signupTentti2
            // 
            this.signupTentti2.AutoSize = true;
            this.signupTentti2.Location = new System.Drawing.Point(6, 38);
            this.signupTentti2.Name = "signupTentti2";
            this.signupTentti2.Size = new System.Drawing.Size(73, 17);
            this.signupTentti2.TabIndex = 19;
            this.signupTentti2.Text = "26.8.2022";
            this.signupTentti2.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(186, 85);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 18);
            this.label13.TabIndex = 16;
            this.label13.Text = "Kurssit";
            // 
            // signupCourseSelection
            // 
            this.signupCourseSelection.CheckOnClick = true;
            this.signupCourseSelection.FormattingEnabled = true;
            this.signupCourseSelection.Items.AddRange(new object[] {
            "Ohjelmiston prototyyppi",
            "Ohjelmiston tuotantoversio",
            "Kehitysympäristön käyttö"});
            this.signupCourseSelection.Location = new System.Drawing.Point(189, 106);
            this.signupCourseSelection.Name = "signupCourseSelection";
            this.signupCourseSelection.Size = new System.Drawing.Size(200, 49);
            this.signupCourseSelection.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(186, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 18);
            this.label12.TabIndex = 14;
            this.label12.Text = "Syntymäaika";
            // 
            // signupDatePicker
            // 
            this.signupDatePicker.Location = new System.Drawing.Point(189, 62);
            this.signupDatePicker.Name = "signupDatePicker";
            this.signupDatePicker.Size = new System.Drawing.Size(200, 20);
            this.signupDatePicker.TabIndex = 13;
            // 
            // signupReadyButton
            // 
            this.signupReadyButton.Location = new System.Drawing.Point(578, 408);
            this.signupReadyButton.Name = "signupReadyButton";
            this.signupReadyButton.Size = new System.Drawing.Size(75, 23);
            this.signupReadyButton.TabIndex = 12;
            this.signupReadyButton.Text = "Luo tunnus";
            this.signupReadyButton.UseVisualStyleBackColor = true;
            this.signupReadyButton.Click += new System.EventHandler(this.signupReadyButton_Click);
            // 
            // singupBackButton
            // 
            this.singupBackButton.Location = new System.Drawing.Point(4, 408);
            this.singupBackButton.Name = "singupBackButton";
            this.singupBackButton.Size = new System.Drawing.Size(75, 23);
            this.singupBackButton.TabIndex = 11;
            this.singupBackButton.Text = "Takaisin";
            this.singupBackButton.UseVisualStyleBackColor = true;
            this.singupBackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // signupEmailBox
            // 
            this.signupEmailBox.Location = new System.Drawing.Point(8, 238);
            this.signupEmailBox.Name = "signupEmailBox";
            this.signupEmailBox.Size = new System.Drawing.Size(167, 20);
            this.signupEmailBox.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 217);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 18);
            this.label11.TabIndex = 9;
            this.label11.Text = "Sähköposti";
            // 
            // signupRepeatPassBox
            // 
            this.signupRepeatPassBox.Location = new System.Drawing.Point(8, 194);
            this.signupRepeatPassBox.Name = "signupRepeatPassBox";
            this.signupRepeatPassBox.PasswordChar = '*';
            this.signupRepeatPassBox.Size = new System.Drawing.Size(100, 20);
            this.signupRepeatPassBox.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 173);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 18);
            this.label10.TabIndex = 7;
            this.label10.Text = "Toista salasana";
            // 
            // signupPasswordBox
            // 
            this.signupPasswordBox.Location = new System.Drawing.Point(8, 150);
            this.signupPasswordBox.Name = "signupPasswordBox";
            this.signupPasswordBox.PasswordChar = '*';
            this.signupPasswordBox.Size = new System.Drawing.Size(100, 20);
            this.signupPasswordBox.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 18);
            this.label9.TabIndex = 5;
            this.label9.Text = "Salasana";
            // 
            // signupLastnameBox
            // 
            this.signupLastnameBox.Location = new System.Drawing.Point(8, 106);
            this.signupLastnameBox.Name = "signupLastnameBox";
            this.signupLastnameBox.Size = new System.Drawing.Size(100, 20);
            this.signupLastnameBox.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 18);
            this.label8.TabIndex = 3;
            this.label8.Text = "Sukunimi";
            // 
            // signupNameBox
            // 
            this.signupNameBox.Location = new System.Drawing.Point(8, 62);
            this.signupNameBox.Name = "signupNameBox";
            this.signupNameBox.Size = new System.Drawing.Size(100, 20);
            this.signupNameBox.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "Etunimi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tunnusten luonti";
            // 
            // Main
            // 
            this.ClientSize = new System.Drawing.Size(680, 458);
            this.Controls.Add(this.createPanel);
            this.Controls.Add(this.welcomePanel);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.etusivuPanel);
            this.Name = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.etusivuPanel.ResumeLayout(false);
            this.etusivuPanel.PerformLayout();
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.welcomePanel.ResumeLayout(false);
            this.welcomePanel.PerformLayout();
            this.createPanel.ResumeLayout(false);
            this.createPanel.PerformLayout();
            this.signupCourseTimes.ResumeLayout(false);
            this.signupCourseTimes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel etusivuPanel;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Panel welcomePanel;
        private System.Windows.Forms.Label WelcomeText;
        private System.Windows.Forms.Panel createPanel;
        private System.Windows.Forms.Button signupReadyButton;
        private System.Windows.Forms.Button singupBackButton;
        private System.Windows.Forms.TextBox signupEmailBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox signupRepeatPassBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox signupPasswordBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox signupLastnameBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox signupNameBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton signupTentti1;
        private System.Windows.Forms.RadioButton signupTentti3;
        private System.Windows.Forms.RadioButton signupTentti2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckedListBox signupCourseSelection;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker signupDatePicker;
        private System.Windows.Forms.ComboBox signupLanguageCombo;
        private System.Windows.Forms.GroupBox signupCourseTimes;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RichTextBox PalauteBox;
        private System.Windows.Forms.Button sendPalaute;
    }
}