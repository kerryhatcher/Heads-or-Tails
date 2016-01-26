namespace Heads_or_Tails
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
            this.buttonShowHead = new System.Windows.Forms.Button();
            this.buttonShowTail = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.pictureBoxTails = new System.Windows.Forms.PictureBox();
            this.pictureBoxHeads = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeads)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonShowHead
            // 
            this.buttonShowHead.Location = new System.Drawing.Point(54, 220);
            this.buttonShowHead.Name = "buttonShowHead";
            this.buttonShowHead.Size = new System.Drawing.Size(75, 41);
            this.buttonShowHead.TabIndex = 0;
            this.buttonShowHead.Text = "Show Heads";
            this.buttonShowHead.UseVisualStyleBackColor = true;
            this.buttonShowHead.Click += new System.EventHandler(this.buttonShowHead_Click);
            // 
            // buttonShowTail
            // 
            this.buttonShowTail.Location = new System.Drawing.Point(205, 220);
            this.buttonShowTail.Name = "buttonShowTail";
            this.buttonShowTail.Size = new System.Drawing.Size(75, 41);
            this.buttonShowTail.TabIndex = 1;
            this.buttonShowTail.Text = "Show Tails";
            this.buttonShowTail.UseVisualStyleBackColor = true;
            this.buttonShowTail.Click += new System.EventHandler(this.buttonShowTail_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(362, 220);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 41);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // pictureBoxTails
            // 
            this.pictureBoxTails.Image = global::Heads_or_Tails.Properties.Resources.Tails1;
            this.pictureBoxTails.InitialImage = global::Heads_or_Tails.Properties.Resources.Heads1;
            this.pictureBoxTails.Location = new System.Drawing.Point(256, 33);
            this.pictureBoxTails.Name = "pictureBoxTails";
            this.pictureBoxTails.Size = new System.Drawing.Size(181, 159);
            this.pictureBoxTails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTails.TabIndex = 4;
            this.pictureBoxTails.TabStop = false;
            this.pictureBoxTails.Visible = false;
            // 
            // pictureBoxHeads
            // 
            this.pictureBoxHeads.Image = global::Heads_or_Tails.Properties.Resources.Heads1;
            this.pictureBoxHeads.InitialImage = global::Heads_or_Tails.Properties.Resources.Heads1;
            this.pictureBoxHeads.Location = new System.Drawing.Point(54, 33);
            this.pictureBoxHeads.Name = "pictureBoxHeads";
            this.pictureBoxHeads.Size = new System.Drawing.Size(181, 159);
            this.pictureBoxHeads.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHeads.TabIndex = 3;
            this.pictureBoxHeads.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 283);
            this.Controls.Add(this.pictureBoxTails);
            this.Controls.Add(this.pictureBoxHeads);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonShowTail);
            this.Controls.Add(this.buttonShowHead);
            this.Name = "Form1";
            this.Text = "Heads or Tails";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeads)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonShowHead;
        private System.Windows.Forms.Button buttonShowTail;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.PictureBox pictureBoxHeads;
        private System.Windows.Forms.PictureBox pictureBoxTails;
    }
}

