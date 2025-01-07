namespace MF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void konnitiwaaa_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            label8.Text = "";
            labelA.Text = "A:";
            labelB.Text = "B:";
            labelC.Text = "C:";

            listBox1.Items.Add(string.Format("この物語はごく平凡な男の子の物語。"));
            label8.Text = "男の子の趣味を選択してください。";
            labelA.Text ="A:音楽";
            labelB.Text ="B:アニメ";
            labelC.Text ="C:スポーツ";
            
        }
    }
}
