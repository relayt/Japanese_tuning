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
    public partial class FormRocketB : Form
    {
        public FormRocketB()
        {
            InitializeComponent();
            
        }

        private void FormRocketB_Load(object sender, EventArgs e)
        {
            var executablePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            WebRocketB.Navigate($@"{executablePath}\Site\Pages\DLC\Rocket Bunny.html");
        }
    }
}
