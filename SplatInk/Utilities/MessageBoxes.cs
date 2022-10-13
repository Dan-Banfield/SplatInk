using System.Windows.Forms;

namespace SplatInk.Utilities
{
    internal static class MessageBoxes
    {
        internal static void 
            ShowInformationMessage(string title, string content)
        {
            MessageBox.Show(content, title, MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        internal static DialogResult
            ShowInformationConfirmation(string title, string content)
        {
            return MessageBox.Show(content, title, MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);
        }

        internal static void
            ShowErrorMessage(string title, string content)
        {
            MessageBox.Show(content, title, MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}