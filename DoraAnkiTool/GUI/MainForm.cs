using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoraAnkiTool.GUI
{
    public partial class MainForm : Form
    {
        private AnkiToolMain ankiToolMain = new AnkiToolMain();
        private Dictionary<Label, ThemeDictionaly> dict = new Dictionary<Label, ThemeDictionaly>();
        private ThemeDictionaly[]? nowQuestions;

        public MainForm()
        {
            InitializeComponent();
        }

        private void GetQuestion()
        {
            nowQuestions = ankiToolMain.Questions();
            if(nowQuestions == null)
            {
                questionLabel.Text = "全問題終わり。";
                answer1Label.Visible = false;
                answer2Label.Visible= false;
                answer3Label.Visible= false;
                answer4Label.Visible= false;
                return;
            }

            // 問題文を表示
            questionLabel.Text = nowQuestions[0].Word;

            // 回答を表示
            var rnd = new Random();
            var rndInt = rnd.Next(0, nowQuestions.Length);
            switch(rndInt)
            {
                case 0:
                    answer1Label.Text = nowQuestions[0].Mean;
                    answer2Label.Text = nowQuestions[1].Mean;
                    answer3Label.Text = nowQuestions[2].Mean;
                    answer4Label.Text = nowQuestions[3].Mean;

                    dict[answer1Label] = nowQuestions[0];
                    dict[answer2Label] = nowQuestions[1];
                    dict[answer3Label] = nowQuestions[2];
                    dict[answer4Label] = nowQuestions[3];

                    break;

                case 1:
                    answer1Label.Text = nowQuestions[1].Mean;
                    answer2Label.Text = nowQuestions[0].Mean;
                    answer3Label.Text = nowQuestions[2].Mean;
                    answer4Label.Text = nowQuestions[3].Mean;

                    dict[answer1Label] = nowQuestions[1];
                    dict[answer2Label] = nowQuestions[0];
                    dict[answer3Label] = nowQuestions[2];
                    dict[answer4Label] = nowQuestions[3];

                    break;

                case 2:
                    answer1Label.Text = nowQuestions[2].Mean;
                    answer2Label.Text = nowQuestions[1].Mean;
                    answer3Label.Text = nowQuestions[0].Mean;
                    answer4Label.Text = nowQuestions[3].Mean;

                    dict[answer1Label] = nowQuestions[2];
                    dict[answer2Label] = nowQuestions[1];
                    dict[answer3Label] = nowQuestions[0];
                    dict[answer4Label] = nowQuestions[3];

                    break;

                case 3:
                    answer1Label.Text = nowQuestions[3].Mean;
                    answer2Label.Text = nowQuestions[1].Mean;
                    answer3Label.Text = nowQuestions[2].Mean;
                    answer4Label.Text = nowQuestions[0].Mean;

                    dict[answer1Label] = nowQuestions[3];
                    dict[answer2Label] = nowQuestions[1];
                    dict[answer3Label] = nowQuestions[2];
                    dict[answer4Label] = nowQuestions[0];

                    break;
            }
        }

        private void ShowAnswer()
        {
            // 正解の場合、文字色を変える
            if (answer1Label.Text == nowQuestions[0].Mean)
            {
                answer1Label.ForeColor = Color.Red;
            }
            else if (answer2Label.Text == nowQuestions[0].Mean)
            {
                answer2Label.ForeColor = Color.Red;
            }
            else if (answer3Label.Text == nowQuestions[0].Mean)
            {
                answer3Label.ForeColor = Color.Red;
            }
            else
            {
                answer4Label.ForeColor = Color.Red;
            }

            answer1Label.Text = dict[answer1Label].Word + "..." + dict[answer1Label].Mean;
            answer2Label.Text = dict[answer2Label].Word + "..." + dict[answer2Label].Mean;
            answer3Label.Text = dict[answer3Label].Word + "..." + dict[answer3Label].Mean;
            answer4Label.Text = dict[answer4Label].Word + "..." + dict[answer4Label].Mean;

            nextButton.Visible = true;
        }

        private void Next()
        {
            nextButton.Visible = false;

            answer1Label.ForeColor = Color.Black;
            answer2Label.ForeColor = Color.Black;
            answer3Label.ForeColor = Color.Black;
            answer4Label.ForeColor = Color.Black;

            GetQuestion();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GetQuestion();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            Next();
        }

        private void answer1Label_Click(object sender, EventArgs e)
        {
            // 回答表示中はnextボタンと同じ挙動
            if (nextButton.Visible)
            {
                Next();
            }
            else
            {
                ShowAnswer();
            }
        }

        private void answer2Label_Click(object sender, EventArgs e)
        {
            // 回答表示中はnextボタンと同じ挙動
            if (nextButton.Visible)
            {
                Next();
            }
            else
            {
                ShowAnswer();
            }
        }

        private void answer3Label_Click(object sender, EventArgs e)
        {
            // 回答表示中はnextボタンと同じ挙動
            if (nextButton.Visible)
            {
                Next();
            }
            else
            {
                ShowAnswer();
            }
        }

        private void answer4Label_Click(object sender, EventArgs e)
        {
            // 回答表示中はnextボタンと同じ挙動
            if (nextButton.Visible)
            {
                Next();
            }
            else
            {
                ShowAnswer();
            }
        }

        private void MainForm_Click(object sender, EventArgs e)
        {
            // 回答表示中はnextボタンと同じ挙動
            if (nextButton.Visible)
            {
                Next();
            }
        }
    }
}
