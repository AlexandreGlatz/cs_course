namespace TU_Challenge;

public struct VECTOR3
{
    private float _x, _y, _z;
    public float X { get; set; }
    public float Y { get; set; }
    public float Z { get; set; }

    private float Magnitude() => float.Sqrt(_x * _x + _y * _y + _z * _z);
    public float SqrtMagnitude() => _x * _x + _y * _y + _z * _z;

    public static VECTOR3 operator +(VECTOR3 left, VECTOR3 right)
    {
        left.X = left.X + right.X;
        left.Y = left.Y + right.Y;
        left.Z = left.Z + right.Z;

    }
}