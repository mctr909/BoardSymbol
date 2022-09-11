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
        readonly Brush GridColor = new Pen(Color.FromArgb(95, 0, 0)).Brush;
        readonly Pen CursorColor = new Pen(Color.FromArgb(63, 0, 255, 255));
        readonly int[] mPitchDiv = new int[] {
            2, 4, 8, 10,
            16, 20, 32,
            50, 64, 100
        };
        const int SCALE = 4;
        int mZoomIndex = 4;
        double mPitch = 1.0;
        bool mSetSize = true;
        Point mMousePos;

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

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e) {
            mMousePos = ((PictureBox)sender).PointToClient(Cursor.Position);
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
                ControlBox = false,
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
            var img = pictureBox1.Image;
            var g = Graphics.FromImage(img);
            var pitchDiv = mPitchDiv[mZoomIndex];
            var centerX = img.Width / 2;
            var centerY = img.Height / 2;
            var mouseX = mMousePos.X - centerX;
            var mouseY = mMousePos.Y - centerY;
            mouseX = (mouseX * pitchDiv / SCALE + Math.Sign(mouseX) * pitchDiv / 2) / pitchDiv;
            mouseY = (mouseY * pitchDiv / SCALE + Math.Sign(mouseY) * pitchDiv / 2) / pitchDiv;
            var posX = mouseX * mPitch / pitchDiv;
            var posY = -mouseY * mPitch / pitchDiv;
            pitchDiv *= SCALE;
            mouseX = mouseX * SCALE + centerX;
            mouseY = mouseY * SCALE + centerY;

            lblPitch.Text = string.Format("ピッチ:{0}mm", mPitch.ToString("0.000"));
            lblPitchDiv.Text = string.Format("ピッチ分割:{0}", mPitchDiv[mZoomIndex]);
            lblPos.Text = string.Format("位置:{0}mm, {1}mm", posX.ToString("0.000"), posY.ToString("0.000"));

            /***** *****/
            g.Clear(Color.Black);
            for (float yp = centerY - 1.5f, ym = yp; yp < img.Height; yp += pitchDiv, ym -= pitchDiv) {
                for (float xp = centerX - 1.5f, xm = xp; xp < img.Width; xp += pitchDiv, xm -= pitchDiv) {
                    g.FillPie(GridColor, xp, yp, 3, 3, 0, 360);
                    g.FillPie(GridColor, xp, ym, 3, 3, 0, 360);
                    g.FillPie(GridColor, xm, yp, 3, 3, 0, 360);
                    g.FillPie(GridColor, xm, ym, 3, 3, 0, 360);
                }
            }
            /***** *****/
            g.DrawLine(CursorColor, mouseX, 0, mouseX, img.Height - 1);
            g.DrawLine(CursorColor, 0, mouseY, img.Width - 1, mouseY);
            /***** *****/

            /***** *****/
            pictureBox1.Image = pictureBox1.Image;
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
