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

            listBox1.Items.Add(string.Format("���̕���͂������}�Ȓj�̎q�̕���B"));
            label8.Text = "�j�̎q�̎��I�����Ă��������B";
            labelA.Text ="A:���y";
            labelB.Text ="B:�A�j��";
            labelC.Text ="C:�X�|�[�c";
            
        }
    }
}
