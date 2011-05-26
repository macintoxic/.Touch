using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DotTouch
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void Apply_Click(object sender, EventArgs e)
        {
        }

        private void panel1_DragOver(object sender, DragEventArgs e)
        {
            //Cursor.Current = Cursors.Hand;
            object obj = e.Data.GetData(DataFormats.FileDrop);
            if (obj != null)
            {
                string[] fileNames = (string[])obj;

                foreach (string fileName in fileNames)
                {
                    if (dtCreation.Checked)
                    {
                        File.SetCreationTime(fileName, dtCreation.Value);
                    }
                    if (dtModification.Checked)
                    {
                        File.SetLastWriteTime(fileName, dtModification.Value);
                    }

                    if (dtLastAccess.Checked)
                    {
                        File.SetLastWriteTime(fileName, dtLastAccess.Value);
                    }
                }

            }


        }
    }
}
//System.Windows.Forms.DataFormats.FileDrop