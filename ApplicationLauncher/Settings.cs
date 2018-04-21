using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace ApplicationLauncher
{
    /// <summary>
    /// 設定管理クラス
    /// </summary>
    class Settings
    {
        // [XML項目名]
        // ルート
        private  const string ITEM_ROOT = "Settings";
        // 設定ファイルバージョン
        private const string ITEM_SETTINGS_VERSION = "SettingsVersion";
        // アプリバージョン
        private const string ITEM_APPLICATION_VERSION_CODE = "ApplicationVersionCode";
        // アプリバージョン名
        private const string ITEM_APPLICATION_VERSION_NAME = "ApplicationVersionName";

        // XML項目名配列
        private static string[] XML_ITEMS =
        {
            ITEM_SETTINGS_VERSION,
            ITEM_APPLICATION_VERSION_CODE,
            ITEM_APPLICATION_VERSION_NAME,
        };

        // [設定値]
        // 設定ファイルバージョン
        public int SettingsVersion
        {
            get
            {
                return _SettingsVersion;
            }
        }
        // アプリバージョン
        public string ApplicationVersionCode
        {
            get
            {
                return _ApplicationVersionCode;
            }
        }
        // アプリバージョン名
        public string ApplicationVersionName
        {
            get
            {
                return _ApplicationVersionName;
            }
        }

        // [設定値実態]
        // 設定ファイルバージョン
        private static int _SettingsVersion = 0;
        // アプリバージョン
        private static string _ApplicationVersionCode = "0.0.1";
        // アプリバージョン名
        private static string _ApplicationVersionName = "Akane";

        // シングルトンのインスタンス
        private static Settings _SettingsInstance = new Settings();

        /// <summary>
        /// Settingsインスタンス取得
        /// </summary>
        /// <returns>静的Settingsインスタンス</returns>
        public static Settings GetInstance()
        {
            return _SettingsInstance;
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        private Settings()
        {
            if (!File.Exists(ConstUtil.SETTINGS_FILE_PATH))
            {
                CreateSettingsFile();
            }
            else
            {
                LoadSettings();
            }
        }

        /// <summary>
        /// Settingsファイルを新規作成する
        /// </summary>
        private void CreateSettingsFile()
        {
            SaveSettings();
        }

        /// <summary>
        /// Settingsファイルをロードする
        /// </summary>
        private void LoadSettings()
        {
            XElement documentRoot = XDocument.Load(ConstUtil.SETTINGS_FILE_PATH).Element(ITEM_ROOT);

            // 設定ファイルバージョン
            if(null != documentRoot.Element(ITEM_SETTINGS_VERSION))
            {
                _SettingsVersion = int.Parse(documentRoot.Element(ITEM_SETTINGS_VERSION).Value);
            }
            // アプリバージョン
            if(null != documentRoot.Element(ITEM_APPLICATION_VERSION_CODE))
            {
                _ApplicationVersionCode = documentRoot.Element(ITEM_APPLICATION_VERSION_CODE).Value;
            }
            // アプリケーションバージョン名
            if(null != documentRoot.Element(ITEM_APPLICATION_VERSION_NAME))
            {
                _ApplicationVersionName = documentRoot.Element(ITEM_APPLICATION_VERSION_NAME).Value;
            }
        }

        /// <summary>
        /// 現在の値でSettingsファイルに保存する
        /// </summary>
        public void SaveSettings()
        {
            if(!Directory.Exists(ConstUtil.DEFAULT_BASE_DIR))
            {
                Directory.CreateDirectory(ConstUtil.DEFAULT_BASE_DIR);
            }

            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.PreserveWhitespace = true;
            
            xmlDocument.LoadXml("<?xml version=\"1.0\" encoding=\"utf-8\"?><" + ITEM_ROOT + "></" + ITEM_ROOT + ">");

            foreach(var item in XML_ITEMS)
            {
                XmlElement element = xmlDocument.CreateElement(item);
                element.InnerText = GetValue(item);
                xmlDocument.DocumentElement.AppendChild(element);
            }

            xmlDocument.Save(ConstUtil.SETTINGS_FILE_PATH);
        }

        /// <summary>
        /// xmlエレメント名から対応する値を返す
        /// </summary>
        /// <param name="ElementName">xmlエレメント名</param>
        private string GetValue(string ElementName)
        {
            string value;
            switch(ElementName)
            {
                case ITEM_SETTINGS_VERSION:
                    value = _SettingsVersion.ToString();
                    break;
                case ITEM_APPLICATION_VERSION_CODE:
                    value = _ApplicationVersionCode;
                    break;
                case ITEM_APPLICATION_VERSION_NAME:
                    value = _ApplicationVersionName;
                    break;
                default:
                    value = "";
                    break;
            }
            return value;
        }
    }
}
