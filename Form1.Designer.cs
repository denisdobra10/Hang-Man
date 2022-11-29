namespace HangMan
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
            this.wordLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.headLabel = new System.Windows.Forms.Label();
            this.bodyLabel = new System.Windows.Forms.Label();
            this.legsLabel = new System.Windows.Forms.Label();
            this.leftArmLabel = new System.Windows.Forms.Label();
            this.rightArmLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.triesLeftLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lettersUsedLabel = new System.Windows.Forms.Label();
            this.hangerLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // wordLabel
            // 
            this.wordLabel.AutoSize = true;
            this.wordLabel.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordLabel.Location = new System.Drawing.Point(33, 420);
            this.wordLabel.Name = "wordLabel";
            this.wordLabel.Size = new System.Drawing.Size(127, 44);
            this.wordLabel.TabIndex = 0;
            this.wordLabel.Text = "_ _ _ ";
            this.wordLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hangerLabel);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.rightArmLabel);
            this.groupBox1.Controls.Add(this.leftArmLabel);
            this.groupBox1.Controls.Add(this.legsLabel);
            this.groupBox1.Controls.Add(this.bodyLabel);
            this.groupBox1.Controls.Add(this.headLabel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(99, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 297);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 260);
            this.label2.TabIndex = 0;
            this.label2.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "________";
            // 
            // headLabel
            // 
            this.headLabel.AutoSize = true;
            this.headLabel.Location = new System.Drawing.Point(115, 66);
            this.headLabel.Name = "headLabel";
            this.headLabel.Size = new System.Drawing.Size(22, 40);
            this.headLabel.TabIndex = 2;
            this.headLabel.Text = "/-\\\r\n\\ /";
            // 
            // bodyLabel
            // 
            this.bodyLabel.AutoSize = true;
            this.bodyLabel.Location = new System.Drawing.Point(110, 106);
            this.bodyLabel.Name = "bodyLabel";
            this.bodyLabel.Size = new System.Drawing.Size(33, 40);
            this.bodyLabel.TabIndex = 3;
            this.bodyLabel.Text = "/    \\\r\n\\    /";
            // 
            // legsLabel
            // 
            this.legsLabel.AutoSize = true;
            this.legsLabel.Location = new System.Drawing.Point(99, 146);
            this.legsLabel.Name = "legsLabel";
            this.legsLabel.Size = new System.Drawing.Size(49, 60);
            this.legsLabel.TabIndex = 4;
            this.legsLabel.Text = "   /   \\\r\n  /     \\\r\n /       \\";
            // 
            // leftArmLabel
            // 
            this.leftArmLabel.AutoSize = true;
            this.leftArmLabel.Location = new System.Drawing.Point(77, 105);
            this.leftArmLabel.Name = "leftArmLabel";
            this.leftArmLabel.Size = new System.Drawing.Size(35, 60);
            this.leftArmLabel.TabIndex = 5;
            this.leftArmLabel.Text = "   /--\r\n  /\r\n /";
            // 
            // rightArmLabel
            // 
            this.rightArmLabel.AutoSize = true;
            this.rightArmLabel.Location = new System.Drawing.Point(142, 106);
            this.rightArmLabel.Name = "rightArmLabel";
            this.rightArmLabel.Size = new System.Drawing.Size(33, 60);
            this.rightArmLabel.TabIndex = 6;
            this.rightArmLabel.Text = "--\\\r\n    \\\r\n     \\";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(79, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 60);
            this.label9.TabIndex = 7;
            this.label9.Text = "____   _________\r\n     _______     _______\r\n    _____   ____ ____";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(223, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Lives:";
            // 
            // triesLeftLabel
            // 
            this.triesLeftLabel.AutoSize = true;
            this.triesLeftLabel.Font = new System.Drawing.Font("Old English Text MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.triesLeftLabel.Location = new System.Drawing.Point(223, 35);
            this.triesLeftLabel.Name = "triesLeftLabel";
            this.triesLeftLabel.Size = new System.Drawing.Size(49, 57);
            this.triesLeftLabel.TabIndex = 3;
            this.triesLeftLabel.Text = "0";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(231, 504);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(41, 26);
            this.textBox1.TabIndex = 4;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(188, 547);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Guess Letter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 609);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Letters used:";
            // 
            // lettersUsedLabel
            // 
            this.lettersUsedLabel.AutoSize = true;
            this.lettersUsedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lettersUsedLabel.Location = new System.Drawing.Point(120, 605);
            this.lettersUsedLabel.Name = "lettersUsedLabel";
            this.lettersUsedLabel.Size = new System.Drawing.Size(113, 25);
            this.lettersUsedLabel.TabIndex = 7;
            this.lettersUsedLabel.Text = "a b c d e f ";
            this.lettersUsedLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // hangerLabel
            // 
            this.hangerLabel.AutoSize = true;
            this.hangerLabel.Location = new System.Drawing.Point(119, 44);
            this.hangerLabel.Name = "hangerLabel";
            this.hangerLabel.Size = new System.Drawing.Size(14, 20);
            this.hangerLabel.TabIndex = 8;
            this.hangerLabel.Text = "|";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 654);
            this.Controls.Add(this.lettersUsedLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.triesLeftLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.wordLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HangMan";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label wordLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label rightArmLabel;
        private System.Windows.Forms.Label leftArmLabel;
        private System.Windows.Forms.Label legsLabel;
        private System.Windows.Forms.Label bodyLabel;
        private System.Windows.Forms.Label headLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label triesLeftLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lettersUsedLabel;
        private System.Windows.Forms.Label hangerLabel;
    }
}

