namespace youtubeApi
{
    partial class DetailScreen
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureAdd = new System.Windows.Forms.PictureBox();
            this.lblDecript = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(358, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // pictureAdd
            // 
            this.pictureAdd.Location = new System.Drawing.Point(234, 51);
            this.pictureAdd.Name = "pictureAdd";
            this.pictureAdd.Size = new System.Drawing.Size(324, 161);
            this.pictureAdd.TabIndex = 2;
            this.pictureAdd.TabStop = false;
            // 
            // lblDecript
            // 
            this.lblDecript.AutoSize = true;
            this.lblDecript.Location = new System.Drawing.Point(341, 225);
            this.lblDecript.Name = "lblDecript";
            this.lblDecript.Size = new System.Drawing.Size(102, 13);
            this.lblDecript.TabIndex = 3;
            this.lblDecript.Text = "Description/Content";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(713, 328);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Link";
            // 
            // DetailScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 364);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblDecript);
            this.Controls.Add(this.pictureAdd);
            this.Controls.Add(this.lblTitle);
            this.Name = "DetailScreen";
            this.Text = "DetailScreen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureAdd;
        private System.Windows.Forms.Label lblDecript;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
    }
}