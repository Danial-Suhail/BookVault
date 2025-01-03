namespace Island_Boi.Forms
{
    partial class frmBookReview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookReview));
            this.panelBackReview = new System.Windows.Forms.Panel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblRating = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStar10 = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnStar9 = new System.Windows.Forms.Button();
            this.btnStar8 = new System.Windows.Forms.Button();
            this.btnStar7 = new System.Windows.Forms.Button();
            this.btnStar6 = new System.Windows.Forms.Button();
            this.btnStar5 = new System.Windows.Forms.Button();
            this.btnStar4 = new System.Windows.Forms.Button();
            this.btnStar3 = new System.Windows.Forms.Button();
            this.btnStar2 = new System.Windows.Forms.Button();
            this.btnStar1 = new System.Windows.Forms.Button();
            this.pictureBox_Cover = new System.Windows.Forms.PictureBox();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.panelBackReview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Cover)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBackReview
            // 
            this.panelBackReview.AutoScroll = true;
            this.panelBackReview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelBackReview.Controls.Add(this.btnSubmit);
            this.panelBackReview.Controls.Add(this.lblRating);
            this.panelBackReview.Controls.Add(this.label1);
            this.panelBackReview.Controls.Add(this.btnStar10);
            this.panelBackReview.Controls.Add(this.lblTitle);
            this.panelBackReview.Controls.Add(this.btnStar9);
            this.panelBackReview.Controls.Add(this.btnStar8);
            this.panelBackReview.Controls.Add(this.btnStar7);
            this.panelBackReview.Controls.Add(this.btnStar6);
            this.panelBackReview.Controls.Add(this.btnStar5);
            this.panelBackReview.Controls.Add(this.btnStar4);
            this.panelBackReview.Controls.Add(this.btnStar3);
            this.panelBackReview.Controls.Add(this.btnStar2);
            this.panelBackReview.Controls.Add(this.btnStar1);
            this.panelBackReview.Controls.Add(this.pictureBox_Cover);
            this.panelBackReview.Controls.Add(this.lblInstruction);
            this.panelBackReview.Controls.Add(this.lblInfo);
            this.panelBackReview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackReview.Location = new System.Drawing.Point(0, 0);
            this.panelBackReview.Name = "panelBackReview";
            this.panelBackReview.Size = new System.Drawing.Size(800, 450);
            this.panelBackReview.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(182, 364);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(121, 65);
            this.btnSubmit.TabIndex = 214;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblRating
            // 
            this.lblRating.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRating.AutoSize = true;
            this.lblRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRating.ForeColor = System.Drawing.Color.White;
            this.lblRating.Location = new System.Drawing.Point(235, 296);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(0, 24);
            this.lblRating.TabIndex = 213;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(164, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 24);
            this.label1.TabIndex = 212;
            this.label1.Text = "Rating Stars(1-10)";
            // 
            // btnStar10
            // 
            this.btnStar10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStar10.FlatAppearance.BorderSize = 0;
            this.btnStar10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStar10.Image = global::Island_Boi.Properties.Resources.Untitled;
            this.btnStar10.Location = new System.Drawing.Point(429, 224);
            this.btnStar10.Name = "btnStar10";
            this.btnStar10.Size = new System.Drawing.Size(39, 38);
            this.btnStar10.TabIndex = 211;
            this.btnStar10.UseVisualStyleBackColor = true;
            this.btnStar10.Click += new System.EventHandler(this.btnStar10_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(575, 83);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 18);
            this.lblTitle.TabIndex = 210;
            // 
            // btnStar9
            // 
            this.btnStar9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStar9.FlatAppearance.BorderSize = 0;
            this.btnStar9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStar9.Image = global::Island_Boi.Properties.Resources.Untitled;
            this.btnStar9.Location = new System.Drawing.Point(384, 224);
            this.btnStar9.Name = "btnStar9";
            this.btnStar9.Size = new System.Drawing.Size(39, 38);
            this.btnStar9.TabIndex = 209;
            this.btnStar9.UseVisualStyleBackColor = true;
            this.btnStar9.Click += new System.EventHandler(this.btnStar9_Click);
            // 
            // btnStar8
            // 
            this.btnStar8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStar8.FlatAppearance.BorderSize = 0;
            this.btnStar8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStar8.Image = global::Island_Boi.Properties.Resources.Untitled;
            this.btnStar8.Location = new System.Drawing.Point(339, 224);
            this.btnStar8.Name = "btnStar8";
            this.btnStar8.Size = new System.Drawing.Size(39, 38);
            this.btnStar8.TabIndex = 208;
            this.btnStar8.UseVisualStyleBackColor = true;
            this.btnStar8.Click += new System.EventHandler(this.btnStar8_Click);
            // 
            // btnStar7
            // 
            this.btnStar7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStar7.FlatAppearance.BorderSize = 0;
            this.btnStar7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStar7.Image = global::Island_Boi.Properties.Resources.Untitled;
            this.btnStar7.Location = new System.Drawing.Point(294, 224);
            this.btnStar7.Name = "btnStar7";
            this.btnStar7.Size = new System.Drawing.Size(39, 38);
            this.btnStar7.TabIndex = 207;
            this.btnStar7.UseVisualStyleBackColor = true;
            this.btnStar7.Click += new System.EventHandler(this.btnStar7_Click);
            // 
            // btnStar6
            // 
            this.btnStar6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStar6.FlatAppearance.BorderSize = 0;
            this.btnStar6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStar6.Image = global::Island_Boi.Properties.Resources.Untitled;
            this.btnStar6.Location = new System.Drawing.Point(249, 224);
            this.btnStar6.Name = "btnStar6";
            this.btnStar6.Size = new System.Drawing.Size(39, 38);
            this.btnStar6.TabIndex = 206;
            this.btnStar6.UseVisualStyleBackColor = true;
            this.btnStar6.Click += new System.EventHandler(this.btnStar6_Click);
            // 
            // btnStar5
            // 
            this.btnStar5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStar5.FlatAppearance.BorderSize = 0;
            this.btnStar5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStar5.Image = global::Island_Boi.Properties.Resources.Untitled;
            this.btnStar5.Location = new System.Drawing.Point(204, 224);
            this.btnStar5.Name = "btnStar5";
            this.btnStar5.Size = new System.Drawing.Size(39, 38);
            this.btnStar5.TabIndex = 205;
            this.btnStar5.UseVisualStyleBackColor = true;
            this.btnStar5.Click += new System.EventHandler(this.btnStar5_Click);
            // 
            // btnStar4
            // 
            this.btnStar4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStar4.FlatAppearance.BorderSize = 0;
            this.btnStar4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStar4.Image = global::Island_Boi.Properties.Resources.Untitled;
            this.btnStar4.Location = new System.Drawing.Point(157, 224);
            this.btnStar4.Name = "btnStar4";
            this.btnStar4.Size = new System.Drawing.Size(41, 38);
            this.btnStar4.TabIndex = 204;
            this.btnStar4.UseVisualStyleBackColor = true;
            this.btnStar4.Click += new System.EventHandler(this.btnStar4_Click);
            // 
            // btnStar3
            // 
            this.btnStar3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStar3.FlatAppearance.BorderSize = 0;
            this.btnStar3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStar3.Image = global::Island_Boi.Properties.Resources.Untitled;
            this.btnStar3.Location = new System.Drawing.Point(110, 224);
            this.btnStar3.Name = "btnStar3";
            this.btnStar3.Size = new System.Drawing.Size(41, 38);
            this.btnStar3.TabIndex = 203;
            this.btnStar3.UseVisualStyleBackColor = true;
            this.btnStar3.Click += new System.EventHandler(this.btnStar3_Click);
            // 
            // btnStar2
            // 
            this.btnStar2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStar2.FlatAppearance.BorderSize = 0;
            this.btnStar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStar2.Image = global::Island_Boi.Properties.Resources.Untitled;
            this.btnStar2.Location = new System.Drawing.Point(63, 224);
            this.btnStar2.Name = "btnStar2";
            this.btnStar2.Size = new System.Drawing.Size(41, 38);
            this.btnStar2.TabIndex = 202;
            this.btnStar2.UseVisualStyleBackColor = true;
            this.btnStar2.Click += new System.EventHandler(this.btnStar2_Click);
            // 
            // btnStar1
            // 
            this.btnStar1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStar1.FlatAppearance.BorderSize = 0;
            this.btnStar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStar1.Image = global::Island_Boi.Properties.Resources.Untitled;
            this.btnStar1.Location = new System.Drawing.Point(16, 224);
            this.btnStar1.Name = "btnStar1";
            this.btnStar1.Size = new System.Drawing.Size(41, 38);
            this.btnStar1.TabIndex = 201;
            this.btnStar1.UseVisualStyleBackColor = true;
            this.btnStar1.Click += new System.EventHandler(this.btnStar1_Click);
            // 
            // pictureBox_Cover
            // 
            this.pictureBox_Cover.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox_Cover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.pictureBox_Cover.Location = new System.Drawing.Point(487, 106);
            this.pictureBox_Cover.Name = "pictureBox_Cover";
            this.pictureBox_Cover.Size = new System.Drawing.Size(276, 336);
            this.pictureBox_Cover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Cover.TabIndex = 200;
            this.pictureBox_Cover.TabStop = false;
            // 
            // lblInstruction
            // 
            this.lblInstruction.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction.ForeColor = System.Drawing.Color.White;
            this.lblInstruction.Location = new System.Drawing.Point(36, 20);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(101, 20);
            this.lblInstruction.TabIndex = 13;
            this.lblInstruction.Text = "Instructions:";
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(37, 43);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(749, 54);
            this.lblInfo.TabIndex = 12;
            this.lblInfo.Text = resources.GetString("lblInfo.Text");
            // 
            // frmBookReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelBackReview);
            this.Name = "frmBookReview";
            this.Text = "BOOK REVIEW";
            this.panelBackReview.ResumeLayout(false);
            this.panelBackReview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Cover)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBackReview;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.PictureBox pictureBox_Cover;
        private System.Windows.Forms.Button btnStar5;
        private System.Windows.Forms.Button btnStar4;
        private System.Windows.Forms.Button btnStar3;
        private System.Windows.Forms.Button btnStar2;
        private System.Windows.Forms.Button btnStar1;
        private System.Windows.Forms.Button btnStar9;
        private System.Windows.Forms.Button btnStar8;
        private System.Windows.Forms.Button btnStar7;
        private System.Windows.Forms.Button btnStar6;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnStar10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Button btnSubmit;
    }
}