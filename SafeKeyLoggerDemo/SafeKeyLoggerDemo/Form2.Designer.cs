namespace SafeKeyLoggerDemo
{
    partial class Form2
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
            this.btnToggleLogging = new System.Windows.Forms.Button();
            this.chkConsent = new System.Windows.Forms.CheckBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnToggleLogging
            // 
            this.btnToggleLogging.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnToggleLogging.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnToggleLogging.Location = new System.Drawing.Point(342, 327);
            this.btnToggleLogging.Name = "btnToggleLogging";
            this.btnToggleLogging.Size = new System.Drawing.Size(165, 46);
            this.btnToggleLogging.TabIndex = 0;
            this.btnToggleLogging.Text = "\"Kayıt Başlat\"";
            this.btnToggleLogging.UseVisualStyleBackColor = false;
            // 
            // chkConsent
            // 
            this.chkConsent.AutoSize = true;
            this.chkConsent.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkConsent.Location = new System.Drawing.Point(229, 49);
            this.chkConsent.Name = "chkConsent";
            this.chkConsent.Size = new System.Drawing.Size(278, 26);
            this.chkConsent.TabIndex = 1;
            this.chkConsent.Text = "\"Kayıt yapılmasını onaylıyorum\"";
            this.chkConsent.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblStatus.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStatus.Location = new System.Drawing.Point(371, 393);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(108, 21);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "\"Kayıt: pasif\"";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(229, 102);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInput.Size = new System.Drawing.Size(401, 200);
            this.textBoxInput.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(904, 517);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.chkConsent);
            this.Controls.Add(this.btnToggleLogging);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnToggleLogging;
        private System.Windows.Forms.CheckBox chkConsent;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox textBoxInput;
    }
}