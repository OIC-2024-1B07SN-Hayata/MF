namespace MF
{
    public partial class Form1 : Form
    {
        string currentPath = "start";
        string curr;
        string kansu(string curr)
        {

            var storyData = new Dictionary<string, Dictionary<string, string>>
            {
                {"start", new Dictionary<string, string>
                {
                    {"���y", "path1"},
                    {"�A�j��", "path2"},
                    {"�X�|�[�c","path3" }
                }},
                {"path1", new Dictionary<string, string>
                {
                    {"�M�^�[", "path4"},
                    {"�s�A�m", "path5"},
                    {"���R�[�_�[","path6" }
                }},
                {"path2", new Dictionary<string, string>
                {
                    {"�A�j���P", "path7"},
                    {"�A�j���Q", "path8"},
                    {"�A�j���R", "path9"}
                }},
                {"path3",new Dictionary<string, string>
                {
                    {"�X�|�[�c�P","path10"},
                    {"�X�|�[�c�Q","path11" },
                    {"�X�|�[�c�R","path12" }
                }},
                 {"path4", new Dictionary<string, string>
                {
                    {"�y����", "path13"},
                    {"��1", "path14"},
                    {"��2","path15" }
                }}
            };
            string a = storyData[currentPath][curr];
            return a;
            //�����ɂ�if�ŏ������݂����ɂ����Ă�
        }
        void HANDAN()
        {
            if (curr == "���y")
            {
                listBox1.Items.Add(string.Format("�ނ͗c�������特�y���D���ł����B"));
                listBox1.Items.Add(string.Format("���y�͂ƂĂ��y�����A���������̂�"));
                listBox1.Items.Add(string.Format("���y�ɂ͖ڂɌ����Ȃ��͂����邱�Ƃ��ނ͒m���Ă��܂����B"));
                listBox1.Items.Add(string.Format(""));
                buttonA.Text = "�M�^�[";
                buttonB.Text = "�s�A�m";
                buttonC.Text = "���R�[�_�[";
                labelA.Text = "�M�^�[";
                labelB.Text = "�s�A�m";
                labelC.Text = "���R�[�_�[";
                label6.Text = "�����ł��Ȃ��͊y����n�߂邱�Ƃɂ��܂����B";
                label7.Text = "�D���Ȋy���I��ł��������B";
            }
            if (curr == "�A�j��")
            {
                listBox1.Items.Add(string.Format("�ނ̓A�j�����D���ł����B"));
                listBox1.Items.Add(string.Format("��ʂ̌������ɂ͐l�X����D�����q�[���[�����܂����B"));
                listBox1.Items.Add(string.Format(""));
            }
            if (curr == "�X�|�[�c")
            {
                listBox1.Items.Add(string.Format("�ނ̓X�|�[�c���D���ł����B"));
                listBox1.Items.Add(string.Format(""));
            }

            if (curr == "�M�^�[")
            {
                listBox1.Items.Add(string.Format("�ނ͕K���ɃM�^�[�̗��K������"));
                listBox1.Items.Add(string.Format("���K�����Ă���������"));
                listBox1.Items.Add(string.Format("�F��Ȑl�Ɏ����̉��t�𒮂��Ăق����Ǝv���悤�ɂȂ�܂���"));
                listBox1.Items.Add(string.Format(""));
                buttonA.Text = "�y����";
                buttonB.Text = "��1";
                buttonC.Text = "��2";
                labelA.Text = "�y�����ɓ�������LIVE�ɂł�";
                labelB.Text = "��1";
                labelC.Text = "��2";
                label6.Text = "�ǂ�Ȍ`�ŉ��t�������ł����H";
                label7.Text = "���Ȃ��̗��z�Ƃ����ʂ��l���đI��ł�������";
            }
            //�����ɂ��낢��if�����Ă�




        }
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
            curr = buttonA.Text;
            string a = kansu(curr);
            HANDAN();
            currentPath = a;
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            curr = buttonB.Text;
            string a = kansu(curr);
            HANDAN();
            currentPath = a;
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            curr = buttonC.Text;
            string a = kansu(curr);
            HANDAN();
            currentPath = a;
        }
    }
}
