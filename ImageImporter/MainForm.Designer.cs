
namespace ImageImporter
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSourceFolder = new System.Windows.Forms.Button();
            this.textBoxSourceFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxSubfolders = new System.Windows.Forms.CheckBox();
            this.checkBoxDeleteImages = new System.Windows.Forms.CheckBox();
            this.textBoxDestinationFolder = new System.Windows.Forms.TextBox();
            this.buttonDestinatonFolder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonImport = new System.Windows.Forms.Button();
            this.progressBarImporting = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.labelFileCounter = new System.Windows.Forms.Label();
            this.SubfoldersNamingConvention = new System.Windows.Forms.ComboBox();
            this.labelNamingConventions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSourceFolder
            // 
            this.buttonSourceFolder.Location = new System.Drawing.Point(584, 74);
            this.buttonSourceFolder.Name = "buttonSourceFolder";
            this.buttonSourceFolder.Size = new System.Drawing.Size(111, 29);
            this.buttonSourceFolder.TabIndex = 0;
            this.buttonSourceFolder.Text = "Browse";
            this.buttonSourceFolder.UseVisualStyleBackColor = true;
            this.buttonSourceFolder.Click += new System.EventHandler(this.buttonSourceFolder_Click);
            // 
            // textBoxSourceFolder
            // 
            this.textBoxSourceFolder.Location = new System.Drawing.Point(141, 74);
            this.textBoxSourceFolder.Name = "textBoxSourceFolder";
            this.textBoxSourceFolder.Size = new System.Drawing.Size(421, 27);
            this.textBoxSourceFolder.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Source:";
            // 
            // checkBoxSubfolders
            // 
            this.checkBoxSubfolders.AutoSize = true;
            this.checkBoxSubfolders.Location = new System.Drawing.Point(141, 107);
            this.checkBoxSubfolders.Name = "checkBoxSubfolders";
            this.checkBoxSubfolders.Size = new System.Drawing.Size(190, 24);
            this.checkBoxSubfolders.TabIndex = 3;
            this.checkBoxSubfolders.Text = "Check source subfolders";
            this.checkBoxSubfolders.UseVisualStyleBackColor = true;
            // 
            // checkBoxDeleteImages
            // 
            this.checkBoxDeleteImages.AutoSize = true;
            this.checkBoxDeleteImages.Location = new System.Drawing.Point(141, 137);
            this.checkBoxDeleteImages.Name = "checkBoxDeleteImages";
            this.checkBoxDeleteImages.Size = new System.Drawing.Size(286, 24);
            this.checkBoxDeleteImages.TabIndex = 4;
            this.checkBoxDeleteImages.Text = "Delete from source folder after import";
            this.checkBoxDeleteImages.UseVisualStyleBackColor = true;
            // 
            // textBoxDestinationFolder
            // 
            this.textBoxDestinationFolder.Location = new System.Drawing.Point(141, 283);
            this.textBoxDestinationFolder.Name = "textBoxDestinationFolder";
            this.textBoxDestinationFolder.Size = new System.Drawing.Size(421, 27);
            this.textBoxDestinationFolder.TabIndex = 5;
            // 
            // buttonDestinatonFolder
            // 
            this.buttonDestinatonFolder.Location = new System.Drawing.Point(584, 283);
            this.buttonDestinatonFolder.Name = "buttonDestinatonFolder";
            this.buttonDestinatonFolder.Size = new System.Drawing.Size(111, 29);
            this.buttonDestinatonFolder.TabIndex = 6;
            this.buttonDestinatonFolder.Text = "Browse";
            this.buttonDestinatonFolder.UseVisualStyleBackColor = true;
            this.buttonDestinatonFolder.Click += new System.EventHandler(this.buttonDestinatonFolder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Destination:";
            // 
            // buttonImport
            // 
            this.buttonImport.Location = new System.Drawing.Point(141, 327);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(94, 29);
            this.buttonImport.TabIndex = 8;
            this.buttonImport.Text = "Import";
            this.buttonImport.UseVisualStyleBackColor = true;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // progressBarImporting
            // 
            this.progressBarImporting.Location = new System.Drawing.Point(12, 409);
            this.progressBarImporting.Name = "progressBarImporting";
            this.progressBarImporting.Size = new System.Drawing.Size(776, 29);
            this.progressBarImporting.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(386, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Files:";
            // 
            // labelFileCounter
            // 
            this.labelFileCounter.AutoSize = true;
            this.labelFileCounter.Location = new System.Drawing.Point(433, 377);
            this.labelFileCounter.Name = "labelFileCounter";
            this.labelFileCounter.Size = new System.Drawing.Size(17, 20);
            this.labelFileCounter.TabIndex = 11;
            this.labelFileCounter.Text = "0";
            // 
            // SubfoldersNamingConvention
            // 
            this.SubfoldersNamingConvention.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SubfoldersNamingConvention.FormattingEnabled = true;
            this.SubfoldersNamingConvention.Items.AddRange(new object[] {
            "Year-Month(number)",
            "Year\\Month(number)"});
            this.SubfoldersNamingConvention.Location = new System.Drawing.Point(141, 217);
            this.SubfoldersNamingConvention.Name = "SubfoldersNamingConvention";
            this.SubfoldersNamingConvention.Size = new System.Drawing.Size(223, 28);
            this.SubfoldersNamingConvention.TabIndex = 12;
            this.SubfoldersNamingConvention.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelNamingConventions
            // 
            this.labelNamingConventions.AutoSize = true;
            this.labelNamingConventions.Location = new System.Drawing.Point(141, 194);
            this.labelNamingConventions.Name = "labelNamingConventions";
            this.labelNamingConventions.Size = new System.Drawing.Size(109, 20);
            this.labelNamingConventions.TabIndex = 13;
            this.labelNamingConventions.Text = "Use subfolders:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelNamingConventions);
            this.Controls.Add(this.SubfoldersNamingConvention);
            this.Controls.Add(this.labelFileCounter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBarImporting);
            this.Controls.Add(this.buttonImport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonDestinatonFolder);
            this.Controls.Add(this.textBoxDestinationFolder);
            this.Controls.Add(this.checkBoxDeleteImages);
            this.Controls.Add(this.checkBoxSubfolders);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSourceFolder);
            this.Controls.Add(this.buttonSourceFolder);
            this.Name = "MainForm";
            this.Text = "Image Importer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSourceFolder;
        private System.Windows.Forms.TextBox textBoxSourceFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxSubfolders;
        private System.Windows.Forms.CheckBox checkBoxDeleteImages;
        private System.Windows.Forms.TextBox textBoxDestinationFolder;
        private System.Windows.Forms.Button buttonDestinatonFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.ProgressBar progressBarImporting;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelFileCounter;
        private System.Windows.Forms.ComboBox SubfoldersNamingConvention;
        private System.Windows.Forms.Label labelNamingConventions;
    }
}

