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
            labelA.Text = "A:音楽";
            labelB.Text = "B:アニメ";
            labelC.Text = "C:スポーツ";

        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            if (labelA.Text == "A:音楽")
            {
                listBox1.Items.Add(string.Format("彼は幼い頃から音楽が好きでした。"));
                listBox1.Items.Add(string.Format("音楽はとても楽しく、美しいもので"));
                listBox1.Items.Add(string.Format("音楽には目に見えない力があることも彼は知っていました。"));
                listBox1.Items.Add(string.Format(""));
            }
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            if (labelB.Text == "B:アニメ")
            {
                listBox1.Items.Add(string.Format("彼はアニメが好きでした。"));
                listBox1.Items.Add(string.Format("画面の向こうには人々から好かれるヒーローがいました。"));
                listBox1.Items.Add(string.Format(""));
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            if (labelC.Text == "C:スポーツ")
            {
                listBox1.Items.Add(string.Format("彼はスポーツが好きでした。"));
                listBox1.Items.Add(string.Format(""));              
            }
        }
    }
}
