using Tut2_s20123;

namespace Tut2_s20123_Tests
{
    public class Tests
    {
        private readonly IShape sphere = new Sphere(5);
        private readonly IShape cylinder = new Cylinder(3, 7);
        private readonly IShape rectangle = new Rectangle(4, 8);

        [Test]
        public void TestSphereCalculateArea()
        {
            Assert.That(sphere.CalculateArea(), Is.EqualTo(314.159).Within(0.001));
        }

        [Test]
        public void TestSphereCalculateVolume()
        {
            Assert.That(sphere.CalculateVolume(), Is.EqualTo(523.598).Within(0.001));
        }

        [Test]
        public void TestCylinderCalculateArea()
        {
            Assert.That(cylinder.CalculateArea(), Is.EqualTo(188.495).Within(0.001));
        }

        [Test]
        public void TestCylinderCalculateVolume()
        {
            Assert.That(cylinder.CalculateVolume(), Is.EqualTo(197.920).Within(0.001));
        }

        [Test]
        public void TestRectangleCalculateArea()
        {
            Assert.That(rectangle.CalculateArea(), Is.EqualTo(32.0).Within(0.001));
        }

        [Test]
        public void TestRectangleCalculateVolumeIsZero()
        {
            Assert.That(rectangle.CalculateVolume(), Is.EqualTo(0.0));
        }

        [Test]
        public void TestCylinderZeroRadiusReturnsZeroArea()
        {
            IShape cylinder = new Cylinder(0, 7);
            Assert.That(cylinder.CalculateArea(), Is.EqualTo(0.0));
        }

        [Test]
        public void TestCylinderZeroRadiusReturnsZeroVolume()
        {
            IShape cylinder = new Cylinder(0, 7);
            Assert.That(cylinder.CalculateVolume(), Is.EqualTo(0.0));
        }

        [Test]
        public void TestCylinderZeroHeightReturnsZeroVolume()
        {
            IShape cylinder = new Cylinder(3, 0);
            Assert.That(cylinder.CalculateVolume(), Is.EqualTo(0.0));
        }

        [Test]
        public void TestRectangleZeroLengthReturnsZeroArea()
        {
            IShape zeroLengthRectangle = new Rectangle(0, 8);
            Assert.That(zeroLengthRectangle.CalculateArea(), Is.EqualTo(0.0));
        }

        [Test]
        public void TestRectangleZeroLengthReturnsZeroVolume()
        {
            IShape zeroLengthRectangle = new Rectangle(0, 8);
            Assert.That(zeroLengthRectangle.CalculateVolume(), Is.EqualTo(0.0));
        }

        [Test]
        public void TestCubeCalculateArea()
        {
            IShape cube = new Cube(4);
            Assert.That(cube.CalculateArea(), Is.EqualTo(96.0).Within(0.001));
        }

        public void TestCubeZeroSideReturnsZeroArea()
        {
            IShape zeroSideCube = new Cube(0);
            Assert.That(zeroSideCube.CalculateArea(), Is.EqualTo(0.0));
        }

        [Test]
        public void TestCubeZeroSideReturnsZeroVolume()
        {
            IShape zeroSideCube = new Cube(0);
            Assert.That(zeroSideCube.CalculateVolume(), Is.EqualTo(0.0));
        }

        [Test]
        public void TestCubeCalculateVolume()
        {
            IShape cube = new Cube(4);
            Assert.That(cube.CalculateVolume(), Is.EqualTo(64.0).Within(0.001));
        }
    }
}
