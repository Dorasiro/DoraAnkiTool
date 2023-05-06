using DoraAnkiTool.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DoraAnkiTool
{
    internal class AnkiToolMain
    {
        public static readonly string CsvFileName = "mondai.csv";
        private List<ThemeDictionaly> themeDictionalyList = new List<ThemeDictionaly>();

        public AnkiToolMain()
        {
            if(!File.Exists(CsvFileName))
            {
                throw new FileNotFoundException(CsvFileName + "が見つかりません。");
            }

            // CSVから単語意味セットを読み込む
            using (var fs = new FileStream(CsvFileName, FileMode.Open, FileAccess.Read, FileShare.Read))
            using (var sr = new StreamReader(fs))
            {
                string line;
                var count = 0;
                // ReadLine()の後に!を付けることでnullを許容できる（コンパイラが文句言わない）ようにできるらしい
                while((line = sr.ReadLine()!) != null)
                {
                    var sp = line.Split(',');

                    // csvにミスがないかをチェック
                    if (sp.Length < 2)
                    {
                        throw new Exception("csvの異常検知　エラー箇所：" + count);
                    }

                    if (sp[0] == "" || sp[1] == "")
                    {
                        throw new Exception("csvの異常検知　エラー箇所：" + count);
                    }

                    themeDictionalyList.Add(new ThemeDictionaly(sp[0], sp[1]));
                    count++;
                }
            }
        }

        /// <summary>
        /// 全部の問題を返す
        /// </summary>
        /// <returns></returns>
        public List<ThemeDictionaly> GetAllThemeDictionalies()
        {
            return themeDictionalyList;
        }
    }
}
