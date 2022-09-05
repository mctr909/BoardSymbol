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
            setList(jsonPath + "\\R", "resistor_list", Resistors);
            setList(jsonPath + "\\C", "capacitor_list", Capacitors);
            setList(jsonPath + "\\L", "inductor_list", Inductors);
            setList(jsonPath + "\\D", "diode_list", Diodes);
            setList(jsonPath + "\\Tr", "transistor_list", Transistors);
            setList(jsonPath + "\\IC", "ic_list", ICs);
            setList(jsonPath + "\\SW", "switch_list", SWs);
        }
        void setList(string path, string name, List<ImageElements> list) {
            using (var fs = new StreamReader(path + "\\parts.json")) {
                var jsonString = fs.ReadToEnd();
                var node = JsonNode.Parse(jsonString);
                if (null == node) {
                    return;
                }
                var root = node[name];
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
