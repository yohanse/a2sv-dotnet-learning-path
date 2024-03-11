interface IShape
{
    string Name;
}


class Rectangle {
    decimal height;
    decimal width;
    public Rectangle(decimal width, decimal height) {
        this.height = height;
        this.width = width;
    }

    public override string ToString() {
        return $"{height} by {width}";
    }
}