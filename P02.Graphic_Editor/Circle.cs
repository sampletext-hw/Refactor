﻿using System;
using System.Collections.Generic;
using System.Text;

namespace P02.Graphic_Editor
{
    public class Circle : IShape
    {
        public void Draw(GraphicEditor editor)
        {
            Console.WriteLine("I am Circle");
        }
    }
}
