using System.Collections;
using System.Security.Cryptography;

namespace TU_Challenge.Tests;

[TestFixture]
public class Test_Vector3
{
    [Test]
    [TestCase(1.0f, 2.0f, 3.0f)]
    [TestCase(1.011f, 2.548f, 4.458f)]
    [TestCase(float.MinValue, float.MaxValue, 0.0f)]
    public void TestCreation(float x, float y, float z)
    {
        VECTOR3 test = new VECTOR3(x, y, z);

        Assert.That(test.X, Is.EqualTo(x).Within(0.0001f));
        Assert.That(test.Y, Is.EqualTo(y).Within(0.0001f));
        Assert.That(test.Z, Is.EqualTo(z).Within(0.0001f));
    }

    [Test]
    [TestCase(3f, 4f,5f, 7.07106f)]
    [TestCase(-3f, -4f,-5f, 7.07106f)]
    [TestCase(2f, 3f,6f, 7)]
    [TestCase(0f,0f,0f,0f)]
    public void TestMagnitude(float x, float y, float z, float expected)
    {
        VECTOR3 test = new VECTOR3(x, y, z);
        
       Assert.That(test.Magnitude(), Is.EqualTo(expected).Within(0.0001f)); 
    }

    [Test]
    [TestCase(3f, 4f,5f, 50f)]
    [TestCase(-3f, -4f,-5f, 50f)]
    [TestCase(2f, 3f,6f, 49f)]
    [TestCase(0f,0f,0f,0f)]
    public void TestSqrtMagnitude(float x, float y, float z, float expected)
    {
        VECTOR3 test = new VECTOR3(x,y,z);
        
        Assert.That(test.SqrtMagnitude(), Is.EqualTo(expected).Within(0.001f));
    }

    [Test]
    [TestCase(3,4,5,0.42426454f,0.56568605f,0.70710756f)]
    [TestCase(0.1f, 0.2f, -0.3f, 0.267f, 0.535f, -0.802f)] 
    [TestCase(-10.5f, 0.25f, 3.33f, -0.952f, 0.023f, 0.302f)]
    public void TestNormalize(float x, float y, float z, float rx, float ry, float rz)
    {
        VECTOR3 test = new VECTOR3(x, y, z);

        VECTOR3 expected = new VECTOR3(rx, ry, rz);
        
        test.Normalize();
        Assert.That(test, Is.EqualTo(expected));
    }

    [Test]
    [TestCase(1f,1f,1f,2f,2f,2f,3f,3f,3f)]
    public void TestAddition(float x, float y, float z, float x2, float y2, float z2, float rx, float ry, float rz)
    {
        VECTOR3 test = new VECTOR3(x, y, z);
        VECTOR3 test1 = new VECTOR3(x2, y2, z2);
        VECTOR3 expected = new VECTOR3(rx, ry, rz);

        Assert.That(test + test1, Is.EqualTo(expected));
    }

}