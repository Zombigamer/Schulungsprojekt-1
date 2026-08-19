using System.Windows.Forms;

namespace SchulungsprojektGit
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnDialog1_Click(object sender, System.EventArgs e)
        {
            new Dialog1().ShowDialog();
        }

        private void btnDialog2_Click(object sender, System.EventArgs e)
        {
            new Dialog2().ShowDialog();
        }

        private void btnDialog3_Click(object sender, System.EventArgs e)
        {
            new Dialog3().ShowDialog();
        }
        private void btnDialog4_Click(object sender, System.EventArgs e)
        {
            new Dialog3().ShowDialog();
        }
    }
}