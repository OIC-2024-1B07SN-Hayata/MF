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
            labelA.Text = "A:���y";
            labelB.Text = "B:�A�j��";
            labelC.Text = "C:�X�|�[�c";

        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            if (labelA.Text == "A:���y")
            {
                listBox1.Items.Add(string.Format("�ނ͗c�������特�y���D���ł����B"));
                listBox1.Items.Add(string.Format("���y�͂ƂĂ��y�����A���������̂�"));
                listBox1.Items.Add(string.Format("���y�ɂ͖ڂɌ����Ȃ��͂����邱�Ƃ��ނ͒m���Ă��܂����B"));
                listBox1.Items.Add(string.Format(""));
            }
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            if (labelB.Text == "B:�A�j��")
            {
                listBox1.Items.Add(string.Format("�ނ̓A�j�����D���ł����B"));
                listBox1.Items.Add(string.Format("��ʂ̌������ɂ͐l�X����D�����q�[���[�����܂����B"));
                listBox1.Items.Add(string.Format(""));
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            if (labelC.Text == "C:�X�|�[�c")
            {
                listBox1.Items.Add(string.Format("�ނ̓X�|�[�c���D���ł����B"));
                listBox1.Items.Add(string.Format(""));              
            }
        }
    }
}
