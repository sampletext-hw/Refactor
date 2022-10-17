namespace P02.Graphic_Editor
{
    public class Square : IShape
    {
        public void Draw(DrawContext context)
        {
            context.DrawSquare();
        }
    }
}
