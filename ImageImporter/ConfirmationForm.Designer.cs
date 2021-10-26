
namespace ImageImporter
{
    partial class ConfirmationForm
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
            this.ConfirmationFormInfoText = new System.Windows.Forms.Label();
            this.ConfirmationFormTitle = new System.Windows.Forms.Label();
            this.buttonYes = new System.Windows.Forms.Button();
            this.buttonNo = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ConfirmationFormInfoText
            // 
            this.ConfirmationFormInfoText.Location = new System.Drawing.Point(38, 84);
            this.ConfirmationFormInfoText.Name = "ConfirmationFormInfoText";
            this.ConfirmationFormInfoText.Size = new System.Drawing.Size(487, 105);
            this.ConfirmationFormInfoText.TabIndex = 0;
            this.ConfirmationFormInfoText.Text = "Do you really want to import files to destination folder?";
            this.ConfirmationFormInfoText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // ConfirmationFormTitle
            // 
            this.ConfirmationFormTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ConfirmationFormTitle.Location = new System.Drawing.Point(169, 46);
            this.ConfirmationFormTitle.Name = "ConfirmationFormTitle";
            this.ConfirmationFormTitle.Size = new System.Drawing.Size(242, 28);
            this.ConfirmationFormTitle.TabIndex = 1;
            this.ConfirmationFormTitle.Text = "Are you sure?";
            this.ConfirmationFormTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonYes
            // 
            this.buttonYes.Location = new System.Drawing.Point(128, 219);
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.Size = new System.Drawing.Size(94, 29);
            this.buttonYes.TabIndex = 2;
            this.buttonYes.Text = "Yes";
            this.buttonYes.UseVisualStyleBackColor = true;
            this.buttonYes.Click += new System.EventHandler(this.buttonYes_Click);
            // 
            // buttonNo
            // 
            this.buttonNo.Location = new System.Drawing.Point(328, 219);
            this.buttonNo.Name = "buttonNo";
            this.buttonNo.Size = new System.Drawing.Size(94, 29);
            this.buttonNo.TabIndex = 3;
            this.buttonNo.Text = "No";
            this.buttonNo.UseVisualStyleBackColor = true;
            this.buttonNo.Click += new System.EventHandler(this.buttonNo_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(228, 219);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(94, 29);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // ConfirmationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 313);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonNo);
            this.Controls.Add(this.buttonYes);
            this.Controls.Add(this.ConfirmationFormTitle);
            this.Controls.Add(this.ConfirmationFormInfoText);
            this.Name = "ConfirmationForm";
            this.Text = "Confirmation";
            this.Load += new System.EventHandler(this.ConfirmationForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ConfirmationFormInfoText;
        private System.Windows.Forms.Label ConfirmationFormTitle;
        private System.Windows.Forms.Button buttonYes;
        private System.Windows.Forms.Button buttonNo;
        private System.Windows.Forms.Button buttonOK;
    }
}