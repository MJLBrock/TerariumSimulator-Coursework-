namespace TerariumSimulator_Coursework_
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.cbRndSnails = new System.Windows.Forms.CheckBox();
            this.cbTileLables = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbFood = new System.Windows.Forms.RadioButton();
            this.rbGlass = new System.Windows.Forms.RadioButton();
            this.rbBeetleEgg = new System.Windows.Forms.RadioButton();
            this.rbHoney = new System.Windows.Forms.RadioButton();
            this.rbAntEgg = new System.Windows.Forms.RadioButton();
            this.rbHive = new System.Windows.Forms.RadioButton();
            this.rbBeeEgg = new System.Windows.Forms.RadioButton();
            this.rbFlower = new System.Windows.Forms.RadioButton();
            this.rbSnail = new System.Windows.Forms.RadioButton();
            this.rbStem = new System.Windows.Forms.RadioButton();
            this.rbBeetle = new System.Windows.Forms.RadioButton();
            this.rbAir = new System.Windows.Forms.RadioButton();
            this.rbAnt = new System.Windows.Forms.RadioButton();
            this.rbWater = new System.Windows.Forms.RadioButton();
            this.rbBee = new System.Windows.Forms.RadioButton();
            this.rbSubstrate = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.SkyBlue;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(580, 580);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(615, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "Options";
            // 
            // cbRndSnails
            // 
            this.cbRndSnails.AutoSize = true;
            this.cbRndSnails.Location = new System.Drawing.Point(619, 239);
            this.cbRndSnails.Name = "cbRndSnails";
            this.cbRndSnails.Size = new System.Drawing.Size(135, 17);
            this.cbRndSnails.TabIndex = 19;
            this.cbRndSnails.Text = "Snails randomly appear";
            this.cbRndSnails.UseVisualStyleBackColor = true;
            // 
            // cbTileLables
            // 
            this.cbTileLables.AutoSize = true;
            this.cbTileLables.Location = new System.Drawing.Point(618, 272);
            this.cbTileLables.Name = "cbTileLables";
            this.cbTileLables.Size = new System.Drawing.Size(94, 17);
            this.cbTileLables.TabIndex = 20;
            this.cbTileLables.Text = "Hide tile labels";
            this.cbTileLables.UseVisualStyleBackColor = true;
            this.cbTileLables.CheckedChanged += new System.EventHandler(this.cbTileLables_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbFood);
            this.groupBox1.Controls.Add(this.rbGlass);
            this.groupBox1.Controls.Add(this.rbBeetleEgg);
            this.groupBox1.Controls.Add(this.rbHoney);
            this.groupBox1.Controls.Add(this.rbAntEgg);
            this.groupBox1.Controls.Add(this.rbHive);
            this.groupBox1.Controls.Add(this.rbBeeEgg);
            this.groupBox1.Controls.Add(this.rbFlower);
            this.groupBox1.Controls.Add(this.rbSnail);
            this.groupBox1.Controls.Add(this.rbStem);
            this.groupBox1.Controls.Add(this.rbBeetle);
            this.groupBox1.Controls.Add(this.rbAir);
            this.groupBox1.Controls.Add(this.rbAnt);
            this.groupBox1.Controls.Add(this.rbWater);
            this.groupBox1.Controls.Add(this.rbBee);
            this.groupBox1.Controls.Add(this.rbSubstrate);
            this.groupBox1.Location = new System.Drawing.Point(615, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 202);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tiles";
            // 
            // rbFood
            // 
            this.rbFood.AutoSize = true;
            this.rbFood.Location = new System.Drawing.Point(95, 180);
            this.rbFood.Name = "rbFood";
            this.rbFood.Size = new System.Drawing.Size(49, 17);
            this.rbFood.TabIndex = 38;
            this.rbFood.Text = "Food";
            this.rbFood.UseVisualStyleBackColor = true;
            this.rbFood.CheckedChanged += new System.EventHandler(this.rbFood_CheckedChanged);
            // 
            // rbGlass
            // 
            this.rbGlass.AutoSize = true;
            this.rbGlass.Location = new System.Drawing.Point(6, 180);
            this.rbGlass.Name = "rbGlass";
            this.rbGlass.Size = new System.Drawing.Size(51, 17);
            this.rbGlass.TabIndex = 30;
            this.rbGlass.Text = "Glass";
            this.rbGlass.UseVisualStyleBackColor = true;
            this.rbGlass.CheckedChanged += new System.EventHandler(this.rbGlass_CheckedChanged);
            // 
            // rbBeetleEgg
            // 
            this.rbBeetleEgg.AutoSize = true;
            this.rbBeetleEgg.Location = new System.Drawing.Point(95, 157);
            this.rbBeetleEgg.Name = "rbBeetleEgg";
            this.rbBeetleEgg.Size = new System.Drawing.Size(77, 17);
            this.rbBeetleEgg.TabIndex = 37;
            this.rbBeetleEgg.Text = "Beetle Egg";
            this.rbBeetleEgg.UseVisualStyleBackColor = true;
            this.rbBeetleEgg.CheckedChanged += new System.EventHandler(this.rbBeetleEgg_CheckedChanged);
            // 
            // rbHoney
            // 
            this.rbHoney.AutoSize = true;
            this.rbHoney.Location = new System.Drawing.Point(6, 157);
            this.rbHoney.Name = "rbHoney";
            this.rbHoney.Size = new System.Drawing.Size(56, 17);
            this.rbHoney.TabIndex = 29;
            this.rbHoney.Text = "Honey";
            this.rbHoney.UseVisualStyleBackColor = true;
            this.rbHoney.CheckedChanged += new System.EventHandler(this.rbHoney_CheckedChanged);
            // 
            // rbAntEgg
            // 
            this.rbAntEgg.AutoSize = true;
            this.rbAntEgg.Location = new System.Drawing.Point(95, 134);
            this.rbAntEgg.Name = "rbAntEgg";
            this.rbAntEgg.Size = new System.Drawing.Size(63, 17);
            this.rbAntEgg.TabIndex = 36;
            this.rbAntEgg.Text = "Ant Egg";
            this.rbAntEgg.UseVisualStyleBackColor = true;
            this.rbAntEgg.CheckedChanged += new System.EventHandler(this.rbAntEgg_CheckedChanged);
            // 
            // rbHive
            // 
            this.rbHive.AutoSize = true;
            this.rbHive.Location = new System.Drawing.Point(6, 134);
            this.rbHive.Name = "rbHive";
            this.rbHive.Size = new System.Drawing.Size(47, 17);
            this.rbHive.TabIndex = 28;
            this.rbHive.Text = "Hive";
            this.rbHive.UseVisualStyleBackColor = true;
            this.rbHive.CheckedChanged += new System.EventHandler(this.rbHive_CheckedChanged);
            // 
            // rbBeeEgg
            // 
            this.rbBeeEgg.AutoSize = true;
            this.rbBeeEgg.Location = new System.Drawing.Point(95, 111);
            this.rbBeeEgg.Name = "rbBeeEgg";
            this.rbBeeEgg.Size = new System.Drawing.Size(66, 17);
            this.rbBeeEgg.TabIndex = 35;
            this.rbBeeEgg.Text = "Bee Egg";
            this.rbBeeEgg.UseVisualStyleBackColor = true;
            this.rbBeeEgg.CheckedChanged += new System.EventHandler(this.rbBeeEgg_CheckedChanged);
            // 
            // rbFlower
            // 
            this.rbFlower.AutoSize = true;
            this.rbFlower.Location = new System.Drawing.Point(6, 111);
            this.rbFlower.Name = "rbFlower";
            this.rbFlower.Size = new System.Drawing.Size(56, 17);
            this.rbFlower.TabIndex = 27;
            this.rbFlower.Text = "Flower";
            this.rbFlower.UseVisualStyleBackColor = true;
            this.rbFlower.CheckedChanged += new System.EventHandler(this.rbFlower_CheckedChanged);
            // 
            // rbSnail
            // 
            this.rbSnail.AutoSize = true;
            this.rbSnail.Location = new System.Drawing.Point(95, 88);
            this.rbSnail.Name = "rbSnail";
            this.rbSnail.Size = new System.Drawing.Size(48, 17);
            this.rbSnail.TabIndex = 34;
            this.rbSnail.Text = "Snail";
            this.rbSnail.UseVisualStyleBackColor = true;
            this.rbSnail.CheckedChanged += new System.EventHandler(this.rbSnail_CheckedChanged);
            // 
            // rbStem
            // 
            this.rbStem.AutoSize = true;
            this.rbStem.Location = new System.Drawing.Point(6, 88);
            this.rbStem.Name = "rbStem";
            this.rbStem.Size = new System.Drawing.Size(49, 17);
            this.rbStem.TabIndex = 26;
            this.rbStem.Text = "Stem";
            this.rbStem.UseVisualStyleBackColor = true;
            this.rbStem.CheckedChanged += new System.EventHandler(this.rbStem_CheckedChanged);
            // 
            // rbBeetle
            // 
            this.rbBeetle.AutoSize = true;
            this.rbBeetle.Location = new System.Drawing.Point(95, 65);
            this.rbBeetle.Name = "rbBeetle";
            this.rbBeetle.Size = new System.Drawing.Size(55, 17);
            this.rbBeetle.TabIndex = 33;
            this.rbBeetle.Text = "Beetle";
            this.rbBeetle.UseVisualStyleBackColor = true;
            this.rbBeetle.CheckedChanged += new System.EventHandler(this.rbBeetle_CheckedChanged);
            // 
            // rbAir
            // 
            this.rbAir.AutoSize = true;
            this.rbAir.Location = new System.Drawing.Point(6, 65);
            this.rbAir.Name = "rbAir";
            this.rbAir.Size = new System.Drawing.Size(37, 17);
            this.rbAir.TabIndex = 25;
            this.rbAir.Text = "Air";
            this.rbAir.UseVisualStyleBackColor = true;
            this.rbAir.CheckedChanged += new System.EventHandler(this.rbAir_CheckedChanged);
            // 
            // rbAnt
            // 
            this.rbAnt.AutoSize = true;
            this.rbAnt.Location = new System.Drawing.Point(95, 42);
            this.rbAnt.Name = "rbAnt";
            this.rbAnt.Size = new System.Drawing.Size(41, 17);
            this.rbAnt.TabIndex = 32;
            this.rbAnt.Text = "Ant";
            this.rbAnt.UseVisualStyleBackColor = true;
            this.rbAnt.CheckedChanged += new System.EventHandler(this.rbAnt_CheckedChanged);
            // 
            // rbWater
            // 
            this.rbWater.AutoSize = true;
            this.rbWater.Location = new System.Drawing.Point(6, 42);
            this.rbWater.Name = "rbWater";
            this.rbWater.Size = new System.Drawing.Size(54, 17);
            this.rbWater.TabIndex = 24;
            this.rbWater.Text = "Water";
            this.rbWater.UseVisualStyleBackColor = true;
            this.rbWater.CheckedChanged += new System.EventHandler(this.rbWater_CheckedChanged);
            // 
            // rbBee
            // 
            this.rbBee.AutoSize = true;
            this.rbBee.Location = new System.Drawing.Point(95, 19);
            this.rbBee.Name = "rbBee";
            this.rbBee.Size = new System.Drawing.Size(44, 17);
            this.rbBee.TabIndex = 31;
            this.rbBee.Text = "Bee";
            this.rbBee.UseVisualStyleBackColor = true;
            this.rbBee.CheckedChanged += new System.EventHandler(this.rbBee_CheckedChanged);
            // 
            // rbSubstrate
            // 
            this.rbSubstrate.AutoSize = true;
            this.rbSubstrate.Checked = true;
            this.rbSubstrate.Location = new System.Drawing.Point(6, 19);
            this.rbSubstrate.Name = "rbSubstrate";
            this.rbSubstrate.Size = new System.Drawing.Size(70, 17);
            this.rbSubstrate.TabIndex = 0;
            this.rbSubstrate.TabStop = true;
            this.rbSubstrate.Text = "Substrate";
            this.rbSubstrate.UseVisualStyleBackColor = true;
            this.rbSubstrate.CheckedChanged += new System.EventHandler(this.rbSubstrate_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(827, 607);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbTileLables);
            this.Controls.Add(this.cbRndSnails);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Terrarium Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbRndSnails;
        private System.Windows.Forms.CheckBox cbTileLables;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbSubstrate;
        private System.Windows.Forms.RadioButton rbWater;
        private System.Windows.Forms.RadioButton rbGlass;
        private System.Windows.Forms.RadioButton rbHoney;
        private System.Windows.Forms.RadioButton rbHive;
        private System.Windows.Forms.RadioButton rbFlower;
        private System.Windows.Forms.RadioButton rbStem;
        private System.Windows.Forms.RadioButton rbAir;
        private System.Windows.Forms.RadioButton rbFood;
        private System.Windows.Forms.RadioButton rbBeetleEgg;
        private System.Windows.Forms.RadioButton rbAntEgg;
        private System.Windows.Forms.RadioButton rbBeeEgg;
        private System.Windows.Forms.RadioButton rbSnail;
        private System.Windows.Forms.RadioButton rbBeetle;
        private System.Windows.Forms.RadioButton rbAnt;
        private System.Windows.Forms.RadioButton rbBee;
    }
}

