namespace Island_Boi
{
    partial class frmLibMain
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnBookCheckout = new System.Windows.Forms.Button();
            this.btnBookReview = new System.Windows.Forms.Button();
            this.btnBookISBN = new System.Windows.Forms.Button();
            this.btnBookList = new System.Windows.Forms.Button();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.btnMoveMain = new System.Windows.Forms.Button();
            this.panelTopTitle = new System.Windows.Forms.Panel();
            this.btnSearchButton = new System.Windows.Forms.Button();
            this.txtSearchBar = new System.Windows.Forms.TextBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExpand = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.panelBackground = new System.Windows.Forms.Panel();
            this.panelDisplayForm = new System.Windows.Forms.Panel();
            this.lblUserIntro2 = new System.Windows.Forms.Label();
            this.lblUserIntro1 = new System.Windows.Forms.Label();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMain.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.panelTopTitle.SuspendLayout();
            this.panelDisplayForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(70)))), ((int)(((byte)(125)))));
            this.panelMain.Controls.Add(this.btnBookCheckout);
            this.panelMain.Controls.Add(this.btnBookReview);
            this.panelMain.Controls.Add(this.btnBookISBN);
            this.panelMain.Controls.Add(this.btnBookList);
            this.panelMain.Controls.Add(this.panelTitle);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(220, 557);
            this.panelMain.TabIndex = 0;
            // 
            // btnBookCheckout
            // 
            this.btnBookCheckout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBookCheckout.FlatAppearance.BorderSize = 0;
            this.btnBookCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookCheckout.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookCheckout.ForeColor = System.Drawing.Color.White;
            this.btnBookCheckout.Image = global::Island_Boi.Properties.Resources.BookCheckoutSymbol;
            this.btnBookCheckout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookCheckout.Location = new System.Drawing.Point(0, 260);
            this.btnBookCheckout.Name = "btnBookCheckout";
            this.btnBookCheckout.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnBookCheckout.Size = new System.Drawing.Size(220, 60);
            this.btnBookCheckout.TabIndex = 7;
            this.btnBookCheckout.Text = "   Book Checkout";
            this.btnBookCheckout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookCheckout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBookCheckout.UseVisualStyleBackColor = true;
            this.btnBookCheckout.Click += new System.EventHandler(this.btnBookCheckout_Click);
            // 
            // btnBookReview
            // 
            this.btnBookReview.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBookReview.FlatAppearance.BorderSize = 0;
            this.btnBookReview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookReview.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookReview.ForeColor = System.Drawing.Color.White;
            this.btnBookReview.Image = global::Island_Boi.Properties.Resources.BookReviewSymbol;
            this.btnBookReview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookReview.Location = new System.Drawing.Point(0, 200);
            this.btnBookReview.Name = "btnBookReview";
            this.btnBookReview.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnBookReview.Size = new System.Drawing.Size(220, 60);
            this.btnBookReview.TabIndex = 4;
            this.btnBookReview.Text = "   Book Review";
            this.btnBookReview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookReview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBookReview.UseVisualStyleBackColor = true;
            this.btnBookReview.Click += new System.EventHandler(this.btnBookReview_Click);
            // 
            // btnBookISBN
            // 
            this.btnBookISBN.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBookISBN.FlatAppearance.BorderSize = 0;
            this.btnBookISBN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookISBN.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookISBN.ForeColor = System.Drawing.Color.White;
            this.btnBookISBN.Image = global::Island_Boi.Properties.Resources.BookHistSymbol;
            this.btnBookISBN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookISBN.Location = new System.Drawing.Point(0, 140);
            this.btnBookISBN.Name = "btnBookISBN";
            this.btnBookISBN.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnBookISBN.Size = new System.Drawing.Size(220, 60);
            this.btnBookISBN.TabIndex = 3;
            this.btnBookISBN.Text = "   Book ISBN";
            this.btnBookISBN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookISBN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBookISBN.UseVisualStyleBackColor = true;
            this.btnBookISBN.Click += new System.EventHandler(this.btnBookHistory_Click);
            // 
            // btnBookList
            // 
            this.btnBookList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBookList.FlatAppearance.BorderSize = 0;
            this.btnBookList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookList.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookList.ForeColor = System.Drawing.Color.White;
            this.btnBookList.Image = global::Island_Boi.Properties.Resources.ghjhkjhgjfyujhgkj;
            this.btnBookList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookList.Location = new System.Drawing.Point(0, 80);
            this.btnBookList.Name = "btnBookList";
            this.btnBookList.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnBookList.Size = new System.Drawing.Size(220, 60);
            this.btnBookList.TabIndex = 2;
            this.btnBookList.Text = "   Book List";
            this.btnBookList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBookList.UseVisualStyleBackColor = true;
            this.btnBookList.Click += new System.EventHandler(this.btnBookList_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(54)))), ((int)(((byte)(97)))));
            this.panelTitle.BackgroundImage = global::Island_Boi.Properties.Resources.BookVaultOfficialLogoV2;
            this.panelTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelTitle.Controls.Add(this.btnMoveMain);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(220, 80);
            this.panelTitle.TabIndex = 1;
            // 
            // btnMoveMain
            // 
            this.btnMoveMain.BackColor = System.Drawing.Color.Transparent;
            this.btnMoveMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMoveMain.FlatAppearance.BorderSize = 0;
            this.btnMoveMain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMoveMain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMoveMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveMain.Location = new System.Drawing.Point(0, 0);
            this.btnMoveMain.Name = "btnMoveMain";
            this.btnMoveMain.Size = new System.Drawing.Size(220, 80);
            this.btnMoveMain.TabIndex = 0;
            this.btnMoveMain.UseVisualStyleBackColor = false;
            this.btnMoveMain.Click += new System.EventHandler(this.btnMoveMain_Click);
            // 
            // panelTopTitle
            // 
            this.panelTopTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.panelTopTitle.Controls.Add(this.btnSearchButton);
            this.panelTopTitle.Controls.Add(this.txtSearchBar);
            this.panelTopTitle.Controls.Add(this.btnMinimize);
            this.panelTopTitle.Controls.Add(this.btnExpand);
            this.panelTopTitle.Controls.Add(this.btnClose);
            this.panelTopTitle.Controls.Add(this.lblSubTitle);
            this.panelTopTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopTitle.Location = new System.Drawing.Point(220, 0);
            this.panelTopTitle.Name = "panelTopTitle";
            this.panelTopTitle.Size = new System.Drawing.Size(763, 80);
            this.panelTopTitle.TabIndex = 1;
            this.panelTopTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTopTitle_MouseDown);
            // 
            // btnSearchButton
            // 
            this.btnSearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSearchButton.FlatAppearance.BorderSize = 0;
            this.btnSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchButton.Image = global::Island_Boi.Properties.Resources.Magnifyingiconv3white;
            this.btnSearchButton.Location = new System.Drawing.Point(718, 32);
            this.btnSearchButton.Name = "btnSearchButton";
            this.btnSearchButton.Size = new System.Drawing.Size(40, 19);
            this.btnSearchButton.TabIndex = 5;
            this.btnSearchButton.UseVisualStyleBackColor = false;
            this.btnSearchButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSearchBar
            // 
            this.txtSearchBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(89)))));
            this.txtSearchBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchBar.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtSearchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtSearchBar.Location = new System.Drawing.Point(420, 32);
            this.txtSearchBar.Multiline = true;
            this.txtSearchBar.Name = "txtSearchBar";
            this.txtSearchBar.Size = new System.Drawing.Size(292, 20);
            this.txtSearchBar.TabIndex = 4;
            this.txtSearchBar.Text = "search...";
            this.txtSearchBar.Click += new System.EventHandler(this.txtSearchBar_Click);
            this.txtSearchBar.TextChanged += new System.EventHandler(this.txtSearchBar_TextChanged);
            this.txtSearchBar.Enter += new System.EventHandler(this.txtSearchBar_Enter);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Arial", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(664, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(22, 26);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.Text = "-";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExpand
            // 
            this.btnExpand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExpand.FlatAppearance.BorderSize = 0;
            this.btnExpand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpand.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpand.ForeColor = System.Drawing.Color.White;
            this.btnExpand.Location = new System.Drawing.Point(701, 4);
            this.btnExpand.Name = "btnExpand";
            this.btnExpand.Size = new System.Drawing.Size(18, 23);
            this.btnExpand.TabIndex = 2;
            this.btnExpand.Text = "O";
            this.btnExpand.UseVisualStyleBackColor = true;
            this.btnExpand.Click += new System.EventHandler(this.btnExpand_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(734, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(18, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.ForeColor = System.Drawing.Color.White;
            this.lblSubTitle.Location = new System.Drawing.Point(169, 24);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(102, 34);
            this.lblSubTitle.TabIndex = 0;
            this.lblSubTitle.Text = "WELCOME";
            // 
            // panelBackground
            // 
            this.panelBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(220, 80);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(763, 477);
            this.panelBackground.TabIndex = 3;
            // 
            // panelDisplayForm
            // 
            this.panelDisplayForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelDisplayForm.Controls.Add(this.lblUserIntro2);
            this.panelDisplayForm.Controls.Add(this.lblUserIntro1);
            this.panelDisplayForm.Controls.Add(this.lblSlogan);
            this.panelDisplayForm.Controls.Add(this.pictureBox1);
            this.panelDisplayForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDisplayForm.Location = new System.Drawing.Point(220, 80);
            this.panelDisplayForm.Name = "panelDisplayForm";
            this.panelDisplayForm.Size = new System.Drawing.Size(763, 477);
            this.panelDisplayForm.TabIndex = 4;
            // 
            // lblUserIntro2
            // 
            this.lblUserIntro2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUserIntro2.AutoSize = true;
            this.lblUserIntro2.Font = new System.Drawing.Font("Roboto Mono", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserIntro2.ForeColor = System.Drawing.Color.White;
            this.lblUserIntro2.Location = new System.Drawing.Point(396, 226);
            this.lblUserIntro2.Name = "lblUserIntro2";
            this.lblUserIntro2.Size = new System.Drawing.Size(0, 35);
            this.lblUserIntro2.TabIndex = 3;
            this.lblUserIntro2.Click += new System.EventHandler(this.lblUserIntro2_Click);
            // 
            // lblUserIntro1
            // 
            this.lblUserIntro1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUserIntro1.AutoSize = true;
            this.lblUserIntro1.Font = new System.Drawing.Font("Roboto Mono", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserIntro1.ForeColor = System.Drawing.Color.White;
            this.lblUserIntro1.Location = new System.Drawing.Point(265, 226);
            this.lblUserIntro1.Name = "lblUserIntro1";
            this.lblUserIntro1.Size = new System.Drawing.Size(134, 35);
            this.lblUserIntro1.TabIndex = 2;
            this.lblUserIntro1.Text = "Welcome";
            // 
            // lblSlogan
            // 
            this.lblSlogan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSlogan.AutoSize = true;
            this.lblSlogan.Font = new System.Drawing.Font("Roboto Mono", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlogan.ForeColor = System.Drawing.Color.White;
            this.lblSlogan.Location = new System.Drawing.Point(251, 160);
            this.lblSlogan.Name = "lblSlogan";
            this.lblSlogan.Size = new System.Drawing.Size(335, 15);
            this.lblSlogan.TabIndex = 1;
            this.lblSlogan.Text = "Preserving knowledge, one book at a time|\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Island_Boi.Properties.Resources.bruvvvvv;
            this.pictureBox1.Location = new System.Drawing.Point(18, -76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(701, 417);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmLibMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 557);
            this.Controls.Add(this.panelDisplayForm);
            this.Controls.Add(this.panelBackground);
            this.Controls.Add(this.panelTopTitle);
            this.Controls.Add(this.panelMain);
            this.MinimumSize = new System.Drawing.Size(799, 476);
            this.Name = "frmLibMain";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.frmLibMain_Load);
            this.panelMain.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelTopTitle.ResumeLayout(false);
            this.panelTopTitle.PerformLayout();
            this.panelDisplayForm.ResumeLayout(false);
            this.panelDisplayForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnBookList;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Button btnBookCheckout;
        private System.Windows.Forms.Button btnBookReview;
        private System.Windows.Forms.Button btnBookISBN;
        private System.Windows.Forms.Panel panelTopTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExpand;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtSearchBar;
        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.Panel panelDisplayForm;
        private System.Windows.Forms.Button btnSearchButton;
        private System.Windows.Forms.Button btnMoveMain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSlogan;
        private System.Windows.Forms.Label lblUserIntro2;
        private System.Windows.Forms.Label lblUserIntro1;
    }
}