using System.Text.Json.Nodes;

namespace UniversalBoardEditor {
    internal class ImageLoader {
        public List<ImageElements> Resistors { get; private set; } = new List<ImageElements>();
        public List<ImageElements> Capacitors { get; private set; } = new List<ImageElements>();
        public List<ImageElements> Inductors { get; private set; } = new List<ImageElements>();
        public List<ImageElements> Diodes { get; private set; } = new List<ImageElements>();
        public List<ImageElements> Transistors { get; private set; } = new List<ImageElements>();
        public List<ImageElements> ICs { get; private set; } = new List<ImageElements>();
        public List<ImageElements> SWs { get; private set; } = new List<ImageElements>();
        public ImageLoader(string jsonPath) {
            setList(jsonPath + "\\R", Resistors);
            setList(jsonPath + "\\C", Capacitors);
            setList(jsonPath + "\\L", Inductors);
            setList(jsonPath + "\\D", Diodes);
            setList(jsonPath + "\\Tr", Transistors);
            setList(jsonPath + "\\IC", ICs);
            setList(jsonPath + "\\SW", SWs);
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
    }
}
