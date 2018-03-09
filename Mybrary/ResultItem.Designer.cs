namespace Mybrary
{
    partial class ResultItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.volumeTitle = new System.Windows.Forms.Label();
            this.volumeAuthor = new System.Windows.Forms.Label();
            this.volumeISBN = new System.Windows.Forms.Label();
            this.volumePublisher = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // volumeTitle
            // 
            this.volumeTitle.AutoSize = true;
            this.volumeTitle.Location = new System.Drawing.Point(111, 21);
            this.volumeTitle.Name = "volumeTitle";
            this.volumeTitle.Size = new System.Drawing.Size(30, 13);
            this.volumeTitle.TabIndex = 1;
            this.volumeTitle.Text = "Title:";
            // 
            // volumeAuthor
            // 
            this.volumeAuthor.AutoSize = true;
            this.volumeAuthor.Location = new System.Drawing.Point(111, 85);
            this.volumeAuthor.Name = "volumeAuthor";
            this.volumeAuthor.Size = new System.Drawing.Size(41, 13);
            this.volumeAuthor.TabIndex = 2;
            this.volumeAuthor.Text = "Author:";
            // 
            // volumeISBN
            // 
            this.volumeISBN.AutoSize = true;
            this.volumeISBN.Location = new System.Drawing.Point(373, 21);
            this.volumeISBN.Name = "volumeISBN";
            this.volumeISBN.Size = new System.Drawing.Size(35, 13);
            this.volumeISBN.TabIndex = 3;
            this.volumeISBN.Text = "ISBN:";
            // 
            // volumePublisher
            // 
            this.volumePublisher.AutoSize = true;
            this.volumePublisher.Location = new System.Drawing.Point(373, 85);
            this.volumePublisher.Name = "volumePublisher";
            this.volumePublisher.Size = new System.Drawing.Size(53, 13);
            this.volumePublisher.TabIndex = 4;
            this.volumePublisher.Text = "Publisher:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(114, 102);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(226, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(373, 38);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(155, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(373, 102);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(155, 20);
            this.textBox4.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(547, 66);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 25);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add to Library";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // ResultItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.volumePublisher);
            this.Controls.Add(this.volumeISBN);
            this.Controls.Add(this.volumeAuthor);
            this.Controls.Add(this.volumeTitle);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ResultItem";
            this.Size = new System.Drawing.Size(639, 147);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label volumeTitle;
        private System.Windows.Forms.Label volumeAuthor;
        private System.Windows.Forms.Label volumeISBN;
        private System.Windows.Forms.Label volumePublisher;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnAdd;
    }
}
