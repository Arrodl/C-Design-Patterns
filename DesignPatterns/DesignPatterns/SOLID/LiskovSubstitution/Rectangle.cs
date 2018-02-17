namespace DesignPatterns.SOLID.LiskovSubstitution {
    public class Rectangle {
        public virtual int _width { get; set; }
        public virtual int _height { get; set; }
        public Rectangle() {}
        public Rectangle(int width, int height) {
            this._height = height;
            this._width = width;
        }
        public override string ToString() => $"{nameof(_width)}: {_width}, {nameof(_height)}: {_height}";
    }
}