namespace Belekse_WinForm
{
    public partial class Beleske : Form
    {
        bool zadnjePisanPrviTab = true;

        public Beleske()
        {
            InitializeComponent();
            richTextBox1.Parent = this.tabControl1.TabPages[0];
            richTextBox1.Dock = DockStyle.Fill;
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            tabControl1.Size = new Size(splitContainer1.Panel1.Width, splitContainer1.Panel1.Height);
            tabControl2.Size = new Size(splitContainer1.Panel2.Width, splitContainer1.Panel2.Height);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(zadnjePisanPrviTab)
            {
                TabPage newTabPage = new("New file");
                newTabPage.Name = "New file";

                tabControl1.TabPages.Add(newTabPage);

                RichTextBox newRichTextBox = new();

                tabControl1.SuspendLayout();
                tabControl1.TabPages[tabControl1.TabCount - 1].Controls.Add(newRichTextBox);
                tabControl1.ResumeLayout();

                newRichTextBox.Parent = this.tabControl1.TabPages[tabControl1.TabCount - 1];
                newRichTextBox.Dock = DockStyle.Fill;
            }

            if(!zadnjePisanPrviTab)
            {
                TabPage newTabPage = new("New file");
                newTabPage.Name = "New file";

                tabControl2.TabPages.Add(newTabPage);

                RichTextBox newRichTextBox = new();

                tabControl2.SuspendLayout();
                tabControl2.TabPages[tabControl2.TabCount - 1].Controls.Add(newRichTextBox);
                tabControl2.ResumeLayout();

                newRichTextBox.Parent = this.tabControl2.TabPages[tabControl2.TabCount - 1];
                newRichTextBox.Dock = DockStyle.Fill;
            }
        }

        private void richTextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            zadnjePisanPrviTab = true;
        }

        private void richTextBox2_MouseClick(object sender, MouseEventArgs e)
        {
            zadnjePisanPrviTab = false;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            zadnjePisanPrviTab = true;
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            zadnjePisanPrviTab = false;
        }
    }
}