using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Xml.Serialization;
using System.Linq;
using ImageMagick;

namespace BatchConverterProfiler
{
    public partial class MainForm : Form
    {
        // profile settings for the converter
        ConverterProfile profile;
        // info about original image
        MagickImageInfo info_before;
        // original image in ImageMagick
        MagickImage image_before;
        // image in ImageMagick after applying
        // the profile settings
        MagickImage image_after;

        public MainForm()
        {
            InitializeComponent();

            // initializing variables
            info_before = null;
            image_before = null;
            image_after = null;

            // creating empty profile
            profile = new ConverterProfile();

            // initializing form values
            LoadProfileSettings();

            // other visual setup
            bOrderUp.Text = ((char)0x2191).ToString();
            bOrderDown.Text = ((char)0x2193).ToString();
        }

        private void LoadProfileSettings()
        {
            tbContrast.Value = profile.Contrast;
            tbBrightness.Value = profile.Brightness;
            tbTreshold.Value = profile.Treshold;
            tbGamma.Value = profile.Gamma;
            tbNoise.Value = profile.Noise;

            cbTreshold.Checked = profile.DoTreshold;
            cbSharpen.Checked = profile.DoSharpen;
            cbEnhance.Checked = profile.DoEnhance;

            lOrder.ClearSelected();
            lOrder.Items.Clear();
            foreach (string optype in profile.Order)
            {
                lOrder.Items.Add(optype);
            }
        }

        private void tbContrast_ValueChanged(object sender, EventArgs e)
        {
            profile.Contrast = tbContrast.Value;
            tContrast.Value = tbContrast.Value;
            tmrRefresh.Stop();
            tmrRefresh.Start();
        }

        private void tContrast_ValueChanged(object sender, EventArgs e)
        {
            tbContrast.Value = (int)tContrast.Value;
        }

        private void tbBrightness_ValueChanged(object sender, EventArgs e)
        {
            profile.Brightness = tbBrightness.Value;
            tBrightness.Value = tbBrightness.Value;
            tmrRefresh.Stop();
            tmrRefresh.Start();
        }

        private void tBrightness_ValueChanged(object sender, EventArgs e)
        {
            tbBrightness.Value = (int)tBrightness.Value;
        }

        private void tbTreshold_ValueChanged(object sender, EventArgs e)
        {
            profile.Treshold = tbTreshold.Value;
            tTreshold.Value = tbTreshold.Value;
            if (cbTreshold.Checked)
            {
                tmrRefresh.Stop();
                tmrRefresh.Start();
            }
        }

        private void tTreshold_ValueChanged(object sender, EventArgs e)
        {
            tbTreshold.Value = (int)tTreshold.Value;
        }

        private void tbGamma_ValueChanged(object sender, EventArgs e)
        {
            profile.Gamma = tbGamma.Value;
            tGamma.Value = (decimal)tbGamma.Value / 100;
            tmrRefresh.Stop();
            tmrRefresh.Start();
        }

        private void tGamma_ValueChanged(object sender, EventArgs e)
        {
            tbGamma.Value = (int)(tGamma.Value * 100);
        }

        private void tbNoise_ValueChanged(object sender, EventArgs e)
        {
            profile.Noise = tbNoise.Value;
            tNoise.Value = tbNoise.Value;
            tmrRefresh.Stop();
            tmrRefresh.Start();
        }

        private void tNoise_ValueChanged(object sender, EventArgs e)
        {
            tbNoise.Value = (int)tNoise.Value;
        }

        private void cbTreshold_CheckedChanged(object sender, EventArgs e)
        {
            profile.DoTreshold = cbTreshold.Checked;
            tmrRefresh.Stop();
            tmrRefresh.Start();
        }

        private void cbEnhance_CheckedChanged(object sender, EventArgs e)
        {
            profile.DoEnhance = cbEnhance.Checked;
            tmrRefresh.Stop();
            tmrRefresh.Start();
        }

        private void cbSharpen_CheckedChanged(object sender, EventArgs e)
        {
            profile.DoSharpen = cbSharpen.Checked;
            tmrRefresh.Stop();
            tmrRefresh.Start();
        }

        private void MoveItem(int direction)
        {
            if (lOrder.SelectedItem == null || lOrder.SelectedIndex < 0)
            {
                return;
            }

            int newIndex = lOrder.SelectedIndex + direction;

            if (newIndex < 0 || newIndex >= lOrder.Items.Count)
            {
                return;
            }

            object selected = lOrder.SelectedItem;

            lOrder.Items.Remove(selected);
            lOrder.Items.Insert(newIndex, selected);
            lOrder.SetSelected(newIndex, true);

            // Start timer only if something changed
            profile.Order = lOrder.Items.Cast<string>().ToList();
            tmrRefresh.Stop();
            tmrRefresh.Start();
        }

        private void bOrderUp_Click(object sender, EventArgs e)
        {
            MoveItem(-1);
        }

        private void bOrderDown_MouseClick(object sender, MouseEventArgs e)
        {
            MoveItem(1);
        }

        private void bInputChoose_Click(object sender, EventArgs e)
        {
            if(ofdInput.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // show labels in case of error
                lBefore.Visible = true;
                lAfter.Visible = true;

                // try to open the selected file
                info_before = new MagickImageInfo();
                try
                {
                    info_before.Read(ofdInput.FileName);
                }
                catch (MagickErrorException ex)
                {
                    MessageBox.Show("Input file is not an image!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // clear everything, just in case
                    image_before = null;
                    image_after = null;
                    return;
                }

                // read the image and display it in PictureBox
                image_before = new MagickImage();
                image_before.Read(ofdInput.FileName);
                pbBefore.Image = image_before.ToBitmap();
                lBefore.Visible = false;

                // prepare the image after conversion
                // and display it in PictureBox
                // using a backgroundWorker
                backgroundWorker.RunWorkerAsync();
            }
        }

        private void tmrRefresh_Tick(object sender, EventArgs e)
        {
            tmrRefresh.Stop();
            backgroundWorker.RunWorkerAsync();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (sfdProfile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                XmlSerializer writer = new XmlSerializer(typeof(ConverterProfile));
                FileStream fs = (FileStream)sfdProfile.OpenFile();
                writer.Serialize(fs, profile);
            }
        }

        private void bLoad_Click(object sender, EventArgs e)
        {
            if (ofdProfile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // deserialize profile settings
                XmlSerializer reader = new XmlSerializer(typeof(ConverterProfile));
                FileStream fs = (FileStream)ofdProfile.OpenFile();
                profile = (ConverterProfile)(reader.Deserialize(fs));
                LoadProfileSettings();

                // force preview refresh
                tmrRefresh.Stop();
                backgroundWorker.RunWorkerAsync();
            }
        }

        // converting image in background
        private void backgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (image_before != null)
            {
                if (image_after != null && !image_after.IsDisposed)
                {
                    image_after.Dispose();
                }

                try
                {
                    image_after = profile.DoConversion(image_before);
                }
                catch (MagickCorruptImageErrorException ex)
                {
                    MessageBox.Show("An error has occured during while preparing preview image!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (!image_after.IsDisposed)
                    {
                        image_after.Dispose();
                    }
                    image_after = null;
                    return;
                }
            }
        }

        // displaying finished results
        private void backgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if(image_after != null)
            {
                pbAfter.Image = image_after.ToBitmap();
                lAfter.Visible = false;
            }
            else
            {
                if (image_before != null)
                {
                    pbAfter.Image = pbAfter.ErrorImage;
                    lAfter.Visible = false;
                }
            }
        }

    }
}
