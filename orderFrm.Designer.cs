namespace pizza_Application
{
    partial class orderFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(orderFrm));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.rbThick = new System.Windows.Forms.RadioButton();
            this.rbThin = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.ckbCheese = new System.Windows.Forms.CheckBox();
            this.ckbOnion = new System.Windows.Forms.CheckBox();
            this.ckbTomato = new System.Windows.Forms.CheckBox();
            this.ckbMush = new System.Windows.Forms.CheckBox();
            this.ckbPepper = new System.Windows.Forms.CheckBox();
            this.ckbOlives = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.rbIn = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.priceTb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Perfecto Calligraphy - Personal", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(409, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(786, 151);
            this.label3.TabIndex = 2;
            this.label3.Text = "Make Your Pizza";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label2.ForeColor = System.Drawing.Color.Bisque;
            this.label2.Location = new System.Drawing.Point(619, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 41);
            this.label2.TabIndex = 3;
            this.label2.Text = "Size";
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.BackColor = System.Drawing.Color.Transparent;
            this.rbSmall.Font = new System.Drawing.Font("Tahoma", 10F);
            this.rbSmall.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.rbSmall.Location = new System.Drawing.Point(16, 8);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(71, 25);
            this.rbSmall.TabIndex = 4;
            this.rbSmall.TabStop = true;
            this.rbSmall.Tag = "5";
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = false;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.size_changed);
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.BackColor = System.Drawing.Color.Transparent;
            this.rbLarge.Font = new System.Drawing.Font("Tahoma", 10F);
            this.rbLarge.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.rbLarge.Location = new System.Drawing.Point(15, 90);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(72, 25);
            this.rbLarge.TabIndex = 7;
            this.rbLarge.TabStop = true;
            this.rbLarge.Tag = "15";
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = false;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.size_changed);
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.BackColor = System.Drawing.Color.Transparent;
            this.rbMedium.Font = new System.Drawing.Font("Tahoma", 10F);
            this.rbMedium.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.rbMedium.Location = new System.Drawing.Point(13, 49);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(89, 25);
            this.rbMedium.TabIndex = 8;
            this.rbMedium.TabStop = true;
            this.rbMedium.Tag = "10";
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = false;
            this.rbMedium.CheckedChanged += new System.EventHandler(this.size_changed);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label4.ForeColor = System.Drawing.Color.Bisque;
            this.label4.Location = new System.Drawing.Point(856, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 41);
            this.label4.TabIndex = 9;
            this.label4.Text = "Crust Type";
            // 
            // rbThick
            // 
            this.rbThick.AutoSize = true;
            this.rbThick.BackColor = System.Drawing.Color.Transparent;
            this.rbThick.Font = new System.Drawing.Font("Tahoma", 10F);
            this.rbThick.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.rbThick.Location = new System.Drawing.Point(24, 63);
            this.rbThick.Name = "rbThick";
            this.rbThick.Size = new System.Drawing.Size(70, 25);
            this.rbThick.TabIndex = 10;
            this.rbThick.TabStop = true;
            this.rbThick.Tag = "4";
            this.rbThick.Text = "Thick";
            this.rbThick.UseVisualStyleBackColor = false;
            this.rbThick.CheckedChanged += new System.EventHandler(this.crust_changed);
            // 
            // rbThin
            // 
            this.rbThin.AutoSize = true;
            this.rbThin.BackColor = System.Drawing.Color.Transparent;
            this.rbThin.Font = new System.Drawing.Font("Tahoma", 10F);
            this.rbThin.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.rbThin.Location = new System.Drawing.Point(24, 23);
            this.rbThin.Name = "rbThin";
            this.rbThin.Size = new System.Drawing.Size(63, 25);
            this.rbThin.TabIndex = 11;
            this.rbThin.TabStop = true;
            this.rbThin.Tag = "2";
            this.rbThin.Text = "Thin";
            this.rbThin.UseVisualStyleBackColor = false;
            this.rbThin.CheckedChanged += new System.EventHandler(this.crust_changed);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label5.ForeColor = System.Drawing.Color.Bisque;
            this.label5.Location = new System.Drawing.Point(480, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 41);
            this.label5.TabIndex = 12;
            this.label5.Text = "Toppings";
            // 
            // ckbCheese
            // 
            this.ckbCheese.AutoSize = true;
            this.ckbCheese.BackColor = System.Drawing.Color.Transparent;
            this.ckbCheese.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ckbCheese.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.ckbCheese.Location = new System.Drawing.Point(22, 24);
            this.ckbCheese.Name = "ckbCheese";
            this.ckbCheese.Size = new System.Drawing.Size(130, 25);
            this.ckbCheese.TabIndex = 13;
            this.ckbCheese.Tag = "5";
            this.ckbCheese.Text = "Extra Cheese";
            this.ckbCheese.UseVisualStyleBackColor = false;
            this.ckbCheese.CheckedChanged += new System.EventHandler(this.topping_changed);
            // 
            // ckbOnion
            // 
            this.ckbOnion.AutoSize = true;
            this.ckbOnion.BackColor = System.Drawing.Color.Transparent;
            this.ckbOnion.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ckbOnion.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.ckbOnion.Location = new System.Drawing.Point(272, 66);
            this.ckbOnion.Name = "ckbOnion";
            this.ckbOnion.Size = new System.Drawing.Size(75, 25);
            this.ckbOnion.TabIndex = 14;
            this.ckbOnion.Tag = "3";
            this.ckbOnion.Text = "Onion";
            this.ckbOnion.UseVisualStyleBackColor = false;
            this.ckbOnion.CheckedChanged += new System.EventHandler(this.topping_changed);
            // 
            // ckbTomato
            // 
            this.ckbTomato.AutoSize = true;
            this.ckbTomato.BackColor = System.Drawing.Color.Transparent;
            this.ckbTomato.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ckbTomato.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.ckbTomato.Location = new System.Drawing.Point(269, 24);
            this.ckbTomato.Name = "ckbTomato";
            this.ckbTomato.Size = new System.Drawing.Size(89, 25);
            this.ckbTomato.TabIndex = 15;
            this.ckbTomato.Tag = "3";
            this.ckbTomato.Text = "Tomato";
            this.ckbTomato.UseVisualStyleBackColor = false;
            this.ckbTomato.CheckedChanged += new System.EventHandler(this.topping_changed);
            // 
            // ckbMush
            // 
            this.ckbMush.AutoSize = true;
            this.ckbMush.BackColor = System.Drawing.Color.Transparent;
            this.ckbMush.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ckbMush.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.ckbMush.Location = new System.Drawing.Point(22, 66);
            this.ckbMush.Name = "ckbMush";
            this.ckbMush.Size = new System.Drawing.Size(109, 25);
            this.ckbMush.TabIndex = 16;
            this.ckbMush.Tag = "5";
            this.ckbMush.Text = "Mushroom";
            this.ckbMush.UseVisualStyleBackColor = false;
            this.ckbMush.CheckedChanged += new System.EventHandler(this.topping_changed);
            // 
            // ckbPepper
            // 
            this.ckbPepper.AutoSize = true;
            this.ckbPepper.BackColor = System.Drawing.Color.Transparent;
            this.ckbPepper.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ckbPepper.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.ckbPepper.Location = new System.Drawing.Point(511, 66);
            this.ckbPepper.Name = "ckbPepper";
            this.ckbPepper.Size = new System.Drawing.Size(91, 25);
            this.ckbPepper.TabIndex = 18;
            this.ckbPepper.Tag = "3";
            this.ckbPepper.Text = "Peppers";
            this.ckbPepper.UseVisualStyleBackColor = false;
            this.ckbPepper.CheckedChanged += new System.EventHandler(this.topping_changed);
            // 
            // ckbOlives
            // 
            this.ckbOlives.AutoSize = true;
            this.ckbOlives.BackColor = System.Drawing.Color.Transparent;
            this.ckbOlives.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ckbOlives.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.ckbOlives.Location = new System.Drawing.Point(511, 24);
            this.ckbOlives.Name = "ckbOlives";
            this.ckbOlives.Size = new System.Drawing.Size(77, 25);
            this.ckbOlives.TabIndex = 19;
            this.ckbOlives.Tag = "3";
            this.ckbOlives.Text = "Olives";
            this.ckbOlives.UseVisualStyleBackColor = false;
            this.ckbOlives.CheckedChanged += new System.EventHandler(this.topping_changed);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label6.ForeColor = System.Drawing.Color.Bisque;
            this.label6.Location = new System.Drawing.Point(480, 534);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 41);
            this.label6.TabIndex = 20;
            this.label6.Text = "Where";
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.BackColor = System.Drawing.Color.Transparent;
            this.radioButton6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.radioButton6.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.radioButton6.Location = new System.Drawing.Point(345, 29);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(96, 25);
            this.radioButton6.TabIndex = 21;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Take out";
            this.radioButton6.UseVisualStyleBackColor = false;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.place_changed);
            // 
            // rbIn
            // 
            this.rbIn.AutoSize = true;
            this.rbIn.BackColor = System.Drawing.Color.Transparent;
            this.rbIn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.rbIn.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.rbIn.Location = new System.Drawing.Point(61, 29);
            this.rbIn.Name = "rbIn";
            this.rbIn.Size = new System.Drawing.Size(74, 25);
            this.rbIn.TabIndex = 22;
            this.rbIn.TabStop = true;
            this.rbIn.Text = "Eat in";
            this.rbIn.UseVisualStyleBackColor = false;
            this.rbIn.CheckedChanged += new System.EventHandler(this.place_changed);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.rbThin);
            this.panel1.Controls.Add(this.rbThick);
            this.panel1.Location = new System.Drawing.Point(838, 231);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 131);
            this.panel1.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.rbSmall);
            this.panel2.Controls.Add(this.rbMedium);
            this.panel2.Controls.Add(this.rbLarge);
            this.panel2.Location = new System.Drawing.Point(595, 232);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(217, 133);
            this.panel2.TabIndex = 25;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.ckbOlives);
            this.panel3.Controls.Add(this.ckbPepper);
            this.panel3.Controls.Add(this.ckbMush);
            this.panel3.Controls.Add(this.ckbTomato);
            this.panel3.Controls.Add(this.ckbOnion);
            this.panel3.Controls.Add(this.ckbCheese);
            this.panel3.Location = new System.Drawing.Point(465, 415);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(698, 111);
            this.panel3.TabIndex = 26;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.rbIn);
            this.panel4.Controls.Add(this.radioButton6);
            this.panel4.Location = new System.Drawing.Point(463, 578);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(700, 57);
            this.panel4.TabIndex = 27;
            // 
            // priceTb
            // 
            this.priceTb.BackColor = System.Drawing.Color.Linen;
            this.priceTb.Enabled = false;
            this.priceTb.Location = new System.Drawing.Point(942, 661);
            this.priceTb.Multiline = true;
            this.priceTb.Name = "priceTb";
            this.priceTb.Size = new System.Drawing.Size(167, 57);
            this.priceTb.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Coral;
            this.button1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(762, 661);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 37);
            this.button1.TabIndex = 29;
            this.button1.Text = "confirm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Coral;
            this.button2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(571, 661);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 37);
            this.button2.TabIndex = 30;
            this.button2.Text = "reset";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(105, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "........5$";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(108, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 21);
            this.label7.TabIndex = 10;
            this.label7.Text = "........10$";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(371, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 21);
            this.label8.TabIndex = 11;
            this.label8.Text = "........3$";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(371, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 21);
            this.label9.TabIndex = 12;
            this.label9.Text = "........3$";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(157, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 21);
            this.label10.TabIndex = 13;
            this.label10.Text = "........5$";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(157, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 21);
            this.label11.TabIndex = 14;
            this.label11.Text = "........5$";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(108, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 21);
            this.label12.TabIndex = 11;
            this.label12.Text = "........15$";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(100, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 21);
            this.label13.TabIndex = 12;
            this.label13.Text = "........4$";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(100, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 21);
            this.label14.TabIndex = 13;
            this.label14.Text = "........2$";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(608, 66);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 21);
            this.label15.TabIndex = 12;
            this.label15.Text = "........3$";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Location = new System.Drawing.Point(594, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 21);
            this.label16.TabIndex = 13;
            this.label16.Text = "........3$";
            // 
            // orderFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1207, 796);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.priceTb);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.DoubleBuffered = true;
            this.Name = "orderFrm";
            this.Text = "orderFrm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbThick;
        private System.Windows.Forms.RadioButton rbThin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ckbCheese;
        private System.Windows.Forms.CheckBox ckbOnion;
        private System.Windows.Forms.CheckBox ckbTomato;
        private System.Windows.Forms.CheckBox ckbMush;
        private System.Windows.Forms.CheckBox ckbPepper;
        private System.Windows.Forms.CheckBox ckbOlives;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton rbIn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox priceTb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}