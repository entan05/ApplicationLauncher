using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ApplicationLauncher
{
    /// <summary>
    /// 登録フォーム
    /// </summary>
    public partial class RegisterForm : Form
    {
        // アプリ情報
        public App Application { get; set; }

        // 登録したかどうか
        public bool FormResult { get; set; } = false;

        // アイコン画像
        private Bitmap _Bitmap { get; set; } = null;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public RegisterForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="app">アプリ情報</param>
        public RegisterForm(App app) : this()
        {
            Application = app;

            if (null != Application)
            {
                nameBox.Text = Application.Name;
                makerBox.Text = Application.Maker;
                pathBox.Text = Application.AppPath;
                saveDirBox.Text = Application.SavePath;
                _Bitmap = (string.IsNullOrEmpty(Application.IconPath) || !File.Exists(Application.IconPath))
                    ? null : (Bitmap)ConstUtil.LoadReadImage(Application.IconPath);
                iconBox.Image = _Bitmap;
                genreBox.Text = Application.Genre;

                DeleteBtn.Visible = true;
            }
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="name">アプリ名</param>
        /// <param name="path">アプリパス</param>
        /// <param name="icon">アイコンパス</param>
        public RegisterForm(string name, string path, Bitmap icon) : this()
        {
            nameBox.Text = name;
            pathBox.Text = path;
            iconBox.Image = icon;

            DeleteBtn.Visible = false;
        }

        /// <summary>
        /// 実行ファイル選択ボタンイベント
        /// </summary>
        private void OpenExeFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "実行ファイル(*.exe)|*.exe";
            dialog.Multiselect = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pathBox.Text = dialog.FileName;

                if (!string.IsNullOrEmpty(pathBox.Text) && File.Exists(pathBox.Text))
                {
                    iconBox.Image = Icon.ExtractAssociatedIcon(pathBox.Text).ToBitmap();
                }
            }
        }

        /// <summary>
        /// セーブファイルディレクトリ選択ボタンイベント
        /// </summary>
        private void OpenSaveDirBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "セーブデータ保存ディレクトリを選択";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                saveDirBox.Text = dialog.SelectedPath;
            }
        }

        /// <summary>
        /// 登録ボタンイベント
        /// </summary>
        private void Regist_Click(object sender, EventArgs e)
        {
            // アプリ名が入力されていない
            if (string.IsNullOrEmpty(nameBox.Text))
            {
                MessageBox.Show("アプリ名が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // 実行ファイルが入力されていない
            else if (string.IsNullOrEmpty(pathBox.Text))
            {
                MessageBox.Show("実行ファイルが入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // 実行ファイルのパスが存在しないファイルパス
            else if (!File.Exists(pathBox.Text))
            {
                MessageBox.Show("実行ファイルが存在しません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // セーブデータディレクトリが存在しないパス
            else if (!string.IsNullOrEmpty(saveDirBox.Text) && !Directory.Exists(saveDirBox.Text))
            {
                MessageBox.Show("セーブデータ保存先のディレクトリが存在しません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (null == Application)
            {
                Application = new App();
            }

            Application.Name = nameBox.Text;
            Application.Maker = makerBox.Text;
            Application.AppPath = pathBox.Text;
            Application.SavePath = saveDirBox.Text;

            if (_Bitmap != null)
            {
                _Bitmap.Dispose();
            }
            string iconName = GetFileName();
            if (!string.IsNullOrEmpty(Application.IconPath))
            {
                iconName = Application.IconPath;
            }
            if (File.Exists(iconName))
            {
                File.Delete(iconName);
            }
            iconBox.Image.Save(iconName);
            Application.IconPath = iconName;

            Application.Genre = genreBox.Text;

            Application.SaveXml();

            FormResult = true;
            Close();
        }

        /// <summary>
        /// キャンセルボタンイベント
        /// </summary>
        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// 削除ボタンイベント
        /// </summary>
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("削除しますか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {
                Application.DeleteXml();
                FormResult = true;
                Close();
            }
        }

        /// <summary>
        /// 実行ファイル入力欄にアイテムをドラッグ時のイベント
        /// </summary>
        private void PathBox_DragEnter(object sender, DragEventArgs e)
        {
            bool enable = true;
            foreach (string file in (string[])e.Data.GetData(DataFormats.FileDrop))
            {
                string extension = Path.GetExtension(file);
                if (".exe" != extension && ".lnk" != extension)
                {
                    enable = false;
                    break;
                }
            }

            if (enable)
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        /// <summary>
        /// 実行ファイル入力欄にアイテムをドロップ時のイベント
        /// </summary>
        private void PathBox_DragDrop(object sender, DragEventArgs e)
        {
            foreach (string file in (string[])e.Data.GetData(DataFormats.FileDrop))
            {
                string extension = Path.GetExtension(file);
                if (".exe" == extension)
                {
                    pathBox.Text = file;
                }
                else if (".lnk" == extension)
                {
                    IWshRuntimeLibrary.WshShell shell = new IWshRuntimeLibrary.WshShell();
                    IWshRuntimeLibrary.IWshShortcut shortcut = (IWshRuntimeLibrary.IWshShortcut)shell.CreateShortcut(file);

                    if (".exe" == Path.GetExtension(shortcut.TargetPath.ToString()))
                    {
                        pathBox.Text = shortcut.TargetPath.ToString();
                    }
                }

                if (!string.IsNullOrEmpty(pathBox.Text) && File.Exists(pathBox.Text))
                {
                    iconBox.Image = Icon.ExtractAssociatedIcon(pathBox.Text).ToBitmap();
                }
            }
        }

        /// <summary>
        /// 画像ファイル名を取得する
        /// </summary>
        /// <returns>画像ファイル名</returns>
        private string GetFileName()
        {
            return ConstUtil.DEFAULT_ICON_DIR + "\\" + DateTime.Now.ToString("yyyyMMddhhmmss") + ".bmp";
        }
    }
}
