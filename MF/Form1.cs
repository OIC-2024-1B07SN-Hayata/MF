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
                    {"����q�[���[", "path7"},
                    {"�X�[�p�[�q�[���[", "path8"},
                    {"�_�[�N�q�[���[", "path9"}
                }},
                {"path3",new Dictionary<string, string>
                {
                    {"�싅","path10"},
                    {"���j","path11" },
                    {"�e�j�X","path12" }
                }},
                 {"path4", new Dictionary<string, string>
                {
                    {"�y����", "path13"},
                    {"��1", "path14"},
                    {"��2","path15" }
                }},
                 {"path5",new Dictionary<string, string>
                {
                    {"�R�����","path16"},
                    {"���₩�ȋ�","path17" },
                    {"���u�\���O","path18" }
                }},
                 {"path6",new Dictionary<string, string>
                {
                    {"���y�C�x���g","path19"},
                    {"�F�B�Ɖ��t","path20" },
                    {"�T�[�N��","path21" }
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
                buttonA.Text = "����q�[���[";
                buttonB.Text = "�X�[�p�[�q�[���[";
                buttonC.Text = "�_�[�N�q�[���[";
                labelA.Text = "����q�[���[";
                labelB.Text = "�X�[�p�[�q�[���[";
                labelC.Text = "�_�[�N�q�[���[";
                label6.Text = "���Ȃ��͂��̃q�[���[�ɓ���܂����B";
                label7.Text = "���ꂽ�q�[���[��I��ł��������B";
            }
            if (curr == "�X�|�[�c")
            {
                listBox1.Items.Add(string.Format("�ނ̓X�|�[�c���D���ł����B"));
                listBox1.Items.Add(string.Format(""));
                buttonA.Text = "�싅";
                buttonB.Text = "���j";
                buttonC.Text = "�e�j�X";
                labelA.Text = "�싅";
                labelB.Text = "���j";
                labelC.Text = "�e�j�X";
                label6.Text = "����̂��D�����������Ȃ��͒��킷�邱�Ƃɂ��܂����B";
                label7.Text = "�D���ȃX�|�[�c��I��ł��������B";
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
            if (curr == "�s�A�m")
            {
                listBox1.Items.Add(string.Format("�ނ͗��K�����Ă���������"));                
                listBox1.Items.Add(string.Format("�����ŋȂ���肽���Ǝv���悤�ɂȂ�܂����B"));
                listBox1.Items.Add(string.Format(""));
                buttonA.Text = "�R�����";
                buttonB.Text = "���₩�ȋ�";
                buttonC.Text = "���u�\���O";
                labelA.Text = "�͂��݂Ȃ����Ă���悤�ȔR�����";
                labelB.Text = "�����ł��ĈԂ߂Ă����悤�ȉ��₩�ȋ�";
                labelC.Text = "�t������v���o���悤�ȃ��u�\���O";
                label6.Text = "�ǂ�ȋȂ���肽���ł����H";
                label7.Text = "���Ȃ��̗��z�Ƃ����ʂ��l���đI��ł�������";
            }
            if (curr == "���R�[�_�[")
            {
                listBox1.Items.Add(string.Format("�ނ͉�������ɂ��܂��Ă������R�[�_�[���v���o���܂����B"));
                listBox1.Items.Add(string.Format("���w���̍��ɉ��y�̎��ƂŊw�񂾂��Ƃ��v���o���Ȃ�����K���Ă��������ɁA"));
                listBox1.Items.Add(string.Format("�ЂƂ�ŉ��t���邱�Ƃɕ�����Ȃ��������܂����B"));
                listBox1.Items.Add(string.Format(""));
                buttonA.Text = "���y�C�x���g";
                buttonB.Text = "�F�B�Ɖ��t";
                buttonC.Text = "�T�[�N��";
                labelA.Text = "���t���y���މ��y�C�x���g�ɎQ������";
                labelB.Text = "���̂����F�B�Ɖ��t����";
                labelC.Text = "�T�[�N���ɏ�������";
                label6.Text = "�ǂ�ȕ��ɉ��t�������ł����H";
                label7.Text = "���Ȃ��̗��z�Ƃ�������l���đI��ł�������";
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
            label8.Text = "�I�����Ă��������B";
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
