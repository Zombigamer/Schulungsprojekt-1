using System.Windows.Forms;

namespace SchulungsprojektGit
{
    public class Dialog3 : Form
    {
        public Dialog3()
        {
            Text = "Text für den dritten Dialog";

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