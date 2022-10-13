using System;
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

        internal static float HexToFloat(uint value)
        {
            return BitConverter.
                ToSingle(BitConverter.GetBytes(value), 0);
        }

        internal static uint FloatToHex(float value)
        {
            byte[] buffer = BitConverter.GetBytes(value);
            uint t1 = (uint)buffer[3];
            t1 <<= 8;
            t1 += buffer[2];
            t1 <<= 8;
            t1 += buffer[1];
            t1 <<= 8;
            t1 += buffer[0];
            return t1;
        }
    }
}