namespace WebApiCodeTest
{
    public interface IShapeFactory
    {
        public IShape GetShape(ShapeEnum shapeEnum);
    }
}
