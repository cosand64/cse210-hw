
class Cylinder
{
    Circle _circle;
    double _height;

    public double GetCylinderVolume()
    {
        return _circle.GetArea() * _height;
    }
}