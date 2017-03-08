using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TranslationHelper.Extractors;

namespace TranslationHelper
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            browseWindows.Click += inFileWindows_Click;
            browseAndroid.Click += inFileAndroid_Click;
            browseiOS.Click += inFileiOS_Click;
            extractButton.Click += extractButton_Click;
            outFileButton.Click += outFileButton_Click;
        }

        private void inFileWindows_Click(object sender, System.EventArgs e)
        {
            openFileDialogWindows = new OpenFileDialog();
            if (openFileDialogWindows.ShowDialog() == DialogResult.OK)
            {
                inFileWindows.Text = (openFileDialogWindows.FileName);
            }
        }

        private void inFileAndroid_Click(object sender, System.EventArgs e)
        {
            openFileDialogAndroid = new OpenFileDialog();
            if (openFileDialogAndroid.ShowDialog() == DialogResult.OK)
            {
                inFileAndroid.Text = (openFileDialogAndroid.FileName);
            }
        }

        private void inFileiOS_Click(object sender, System.EventArgs e)
        {
            openFileDialogiOS = new OpenFileDialog();
            if (openFileDialogiOS.ShowDialog() == DialogResult.OK)
            {
                inFileiOS.Text = (openFileDialogiOS.FileName);
            }
        }

        private void outFileButton_Click(object sender, System.EventArgs e)
        {
            outFileDialog = new FolderBrowserDialog();
            if (outFileDialog.ShowDialog() == DialogResult.OK)
            {
                outFilePath.Text = (outFileDialog.SelectedPath + @"\extracted.csv");
            }
        }

        private void extractButton_Click(object sender, System.EventArgs e)
        {
            //load an extractor for each input file
            //use a factory?
            if (String.IsNullOrEmpty(outFilePath.Text))
            {
                MessageBox.Show("Please enter an output file path!");
                return;
            }
            try
            {
                ExtractorFactory exFac = new ExtractorFactory(inFileWindows.Text, inFileAndroid.Text, inFileiOS.Text, outFilePath.Text);
                exFac.ExtractThemStrings();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}