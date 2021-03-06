﻿namespace Player
{
    partial class InGameView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InGameView));
            this.panel1 = new System.Windows.Forms.Panel();
            this.sidebarBetAmount = new System.Windows.Forms.Label();
            this.submitBetBtn = new System.Windows.Forms.Button();
            this.creditAllBet = new System.Windows.Forms.Button();
            this.credit10Btn = new System.Windows.Forms.Button();
            this.credit5Btn = new System.Windows.Forms.Button();
            this.credit1Btn = new System.Windows.Forms.Button();
            this.standBtn = new System.Windows.Forms.Button();
            this.hitBtn = new System.Windows.Forms.Button();
            this.betStatus = new System.Windows.Forms.Label();
            this.hitStandStatus = new System.Windows.Forms.Label();
            this.gameStatusLabel = new System.Windows.Forms.Label();
            this.gameStatus = new System.Windows.Forms.Label();
            this.cardShoe = new System.Windows.Forms.PictureBox();
            this.cardDeck = new System.Windows.Forms.PictureBox();
            this.pokerChips = new System.Windows.Forms.PictureBox();
            this.dealerCardPanel = new System.Windows.Forms.Panel();
            this.p1CardPanel = new System.Windows.Forms.Panel();
            this.p2CardPanel = new System.Windows.Forms.Panel();
            this.p3CardPanel = new System.Windows.Forms.Panel();
            this.p4CardPanel = new System.Windows.Forms.Panel();
            this.dealerName = new System.Windows.Forms.Label();
            this.p1Name = new System.Windows.Forms.Label();
            this.p1CardValue = new System.Windows.Forms.Label();
            this.p1BetAmount = new System.Windows.Forms.Label();
            this.p1TotalMoney = new System.Windows.Forms.Label();
            this.p2TotalMoney = new System.Windows.Forms.Label();
            this.p2BetAmount = new System.Windows.Forms.Label();
            this.p2CardValue = new System.Windows.Forms.Label();
            this.p2Name = new System.Windows.Forms.Label();
            this.p3TotalMoney = new System.Windows.Forms.Label();
            this.p3BetAmount = new System.Windows.Forms.Label();
            this.p3CardValue = new System.Windows.Forms.Label();
            this.p3Name = new System.Windows.Forms.Label();
            this.p4TotalMoney = new System.Windows.Forms.Label();
            this.p4BetAmount = new System.Windows.Forms.Label();
            this.p4CardValue = new System.Windows.Forms.Label();
            this.p4Name = new System.Windows.Forms.Label();
            this.blackjackText = new System.Windows.Forms.Label();
            this.blackjackRulesText = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dealerCardValue = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardShoe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDeck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokerChips)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.sidebarBetAmount);
            this.panel1.Controls.Add(this.submitBetBtn);
            this.panel1.Controls.Add(this.creditAllBet);
            this.panel1.Controls.Add(this.credit10Btn);
            this.panel1.Controls.Add(this.credit5Btn);
            this.panel1.Controls.Add(this.credit1Btn);
            this.panel1.Controls.Add(this.standBtn);
            this.panel1.Controls.Add(this.hitBtn);
            this.panel1.Controls.Add(this.betStatus);
            this.panel1.Controls.Add(this.hitStandStatus);
            this.panel1.Controls.Add(this.gameStatusLabel);
            this.panel1.Controls.Add(this.gameStatus);
            this.panel1.Location = new System.Drawing.Point(775, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 610);
            this.panel1.TabIndex = 27;
            // 
            // sidebarBetAmount
            // 
            this.sidebarBetAmount.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sidebarBetAmount.ForeColor = System.Drawing.Color.White;
            this.sidebarBetAmount.Location = new System.Drawing.Point(0, 291);
            this.sidebarBetAmount.Name = "sidebarBetAmount";
            this.sidebarBetAmount.Size = new System.Drawing.Size(229, 23);
            this.sidebarBetAmount.TabIndex = 11;
            this.sidebarBetAmount.Text = "$0";
            this.sidebarBetAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // submitBetBtn
            // 
            this.submitBetBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("submitBetBtn.BackgroundImage")));
            this.submitBetBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitBetBtn.FlatAppearance.BorderSize = 0;
            this.submitBetBtn.Location = new System.Drawing.Point(21, 530);
            this.submitBetBtn.Name = "submitBetBtn";
            this.submitBetBtn.Size = new System.Drawing.Size(188, 40);
            this.submitBetBtn.TabIndex = 10;
            this.submitBetBtn.UseVisualStyleBackColor = true;
            this.submitBetBtn.Click += new System.EventHandler(this.submitBetBtn_Click);
            // 
            // creditAllBet
            // 
            this.creditAllBet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("creditAllBet.BackgroundImage")));
            this.creditAllBet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.creditAllBet.FlatAppearance.BorderSize = 0;
            this.creditAllBet.Location = new System.Drawing.Point(21, 480);
            this.creditAllBet.Name = "creditAllBet";
            this.creditAllBet.Size = new System.Drawing.Size(188, 40);
            this.creditAllBet.TabIndex = 9;
            this.creditAllBet.UseVisualStyleBackColor = true;
            this.creditAllBet.Click += new System.EventHandler(this.creditAllBet_Click);
            // 
            // credit10Btn
            // 
            this.credit10Btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("credit10Btn.BackgroundImage")));
            this.credit10Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.credit10Btn.Enabled = false;
            this.credit10Btn.FlatAppearance.BorderSize = 0;
            this.credit10Btn.Location = new System.Drawing.Point(21, 430);
            this.credit10Btn.Name = "credit10Btn";
            this.credit10Btn.Size = new System.Drawing.Size(188, 40);
            this.credit10Btn.TabIndex = 8;
            this.credit10Btn.UseVisualStyleBackColor = true;
            this.credit10Btn.Click += new System.EventHandler(this.credit10Btn_Click);
            // 
            // credit5Btn
            // 
            this.credit5Btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("credit5Btn.BackgroundImage")));
            this.credit5Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.credit5Btn.Enabled = false;
            this.credit5Btn.FlatAppearance.BorderSize = 0;
            this.credit5Btn.Location = new System.Drawing.Point(21, 380);
            this.credit5Btn.Name = "credit5Btn";
            this.credit5Btn.Size = new System.Drawing.Size(188, 40);
            this.credit5Btn.TabIndex = 7;
            this.credit5Btn.UseVisualStyleBackColor = true;
            this.credit5Btn.Click += new System.EventHandler(this.credit5Btn_Click);
            // 
            // credit1Btn
            // 
            this.credit1Btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("credit1Btn.BackgroundImage")));
            this.credit1Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.credit1Btn.Enabled = false;
            this.credit1Btn.FlatAppearance.BorderSize = 0;
            this.credit1Btn.Location = new System.Drawing.Point(21, 330);
            this.credit1Btn.Name = "credit1Btn";
            this.credit1Btn.Size = new System.Drawing.Size(188, 40);
            this.credit1Btn.TabIndex = 6;
            this.credit1Btn.UseVisualStyleBackColor = true;
            this.credit1Btn.Click += new System.EventHandler(this.credit1Btn_Click);
            // 
            // standBtn
            // 
            this.standBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("standBtn.BackgroundImage")));
            this.standBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.standBtn.Enabled = false;
            this.standBtn.FlatAppearance.BorderSize = 0;
            this.standBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.standBtn.Location = new System.Drawing.Point(21, 207);
            this.standBtn.Name = "standBtn";
            this.standBtn.Size = new System.Drawing.Size(188, 40);
            this.standBtn.TabIndex = 5;
            this.standBtn.UseVisualStyleBackColor = true;
            this.standBtn.Click += new System.EventHandler(this.standBtn_Click);
            // 
            // hitBtn
            // 
            this.hitBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hitBtn.BackgroundImage")));
            this.hitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hitBtn.Enabled = false;
            this.hitBtn.FlatAppearance.BorderSize = 0;
            this.hitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hitBtn.Location = new System.Drawing.Point(21, 157);
            this.hitBtn.Name = "hitBtn";
            this.hitBtn.Size = new System.Drawing.Size(188, 40);
            this.hitBtn.TabIndex = 4;
            this.hitBtn.UseVisualStyleBackColor = true;
            this.hitBtn.Click += new System.EventHandler(this.hitBtn_Click);
            // 
            // betStatus
            // 
            this.betStatus.AutoSize = true;
            this.betStatus.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betStatus.ForeColor = System.Drawing.Color.White;
            this.betStatus.Location = new System.Drawing.Point(99, 271);
            this.betStatus.Name = "betStatus";
            this.betStatus.Size = new System.Drawing.Size(32, 16);
            this.betStatus.TabIndex = 3;
            this.betStatus.Text = "Bet";
            // 
            // hitStandStatus
            // 
            this.hitStandStatus.AutoSize = true;
            this.hitStandStatus.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hitStandStatus.ForeColor = System.Drawing.Color.White;
            this.hitStandStatus.Location = new System.Drawing.Point(83, 108);
            this.hitStandStatus.Name = "hitStandStatus";
            this.hitStandStatus.Size = new System.Drawing.Size(71, 16);
            this.hitStandStatus.TabIndex = 2;
            this.hitStandStatus.Text = "Hit/Stand";
            // 
            // gameStatusLabel
            // 
            this.gameStatusLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameStatusLabel.ForeColor = System.Drawing.Color.White;
            this.gameStatusLabel.Location = new System.Drawing.Point(21, 51);
            this.gameStatusLabel.Name = "gameStatusLabel";
            this.gameStatusLabel.Size = new System.Drawing.Size(188, 16);
            this.gameStatusLabel.TabIndex = 1;
            this.gameStatusLabel.Text = "Waiting for bets...";
            this.gameStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameStatus
            // 
            this.gameStatus.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameStatus.ForeColor = System.Drawing.Color.White;
            this.gameStatus.Location = new System.Drawing.Point(21, 28);
            this.gameStatus.Name = "gameStatus";
            this.gameStatus.Size = new System.Drawing.Size(188, 16);
            this.gameStatus.TabIndex = 0;
            this.gameStatus.Text = "Game Status:";
            this.gameStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cardShoe
            // 
            this.cardShoe.Image = ((System.Drawing.Image)(resources.GetObject("cardShoe.Image")));
            this.cardShoe.Location = new System.Drawing.Point(571, 37);
            this.cardShoe.Name = "cardShoe";
            this.cardShoe.Size = new System.Drawing.Size(93, 195);
            this.cardShoe.TabIndex = 28;
            this.cardShoe.TabStop = false;
            this.cardShoe.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cardDeck
            // 
            this.cardDeck.Image = ((System.Drawing.Image)(resources.GetObject("cardDeck.Image")));
            this.cardDeck.Location = new System.Drawing.Point(109, 110);
            this.cardDeck.Name = "cardDeck";
            this.cardDeck.Size = new System.Drawing.Size(76, 122);
            this.cardDeck.TabIndex = 29;
            this.cardDeck.TabStop = false;
            // 
            // pokerChips
            // 
            this.pokerChips.BackColor = System.Drawing.Color.Transparent;
            this.pokerChips.Image = ((System.Drawing.Image)(resources.GetObject("pokerChips.Image")));
            this.pokerChips.Location = new System.Drawing.Point(300, 15);
            this.pokerChips.Name = "pokerChips";
            this.pokerChips.Size = new System.Drawing.Size(158, 66);
            this.pokerChips.TabIndex = 30;
            this.pokerChips.TabStop = false;
            // 
            // dealerCardPanel
            // 
            this.dealerCardPanel.BackColor = System.Drawing.Color.Transparent;
            this.dealerCardPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dealerCardPanel.BackgroundImage")));
            this.dealerCardPanel.Location = new System.Drawing.Point(335, 112);
            this.dealerCardPanel.Name = "dealerCardPanel";
            this.dealerCardPanel.Size = new System.Drawing.Size(86, 120);
            this.dealerCardPanel.TabIndex = 31;
            // 
            // p1CardPanel
            // 
            this.p1CardPanel.BackColor = System.Drawing.Color.Transparent;
            this.p1CardPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p1CardPanel.BackgroundImage")));
            this.p1CardPanel.Location = new System.Drawing.Point(109, 410);
            this.p1CardPanel.Name = "p1CardPanel";
            this.p1CardPanel.Size = new System.Drawing.Size(86, 120);
            this.p1CardPanel.TabIndex = 32;
            // 
            // p2CardPanel
            // 
            this.p2CardPanel.BackColor = System.Drawing.Color.Transparent;
            this.p2CardPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p2CardPanel.BackgroundImage")));
            this.p2CardPanel.Location = new System.Drawing.Point(258, 410);
            this.p2CardPanel.Name = "p2CardPanel";
            this.p2CardPanel.Size = new System.Drawing.Size(86, 120);
            this.p2CardPanel.TabIndex = 33;
            // 
            // p3CardPanel
            // 
            this.p3CardPanel.BackColor = System.Drawing.Color.Transparent;
            this.p3CardPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p3CardPanel.BackgroundImage")));
            this.p3CardPanel.Location = new System.Drawing.Point(416, 410);
            this.p3CardPanel.Name = "p3CardPanel";
            this.p3CardPanel.Size = new System.Drawing.Size(86, 120);
            this.p3CardPanel.TabIndex = 32;
            // 
            // p4CardPanel
            // 
            this.p4CardPanel.BackColor = System.Drawing.Color.Transparent;
            this.p4CardPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p4CardPanel.BackgroundImage")));
            this.p4CardPanel.Location = new System.Drawing.Point(571, 410);
            this.p4CardPanel.Name = "p4CardPanel";
            this.p4CardPanel.Size = new System.Drawing.Size(86, 120);
            this.p4CardPanel.TabIndex = 32;
            // 
            // dealerName
            // 
            this.dealerName.AutoSize = true;
            this.dealerName.BackColor = System.Drawing.Color.Transparent;
            this.dealerName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealerName.ForeColor = System.Drawing.Color.White;
            this.dealerName.Location = new System.Drawing.Point(357, 240);
            this.dealerName.Name = "dealerName";
            this.dealerName.Size = new System.Drawing.Size(44, 15);
            this.dealerName.TabIndex = 34;
            this.dealerName.Text = "Dealer";
            // 
            // p1Name
            // 
            this.p1Name.BackColor = System.Drawing.Color.Transparent;
            this.p1Name.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1Name.ForeColor = System.Drawing.Color.White;
            this.p1Name.Location = new System.Drawing.Point(109, 390);
            this.p1Name.Name = "p1Name";
            this.p1Name.Size = new System.Drawing.Size(86, 15);
            this.p1Name.TabIndex = 35;
            this.p1Name.Text = "Empty";
            this.p1Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p1CardValue
            // 
            this.p1CardValue.BackColor = System.Drawing.Color.Transparent;
            this.p1CardValue.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1CardValue.ForeColor = System.Drawing.Color.Yellow;
            this.p1CardValue.Location = new System.Drawing.Point(109, 365);
            this.p1CardValue.Name = "p1CardValue";
            this.p1CardValue.Size = new System.Drawing.Size(86, 15);
            this.p1CardValue.TabIndex = 36;
            this.p1CardValue.Text = "Count";
            this.p1CardValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p1BetAmount
            // 
            this.p1BetAmount.BackColor = System.Drawing.Color.Transparent;
            this.p1BetAmount.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1BetAmount.ForeColor = System.Drawing.Color.White;
            this.p1BetAmount.Location = new System.Drawing.Point(109, 540);
            this.p1BetAmount.Name = "p1BetAmount";
            this.p1BetAmount.Size = new System.Drawing.Size(86, 15);
            this.p1BetAmount.TabIndex = 37;
            this.p1BetAmount.Text = "Bet: $0";
            this.p1BetAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p1TotalMoney
            // 
            this.p1TotalMoney.BackColor = System.Drawing.Color.Transparent;
            this.p1TotalMoney.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1TotalMoney.ForeColor = System.Drawing.Color.White;
            this.p1TotalMoney.Location = new System.Drawing.Point(109, 565);
            this.p1TotalMoney.Name = "p1TotalMoney";
            this.p1TotalMoney.Size = new System.Drawing.Size(86, 15);
            this.p1TotalMoney.TabIndex = 38;
            this.p1TotalMoney.Text = "Total Money";
            this.p1TotalMoney.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p2TotalMoney
            // 
            this.p2TotalMoney.BackColor = System.Drawing.Color.Transparent;
            this.p2TotalMoney.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2TotalMoney.ForeColor = System.Drawing.Color.White;
            this.p2TotalMoney.Location = new System.Drawing.Point(258, 565);
            this.p2TotalMoney.Name = "p2TotalMoney";
            this.p2TotalMoney.Size = new System.Drawing.Size(86, 15);
            this.p2TotalMoney.TabIndex = 42;
            this.p2TotalMoney.Text = "Total Money";
            this.p2TotalMoney.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p2BetAmount
            // 
            this.p2BetAmount.BackColor = System.Drawing.Color.Transparent;
            this.p2BetAmount.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2BetAmount.ForeColor = System.Drawing.Color.White;
            this.p2BetAmount.Location = new System.Drawing.Point(258, 540);
            this.p2BetAmount.Name = "p2BetAmount";
            this.p2BetAmount.Size = new System.Drawing.Size(86, 15);
            this.p2BetAmount.TabIndex = 41;
            this.p2BetAmount.Text = "Bet: $0";
            this.p2BetAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p2CardValue
            // 
            this.p2CardValue.BackColor = System.Drawing.Color.Transparent;
            this.p2CardValue.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2CardValue.ForeColor = System.Drawing.Color.Yellow;
            this.p2CardValue.Location = new System.Drawing.Point(258, 365);
            this.p2CardValue.Name = "p2CardValue";
            this.p2CardValue.Size = new System.Drawing.Size(86, 15);
            this.p2CardValue.TabIndex = 40;
            this.p2CardValue.Text = "Count";
            this.p2CardValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p2Name
            // 
            this.p2Name.BackColor = System.Drawing.Color.Transparent;
            this.p2Name.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2Name.ForeColor = System.Drawing.Color.White;
            this.p2Name.Location = new System.Drawing.Point(258, 390);
            this.p2Name.Name = "p2Name";
            this.p2Name.Size = new System.Drawing.Size(86, 15);
            this.p2Name.TabIndex = 39;
            this.p2Name.Text = "Empty";
            this.p2Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p3TotalMoney
            // 
            this.p3TotalMoney.BackColor = System.Drawing.Color.Transparent;
            this.p3TotalMoney.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p3TotalMoney.ForeColor = System.Drawing.Color.White;
            this.p3TotalMoney.Location = new System.Drawing.Point(416, 565);
            this.p3TotalMoney.Name = "p3TotalMoney";
            this.p3TotalMoney.Size = new System.Drawing.Size(86, 15);
            this.p3TotalMoney.TabIndex = 46;
            this.p3TotalMoney.Text = "Total Money";
            this.p3TotalMoney.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p3BetAmount
            // 
            this.p3BetAmount.BackColor = System.Drawing.Color.Transparent;
            this.p3BetAmount.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p3BetAmount.ForeColor = System.Drawing.Color.White;
            this.p3BetAmount.Location = new System.Drawing.Point(416, 540);
            this.p3BetAmount.Name = "p3BetAmount";
            this.p3BetAmount.Size = new System.Drawing.Size(86, 15);
            this.p3BetAmount.TabIndex = 45;
            this.p3BetAmount.Text = "Bet: $0";
            this.p3BetAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p3CardValue
            // 
            this.p3CardValue.BackColor = System.Drawing.Color.Transparent;
            this.p3CardValue.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p3CardValue.ForeColor = System.Drawing.Color.Yellow;
            this.p3CardValue.Location = new System.Drawing.Point(416, 365);
            this.p3CardValue.Name = "p3CardValue";
            this.p3CardValue.Size = new System.Drawing.Size(86, 15);
            this.p3CardValue.TabIndex = 44;
            this.p3CardValue.Text = "Count";
            this.p3CardValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p3Name
            // 
            this.p3Name.BackColor = System.Drawing.Color.Transparent;
            this.p3Name.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p3Name.ForeColor = System.Drawing.Color.White;
            this.p3Name.Location = new System.Drawing.Point(416, 390);
            this.p3Name.Name = "p3Name";
            this.p3Name.Size = new System.Drawing.Size(86, 15);
            this.p3Name.TabIndex = 43;
            this.p3Name.Text = "Empty";
            this.p3Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p4TotalMoney
            // 
            this.p4TotalMoney.BackColor = System.Drawing.Color.Transparent;
            this.p4TotalMoney.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p4TotalMoney.ForeColor = System.Drawing.Color.White;
            this.p4TotalMoney.Location = new System.Drawing.Point(571, 565);
            this.p4TotalMoney.Name = "p4TotalMoney";
            this.p4TotalMoney.Size = new System.Drawing.Size(86, 15);
            this.p4TotalMoney.TabIndex = 50;
            this.p4TotalMoney.Text = "Total Money";
            this.p4TotalMoney.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p4BetAmount
            // 
            this.p4BetAmount.BackColor = System.Drawing.Color.Transparent;
            this.p4BetAmount.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p4BetAmount.ForeColor = System.Drawing.Color.White;
            this.p4BetAmount.Location = new System.Drawing.Point(571, 540);
            this.p4BetAmount.Name = "p4BetAmount";
            this.p4BetAmount.Size = new System.Drawing.Size(86, 15);
            this.p4BetAmount.TabIndex = 49;
            this.p4BetAmount.Text = "Bet: $0";
            this.p4BetAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p4CardValue
            // 
            this.p4CardValue.BackColor = System.Drawing.Color.Transparent;
            this.p4CardValue.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p4CardValue.ForeColor = System.Drawing.Color.Yellow;
            this.p4CardValue.Location = new System.Drawing.Point(571, 365);
            this.p4CardValue.Name = "p4CardValue";
            this.p4CardValue.Size = new System.Drawing.Size(86, 15);
            this.p4CardValue.TabIndex = 48;
            this.p4CardValue.Text = "Count";
            this.p4CardValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p4Name
            // 
            this.p4Name.BackColor = System.Drawing.Color.Transparent;
            this.p4Name.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p4Name.ForeColor = System.Drawing.Color.White;
            this.p4Name.Location = new System.Drawing.Point(571, 390);
            this.p4Name.Name = "p4Name";
            this.p4Name.Size = new System.Drawing.Size(86, 15);
            this.p4Name.TabIndex = 47;
            this.p4Name.Text = "Empty";
            this.p4Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // blackjackText
            // 
            this.blackjackText.AutoSize = true;
            this.blackjackText.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blackjackText.ForeColor = System.Drawing.Color.Yellow;
            this.blackjackText.Location = new System.Drawing.Point(259, 283);
            this.blackjackText.Name = "blackjackText";
            this.blackjackText.Size = new System.Drawing.Size(248, 22);
            this.blackjackText.TabIndex = 51;
            this.blackjackText.Text = "BLACKJACK PAYS 2 TO 1";
            // 
            // blackjackRulesText
            // 
            this.blackjackRulesText.AutoSize = true;
            this.blackjackRulesText.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blackjackRulesText.ForeColor = System.Drawing.Color.White;
            this.blackjackRulesText.Location = new System.Drawing.Point(152, 316);
            this.blackjackRulesText.Name = "blackjackRulesText";
            this.blackjackRulesText.Size = new System.Drawing.Size(478, 16);
            this.blackjackRulesText.TabIndex = 52;
            this.blackjackRulesText.Text = "DEALER MUST DRAW ON 16 AND BELOW  -  STAND ON 17 AND ABOVE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(580, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(580, 112);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 105);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 54;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "2-clubs.png");
            this.imageList1.Images.SetKeyName(1, "3-clubs.png");
            this.imageList1.Images.SetKeyName(2, "4-clubs.png");
            this.imageList1.Images.SetKeyName(3, "5-clubs.png");
            this.imageList1.Images.SetKeyName(4, "6-clubs.png");
            this.imageList1.Images.SetKeyName(5, "7-clubs.png");
            this.imageList1.Images.SetKeyName(6, "8-clubs.png");
            this.imageList1.Images.SetKeyName(7, "9-clubs.png");
            this.imageList1.Images.SetKeyName(8, "10-clubs.png");
            this.imageList1.Images.SetKeyName(9, "j-clubs.png");
            this.imageList1.Images.SetKeyName(10, "q-clubs.png");
            this.imageList1.Images.SetKeyName(11, "k-clubs.png");
            this.imageList1.Images.SetKeyName(12, "a-clubs.png");
            this.imageList1.Images.SetKeyName(13, "2-diamonds.png");
            this.imageList1.Images.SetKeyName(14, "3-diamonds.png");
            this.imageList1.Images.SetKeyName(15, "4-diamonds.png");
            this.imageList1.Images.SetKeyName(16, "5-diamonds.png");
            this.imageList1.Images.SetKeyName(17, "6-diamonds.png");
            this.imageList1.Images.SetKeyName(18, "7-diamonds.png");
            this.imageList1.Images.SetKeyName(19, "8-diamonds.png");
            this.imageList1.Images.SetKeyName(20, "9-diamonds.png");
            this.imageList1.Images.SetKeyName(21, "10-diamonds.png");
            this.imageList1.Images.SetKeyName(22, "j-diamonds.png");
            this.imageList1.Images.SetKeyName(23, "q-diamonds.png");
            this.imageList1.Images.SetKeyName(24, "k-diamonds.png");
            this.imageList1.Images.SetKeyName(25, "a-diamonds.png");
            this.imageList1.Images.SetKeyName(26, "2-hearts.png");
            this.imageList1.Images.SetKeyName(27, "3-hearts.png");
            this.imageList1.Images.SetKeyName(28, "4-hearts.png");
            this.imageList1.Images.SetKeyName(29, "5-hearts.png");
            this.imageList1.Images.SetKeyName(30, "6-hearts.png");
            this.imageList1.Images.SetKeyName(31, "7-hearts.png");
            this.imageList1.Images.SetKeyName(32, "8-hearts.png");
            this.imageList1.Images.SetKeyName(33, "9-hearts.png");
            this.imageList1.Images.SetKeyName(34, "10-hearts.png");
            this.imageList1.Images.SetKeyName(35, "j-hearts.png");
            this.imageList1.Images.SetKeyName(36, "q-hearts.png");
            this.imageList1.Images.SetKeyName(37, "k-hearts.png");
            this.imageList1.Images.SetKeyName(38, "a-hearts.png");
            this.imageList1.Images.SetKeyName(39, "2-spades.png");
            this.imageList1.Images.SetKeyName(40, "3-spades.png");
            this.imageList1.Images.SetKeyName(41, "4-spades.png");
            this.imageList1.Images.SetKeyName(42, "5-spades.png");
            this.imageList1.Images.SetKeyName(43, "6-spades.png");
            this.imageList1.Images.SetKeyName(44, "7-spades.png");
            this.imageList1.Images.SetKeyName(45, "8-spades.png");
            this.imageList1.Images.SetKeyName(46, "9-spades.png");
            this.imageList1.Images.SetKeyName(47, "10-spades.png");
            this.imageList1.Images.SetKeyName(48, "j-spades.png");
            this.imageList1.Images.SetKeyName(49, "q-spades.png");
            this.imageList1.Images.SetKeyName(50, "k-spades.png");
            this.imageList1.Images.SetKeyName(51, "a-spades.png");
            this.imageList1.Images.SetKeyName(52, "playing-card.png");
            this.imageList1.Images.SetKeyName(53, "playing-card-low-res.png");
            // 
            // dealerCardValue
            // 
            this.dealerCardValue.BackColor = System.Drawing.Color.Transparent;
            this.dealerCardValue.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealerCardValue.ForeColor = System.Drawing.Color.Yellow;
            this.dealerCardValue.Location = new System.Drawing.Point(335, 94);
            this.dealerCardValue.Name = "dealerCardValue";
            this.dealerCardValue.Size = new System.Drawing.Size(86, 15);
            this.dealerCardValue.TabIndex = 55;
            this.dealerCardValue.Text = "Count";
            this.dealerCardValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InGameView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(162)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(1004, 611);
            this.Controls.Add(this.dealerCardValue);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.blackjackRulesText);
            this.Controls.Add(this.blackjackText);
            this.Controls.Add(this.p4TotalMoney);
            this.Controls.Add(this.p4BetAmount);
            this.Controls.Add(this.p4CardValue);
            this.Controls.Add(this.p4Name);
            this.Controls.Add(this.p3TotalMoney);
            this.Controls.Add(this.p3BetAmount);
            this.Controls.Add(this.p3CardValue);
            this.Controls.Add(this.p3Name);
            this.Controls.Add(this.p2TotalMoney);
            this.Controls.Add(this.p2BetAmount);
            this.Controls.Add(this.p2CardValue);
            this.Controls.Add(this.p2Name);
            this.Controls.Add(this.p1TotalMoney);
            this.Controls.Add(this.p1BetAmount);
            this.Controls.Add(this.p1CardValue);
            this.Controls.Add(this.p1Name);
            this.Controls.Add(this.dealerName);
            this.Controls.Add(this.p4CardPanel);
            this.Controls.Add(this.p3CardPanel);
            this.Controls.Add(this.p2CardPanel);
            this.Controls.Add(this.p1CardPanel);
            this.Controls.Add(this.dealerCardPanel);
            this.Controls.Add(this.pokerChips);
            this.Controls.Add(this.cardDeck);
            this.Controls.Add(this.cardShoe);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "InGameView";
            this.Text = "Blackjack";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InGameView_FormClosing);
            this.Load += new System.EventHandler(this.InGame_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardShoe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDeck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokerChips)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox cardShoe;
        private System.Windows.Forms.PictureBox cardDeck;
        private System.Windows.Forms.PictureBox pokerChips;
        private System.Windows.Forms.Panel dealerCardPanel;
        private System.Windows.Forms.Panel p1CardPanel;
        private System.Windows.Forms.Panel p2CardPanel;
        private System.Windows.Forms.Panel p3CardPanel;
        private System.Windows.Forms.Panel p4CardPanel;
        private System.Windows.Forms.Label betStatus;
        private System.Windows.Forms.Label hitStandStatus;
        private System.Windows.Forms.Label gameStatusLabel;
        private System.Windows.Forms.Label dealerName;
        private System.Windows.Forms.Label p1Name;
        private System.Windows.Forms.Label p1CardValue;
        private System.Windows.Forms.Label p1BetAmount;
        private System.Windows.Forms.Label p1TotalMoney;
        private System.Windows.Forms.Label p2TotalMoney;
        private System.Windows.Forms.Label p2BetAmount;
        private System.Windows.Forms.Label p2CardValue;
        private System.Windows.Forms.Label p2Name;
        private System.Windows.Forms.Label p3TotalMoney;
        private System.Windows.Forms.Label p3BetAmount;
        private System.Windows.Forms.Label p3CardValue;
        private System.Windows.Forms.Label p3Name;
        private System.Windows.Forms.Label p4TotalMoney;
        private System.Windows.Forms.Label p4BetAmount;
        private System.Windows.Forms.Label p4CardValue;
        private System.Windows.Forms.Label p4Name;
        private System.Windows.Forms.Label blackjackText;
        private System.Windows.Forms.Label blackjackRulesText;
        private System.Windows.Forms.Button submitBetBtn;
        private System.Windows.Forms.Button creditAllBet;
        private System.Windows.Forms.Button credit10Btn;
        private System.Windows.Forms.Button credit5Btn;
        private System.Windows.Forms.Button credit1Btn;
        private System.Windows.Forms.Button standBtn;
        private System.Windows.Forms.Button hitBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label sidebarBetAmount;
        private System.Windows.Forms.Label dealerCardValue;
        private System.Windows.Forms.Label gameStatus;
    }
}