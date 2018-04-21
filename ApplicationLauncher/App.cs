using System;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace ApplicationLauncher
{
    /// <summary>
    /// アプリ情報クラス
    /// </summary>
    public class App
    {
        // [XML項目名]
        // ルート
        private const string ITEM_ROOT = "application";
        // アプリ名
        private const string ITEM_NAME = "name";
        // アプリパス
        private const string ITEM_APP_PATH = "appPath";
        // セーブディレクトリパス
        private const string ITEM_SAVE_PATH = "savePath";
        // メーカー名
        private const string ITEM_MAKER = "maker";
        // ジャンル
        private const string ITEM_GENRE = "genre";
        // アイコンパス
        private const string ITEM_ICON_PATH = "iconPath";

        // XML項目名配列
        private static string[] XML_ITEMS =
        {
            ITEM_NAME,
            ITEM_APP_PATH,
            ITEM_SAVE_PATH,
            ITEM_MAKER,
            ITEM_GENRE,
            ITEM_ICON_PATH,
        };

        // [設定値]
        // アプリ名(必須)
        public string Name { get; set; }
        // アプリパス(必須)
        public string AppPath { get; set; }
        // セーブディレクトリパス(任意)
        public string SavePath { get; set; }
        // メーカー名(任意)
        public string Maker { get; set; }
        // ジャンル(任意)
        public string Genre { get; set; }
        // アイコンパス(任意)
        public string IconPath { get; set; }

        // xmlパス
        private string XmlPath { get; set; } = null;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public App() : this(null, null)
        {
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="name">アプリ名</param>
        /// <param name="path">アプリパス</param>
        public App(string name, string path)
        {
            Name = name;
            AppPath = path;
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="file">xmlファイルパス</param>
        public App(string file)
        {
            XElement documentRoot = XDocument.Load(file).Element(ITEM_ROOT);

            // アプリ名
            if (null != documentRoot.Element(ITEM_NAME))
            {
                Name = documentRoot.Element(ITEM_NAME).Value;
            }
            // アプリパス
            if (null != documentRoot.Element(ITEM_APP_PATH))
            {
                AppPath = documentRoot.Element(ITEM_APP_PATH).Value;
            }
            // セーブディレクトリ
            if (null != documentRoot.Element(ITEM_SAVE_PATH))
            {
                SavePath = documentRoot.Element(ITEM_SAVE_PATH).Value;
            }
            // メーカー名
            if (null != documentRoot.Element(ITEM_MAKER))
            {
                Maker = documentRoot.Element(ITEM_MAKER).Value;
            }
            // ジャンル
            if (null != documentRoot.Element(ITEM_GENRE))
            {
                Genre = documentRoot.Element(ITEM_GENRE).Value;
            }
            // アイコンパス
            if (null != documentRoot.Element(ITEM_ICON_PATH))
            {
                IconPath = documentRoot.Element(ITEM_ICON_PATH).Value;
            }
            // xmlパス
            XmlPath = file;
        }

        /// <summary>
        /// アプリ情報をXMLに保存する
        /// </summary>
        /// <returns>保存成否</returns>
        public bool SaveXml()
        {
            // 必須項目が空なら失敗
            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(AppPath))
            {
                return false;
            }

            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.PreserveWhitespace = true;

            xmlDocument.LoadXml("<?xml version=\"1.0\" encoding=\"utf-8\"?><" + ITEM_ROOT + "></" + ITEM_ROOT + ">");

            foreach (var item in XML_ITEMS)
            {
                string value = GetValue(item);
                if (null != value)
                {
                    XmlElement Element = xmlDocument.CreateElement(item);
                    Element.InnerText = value;
                    xmlDocument.DocumentElement.AppendChild(Element);
                }
            }

            if (XmlPath == null)
            {
                XmlPath = ConstUtil.DEFAULT_XML_DIR + "\\" + GetFileName();
            }
            xmlDocument.Save(XmlPath);

            return true;
        }

        /// <summary>
        /// xmlエレメント名から対応する値を返す
        /// </summary>
        /// <param name="ElementName">xmlエレメント名</param>
        private string GetValue(string ElementName)
        {
            string value;
            switch (ElementName)
            {
                case ITEM_NAME:
                    value = Name;
                    break;
                case ITEM_APP_PATH:
                    value = AppPath;
                    break;
                case ITEM_SAVE_PATH:
                    value = SavePath;
                    break;
                case ITEM_MAKER:
                    value = Maker;
                    break;
                case ITEM_GENRE:
                    value = Genre;
                    break;
                case ITEM_ICON_PATH:
                    value = IconPath;
                    break;
                default:
                    value = null;
                    break;
            }
            return value;
        }

        /// <summary>
        /// 対応するXMLファイルを削除する
        /// </summary>
        public void DeleteXml()
        {
            if (null == XmlPath)
            {
                return;
            }
            if(File.Exists(IconPath))
            {
                File.Delete(IconPath);
            }
            File.Delete(XmlPath);
        }

        /// <summary>
        /// XMLファイル名を生成する
        /// </summary>
        private string GetFileName()
        {
            return DateTime.Now.ToString("yyyyMMddhhmmss") + ".xml";
        }

        public override string ToString()
        {
            return (Name == null) ? "xxxxx" : Name;
        }

        /// <summary>
        /// dataGrid表示用項目を取得する
        /// </summary>
        /// <returns>0番目から順にアプリ名, メーカー名, ジャンル</returns>
        public string[] GetRowData()
        {
            return new string[] { Name, Maker, Genre };
        }
    }
}
