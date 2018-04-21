using System;

namespace ApplicationLauncher
{
    /// <summary>
    /// 定数クラス
    /// </summary>
    class ConstUtil
    {
        // デフォルトのxmlディレクトリ
        public static string DEFAULT_BASE_DIR { get; } = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)
            + "\\e-works\\ApplicationLauncher";

        // settingsファイルパス
        public static string SETTINGS_FILE_PATH { get; } = DEFAULT_BASE_DIR + "\\settings.xml";

        // デフォルトのxmlディレクトリ
        public static string DEFAULT_XML_DIR { get; } = DEFAULT_BASE_DIR + "\\xml";

        // デフォルトのiconディレクトリ
        public static string DEFAULT_ICON_DIR { get; } = DEFAULT_BASE_DIR + "\\icon";

        /// <summary>
        /// 読み取り専用で画像をロードする
        /// </summary>
        /// <param name="FilePath">画像パス</param>
        /// <returns></returns>
        public static System.Drawing.Image LoadReadImage(string FilePath)
        {
            System.IO.FileStream stream = new System.IO.FileStream(FilePath, System.IO.FileMode.Open, System.IO.FileAccess.Read);
            System.Drawing.Image image = System.Drawing.Image.FromStream(stream);
            stream.Close();
            return image;
        }
    }
}
