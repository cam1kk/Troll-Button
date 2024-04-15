namespace Troll_Button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Da_Click(object sender, EventArgs e)
        {
            label1.Text = "Spasibo!!!      =)";
            Da.Visible = false;
            Net.Visible = false;
        }

        private void Net_MouseEnter(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int newX = rnd.Next(0, this.ClientSize.Width - Net.Width);
            int newY = rnd.Next(0, this.ClientSize.Height - Net.Height);
            Net.Location = new System.Drawing.Point(newX, newY);
            label1.SendToBack();
        }
    }
}