namespace FalloutWordGameHelper
{
    partial class frmGameHelper
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
            this.lstWords = new System.Windows.Forms.ListBox();
            this.btnAddWord = new System.Windows.Forms.Button();
            this.btnBegin = new System.Windows.Forms.Button();
            this.btnSetGuess = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.nudCorrect = new System.Windows.Forms.NumericUpDown();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCorrect)).BeginInit();
            this.SuspendLayout();
            // 
            // lstWords
            // 
            this.lstWords.FormattingEnabled = true;
            this.lstWords.Location = new System.Drawing.Point(442, 26);
            this.lstWords.Name = "lstWords";
            this.lstWords.Size = new System.Drawing.Size(146, 407);
            this.lstWords.TabIndex = 0;
            this.lstWords.SelectedIndexChanged += new System.EventHandler(this.lstWords_SelectedIndexChanged);
            // 
            // btnAddWord
            // 
            this.btnAddWord.Location = new System.Drawing.Point(36, 52);
            this.btnAddWord.Name = "btnAddWord";
            this.btnAddWord.Size = new System.Drawing.Size(75, 23);
            this.btnAddWord.TabIndex = 1;
            this.btnAddWord.Text = "Add Word";
            this.btnAddWord.UseVisualStyleBackColor = true;
            this.btnAddWord.Click += new System.EventHandler(this.btnAddWord_Click);
            // 
            // btnBegin
            // 
            this.btnBegin.Location = new System.Drawing.Point(36, 118);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(75, 23);
            this.btnBegin.TabIndex = 2;
            this.btnBegin.Text = "Begin";
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // btnSetGuess
            // 
            this.btnSetGuess.Location = new System.Drawing.Point(36, 188);
            this.btnSetGuess.Name = "btnSetGuess";
            this.btnSetGuess.Size = new System.Drawing.Size(75, 23);
            this.btnSetGuess.TabIndex = 3;
            this.btnSetGuess.Text = "Set Guess 1";
            this.btnSetGuess.UseVisualStyleBackColor = true;
            this.btnSetGuess.Click += new System.EventHandler(this.btnSetGuess_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(36, 253);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 4;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(139, 52);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(100, 20);
            this.txtWord.TabIndex = 5;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // nudCorrect
            // 
            this.nudCorrect.Location = new System.Drawing.Point(305, 191);
            this.nudCorrect.Name = "nudCorrect";
            this.nudCorrect.Size = new System.Drawing.Size(44, 20);
            this.nudCorrect.TabIndex = 6;
            // 
            // txtGuess
            // 
            this.txtGuess.Enabled = false;
            this.txtGuess.Location = new System.Drawing.Point(139, 190);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.ReadOnly = true;
            this.txtGuess.Size = new System.Drawing.Size(100, 20);
            this.txtGuess.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Guess";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Number of Correct Characters";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 491);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.nudCorrect);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnSetGuess);
            this.Controls.Add(this.btnBegin);
            this.Controls.Add(this.btnAddWord);
            this.Controls.Add(this.lstWords);
            this.Name = "Form1";
            this.Text = "Fallout 3 Hacking Helper";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCorrect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstWords;
        private System.Windows.Forms.Button btnAddWord;
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.Button btnSetGuess;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.NumericUpDown nudCorrect;
    }
}

