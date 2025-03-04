namespace PizzaProject
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
            this.label1 = new System.Windows.Forms.Label();
            this.GBoxSize = new System.Windows.Forms.GroupBox();
            this.rdBtnLarge = new System.Windows.Forms.RadioButton();
            this.rdBtnMedium = new System.Windows.Forms.RadioButton();
            this.rdBtnSmall = new System.Windows.Forms.RadioButton();
            this.GBoxCrustType = new System.Windows.Forms.GroupBox();
            this.rdBtnThinkCrust = new System.Windows.Forms.RadioButton();
            this.rdBtnThinCrust = new System.Windows.Forms.RadioButton();
            this.GBoxToppings = new System.Windows.Forms.GroupBox();
            this.chkBoxGreenPeppers = new System.Windows.Forms.CheckBox();
            this.chkBoxOlives = new System.Windows.Forms.CheckBox();
            this.chkBoxOnion = new System.Windows.Forms.CheckBox();
            this.chkBoxTomatoes = new System.Windows.Forms.CheckBox();
            this.chkBoxMushrooms = new System.Windows.Forms.CheckBox();
            this.chkBoxExtraCheese = new System.Windows.Forms.CheckBox();
            this.GBoxWhereToEat = new System.Windows.Forms.GroupBox();
            this.rdBtnTakeOut = new System.Windows.Forms.RadioButton();
            this.rdBtnEatIn = new System.Windows.Forms.RadioButton();
            this.BtnOrderPizza = new System.Windows.Forms.Button();
            this.BtnResetForm = new System.Windows.Forms.Button();
            this.GBoxOrderSummary = new System.Windows.Forms.GroupBox();
            this.LabelTotalPrice = new System.Windows.Forms.Label();
            this.LabelWhereToEat = new System.Windows.Forms.Label();
            this.LabelCrustType = new System.Windows.Forms.Label();
            this.LabelToppings = new System.Windows.Forms.Label();
            this.LabelSize = new System.Windows.Forms.Label();
            this.GBoxSize.SuspendLayout();
            this.GBoxCrustType.SuspendLayout();
            this.GBoxToppings.SuspendLayout();
            this.GBoxWhereToEat.SuspendLayout();
            this.GBoxOrderSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Andalus", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(249, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make Your Pizza";
            // 
            // GBoxSize
            // 
            this.GBoxSize.Controls.Add(this.rdBtnLarge);
            this.GBoxSize.Controls.Add(this.rdBtnMedium);
            this.GBoxSize.Controls.Add(this.rdBtnSmall);
            this.GBoxSize.Location = new System.Drawing.Point(26, 70);
            this.GBoxSize.Name = "GBoxSize";
            this.GBoxSize.Size = new System.Drawing.Size(200, 100);
            this.GBoxSize.TabIndex = 1;
            this.GBoxSize.TabStop = false;
            this.GBoxSize.Text = "Size";
            // 
            // rdBtnLarge
            // 
            this.rdBtnLarge.AutoSize = true;
            this.rdBtnLarge.Location = new System.Drawing.Point(7, 67);
            this.rdBtnLarge.Name = "rdBtnLarge";
            this.rdBtnLarge.Size = new System.Drawing.Size(52, 17);
            this.rdBtnLarge.TabIndex = 2;
            this.rdBtnLarge.TabStop = true;
            this.rdBtnLarge.Tag = "40";
            this.rdBtnLarge.Text = "Large";
            this.rdBtnLarge.UseVisualStyleBackColor = true;
            this.rdBtnLarge.CheckedChanged += new System.EventHandler(this.rdBtnLarge_CheckedChanged);
            // 
            // rdBtnMedium
            // 
            this.rdBtnMedium.AutoSize = true;
            this.rdBtnMedium.Location = new System.Drawing.Point(7, 43);
            this.rdBtnMedium.Name = "rdBtnMedium";
            this.rdBtnMedium.Size = new System.Drawing.Size(62, 17);
            this.rdBtnMedium.TabIndex = 1;
            this.rdBtnMedium.TabStop = true;
            this.rdBtnMedium.Tag = "30";
            this.rdBtnMedium.Text = "Medium";
            this.rdBtnMedium.UseVisualStyleBackColor = true;
            this.rdBtnMedium.CheckedChanged += new System.EventHandler(this.rdBtnMedium_CheckedChanged);
            // 
            // rdBtnSmall
            // 
            this.rdBtnSmall.AutoSize = true;
            this.rdBtnSmall.Location = new System.Drawing.Point(7, 20);
            this.rdBtnSmall.Name = "rdBtnSmall";
            this.rdBtnSmall.Size = new System.Drawing.Size(50, 17);
            this.rdBtnSmall.TabIndex = 0;
            this.rdBtnSmall.TabStop = true;
            this.rdBtnSmall.Tag = "20";
            this.rdBtnSmall.Text = "Small";
            this.rdBtnSmall.UseVisualStyleBackColor = true;
            this.rdBtnSmall.CheckedChanged += new System.EventHandler(this.rdBtnSmall_CheckedChanged);
            // 
            // GBoxCrustType
            // 
            this.GBoxCrustType.Controls.Add(this.rdBtnThinkCrust);
            this.GBoxCrustType.Controls.Add(this.rdBtnThinCrust);
            this.GBoxCrustType.Location = new System.Drawing.Point(26, 203);
            this.GBoxCrustType.Name = "GBoxCrustType";
            this.GBoxCrustType.Size = new System.Drawing.Size(200, 100);
            this.GBoxCrustType.TabIndex = 2;
            this.GBoxCrustType.TabStop = false;
            this.GBoxCrustType.Text = "Crust Type";
            // 
            // rdBtnThinkCrust
            // 
            this.rdBtnThinkCrust.AutoSize = true;
            this.rdBtnThinkCrust.Location = new System.Drawing.Point(7, 44);
            this.rdBtnThinkCrust.Name = "rdBtnThinkCrust";
            this.rdBtnThinkCrust.Size = new System.Drawing.Size(79, 17);
            this.rdBtnThinkCrust.TabIndex = 1;
            this.rdBtnThinkCrust.TabStop = true;
            this.rdBtnThinkCrust.Tag = "10";
            this.rdBtnThinkCrust.Text = "Think Crust";
            this.rdBtnThinkCrust.UseVisualStyleBackColor = true;
            this.rdBtnThinkCrust.CheckedChanged += new System.EventHandler(this.rdBtnThinkCrust_CheckedChanged);
            // 
            // rdBtnThinCrust
            // 
            this.rdBtnThinCrust.AutoSize = true;
            this.rdBtnThinCrust.Location = new System.Drawing.Point(7, 20);
            this.rdBtnThinCrust.Name = "rdBtnThinCrust";
            this.rdBtnThinCrust.Size = new System.Drawing.Size(73, 17);
            this.rdBtnThinCrust.TabIndex = 0;
            this.rdBtnThinCrust.TabStop = true;
            this.rdBtnThinCrust.Tag = "0";
            this.rdBtnThinCrust.Text = "Thin Crust";
            this.rdBtnThinCrust.UseVisualStyleBackColor = true;
            this.rdBtnThinCrust.CheckedChanged += new System.EventHandler(this.rdBtnThinCrust_CheckedChanged);
            // 
            // GBoxToppings
            // 
            this.GBoxToppings.Controls.Add(this.chkBoxGreenPeppers);
            this.GBoxToppings.Controls.Add(this.chkBoxOlives);
            this.GBoxToppings.Controls.Add(this.chkBoxOnion);
            this.GBoxToppings.Controls.Add(this.chkBoxTomatoes);
            this.GBoxToppings.Controls.Add(this.chkBoxMushrooms);
            this.GBoxToppings.Controls.Add(this.chkBoxExtraCheese);
            this.GBoxToppings.Location = new System.Drawing.Point(245, 70);
            this.GBoxToppings.Name = "GBoxToppings";
            this.GBoxToppings.Size = new System.Drawing.Size(200, 100);
            this.GBoxToppings.TabIndex = 3;
            this.GBoxToppings.TabStop = false;
            this.GBoxToppings.Text = "Toppings";
            // 
            // chkBoxGreenPeppers
            // 
            this.chkBoxGreenPeppers.AutoSize = true;
            this.chkBoxGreenPeppers.Location = new System.Drawing.Point(107, 68);
            this.chkBoxGreenPeppers.Name = "chkBoxGreenPeppers";
            this.chkBoxGreenPeppers.Size = new System.Drawing.Size(97, 17);
            this.chkBoxGreenPeppers.TabIndex = 5;
            this.chkBoxGreenPeppers.Tag = "5";
            this.chkBoxGreenPeppers.Text = "Green Peppers";
            this.chkBoxGreenPeppers.UseVisualStyleBackColor = true;
            this.chkBoxGreenPeppers.CheckedChanged += new System.EventHandler(this.chkBoxGreenPeppers_CheckedChanged);
            // 
            // chkBoxOlives
            // 
            this.chkBoxOlives.AutoSize = true;
            this.chkBoxOlives.Location = new System.Drawing.Point(107, 44);
            this.chkBoxOlives.Name = "chkBoxOlives";
            this.chkBoxOlives.Size = new System.Drawing.Size(55, 17);
            this.chkBoxOlives.TabIndex = 4;
            this.chkBoxOlives.Tag = "5";
            this.chkBoxOlives.Text = "Olives";
            this.chkBoxOlives.UseVisualStyleBackColor = true;
            this.chkBoxOlives.CheckedChanged += new System.EventHandler(this.chkBoxOlives_CheckedChanged);
            // 
            // chkBoxOnion
            // 
            this.chkBoxOnion.AutoSize = true;
            this.chkBoxOnion.Location = new System.Drawing.Point(107, 20);
            this.chkBoxOnion.Name = "chkBoxOnion";
            this.chkBoxOnion.Size = new System.Drawing.Size(54, 17);
            this.chkBoxOnion.TabIndex = 3;
            this.chkBoxOnion.Tag = "5";
            this.chkBoxOnion.Text = "Onion";
            this.chkBoxOnion.UseVisualStyleBackColor = true;
            this.chkBoxOnion.CheckedChanged += new System.EventHandler(this.chkBoxOnion_CheckedChanged);
            // 
            // chkBoxTomatoes
            // 
            this.chkBoxTomatoes.AutoSize = true;
            this.chkBoxTomatoes.Location = new System.Drawing.Point(11, 68);
            this.chkBoxTomatoes.Name = "chkBoxTomatoes";
            this.chkBoxTomatoes.Size = new System.Drawing.Size(73, 17);
            this.chkBoxTomatoes.TabIndex = 2;
            this.chkBoxTomatoes.Tag = "5";
            this.chkBoxTomatoes.Text = "Tomatoes";
            this.chkBoxTomatoes.UseVisualStyleBackColor = true;
            this.chkBoxTomatoes.CheckedChanged += new System.EventHandler(this.chkBoxTomatoes_CheckedChanged);
            // 
            // chkBoxMushrooms
            // 
            this.chkBoxMushrooms.AutoSize = true;
            this.chkBoxMushrooms.Location = new System.Drawing.Point(11, 44);
            this.chkBoxMushrooms.Name = "chkBoxMushrooms";
            this.chkBoxMushrooms.Size = new System.Drawing.Size(80, 17);
            this.chkBoxMushrooms.TabIndex = 1;
            this.chkBoxMushrooms.Tag = "5";
            this.chkBoxMushrooms.Text = "Mushrooms";
            this.chkBoxMushrooms.UseVisualStyleBackColor = true;
            this.chkBoxMushrooms.CheckedChanged += new System.EventHandler(this.chkBoxMushrooms_CheckedChanged);
            // 
            // chkBoxExtraCheese
            // 
            this.chkBoxExtraCheese.AutoSize = true;
            this.chkBoxExtraCheese.Location = new System.Drawing.Point(11, 20);
            this.chkBoxExtraCheese.Name = "chkBoxExtraCheese";
            this.chkBoxExtraCheese.Size = new System.Drawing.Size(89, 17);
            this.chkBoxExtraCheese.TabIndex = 0;
            this.chkBoxExtraCheese.Tag = "5";
            this.chkBoxExtraCheese.Text = "Extra Cheese";
            this.chkBoxExtraCheese.UseVisualStyleBackColor = true;
            this.chkBoxExtraCheese.CheckedChanged += new System.EventHandler(this.chkBoxExtraCheese_CheckedChanged);
            // 
            // GBoxWhereToEat
            // 
            this.GBoxWhereToEat.Controls.Add(this.rdBtnTakeOut);
            this.GBoxWhereToEat.Controls.Add(this.rdBtnEatIn);
            this.GBoxWhereToEat.Location = new System.Drawing.Point(245, 203);
            this.GBoxWhereToEat.Name = "GBoxWhereToEat";
            this.GBoxWhereToEat.Size = new System.Drawing.Size(200, 100);
            this.GBoxWhereToEat.TabIndex = 4;
            this.GBoxWhereToEat.TabStop = false;
            this.GBoxWhereToEat.Text = "Where To Eat";
            // 
            // rdBtnTakeOut
            // 
            this.rdBtnTakeOut.AutoSize = true;
            this.rdBtnTakeOut.Location = new System.Drawing.Point(86, 33);
            this.rdBtnTakeOut.Name = "rdBtnTakeOut";
            this.rdBtnTakeOut.Size = new System.Drawing.Size(68, 17);
            this.rdBtnTakeOut.TabIndex = 1;
            this.rdBtnTakeOut.TabStop = true;
            this.rdBtnTakeOut.Text = "Take out";
            this.rdBtnTakeOut.UseVisualStyleBackColor = true;
            this.rdBtnTakeOut.CheckedChanged += new System.EventHandler(this.rdBtnTakeOut_CheckedChanged);
            // 
            // rdBtnEatIn
            // 
            this.rdBtnEatIn.AutoSize = true;
            this.rdBtnEatIn.Location = new System.Drawing.Point(16, 33);
            this.rdBtnEatIn.Name = "rdBtnEatIn";
            this.rdBtnEatIn.Size = new System.Drawing.Size(53, 17);
            this.rdBtnEatIn.TabIndex = 0;
            this.rdBtnEatIn.TabStop = true;
            this.rdBtnEatIn.Text = "Eat In";
            this.rdBtnEatIn.UseVisualStyleBackColor = true;
            this.rdBtnEatIn.CheckedChanged += new System.EventHandler(this.rdBtnEatIn_CheckedChanged);
            // 
            // BtnOrderPizza
            // 
            this.BtnOrderPizza.Location = new System.Drawing.Point(245, 319);
            this.BtnOrderPizza.Name = "BtnOrderPizza";
            this.BtnOrderPizza.Size = new System.Drawing.Size(75, 23);
            this.BtnOrderPizza.TabIndex = 5;
            this.BtnOrderPizza.Text = "Order Pizza";
            this.BtnOrderPizza.UseVisualStyleBackColor = true;
            this.BtnOrderPizza.Click += new System.EventHandler(this.BtnOrderPizza_Click);
            // 
            // BtnResetForm
            // 
            this.BtnResetForm.Location = new System.Drawing.Point(370, 319);
            this.BtnResetForm.Name = "BtnResetForm";
            this.BtnResetForm.Size = new System.Drawing.Size(75, 23);
            this.BtnResetForm.TabIndex = 6;
            this.BtnResetForm.Text = "Reset Form";
            this.BtnResetForm.UseVisualStyleBackColor = true;
            this.BtnResetForm.Click += new System.EventHandler(this.BtnResetForm_Click);
            // 
            // GBoxOrderSummary
            // 
            this.GBoxOrderSummary.Controls.Add(this.LabelTotalPrice);
            this.GBoxOrderSummary.Controls.Add(this.LabelWhereToEat);
            this.GBoxOrderSummary.Controls.Add(this.LabelCrustType);
            this.GBoxOrderSummary.Controls.Add(this.LabelToppings);
            this.GBoxOrderSummary.Controls.Add(this.LabelSize);
            this.GBoxOrderSummary.Location = new System.Drawing.Point(521, 70);
            this.GBoxOrderSummary.Name = "GBoxOrderSummary";
            this.GBoxOrderSummary.Size = new System.Drawing.Size(200, 233);
            this.GBoxOrderSummary.TabIndex = 7;
            this.GBoxOrderSummary.TabStop = false;
            this.GBoxOrderSummary.Text = "Order Summary";
            // 
            // LabelTotalPrice
            // 
            this.LabelTotalPrice.AutoSize = true;
            this.LabelTotalPrice.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotalPrice.ForeColor = System.Drawing.Color.DarkGreen;
            this.LabelTotalPrice.Location = new System.Drawing.Point(22, 181);
            this.LabelTotalPrice.Name = "LabelTotalPrice";
            this.LabelTotalPrice.Size = new System.Drawing.Size(89, 21);
            this.LabelTotalPrice.TabIndex = 4;
            this.LabelTotalPrice.Text = "Total Price";
            // 
            // LabelWhereToEat
            // 
            this.LabelWhereToEat.AutoSize = true;
            this.LabelWhereToEat.Location = new System.Drawing.Point(22, 144);
            this.LabelWhereToEat.Name = "LabelWhereToEat";
            this.LabelWhereToEat.Size = new System.Drawing.Size(74, 13);
            this.LabelWhereToEat.TabIndex = 3;
            this.LabelWhereToEat.Text = "Where To Eat";
            // 
            // LabelCrustType
            // 
            this.LabelCrustType.AutoSize = true;
            this.LabelCrustType.Location = new System.Drawing.Point(22, 121);
            this.LabelCrustType.Name = "LabelCrustType";
            this.LabelCrustType.Size = new System.Drawing.Size(58, 13);
            this.LabelCrustType.TabIndex = 2;
            this.LabelCrustType.Text = "Crust Type";
            // 
            // LabelToppings
            // 
            this.LabelToppings.AutoSize = true;
            this.LabelToppings.Location = new System.Drawing.Point(22, 67);
            this.LabelToppings.Name = "LabelToppings";
            this.LabelToppings.Size = new System.Drawing.Size(51, 13);
            this.LabelToppings.TabIndex = 1;
            this.LabelToppings.Text = "Toppings";
            this.LabelToppings.Click += new System.EventHandler(this.LabelToppings_Click);
            // 
            // LabelSize
            // 
            this.LabelSize.AutoSize = true;
            this.LabelSize.Location = new System.Drawing.Point(22, 43);
            this.LabelSize.Name = "LabelSize";
            this.LabelSize.Size = new System.Drawing.Size(25, 13);
            this.LabelSize.TabIndex = 0;
            this.LabelSize.Text = "size";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 437);
            this.Controls.Add(this.GBoxOrderSummary);
            this.Controls.Add(this.BtnResetForm);
            this.Controls.Add(this.GBoxWhereToEat);
            this.Controls.Add(this.BtnOrderPizza);
            this.Controls.Add(this.GBoxToppings);
            this.Controls.Add(this.GBoxCrustType);
            this.Controls.Add(this.GBoxSize);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Pizza Order";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GBoxSize.ResumeLayout(false);
            this.GBoxSize.PerformLayout();
            this.GBoxCrustType.ResumeLayout(false);
            this.GBoxCrustType.PerformLayout();
            this.GBoxToppings.ResumeLayout(false);
            this.GBoxToppings.PerformLayout();
            this.GBoxWhereToEat.ResumeLayout(false);
            this.GBoxWhereToEat.PerformLayout();
            this.GBoxOrderSummary.ResumeLayout(false);
            this.GBoxOrderSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GBoxSize;
        private System.Windows.Forms.RadioButton rdBtnLarge;
        private System.Windows.Forms.RadioButton rdBtnMedium;
        private System.Windows.Forms.RadioButton rdBtnSmall;
        private System.Windows.Forms.GroupBox GBoxCrustType;
        private System.Windows.Forms.RadioButton rdBtnThinkCrust;
        private System.Windows.Forms.RadioButton rdBtnThinCrust;
        private System.Windows.Forms.GroupBox GBoxToppings;
        private System.Windows.Forms.CheckBox chkBoxMushrooms;
        private System.Windows.Forms.CheckBox chkBoxExtraCheese;
        private System.Windows.Forms.CheckBox chkBoxGreenPeppers;
        private System.Windows.Forms.CheckBox chkBoxOlives;
        private System.Windows.Forms.CheckBox chkBoxOnion;
        private System.Windows.Forms.CheckBox chkBoxTomatoes;
        private System.Windows.Forms.GroupBox GBoxWhereToEat;
        private System.Windows.Forms.RadioButton rdBtnTakeOut;
        private System.Windows.Forms.RadioButton rdBtnEatIn;
        private System.Windows.Forms.Button BtnOrderPizza;
        private System.Windows.Forms.Button BtnResetForm;
        private System.Windows.Forms.GroupBox GBoxOrderSummary;
        private System.Windows.Forms.Label LabelSize;
        private System.Windows.Forms.Label LabelCrustType;
        private System.Windows.Forms.Label LabelToppings;
        private System.Windows.Forms.Label LabelTotalPrice;
        private System.Windows.Forms.Label LabelWhereToEat;
    }
}

