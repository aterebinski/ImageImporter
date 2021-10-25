
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
            this.SuspendLayout();
            // 
            // ConfirmationFormInfoText
            // 
            this.ConfirmationFormInfoText.AutoSize = true;
            this.ConfirmationFormInfoText.Location = new System.Drawing.Point(76, 93);
            this.ConfirmationFormInfoText.Name = "ConfirmationFormInfoText";
            this.ConfirmationFormInfoText.Size = new System.Drawing.Size(378, 20);
            this.ConfirmationFormInfoText.TabIndex = 0;
            this.ConfirmationFormInfoText.Text = "Do you really want to import files to destination folder?";
            // 
            // ConfirmationFormTitle
            // 
            this.ConfirmationFormTitle.AutoSize = true;
            this.ConfirmationFormTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ConfirmationFormTitle.Location = new System.Drawing.Point(204, 45);
            this.ConfirmationFormTitle.Name = "ConfirmationFormTitle";
            this.ConfirmationFormTitle.Size = new System.Drawing.Size(141, 28);
            this.ConfirmationFormTitle.TabIndex = 1;
            this.ConfirmationFormTitle.Text = "Are you sure?";
            // 
            // buttonYes
            // 
            this.buttonYes.Location = new System.Drawing.Point(140, 219);
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.Size = new System.Drawing.Size(94, 29);
            this.buttonYes.TabIndex = 2;
            this.buttonYes.Text = "Yes";
            this.buttonYes.UseVisualStyleBackColor = true;
            // 
            // buttonNo
            // 
            this.buttonNo.Location = new System.Drawing.Point(308, 219);
            this.buttonNo.Name = "buttonNo";
            this.buttonNo.Size = new System.Drawing.Size(94, 29);
            this.buttonNo.TabIndex = 3;
            this.buttonNo.Text = "No";
            this.buttonNo.UseVisualStyleBackColor = true;
            // 
            // ConfirmationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 313);
            this.Controls.Add(this.buttonNo);
            this.Controls.Add(this.buttonYes);
            this.Controls.Add(this.ConfirmationFormTitle);
            this.Controls.Add(this.ConfirmationFormInfoText);
            this.Name = "ConfirmationForm";
            this.Text = "Confirmation";
            this.Load += new System.EventHandler(this.ConfirmationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ConfirmationFormInfoText;
        private System.Windows.Forms.Label ConfirmationFormTitle;
        private System.Windows.Forms.Button buttonYes;
        private System.Windows.Forms.Button buttonNo;
    }
}