using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BatchConverterProfiler;

namespace BatchConverter
{
    public partial class MainForm : Form
    {
        ConverterProfile loaded_profile;
        public MainForm()
        {
            InitializeComponent();
        }
    }
}
