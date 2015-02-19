using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NoiseTools
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            optionsDialog = new Options(bufferPanel.PerlinOptions);
        }

        private Options optionsDialog;

        private void noiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bufferPanel.RenderPlanet();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            optionsDialog.Visible = true;
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bufferPanel.Reset();
            bufferPanel.RenderPlanet();
        }

        private void speichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    bufferPanel.Save(saveFileDialog.FileName);
                }
            }
            catch
            {

            }
        }

        private void noiseSquareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bufferPanel.RenderSquare();
        }

        private void MainForm_DoubleClick(object sender, EventArgs e)
        {

        }

        private void bufferPanel_DoubleClick(object sender, EventArgs e)
        {

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                bufferPanel.BackColor = colorDialog.Color;
            }
        }
    }
}
