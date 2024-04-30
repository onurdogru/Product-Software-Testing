namespace B8FCTVer3
{
    partial class FormMessageYesNo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMessageYesNo));
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnNO = new System.Windows.Forms.Button();
            this.picMessage = new System.Windows.Forms.PictureBox();
            this.btnYES = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblMessage.Location = new System.Drawing.Point(188, 20);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(0);
            this.lblMessage.MaximumSize = new System.Drawing.Size(310, 70);
            this.lblMessage.MinimumSize = new System.Drawing.Size(310, 70);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(310, 70);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "Message";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNO
            // 
            this.btnNO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.btnNO.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnNO.FlatAppearance.BorderSize = 0;
            this.btnNO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNO.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnNO.Image = global::B8FCTVer3.Properties.Resources.cross_32x32;
            this.btnNO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNO.Location = new System.Drawing.Point(354, 110);
            this.btnNO.Margin = new System.Windows.Forms.Padding(0);
            this.btnNO.Name = "btnNO";
            this.btnNO.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnNO.Size = new System.Drawing.Size(144, 40);
            this.btnNO.TabIndex = 2;
            this.btnNO.Text = "&HAYIR";
            this.btnNO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNO.UseVisualStyleBackColor = false;
            // 
            // picMessage
            // 
            this.picMessage.Image = global::B8FCTVer3.Properties.Resources.error_128x128;
            this.picMessage.Location = new System.Drawing.Point(20, 20);
            this.picMessage.Margin = new System.Windows.Forms.Padding(0);
            this.picMessage.Name = "picMessage";
            this.picMessage.Size = new System.Drawing.Size(130, 130);
            this.picMessage.TabIndex = 11;
            this.picMessage.TabStop = false;
            // 
            // btnYES
            // 
            this.btnYES.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.btnYES.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnYES.FlatAppearance.BorderSize = 0;
            this.btnYES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYES.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYES.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnYES.Image = global::B8FCTVer3.Properties.Resources.ok_32x32;
            this.btnYES.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYES.Location = new System.Drawing.Point(174, 110);
            this.btnYES.Margin = new System.Windows.Forms.Padding(0);
            this.btnYES.Name = "btnYES";
            this.btnYES.Padding = new System.Windows.Forms.Padding(0, 0, 25, 0);
            this.btnYES.Size = new System.Drawing.Size(136, 40);
            this.btnYES.TabIndex = 1;
            this.btnYES.Text = "&EVET";
            this.btnYES.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYES.UseVisualStyleBackColor = false;
            // 
            // FormMessageYesNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(511, 170);
            this.Controls.Add(this.btnNO);
            this.Controls.Add(this.picMessage);
            this.Controls.Add(this.btnYES);
            this.Controls.Add(this.lblMessage);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormMessageYesNo";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programlama İstasyonu";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnYES;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.PictureBox picMessage;
        private System.Windows.Forms.Button btnNO;
    }
}

