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

        public ConfirmationForm()
        {
            InitializeComponent();
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
            }else if (DestinationFolderPath == null)
            {
                this.Text = "Alert";
                ConfirmationFormTitle.Text = "Alert!";
                ConfirmationFormInfoText.Text = "You haven't choosen destination folder!";
            }else
            {
                importFiles();
                
            }
        }

        private int importFiles()
        {
            DateTime fileCreationTime;
            string fileName;
            string year, month;
            string destinationFolder;

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


            int i = 0;

            this.Text = importedFiles.Length.ToString();

            foreach (var sourceFile in importedFiles)
            {
                if (i < 100)
                {
                    fileCreationTime = System.IO.File.GetCreationTime(sourceFile);
                    year = fileCreationTime.Year.ToString();
                    month = (fileCreationTime.Month + 1).ToString();
                    fileName = Path.GetFileName(sourceFile);

                    ConfirmationFormInfoText.Text = $"Path: {sourceFile}, year: {year}, month: {month}, filename: {fileName}";

                    switch (SelectedSubfolderNamingConvention)
                    {
                        case 0: // Year-Month(number)
                            System.IO.Directory.CreateDirectory($"{DestinationFolderPath}\\{year}-{month}");
                            destinationFolder = $"{DestinationFolderPath}\\{year}-{month}\\{fileName}";
                            System.IO.File.Copy(sourceFile, destinationFolder);
                            break;
                        case 1: // Year\Month(number)
                            System.IO.Directory.CreateDirectory($"{DestinationFolderPath}\\{year}\\{month}");
                            destinationFolder = $"{DestinationFolderPath}\\{year}\\{month}\\{fileName}";
                            System.IO.File.Copy(sourceFile, destinationFolder);
                            break;
                        
                        default:
                            System.IO.Directory.CreateDirectory($"{DestinationFolderPath}\\{year}-{month}");
                            destinationFolder = $"{DestinationFolderPath}\\{year}-{month}\\{fileName}";
                            System.IO.File.Copy(sourceFile, destinationFolder);
                 
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
