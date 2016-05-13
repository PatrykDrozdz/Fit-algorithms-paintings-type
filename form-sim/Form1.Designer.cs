namespace form_sim
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
            this.generator = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.proces = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.clear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.worst = new System.Windows.Forms.RadioButton();
            this.best = new System.Windows.Forms.RadioButton();
            this.first = new System.Windows.Forms.RadioButton();
            this.timerCheck = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // generator
            // 
            this.generator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.generator.Location = new System.Drawing.Point(103, 424);
            this.generator.Name = "generator";
            this.generator.Size = new System.Drawing.Size(77, 55);
            this.generator.TabIndex = 0;
            this.generator.Text = "generuj";
            this.generator.UseVisualStyleBackColor = true;
            this.generator.Click += new System.EventHandler(this.generator_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(7, 493);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "liczba procesów i bloków pamięci:";
            // 
            // proces
            // 
            this.proces.Location = new System.Drawing.Point(228, 492);
            this.proces.Name = "proces";
            this.proces.Size = new System.Drawing.Size(152, 20);
            this.proces.TabIndex = 6;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clear.Location = new System.Drawing.Point(186, 424);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(104, 53);
            this.clear.TabIndex = 9;
            this.clear.Text = "Wyczyść wszystko";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.worst);
            this.groupBox1.Controls.Add(this.best);
            this.groupBox1.Controls.Add(this.first);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(296, 424);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 53);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "typy dopasowań";
            // 
            // worst
            // 
            this.worst.AutoSize = true;
            this.worst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.worst.Location = new System.Drawing.Point(176, 20);
            this.worst.Name = "worst";
            this.worst.Size = new System.Drawing.Size(75, 21);
            this.worst.TabIndex = 2;
            this.worst.TabStop = true;
            this.worst.Text = "worst-fit";
            this.worst.UseVisualStyleBackColor = true;
            // 
            // best
            // 
            this.best.AutoSize = true;
            this.best.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.best.Location = new System.Drawing.Point(97, 20);
            this.best.Name = "best";
            this.best.Size = new System.Drawing.Size(69, 21);
            this.best.TabIndex = 1;
            this.best.TabStop = true;
            this.best.Text = "best-fit";
            this.best.UseVisualStyleBackColor = true;
            // 
            // first
            // 
            this.first.AutoSize = true;
            this.first.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.first.Location = new System.Drawing.Point(19, 20);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(65, 21);
            this.first.TabIndex = 0;
            this.first.TabStop = true;
            this.first.Text = "first-fit";
            this.first.UseVisualStyleBackColor = true;
            // 
            // timerCheck
            // 
            this.timerCheck.AutoSize = true;
            this.timerCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timerCheck.Location = new System.Drawing.Point(2, 424);
            this.timerCheck.Name = "timerCheck";
            this.timerCheck.Size = new System.Drawing.Size(95, 46);
            this.timerCheck.TabIndex = 11;
            this.timerCheck.Text = "time";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(584, 516);
            this.Controls.Add(this.timerCheck);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.proces);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.generator);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 554);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 554);
            this.Name = "Form1";
            this.Text = "Fit algorithms";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generator;
        
        /// //////////////////////////
    
        private int a = 0;
        private int m = 0;
        private int p = 0;
        private int ticks = 0;
        private int temp = 0;

        private string s1;
        private string s2;

        private int[] proc;
        private int[] memor;
        private int[] tabX;
        private int[] tabY;

        /// /////////////////////

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox proces;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton worst;
        private System.Windows.Forms.RadioButton best;
        private System.Windows.Forms.RadioButton first;
        private System.Windows.Forms.Label timerCheck;
    }
}

