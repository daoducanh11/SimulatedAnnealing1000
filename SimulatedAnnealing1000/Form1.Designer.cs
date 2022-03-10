
namespace SimulatedAnnealing1000
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Distance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.stopButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.currentTempBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.currentIterationBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.iterationsBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.currTempBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.coolingRateBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtend = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtstart = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.generateMapButton = new System.Windows.Forms.Button();
            this.mapControl = new Accord.Controls.Chart();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1112, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 553);
            this.panel1.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Distance});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 503);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(253, 38);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Distance
            // 
            this.Distance.Text = "Distance";
            this.Distance.Width = 600;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.stopButton);
            this.groupBox2.Controls.Add(this.startButton);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.currentTempBox);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.currentIterationBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.iterationsBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.currTempBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.coolingRateBox);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.txtend);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txtstart);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(5, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 418);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            // 
            // stopButton
            // 
            this.stopButton.Enabled = false;
            this.stopButton.Location = new System.Drawing.Point(136, 361);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(90, 26);
            this.stopButton.TabIndex = 36;
            this.stopButton.Text = "S&top";
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(31, 361);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(90, 26);
            this.startButton.TabIndex = 35;
            this.startButton.Text = "&Start";
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Location = new System.Drawing.Point(6, 317);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(240, 2);
            this.label10.TabIndex = 34;
            // 
            // currentTempBox
            // 
            this.currentTempBox.Location = new System.Drawing.Point(127, 274);
            this.currentTempBox.Name = "currentTempBox";
            this.currentTempBox.ReadOnly = true;
            this.currentTempBox.Size = new System.Drawing.Size(118, 22);
            this.currentTempBox.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(6, 277);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 16);
            this.label11.TabIndex = 32;
            this.label11.Text = "Current temp:";
            // 
            // currentIterationBox
            // 
            this.currentIterationBox.Location = new System.Drawing.Point(127, 245);
            this.currentIterationBox.Name = "currentIterationBox";
            this.currentIterationBox.ReadOnly = true;
            this.currentIterationBox.Size = new System.Drawing.Size(118, 22);
            this.currentIterationBox.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(6, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 18);
            this.label8.TabIndex = 30;
            this.label8.Text = "Current iteration:";
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(6, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(240, 2);
            this.label9.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(162, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 19);
            this.label5.TabIndex = 26;
            this.label5.Text = "( 0 - inifinity )";
            // 
            // iterationsBox
            // 
            this.iterationsBox.Location = new System.Drawing.Point(118, 174);
            this.iterationsBox.Name = "iterationsBox";
            this.iterationsBox.Size = new System.Drawing.Size(127, 22);
            this.iterationsBox.TabIndex = 25;
            this.iterationsBox.Text = "1000000";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 19);
            this.label4.TabIndex = 24;
            this.label4.Text = "Iterations limit:";
            // 
            // currTempBox
            // 
            this.currTempBox.Location = new System.Drawing.Point(118, 141);
            this.currTempBox.Name = "currTempBox";
            this.currTempBox.Size = new System.Drawing.Size(127, 22);
            this.currTempBox.TabIndex = 23;
            this.currTempBox.Text = "1000000";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "Current Temp:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 19);
            this.label6.TabIndex = 20;
            this.label6.Text = "Cooling rate:";
            // 
            // coolingRateBox
            // 
            this.coolingRateBox.Location = new System.Drawing.Point(118, 109);
            this.coolingRateBox.Name = "coolingRateBox";
            this.coolingRateBox.Size = new System.Drawing.Size(127, 22);
            this.coolingRateBox.TabIndex = 21;
            this.coolingRateBox.Text = "0.995";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Yellow;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(6, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(20, 20);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // txtend
            // 
            this.txtend.Location = new System.Drawing.Point(118, 67);
            this.txtend.Margin = new System.Windows.Forms.Padding(2);
            this.txtend.Name = "txtend";
            this.txtend.Size = new System.Drawing.Size(63, 22);
            this.txtend.TabIndex = 6;
            this.txtend.Text = "1000";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(41, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "End:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(6, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 20);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // txtstart
            // 
            this.txtstart.Location = new System.Drawing.Point(118, 26);
            this.txtstart.Margin = new System.Windows.Forms.Padding(2);
            this.txtstart.Name = "txtstart";
            this.txtstart.Size = new System.Drawing.Size(63, 22);
            this.txtstart.TabIndex = 3;
            this.txtstart.Text = "1";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(41, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Start:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.generateMapButton);
            this.groupBox1.Location = new System.Drawing.Point(5, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 61);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generate";
            // 
            // generateMapButton
            // 
            this.generateMapButton.Location = new System.Drawing.Point(79, 20);
            this.generateMapButton.Margin = new System.Windows.Forms.Padding(2);
            this.generateMapButton.Name = "generateMapButton";
            this.generateMapButton.Size = new System.Drawing.Size(100, 27);
            this.generateMapButton.TabIndex = 4;
            this.generateMapButton.Text = "&Generate";
            this.generateMapButton.Click += new System.EventHandler(this.generateMapButton_Click);
            // 
            // mapControl
            // 
            this.mapControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl.Location = new System.Drawing.Point(0, 0);
            this.mapControl.Margin = new System.Windows.Forms.Padding(2);
            this.mapControl.Name = "mapControl";
            this.mapControl.Size = new System.Drawing.Size(1112, 553);
            this.mapControl.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(186, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 19);
            this.label7.TabIndex = 37;
            this.label7.Text = "(1 - 1000)";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(185, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 19);
            this.label12.TabIndex = 38;
            this.label12.Text = "(1 - 1000)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1380, 553);
            this.Controls.Add(this.mapControl);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "SimulatedAnnealing1000";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Accord.Controls.Chart mapControl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button generateMapButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtstart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox iterationsBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox currTempBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox coolingRateBox;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox currentTempBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox currentIterationBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Distance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
    }
}

