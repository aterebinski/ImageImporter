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
    public partial class ConfirmationForm : Form
    {
        public static string SourceFolderPath { get; set; }
        public static string DestinationFolderPath { get; set; }

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

            }
        }
    }
}
