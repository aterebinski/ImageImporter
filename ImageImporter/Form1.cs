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
    public partial class Form1 : Form
    {
        string sourceFolderPath = null;
        string destinationFolderPath = null;



        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSourceFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog sourceFolderBrowserDialog = new FolderBrowserDialog();
            if (sourceFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                sourceFolderPath = sourceFolderBrowserDialog.SelectedPath;
                textBoxSourceFolder.Text = sourceFolderPath;
            }
                
        }

        private void buttonDestinatonFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog destinationFolderBrowserDialog = new FolderBrowserDialog();
            if(destinationFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                destinationFolderPath = destinationFolderBrowserDialog.SelectedPath;
                textBoxDestinationFolder.Text = destinationFolderPath;
            }
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            
        }
    }
}
