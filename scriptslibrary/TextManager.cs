using System;
using OpenTK;
using StorybrewCommon.Scripting;
using StorybrewCommon.Storyboarding;
using StorybrewCommon.Subtitles;

public class TextManager
{
    private StoryboardObjectGenerator generator;
    private FontLibrary fontlibrary;
    public TextManager(StoryboardObjectGenerator generator) 
    {
        this.generator = generator;
    } 
    public void VerticalLetter(string text, int startTime, int endTime, bool heading = false, string fontStyle = "Light", float scale = 0.15f)
    {
        Vector2 position = new Vector2(320, 460);
        if(fontlibrary == null)
            fontlibrary = new FontLibrary(generator);

        if (heading)
        {
            position.Y = 240;
            position.X = 300;
            scale = 0.25f;
        }
        else
        {
            position.Y = 460;
            position.X = 320;
            scale = 0.12f;
        }
        var font = fontlibrary.GetFont(fontStyle);
        SentenceOptions SentenceOptions = new SentenceOptions(font, text, scale);

        int delay = 0;

        float letterX = position.X - SentenceOptions.Width / 2;
        float letterY = position.Y - SentenceOptions.Height / 2;

        foreach(var letter in text)
        {
            var texture = font.GetTexture(letter.ToString());
            
            var letterPosition = new Vector2(letterX, letterY)
                + texture.OffsetFor(OsbOrigin.Centre) *scale;

            if(!texture.IsEmpty)
            {
                var sprite = generator.GetLayer("TEXT").CreateSprite(texture.Path, OsbOrigin.Centre, letterPosition);
                sprite.Fade(startTime, startTime + 200, 0, 1);
                sprite.Fade(endTime, endTime + 200, 1, 0);
                sprite.Scale(startTime, scale);
            }
            delay += 50;
            letterX += texture.BaseWidth * scale;
        }
    }
    private class SentenceOptions
    {
        public float Width;
        public float Height;

        public SentenceOptions(FontGenerator font, string text, float scale)
        {
            float width = 0;
            float height = 0;
            foreach(var letter in text)
            {
                var texture = font.GetTexture(letter.ToString());
                width += texture.BaseWidth * scale / 1.2f;
                height = Math.Max(height, texture.BaseHeight) * scale;
            }
            this.Width = width;
            this.Height = height;
        }
    }
}