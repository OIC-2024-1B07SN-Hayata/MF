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
                    {"SNS", "path14"},
                    {"�z�M","path15" }
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
                }},
                 {"path13", new Dictionary<string, string>
                {
                    {"���C�u����", "path22"},
                    {"�y�Ȑ���", "path23"},
                    {"�R���e�X�g","path24" }
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
                buttonB.Text = "SNS";
                buttonC.Text = "�z�M";
                labelA.Text = "�y�����ɓ�������LIVE�ɂł�";
                labelB.Text = "SNS�ɉ��t����𓊍e����";
                labelC.Text = "���C�u�⃉�W�I�z�M������";
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
            if (curr == "�y����")
            {
                listBox1.Items.Add(string.Format("�y�����ł́A�ނƓ����悤�ɉ��y�ɏ�M�������Ԃ����Əo��܂����B"));
                listBox1.Items.Add(string.Format("�o���h�����o�[�����͂����ɈӋC�������A�ނ̃M�^�[�̍˔\�ɋ��Q���܂����B"));
                listBox1.Items.Add(string.Format("�ނ�͈ꏏ�ɗ��K���d�ˁA�������̊y�Ȃ����������܂����B"));
                listBox1.Items.Add(string.Format(""));
                listBox1.Items.Add(string.Format("�����āA"));
                listBox1.Items.Add(string.Format("���ɔނ�̃o���h�͊w�Z�̃��C�u�C�x���g�ɏo�����邱�ƂɂȂ�܂����B"));
                listBox1.Items.Add(string.Format("�ނ̓X�e�[�W�ɗ��O�ْ̋��Ƌ����������Ȃ���A�M�^�[����Ɏ��܂����B"));
                listBox1.Items.Add(string.Format("�X�e�[�W���n�܂�ƁA�ނ̉��t�͗͋����A�ϋq�𖣗����܂����B"));
                listBox1.Items.Add(string.Format("�ނ̉��y�͑����̐l�X�ɓ͂��A���O�̐S��͂�ŗ����܂���ł����B"));
                listBox1.Items.Add(string.Format("���C�u���I���ƁA�傫�Ȕ���Ƌ��ɁA"));
                listBox1.Items.Add(string.Format("�����̐l�X���ނ�̃o���h���̎^���܂����B"));
                listBox1.Items.Add(string.Format("�ނ͉��y��ʂ��Ď������g��\�����A"));
                listBox1.Items.Add(string.Format("�����̐l�X�Ɋ�т�͂��邱�Ƃ��ł������Ƃɖ��������o���܂����B"));
                listBox1.Items.Add(string.Format(""));
                buttonA.Text = "���C�u����";
                buttonB.Text = "�y�Ȑ���";
                buttonC.Text = "�R���e�X�g";
                labelA.Text = "�ϋɓI�Ƀ��C�u�������s��";
                labelB.Text = "�I���W�i���y�Ȃ̐���ɏW������";
                labelC.Text = "���y�R���e�X�g�ɒ��킷��";
                label6.Text = "�ǂ�ȕ��ɉ��t�������ł����H";
                label7.Text = "���Ȃ��̗��z�Ƃ��铹���l���đI��ł�������";

            }
            if (curr == "���C�u����")
            {
                listBox1.Items.Add(string.Format("�o���h�����o�[�����́A�ϋɓI�Ƀ��C�u�������s�����Ƃ����ӂ��܂����B�B"));
                listBox1.Items.Add(string.Format("�ނ�͒n���̃��C�u�n�E�X��t�F�X�e�B�o���ɏo�����A"));
                listBox1.Items.Add(string.Format("�����̊ϋq�Ɏ��������̉��y��͂��܂����B"));
                listBox1.Items.Add(string.Format(""));
                listBox1.Items.Add(string.Format("���C�u�p�t�H�[�}���X�̌o����ςނ��ƂŁA"));
                listBox1.Items.Add(string.Format("�ނ�̉��t�Z�p��X�e�[�W���O�����サ�A�n���ł̒m���x�����܂�܂����B"));
                listBox1.Items.Add(string.Format(""));
                listBox1.Items.Add(string.Format("�ŏI�I�ɁA���R�[�h��Ђ���_��̃I�t�@�[���󂯁A"));
                listBox1.Items.Add(string.Format("�v���f�r���[���ʂ������ƂɂȂ�܂����B"));           
                listBox1.Items.Add(string.Format(""));          
                listBox1.Items.Add(string.Format("���y�̗��͂�������V���ȏ͂ɓ˓����܂����B"));
                listBox1.Items.Add(string.Format("�ނ�͍��コ��ɑ����̃��C�u�ɏo�����A"));
                listBox1.Items.Add(string.Format("�����̉��y���L�߂邽�߂ɓw�͂𑱂���̂ł��傤�B"));
            }
            if (curr == "�y�Ȑ���")
            {
                listBox1.Items.Add(string.Format("�o���h�̓��C�u�������T���߂ɂ��A"));
                listBox1.Items.Add(string.Format("�I���W�i���y�Ȃ̐���ɏW�����邱�Ƃɂ��܂����B"));
                listBox1.Items.Add(string.Format("�ނ�͎��吧��̃A���o���������[�X���A"));
                listBox1.Items.Add(string.Format("�C���^�[�l�b�g��ʂ��Ď��������̉��y���L�߂܂����B"));
                listBox1.Items.Add(string.Format(""));
                listBox1.Items.Add(string.Format("�I�����C����ł̕]���͗l�X�ł��������X�ɍ��܂�A"));
                listBox1.Items.Add(string.Format("�����̃t�@�����l�����܂���"));
                listBox1.Items.Add(string.Format("�ނ�̊y�Ȃ����y�u���O��SNS�Ŏ��グ���A"));
                listBox1.Items.Add(string.Format("�l�b�g��ł̐l�C���}�㏸���A"));
                listBox1.Items.Add(string.Format("�C�O����̒��ڂ��W�߂�悤�ɂȂ�܂����B"));
                listBox1.Items.Add(string.Format(""));
                listBox1.Items.Add(string.Format("���y�̗��͂�������V���ȏ͂ɓ˓����܂����B"));
                listBox1.Items.Add(string.Format("�ނ�͍��コ��ɑ����̃��C�u�ɏo�����A"));
                listBox1.Items.Add(string.Format("�����̉��y���L�߂邽�߂ɓw�͂𑱂���̂ł��傤�B"));
            }
            if (curr == "�R���e�X�g")
            {
                listBox1.Items.Add(string.Format("�o���h�����o�[�����͉��y�R���e�X�g�ɎQ�����邱�Ƃ����ӂ��܂����B"));
                listBox1.Items.Add(string.Format("�ނ�͒n����S���K�͂̃R���e�X�g�ɒ��킵�A���X�̏܂���܂��܂����B"));
                listBox1.Items.Add(string.Format("���e�X�g��ʂ��đ����̉��y�֌W�҂ɒ��ڂ����悤�ɂȂ�A�A"));
                listBox1.Items.Add(string.Format("�ނ�̍˔\���F�߂��܂����B"));
                listBox1.Items.Add(string.Format(""));
                listBox1.Items.Add(string.Format("�ŏI�I�ɂ͗L���ȉ��y�v���f���[�T�[�Əo��A"));
                listBox1.Items.Add(string.Format("�v���f���[�X���󂯂邱�ƂɂȂ�܂����B"));    
                listBox1.Items.Add(string.Format(""));
                listBox1.Items.Add(string.Format("���y�̗��͂�������V���ȏ͂ɓ˓����܂����B"));
                listBox1.Items.Add(string.Format("�ނ�͍��コ��ɑ����̃��C�u�ɏo�����A"));
                listBox1.Items.Add(string.Format("�����̉��y���L�߂邽�߂ɓw�͂𑱂���̂ł��傤�B"));
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
