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
                    {"音楽", "path1"},
                    {"アニメ", "path2"},
                    {"スポーツ","path3" }
                }},
                {"path1", new Dictionary<string, string>
                {
                    {"ギター", "path4"},
                    {"ピアノ", "path5"},
                    {"リコーダー","path6" }
                }},
                {"path2", new Dictionary<string, string>
                {
                    {"戦隊ヒーロー", "path7"},
                    {"スーパーヒーロー", "path8"},
                    {"ダークヒーロー", "path9"}
                }},
                {"path3",new Dictionary<string, string>
                {
                    {"野球","path10"},
                    {"水泳","path11" },
                    {"テニス","path12" }
                }},
                 {"path4", new Dictionary<string, string>
                {
                    {"軽音部", "path13"},
                    {"例1", "path14"},
                    {"例2","path15" }
                }},
                 {"path5",new Dictionary<string, string>
                {
                    {"燃える曲","path16"},
                    {"穏やかな曲","path17" },
                    {"ラブソング","path18" }
                }},
                 {"path6",new Dictionary<string, string>
                {
                    {"音楽イベント","path19"},
                    {"友達と演奏","path20" },
                    {"サークル","path21" }
                }}
            };
            string a = storyData[currentPath][curr];
            return a;
            //ここにもifで書いたみたいにかいてね
        }
        void HANDAN()
        {
            if (curr == "音楽")
            {
                listBox1.Items.Add(string.Format("彼は幼い頃から音楽が好きでした。"));
                listBox1.Items.Add(string.Format("音楽はとても楽しく、美しいもので"));
                listBox1.Items.Add(string.Format("音楽には目に見えない力があることも彼は知っていました。"));
                listBox1.Items.Add(string.Format(""));
                buttonA.Text = "ギター";
                buttonB.Text = "ピアノ";
                buttonC.Text = "リコーダー";
                labelA.Text = "ギター";
                labelB.Text = "ピアノ";
                labelC.Text = "リコーダー";
                label6.Text = "そこであなたは楽器を始めることにしました。";
                label7.Text = "好きな楽器を選んでください。";
            }
            if (curr == "アニメ")
            {
                listBox1.Items.Add(string.Format("彼はアニメが好きでした。"));
                listBox1.Items.Add(string.Format("画面の向こうには人々から好かれるヒーローがいました。"));
                listBox1.Items.Add(string.Format(""));
                buttonA.Text = "戦隊ヒーロー";
                buttonB.Text = "スーパーヒーロー";
                buttonC.Text = "ダークヒーロー";
                labelA.Text = "戦隊ヒーロー";
                labelB.Text = "スーパーヒーロー";
                labelC.Text = "ダークヒーロー";
                label6.Text = "あなたはそのヒーローに憧れました。";
                label7.Text = "憧れたヒーローを選んでください。";
            }
            if (curr == "スポーツ")
            {
                listBox1.Items.Add(string.Format("彼はスポーツが好きでした。"));
                listBox1.Items.Add(string.Format(""));
                buttonA.Text = "野球";
                buttonB.Text = "水泳";
                buttonC.Text = "テニス";
                labelA.Text = "野球";
                labelB.Text = "水泳";
                labelC.Text = "テニス";
                label6.Text = "見るのが好きだったあなたは挑戦することにしました。";
                label7.Text = "好きなスポーツを選んでください。";
            }

            if (curr == "ギター")
            {
                listBox1.Items.Add(string.Format("彼は必死にギターの練習をして"));
                listBox1.Items.Add(string.Format("練習をしていくうちに"));
                listBox1.Items.Add(string.Format("色んな人に自分の演奏を聴いてほしいと思うようになりました"));
                listBox1.Items.Add(string.Format(""));
                buttonA.Text = "軽音部";
                buttonB.Text = "例1";
                buttonC.Text = "例2";
                labelA.Text = "軽音部に入部してLIVEにでる";
                labelB.Text = "例1";
                labelC.Text = "例2";
                label6.Text = "どんな形で演奏したいですか？";
                label7.Text = "あなたの理想とする場面を考えて選んでください";
            }
            if (curr == "ピアノ")
            {
                listBox1.Items.Add(string.Format("彼は練習をしていくうちに"));                
                listBox1.Items.Add(string.Format("自分で曲を作りたいと思うようになりました。"));
                listBox1.Items.Add(string.Format(""));
                buttonA.Text = "燃える曲";
                buttonB.Text = "穏やかな曲";
                buttonC.Text = "ラブソング";
                labelA.Text = "力がみなぎってくるような燃える曲";
                labelB.Text = "共感できて慰めてくれるような穏やかな曲";
                labelC.Text = "青春時代を思い出すようなラブソング";
                label6.Text = "どんな曲を作りたいですか？";
                label7.Text = "あなたの理想とする場面を考えて選んでください";
            }
            if (curr == "リコーダー")
            {
                listBox1.Items.Add(string.Format("彼は押し入れにしまっていたリコーダーを思い出しました。"));
                listBox1.Items.Add(string.Format("小学生の頃に音楽の授業で学んだことを思い出しながら練習していくうちに、"));
                listBox1.Items.Add(string.Format("ひとりで演奏することに物足りなさを感じました。"));
                listBox1.Items.Add(string.Format(""));
                buttonA.Text = "音楽イベント";
                buttonB.Text = "友達と演奏";
                buttonC.Text = "サークル";
                labelA.Text = "合奏を楽しむ音楽イベントに参加する";
                labelB.Text = "仲のいい友達と演奏する";
                labelC.Text = "サークルに所属する";
                label6.Text = "どんな風に演奏したいですか？";
                label7.Text = "あなたの理想とする環境を考えて選んでください";
            }
            //ここにいろいろifかいてね




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

            listBox1.Items.Add(string.Format("この物語はごく平凡な男の子の物語。"));
            label8.Text = "選択してください。";
            labelA.Text = "A:音楽";
            labelB.Text = "B:アニメ";
            labelC.Text = "C:スポーツ";

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
