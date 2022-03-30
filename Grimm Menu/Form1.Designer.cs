namespace Grimm_Menu
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
            this.mainrtb = new System.Windows.Forms.RichTextBox();
            this.readrtb = new System.Windows.Forms.RichTextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.picturecar = new System.Windows.Forms.PictureBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picturecar)).BeginInit();
            this.SuspendLayout();
            // 
            // mainrtb
            // 
            this.mainrtb.Location = new System.Drawing.Point(21, 22);
            this.mainrtb.Name = "mainrtb";
            this.mainrtb.Size = new System.Drawing.Size(373, 408);
            this.mainrtb.TabIndex = 0;
            this.mainrtb.Text = "";
            // 
            // readrtb
            // 
            this.readrtb.Location = new System.Drawing.Point(418, 22);
            this.readrtb.Name = "readrtb";
            this.readrtb.ReadOnly = true;
            this.readrtb.Size = new System.Drawing.Size(374, 407);
            this.readrtb.TabIndex = 1;
            this.readrtb.Text = "";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(859, 347);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(66, 35);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear Textbox";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // picturecar
            // 
            this.picturecar.Location = new System.Drawing.Point(804, 24);
            this.picturecar.Name = "picturecar";
            this.picturecar.Size = new System.Drawing.Size(146, 130);
            this.picturecar.TabIndex = 5;
            this.picturecar.TabStop = false;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(859, 388);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(66, 35);
            this.btnsave.TabIndex = 8;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(360, 436);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(89, 32);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 467);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.picturecar);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.readrtb);
            this.Controls.Add(this.mainrtb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picturecar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox mainrtb;
        private System.Windows.Forms.RichTextBox readrtb;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox picturecar;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnEdit;
    }
}
