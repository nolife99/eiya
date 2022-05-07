using OpenTK.Graphics;
using StorybrewCommon.Scripting;
using StorybrewCommon.Subtitles;

public class FontLibrary
{
    private StoryboardObjectGenerator generator;
    private ProjectFont[] fontLibrary;
    public FontLibrary(StoryboardObjectGenerator generator)
    {
        this.generator = generator;
        SetFontLibrary();
    }
    public FontGenerator GetFont(string fontName)
    {
        foreach(var font in fontLibrary)
        {
            if(font.fontName == fontName)
                return font.font;
        }
        generator.Log($"Font {fontName} not found");
        return null;
    }
    private void SetFontLibrary()
    {
        ProjectFont[] library = new ProjectFont[]
        {
            SetFont("Light"),
            SetFont("Black"),
            SetFont("Bold"),
            SetFont("ExtraLight"),
            SetFont("Medium"),
            SetFont("Regular"),
            SetFont("SemiBold")
        };
        fontLibrary = library;
    }
    private ProjectFont SetFont(string fontName)
    {
        var font = generator.LoadFont($"sb/f/{fontName}", new FontDescription
        {
            FontPath = $"font/NotoSerifJP-{fontName}.otf",
            FontSize = 100,
            FontStyle = System.Drawing.FontStyle.Regular,
            Color = Color4.White
        });
        return new ProjectFont(font, fontName);
    }
    private class ProjectFont
    {
        public FontGenerator font;
        public string fontName;

        public ProjectFont(FontGenerator font, string fontName)
        {
            this.font = font;
            this.fontName = fontName;
        }
    }
}