using System;

namespace H4ProvinceEditor {
    class DefItem {
        public int Id { get; }
        public int R { get; }
        public int G { get; }
        public int B { get; }
        public string Type { get; }
        public bool Coastal { get; }
        public string Terrain { get; }
        public int Continent { get; }

        public DefItem(string line) {
            var split = line.Split(';');
            Id = Int32.Parse(split[0]);
            R = Int32.Parse(split[1]);
            G = Int32.Parse(split[2]);
            B = Int32.Parse(split[3]);
            Type = split[4];
            Coastal = Convert.ToBoolean(split[5]);
            Terrain = split[6];
            Continent = Int32.Parse(split[7]);
        }

        public string GetRGBString() {
            return $"{R};{G};{B}";
        }
    }
}
