using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json.Nodes;

namespace UniversalBoardEditor {
    public partial class ImageList : Form {
        const int ITEM_SPAN = 32;
        readonly Font NAME_FONT = new Font("Meiryo UI", 9, FontStyle.Regular);

        Dictionary<string, List<ImageElements>> Lists = new Dictionary<string, List<ImageElements>>();
        bool mSetSize = false;
        bool mSetVScrollValue = false;
        bool mScroll = false;
        int mSelectedItem = 0;

        public ImageList() {
            InitializeComponent();
            loadDir();
        }

        private void ImageList_Load(object sender, EventArgs e) {
            StartPosition = FormStartPosition.CenterParent;
            setTab();
            setSize();
            timer1.Interval = 33;
            timer1.Enabled = true;
            timer1.Start();
        }

        private void ImageList_SizeChanged(object sender, EventArgs e) {
            mSetSize = true;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) {
            mSetSize = true;
            mSetVScrollValue = true;
        }

        private void timer1_Tick(object sender, EventArgs e) {
            if (mSetSize) {
                setSize();
            }
            if (mSetSize || mSetVScrollValue) {
                setVScrollValue();
            }
            if (mSetSize || mSetVScrollValue || mScroll) {
                scroll();
            }
            mSetSize = false;
            mSetVScrollValue = false;
            mScroll = false;
        }

        void loadDir() {
            var imagePath = Path.GetDirectoryName(Application.ExecutablePath) + "\\image";
            if (!Directory.Exists(imagePath)) {
                return;
            }
            var dirs = Directory.GetDirectories(imagePath);
            foreach (var dir in dirs) {
                if (!File.Exists(dir + "\\parts.json")) {
                    continue;
                }
                var dirName = Path.GetFileName(dir);
                if (string.IsNullOrEmpty(dirName)) {
                    continue;
                }
                if (Lists.ContainsKey(dirName)) {
                    Lists.Remove(dirName);
                }
                Lists.Add(dirName, new List<ImageElements>());
                setList(dir, Lists[dirName]);
            }
        }

        void setList(string path, List<ImageElements> list) {
            using (var fs = new StreamReader(path + "\\parts.json")) {
                var jsonString = fs.ReadToEnd();
                var node = JsonNode.Parse(jsonString);
                if (null == node) {
                    return;
                }
                var root = node["list"];
                if (null == root) {
                    return;
                }
                foreach (var n in root.AsArray()) {
                    if (null == n) {
                        continue;
                    }
                    list.Add(new ImageElements(path, n));
                }
            }
        }

        void setTab() {
            tabControl1.Top = 0;
            tabControl1.Left = 0;
            tabControl1.TabPages.Clear();
            foreach (var tab in Lists) {
                var tabPage = new TabPage(tab.Key);
                tabPage.Name = tab.Key;
                var pic = new PictureBox();
                pic.Name = "pic" + tab.Key;
                pic.Image = new Bitmap(1, 1);
                tabPage.Controls.Add(pic);
                var vsb = new VScrollBar();
                vsb.Name = "vsb" + tab.Key;
                vsb.ValueChanged += new EventHandler((sender, e) => {
                    mScroll = true;
                });
                tabPage.Controls.Add(vsb);
                tabControl1.TabPages.Add(tabPage);
            }
        }

        void setSize() {
            tabControl1.Width = Width - 14;
            tabControl1.Height = Height - 38;
            var tab = tabControl1.SelectedTab;
            if (null == tab || 0 == tab.Controls.Count) {
                return;
            }
            var pic = (PictureBox)tab.Controls["pic" + tab.Name];
            var vsb = (VScrollBar)tab.Controls["vsb" + tab.Name];
            vsb.Width = 19;
            vsb.Height = tab.Height;
            pic.Top = 0;
            pic.Left = 0;
            pic.Width = tab.Width - vsb.Width;
            pic.Height = tab.Height;
            if (null != pic.Image) {
                pic.Image.Dispose();
                pic.Image = null;
            }
            pic.Image = new Bitmap(pic.Width, pic.Height);
            vsb.Top = 0;
            vsb.Left = pic.Right;
        }

        void setVScrollValue() {
            var tab = tabControl1.SelectedTab;
            if (null == tab || 0 == tab.Controls.Count) {
                return;
            }
            var tabName = tab.Name;
            var vsb = (VScrollBar)tab.Controls["vsb" + tabName];
            var pic = (PictureBox)tab.Controls["pic" + tabName];
            var maxWidth = pic.Width;
            int height = 0;
            int lastHeight = 0;
            foreach (var item in Lists[tabName]) {
                if (null == item || null == item.Image) {
                    continue;
                }
                maxWidth = Math.Max(maxWidth, item.Image.Width);
                lastHeight = item.Image.Height + ITEM_SPAN;
                height += lastHeight;
            }
            mSelectedItem = 0;
            vsb.Value = 0;
            vsb.Maximum = height - lastHeight + ITEM_SPAN / 4;
        }

        void scroll() {
            var tab = tabControl1.SelectedTab;
            if (null == tab || 0 == tab.Controls.Count) {
                return;
            }
            var tabName = tab.Name;
            var vsb = (VScrollBar)tab.Controls["vsb" + tabName];
            var pic = (PictureBox)tab.Controls["pic" + tabName];
            int maxWidth = pic.Width;
            foreach(var item in Lists[tabName]) {
                if (null == item || null == item.Image) {
                    continue;
                }
                maxWidth = Math.Max(maxWidth, item.Image.Width);
            }            
            var g = Graphics.FromImage(pic.Image);
            g.Clear(Color.White);
            int posY = 0;
            foreach (var item in Lists[tabName]) {
                if (null == item || null == item.Image) {
                    continue;
                }
                if (vsb.Value <= posY + item.Image.Height) {
                    var ofsName = posY - vsb.Value;
                    var ofsImage = ofsName + NAME_FONT.Height + 2;
                    var ofsX = (maxWidth - item.Image.Width) / 2;
                    g.DrawString(item.ImageName, NAME_FONT, Brushes.Black, 0, ofsName);
                    g.DrawImage(item.Image, ofsX, ofsImage);
                }
                posY += item.Image.Height + ITEM_SPAN;
            }
            pic.Image = pic.Image;
            g.Dispose();
        }
    }
}
