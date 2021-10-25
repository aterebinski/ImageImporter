using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageImporter
{
    public partial class MainForm : Form
    {
        public static string SourceFolderPath { get; set; }
        public static string DestinationFolderPath { get; set; }




        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonSourceFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog sourceFolderBrowserDialog = new FolderBrowserDialog();
            if (sourceFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                SourceFolderPath = sourceFolderBrowserDialog.SelectedPath;
                textBoxSourceFolder.Text = SourceFolderPath;
            }
                
        }

        private void buttonDestinatonFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog destinationFolderBrowserDialog = new FolderBrowserDialog();
            if(destinationFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                DestinationFolderPath = destinationFolderBrowserDialog.SelectedPath;
                textBoxDestinationFolder.Text = DestinationFolderPath;
            }
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            ConfirmationForm confirmationForm = new ConfirmationForm();
            confirmationForm.Show();
        }
    }
}
