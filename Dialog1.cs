using System.Windows.Forms;

namespace SchulungsprojektGit
{
    public class Dialog1 : Form
    {
        public Dialog1()
        {
            Text = "Text für den ersten Dialog  erste Änderung";
            // einer neuer Kommentar im Feature1
            // Ein Commit von auserhalb

            Label lblText = new Label
            {
                Text = Text,
                AutoSize = true,
                Left = 40,
                Top = 30
            };

            Controls.Add(lblText);

            StartPosition = FormStartPosition.CenterParent;
            ClientSize = new System.Drawing.Size(350, 100);
        }
    }
}