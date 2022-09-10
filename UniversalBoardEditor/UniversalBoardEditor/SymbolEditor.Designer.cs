namespace UniversalBoardEditor {
    partial class SymbolEditor {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新規作成NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.開くOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.上書き保存SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.名前を付けて保存AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.サイズ設定ZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.編集EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.選択SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.元に戻すUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.やり直しRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.切り取りTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.コピーCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.貼り付けPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.削除LToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.表示DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.拡大ZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.縮小SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ピッチGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ツールTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.直線LToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.円弧AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.クロソイド曲線CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.ポリラインIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ポリゴンGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.穴あけポリゴンHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.原点移動OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.距離測定DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.角度測定NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblDisp = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblPos = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルFToolStripMenuItem,
            this.編集EToolStripMenuItem,
            this.表示DToolStripMenuItem,
            this.ツールTToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(480, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            this.ファイルFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新規作成NToolStripMenuItem,
            this.toolStripSeparator1,
            this.開くOToolStripMenuItem,
            this.toolStripSeparator2,
            this.上書き保存SToolStripMenuItem,
            this.名前を付けて保存AToolStripMenuItem,
            this.toolStripSeparator9,
            this.サイズ設定ZToolStripMenuItem});
            this.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            this.ファイルFToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.ファイルFToolStripMenuItem.Text = "ファイル(F)";
            // 
            // 新規作成NToolStripMenuItem
            // 
            this.新規作成NToolStripMenuItem.Name = "新規作成NToolStripMenuItem";
            this.新規作成NToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.新規作成NToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.新規作成NToolStripMenuItem.Text = "新規作成(N)";
            this.新規作成NToolStripMenuItem.Click += new System.EventHandler(this.新規作成NToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(181, 6);
            // 
            // 開くOToolStripMenuItem
            // 
            this.開くOToolStripMenuItem.Name = "開くOToolStripMenuItem";
            this.開くOToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.開くOToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.開くOToolStripMenuItem.Text = "開く(O)";
            this.開くOToolStripMenuItem.Click += new System.EventHandler(this.開くOToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(181, 6);
            // 
            // 上書き保存SToolStripMenuItem
            // 
            this.上書き保存SToolStripMenuItem.Name = "上書き保存SToolStripMenuItem";
            this.上書き保存SToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.上書き保存SToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.上書き保存SToolStripMenuItem.Text = "上書き保存(S)";
            this.上書き保存SToolStripMenuItem.Click += new System.EventHandler(this.上書き保存SToolStripMenuItem_Click);
            // 
            // 名前を付けて保存AToolStripMenuItem
            // 
            this.名前を付けて保存AToolStripMenuItem.Name = "名前を付けて保存AToolStripMenuItem";
            this.名前を付けて保存AToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.名前を付けて保存AToolStripMenuItem.Text = "名前を付けて保存(A)";
            this.名前を付けて保存AToolStripMenuItem.Click += new System.EventHandler(this.名前を付けて保存AToolStripMenuItem_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(181, 6);
            // 
            // サイズ設定ZToolStripMenuItem
            // 
            this.サイズ設定ZToolStripMenuItem.Name = "サイズ設定ZToolStripMenuItem";
            this.サイズ設定ZToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.サイズ設定ZToolStripMenuItem.Text = "サイズ設定(Z)";
            this.サイズ設定ZToolStripMenuItem.Click += new System.EventHandler(this.サイズ設定ZToolStripMenuItem_Click);
            // 
            // 編集EToolStripMenuItem
            // 
            this.編集EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.選択SToolStripMenuItem,
            this.toolStripSeparator7,
            this.元に戻すUToolStripMenuItem,
            this.やり直しRToolStripMenuItem,
            this.toolStripSeparator3,
            this.切り取りTToolStripMenuItem,
            this.コピーCToolStripMenuItem,
            this.貼り付けPToolStripMenuItem,
            this.削除LToolStripMenuItem});
            this.編集EToolStripMenuItem.Name = "編集EToolStripMenuItem";
            this.編集EToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.編集EToolStripMenuItem.Text = "編集(E)";
            // 
            // 選択SToolStripMenuItem
            // 
            this.選択SToolStripMenuItem.Name = "選択SToolStripMenuItem";
            this.選択SToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.選択SToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.選択SToolStripMenuItem.Text = "選択(S)";
            this.選択SToolStripMenuItem.Click += new System.EventHandler(this.選択SToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(170, 6);
            // 
            // 元に戻すUToolStripMenuItem
            // 
            this.元に戻すUToolStripMenuItem.Name = "元に戻すUToolStripMenuItem";
            this.元に戻すUToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.元に戻すUToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.元に戻すUToolStripMenuItem.Text = "元に戻す(U)";
            this.元に戻すUToolStripMenuItem.Click += new System.EventHandler(this.元に戻すUToolStripMenuItem_Click);
            // 
            // やり直しRToolStripMenuItem
            // 
            this.やり直しRToolStripMenuItem.Name = "やり直しRToolStripMenuItem";
            this.やり直しRToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.やり直しRToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.やり直しRToolStripMenuItem.Text = "やり直し(R)";
            this.やり直しRToolStripMenuItem.Click += new System.EventHandler(this.やり直しRToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(170, 6);
            // 
            // 切り取りTToolStripMenuItem
            // 
            this.切り取りTToolStripMenuItem.Name = "切り取りTToolStripMenuItem";
            this.切り取りTToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.切り取りTToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.切り取りTToolStripMenuItem.Text = "切り取り(T)";
            this.切り取りTToolStripMenuItem.Click += new System.EventHandler(this.切り取りTToolStripMenuItem_Click);
            // 
            // コピーCToolStripMenuItem
            // 
            this.コピーCToolStripMenuItem.Name = "コピーCToolStripMenuItem";
            this.コピーCToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.コピーCToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.コピーCToolStripMenuItem.Text = "コピー(C)";
            this.コピーCToolStripMenuItem.Click += new System.EventHandler(this.コピーCToolStripMenuItem_Click);
            // 
            // 貼り付けPToolStripMenuItem
            // 
            this.貼り付けPToolStripMenuItem.Name = "貼り付けPToolStripMenuItem";
            this.貼り付けPToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.貼り付けPToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.貼り付けPToolStripMenuItem.Text = "貼り付け(P)";
            this.貼り付けPToolStripMenuItem.Click += new System.EventHandler(this.貼り付けPToolStripMenuItem_Click);
            // 
            // 削除LToolStripMenuItem
            // 
            this.削除LToolStripMenuItem.Name = "削除LToolStripMenuItem";
            this.削除LToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.削除LToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.削除LToolStripMenuItem.Text = "削除(L)";
            this.削除LToolStripMenuItem.Click += new System.EventHandler(this.削除LToolStripMenuItem_Click);
            // 
            // 表示DToolStripMenuItem
            // 
            this.表示DToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.拡大ZToolStripMenuItem,
            this.縮小SToolStripMenuItem,
            this.toolStripSeparator4,
            this.ピッチGToolStripMenuItem});
            this.表示DToolStripMenuItem.Name = "表示DToolStripMenuItem";
            this.表示DToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.表示DToolStripMenuItem.Text = "表示(D)";
            // 
            // 拡大ZToolStripMenuItem
            // 
            this.拡大ZToolStripMenuItem.Name = "拡大ZToolStripMenuItem";
            this.拡大ZToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+(+)";
            this.拡大ZToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemplus)));
            this.拡大ZToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.拡大ZToolStripMenuItem.Text = "拡大(Z)";
            this.拡大ZToolStripMenuItem.Click += new System.EventHandler(this.拡大ZToolStripMenuItem_Click);
            // 
            // 縮小SToolStripMenuItem
            // 
            this.縮小SToolStripMenuItem.Name = "縮小SToolStripMenuItem";
            this.縮小SToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+(-)";
            this.縮小SToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemMinus)));
            this.縮小SToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.縮小SToolStripMenuItem.Text = "縮小(S)";
            this.縮小SToolStripMenuItem.Click += new System.EventHandler(this.縮小SToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(159, 6);
            // 
            // ピッチGToolStripMenuItem
            // 
            this.ピッチGToolStripMenuItem.Name = "ピッチGToolStripMenuItem";
            this.ピッチGToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.ピッチGToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.ピッチGToolStripMenuItem.Text = "ピッチ(G)";
            this.ピッチGToolStripMenuItem.Click += new System.EventHandler(this.ピッチGToolStripMenuItem_Click);
            // 
            // ツールTToolStripMenuItem
            // 
            this.ツールTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.直線LToolStripMenuItem,
            this.円弧AToolStripMenuItem,
            this.クロソイド曲線CToolStripMenuItem,
            this.toolStripSeparator5,
            this.ポリラインIToolStripMenuItem,
            this.ポリゴンGToolStripMenuItem,
            this.穴あけポリゴンHToolStripMenuItem,
            this.toolStripSeparator6,
            this.原点移動OToolStripMenuItem,
            this.toolStripSeparator8,
            this.距離測定DToolStripMenuItem,
            this.角度測定NToolStripMenuItem});
            this.ツールTToolStripMenuItem.Name = "ツールTToolStripMenuItem";
            this.ツールTToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.ツールTToolStripMenuItem.Text = "ツール(T)";
            // 
            // 直線LToolStripMenuItem
            // 
            this.直線LToolStripMenuItem.Name = "直線LToolStripMenuItem";
            this.直線LToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.直線LToolStripMenuItem.Text = "直線(L)";
            this.直線LToolStripMenuItem.Click += new System.EventHandler(this.直線LToolStripMenuItem_Click);
            // 
            // 円弧AToolStripMenuItem
            // 
            this.円弧AToolStripMenuItem.Name = "円弧AToolStripMenuItem";
            this.円弧AToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.円弧AToolStripMenuItem.Text = "円弧(A)";
            this.円弧AToolStripMenuItem.Click += new System.EventHandler(this.円弧AToolStripMenuItem_Click);
            // 
            // クロソイド曲線CToolStripMenuItem
            // 
            this.クロソイド曲線CToolStripMenuItem.Name = "クロソイド曲線CToolStripMenuItem";
            this.クロソイド曲線CToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.クロソイド曲線CToolStripMenuItem.Text = "クロソイド曲線(C)";
            this.クロソイド曲線CToolStripMenuItem.Click += new System.EventHandler(this.クロソイド曲線CToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(155, 6);
            // 
            // ポリラインIToolStripMenuItem
            // 
            this.ポリラインIToolStripMenuItem.Name = "ポリラインIToolStripMenuItem";
            this.ポリラインIToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.ポリラインIToolStripMenuItem.Text = "ポリライン(I)";
            this.ポリラインIToolStripMenuItem.Click += new System.EventHandler(this.ポリラインIToolStripMenuItem_Click);
            // 
            // ポリゴンGToolStripMenuItem
            // 
            this.ポリゴンGToolStripMenuItem.Name = "ポリゴンGToolStripMenuItem";
            this.ポリゴンGToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.ポリゴンGToolStripMenuItem.Text = "ポリゴン(G)";
            this.ポリゴンGToolStripMenuItem.Click += new System.EventHandler(this.ポリゴンGToolStripMenuItem_Click);
            // 
            // 穴あけポリゴンHToolStripMenuItem
            // 
            this.穴あけポリゴンHToolStripMenuItem.Name = "穴あけポリゴンHToolStripMenuItem";
            this.穴あけポリゴンHToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.穴あけポリゴンHToolStripMenuItem.Text = "穴あけポリゴン(H)";
            this.穴あけポリゴンHToolStripMenuItem.Click += new System.EventHandler(this.穴あけポリゴンHToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(155, 6);
            // 
            // 原点移動OToolStripMenuItem
            // 
            this.原点移動OToolStripMenuItem.Name = "原点移動OToolStripMenuItem";
            this.原点移動OToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.原点移動OToolStripMenuItem.Text = "原点移動(O)";
            this.原点移動OToolStripMenuItem.Click += new System.EventHandler(this.原点移動OToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(155, 6);
            // 
            // 距離測定DToolStripMenuItem
            // 
            this.距離測定DToolStripMenuItem.Name = "距離測定DToolStripMenuItem";
            this.距離測定DToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.距離測定DToolStripMenuItem.Text = "距離測定(D)";
            this.距離測定DToolStripMenuItem.Click += new System.EventHandler(this.距離測定DToolStripMenuItem_Click);
            // 
            // 角度測定NToolStripMenuItem
            // 
            this.角度測定NToolStripMenuItem.Name = "角度測定NToolStripMenuItem";
            this.角度測定NToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.角度測定NToolStripMenuItem.Text = "角度測定(N)";
            this.角度測定NToolStripMenuItem.Click += new System.EventHandler(this.角度測定NToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(439, 377);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(454, 30);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 377);
            this.vScrollBar1.TabIndex = 2;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(12, 410);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(439, 17);
            this.hScrollBar1.TabIndex = 3;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblDisp,
            this.lblPos});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(480, 26);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblDisp
            // 
            this.lblDisp.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblDisp.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDisp.Name = "lblDisp";
            this.lblDisp.Size = new System.Drawing.Size(181, 21);
            this.lblDisp.Text = "ピッチ:0.000mm, ピッチ分割:100";
            // 
            // lblPos
            // 
            this.lblPos.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblPos.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPos.Name = "lblPos";
            this.lblPos.Size = new System.Drawing.Size(139, 21);
            this.lblPos.Text = "99.999mm, 99.999mm";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SymbolEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(256, 256);
            this.Name = "SymbolEditor";
            this.Text = "SymbolEditor";
            this.Load += new System.EventHandler(this.SymbolEditor_Load);
            this.SizeChanged += new System.EventHandler(this.SymbolEditor_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ファイルFToolStripMenuItem;
        private ToolStripMenuItem 新規作成NToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem 開くOToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem 上書き保存SToolStripMenuItem;
        private ToolStripMenuItem 名前を付けて保存AToolStripMenuItem;
        private ToolStripMenuItem 編集EToolStripMenuItem;
        private ToolStripMenuItem 元に戻すUToolStripMenuItem;
        private ToolStripMenuItem やり直しRToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem 切り取りTToolStripMenuItem;
        private ToolStripMenuItem コピーCToolStripMenuItem;
        private ToolStripMenuItem 貼り付けPToolStripMenuItem;
        private ToolStripMenuItem 削除LToolStripMenuItem;
        private ToolStripMenuItem ツールTToolStripMenuItem;
        private ToolStripMenuItem 表示DToolStripMenuItem;
        private ToolStripMenuItem 拡大ZToolStripMenuItem;
        private ToolStripMenuItem 縮小SToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem ピッチGToolStripMenuItem;
        private ToolStripMenuItem 選択SToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripMenuItem 直線LToolStripMenuItem;
        private ToolStripMenuItem 円弧AToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem ポリラインIToolStripMenuItem;
        private ToolStripMenuItem ポリゴンGToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripMenuItem 原点移動OToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripMenuItem 距離測定DToolStripMenuItem;
        private ToolStripMenuItem 角度測定NToolStripMenuItem;
        private ToolStripMenuItem 穴あけポリゴンHToolStripMenuItem;
        private PictureBox pictureBox1;
        private VScrollBar vScrollBar1;
        private HScrollBar hScrollBar1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblDisp;
        private ToolStripStatusLabel lblPos;
        private System.Windows.Forms.Timer timer1;
        private ToolStripSeparator toolStripSeparator9;
        private ToolStripMenuItem サイズ設定ZToolStripMenuItem;
        private ToolStripMenuItem クロソイド曲線CToolStripMenuItem;
    }
}