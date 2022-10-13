using GeckoDotNet;
using SplatInk.Utilities;
using System.Windows.Forms;
using SplatInk.UpdateSystem;
using System.Threading.Tasks;

namespace SplatInk.Forms
{
    public partial class MainForm : Form
    {
        #region Instances

        private TCPGecko tcpGecko;

        #endregion

        private uint colourStart = 0x12D28180;

        float coloraR, coloraG, coloraB, coloraA;

        public MainForm()
        {
            InitializeComponent();
        }

        #region Event Handlers

        private void MainForm_Load(object sender, System.EventArgs e)
            => Task.Run(() => Updater.CheckForUpdates());

        private void connectButton_Click(object sender, System.EventArgs e)
            => Connect();

        private void disconnectButton_Click(object sender, System.EventArgs e)
            => Disconnect();

        private void changeInkColourButton_Click(object sender, System.EventArgs e)
            => SetAlphaColour();

        #endregion

        #region Methods

        private void Connect()
        {
            tcpGecko = new
                TCPGecko(wiiUIPAddressTextBox.Text, 7331);

            try { tcpGecko.Connect(); }
            catch
            {
                MessageBoxes.
                    ShowErrorMessage
                    ("Error!", "Failed to connect to the Wii U.");
                return;
            }

            tcpGecko.poke(0x10613C2C, 0x5F476573);
            tcpGecko.poke(0x10613C3C, 0x756C6174);
            tcpGecko.poke(0x10613C4C, 0x68650000);
            tcpGecko.poke(0x10613C88, 0x63650000);

            if (tcpGecko.peek(0x12CDADA0) == 0x000003F2)
                colourStart = colourStart - 0x9000;
            else if (tcpGecko.peek(0x12CE2DA0) == 0x000003F2)
                colourStart = colourStart - 0x1000;
            else if (tcpGecko.peek(0x12CE3DA0) == 0x000003F2)
                return;
            else
            {
                MessageBoxes.ShowErrorMessage
                    ("Error!", "Could not find the Splattershot Jr. in memory. Try using TCPGecko from loadiine.ovh. If that does not work, the tool might need to be updated for a newer version of Splatoon.");

                Disconnect();
                return;
            }

            connectButton.Enabled = false;
            disconnectButton.Enabled = true;
            changeInkColourButton.Enabled = true;
        }

        private void Disconnect()
        {
            tcpGecko.Disconnect();

            connectButton.Enabled = true;
            disconnectButton.Enabled = false;
            changeInkColourButton.Enabled = false;
        }

        private void SetAlphaColour()
        {
            DialogResult result = colourDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                coloraR = colourDialog.Color.R;
                coloraG = colourDialog.Color.G;
                coloraB = colourDialog.Color.B;
                coloraA = colourDialog.Color.A;

                try
                {
                    tcpGecko.poke(colourStart, 
                        MessageBoxes.FloatToHex(coloraR / 256.0F));
                    tcpGecko.poke(colourStart + 0x4, 
                        MessageBoxes.FloatToHex(coloraG / 256.0F));
                    tcpGecko.poke(colourStart + 0x8, 
                        MessageBoxes.FloatToHex(coloraB / 256.0F));
                }
                catch
                {
                    MessageBoxes.
                        ShowErrorMessage("Error!", "Failed to write colours to the game's memory!");
                }

                // AlphaShowBox.BackColor = colourDialog.Color;
            }
        }

        #endregion
    }
}