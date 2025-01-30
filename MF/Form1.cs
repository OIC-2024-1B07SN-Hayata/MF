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
                    {"SNS", "path14"},
                    {"配信","path15" }
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
                }},
                 {"path13", new Dictionary<string, string>
                {
                    {"ライブ活動", "path22"},
                    {"楽曲制作", "path23"},
                    {"コンテスト","path24" }
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
                buttonB.Text = "SNS";
                buttonC.Text = "配信";
                labelA.Text = "軽音部に入部してLIVEにでる";
                labelB.Text = "SNSに演奏動画を投稿する";
                labelC.Text = "ライブやラジオ配信をする";
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
            if (curr == "軽音部")
            {
                listBox1.Items.Add(string.Format("軽音部では、彼と同じように音楽に情熱を持つ仲間たちと出会いました。"));
                listBox1.Items.Add(string.Format("バンドメンバーたちはすぐに意気投合し、彼のギターの才能に驚嘆しました。"));
                listBox1.Items.Add(string.Format("彼らは一緒に練習を重ね、いくつかの楽曲を完成させました。"));
                listBox1.Items.Add(string.Format(""));
                listBox1.Items.Add(string.Format("そして、"));
                listBox1.Items.Add(string.Format("ついに彼らのバンドは学校のライブイベントに出演することになりました。"));
                listBox1.Items.Add(string.Format("彼はステージに立つ前の緊張と興奮を感じながら、ギターを手に取りました。"));
                listBox1.Items.Add(string.Format("ステージが始まると、彼の演奏は力強く、観客を魅了しました。"));
                listBox1.Items.Add(string.Format("彼の音楽は多くの人々に届き、聴衆の心を掴んで離しませんでした。"));
                listBox1.Items.Add(string.Format("ライブが終わると、大きな拍手と共に、"));
                listBox1.Items.Add(string.Format("多くの人々が彼らのバンドを称賛しました。"));
                listBox1.Items.Add(string.Format("彼は音楽を通じて自分自身を表現し、"));
                listBox1.Items.Add(string.Format("多くの人々に喜びを届けることができたことに満足感を覚えました。"));
                listBox1.Items.Add(string.Format(""));
                buttonA.Text = "ライブ活動";
                buttonB.Text = "楽曲制作";
                buttonC.Text = "コンテスト";
                labelA.Text = "積極的にライブ活動を行う";
                labelB.Text = "オリジナル楽曲の制作に集中する";
                labelC.Text = "音楽コンテストに挑戦する";
                label6.Text = "どんな風に演奏したいですか？";
                label7.Text = "あなたの理想とする道を考えて選んでください";

            }
            if (curr == "ライブ活動")
            {
                listBox1.Items.Add(string.Format("バンドメンバーたちは、積極的にライブ活動を行うことを決意しました。。"));
                listBox1.Items.Add(string.Format("彼らは地元のライブハウスやフェスティバルに出演し、"));
                listBox1.Items.Add(string.Format("多くの観客に自分たちの音楽を届けました。"));
                listBox1.Items.Add(string.Format(""));
                listBox1.Items.Add(string.Format("ライブパフォーマンスの経験を積むことで、"));
                listBox1.Items.Add(string.Format("彼らの演奏技術やステージングが向上し、地元での知名度も高まりました。"));
                listBox1.Items.Add(string.Format(""));
                listBox1.Items.Add(string.Format("最終的に、レコード会社から契約のオファーを受け、"));
                listBox1.Items.Add(string.Format("プロデビューを果たすことになりました。"));           
                listBox1.Items.Add(string.Format(""));          
                listBox1.Items.Add(string.Format("音楽の旅はここから新たな章に突入しました。"));
                listBox1.Items.Add(string.Format("彼らは今後さらに多くのライブに出演し、"));
                listBox1.Items.Add(string.Format("自分の音楽を広めるために努力を続けるのでしょう。"));
            }
            if (curr == "楽曲制作")
            {
                listBox1.Items.Add(string.Format("バンドはライブ活動を控えめにし、"));
                listBox1.Items.Add(string.Format("オリジナル楽曲の制作に集中することにしました。"));
                listBox1.Items.Add(string.Format("彼らは自主制作のアルバムをリリースし、"));
                listBox1.Items.Add(string.Format("インターネットを通じて自分たちの音楽を広めました。"));
                listBox1.Items.Add(string.Format(""));
                listBox1.Items.Add(string.Format("オンライン上での評判は様々でしたが徐々に高まり、"));
                listBox1.Items.Add(string.Format("多くのファンを獲得しました"));
                listBox1.Items.Add(string.Format("彼らの楽曲が音楽ブログやSNSで取り上げられ、"));
                listBox1.Items.Add(string.Format("ネット上での人気が急上昇し、"));
                listBox1.Items.Add(string.Format("海外からの注目も集めるようになりました。"));
                listBox1.Items.Add(string.Format(""));
                listBox1.Items.Add(string.Format("音楽の旅はここから新たな章に突入しました。"));
                listBox1.Items.Add(string.Format("彼らは今後さらに多くのライブに出演し、"));
                listBox1.Items.Add(string.Format("自分の音楽を広めるために努力を続けるのでしょう。"));
            }
            if (curr == "コンテスト")
            {
                listBox1.Items.Add(string.Format("バンドメンバーたちは音楽コンテストに参加することを決意しました。"));
                listBox1.Items.Add(string.Format("彼らは地元や全国規模のコンテストに挑戦し、数々の賞を受賞しました。"));
                listBox1.Items.Add(string.Format("ンテストを通じて多くの音楽関係者に注目されるようになり、、"));
                listBox1.Items.Add(string.Format("彼らの才能が認められました。"));
                listBox1.Items.Add(string.Format(""));
                listBox1.Items.Add(string.Format("最終的には有名な音楽プロデューサーと出会い、"));
                listBox1.Items.Add(string.Format("プロデュースを受けることになりました。"));    
                listBox1.Items.Add(string.Format(""));
                listBox1.Items.Add(string.Format("音楽の旅はここから新たな章に突入しました。"));
                listBox1.Items.Add(string.Format("彼らは今後さらに多くのライブに出演し、"));
                listBox1.Items.Add(string.Format("自分の音楽を広めるために努力を続けるのでしょう。"));
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
