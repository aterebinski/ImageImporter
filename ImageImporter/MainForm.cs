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
    public partial class MainForm : Form
    {
        public static string SourceFolderPath { get; set; }
        public static string DestinationFolderPath { get; set; }
        public static int SelectedSubfolderNamingConvention { get; set; }
        public static bool Overwrite { get; set; }
        public static string[] importedFiles { get; set; }




        public MainForm()
        {
            
            InitializeComponent();
            SubfoldersNamingConvention.SelectedIndex = 0;
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
            Overwrite = checkBoxOverwrite.Checked;
            ConfirmationForm confirmationForm = new ConfirmationForm();
            confirmationForm.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedSubfolderNamingConvention = SubfoldersNamingConvention.SelectedIndex;
        }

        public static int importFiles()
        {
            DateTime fileCreationTime;
            string fileName;
            string year, month;
            string destinationFolder;


            int i = 1;

            foreach (var sourceFile in importedFiles)
            {
                if (i < 100)
                {
                    fileCreationTime = System.IO.File.GetCreationTime(sourceFile);
                    year = fileCreationTime.Year.ToString();
                    month = fileCreationTime.Month.ToString();
                    fileName = Path.GetFileName(sourceFile);

                    //ConfirmationFormInfoText.Text = $"Path: {sourceFile}, year: {year}, month: {month}, filename: {fileName}";

                    

                    switch (SelectedSubfolderNamingConvention)
                    {
                        case 0: // Year-Month(number)
                            System.IO.Directory.CreateDirectory($"{DestinationFolderPath}\\{year}-{month}");
                            destinationFolder = $"{DestinationFolderPath}\\{year}-{month}\\{fileName}";
                            System.IO.File.Copy(sourceFile, destinationFolder, Overwrite);
                            break;
                        case 1: // Year\Month(number)
                            System.IO.Directory.CreateDirectory($"{DestinationFolderPath}\\{year}\\{month}");
                            destinationFolder = $"{DestinationFolderPath}\\{year}\\{month}\\{fileName}";
                            System.IO.File.Copy(sourceFile, destinationFolder, Overwrite);
                            break;
                        default:
                            System.IO.Directory.CreateDirectory($"{DestinationFolderPath}\\{year}-{month}");
                            destinationFolder = $"{DestinationFolderPath}\\{year}-{month}\\{fileName}";
                            System.IO.File.Copy(sourceFile, destinationFolder, Overwrite);
                            break;
                    }



                    //ConfirmationFormInfoText.Text = $"Path: {sourceFile}, year: {year}, month: {month}, filename: {fileName}, destination folder: {destinationFolder} ";
                }
              

                i++;
            }




            return 1;
        }

    }
}
