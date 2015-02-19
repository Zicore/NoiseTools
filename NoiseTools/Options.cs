using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NoiseTools.PerlinNoise;

namespace NoiseTools
{
    public partial class Options : Form
    {
        public Options(PerlinOptions perlinOptions)
        {
            InitializeComponent();
            PerlinOptions = perlinOptions;
            SetOptions();
        }

        private void SetOptions()
        {
            trackBarRedMin.Value = PerlinOptions.MinRed;
            trackBarRedMax.Value = PerlinOptions.MaxRed;
            trackBarGreenMin.Value = PerlinOptions.MinGreen;
            trackBarGreenMax.Value = PerlinOptions.MaxGreen;
            trackBarBlueMin.Value = PerlinOptions.MinBlue;
            trackBarBlueMax.Value = PerlinOptions.MaxBlue;

            numericGain.Value = (decimal)PerlinOptions.Gain;
            numericLacunarity.Value = (decimal)PerlinOptions.Lacunarity;
            numericOctaves.Value = PerlinOptions.Octaves;
            numericOffset.Value = (decimal)PerlinOptions.Offset;
            numericStep.Value = (decimal)PerlinOptions.PerlinNoiseStep;

            checkBoxRedCosine.Checked = PerlinOptions.UseCosineOnRed;
            checkBoxGreenCosine.Checked = PerlinOptions.UseCosineOnGreen;
            checkBoxBlueCosine.Checked = PerlinOptions.UseCosineOnBlue;

            checkBoxReverseRed.Checked = PerlinOptions.ReverseRed;
            checkBoxReverseGreen.Checked = PerlinOptions.ReverseGreen;
            checkBoxReverseBlue.Checked = PerlinOptions.ReverseBlue;

            numericFactorRed.Value = (decimal)PerlinOptions.FactorRed;
            numericFactorGreen.Value = (decimal)PerlinOptions.FactorGreen;
            numericFactorBlue.Value = (decimal)PerlinOptions.FactorBlue;

            numericWidth.Value = PerlinOptions.Width;
            numericHeight.Value = PerlinOptions.Height;
        }

        private PerlinOptions _perlinOptions;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public PerlinOptions PerlinOptions
        {
            get { return _perlinOptions; }
            set { _perlinOptions = value; }
        }

        private void Options_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Visible = false;
        }

        private void trackBarRedMin_Scroll(object sender, EventArgs e)
        {
            PerlinOptions.MinRed = trackBarRedMin.Value;
            RearangeR(trackBarRedMin, trackBarRedMax);
        }

        private void trackBarRedMax_Scroll(object sender, EventArgs e)
        {
            PerlinOptions.MaxRed = trackBarRedMax.Value;
            Rearange(trackBarRedMin, trackBarRedMax);
        }

        private void trackBarGreenMin_Scroll(object sender, EventArgs e)
        {
            PerlinOptions.MinGreen = trackBarGreenMin.Value;
            RearangeR(trackBarGreenMin, trackBarGreenMax);
        }

        private void trackBarGreenMax_Scroll(object sender, EventArgs e)
        {
            PerlinOptions.MaxGreen = trackBarGreenMax.Value;
            Rearange(trackBarGreenMin, trackBarGreenMax);
        }

        private void trackBarBlueMin_Scroll(object sender, EventArgs e)
        {
            PerlinOptions.MinBlue = trackBarBlueMin.Value;
            RearangeR(trackBarBlueMin, trackBarBlueMax);
        }

        private void trackBarBlueMax_Scroll(object sender, EventArgs e)
        {
            PerlinOptions.MaxBlue = trackBarBlueMax.Value;
            Rearange(trackBarBlueMin, trackBarBlueMax);
        }

        private void checkBoxRedCosine_CheckedChanged(object sender, EventArgs e)
        {
            PerlinOptions.UseCosineOnRed = checkBoxRedCosine.Checked;
        }

        private void checkBoxGreenCosine_CheckedChanged(object sender, EventArgs e)
        {
            PerlinOptions.UseCosineOnGreen = checkBoxGreenCosine.Checked;
        }

        private void checkBoxBlueCosine_CheckedChanged(object sender, EventArgs e)
        {
            PerlinOptions.UseCosineOnBlue = checkBoxBlueCosine.Checked;
        }

        private void Rearange(TrackBar tb1, TrackBar tb2)
        {
            if (tb1.Value > tb2.Value)
                tb1.Value = tb2.Value;
        }

        private void RearangeR(TrackBar tb1, TrackBar tb2)
        {
            if (tb1.Value > tb2.Value)
                tb2.Value = tb1.Value;
        }

        private void numericOctaves_ValueChanged(object sender, EventArgs e)
        {
            PerlinOptions.Octaves = (int)numericOctaves.Value;
        }

        private void numericLacunarity_ValueChanged(object sender, EventArgs e)
        {
            PerlinOptions.Lacunarity = (double)numericLacunarity.Value;
        }

        private void numericGain_ValueChanged(object sender, EventArgs e)
        {
            PerlinOptions.Gain = (double)numericGain.Value;
        }

        private void numericOffset_ValueChanged(object sender, EventArgs e)
        {
            PerlinOptions.Offset = (double)numericOffset.Value;
        }

        private void numericStep_ValueChanged(object sender, EventArgs e)
        {
            PerlinOptions.PerlinNoiseStep = (double)numericStep.Value;
        }

        private void numericColorSeed_ValueChanged(object sender, EventArgs e)
        {
            PerlinOptions.RandomColor = new Random((int)numericColorSeed.Value);
        }

        private void numericNoiseSeed_ValueChanged(object sender, EventArgs e)
        {
            PerlinOptions.RandomNoise = new Random((int)numericNoiseSeed.Value);
        }

        private void checkBoxReverseRed_CheckedChanged(object sender, EventArgs e)
        {
            PerlinOptions.ReverseRed = checkBoxReverseRed.Checked;
        }

        private void checkBoxReverseGreen_CheckedChanged(object sender, EventArgs e)
        {
            PerlinOptions.ReverseGreen = checkBoxReverseGreen.Checked;
        }

        private void checkBoxReverseBlue_CheckedChanged(object sender, EventArgs e)
        {
            PerlinOptions.ReverseBlue = checkBoxReverseBlue.Checked;
        }

        private void numericFactorRed_ValueChanged(object sender, EventArgs e)
        {
            PerlinOptions.FactorRed = (int)numericFactorRed.Value;
        }

        private void numericFactorGreen_ValueChanged(object sender, EventArgs e)
        {
            PerlinOptions.FactorGreen = (int)numericFactorGreen.Value;
        }

        private void numericFactorBlue_ValueChanged(object sender, EventArgs e)
        {
            PerlinOptions.FactorBlue = (int)numericFactorBlue.Value;
        }

        private void numericWidth_ValueChanged(object sender, EventArgs e)
        {
            PerlinOptions.Width = (int)numericWidth.Value;
        }

        private void numericHeight_ValueChanged(object sender, EventArgs e)
        {
            PerlinOptions.Height = (int)numericHeight.Value;
        }

    }
}
