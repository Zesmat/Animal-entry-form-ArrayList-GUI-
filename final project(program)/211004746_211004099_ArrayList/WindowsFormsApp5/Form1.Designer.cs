namespace WindowsFormsApp5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.addButton = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.UpdateListBox = new System.Windows.Forms.ListBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputTextBox1 = new System.Windows.Forms.TextBox();
            this.inputTextBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Make_Sound = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageTimer = new System.Windows.Forms.Timer(this.components);
            this.updateButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.LightBlue;
            this.addButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addButton.FlatAppearance.BorderSize = 500;
            this.addButton.Location = new System.Drawing.Point(253, 184);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(93, 26);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(113, 184);
            this.inputTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(117, 25);
            this.inputTextBox.TabIndex = 1;
            // 
            // searchTextBox
            // 
            this.searchTextBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.searchTextBox.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.searchTextBox.Location = new System.Drawing.Point(39, 365);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(191, 25);
            this.searchTextBox.TabIndex = 2;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.LightPink;
            this.removeButton.Location = new System.Drawing.Point(253, 268);
            this.removeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(93, 26);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "Delete";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // UpdateListBox
            // 
            this.UpdateListBox.Font = new System.Drawing.Font("Felix Titling", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateListBox.FormattingEnabled = true;
            this.UpdateListBox.ItemHeight = 20;
            this.UpdateListBox.Location = new System.Drawing.Point(361, 171);
            this.UpdateListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UpdateListBox.Name = "UpdateListBox";
            this.UpdateListBox.Size = new System.Drawing.Size(185, 124);
            this.UpdateListBox.TabIndex = 4;
            this.UpdateListBox.SelectedIndexChanged += new System.EventHandler(this.UpdateListBox_SelectedIndexChanged);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(253, 365);
            this.searchButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(93, 26);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 18;
            this.listBox.Location = new System.Drawing.Point(46, 396);
            this.listBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(151, 94);
            this.listBox.TabIndex = 6;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Location = new System.Drawing.Point(44, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label2.Location = new System.Drawing.Point(43, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // inputTextBox1
            // 
            this.inputTextBox1.Location = new System.Drawing.Point(113, 224);
            this.inputTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inputTextBox1.Name = "inputTextBox1";
            this.inputTextBox1.Size = new System.Drawing.Size(117, 25);
            this.inputTextBox1.TabIndex = 1;
            // 
            // inputTextBox2
            // 
            this.inputTextBox2.Location = new System.Drawing.Point(113, 264);
            this.inputTextBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inputTextBox2.Name = "inputTextBox2";
            this.inputTextBox2.Size = new System.Drawing.Size(117, 25);
            this.inputTextBox2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label3.Location = new System.Drawing.Point(44, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Age";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // Make_Sound
            // 
            this.Make_Sound.Location = new System.Drawing.Point(33, 14);
            this.Make_Sound.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Make_Sound.Name = "Make_Sound";
            this.Make_Sound.Size = new System.Drawing.Size(47, 31);
            this.Make_Sound.TabIndex = 8;
            this.Make_Sound.Text = "OFF";
            this.Make_Sound.UseVisualStyleBackColor = true;
            this.Make_Sound.Click += new System.EventHandler(this.Make_Sound_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB Demi", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(289, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(400, 50);
            this.label4.TabIndex = 9;
            this.label4.Text = "Animal Form Entry";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(582, 285);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(385, 205);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // imageTimer
            // 
            this.imageTimer.Interval = 1000;
            this.imageTimer.Tick += new System.EventHandler(this.imageTimer_Tick);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.LightBlue;
            this.updateButton.Location = new System.Drawing.Point(253, 227);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(93, 23);
            this.updateButton.TabIndex = 11;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(31, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Enter all data below: ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(931, 562);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Make_Sound);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.UpdateListBox);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.inputTextBox2);
            this.Controls.Add(this.inputTextBox1);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.addButton);
            this.Font = new System.Drawing.Font("Felix Titling", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.ListBox UpdateListBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputTextBox1;
        private System.Windows.Forms.TextBox inputTextBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Make_Sound;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer imageTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label label5;
    }
}

