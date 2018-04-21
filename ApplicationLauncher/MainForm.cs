using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ApplicationLauncher
{
    /// <summary>
    /// メインフォーム
    /// </summary>
    public partial class MainForm : Form
    {
        // 設定
        private Settings m_Settings;
        // 選択されたアイテムのインデックス
        private int m_SelectedIndex { get; set; } = -1;

        // 表示アプリリスト
        private ArrayList m_AppList;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            // 設定取得
            m_Settings = Settings.GetInstance();

            // dataGrid初期化
            InitDataGrid();

            m_AppList = new ArrayList();

            // 項目を非表示に変更
            SetItemVisible(false);

            // iconの保存ディレクトリ存在確認
            if (!Directory.Exists(ConstUtil.DEFAULT_ICON_DIR))
            {
                // なければ生成
                Directory.CreateDirectory(ConstUtil.DEFAULT_ICON_DIR);
            }
            // xmlのディレクトリが存在しているか確認する
            if (!Directory.Exists(ConstUtil.DEFAULT_XML_DIR))
            {
                // ない場合は作成して終了
                Directory.CreateDirectory(ConstUtil.DEFAULT_XML_DIR);
                return;
            }
            // アプリのxmlをロード
            LoadXmls();
        }

        /// <summary>
        /// フォーム表示完了イベント
        /// </summary>
        private void FormShown(object sender, EventArgs e)
        {
            // 選択をなしに
            dataList.CurrentCell = null;
        }

        /// <summary>
        /// dataGrid初期化関数
        /// </summary>
        private void InitDataGrid()
        {
            // 表示項目数
            dataList.ColumnCount = 4;

            // データの紐づけ用項目は非表示
            dataList.Columns[0].HeaderText = "Index";
            dataList.Columns[0].Visible = false;

            dataList.Columns[1].HeaderText = "Name";
            dataList.Columns[2].HeaderText = "Maker";
            dataList.Columns[3].HeaderText = "Genre";

            dataList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        /// <summary>
        /// アプリのXMLをロードする
        /// </summary>
        private void LoadXmls()
        {
            // DataGridをクリア
            dataList.Rows.Clear();
            m_AppList.Clear();

            int index = 0;
            foreach (string file in Directory.GetFiles(ConstUtil.DEFAULT_XML_DIR))
            {
                App app = new App(file);
                dataList.Rows.Add(index, app.GetRowData()[0], app.GetRowData()[1], app.GetRowData()[2]);
                m_AppList.Add(app);

                index += 1;
            }

            dataList.CurrentCell = null;
            m_SelectedIndex = -1;
            SetItemVisible(false);
            UpdateMainContents();
        }

        /// <summary>
        /// Files > New クリックイベント
        /// </summary>
        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (iconBox.Image != null)
            {
                iconBox.Image.Dispose();
            }
            // 登録フォームを表示
            RegisterForm registerForm = new RegisterForm();
            registerForm.Location = this.Location;
            registerForm.ShowDialog();
            if (registerForm.FormResult)
            {
                // 登録された場合はXMLを再ロードする
                LoadXmls();
            }
            registerForm.Dispose();
        }

        /// <summary>
        /// Files > Exit クリックイベント
        /// </summary>
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Help > Help クリックイベント
        /// </summary>
        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // todo
        }

        /// <summary>
        /// 表示項目の可視状態変更
        /// </summary>
        /// <param name="visible">表示状態</param>
        private void SetItemVisible(bool visible)
        {
            iconBox.Visible = visible;
            AppName.Visible = visible;
            MakerLabel.Visible = visible;
            Maker.Visible = visible;
            AppPathLabel.Visible = visible;
            AppPath.Visible = visible;
            SaveDirLabel.Visible = visible;
            SaveDir.Visible = visible;
            GenreLabel.Visible = visible;
            Genre.Visible = visible;

            StartBtn.Visible = visible;
            EditBtn.Visible = visible;
        }

        /// <summary>
        /// 開始ボタンイベント
        /// </summary>
        private void StartBtn_Click(object sender, EventArgs e)
        {
            if (m_SelectedIndex != -1)
            {
                Process.Start(((App)m_AppList[m_SelectedIndex]).AppPath);
            }
        }

        /// <summary>
        /// 編集ボタンイベント
        /// </summary>
        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (m_SelectedIndex != -1)
            {
                if (iconBox.Image != null)
                {
                    iconBox.Image.Dispose();
                }

                RegisterForm registerForm = new RegisterForm(((App)m_AppList[m_SelectedIndex]));
                registerForm.Location = this.Location;
                registerForm.ShowDialog();
                if (registerForm.FormResult)
                {
                    // 更新されたらXMLを再ロードする
                    LoadXmls();
                }
                registerForm.Dispose();
            }
        }

        /// <summary>
        /// dataGrid選択変更イベント
        /// </summary>
        private void dataList_CurrentCellChanged(object sender, EventArgs e)
        {
            // 表示項目更新
            UpdateMainContents();
        }

        /// <summary>
        /// 表示項目を更新する
        /// </summary>
        private void UpdateMainContents()
        {
            foreach (DataGridViewRow row in dataList.SelectedRows)
            {
                m_SelectedIndex = (int)row.Cells[0].Value;

                App app = (App)m_AppList[m_SelectedIndex];
                iconBox.Image = (string.IsNullOrEmpty(app.IconPath) || !File.Exists(app.IconPath)) ? null : ConstUtil.LoadReadImage(app.IconPath);
                AppName.Text = app.Name;
                Maker.Text = string.IsNullOrEmpty(app.Maker) ? "-" : app.Maker;
                AppPath.Text = app.AppPath;
                SaveDir.Text = string.IsNullOrEmpty(app.SavePath) ? "-" : app.SavePath;
                Genre.Text = string.IsNullOrEmpty(app.Genre) ? "-" : app.Genre;

                SetItemVisible(true);
            }
        }

        /// <summary>
        /// データ一覧へのアイテムドラッグイベント
        /// </summary>
        private void dataList_DragEnter(object sender, DragEventArgs e)
        {
            bool enable = true;
            foreach (string file in (string[])e.Data.GetData(DataFormats.FileDrop))
            {
                string extension = Path.GetExtension(file);
                // exe or ショートカットリンクのみを受け付ける
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
        /// データ一覧へのアイテムドロップイベント
        /// </summary>
        private void dataList_DragDrop(object sender, DragEventArgs e)
        {
            string fileName = "";
            string filePath = "";
            Bitmap icon = null;
            foreach (string file in (string[])e.Data.GetData(DataFormats.FileDrop))
            {
                string extension = Path.GetExtension(file);
                if (".exe" == extension)
                {
                    filePath = file;
                }
                else if (".lnk" == extension)
                {
                    IWshRuntimeLibrary.WshShell shell = new IWshRuntimeLibrary.WshShell();
                    IWshRuntimeLibrary.IWshShortcut shortcut = (IWshRuntimeLibrary.IWshShortcut)shell.CreateShortcut(file);

                    if (".exe" == Path.GetExtension(shortcut.TargetPath.ToString()))
                    {
                        filePath = shortcut.TargetPath.ToString();
                    }
                }

                if (!string.IsNullOrEmpty(filePath))
                {
                    fileName = Path.GetFileNameWithoutExtension(file);

                    Icon appIcon = Icon.ExtractAssociatedIcon(filePath);
                    icon = appIcon.ToBitmap();
                }
            }

            if (iconBox.Image != null)
            {
                iconBox.Image.Dispose();
            }
            // 登録フォームを開く
            RegisterForm registerForm = new RegisterForm(fileName, filePath, icon);
            registerForm.Location = this.Location;
            registerForm.ShowDialog();
            if (registerForm.FormResult)
            {
                // 登録されたらXMLを再ロードする
                LoadXmls();
            }
            registerForm.Dispose();
        }
    }
}
