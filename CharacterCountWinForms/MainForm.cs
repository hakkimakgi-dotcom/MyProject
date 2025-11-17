using System;
using System.Windows.Forms;

namespace CharacterCountWinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            UpdateCounts();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            UpdateCounts();
        }

        private void chkIgnoreSpaces_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCounts();
        }

        private void UpdateCounts()
        {
            string text = txtInput.Text ?? string.Empty;
            int totalChars = text.Length;
            int withoutSpaces = text.Replace(" ", string.Empty).Length;

            if (chkIgnoreSpaces.Checked)
                lblCount.Text = $"Karakter sayısı (boşluk hariç): {withoutSpaces}";
            else
                lblCount.Text = $"Karakter sayısı (boşluk dahil): {totalChars}";

            // ayrıca her iki sayıyı da göstermek isterseniz:
            lblBoth.Text = $"Toplam: {totalChars}  |  Boşluk hariç: {withoutSpaces}";
        }
    }
}