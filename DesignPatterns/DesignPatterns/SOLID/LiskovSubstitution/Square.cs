
namespace DesignPatterns.SOLID.LiskovSubstitution {
    public class Square : Rectangle {
        public override int _width {
            set { base._width = base._height = value; }
        }

        public override int _height {
            set { base._width = base._height = value; }
        }
    }
}