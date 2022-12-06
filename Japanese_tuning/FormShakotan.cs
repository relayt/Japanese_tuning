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
    public partial class FormShakotan : Form
    {
        public FormShakotan()
        {
            InitializeComponent();
        }

        private void FormShakotan_Load(object sender, EventArgs e)
        {
            var executablePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            WebShak.Navigate($@"{executablePath}\Site\Pages\DLC\Shakotan.html");
        }
    }
}
