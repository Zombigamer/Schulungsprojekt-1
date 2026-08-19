using System.Windows.Forms;

namespace SchulungsprojektGit
{
    partial class MainForm
    {
        private Button btnDialog1;
        private Button btnDialog2;
        private Button btnDialog3;
        private Button btnDialog4;

        private void InitializeComponent()
        {
            btnDialog1 = new Button();
            btnDialog2 = new Button();
            btnDialog3 = new Button();
            btnDialog4 = new Button();

            SuspendLayout();

            // btnDialog1
            btnDialog1.Location = new System.Drawing.Point(30, 50);
            btnDialog1.Size = new System.Drawing.Size(100, 30);
            btnDialog1.Text = "Dialog 1";
            btnDialog1.Click += btnDialog1_Click;

            // btnDialog2
            btnDialog2.Location = new System.Drawing.Point(140, 50);
            btnDialog2.Size = new System.Drawing.Size(100, 30);
            btnDialog2.Text = "Dialog 2";
            btnDialog2.Click += btnDialog2_Click;

            // btnDialog3
            btnDialog3.Location = new System.Drawing.Point(250, 50);
            btnDialog3.Size = new System.Drawing.Size(100, 30);
            btnDialog3.Text = "Dialog 3";
            btnDialog3.Click += btnDialog3_Click;

            // btnDialog4
            btnDialog4.Location = new System.Drawing.Point(100, 80);
            btnDialog4.Size = new System.Drawing.Size(100, 30);
            btnDialog4.Text = "Dialog 4";
            btnDialog4.Click += btnDialog3_Click;

            // MainForm
            ClientSize = new System.Drawing.Size(380, 140);
            Controls.Add(btnDialog1);
            Controls.Add(btnDialog2);
            Controls.Add(btnDialog3);
            Controls.Add(btnDialog4);
            Text = "Schulungsprojekt Git";
            StartPosition = FormStartPosition.CenterScreen;

            ResumeLayout(false);
        }
    }
}