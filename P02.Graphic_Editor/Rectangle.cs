namespace P02.Graphic_Editor
{
    public class Rectangle : IShape
    {
        public void Draw(DrawContext context)
        {
            context.DrawRect();
        }
    }
}
