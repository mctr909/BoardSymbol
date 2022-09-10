using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversalBoardEditor {
    public partial class SymbolEditor : Form {
        readonly Brush GridMajor = new Pen(Color.FromArgb(95, 0, 0)).Brush;
        readonly Brush GridMinor = new Pen(Color.FromArgb(63, 63, 63)).Brush;
        readonly int[] mPitchDiv = new int[] {
            2, 3, 4, 5,
            6, 8, 10, 12,
            16, 20, 24, 25,
            32, 40, 48, 50,
            64, 80, 96, 100
        };
        int mZoomIndex = 6;
        double mPitch = 1.0;
        bool mSetSize = true;

        public SymbolEditor() {
            InitializeComponent();
        }

        private void SymbolEditor_Load(object sender, EventArgs e) {
            timer1.Interval = 33;
            timer1.Enabled = true;
            timer1.Start();
        }

        private void SymbolEditor_SizeChanged(object sender, EventArgs e) {
            mSetSize = true;
        }

        #region Menu[ファイル]
        private void 新規作成NToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void 開くOToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void 上書き保存SToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void 名前を付けて保存AToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void サイズ設定ZToolStripMenuItem_Click(object sender, EventArgs e) {

        }
        #endregion

        #region Menu[編集]
        private void 選択SToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void 元に戻すUToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void やり直しRToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void 切り取りTToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void コピーCToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void 貼り付けPToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void 削除LToolStripMenuItem_Click(object sender, EventArgs e) {

        }
        #endregion

        #region Menu[表示]
        private void 拡大ZToolStripMenuItem_Click(object sender, EventArgs e) {
            if (mZoomIndex < mPitchDiv.Length - 1) {
                mZoomIndex++;
            }
        }

        private void 縮小SToolStripMenuItem_Click(object sender, EventArgs e) {
            if (0 < mZoomIndex) {
                mZoomIndex--;
            }
        }

        private void ピッチGToolStripMenuItem_Click(object sender, EventArgs e) {
            var fm = new Form() {
                FormBorderStyle = FormBorderStyle.FixedToolWindow,
                ControlBox = true,
                StartPosition = FormStartPosition.CenterParent,
                Width = 96,
                Height = 65,
                Text = "ピッチ設定"
            };
            var txt = new TextBox() {
                Top = 0,
                Height = 0,
                Width = 80,
                Text = mPitch.ToString("0.000"),
                Font = new Font(Font.Name, 11)
            };
            txt.KeyDown += new KeyEventHandler((s, e) => {
                if (e.KeyCode == Keys.Enter) {
                    fm.Close();
                }
            });
            fm.Controls.Add(txt);
            fm.FormClosing += new FormClosingEventHandler((s, e) => {
                var pitch = 0.0;
                if (!double.TryParse(txt.Text, out pitch)) {
                    txt.Text = "";
                    System.Media.SystemSounds.Beep.Play();
                    e.Cancel = true;
                }
                mPitch = pitch;
            });
            fm.ShowDialog();
        }
        #endregion

        #region Menu[ツール]
        private void 直線LToolStripMenuItem_Click(object sender, EventArgs e) {
            setMode(sender);
        }

        private void 円弧AToolStripMenuItem_Click(object sender, EventArgs e) {
            setMode(sender);
        }

        private void クロソイド曲線CToolStripMenuItem_Click(object sender, EventArgs e) {
            setMode(sender);
        }

        private void ポリラインIToolStripMenuItem_Click(object sender, EventArgs e) {
            setTools(sender);
        }

        private void ポリゴンGToolStripMenuItem_Click(object sender, EventArgs e) {
            setTools(sender);
        }

        private void 穴あけポリゴンHToolStripMenuItem_Click(object sender, EventArgs e) {
            setTools(sender);
        }

        private void 原点移動OToolStripMenuItem_Click(object sender, EventArgs e) {
            setTools(sender);
        }

        private void 距離測定DToolStripMenuItem_Click(object sender, EventArgs e) {
            setTools(sender);
        }

        private void 角度測定NToolStripMenuItem_Click(object sender, EventArgs e) {
            setTools(sender);
        }
        #endregion

        private void timer1_Tick(object sender, EventArgs e) {
            if (mSetSize) {
                setSize();
            }
            var pitchDiv = mPitchDiv[mZoomIndex] * 2;
            var img = pictureBox1.Image;
            var g = Graphics.FromImage(img);
            g.Clear(Color.Black);
            if (12 <= pitchDiv) {
                for (int y = 0; y < img.Height; y += pitchDiv) {
                    for (int x = 0; x < img.Width; x += pitchDiv) {
                        g.FillPie(GridMajor, x - 1.5f, y - 1.5f, 3, 3, 0, 360);
                    }
                }
            }

            pictureBox1.Image = pictureBox1.Image;

            lblDisp.Text = string.Format("ピッチ:{0}mm, ピッチ分割:{1}", mPitch.ToString("0.000"), mPitchDiv[mZoomIndex]);
            g.Dispose();
            mSetSize = false;
        }

        void setTools(object item) {
            ポリラインIToolStripMenuItem.Checked = false;
            ポリゴンGToolStripMenuItem.Checked = false;
            穴あけポリゴンHToolStripMenuItem.Checked = false;
            原点移動OToolStripMenuItem.Checked = false;
            距離測定DToolStripMenuItem.Checked = false;
            角度測定NToolStripMenuItem.Checked = false;
            ((ToolStripMenuItem)item).Checked = true;
            switch (((ToolStripMenuItem)item).Name) {
            case "原点移動OToolStripMenuItem":
            case "距離測定DToolStripMenuItem":
            case "角度測定NToolStripMenuItem":
                直線LToolStripMenuItem.Checked = false;
                円弧AToolStripMenuItem.Checked = false;
                クロソイド曲線CToolStripMenuItem.Checked = false;
                break;
            }
        }

        void setMode(object item) {
            直線LToolStripMenuItem.Checked = false;
            円弧AToolStripMenuItem.Checked = false;
            クロソイド曲線CToolStripMenuItem.Checked = false;
            ((ToolStripMenuItem)item).Checked = !(
                原点移動OToolStripMenuItem.Checked ||
                距離測定DToolStripMenuItem.Checked ||
                角度測定NToolStripMenuItem.Checked
            );
        }

        void setSize() {
            pictureBox1.Top = menuStrip1.Bottom;
            pictureBox1.Left = 0;
            pictureBox1.Width = Width - vScrollBar1.Width - 16;
            pictureBox1.Height = Height - hScrollBar1.Height - menuStrip1.Height - statusStrip1.Height - 39;
            vScrollBar1.Top = menuStrip1.Bottom;
            vScrollBar1.Left = pictureBox1.Right;
            vScrollBar1.Height = pictureBox1.Height;
            hScrollBar1.Top = pictureBox1.Bottom;
            hScrollBar1.Left = 0;
            hScrollBar1.Width = pictureBox1.Width;
            if (null != pictureBox1.Image) {
                pictureBox1.Image.Dispose();
                pictureBox1.Image = null;
            }
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }
    }
}
