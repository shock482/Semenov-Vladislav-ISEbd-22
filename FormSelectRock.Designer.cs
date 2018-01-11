namespace lab2sem1
{
    partial class FormSelectRock
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelRock = new System.Windows.Forms.Label();
            this.panelRock = new System.Windows.Forms.Panel();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.labelBaseColor = new System.Windows.Forms.Label();
            this.pictureBoxRock = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panelGold = new System.Windows.Forms.Panel();
            this.panelGray = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.buttonSetRock = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panelRock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRock)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labelRock);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 106);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип драгоценности";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 41);
            this.label2.TabIndex = 2;
            this.label2.Text = "Алмаз";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelDIamond_MouseDown);
            // 
            // labelRock
            // 
            this.labelRock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelRock.Location = new System.Drawing.Point(6, 16);
            this.labelRock.Name = "labelRock";
            this.labelRock.Size = new System.Drawing.Size(127, 37);
            this.labelRock.TabIndex = 2;
            this.labelRock.Text = "Камень";
            this.labelRock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelRock.Click += new System.EventHandler(this.label1_Click);
            this.labelRock.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelRock_MouseDown);
            // 
            // panelRock
            // 
            this.panelRock.AllowDrop = true;
            this.panelRock.Controls.Add(this.labelDopColor);
            this.panelRock.Controls.Add(this.labelBaseColor);
            this.panelRock.Controls.Add(this.pictureBoxRock);
            this.panelRock.Location = new System.Drawing.Point(255, 12);
            this.panelRock.Name = "panelRock";
            this.panelRock.Size = new System.Drawing.Size(157, 141);
            this.panelRock.TabIndex = 2;
            this.panelRock.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelRock_DragDrop);
            this.panelRock.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelRock_DragEnter);
            this.panelRock.Paint += new System.Windows.Forms.PaintEventHandler(this.panelRock_Paint);
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(8, 83);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(70, 58);
            this.labelDopColor.TabIndex = 4;
            this.labelDopColor.Text = "Доп. цвет";
            this.labelDopColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // labelBaseColor
            // 
            this.labelBaseColor.AllowDrop = true;
            this.labelBaseColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBaseColor.Location = new System.Drawing.Point(84, 83);
            this.labelBaseColor.Name = "labelBaseColor";
            this.labelBaseColor.Size = new System.Drawing.Size(70, 58);
            this.labelBaseColor.TabIndex = 3;
            this.labelBaseColor.Text = "Основной цвет";
            this.labelBaseColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBaseColor.Click += new System.EventHandler(this.labelBaseColor_Click);
            this.labelBaseColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
            this.labelBaseColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // pictureBoxRock
            // 
            this.pictureBoxRock.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxRock.Name = "pictureBoxRock";
            this.pictureBoxRock.Size = new System.Drawing.Size(151, 77);
            this.pictureBoxRock.TabIndex = 0;
            this.pictureBoxRock.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panelGold);
            this.groupBox2.Controls.Add(this.panelGray);
            this.groupBox2.Controls.Add(this.panelYellow);
            this.groupBox2.Controls.Add(this.panelRed);
            this.groupBox2.Controls.Add(this.panelBlue);
            this.groupBox2.Controls.Add(this.panelGreen);
            this.groupBox2.Controls.Add(this.panelWhite);
            this.groupBox2.Controls.Add(this.panelBlack);
            this.groupBox2.Location = new System.Drawing.Point(193, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 121);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Цвета";
            // 
            // panelGold
            // 
            this.panelGold.BackColor = System.Drawing.Color.Gold;
            this.panelGold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGold.Location = new System.Drawing.Point(176, 63);
            this.panelGold.Name = "panelGold";
            this.panelGold.Size = new System.Drawing.Size(37, 38);
            this.panelGold.TabIndex = 7;
            // 
            // panelGray
            // 
            this.panelGray.BackColor = System.Drawing.Color.Gray;
            this.panelGray.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGray.Location = new System.Drawing.Point(110, 63);
            this.panelGray.Name = "panelGray";
            this.panelGray.Size = new System.Drawing.Size(60, 38);
            this.panelGray.TabIndex = 6;
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelYellow.Location = new System.Drawing.Point(49, 63);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(55, 38);
            this.panelYellow.TabIndex = 5;
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRed.Location = new System.Drawing.Point(6, 63);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(37, 38);
            this.panelRed.TabIndex = 4;
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBlue.Location = new System.Drawing.Point(176, 19);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(37, 38);
            this.panelBlue.TabIndex = 3;
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Green;
            this.panelGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGreen.Location = new System.Drawing.Point(110, 19);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(60, 38);
            this.panelGreen.TabIndex = 2;
            // 
            // panelWhite
            // 
            this.panelWhite.BackColor = System.Drawing.Color.White;
            this.panelWhite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWhite.Location = new System.Drawing.Point(49, 19);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(55, 38);
            this.panelWhite.TabIndex = 1;
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBlack.Location = new System.Drawing.Point(6, 19);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(37, 38);
            this.panelBlack.TabIndex = 0;
            // 
            // buttonSetRock
            // 
            this.buttonSetRock.Location = new System.Drawing.Point(18, 229);
            this.buttonSetRock.Name = "buttonSetRock";
            this.buttonSetRock.Size = new System.Drawing.Size(75, 23);
            this.buttonSetRock.TabIndex = 4;
            this.buttonSetRock.Text = " Добавить";
            this.buttonSetRock.UseVisualStyleBackColor = true;
            this.buttonSetRock.Click += new System.EventHandler(this.buttonSetRock_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(18, 264);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormSelectRock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 299);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSetRock);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panelRock);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormSelectRock";
            this.Text = "Выбор драгоценности";
            this.groupBox1.ResumeLayout(false);
            this.panelRock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRock)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelRock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelRock;
        private System.Windows.Forms.PictureBox pictureBoxRock;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Label labelBaseColor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panelGold;
        private System.Windows.Forms.Panel panelGray;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Button buttonSetRock;
        private System.Windows.Forms.Button buttonCancel;
    }
}