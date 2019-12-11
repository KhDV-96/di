﻿using System.Drawing;
using System.Linq;
using TagsCloudContainer.Visualization.Layouts;

namespace TagsCloudContainer.Visualization.Painters
{
    public class ConstantColorsPainter : IPainter
    {
        private readonly Brush textBrush;
        private readonly Brush fillBrush;
        private readonly Pen borderPen;

        public ConstantColorsPainter(Color textColor, Color fillColor, Color borderColor)
        {
            textBrush = new SolidBrush(textColor);
            fillBrush = new SolidBrush(fillColor);
            borderPen = new Pen(borderColor);
        }

        public ColorizedRectangle[] Colorize(Rectangle[] rectangles)
        {
            return rectangles
                .Select(rect => new ColorizedRectangle(rect, fillBrush, borderPen))
                .ToArray();
        }

        public ColorizedTag[] Colorize(Tag[] tags)
        {
            return tags
                .Select(tag => new ColorizedTag(tag, textBrush, fillBrush, borderPen))
                .ToArray();
        }
    }
}