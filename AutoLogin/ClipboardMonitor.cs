using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AutoLogin{
    public partial class ClipboardMonitor : Form
    {
        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool AddClipboardFormatListener(IntPtr hwnd);

        private Timer clipboardTimer;

        public ClipboardMonitor()
        {
            InitializeClipboardMonitor();
        }

        private void InitializeClipboardMonitor()
        {
            // Füge das Clipboard-Änderungsereignis dem Fenster hinzu
            AddClipboardFormatListener(this.Handle);

            // Erstelle und konfiguriere einen Timer
            clipboardTimer = new Timer();
            clipboardTimer.Interval = 500; // Überprüfe alle 500 Millisekunden
            clipboardTimer.Tick += ClipboardTimer_Tick;
            clipboardTimer.Start();
        }

        private void ClipboardTimer_Tick(object sender, EventArgs e)
        {
            // Überprüfe, ob die Zwischenablage Daten enthält
            if (Clipboard.ContainsData(DataFormats.Text))
            {
                // Hier kannst du die Aktion ausführen, die du bei Änderungen in der Zwischenablage durchführen möchtest
                // Zum Beispiel:
                string clipboardText = Clipboard.GetText();
                Console.WriteLine("Neue Zwischenablage-Daten: " + clipboardText);
                // Hier kannst du deine gewünschten Aktionen ausführen, z.B. Event auslösen oder Verarbeitung der Daten
            }
        }

        protected override void WndProc(ref Message m)
        {
            // Überwache das Clipboard-Änderungsereignis
            const int WM_CLIPBOARDUPDATE = 0x031D;
            if (m.Msg == WM_CLIPBOARDUPDATE)
            {
                // Das Clipboard wurde aktualisiert
                // Du kannst hier zusätzliche Aktionen ausführen, falls nötig
                
            }

            base.WndProc(ref m);
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClipboardMonitor));
            this.SuspendLayout();
            // 
            // ClipboardMonitor
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClipboardMonitor";
            this.ResumeLayout(false);
        }
    }
}