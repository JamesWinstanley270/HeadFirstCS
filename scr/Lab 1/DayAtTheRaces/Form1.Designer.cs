namespace DayAtTheRaces
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
            this.picRacetrack = new System.Windows.Forms.PictureBox();
            this.picGreyhound1 = new System.Windows.Forms.PictureBox();
            this.picGreyhound2 = new System.Windows.Forms.PictureBox();
            this.picGreyhound3 = new System.Windows.Forms.PictureBox();
            this.picGreyhound4 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAlsLabel = new System.Windows.Forms.Label();
            this.lblBobsLabel = new System.Windows.Forms.Label();
            this.lblJoesLabel = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.numDogNumber = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numBetAmmount = new System.Windows.Forms.NumericUpDown();
            this.btnPlaceBet = new System.Windows.Forms.Button();
            this.lblSelectedGuy = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radAl = new System.Windows.Forms.RadioButton();
            this.radBob = new System.Windows.Forms.RadioButton();
            this.radJoe = new System.Windows.Forms.RadioButton();
            this.lblMinimumBet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picRacetrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGreyhound1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGreyhound2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGreyhound3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGreyhound4)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDogNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBetAmmount)).BeginInit();
            this.SuspendLayout();
            // 
            // picRacetrack
            // 
            this.picRacetrack.Image = global::DayAtTheRaces.Properties.Resources.Track;
            this.picRacetrack.Location = new System.Drawing.Point(12, 12);
            this.picRacetrack.Name = "picRacetrack";
            this.picRacetrack.Size = new System.Drawing.Size(776, 260);
            this.picRacetrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRacetrack.TabIndex = 0;
            this.picRacetrack.TabStop = false;
            // 
            // picGreyhound1
            // 
            this.picGreyhound1.Image = global::DayAtTheRaces.Properties.Resources.Dog;
            this.picGreyhound1.Location = new System.Drawing.Point(12, 12);
            this.picGreyhound1.Name = "picGreyhound1";
            this.picGreyhound1.Size = new System.Drawing.Size(111, 42);
            this.picGreyhound1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGreyhound1.TabIndex = 1;
            this.picGreyhound1.TabStop = false;
            // 
            // picGreyhound2
            // 
            this.picGreyhound2.Image = global::DayAtTheRaces.Properties.Resources.Dog;
            this.picGreyhound2.Location = new System.Drawing.Point(12, 80);
            this.picGreyhound2.Name = "picGreyhound2";
            this.picGreyhound2.Size = new System.Drawing.Size(111, 42);
            this.picGreyhound2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGreyhound2.TabIndex = 2;
            this.picGreyhound2.TabStop = false;
            // 
            // picGreyhound3
            // 
            this.picGreyhound3.Image = global::DayAtTheRaces.Properties.Resources.Dog;
            this.picGreyhound3.Location = new System.Drawing.Point(12, 151);
            this.picGreyhound3.Name = "picGreyhound3";
            this.picGreyhound3.Size = new System.Drawing.Size(111, 42);
            this.picGreyhound3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGreyhound3.TabIndex = 3;
            this.picGreyhound3.TabStop = false;
            // 
            // picGreyhound4
            // 
            this.picGreyhound4.Image = global::DayAtTheRaces.Properties.Resources.Dog;
            this.picGreyhound4.Location = new System.Drawing.Point(12, 221);
            this.picGreyhound4.Name = "picGreyhound4";
            this.picGreyhound4.Size = new System.Drawing.Size(111, 42);
            this.picGreyhound4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGreyhound4.TabIndex = 4;
            this.picGreyhound4.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAlsLabel);
            this.groupBox1.Controls.Add(this.lblBobsLabel);
            this.groupBox1.Controls.Add(this.lblJoesLabel);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.numDogNumber);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numBetAmmount);
            this.groupBox1.Controls.Add(this.btnPlaceBet);
            this.groupBox1.Controls.Add(this.lblSelectedGuy);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.radAl);
            this.groupBox1.Controls.Add(this.radBob);
            this.groupBox1.Controls.Add(this.radJoe);
            this.groupBox1.Controls.Add(this.lblMinimumBet);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 294);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 166);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Betting Parlor";
            // 
            // lblAlsLabel
            // 
            this.lblAlsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAlsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlsLabel.Location = new System.Drawing.Point(387, 95);
            this.lblAlsLabel.Name = "lblAlsLabel";
            this.lblAlsLabel.Size = new System.Drawing.Size(295, 19);
            this.lblAlsLabel.TabIndex = 13;
            this.lblAlsLabel.Text = "Guy bets 5 bucks on dog #1";
            // 
            // lblBobsLabel
            // 
            this.lblBobsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBobsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBobsLabel.Location = new System.Drawing.Point(387, 70);
            this.lblBobsLabel.Name = "lblBobsLabel";
            this.lblBobsLabel.Size = new System.Drawing.Size(295, 19);
            this.lblBobsLabel.TabIndex = 12;
            this.lblBobsLabel.Text = "Guy bets 5 bucks on dog #1";
            // 
            // lblJoesLabel
            // 
            this.lblJoesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblJoesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoesLabel.Location = new System.Drawing.Point(388, 45);
            this.lblJoesLabel.Name = "lblJoesLabel";
            this.lblJoesLabel.Size = new System.Drawing.Size(295, 19);
            this.lblJoesLabel.TabIndex = 11;
            this.lblJoesLabel.Text = "Guy bets 5 bucks on dog #1";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(689, 123);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(81, 35);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "Race!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // numDogNumber
            // 
            this.numDogNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDogNumber.Location = new System.Drawing.Point(348, 130);
            this.numDogNumber.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numDogNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDogNumber.Name = "numDogNumber";
            this.numDogNumber.Size = new System.Drawing.Size(54, 21);
            this.numDogNumber.TabIndex = 9;
            this.numDogNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(213, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "bucks on dog number";
            // 
            // numBetAmmount
            // 
            this.numBetAmmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBetAmmount.Location = new System.Drawing.Point(146, 130);
            this.numBetAmmount.Name = "numBetAmmount";
            this.numBetAmmount.Size = new System.Drawing.Size(61, 21);
            this.numBetAmmount.TabIndex = 7;
            // 
            // btnPlaceBet
            // 
            this.btnPlaceBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceBet.Location = new System.Drawing.Point(65, 129);
            this.btnPlaceBet.Name = "btnPlaceBet";
            this.btnPlaceBet.Size = new System.Drawing.Size(75, 23);
            this.btnPlaceBet.TabIndex = 6;
            this.btnPlaceBet.Text = "Bets";
            this.btnPlaceBet.UseVisualStyleBackColor = true;
            this.btnPlaceBet.Click += new System.EventHandler(this.btnPlaceBet_Click);
            // 
            // lblSelectedGuy
            // 
            this.lblSelectedGuy.AutoSize = true;
            this.lblSelectedGuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedGuy.Location = new System.Drawing.Point(7, 133);
            this.lblSelectedGuy.Name = "lblSelectedGuy";
            this.lblSelectedGuy.Size = new System.Drawing.Size(29, 15);
            this.lblSelectedGuy.TabIndex = 5;
            this.lblSelectedGuy.Text = "Bob";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(384, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bets";
            // 
            // radAl
            // 
            this.radAl.AutoSize = true;
            this.radAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAl.Location = new System.Drawing.Point(10, 95);
            this.radAl.Name = "radAl";
            this.radAl.Size = new System.Drawing.Size(35, 19);
            this.radAl.TabIndex = 3;
            this.radAl.TabStop = true;
            this.radAl.Text = "Al";
            this.radAl.UseVisualStyleBackColor = true;
            // 
            // radBob
            // 
            this.radBob.AutoSize = true;
            this.radBob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBob.Location = new System.Drawing.Point(10, 70);
            this.radBob.Name = "radBob";
            this.radBob.Size = new System.Drawing.Size(47, 19);
            this.radBob.TabIndex = 2;
            this.radBob.TabStop = true;
            this.radBob.Text = "Bob";
            this.radBob.UseVisualStyleBackColor = true;
            // 
            // radJoe
            // 
            this.radJoe.AutoSize = true;
            this.radJoe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radJoe.Location = new System.Drawing.Point(10, 45);
            this.radJoe.Name = "radJoe";
            this.radJoe.Size = new System.Drawing.Size(45, 19);
            this.radJoe.TabIndex = 1;
            this.radJoe.TabStop = true;
            this.radJoe.Text = "Joe";
            this.radJoe.UseVisualStyleBackColor = true;
            // 
            // lblMinimumBet
            // 
            this.lblMinimumBet.AutoSize = true;
            this.lblMinimumBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimumBet.Location = new System.Drawing.Point(7, 26);
            this.lblMinimumBet.Name = "lblMinimumBet";
            this.lblMinimumBet.Size = new System.Drawing.Size(95, 16);
            this.lblMinimumBet.TabIndex = 0;
            this.lblMinimumBet.Text = "Minimum Bet";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picGreyhound4);
            this.Controls.Add(this.picGreyhound3);
            this.Controls.Add(this.picGreyhound2);
            this.Controls.Add(this.picGreyhound1);
            this.Controls.Add(this.picRacetrack);
            this.Name = "Form1";
            this.Text = "A Day at the Races";
            ((System.ComponentModel.ISupportInitialize)(this.picRacetrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGreyhound1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGreyhound2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGreyhound3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGreyhound4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDogNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBetAmmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picRacetrack;
        private System.Windows.Forms.PictureBox picGreyhound1;
        private System.Windows.Forms.PictureBox picGreyhound2;
        private System.Windows.Forms.PictureBox picGreyhound3;
        private System.Windows.Forms.PictureBox picGreyhound4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblJoesLabel;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown numDogNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numBetAmmount;
        private System.Windows.Forms.Button btnPlaceBet;
        private System.Windows.Forms.Label lblSelectedGuy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radAl;
        private System.Windows.Forms.RadioButton radBob;
        private System.Windows.Forms.RadioButton radJoe;
        private System.Windows.Forms.Label lblMinimumBet;
        private System.Windows.Forms.Label lblAlsLabel;
        private System.Windows.Forms.Label lblBobsLabel;
    }
}

