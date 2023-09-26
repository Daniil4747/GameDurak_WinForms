namespace GameDurak
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gameStateTb = new System.Windows.Forms.TextBox();
            this.DeckZone = new System.Windows.Forms.GroupBox();
            this.DeckBack = new System.Windows.Forms.PictureBox();
            this.TrumpCard = new System.Windows.Forms.PictureBox();
            this.TrumpImage = new System.Windows.Forms.PictureBox();
            this.IamZone = new System.Windows.Forms.GroupBox();
            this.Gamer1Zone = new System.Windows.Forms.GroupBox();
            this.Gamer2Zone = new System.Windows.Forms.GroupBox();
            this.Gamer3Zone = new System.Windows.Forms.GroupBox();
            this.Gamer4Zone = new System.Windows.Forms.GroupBox();
            this.Gamer5Zone = new System.Windows.Forms.GroupBox();
            this.GameField = new System.Windows.Forms.GroupBox();
            this.takeCardsBtn = new System.Windows.Forms.Button();
            this.endRoundBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.startServer = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.DeckZone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeckBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrumpCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrumpImage)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.groupBox1.Controls.Add(this.gameStateTb);
            this.groupBox1.Controls.Add(this.DeckZone);
            this.groupBox1.Location = new System.Drawing.Point(712, 163);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 342);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // gameStateTb
            // 
            this.gameStateTb.BackColor = System.Drawing.SystemColors.Menu;
            this.gameStateTb.Location = new System.Drawing.Point(7, 23);
            this.gameStateTb.Multiline = true;
            this.gameStateTb.Name = "gameStateTb";
            this.gameStateTb.Size = new System.Drawing.Size(152, 79);
            this.gameStateTb.TabIndex = 9;
            // 
            // DeckZone
            // 
            this.DeckZone.Controls.Add(this.DeckBack);
            this.DeckZone.Controls.Add(this.TrumpCard);
            this.DeckZone.Controls.Add(this.TrumpImage);
            this.DeckZone.Location = new System.Drawing.Point(6, 108);
            this.DeckZone.Name = "DeckZone";
            this.DeckZone.Size = new System.Drawing.Size(153, 146);
            this.DeckZone.TabIndex = 8;
            this.DeckZone.TabStop = false;
            this.DeckZone.Text = "Колода";
            // 
            // DeckBack
            // 
            this.DeckBack.BackColor = System.Drawing.Color.Transparent;
            this.DeckBack.Location = new System.Drawing.Point(56, 29);
            this.DeckBack.Name = "DeckBack";
            this.DeckBack.Size = new System.Drawing.Size(80, 100);
            this.DeckBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DeckBack.TabIndex = 2;
            this.DeckBack.TabStop = false;
            this.DeckBack.Visible = false;
            // 
            // TrumpCard
            // 
            this.TrumpCard.BackColor = System.Drawing.Color.Transparent;
            this.TrumpCard.Location = new System.Drawing.Point(19, 29);
            this.TrumpCard.Name = "TrumpCard";
            this.TrumpCard.Size = new System.Drawing.Size(80, 100);
            this.TrumpCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TrumpCard.TabIndex = 1;
            this.TrumpCard.TabStop = false;
            this.TrumpCard.Visible = false;
            // 
            // TrumpImage
            // 
            this.TrumpImage.Location = new System.Drawing.Point(41, 41);
            this.TrumpImage.Name = "TrumpImage";
            this.TrumpImage.Size = new System.Drawing.Size(73, 66);
            this.TrumpImage.TabIndex = 3;
            this.TrumpImage.TabStop = false;
            // 
            // IamZone
            // 
            this.IamZone.BackColor = System.Drawing.Color.Transparent;
            this.IamZone.Location = new System.Drawing.Point(174, 511);
            this.IamZone.Name = "IamZone";
            this.IamZone.Size = new System.Drawing.Size(527, 128);
            this.IamZone.TabIndex = 1;
            this.IamZone.TabStop = false;
            this.IamZone.Text = "I am";
            // 
            // Gamer1Zone
            // 
            this.Gamer1Zone.BackColor = System.Drawing.Color.Transparent;
            this.Gamer1Zone.Location = new System.Drawing.Point(12, 330);
            this.Gamer1Zone.Name = "Gamer1Zone";
            this.Gamer1Zone.Size = new System.Drawing.Size(156, 309);
            this.Gamer1Zone.TabIndex = 2;
            this.Gamer1Zone.TabStop = false;
            this.Gamer1Zone.Text = "groupBox3";
            // 
            // Gamer2Zone
            // 
            this.Gamer2Zone.BackColor = System.Drawing.Color.Transparent;
            this.Gamer2Zone.Location = new System.Drawing.Point(12, 28);
            this.Gamer2Zone.Name = "Gamer2Zone";
            this.Gamer2Zone.Size = new System.Drawing.Size(156, 296);
            this.Gamer2Zone.TabIndex = 3;
            this.Gamer2Zone.TabStop = false;
            this.Gamer2Zone.Text = "groupBox4";
            // 
            // Gamer3Zone
            // 
            this.Gamer3Zone.BackColor = System.Drawing.Color.Transparent;
            this.Gamer3Zone.Location = new System.Drawing.Point(174, 28);
            this.Gamer3Zone.Name = "Gamer3Zone";
            this.Gamer3Zone.Size = new System.Drawing.Size(527, 128);
            this.Gamer3Zone.TabIndex = 4;
            this.Gamer3Zone.TabStop = false;
            this.Gamer3Zone.Text = "groupBox5";
            // 
            // Gamer4Zone
            // 
            this.Gamer4Zone.BackColor = System.Drawing.Color.Transparent;
            this.Gamer4Zone.Location = new System.Drawing.Point(883, 28);
            this.Gamer4Zone.Name = "Gamer4Zone";
            this.Gamer4Zone.Size = new System.Drawing.Size(156, 296);
            this.Gamer4Zone.TabIndex = 6;
            this.Gamer4Zone.TabStop = false;
            this.Gamer4Zone.Text = "groupBox7";
            // 
            // Gamer5Zone
            // 
            this.Gamer5Zone.BackColor = System.Drawing.Color.Transparent;
            this.Gamer5Zone.Location = new System.Drawing.Point(883, 330);
            this.Gamer5Zone.Name = "Gamer5Zone";
            this.Gamer5Zone.Size = new System.Drawing.Size(156, 309);
            this.Gamer5Zone.TabIndex = 4;
            this.Gamer5Zone.TabStop = false;
            this.Gamer5Zone.Text = "groupBox8";
            // 
            // GameField
            // 
            this.GameField.Location = new System.Drawing.Point(174, 163);
            this.GameField.Name = "GameField";
            this.GameField.Size = new System.Drawing.Size(527, 342);
            this.GameField.TabIndex = 7;
            this.GameField.TabStop = false;
            this.GameField.Text = "Стол";
            // 
            // takeCardsBtn
            // 
            this.takeCardsBtn.Location = new System.Drawing.Point(748, 544);
            this.takeCardsBtn.Name = "takeCardsBtn";
            this.takeCardsBtn.Size = new System.Drawing.Size(95, 35);
            this.takeCardsBtn.TabIndex = 8;
            this.takeCardsBtn.Text = "Беру";
            this.takeCardsBtn.UseVisualStyleBackColor = true;
            this.takeCardsBtn.Click += new System.EventHandler(this.takeCardsBtn_Click);
            // 
            // endRoundBtn
            // 
            this.endRoundBtn.Location = new System.Drawing.Point(748, 597);
            this.endRoundBtn.Name = "endRoundBtn";
            this.endRoundBtn.Size = new System.Drawing.Size(95, 33);
            this.endRoundBtn.TabIndex = 9;
            this.endRoundBtn.Text = "Отбой";
            this.endRoundBtn.UseVisualStyleBackColor = true;
            this.endRoundBtn.Click += new System.EventHandler(this.endRoundBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1049, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(46, 20);
            this.toolStripMenuItem1.Text = "Игра";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.newGameToolStripMenuItem.Text = "Новая игра";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startServer,
            this.connectToServerToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(59, 20);
            this.toolStripMenuItem2.Text = "Сервер";
            // 
            // startServer
            // 
            this.startServer.Name = "startServer";
            this.startServer.Size = new System.Drawing.Size(170, 22);
            this.startServer.Text = "Запустить сервер";
            this.startServer.Click += new System.EventHandler(this.startServer_Click);
            // 
            // connectToServerToolStripMenuItem
            // 
            this.connectToServerToolStripMenuItem.Name = "connectToServerToolStripMenuItem";
            this.connectToServerToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.connectToServerToolStripMenuItem.Text = "Присоединиться";
            this.connectToServerToolStripMenuItem.Click += new System.EventHandler(this.connectToServerToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(1049, 649);
            this.Controls.Add(this.endRoundBtn);
            this.Controls.Add(this.takeCardsBtn);
            this.Controls.Add(this.GameField);
            this.Controls.Add(this.Gamer5Zone);
            this.Controls.Add(this.Gamer4Zone);
            this.Controls.Add(this.Gamer3Zone);
            this.Controls.Add(this.Gamer2Zone);
            this.Controls.Add(this.Gamer1Zone);
            this.Controls.Add(this.IamZone);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.White;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.DeckZone.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DeckBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrumpCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrumpImage)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox DeckBack;
        private System.Windows.Forms.PictureBox TrumpCard;
        private System.Windows.Forms.GroupBox IamZone;
        private System.Windows.Forms.GroupBox Gamer1Zone;
        private System.Windows.Forms.GroupBox Gamer2Zone;
        private System.Windows.Forms.GroupBox Gamer3Zone;
        private System.Windows.Forms.GroupBox Gamer4Zone;
        private System.Windows.Forms.GroupBox Gamer5Zone;
        private System.Windows.Forms.GroupBox GameField;
        private System.Windows.Forms.GroupBox DeckZone;
        private System.Windows.Forms.TextBox gameStateTb;
        private System.Windows.Forms.PictureBox TrumpImage;
        private System.Windows.Forms.Button takeCardsBtn;
        private System.Windows.Forms.Button endRoundBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem startServer;
        private System.Windows.Forms.ToolStripMenuItem connectToServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
    }
}

