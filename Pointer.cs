namespace HitmanStatistics {
    public class Pointer {
        public int address { get; private set; }
        public int[] offsets { get; private set; }

        public Pointer(int add, int[] off) {
            address = add;
            offsets = off;
        }
    }
}
