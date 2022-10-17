namespace P02.Graphic_Editor
{
    public class GraphicEditor
    {
        public void DrawShape(IShape shape)
        {
            var drawContext = new DrawContext();
            shape.Draw(drawContext);
        }
    }
}
