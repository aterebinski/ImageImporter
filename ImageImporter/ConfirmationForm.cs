using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageImporter
{
    public partial class ConfirmationForm : Form
    {
        string[] importedFiles;
        List<string> importedFilesList = new List<string>();
        public static string SourceFolderPath { get; set; }
        public static string DestinationFolderPath { get; set; }
        public static int SelectedSubfolderNamingConvention { get; set; }
        public int importedFilesAmount { get; set; }

        public ConfirmationForm()
        {
            InitializeComponent();
            buttonOK.Visible = false;
        }

        private void ConfirmationForm_Load(object sender, EventArgs e)
        {
            SourceFolderPath = MainForm.SourceFolderPath;
            DestinationFolderPath = MainForm.DestinationFolderPath;


            if (SourceFolderPath==null)
            {
                this.Text = "Alert";
                ConfirmationFormTitle.Text = "Alert!";
                ConfirmationFormInfoText.Text = "You haven't choosen source folder!";
                buttonNo.Visible = false;
                buttonYes.Visible = false;
                buttonOK.Visible = true;
            }
            else if (DestinationFolderPath == null)
            {
                this.Text = "Alert";
                ConfirmationFormTitle.Text = "Alert!";
                ConfirmationFormInfoText.Text = "You haven't choosen destination folder!";
                buttonNo.Visible = false;
                buttonYes.Visible = false;
                buttonOK.Visible = true;
            }
            else
            {
                
                importedFiles = System.IO.Directory.GetFiles(SourceFolderPath, "*.jpg");
                importedFilesList.AddRange(importedFiles);
                importedFiles = System.IO.Directory.GetFiles(SourceFolderPath, "*.jpeg");
                importedFilesList.AddRange(importedFiles);
                importedFiles = System.IO.Directory.GetFiles(SourceFolderPath, "*.mp4");
                importedFilesList.AddRange(importedFiles);
                importedFiles = System.IO.Directory.GetFiles(SourceFolderPath, "*.png");
                importedFilesList.AddRange(importedFiles);
                importedFiles = System.IO.Directory.GetFiles(SourceFolderPath, "*.nef");
                importedFilesList.AddRange(importedFiles);
                importedFiles = System.IO.Directory.GetFiles(SourceFolderPath, "*.avi");
                importedFilesList.AddRange(importedFiles);
                importedFiles = System.IO.Directory.GetFiles(SourceFolderPath, "*.bmp");
                importedFilesList.AddRange(importedFiles);
                importedFiles = System.IO.Directory.GetFiles(SourceFolderPath, "*.3gp");
                importedFilesList.AddRange(importedFiles);
                importedFiles = importedFilesList.ToArray();

                importedFilesAmount = importedFiles.Length;

                MainForm.importedFiles = importedFiles;

                ConfirmationFormInfoText.Text = $"There are {importedFilesAmount} images to import. Do you really want to import files to destination folder?";
            }
        }

        

        private void buttonNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            buttonNo.Visible = true;
            buttonYes.Visible = true;
            buttonOK.Visible = false;
            this.Close();
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            //this.Close();
            this.Hide();
            MainForm.importFiles();
            //this.Hide();
        }

    }
}
