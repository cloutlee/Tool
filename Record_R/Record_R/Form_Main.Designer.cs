
namespace Record_R
{
    partial class frmR
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmR));
            this.pelMenu = new System.Windows.Forms.Panel();
            this.pelIgSub = new System.Windows.Forms.Panel();
            this.btnIgSearch = new System.Windows.Forms.Button();
            this.btnIgCreate = new System.Windows.Forms.Button();
            this.btnIg = new System.Windows.Forms.Button();
            this.pelDocSub = new System.Windows.Forms.Panel();
            this.btnDocSearch = new System.Windows.Forms.Button();
            this.btnDocCreate = new System.Windows.Forms.Button();
            this.btnDoc = new System.Windows.Forms.Button();
            this.pelFold = new System.Windows.Forms.Panel();
            this.pbFold = new System.Windows.Forms.PictureBox();
            this.pelTop = new System.Windows.Forms.Panel();
            this.lbPos = new System.Windows.Forms.Label();
            this.pbBig = new System.Windows.Forms.PictureBox();
            this.pbSmall = new System.Windows.Forms.PictureBox();
            this.pbNor = new System.Windows.Forms.PictureBox();
            this.pbCanel = new System.Windows.Forms.PictureBox();
            this.actPel = new System.Windows.Forms.Panel();
            this.pelMenu.SuspendLayout();
            this.pelIgSub.SuspendLayout();
            this.pelDocSub.SuspendLayout();
            this.pelFold.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFold)).BeginInit();
            this.pelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSmall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanel)).BeginInit();
            this.SuspendLayout();
            // 
            // pelMenu
            // 
            this.pelMenu.AutoScroll = true;
            this.pelMenu.BackColor = System.Drawing.Color.RoyalBlue;
            this.pelMenu.Controls.Add(this.pelIgSub);
            this.pelMenu.Controls.Add(this.btnIg);
            this.pelMenu.Controls.Add(this.pelDocSub);
            this.pelMenu.Controls.Add(this.btnDoc);
            this.pelMenu.Controls.Add(this.pelFold);
            this.pelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pelMenu.Location = new System.Drawing.Point(0, 0);
            this.pelMenu.Name = "pelMenu";
            this.pelMenu.Size = new System.Drawing.Size(200, 600);
            this.pelMenu.TabIndex = 0;
            // 
            // pelIgSub
            // 
            this.pelIgSub.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pelIgSub.Controls.Add(this.btnIgSearch);
            this.pelIgSub.Controls.Add(this.btnIgCreate);
            this.pelIgSub.Dock = System.Windows.Forms.DockStyle.Top;
            this.pelIgSub.Location = new System.Drawing.Point(0, 290);
            this.pelIgSub.Name = "pelIgSub";
            this.pelIgSub.Size = new System.Drawing.Size(200, 104);
            this.pelIgSub.TabIndex = 4;
            this.pelIgSub.Visible = false;
            // 
            // btnIgSearch
            // 
            this.btnIgSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIgSearch.FlatAppearance.BorderSize = 0;
            this.btnIgSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIgSearch.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnIgSearch.ForeColor = System.Drawing.Color.Silver;
            this.btnIgSearch.Location = new System.Drawing.Point(0, 50);
            this.btnIgSearch.Name = "btnIgSearch";
            this.btnIgSearch.Padding = new System.Windows.Forms.Padding(70, 0, 0, 0);
            this.btnIgSearch.Size = new System.Drawing.Size(200, 50);
            this.btnIgSearch.TabIndex = 3;
            this.btnIgSearch.Text = "Search";
            this.btnIgSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIgSearch.UseVisualStyleBackColor = true;
            this.btnIgSearch.Click += new System.EventHandler(this.btnIgSearch_Click);
            // 
            // btnIgCreate
            // 
            this.btnIgCreate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIgCreate.FlatAppearance.BorderSize = 0;
            this.btnIgCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIgCreate.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnIgCreate.ForeColor = System.Drawing.Color.Silver;
            this.btnIgCreate.Location = new System.Drawing.Point(0, 0);
            this.btnIgCreate.Name = "btnIgCreate";
            this.btnIgCreate.Padding = new System.Windows.Forms.Padding(70, 0, 0, 0);
            this.btnIgCreate.Size = new System.Drawing.Size(200, 50);
            this.btnIgCreate.TabIndex = 2;
            this.btnIgCreate.Text = "Create";
            this.btnIgCreate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIgCreate.UseVisualStyleBackColor = true;
            this.btnIgCreate.Click += new System.EventHandler(this.btnIgCreate_Click);
            // 
            // btnIg
            // 
            this.btnIg.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIg.FlatAppearance.BorderSize = 0;
            this.btnIg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIg.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnIg.ForeColor = System.Drawing.Color.Silver;
            this.btnIg.Location = new System.Drawing.Point(0, 240);
            this.btnIg.Name = "btnIg";
            this.btnIg.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnIg.Size = new System.Drawing.Size(200, 50);
            this.btnIg.TabIndex = 3;
            this.btnIg.Text = "IG";
            this.btnIg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIg.UseVisualStyleBackColor = true;
            this.btnIg.Click += new System.EventHandler(this.btnIg_Click);
            // 
            // pelDocSub
            // 
            this.pelDocSub.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pelDocSub.Controls.Add(this.btnDocSearch);
            this.pelDocSub.Controls.Add(this.btnDocCreate);
            this.pelDocSub.Dock = System.Windows.Forms.DockStyle.Top;
            this.pelDocSub.Location = new System.Drawing.Point(0, 136);
            this.pelDocSub.Name = "pelDocSub";
            this.pelDocSub.Size = new System.Drawing.Size(200, 104);
            this.pelDocSub.TabIndex = 2;
            this.pelDocSub.Visible = false;
            // 
            // btnDocSearch
            // 
            this.btnDocSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDocSearch.FlatAppearance.BorderSize = 0;
            this.btnDocSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocSearch.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDocSearch.ForeColor = System.Drawing.Color.Silver;
            this.btnDocSearch.Location = new System.Drawing.Point(0, 50);
            this.btnDocSearch.Name = "btnDocSearch";
            this.btnDocSearch.Padding = new System.Windows.Forms.Padding(70, 0, 0, 0);
            this.btnDocSearch.Size = new System.Drawing.Size(200, 50);
            this.btnDocSearch.TabIndex = 3;
            this.btnDocSearch.Text = "Search";
            this.btnDocSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocSearch.UseVisualStyleBackColor = true;
            this.btnDocSearch.Click += new System.EventHandler(this.btnDocSearch_Click);
            // 
            // btnDocCreate
            // 
            this.btnDocCreate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDocCreate.FlatAppearance.BorderSize = 0;
            this.btnDocCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocCreate.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDocCreate.ForeColor = System.Drawing.Color.Silver;
            this.btnDocCreate.Location = new System.Drawing.Point(0, 0);
            this.btnDocCreate.Name = "btnDocCreate";
            this.btnDocCreate.Padding = new System.Windows.Forms.Padding(70, 0, 0, 0);
            this.btnDocCreate.Size = new System.Drawing.Size(200, 50);
            this.btnDocCreate.TabIndex = 2;
            this.btnDocCreate.Text = "Create";
            this.btnDocCreate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocCreate.UseVisualStyleBackColor = true;
            this.btnDocCreate.Click += new System.EventHandler(this.btnDocCreate_Click);
            // 
            // btnDoc
            // 
            this.btnDoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDoc.FlatAppearance.BorderSize = 0;
            this.btnDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoc.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDoc.ForeColor = System.Drawing.Color.Silver;
            this.btnDoc.Location = new System.Drawing.Point(0, 86);
            this.btnDoc.Name = "btnDoc";
            this.btnDoc.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnDoc.Size = new System.Drawing.Size(200, 50);
            this.btnDoc.TabIndex = 2;
            this.btnDoc.Text = "Document";
            this.btnDoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoc.UseVisualStyleBackColor = true;
            this.btnDoc.Click += new System.EventHandler(this.btnDoc_Click);
            // 
            // pelFold
            // 
            this.pelFold.Controls.Add(this.pbFold);
            this.pelFold.Dock = System.Windows.Forms.DockStyle.Top;
            this.pelFold.Location = new System.Drawing.Point(0, 0);
            this.pelFold.Name = "pelFold";
            this.pelFold.Size = new System.Drawing.Size(200, 86);
            this.pelFold.TabIndex = 0;
            // 
            // pbFold
            // 
            this.pbFold.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbFold.Image = ((System.Drawing.Image)(resources.GetObject("pbFold.Image")));
            this.pbFold.Location = new System.Drawing.Point(0, 0);
            this.pbFold.Name = "pbFold";
            this.pbFold.Size = new System.Drawing.Size(200, 86);
            this.pbFold.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFold.TabIndex = 2;
            this.pbFold.TabStop = false;
            // 
            // pelTop
            // 
            this.pelTop.BackColor = System.Drawing.Color.RoyalBlue;
            this.pelTop.Controls.Add(this.lbPos);
            this.pelTop.Controls.Add(this.pbBig);
            this.pelTop.Controls.Add(this.pbSmall);
            this.pelTop.Controls.Add(this.pbNor);
            this.pelTop.Controls.Add(this.pbCanel);
            this.pelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pelTop.Location = new System.Drawing.Point(200, 0);
            this.pelTop.Name = "pelTop";
            this.pelTop.Size = new System.Drawing.Size(793, 86);
            this.pelTop.TabIndex = 1;
            this.pelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pelTop_MouseDown);
            // 
            // lbPos
            // 
            this.lbPos.AutoSize = true;
            this.lbPos.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbPos.ForeColor = System.Drawing.Color.Silver;
            this.lbPos.Location = new System.Drawing.Point(61, 34);
            this.lbPos.Name = "lbPos";
            this.lbPos.Size = new System.Drawing.Size(0, 24);
            this.lbPos.TabIndex = 4;
            // 
            // pbBig
            // 
            this.pbBig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbBig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBig.Image = ((System.Drawing.Image)(resources.GetObject("pbBig.Image")));
            this.pbBig.Location = new System.Drawing.Point(727, 0);
            this.pbBig.Name = "pbBig";
            this.pbBig.Size = new System.Drawing.Size(30, 30);
            this.pbBig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBig.TabIndex = 3;
            this.pbBig.TabStop = false;
            this.pbBig.Click += new System.EventHandler(this.pbBig_Click_1);
            // 
            // pbSmall
            // 
            this.pbSmall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbSmall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSmall.Image = ((System.Drawing.Image)(resources.GetObject("pbSmall.Image")));
            this.pbSmall.Location = new System.Drawing.Point(691, 0);
            this.pbSmall.Name = "pbSmall";
            this.pbSmall.Size = new System.Drawing.Size(30, 30);
            this.pbSmall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSmall.TabIndex = 2;
            this.pbSmall.TabStop = false;
            this.pbSmall.Click += new System.EventHandler(this.pbSmall_Click);
            // 
            // pbNor
            // 
            this.pbNor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbNor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbNor.Image = ((System.Drawing.Image)(resources.GetObject("pbNor.Image")));
            this.pbNor.Location = new System.Drawing.Point(727, 0);
            this.pbNor.Name = "pbNor";
            this.pbNor.Size = new System.Drawing.Size(30, 30);
            this.pbNor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNor.TabIndex = 1;
            this.pbNor.TabStop = false;
            this.pbNor.Visible = false;
            this.pbNor.Click += new System.EventHandler(this.pbNor_Click);
            // 
            // pbCanel
            // 
            this.pbCanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCanel.Image = ((System.Drawing.Image)(resources.GetObject("pbCanel.Image")));
            this.pbCanel.Location = new System.Drawing.Point(763, 0);
            this.pbCanel.Name = "pbCanel";
            this.pbCanel.Size = new System.Drawing.Size(30, 30);
            this.pbCanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCanel.TabIndex = 0;
            this.pbCanel.TabStop = false;
            this.pbCanel.Click += new System.EventHandler(this.pbCanel_Click);
            // 
            // actPel
            // 
            this.actPel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.actPel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actPel.Location = new System.Drawing.Point(200, 86);
            this.actPel.Name = "actPel";
            this.actPel.Size = new System.Drawing.Size(793, 514);
            this.actPel.TabIndex = 2;
            // 
            // frmR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 600);
            this.Controls.Add(this.actPel);
            this.Controls.Add(this.pelTop);
            this.Controls.Add(this.pelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmR";
            this.Text = "Record_R";
            this.pelMenu.ResumeLayout(false);
            this.pelIgSub.ResumeLayout(false);
            this.pelDocSub.ResumeLayout(false);
            this.pelFold.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFold)).EndInit();
            this.pelTop.ResumeLayout(false);
            this.pelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSmall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pelMenu;
        private System.Windows.Forms.Panel pelTop;
        private System.Windows.Forms.Button btnDoc;
        private System.Windows.Forms.Panel pelDocSub;
        private System.Windows.Forms.Button btnDocCreate;
        private System.Windows.Forms.Button btnDocSearch;
        private System.Windows.Forms.Panel actPel;
        private System.Windows.Forms.Panel pelFold;
        private System.Windows.Forms.PictureBox pbFold;
        private System.Windows.Forms.PictureBox pbNor;
        private System.Windows.Forms.PictureBox pbCanel;
        private System.Windows.Forms.PictureBox pbSmall;
        private System.Windows.Forms.PictureBox pbBig;
        private System.Windows.Forms.Panel pelIgSub;
        private System.Windows.Forms.Button btnIgSearch;
        private System.Windows.Forms.Button btnIgCreate;
        private System.Windows.Forms.Button btnIg;
        private System.Windows.Forms.Label lbPos;
    }
}

