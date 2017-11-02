namespace Kuramatik
{
    partial class Kuramatik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kuramatik));
            this.mainListbox = new System.Windows.Forms.ListBox();
            this.chooseListbox = new System.Windows.Forms.ListBox();
            this.RightMoveButton = new System.Windows.Forms.Button();
            this.LeftMoveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RandomChooseButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.choseListClearButton = new System.Windows.Forms.Button();
            this.mainListClearButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.chosenListAddButton = new System.Windows.Forms.Button();
            this.mainListAddButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainListbox
            // 
            this.mainListbox.FormattingEnabled = true;
            this.mainListbox.Location = new System.Drawing.Point(13, 286);
            this.mainListbox.Name = "mainListbox";
            this.mainListbox.Size = new System.Drawing.Size(491, 485);
            this.mainListbox.TabIndex = 0;
            // 
            // chooseListbox
            // 
            this.chooseListbox.FormattingEnabled = true;
            this.chooseListbox.Location = new System.Drawing.Point(770, 272);
            this.chooseListbox.Name = "chooseListbox";
            this.chooseListbox.Size = new System.Drawing.Size(482, 498);
            this.chooseListbox.TabIndex = 1;
            // 
            // RightMoveButton
            // 
            this.RightMoveButton.Location = new System.Drawing.Point(509, 438);
            this.RightMoveButton.Name = "RightMoveButton";
            this.RightMoveButton.Size = new System.Drawing.Size(255, 57);
            this.RightMoveButton.TabIndex = 2;
            this.RightMoveButton.Tag = "right";
            this.RightMoveButton.Text = ">>";
            this.RightMoveButton.UseVisualStyleBackColor = true;
            this.RightMoveButton.Click += new System.EventHandler(this.MoveButtons);
            // 
            // LeftMoveButton
            // 
            this.LeftMoveButton.Location = new System.Drawing.Point(509, 501);
            this.LeftMoveButton.Name = "LeftMoveButton";
            this.LeftMoveButton.Size = new System.Drawing.Size(255, 57);
            this.LeftMoveButton.TabIndex = 3;
            this.LeftMoveButton.Tag = "left";
            this.LeftMoveButton.Text = "<<";
            this.LeftMoveButton.UseVisualStyleBackColor = true;
            this.LeftMoveButton.Click += new System.EventHandler(this.MoveButtons);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ana Liste";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(177, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = " Seçilenler";
            // 
            // RandomChooseButton
            // 
            this.RandomChooseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.RandomChooseButton.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RandomChooseButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.RandomChooseButton.Location = new System.Drawing.Point(22, 70);
            this.RandomChooseButton.Name = "RandomChooseButton";
            this.RandomChooseButton.Size = new System.Drawing.Size(427, 58);
            this.RandomChooseButton.TabIndex = 6;
            this.RandomChooseButton.Text = "Kura Çek";
            this.RandomChooseButton.UseVisualStyleBackColor = false;
            this.RandomChooseButton.Click += new System.EventHandler(this.RandomChooseButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ResetButton.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ResetButton.Location = new System.Drawing.Point(293, 134);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(156, 53);
            this.ResetButton.TabIndex = 7;
            this.ResetButton.Tag = "reset";
            this.ResetButton.Text = "Programı Sıfırla";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.DeleteButtons);
            // 
            // choseListClearButton
            // 
            this.choseListClearButton.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choseListClearButton.Location = new System.Drawing.Point(22, 134);
            this.choseListClearButton.Name = "choseListClearButton";
            this.choseListClearButton.Size = new System.Drawing.Size(138, 53);
            this.choseListClearButton.TabIndex = 8;
            this.choseListClearButton.Tag = "choose";
            this.choseListClearButton.Text = "Seçilenler Listesini Temizle";
            this.choseListClearButton.UseVisualStyleBackColor = true;
            this.choseListClearButton.Click += new System.EventHandler(this.DeleteButtons);
            // 
            // mainListClearButton
            // 
            this.mainListClearButton.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainListClearButton.Location = new System.Drawing.Point(166, 134);
            this.mainListClearButton.Name = "mainListClearButton";
            this.mainListClearButton.Size = new System.Drawing.Size(121, 53);
            this.mainListClearButton.TabIndex = 10;
            this.mainListClearButton.Tag = "main";
            this.mainListClearButton.Text = "Ana Listeyi Temizle";
            this.mainListClearButton.UseVisualStyleBackColor = true;
            this.mainListClearButton.Click += new System.EventHandler(this.DeleteButtons);
            // 
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.mainListClearButton);
            this.panel2.Controls.Add(this.ResetButton);
            this.panel2.Controls.Add(this.choseListClearButton);
            this.panel2.Controls.Add(this.RandomChooseButton);
            this.panel2.Location = new System.Drawing.Point(770, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(482, 205);
            this.panel2.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(441, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Info);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(137, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Program İşlemleri";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.chosenListAddButton);
            this.panel3.Controls.Add(this.mainListAddButton);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.valueTextBox);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(16, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(487, 216);
            this.panel3.TabIndex = 13;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(61, 165);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(401, 22);
            this.button3.TabIndex = 22;
            this.button3.Tag = "chooseItem";
            this.button3.Text = "Seçilen Listeden Eleman Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.DeleteButtons);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(61, 134);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(401, 25);
            this.button2.TabIndex = 21;
            this.button2.Tag = "mainItem";
            this.button2.Text = "Ana Listeden Eleman Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.DeleteButtons);
            // 
            // chosenListAddButton
            // 
            this.chosenListAddButton.Location = new System.Drawing.Point(61, 107);
            this.chosenListAddButton.Name = "chosenListAddButton";
            this.chosenListAddButton.Size = new System.Drawing.Size(401, 21);
            this.chosenListAddButton.TabIndex = 20;
            this.chosenListAddButton.Tag = "choose";
            this.chosenListAddButton.Text = "Seçilenler Listesine Ekle";
            this.chosenListAddButton.UseVisualStyleBackColor = true;
            this.chosenListAddButton.Click += new System.EventHandler(this.ListAddButtons);
            // 
            // mainListAddButton
            // 
            this.mainListAddButton.Location = new System.Drawing.Point(61, 78);
            this.mainListAddButton.Name = "mainListAddButton";
            this.mainListAddButton.Size = new System.Drawing.Size(401, 23);
            this.mainListAddButton.TabIndex = 19;
            this.mainListAddButton.Tag = "main";
            this.mainListAddButton.Text = "Ana Listeye Ekle";
            this.mainListAddButton.UseVisualStyleBackColor = true;
            this.mainListAddButton.Click += new System.EventHandler(this.ListAddButtons);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 18);
            this.label6.TabIndex = 18;
            this.label6.Text = "Değer";
            // 
            // valueTextBox
            // 
            this.valueTextBox.Location = new System.Drawing.Point(61, 52);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(401, 20);
            this.valueTextBox.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(155, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Eleman Ekle";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(770, 223);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(482, 46);
            this.panel4.TabIndex = 14;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(12, 234);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(491, 46);
            this.panel5.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(509, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 420);
            this.panel1.TabIndex = 16;
            // 
            // Kuramatik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 773);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.LeftMoveButton);
            this.Controls.Add(this.RightMoveButton);
            this.Controls.Add(this.chooseListbox);
            this.Controls.Add(this.mainListbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Kuramatik";
            this.Text = "Kuramatik";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox mainListbox;
        private System.Windows.Forms.ListBox chooseListbox;
        private System.Windows.Forms.Button RightMoveButton;
        private System.Windows.Forms.Button LeftMoveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RandomChooseButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button choseListClearButton;
        private System.Windows.Forms.Button mainListClearButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button chosenListAddButton;
        private System.Windows.Forms.Button mainListAddButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
    }
}

