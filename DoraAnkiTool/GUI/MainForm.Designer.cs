namespace DoraAnkiTool.GUI
{
    partial class MainForm
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
            this.questionLabel = new System.Windows.Forms.Label();
            this.answer1Label = new System.Windows.Forms.Label();
            this.answer2Label = new System.Windows.Forms.Label();
            this.answer3Label = new System.Windows.Forms.Label();
            this.answer4Label = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.questionLabel.Location = new System.Drawing.Point(30, 19);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(63, 25);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.Text = "label1";
            // 
            // answer1Label
            // 
            this.answer1Label.AutoSize = true;
            this.answer1Label.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.answer1Label.Location = new System.Drawing.Point(30, 98);
            this.answer1Label.Name = "answer1Label";
            this.answer1Label.Size = new System.Drawing.Size(52, 21);
            this.answer1Label.TabIndex = 5;
            this.answer1Label.Text = "label1";
            this.answer1Label.Click += new System.EventHandler(this.answer1Label_Click);
            // 
            // answer2Label
            // 
            this.answer2Label.AutoSize = true;
            this.answer2Label.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.answer2Label.Location = new System.Drawing.Point(30, 159);
            this.answer2Label.Name = "answer2Label";
            this.answer2Label.Size = new System.Drawing.Size(52, 21);
            this.answer2Label.TabIndex = 6;
            this.answer2Label.Text = "label1";
            this.answer2Label.Click += new System.EventHandler(this.answer2Label_Click);
            // 
            // answer3Label
            // 
            this.answer3Label.AutoSize = true;
            this.answer3Label.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.answer3Label.Location = new System.Drawing.Point(30, 221);
            this.answer3Label.Name = "answer3Label";
            this.answer3Label.Size = new System.Drawing.Size(52, 21);
            this.answer3Label.TabIndex = 7;
            this.answer3Label.Text = "label1";
            this.answer3Label.Click += new System.EventHandler(this.answer3Label_Click);
            // 
            // answer4Label
            // 
            this.answer4Label.AutoSize = true;
            this.answer4Label.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.answer4Label.Location = new System.Drawing.Point(30, 279);
            this.answer4Label.Name = "answer4Label";
            this.answer4Label.Size = new System.Drawing.Size(52, 21);
            this.answer4Label.TabIndex = 8;
            this.answer4Label.Text = "label1";
            this.answer4Label.Click += new System.EventHandler(this.answer4Label_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(30, 333);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(74, 32);
            this.nextButton.TabIndex = 9;
            this.nextButton.Text = "次に進む";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Visible = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.answer4Label);
            this.Controls.Add(this.answer3Label);
            this.Controls.Add(this.answer2Label);
            this.Controls.Add(this.answer1Label);
            this.Controls.Add(this.questionLabel);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Click += new System.EventHandler(this.MainForm_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label questionLabel;
        private Label answer1Label;
        private Label answer2Label;
        private Label answer3Label;
        private Label answer4Label;
        private Button nextButton;
    }
}