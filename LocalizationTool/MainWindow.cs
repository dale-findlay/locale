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

namespace LocalizationTool
{
    public partial class MainWindow : Form
    {
        string langFile;

        public MainWindow()
        {
            InitializeComponent();
            RecalculateFormDimensions();
        }

        /// <summary>
        /// Recalculates and sets, both the dimensions and the position of the window to the center of the screen.
        /// </summary>
        private void RecalculateFormDimensions()
        {
            Rectangle screenRect = Screen.FromControl(this).WorkingArea;
            Size = new Size(screenRect.Width, screenRect.Height);
            Location = new Point(0, 0);

            //Size = new Size(screenRect.Width / 2, screenRect.Height / 2);
            //Location = new Point(screenRect.Width / 2 - (screenRect.Width / 2) / 2, screenRect.Height / 2 - (screenRect.Height / 2) / 2);
        }

        private string ReadFromFile(string fileName)
        {
            using (StreamReader sr = new StreamReader(fileName))
            {
                return sr.ReadToEnd();
            }
        }

        private void openMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if(ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    langFile = ReadFromFile(ofd.FileName);

                    MessageBox.Show(langFile);
                }
            }
        }
    }
}
