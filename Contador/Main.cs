using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Contador
{
    public partial class Main : Form
    {

        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifers, int vlc);
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        const int HOTKEY_ID = 1;

        private int KeyCombo = 0;

        public Main()
        {
            InitializeComponent();
        }
        
        
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == HOTKEY_ID)
            {
                int contador = int.Parse(count.Text);
                contador++;
                count.Text = contador.ToString();
            }
            base.WndProc(ref m);
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            Show();
            if (FormWindowState.Minimized == WindowState)
                WindowState = FormWindowState.Normal;
            Activate();
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
                Hide();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnregisterHotKey(this.Handle, 1);
        }

        private void altRB_CheckedChanged(object sender, EventArgs e)
        {
            KeyCombo = 1;
        }

        private void ctrlRB_CheckedChanged(object sender, EventArgs e)
        {
            KeyCombo = 2;
        }

        private void shiftRB_CheckedChanged(object sender, EventArgs e)
        {
            KeyCombo = 4;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            RegisterHotKey(this.Handle, HOTKEY_ID, KeyCombo, txtTecla.Text.ToUpper().ToCharArray()[0]);
        }
    }
}
