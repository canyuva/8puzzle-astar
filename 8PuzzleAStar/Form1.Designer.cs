namespace _8PuzzleAStar
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
            this.button1 = new System.Windows.Forms.Button();
            this.startButton0 = new System.Windows.Forms.Button();
            this.startButton8 = new System.Windows.Forms.Button();
            this.startButton7 = new System.Windows.Forms.Button();
            this.startButton6 = new System.Windows.Forms.Button();
            this.startButton5 = new System.Windows.Forms.Button();
            this.startButton4 = new System.Windows.Forms.Button();
            this.startButton3 = new System.Windows.Forms.Button();
            this.startButton2 = new System.Windows.Forms.Button();
            this.startButton1 = new System.Windows.Forms.Button();
            this.startStateGB = new System.Windows.Forms.GroupBox();
            this.goalStateGB = new System.Windows.Forms.GroupBox();
            this.goalButton2 = new System.Windows.Forms.Button();
            this.goalButton1 = new System.Windows.Forms.Button();
            this.goalButton3 = new System.Windows.Forms.Button();
            this.goalButton4 = new System.Windows.Forms.Button();
            this.goalButton5 = new System.Windows.Forms.Button();
            this.goalButton6 = new System.Windows.Forms.Button();
            this.goalButton7 = new System.Windows.Forms.Button();
            this.goalButton8 = new System.Windows.Forms.Button();
            this.goalButton0 = new System.Windows.Forms.Button();
            this.startStateSelected = new System.Windows.Forms.GroupBox();
            this.startState1 = new System.Windows.Forms.Button();
            this.startState0 = new System.Windows.Forms.Button();
            this.startState2 = new System.Windows.Forms.Button();
            this.startState3 = new System.Windows.Forms.Button();
            this.startState4 = new System.Windows.Forms.Button();
            this.startState5 = new System.Windows.Forms.Button();
            this.startState6 = new System.Windows.Forms.Button();
            this.startState7 = new System.Windows.Forms.Button();
            this.startState8 = new System.Windows.Forms.Button();
            this.startStateCB = new System.Windows.Forms.CheckBox();
            this.goalStateCB = new System.Windows.Forms.CheckBox();
            this.goalStateSelected = new System.Windows.Forms.GroupBox();
            this.goalState1 = new System.Windows.Forms.Button();
            this.goalState0 = new System.Windows.Forms.Button();
            this.goalState2 = new System.Windows.Forms.Button();
            this.goalState3 = new System.Windows.Forms.Button();
            this.goalState4 = new System.Windows.Forms.Button();
            this.goalState5 = new System.Windows.Forms.Button();
            this.goalState6 = new System.Windows.Forms.Button();
            this.goalState7 = new System.Windows.Forms.Button();
            this.goalState8 = new System.Windows.Forms.Button();
            this.startStateRefresh = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.stepsLog = new System.Windows.Forms.RichTextBox();
            this.startStateGB.SuspendLayout();
            this.goalStateGB.SuspendLayout();
            this.startStateSelected.SuspendLayout();
            this.goalStateSelected.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.YellowGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(271, 71);
            this.button1.TabIndex = 0;
            this.button1.Text = "ÇÖZ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // startButton0
            // 
            this.startButton0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton0.Location = new System.Drawing.Point(157, 160);
            this.startButton0.Name = "startButton0";
            this.startButton0.Size = new System.Drawing.Size(58, 58);
            this.startButton0.TabIndex = 18;
            this.startButton0.Text = "0";
            this.startButton0.UseVisualStyleBackColor = true;
            this.startButton0.Click += new System.EventHandler(this.startButtons_Click);
            // 
            // startButton8
            // 
            this.startButton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton8.Location = new System.Drawing.Point(93, 160);
            this.startButton8.Name = "startButton8";
            this.startButton8.Size = new System.Drawing.Size(58, 58);
            this.startButton8.TabIndex = 17;
            this.startButton8.Text = "8";
            this.startButton8.UseVisualStyleBackColor = true;
            this.startButton8.Click += new System.EventHandler(this.startButtons_Click);
            // 
            // startButton7
            // 
            this.startButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton7.Location = new System.Drawing.Point(29, 160);
            this.startButton7.Name = "startButton7";
            this.startButton7.Size = new System.Drawing.Size(58, 58);
            this.startButton7.TabIndex = 16;
            this.startButton7.Text = "7";
            this.startButton7.UseVisualStyleBackColor = true;
            this.startButton7.Click += new System.EventHandler(this.startButtons_Click);
            // 
            // startButton6
            // 
            this.startButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton6.Location = new System.Drawing.Point(157, 96);
            this.startButton6.Name = "startButton6";
            this.startButton6.Size = new System.Drawing.Size(58, 58);
            this.startButton6.TabIndex = 15;
            this.startButton6.Text = "6";
            this.startButton6.UseVisualStyleBackColor = true;
            this.startButton6.Click += new System.EventHandler(this.startButtons_Click);
            // 
            // startButton5
            // 
            this.startButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton5.Location = new System.Drawing.Point(93, 96);
            this.startButton5.Name = "startButton5";
            this.startButton5.Size = new System.Drawing.Size(58, 58);
            this.startButton5.TabIndex = 14;
            this.startButton5.Text = "5";
            this.startButton5.UseVisualStyleBackColor = true;
            this.startButton5.Click += new System.EventHandler(this.startButtons_Click);
            // 
            // startButton4
            // 
            this.startButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton4.Location = new System.Drawing.Point(29, 96);
            this.startButton4.Name = "startButton4";
            this.startButton4.Size = new System.Drawing.Size(58, 58);
            this.startButton4.TabIndex = 13;
            this.startButton4.Text = "4";
            this.startButton4.UseVisualStyleBackColor = true;
            this.startButton4.Click += new System.EventHandler(this.startButtons_Click);
            // 
            // startButton3
            // 
            this.startButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton3.Location = new System.Drawing.Point(157, 32);
            this.startButton3.Name = "startButton3";
            this.startButton3.Size = new System.Drawing.Size(58, 58);
            this.startButton3.TabIndex = 12;
            this.startButton3.Text = "3";
            this.startButton3.UseVisualStyleBackColor = true;
            this.startButton3.Click += new System.EventHandler(this.startButtons_Click);
            // 
            // startButton2
            // 
            this.startButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton2.Location = new System.Drawing.Point(93, 32);
            this.startButton2.Name = "startButton2";
            this.startButton2.Size = new System.Drawing.Size(58, 58);
            this.startButton2.TabIndex = 11;
            this.startButton2.Text = "2";
            this.startButton2.UseVisualStyleBackColor = true;
            this.startButton2.Click += new System.EventHandler(this.startButtons_Click);
            // 
            // startButton1
            // 
            this.startButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton1.Location = new System.Drawing.Point(29, 32);
            this.startButton1.Name = "startButton1";
            this.startButton1.Size = new System.Drawing.Size(58, 58);
            this.startButton1.TabIndex = 10;
            this.startButton1.Text = "1";
            this.startButton1.UseVisualStyleBackColor = true;
            this.startButton1.Click += new System.EventHandler(this.startButtons_Click);
            // 
            // startStateGB
            // 
            this.startStateGB.Controls.Add(this.startButton2);
            this.startStateGB.Controls.Add(this.startButton1);
            this.startStateGB.Controls.Add(this.startButton3);
            this.startStateGB.Controls.Add(this.startButton4);
            this.startStateGB.Controls.Add(this.startButton5);
            this.startStateGB.Controls.Add(this.startButton6);
            this.startStateGB.Controls.Add(this.startButton7);
            this.startStateGB.Controls.Add(this.startButton8);
            this.startStateGB.Controls.Add(this.startButton0);
            this.startStateGB.Enabled = false;
            this.startStateGB.Location = new System.Drawing.Point(289, 12);
            this.startStateGB.Name = "startStateGB";
            this.startStateGB.Size = new System.Drawing.Size(238, 239);
            this.startStateGB.TabIndex = 30;
            this.startStateGB.TabStop = false;
            this.startStateGB.Text = "Başlangıç Durumu Seçin";
            // 
            // goalStateGB
            // 
            this.goalStateGB.Controls.Add(this.goalButton2);
            this.goalStateGB.Controls.Add(this.goalButton1);
            this.goalStateGB.Controls.Add(this.goalButton3);
            this.goalStateGB.Controls.Add(this.goalButton4);
            this.goalStateGB.Controls.Add(this.goalButton5);
            this.goalStateGB.Controls.Add(this.goalButton6);
            this.goalStateGB.Controls.Add(this.goalButton7);
            this.goalStateGB.Controls.Add(this.goalButton8);
            this.goalStateGB.Controls.Add(this.goalButton0);
            this.goalStateGB.Enabled = false;
            this.goalStateGB.Location = new System.Drawing.Point(533, 12);
            this.goalStateGB.Name = "goalStateGB";
            this.goalStateGB.Size = new System.Drawing.Size(238, 239);
            this.goalStateGB.TabIndex = 31;
            this.goalStateGB.TabStop = false;
            this.goalStateGB.Text = "Hedef Durumu Seçin";
            // 
            // goalButton2
            // 
            this.goalButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goalButton2.Location = new System.Drawing.Point(93, 32);
            this.goalButton2.Name = "goalButton2";
            this.goalButton2.Size = new System.Drawing.Size(58, 58);
            this.goalButton2.TabIndex = 11;
            this.goalButton2.Text = "2";
            this.goalButton2.UseVisualStyleBackColor = true;
            this.goalButton2.Click += new System.EventHandler(this.goalButton1_Click);
            // 
            // goalButton1
            // 
            this.goalButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goalButton1.Location = new System.Drawing.Point(29, 32);
            this.goalButton1.Name = "goalButton1";
            this.goalButton1.Size = new System.Drawing.Size(58, 58);
            this.goalButton1.TabIndex = 10;
            this.goalButton1.Text = "1";
            this.goalButton1.UseVisualStyleBackColor = true;
            this.goalButton1.Click += new System.EventHandler(this.goalButton1_Click);
            // 
            // goalButton3
            // 
            this.goalButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goalButton3.Location = new System.Drawing.Point(157, 32);
            this.goalButton3.Name = "goalButton3";
            this.goalButton3.Size = new System.Drawing.Size(58, 58);
            this.goalButton3.TabIndex = 12;
            this.goalButton3.Text = "3";
            this.goalButton3.UseVisualStyleBackColor = true;
            this.goalButton3.Click += new System.EventHandler(this.goalButton1_Click);
            // 
            // goalButton4
            // 
            this.goalButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goalButton4.Location = new System.Drawing.Point(29, 96);
            this.goalButton4.Name = "goalButton4";
            this.goalButton4.Size = new System.Drawing.Size(58, 58);
            this.goalButton4.TabIndex = 13;
            this.goalButton4.Text = "4";
            this.goalButton4.UseVisualStyleBackColor = true;
            this.goalButton4.Click += new System.EventHandler(this.goalButton1_Click);
            // 
            // goalButton5
            // 
            this.goalButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goalButton5.Location = new System.Drawing.Point(93, 96);
            this.goalButton5.Name = "goalButton5";
            this.goalButton5.Size = new System.Drawing.Size(58, 58);
            this.goalButton5.TabIndex = 14;
            this.goalButton5.Text = "5";
            this.goalButton5.UseVisualStyleBackColor = true;
            this.goalButton5.Click += new System.EventHandler(this.goalButton1_Click);
            // 
            // goalButton6
            // 
            this.goalButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goalButton6.Location = new System.Drawing.Point(157, 96);
            this.goalButton6.Name = "goalButton6";
            this.goalButton6.Size = new System.Drawing.Size(58, 58);
            this.goalButton6.TabIndex = 15;
            this.goalButton6.Text = "6";
            this.goalButton6.UseVisualStyleBackColor = true;
            this.goalButton6.Click += new System.EventHandler(this.goalButton1_Click);
            // 
            // goalButton7
            // 
            this.goalButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goalButton7.Location = new System.Drawing.Point(29, 160);
            this.goalButton7.Name = "goalButton7";
            this.goalButton7.Size = new System.Drawing.Size(58, 58);
            this.goalButton7.TabIndex = 16;
            this.goalButton7.Text = "7";
            this.goalButton7.UseVisualStyleBackColor = true;
            this.goalButton7.Click += new System.EventHandler(this.goalButton1_Click);
            // 
            // goalButton8
            // 
            this.goalButton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goalButton8.Location = new System.Drawing.Point(93, 160);
            this.goalButton8.Name = "goalButton8";
            this.goalButton8.Size = new System.Drawing.Size(58, 58);
            this.goalButton8.TabIndex = 17;
            this.goalButton8.Text = "8";
            this.goalButton8.UseVisualStyleBackColor = true;
            this.goalButton8.Click += new System.EventHandler(this.goalButton1_Click);
            // 
            // goalButton0
            // 
            this.goalButton0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goalButton0.Location = new System.Drawing.Point(157, 160);
            this.goalButton0.Name = "goalButton0";
            this.goalButton0.Size = new System.Drawing.Size(58, 58);
            this.goalButton0.TabIndex = 18;
            this.goalButton0.Text = "0";
            this.goalButton0.UseVisualStyleBackColor = true;
            this.goalButton0.Click += new System.EventHandler(this.goalButton1_Click);
            // 
            // startStateSelected
            // 
            this.startStateSelected.BackColor = System.Drawing.Color.LightCoral;
            this.startStateSelected.Controls.Add(this.startState1);
            this.startStateSelected.Controls.Add(this.startState0);
            this.startStateSelected.Controls.Add(this.startState2);
            this.startStateSelected.Controls.Add(this.startState3);
            this.startStateSelected.Controls.Add(this.startState4);
            this.startStateSelected.Controls.Add(this.startState5);
            this.startStateSelected.Controls.Add(this.startState6);
            this.startStateSelected.Controls.Add(this.startState7);
            this.startStateSelected.Controls.Add(this.startState8);
            this.startStateSelected.Location = new System.Drawing.Point(289, 257);
            this.startStateSelected.Name = "startStateSelected";
            this.startStateSelected.Size = new System.Drawing.Size(238, 239);
            this.startStateSelected.TabIndex = 32;
            this.startStateSelected.TabStop = false;
            this.startStateSelected.Text = "Başlangıç Durum";
            // 
            // startState1
            // 
            this.startState1.Enabled = false;
            this.startState1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startState1.Location = new System.Drawing.Point(29, 32);
            this.startState1.Name = "startState1";
            this.startState1.Size = new System.Drawing.Size(58, 58);
            this.startState1.TabIndex = 11;
            this.startState1.UseVisualStyleBackColor = true;
            // 
            // startState0
            // 
            this.startState0.Enabled = false;
            this.startState0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startState0.Location = new System.Drawing.Point(93, 32);
            this.startState0.Name = "startState0";
            this.startState0.Size = new System.Drawing.Size(58, 58);
            this.startState0.TabIndex = 10;
            this.startState0.UseVisualStyleBackColor = true;
            // 
            // startState2
            // 
            this.startState2.Enabled = false;
            this.startState2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startState2.Location = new System.Drawing.Point(157, 32);
            this.startState2.Name = "startState2";
            this.startState2.Size = new System.Drawing.Size(58, 58);
            this.startState2.TabIndex = 12;
            this.startState2.UseVisualStyleBackColor = true;
            // 
            // startState3
            // 
            this.startState3.Enabled = false;
            this.startState3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startState3.Location = new System.Drawing.Point(29, 96);
            this.startState3.Name = "startState3";
            this.startState3.Size = new System.Drawing.Size(58, 58);
            this.startState3.TabIndex = 13;
            this.startState3.UseVisualStyleBackColor = true;
            // 
            // startState4
            // 
            this.startState4.Enabled = false;
            this.startState4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startState4.Location = new System.Drawing.Point(93, 96);
            this.startState4.Name = "startState4";
            this.startState4.Size = new System.Drawing.Size(58, 58);
            this.startState4.TabIndex = 14;
            this.startState4.UseVisualStyleBackColor = true;
            // 
            // startState5
            // 
            this.startState5.Enabled = false;
            this.startState5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startState5.Location = new System.Drawing.Point(157, 96);
            this.startState5.Name = "startState5";
            this.startState5.Size = new System.Drawing.Size(58, 58);
            this.startState5.TabIndex = 15;
            this.startState5.UseVisualStyleBackColor = true;
            // 
            // startState6
            // 
            this.startState6.Enabled = false;
            this.startState6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startState6.Location = new System.Drawing.Point(29, 160);
            this.startState6.Name = "startState6";
            this.startState6.Size = new System.Drawing.Size(58, 58);
            this.startState6.TabIndex = 16;
            this.startState6.UseVisualStyleBackColor = true;
            // 
            // startState7
            // 
            this.startState7.Enabled = false;
            this.startState7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startState7.Location = new System.Drawing.Point(93, 160);
            this.startState7.Name = "startState7";
            this.startState7.Size = new System.Drawing.Size(58, 58);
            this.startState7.TabIndex = 17;
            this.startState7.UseVisualStyleBackColor = true;
            // 
            // startState8
            // 
            this.startState8.Enabled = false;
            this.startState8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startState8.Location = new System.Drawing.Point(157, 160);
            this.startState8.Name = "startState8";
            this.startState8.Size = new System.Drawing.Size(58, 58);
            this.startState8.TabIndex = 18;
            this.startState8.UseVisualStyleBackColor = true;
            // 
            // startStateCB
            // 
            this.startStateCB.AutoSize = true;
            this.startStateCB.Location = new System.Drawing.Point(12, 12);
            this.startStateCB.Name = "startStateCB";
            this.startStateCB.Size = new System.Drawing.Size(201, 21);
            this.startStateCB.TabIndex = 33;
            this.startStateCB.Text = "Başlangıç Durumu Düzenle";
            this.startStateCB.UseVisualStyleBackColor = true;
            this.startStateCB.CheckedChanged += new System.EventHandler(this.startStateCB_CheckedChanged);
            // 
            // goalStateCB
            // 
            this.goalStateCB.AutoSize = true;
            this.goalStateCB.Location = new System.Drawing.Point(12, 44);
            this.goalStateCB.Name = "goalStateCB";
            this.goalStateCB.Size = new System.Drawing.Size(178, 21);
            this.goalStateCB.TabIndex = 34;
            this.goalStateCB.Text = "Hedef Durumu Düzenle";
            this.goalStateCB.UseVisualStyleBackColor = true;
            this.goalStateCB.CheckedChanged += new System.EventHandler(this.goalStateCB_CheckedChanged);
            // 
            // goalStateSelected
            // 
            this.goalStateSelected.BackColor = System.Drawing.Color.LightCoral;
            this.goalStateSelected.Controls.Add(this.goalState1);
            this.goalStateSelected.Controls.Add(this.goalState0);
            this.goalStateSelected.Controls.Add(this.goalState2);
            this.goalStateSelected.Controls.Add(this.goalState3);
            this.goalStateSelected.Controls.Add(this.goalState4);
            this.goalStateSelected.Controls.Add(this.goalState5);
            this.goalStateSelected.Controls.Add(this.goalState6);
            this.goalStateSelected.Controls.Add(this.goalState7);
            this.goalStateSelected.Controls.Add(this.goalState8);
            this.goalStateSelected.Location = new System.Drawing.Point(533, 257);
            this.goalStateSelected.Name = "goalStateSelected";
            this.goalStateSelected.Size = new System.Drawing.Size(238, 239);
            this.goalStateSelected.TabIndex = 35;
            this.goalStateSelected.TabStop = false;
            this.goalStateSelected.Text = "Hedef Durum";
            // 
            // goalState1
            // 
            this.goalState1.Enabled = false;
            this.goalState1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goalState1.Location = new System.Drawing.Point(29, 32);
            this.goalState1.Name = "goalState1";
            this.goalState1.Size = new System.Drawing.Size(58, 58);
            this.goalState1.TabIndex = 11;
            this.goalState1.UseVisualStyleBackColor = true;
            // 
            // goalState0
            // 
            this.goalState0.Enabled = false;
            this.goalState0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goalState0.Location = new System.Drawing.Point(93, 32);
            this.goalState0.Name = "goalState0";
            this.goalState0.Size = new System.Drawing.Size(58, 58);
            this.goalState0.TabIndex = 10;
            this.goalState0.UseVisualStyleBackColor = true;
            // 
            // goalState2
            // 
            this.goalState2.Enabled = false;
            this.goalState2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goalState2.Location = new System.Drawing.Point(157, 32);
            this.goalState2.Name = "goalState2";
            this.goalState2.Size = new System.Drawing.Size(58, 58);
            this.goalState2.TabIndex = 12;
            this.goalState2.UseVisualStyleBackColor = true;
            // 
            // goalState3
            // 
            this.goalState3.Enabled = false;
            this.goalState3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goalState3.Location = new System.Drawing.Point(29, 96);
            this.goalState3.Name = "goalState3";
            this.goalState3.Size = new System.Drawing.Size(58, 58);
            this.goalState3.TabIndex = 13;
            this.goalState3.UseVisualStyleBackColor = true;
            // 
            // goalState4
            // 
            this.goalState4.Enabled = false;
            this.goalState4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goalState4.Location = new System.Drawing.Point(93, 96);
            this.goalState4.Name = "goalState4";
            this.goalState4.Size = new System.Drawing.Size(58, 58);
            this.goalState4.TabIndex = 14;
            this.goalState4.UseVisualStyleBackColor = true;
            // 
            // goalState5
            // 
            this.goalState5.Enabled = false;
            this.goalState5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goalState5.Location = new System.Drawing.Point(157, 96);
            this.goalState5.Name = "goalState5";
            this.goalState5.Size = new System.Drawing.Size(58, 58);
            this.goalState5.TabIndex = 15;
            this.goalState5.UseVisualStyleBackColor = true;
            // 
            // goalState6
            // 
            this.goalState6.Enabled = false;
            this.goalState6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goalState6.Location = new System.Drawing.Point(29, 160);
            this.goalState6.Name = "goalState6";
            this.goalState6.Size = new System.Drawing.Size(58, 58);
            this.goalState6.TabIndex = 16;
            this.goalState6.UseVisualStyleBackColor = true;
            // 
            // goalState7
            // 
            this.goalState7.Enabled = false;
            this.goalState7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goalState7.Location = new System.Drawing.Point(93, 160);
            this.goalState7.Name = "goalState7";
            this.goalState7.Size = new System.Drawing.Size(58, 58);
            this.goalState7.TabIndex = 17;
            this.goalState7.UseVisualStyleBackColor = true;
            // 
            // goalState8
            // 
            this.goalState8.Enabled = false;
            this.goalState8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goalState8.Location = new System.Drawing.Point(157, 160);
            this.goalState8.Name = "goalState8";
            this.goalState8.Size = new System.Drawing.Size(58, 58);
            this.goalState8.TabIndex = 18;
            this.goalState8.UseVisualStyleBackColor = true;
            // 
            // startStateRefresh
            // 
            this.startStateRefresh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.startStateRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startStateRefresh.Location = new System.Drawing.Point(389, 502);
            this.startStateRefresh.Name = "startStateRefresh";
            this.startStateRefresh.Size = new System.Drawing.Size(51, 45);
            this.startStateRefresh.TabIndex = 36;
            this.startStateRefresh.Text = "🔄";
            this.startStateRefresh.UseVisualStyleBackColor = false;
            this.startStateRefresh.Click += new System.EventHandler(this.button2_Click);
            this.startStateRefresh.MouseHover += new System.EventHandler(this.button2_MouseHover);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(626, 502);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 45);
            this.button2.TabIndex = 37;
            this.button2.Text = "🔄";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            this.button2.MouseHover += new System.EventHandler(this.button2_MouseHover);
            // 
            // stepsLog
            // 
            this.stepsLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stepsLog.Location = new System.Drawing.Point(805, 12);
            this.stepsLog.Name = "stepsLog";
            this.stepsLog.ReadOnly = true;
            this.stepsLog.Size = new System.Drawing.Size(236, 534);
            this.stepsLog.TabIndex = 38;
            this.stepsLog.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1053, 558);
            this.Controls.Add(this.stepsLog);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.startStateRefresh);
            this.Controls.Add(this.goalStateSelected);
            this.Controls.Add(this.goalStateCB);
            this.Controls.Add(this.startStateCB);
            this.Controls.Add(this.startStateSelected);
            this.Controls.Add(this.goalStateGB);
            this.Controls.Add(this.startStateGB);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.startStateGB.ResumeLayout(false);
            this.goalStateGB.ResumeLayout(false);
            this.startStateSelected.ResumeLayout(false);
            this.goalStateSelected.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button startButton0;
        private System.Windows.Forms.Button startButton8;
        private System.Windows.Forms.Button startButton7;
        private System.Windows.Forms.Button startButton6;
        private System.Windows.Forms.Button startButton5;
        private System.Windows.Forms.Button startButton4;
        private System.Windows.Forms.Button startButton3;
        private System.Windows.Forms.Button startButton2;
        private System.Windows.Forms.Button startButton1;
        private System.Windows.Forms.GroupBox startStateGB;
        private System.Windows.Forms.GroupBox goalStateGB;
        private System.Windows.Forms.Button goalButton2;
        private System.Windows.Forms.Button goalButton1;
        private System.Windows.Forms.Button goalButton3;
        private System.Windows.Forms.Button goalButton4;
        private System.Windows.Forms.Button goalButton5;
        private System.Windows.Forms.Button goalButton6;
        private System.Windows.Forms.Button goalButton7;
        private System.Windows.Forms.Button goalButton8;
        private System.Windows.Forms.Button goalButton0;
        private System.Windows.Forms.GroupBox startStateSelected;
        private System.Windows.Forms.Button startState1;
        private System.Windows.Forms.Button startState0;
        private System.Windows.Forms.Button startState2;
        private System.Windows.Forms.Button startState3;
        private System.Windows.Forms.Button startState4;
        private System.Windows.Forms.Button startState5;
        private System.Windows.Forms.Button startState6;
        private System.Windows.Forms.Button startState7;
        private System.Windows.Forms.Button startState8;
        private System.Windows.Forms.CheckBox startStateCB;
        private System.Windows.Forms.CheckBox goalStateCB;
        private System.Windows.Forms.GroupBox goalStateSelected;
        private System.Windows.Forms.Button goalState1;
        private System.Windows.Forms.Button goalState0;
        private System.Windows.Forms.Button goalState2;
        private System.Windows.Forms.Button goalState3;
        private System.Windows.Forms.Button goalState4;
        private System.Windows.Forms.Button goalState5;
        private System.Windows.Forms.Button goalState6;
        private System.Windows.Forms.Button goalState7;
        private System.Windows.Forms.Button goalState8;
        private System.Windows.Forms.Button startStateRefresh;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox stepsLog;
    }
}

