using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoraAnkiTool.GUI
{
    internal class ThemeDictionaly
    {
        /// <summary>
        /// 単語
        /// </summary>
        public string Word
        {
            get; private set;
        }

        /// <summary>
        /// 意味
        /// </summary>
        public string Mean
        {
            get; private set;
        }

        public ThemeDictionaly(string word, string mean)
        {
            Word = word;
            Mean = mean;
        }

        /// <summary>
        /// 引数で渡された答えが正解かを判定する
        /// </summary>
        /// <param name="mean"></param>
        /// <returns></returns>
        public bool CheckTheAnswer(string mean)
        {
            if(Mean == mean)
            {
                return true;
            }

            return false;
        }
    }
}
