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
    public partial class FormKyusha : Form
    {
        public FormKyusha()
        {
            InitializeComponent();
        }

        private void FormKyusha_Load(object sender, EventArgs e)
        {
            var executablePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            WebKyusha.Navigate($@"{executablePath}\Site\Pages\DLC\Kyusha style.html");
        }
    }
}
