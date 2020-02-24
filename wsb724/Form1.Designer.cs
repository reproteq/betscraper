namespace wsb724
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.textBoxViewer = new System.Windows.Forms.TextBox();
            this.donate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDate1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDate2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxBets = new System.Windows.Forms.TextBox();
            this.textBoxStakes = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxSaldo = new System.Windows.Forms.TextBox();
            this.textBoxOpens = new System.Windows.Forms.TextBox();
            this.textBoxReturns = new System.Windows.Forms.TextBox();
            this.textBoxProfit = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.checkBoxShowAll = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxWins = new System.Windows.Forms.TextBox();
            this.textBoxLoses = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(781, 16);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(125, 33);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(639, 16);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(125, 33);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "RESET";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(46, 22);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(112, 20);
            this.textBoxUser.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "USER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "PASS";
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(219, 22);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.Size = new System.Drawing.Size(112, 20);
            this.textBoxPass.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "URL";
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Location = new System.Drawing.Point(390, 22);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(162, 20);
            this.textBoxUrl.TabIndex = 7;
            // 
            // textBoxViewer
            // 
            this.textBoxViewer.Location = new System.Drawing.Point(12, 133);
            this.textBoxViewer.Multiline = true;
            this.textBoxViewer.Name = "textBoxViewer";
            this.textBoxViewer.Size = new System.Drawing.Size(894, 294);
            this.textBoxViewer.TabIndex = 8;
            // 
            // donate
            // 
            this.donate.AutoSize = true;
            this.donate.Location = new System.Drawing.Point(410, 443);
            this.donate.Name = "donate";
            this.donate.Size = new System.Drawing.Size(98, 13);
            this.donate.TabIndex = 9;
            this.donate.Text = "Bet History Scraper";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "DAT1";
            // 
            // textBoxDate1
            // 
            this.textBoxDate1.Location = new System.Drawing.Point(46, 60);
            this.textBoxDate1.Name = "textBoxDate1";
            this.textBoxDate1.Size = new System.Drawing.Size(112, 20);
            this.textBoxDate1.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(180, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "DAT2";
            // 
            // textBoxDate2
            // 
            this.textBoxDate2.Location = new System.Drawing.Point(219, 60);
            this.textBoxDate2.Name = "textBoxDate2";
            this.textBoxDate2.Size = new System.Drawing.Size(112, 20);
            this.textBoxDate2.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(826, 443);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Powered by TT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(718, 443);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "WSB724 V.beta1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(233, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "BETS";
            // 
            // textBoxBets
            // 
            this.textBoxBets.Location = new System.Drawing.Point(269, 98);
            this.textBoxBets.Name = "textBoxBets";
            this.textBoxBets.Size = new System.Drawing.Size(58, 20);
            this.textBoxBets.TabIndex = 17;
            // 
            // textBoxStakes
            // 
            this.textBoxStakes.Location = new System.Drawing.Point(592, 98);
            this.textBoxStakes.Name = "textBoxStakes";
            this.textBoxStakes.Size = new System.Drawing.Size(55, 20);
            this.textBoxStakes.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(541, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "STAKES";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "CASH";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(113, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "OPENS";
            // 
            // textBoxSaldo
            // 
            this.textBoxSaldo.Location = new System.Drawing.Point(43, 98);
            this.textBoxSaldo.Name = "textBoxSaldo";
            this.textBoxSaldo.Size = new System.Drawing.Size(58, 20);
            this.textBoxSaldo.TabIndex = 22;
            // 
            // textBoxOpens
            // 
            this.textBoxOpens.Location = new System.Drawing.Point(158, 98);
            this.textBoxOpens.Name = "textBoxOpens";
            this.textBoxOpens.Size = new System.Drawing.Size(58, 20);
            this.textBoxOpens.TabIndex = 23;
            // 
            // textBoxReturns
            // 
            this.textBoxReturns.Location = new System.Drawing.Point(723, 98);
            this.textBoxReturns.Name = "textBoxReturns";
            this.textBoxReturns.Size = new System.Drawing.Size(55, 20);
            this.textBoxReturns.TabIndex = 24;
            // 
            // textBoxProfit
            // 
            this.textBoxProfit.Location = new System.Drawing.Point(846, 98);
            this.textBoxProfit.Name = "textBoxProfit";
            this.textBoxProfit.Size = new System.Drawing.Size(55, 20);
            this.textBoxProfit.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(660, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "RETURNS";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(796, 102);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "PROFIT";
            // 
            // checkBoxShowAll
            // 
            this.checkBoxShowAll.AutoSize = true;
            this.checkBoxShowAll.Location = new System.Drawing.Point(12, 441);
            this.checkBoxShowAll.Name = "checkBoxShowAll";
            this.checkBoxShowAll.Size = new System.Drawing.Size(67, 17);
            this.checkBoxShowAll.TabIndex = 28;
            this.checkBoxShowAll.Text = "Show All";
            this.checkBoxShowAll.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(341, 102);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "WINS";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(432, 102);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "LOSES";
            // 
            // textBoxWins
            // 
            this.textBoxWins.Location = new System.Drawing.Point(378, 98);
            this.textBoxWins.Name = "textBoxWins";
            this.textBoxWins.Size = new System.Drawing.Size(50, 20);
            this.textBoxWins.TabIndex = 31;
            // 
            // textBoxLoses
            // 
            this.textBoxLoses.Location = new System.Drawing.Point(478, 98);
            this.textBoxLoses.Name = "textBoxLoses";
            this.textBoxLoses.Size = new System.Drawing.Size(53, 20);
            this.textBoxLoses.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 470);
            this.Controls.Add(this.textBoxLoses);
            this.Controls.Add(this.textBoxWins);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.checkBoxShowAll);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxProfit);
            this.Controls.Add(this.textBoxReturns);
            this.Controls.Add(this.textBoxOpens);
            this.Controls.Add(this.textBoxSaldo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxStakes);
            this.Controls.Add(this.textBoxBets);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxDate2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxDate1);
            this.Controls.Add(this.donate);
            this.Controls.Add(this.textBoxUrl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.textBoxViewer);
            this.Name = "Form1";
            this.Text = "WSB724";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.TextBox textBoxViewer;
        private System.Windows.Forms.Label donate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDate1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDate2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxBets;
        private System.Windows.Forms.TextBox textBoxStakes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxSaldo;
        private System.Windows.Forms.TextBox textBoxOpens;
        private System.Windows.Forms.TextBox textBoxReturns;
        private System.Windows.Forms.TextBox textBoxProfit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox checkBoxShowAll;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxWins;
        private System.Windows.Forms.TextBox textBoxLoses;
    }
}