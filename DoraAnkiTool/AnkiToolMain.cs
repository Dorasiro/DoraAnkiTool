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
        // 読み込んだ問題を保存する
        private List<ThemeDictionaly> themeDictionalyMasterList = new List<ThemeDictionaly>();
        // 読み込んだ問題を保存するが、出題後に重複した問題が出題されるのを防ぐため、出題後に削除される
        private List<ThemeDictionaly> themeDictionalyList;

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

                    themeDictionalyMasterList.Add(new ThemeDictionaly(sp[0], sp[1]));
                    count++;
                }
            }

            themeDictionalyList = new List<ThemeDictionaly>(themeDictionalyMasterList);
        }

        /// <summary>
        /// 全部の問題を返す
        /// </summary>
        /// <returns></returns>
        public List<ThemeDictionaly> GetAllThemeDictionalies()
        {
            return themeDictionalyMasterList;
        }

        /// <summary>
        /// 出題する　
        /// </summary>
        /// <returns>問題の残量が0の場合nullを返す</returns>
        public ThemeDictionaly[]? Questions()
        {
            if(themeDictionalyList.Count <= 0)
            {
                return null;
            }

            var result = new ThemeDictionaly[4];
            var rnd = new Random();
            var rndInt = rnd.Next(0, themeDictionalyList.Count-1);

            // 問題を１個ランダムで出力用の配列に移す
            result[0] = themeDictionalyList[rndInt];
            themeDictionalyList.RemoveAt(rndInt);

            // マスターの中から残りの３つを選ぶ
            var counter = 1;
            // ダミーの回答が重複しないために使う
            // マスターのコピーを取って一度選ばれたものは消していく
            var masterCopy = new List<ThemeDictionaly>(themeDictionalyMasterList);
            while (counter < 4)
            {
                rndInt = rnd.Next(0, masterCopy.Count - 1);
                // 正解ペアと同じものが選ばれていないかチェックする
                if (masterCopy[rndInt].Word == result[0].Word)
                {
                    // 同じだったらマスタコピーから削除してやり直す
                    masterCopy.RemoveAt(rndInt);
                    continue;
                }

                // 同じじゃなかったら次に進む
                result[counter] = masterCopy[rndInt];
                masterCopy.RemoveAt(rndInt);
                counter++;
            }

            return result;
        }
    }
}
