namespace ChuckForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GetJokesBtn = new System.Windows.Forms.Button();
            this.jokeBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // GetJokesBtn
            // 
            this.GetJokesBtn.Location = new System.Drawing.Point(217, 166);
            this.GetJokesBtn.Name = "GetJokesBtn";
            this.GetJokesBtn.Size = new System.Drawing.Size(177, 93);
            this.GetJokesBtn.TabIndex = 0;
            this.GetJokesBtn.Text = "Get Joke";
            this.GetJokesBtn.UseVisualStyleBackColor = true;
            this.GetJokesBtn.Click += new System.EventHandler(this.GetJokesBtn_Click);
            // 
            // jokeBox
            // 
            this.jokeBox.Location = new System.Drawing.Point(268, 320);
            this.jokeBox.Name = "jokeBox";
            this.jokeBox.Size = new System.Drawing.Size(100, 96);
            this.jokeBox.TabIndex = 1;
            this.jokeBox.Text = "Get a joke";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 591);
            this.Controls.Add(this.jokeBox);
            this.Controls.Add(this.GetJokesBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GetJokesBtn;
        private System.Windows.Forms.RichTextBox jokeBox;
    }
}

