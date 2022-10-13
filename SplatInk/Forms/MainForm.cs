using System.Windows.Forms;
using SplatInk.UpdateSystem;
using System.Threading.Tasks;

namespace SplatInk.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
            => Task.Run(() => Updater.CheckForUpdates());
    }
}