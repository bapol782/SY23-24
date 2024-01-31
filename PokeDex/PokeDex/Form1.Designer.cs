namespace PokeDex
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lvlUD = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.typeTB = new System.Windows.Forms.TextBox();
            this.hpTB = new System.Windows.Forms.NumericUpDown();
            this.expTB = new System.Windows.Forms.NumericUpDown();
            this.legCB = new System.Windows.Forms.CheckBox();
            this.shinCB = new System.Windows.Forms.CheckBox();
            this.debugTB = new System.Windows.Forms.TextBox();
            this.SaveB = new System.Windows.Forms.Button();
            this.genTB = new System.Windows.Forms.NumericUpDown();
            this.currentLabel = new System.Windows.Forms.TextBox();
            this.atDD = new System.Windows.Forms.TextBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lastButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.prevButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lvlUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hpTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genTB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Level:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Atk Type:";
            // 
            // lvlUD
            // 
            this.lvlUD.Location = new System.Drawing.Point(85, 91);
            this.lvlUD.Name = "lvlUD";
            this.lvlUD.Size = new System.Drawing.Size(120, 22);
            this.lvlUD.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "HP:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Exp:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 242);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 16);
            this.label10.TabIndex = 7;
            this.label10.Text = "Legendary:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(23, 279);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(43, 16);
            this.label20.TabIndex = 8;
            this.label20.Text = "Shiny:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 320);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Generation:";
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(76, 27);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(100, 22);
            this.nameTB.TabIndex = 10;
            // 
            // typeTB
            // 
            this.typeTB.Location = new System.Drawing.Point(71, 59);
            this.typeTB.Name = "typeTB";
            this.typeTB.Size = new System.Drawing.Size(100, 22);
            this.typeTB.TabIndex = 11;
            // 
            // hpTB
            // 
            this.hpTB.Location = new System.Drawing.Point(58, 166);
            this.hpTB.Name = "hpTB";
            this.hpTB.Size = new System.Drawing.Size(120, 22);
            this.hpTB.TabIndex = 13;
            // 
            // expTB
            // 
            this.expTB.Location = new System.Drawing.Point(62, 200);
            this.expTB.Name = "expTB";
            this.expTB.Size = new System.Drawing.Size(120, 22);
            this.expTB.TabIndex = 14;
            // 
            // legCB
            // 
            this.legCB.AutoSize = true;
            this.legCB.Location = new System.Drawing.Point(104, 242);
            this.legCB.Name = "legCB";
            this.legCB.Size = new System.Drawing.Size(18, 17);
            this.legCB.TabIndex = 15;
            this.legCB.UseVisualStyleBackColor = true;
            // 
            // shinCB
            // 
            this.shinCB.AutoSize = true;
            this.shinCB.Location = new System.Drawing.Point(72, 279);
            this.shinCB.Name = "shinCB";
            this.shinCB.Size = new System.Drawing.Size(18, 17);
            this.shinCB.TabIndex = 16;
            this.shinCB.UseVisualStyleBackColor = true;
            // 
            // debugTB
            // 
            this.debugTB.Location = new System.Drawing.Point(601, 98);
            this.debugTB.Multiline = true;
            this.debugTB.Name = "debugTB";
            this.debugTB.Size = new System.Drawing.Size(161, 267);
            this.debugTB.TabIndex = 18;
            // 
            // SaveB
            // 
            this.SaveB.Location = new System.Drawing.Point(545, 56);
            this.SaveB.Name = "SaveB";
            this.SaveB.Size = new System.Drawing.Size(75, 23);
            this.SaveB.TabIndex = 19;
            this.SaveB.Text = "SAve";
            this.SaveB.UseVisualStyleBackColor = true;
            this.SaveB.Click += new System.EventHandler(this.saveB_Click);
            // 
            // genTB
            // 
            this.genTB.Location = new System.Drawing.Point(105, 320);
            this.genTB.Name = "genTB";
            this.genTB.Size = new System.Drawing.Size(120, 22);
            this.genTB.TabIndex = 20;
            // 
            // currentLabel
            // 
            this.currentLabel.Location = new System.Drawing.Point(39, 371);
            this.currentLabel.Name = "currentLabel";
            this.currentLabel.Size = new System.Drawing.Size(100, 22);
            this.currentLabel.TabIndex = 22;
            // 
            // atDD
            // 
            this.atDD.Location = new System.Drawing.Point(93, 131);
            this.atDD.Name = "atDD";
            this.atDD.Size = new System.Drawing.Size(100, 22);
            this.atDD.TabIndex = 23;
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(601, 404);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 24;
            this.nextButton.Text = "next";
            this.nextButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(507, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "first";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lastButton
            // 
            this.lastButton.Location = new System.Drawing.Point(687, 404);
            this.lastButton.Name = "lastButton";
            this.lastButton.Size = new System.Drawing.Size(75, 23);
            this.lastButton.TabIndex = 26;
            this.lastButton.Text = "last";
            this.lastButton.UseVisualStyleBackColor = true;
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(626, 56);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(75, 23);
            this.newButton.TabIndex = 27;
            this.newButton.Text = "new";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // prevButton
            // 
            this.prevButton.Location = new System.Drawing.Point(507, 371);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(75, 23);
            this.prevButton.TabIndex = 28;
            this.prevButton.Text = "prev";
            this.prevButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.lastButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.atDD);
            this.Controls.Add(this.currentLabel);
            this.Controls.Add(this.genTB);
            this.Controls.Add(this.SaveB);
            this.Controls.Add(this.debugTB);
            this.Controls.Add(this.shinCB);
            this.Controls.Add(this.legCB);
            this.Controls.Add(this.expTB);
            this.Controls.Add(this.hpTB);
            this.Controls.Add(this.typeTB);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lvlUD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lvlUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hpTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genTB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown lvlUD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TextBox typeTB;
        private System.Windows.Forms.NumericUpDown hpTB;
        private System.Windows.Forms.NumericUpDown expTB;
        private System.Windows.Forms.CheckBox legCB;
        private System.Windows.Forms.CheckBox shinCB;
        private System.Windows.Forms.TextBox debugTB;
        private System.Windows.Forms.Button SaveB;
        private System.Windows.Forms.NumericUpDown genTB;
        private System.Windows.Forms.TextBox currentLabel;
        private System.Windows.Forms.TextBox atDD;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button lastButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button prevButton;
    }
}

