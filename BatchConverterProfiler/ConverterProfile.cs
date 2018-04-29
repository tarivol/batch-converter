using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BatchConverterExtensions;
using ImageMagick;

namespace BatchConverterProfiler
{
    public class ConverterProfile
    {
        enum OperationType
        {
            BrightnessContrast,
            Gamma,
            Treshold,
            Enhance,
            Sharpen,
            NoiseFilter
        }

        private List<OperationType> order;
        private List<string> order_names;
        private int brightness;
        private int contrast;
        private int gamma;
        private bool do_treshold;
        private int treshold;
        private bool do_enhance;
        private bool do_sharpen;
        private int noise;

        public int Brightness
        {
            get
            {
                return brightness;
            }
            set
            {
                if (value.IsBetween(-100, 100))
                {
                    brightness = value;
                }
            }
        }

        public int Contrast
        {
            get
            {
                return contrast;
            }
            set
            {
                if(value.IsBetween(-100, 100))
                {
                    contrast = value;
                }
            }
        }

        public int Gamma
        {
            get
            {
                return gamma;
            }
            set
            {
                if (value.IsBetween(50, 400))
                {
                    gamma = value;
                }
            }
        }

        public int Treshold
        {
            get
            {
                return treshold;
            }
            set
            {
                if (value.IsBetween(0, 100))
                {
                    treshold = value;
                }
            }
        }

        public int Noise
        {
            get
            {
                return noise;
            }
            set
            {
                if (value.IsBetween(0, 4))
                {
                    noise = value;
                }
            }
        }

        public bool DoTreshold
        {
            get
            {
                return do_treshold;
            }
            set
            {
                do_treshold = value;
            }
        }

        public bool DoEnhance
        {
            get
            {
                return do_enhance;
            }
            set
            {
                do_enhance = value;
            }
        }

        public bool DoSharpen
        {
            get
            {
                return do_sharpen;
            }
            set
            {
                do_sharpen = value;
            }
        }

        public List<string> Order
        {
            get
            {
                return order_names;
            }
            set
            {
                order.Clear();
                order_names.Clear();
                foreach(string name in value)
                {
                    switch(name)
                    {
                        case "Brightness/Contrast":
                            order.Add(OperationType.BrightnessContrast);
                            order_names.Add(name);
                            break;
                        case "Treshold":
                            order.Add(OperationType.Treshold);
                            order_names.Add(name);
                            break;
                        case "Gamma":
                            order.Add(OperationType.Gamma);
                            order_names.Add(name);
                            break;
                        case "Enhance":
                            order.Add(OperationType.Enhance);
                            order_names.Add(name);
                            break;
                        case "Sharpen":
                            order.Add(OperationType.Sharpen);
                            order_names.Add(name);
                            break;
                        case "Noise Filter":
                            order.Add(OperationType.NoiseFilter);
                            order_names.Add(name);
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        public ConverterProfile()
        {
            order = new List<OperationType>();
            order_names = new List<string>();
            List<string> tmpList = new List<string>(new string[] { "Brightness/Contrast", "Treshold", "Gamma", "Enhance",
            "Sharpen", "Noise Filter"});
            Order = tmpList;
            Brightness = 0;
            Contrast = 0;
            Gamma = 100;
            DoTreshold = false;
            Treshold = 0;
            DoEnhance = false;
            DoSharpen = false;
            Noise = 0;
        }

        public MagickImage DoConversion(MagickImage input)
        {
            MagickImage output = new MagickImage();

            try
            {
                output = new MagickImage(input.Clone());

                foreach (OperationType optype in this.order)
                {
                    switch (optype)
                    {
                        case OperationType.BrightnessContrast:
                            if ((this.contrast != 0) || (this.brightness != 0))
                            {
                                output.BrightnessContrast((Percentage)brightness, (Percentage)contrast);
                            }
                            break;
                        case OperationType.Treshold:
                            if (do_treshold)
                            {
                                output.Threshold((Percentage)treshold);
                            }
                            break;
                        case OperationType.Gamma:
                            if (((double)gamma / 100) != 1.0)
                            {
                                output.GammaCorrect((double)gamma / 100);
                            }
                            break;
                        case OperationType.Enhance:
                            if (do_enhance)
                            {
                                output.Enhance();
                            }
                            break;
                        case OperationType.Sharpen:
                            if (do_sharpen)
                            {
                                output.Sharpen();
                            }
                            break;
                        case OperationType.NoiseFilter:
                            if (noise > 0)
                            {
                                output.ReduceNoise(noise);
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (MagickCorruptImageErrorException e)
            {
                throw e;
            }
            return output;
        }
    }
}
