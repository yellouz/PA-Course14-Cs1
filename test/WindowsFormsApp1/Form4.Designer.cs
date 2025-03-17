namespace WindowsFormsApp1
{
    partial class Form4
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbtnTile = new System.Windows.Forms.RadioButton();
            this.rdbtnList = new System.Windows.Forms.RadioButton();
            this.rdbtnLargeIcons = new System.Windows.Forms.RadioButton();
            this.rdbtnSmallIcons = new System.Windows.Forms.RadioButton();
            this.rdbtnDetails = new System.Windows.Forms.RadioButton();
            this.btnFillRandom = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbtnFemale = new System.Windows.Forms.RadioButton();
            this.rdbtnMale = new System.Windows.Forms.RadioButton();
            this.txtID = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbtnTile);
            this.groupBox2.Controls.Add(this.rdbtnList);
            this.groupBox2.Controls.Add(this.rdbtnLargeIcons);
            this.groupBox2.Controls.Add(this.rdbtnSmallIcons);
            this.groupBox2.Controls.Add(this.rdbtnDetails);
            this.groupBox2.Location = new System.Drawing.Point(577, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View";
            // 
            // rdbtnTile
            // 
            this.rdbtnTile.AutoSize = true;
            this.rdbtnTile.Location = new System.Drawing.Point(6, 65);
            this.rdbtnTile.Name = "rdbtnTile";
            this.rdbtnTile.Size = new System.Drawing.Size(42, 17);
            this.rdbtnTile.TabIndex = 4;
            this.rdbtnTile.TabStop = true;
            this.rdbtnTile.Text = "Tile";
            this.rdbtnTile.UseVisualStyleBackColor = true;
            // 
            // rdbtnList
            // 
            this.rdbtnList.AutoSize = true;
            this.rdbtnList.Location = new System.Drawing.Point(109, 42);
            this.rdbtnList.Name = "rdbtnList";
            this.rdbtnList.Size = new System.Drawing.Size(41, 17);
            this.rdbtnList.TabIndex = 3;
            this.rdbtnList.TabStop = true;
            this.rdbtnList.Text = "List";
            this.rdbtnList.UseVisualStyleBackColor = true;
            // 
            // rdbtnLargeIcons
            // 
            this.rdbtnLargeIcons.AutoSize = true;
            this.rdbtnLargeIcons.Location = new System.Drawing.Point(109, 19);
            this.rdbtnLargeIcons.Name = "rdbtnLargeIcons";
            this.rdbtnLargeIcons.Size = new System.Drawing.Size(81, 17);
            this.rdbtnLargeIcons.TabIndex = 2;
            this.rdbtnLargeIcons.TabStop = true;
            this.rdbtnLargeIcons.Text = "Large Icons";
            this.rdbtnLargeIcons.UseVisualStyleBackColor = true;
            // 
            // rdbtnSmallIcons
            // 
            this.rdbtnSmallIcons.AutoSize = true;
            this.rdbtnSmallIcons.Location = new System.Drawing.Point(6, 42);
            this.rdbtnSmallIcons.Name = "rdbtnSmallIcons";
            this.rdbtnSmallIcons.Size = new System.Drawing.Size(79, 17);
            this.rdbtnSmallIcons.TabIndex = 1;
            this.rdbtnSmallIcons.TabStop = true;
            this.rdbtnSmallIcons.Text = "Small Icons";
            this.rdbtnSmallIcons.UseVisualStyleBackColor = true;
            // 
            // rdbtnDetails
            // 
            this.rdbtnDetails.AutoSize = true;
            this.rdbtnDetails.Location = new System.Drawing.Point(6, 19);
            this.rdbtnDetails.Name = "rdbtnDetails";
            this.rdbtnDetails.Size = new System.Drawing.Size(57, 17);
            this.rdbtnDetails.TabIndex = 0;
            this.rdbtnDetails.TabStop = true;
            this.rdbtnDetails.Text = "Details";
            this.rdbtnDetails.UseVisualStyleBackColor = true;
            // 
            // btnFillRandom
            // 
            this.btnFillRandom.Location = new System.Drawing.Point(473, 60);
            this.btnFillRandom.Name = "btnFillRandom";
            this.btnFillRandom.Size = new System.Drawing.Size(75, 23);
            this.btnFillRandom.TabIndex = 19;
            this.btnFillRandom.Text = "Fill Random";
            this.btnFillRandom.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(368, 60);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 18;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(266, 60);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(101, 45);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbtnFemale);
            this.groupBox1.Controls.Add(this.rdbtnMale);
            this.groupBox1.Location = new System.Drawing.Point(72, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 40);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // rdbtnFemale
            // 
            this.rdbtnFemale.AutoSize = true;
            this.rdbtnFemale.Location = new System.Drawing.Point(81, 23);
            this.rdbtnFemale.Name = "rdbtnFemale";
            this.rdbtnFemale.Size = new System.Drawing.Size(59, 17);
            this.rdbtnFemale.TabIndex = 1;
            this.rdbtnFemale.Text = "Female";
            this.rdbtnFemale.UseVisualStyleBackColor = true;
            // 
            // rdbtnMale
            // 
            this.rdbtnMale.AutoSize = true;
            this.rdbtnMale.Location = new System.Drawing.Point(15, 22);
            this.rdbtnMale.Name = "rdbtnMale";
            this.rdbtnMale.Size = new System.Drawing.Size(48, 17);
            this.rdbtnMale.TabIndex = 0;
            this.rdbtnMale.Text = "Male";
            this.rdbtnMale.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(101, 19);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 12;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(24, 159);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(721, 273);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnFillRandom);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.listView1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbtnTile;
        private System.Windows.Forms.RadioButton rdbtnList;
        private System.Windows.Forms.RadioButton rdbtnLargeIcons;
        private System.Windows.Forms.RadioButton rdbtnSmallIcons;
        private System.Windows.Forms.RadioButton rdbtnDetails;
        private System.Windows.Forms.Button btnFillRandom;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbtnFemale;
        private System.Windows.Forms.RadioButton rdbtnMale;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}