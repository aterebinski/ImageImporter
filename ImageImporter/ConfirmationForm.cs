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
                importedFilesAmount = MainForm.importedFiles.Length;
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
            //this.Hide();
        }

    }
}
