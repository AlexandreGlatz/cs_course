using System.ComponentModel;

namespace TU_Challenge;

public struct VECTOR3
{
    private float _x, _y, _z;
    public float X { get; set; }
    public float Y { get; set; }
    public float Z { get; set; }

    public VECTOR3(float x, float y, float z)
    {
        _x = x;
        _y = y;
        _z = z;
    }

    public float Magnitude() => float.Sqrt(_x * _x + _y * _y + _z * _z);
    public float SqrtMagnitude() => _x * _x + _y * _y + _z * _z;

    public void Normalize()
    {
        float magnitude = SqrtMagnitude();
        _x = _x / magnitude;
        _y = _y / magnitude;
        _z = _z / magnitude;
    }

    public static VECTOR3 operator +(VECTOR3 left, VECTOR3 right)
    {
        VECTOR3 res = new VECTOR3();
        res.X = left.X + right.X;
        res.Y = left.Y + right.Y;
        res.Z = left.Z + right.Z;
        return res;
    }

    public static bool operator ==(VECTOR3 left, VECTOR3 right)
    {
        float epsilon = 0.001f;
        return Math.Abs(left.X - right.X) < epsilon 
               && Math.Abs(left.Y - right.Y) < epsilon
               && Math.Abs(left.Z - right.Z) < epsilon;
    }

    public static bool operator !=(VECTOR3 left, VECTOR3 right)
    {
        float epsilon = 0.001f;
        
        if (Math.Abs(left.X - right.X) > epsilon)
            return true;
        if (Math.Abs(left.Y - right.Y) > epsilon)
            return true;
        if (Math.Abs(left.Z - right.Z) > epsilon)
            return true;

        return false;
    }
}