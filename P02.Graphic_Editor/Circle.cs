namespace P02.Graphic_Editor
{
    public class Circle : IShape
    {
        public void Draw(DrawContext editor)
        {
            editor.DrawCircle();
        }
    }
}
