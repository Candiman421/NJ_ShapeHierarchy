namespace Sharp.Business.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CircleToStringIsCircle()
        {
            var circle = new Circle(6);
            string asString = circle.ToString();
            asString.Should().Be("Circle");
        }
    }
}