using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace Japanese_tuning
{
    public partial class FormVIP : Form
    {
        public FormVIP()
        {
            InitializeComponent();
        }

        private void FormVIP_Load(object sender, EventArgs e)
        {
            var executablePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            WebVIP.Navigate($@"{executablePath}\Site\Pages\DLC\VIP style.html");
        }
    }
}
