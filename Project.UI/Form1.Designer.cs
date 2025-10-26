namespace Project.UI
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
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LstAuthor = new System.Windows.Forms.ListBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnSoftDelete = new System.Windows.Forms.Button();
            this.BtnHardDelete = new System.Windows.Forms.Button();
            this.BtnActiveEntity = new System.Windows.Forms.Button();
            this.BtnPassiveEntity = new System.Windows.Forms.Button();
            this.BtnUpdatedEntity = new System.Windows.Forms.Button();
            this.BtnAllEntity = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(39, 49);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(100, 22);
            this.TxtName.TabIndex = 0;
            // 
            // LstAuthor
            // 
            this.LstAuthor.FormattingEnabled = true;
            this.LstAuthor.ItemHeight = 16;
            this.LstAuthor.Location = new System.Drawing.Point(314, 49);
            this.LstAuthor.Name = "LstAuthor";
            this.LstAuthor.Size = new System.Drawing.Size(248, 260);
            this.LstAuthor.TabIndex = 1;
            this.LstAuthor.Click += new System.EventHandler(this.LstAuthor_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(39, 109);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(100, 23);
            this.BtnAdd.TabIndex = 2;
            this.BtnAdd.Text = "Ekle";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(39, 151);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(100, 23);
            this.BtnUpdate.TabIndex = 2;
            this.BtnUpdate.Text = "Güncelle";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnSoftDelete
            // 
            this.BtnSoftDelete.Location = new System.Drawing.Point(39, 195);
            this.BtnSoftDelete.Name = "BtnSoftDelete";
            this.BtnSoftDelete.Size = new System.Drawing.Size(100, 23);
            this.BtnSoftDelete.TabIndex = 2;
            this.BtnSoftDelete.Text = "Kaldır";
            this.BtnSoftDelete.UseVisualStyleBackColor = true;
            this.BtnSoftDelete.Click += new System.EventHandler(this.BtnSoftDelete_Click);
            // 
            // BtnHardDelete
            // 
            this.BtnHardDelete.BackColor = System.Drawing.Color.Red;
            this.BtnHardDelete.Location = new System.Drawing.Point(39, 240);
            this.BtnHardDelete.Name = "BtnHardDelete";
            this.BtnHardDelete.Size = new System.Drawing.Size(100, 27);
            this.BtnHardDelete.TabIndex = 3;
            this.BtnHardDelete.Text = "Sil";
            this.BtnHardDelete.UseVisualStyleBackColor = false;
            this.BtnHardDelete.Click += new System.EventHandler(this.BtnHardDelete_Click);
            // 
            // BtnActiveEntity
            // 
            this.BtnActiveEntity.Location = new System.Drawing.Point(314, 334);
            this.BtnActiveEntity.Name = "BtnActiveEntity";
            this.BtnActiveEntity.Size = new System.Drawing.Size(112, 23);
            this.BtnActiveEntity.TabIndex = 4;
            this.BtnActiveEntity.Text = "Aktif Veriler";
            this.BtnActiveEntity.UseVisualStyleBackColor = true;
            this.BtnActiveEntity.Click += new System.EventHandler(this.BtnActiveEntity_Click);
            // 
            // BtnPassiveEntity
            // 
            this.BtnPassiveEntity.Location = new System.Drawing.Point(314, 363);
            this.BtnPassiveEntity.Name = "BtnPassiveEntity";
            this.BtnPassiveEntity.Size = new System.Drawing.Size(112, 23);
            this.BtnPassiveEntity.TabIndex = 4;
            this.BtnPassiveEntity.Text = "PasifVeriler";
            this.BtnPassiveEntity.UseVisualStyleBackColor = true;
            this.BtnPassiveEntity.Click += new System.EventHandler(this.BtnPassiveEntity_Click);
            // 
            // BtnUpdatedEntity
            // 
            this.BtnUpdatedEntity.Location = new System.Drawing.Point(314, 392);
            this.BtnUpdatedEntity.Name = "BtnUpdatedEntity";
            this.BtnUpdatedEntity.Size = new System.Drawing.Size(112, 23);
            this.BtnUpdatedEntity.TabIndex = 4;
            this.BtnUpdatedEntity.Text = "Güncellenmiş Veriler";
            this.BtnUpdatedEntity.UseVisualStyleBackColor = true;
            this.BtnUpdatedEntity.Click += new System.EventHandler(this.BtnUpdatedEntity_Click);
            // 
            // BtnAllEntity
            // 
            this.BtnAllEntity.Location = new System.Drawing.Point(591, 137);
            this.BtnAllEntity.Name = "BtnAllEntity";
            this.BtnAllEntity.Size = new System.Drawing.Size(119, 43);
            this.BtnAllEntity.TabIndex = 4;
            this.BtnAllEntity.Text = "Tüm Veriler";
            this.BtnAllEntity.UseVisualStyleBackColor = true;
            this.BtnAllEntity.Click += new System.EventHandler(this.BtnAllEntity_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnAllEntity);
            this.Controls.Add(this.BtnUpdatedEntity);
            this.Controls.Add(this.BtnPassiveEntity);
            this.Controls.Add(this.BtnActiveEntity);
            this.Controls.Add(this.BtnHardDelete);
            this.Controls.Add(this.BtnSoftDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.LstAuthor);
            this.Controls.Add(this.TxtName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.ListBox LstAuthor;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnSoftDelete;
        private System.Windows.Forms.Button BtnHardDelete;
        private System.Windows.Forms.Button BtnActiveEntity;
        private System.Windows.Forms.Button BtnPassiveEntity;
        private System.Windows.Forms.Button BtnUpdatedEntity;
        private System.Windows.Forms.Button BtnAllEntity;
    }
}

