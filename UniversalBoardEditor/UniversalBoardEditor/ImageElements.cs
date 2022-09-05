using System.Text.Json.Nodes;

namespace UniversalBoardEditor {
    public struct Sprite {
        public int Cols { get; private set; }
        public int Rows { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }
        public Sprite(int cols, int rows, int width, int height) {
            Cols = cols;
            Rows = rows;
            Width = width;
            Height = height;
        }
    }

    internal class ImageElements {
        public string ImageName { get; private set; }
        public Bitmap? Image { get; private set; } = null;
        public bool IsSMD { get; private set; }
        public Point Pivot { get; private set; } = new Point();
        public Bitmap? Texture { get; private set; } = null;
        public Sprite TextureSprite { get; private set; } = new Sprite();
        public List<Point> TexturePos { get; private set; } = new List<Point>();
        public List<Point> Tarminals { get; private set; } = new List<Point>();
        public ImageElements(string path, JsonNode node) {
            /* parts_name */
            var tmp = node["parts_name"];
            ImageName = null == tmp ? "" : tmp.GetValue<string>();
            /* file_name */
            tmp = node["file_name"];
            if (null != tmp) {
                var imgPath = path + "\\" + tmp.GetValue<string>();
                if (File.Exists(imgPath)) {
                    Image = new Bitmap(imgPath);
                }
            }
            /* smd */
            tmp = node["smd"];
            IsSMD = null == tmp ? false : tmp.GetValue<bool>();
            /* pivot */
            tmp = node["pivot"];
            if (null == tmp) {
                Pivot = new Point(0, 0);
            } else {
                var arr = tmp.AsArray();
                Pivot = null == tmp ? new Point(0, 0) : new Point(arr[0].GetValue<int>(), arr[1].GetValue<int>());
            }
            /* texture */
            tmp = node["texture"];
            if (null == tmp) {
                TextureSprite = new Sprite();
            } else {
                var arr1 = tmp.AsArray();
                var texPath = path + "\\" + arr1[0].GetValue<string>();
                if (File.Exists(texPath)) {
                    Texture = new Bitmap(texPath);
                    var arr11 = arr1[1].AsArray();
                    var arr12 = arr1[2].AsArray();
                    TextureSprite = new Sprite(
                        arr11[0].GetValue<int>(), arr11[1].GetValue<int>(),
                        arr12[0].GetValue<int>(), arr12[1].GetValue<int>()
                    );
                }
            }
            /* texture_pos */
            tmp = node["texture_pos"];
            if (null == tmp) {
                TexturePos = new List<Point>();
            } else {
                var arr1 = tmp.AsArray();
                foreach (var arr in arr1) {
                    var arr2 = arr.AsArray();
                    TexturePos.Add(new Point(arr2[0].GetValue<int>(), arr2[1].GetValue<int>()));
                }
            }
            /* tarminal */
            tmp = node["tarminal"];
            if (null == tmp) {
                Tarminals = new List<Point>();
            } else {
                var arr1 = tmp.AsArray();
                foreach (var arr in arr1) {
                    var arr2 = arr.AsArray();
                    Tarminals.Add(new Point(arr2[0].GetValue<int>(), arr2[1].GetValue<int>()));
                }
            }
        }
    }
}
