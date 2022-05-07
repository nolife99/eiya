using OpenTK.Graphics;
using StorybrewCommon.Scripting;
using StorybrewCommon.Storyboarding;
using System;
using System.Drawing;
using System.IO;

namespace StorybrewScripts
{
    public class Effects : StoryboardObjectGenerator
    {
        public override void Generate()
        {
            Background();
            Particles(21225, 295962, 319330, 379646);

            TextManager textManager = new TextManager(this);
            textManager.VerticalLetter("凋叶棕 ft. めらみぽっぷ", 21225, 25014, true, "Bold");
            textManager.VerticalLetter("永夜 「Imperishable Challengers」", 26278, 30067, true, "Bold");
            textManager.VerticalLetter("Map and Storyboard by -Tochi", 31330, 33857, true, "Bold");
            textManager.VerticalLetter("そして昇りゆく日の光に、", 54067, 58646);
            textManager.VerticalLetter("「一回休み」を知っては。", 59120, 63541);
            textManager.VerticalLetter("満身創痍の体を抱え、", 64172, 68593);
            textManager.VerticalLetter("明ける空の下眠りゆく。", 69225, 73646);
            textManager.VerticalLetter("“ ―気がつけばあんたはどこかへ消えて、", 83909, 86593);
            textManager.VerticalLetter("朝靄に立ち尽くす私。”", 87067, 89120);
            textManager.VerticalLetter("“どうせまた、何食わぬ顔で", 89593, 91646);
            textManager.VerticalLetter("現れるのでしょう？”", 92120, 93699);
            textManager.VerticalLetter("“―秘策とは何か。勝つために常に", 94014, 96699);
            textManager.VerticalLetter("敵を知り己を知ること。”", 97172, 99383);
            textManager.VerticalLetter("“だというのに、こいつはどうして", 99541, 101909);
            textManager.VerticalLetter("寝て過ごしているんだ？”", 102067, 104278);
            textManager.VerticalLetter("そうしてまた、秋の空に", 104593, 109014);
            textManager.VerticalLetter("偽りの月が昇る。", 109330, 113436);
            textManager.VerticalLetter("さあ急げ、夜を翔べ！", 114067, 118804);
            textManager.VerticalLetter("今宵こそはと、月の照らす下。", 119120, 123857);
            textManager.VerticalLetter("蛍を追え、夜雀を追え！", 124172, 128909);
            textManager.VerticalLetter("全てはこの大儀の為すがまま。", 129225, 133962);
            textManager.VerticalLetter("仮初の", 134909, 139014);
            textManager.VerticalLetter("永遠は、", 139962, 143751);
            textManager.VerticalLetter("続くのか？", 145014, 148804);
            textManager.VerticalLetter("その彼方、", 150067, 153857);
            textManager.VerticalLetter("向かって―。", 154646, 157014);
            textManager.VerticalLetter("どこか胸が騒ぐこんな夜は、", 170278, 174699);
            textManager.VerticalLetter("歴史の影に身を潜め。", 175330, 179751);
            textManager.VerticalLetter("光る竹の一つになった方は、", 180383, 184962);
            textManager.VerticalLetter("次の夜をただ待っている。", 185436, 190014);
            textManager.VerticalLetter("“―誰しも秘密の一つや二つ", 200199, 202804);
            textManager.VerticalLetter("こっそり抱えているものでしょう？", 203120, 205330);
            textManager.VerticalLetter("私のズル休みのこと", 205646, 208014);
            textManager.VerticalLetter("は誰も知らない。”", 208172, 210067);
            textManager.VerticalLetter("“―主に先駆けて眠ることなど、", 210225, 212909);
            textManager.VerticalLetter("仕える者にあるまじきこと。", 213225, 215436);
            textManager.VerticalLetter("けれど今朝は床を並べて", 215751, 217962);
            textManager.VerticalLetter("共に眠れればと…”", 218278, 220488);
            textManager.VerticalLetter("そうしてまた、秋の空に", 220804, 225225);
            textManager.VerticalLetter("偽りの月が昇る。", 225541, 229646);
            textManager.VerticalLetter("さあ急げ、夜を翔べ！", 230278, 235014);
            textManager.VerticalLetter("月の兎は何を見上げてる。", 235330, 239751);
            textManager.VerticalLetter("永遠の、咎人が。", 240383, 244962);
            textManager.VerticalLetter("その秘密を隠して立っている。", 245436, 250014);
            textManager.VerticalLetter("偽りの", 251120, 255225);
            textManager.VerticalLetter("箱庭を、", 256172, 260278);
            textManager.VerticalLetter("壊しては、", 261225, 265172);
            textManager.VerticalLetter("もう一つの", 266278, 270067);
            textManager.VerticalLetter("結末へ―", 270857, 272593);
            textManager.VerticalLetter("幾度も夜を止めては", 276067, 280330);
            textManager.VerticalLetter("夜明けに涙を呑んだ", 281120, 285699);
            textManager.VerticalLetter("全ての「永夜の報い」を", 286488, 290436);
            textManager.VerticalLetter("受けよと、今、不滅の挑戦者達。", 290909, 296593);
            textManager.VerticalLetter("さあ遂に、辿りつく。", 298488, 303067);
            textManager.VerticalLetter("本物の満月の光の中。", 303541, 308120);
            textManager.VerticalLetter("いつか見た、昔話。", 308593, 313172);
            textManager.VerticalLetter("なよ竹の姫の御座すれば。", 313646, 318225);
            textManager.VerticalLetter("さあ元凶を、打ち倒せ！", 318699, 323278);
            textManager.VerticalLetter("けして解かれぬ難題を解き明かせ！", 323751, 328330);
            textManager.VerticalLetter("永き夜のその最後は。", 328804, 333383);
            textManager.VerticalLetter("永夜の術が、翻る。", 333857, 338436);
            textManager.VerticalLetter("仮初の", 339541, 343804);
            textManager.VerticalLetter("永遠が、", 344593, 348541);
            textManager.VerticalLetter("終わるとき。", 349646, 353593);
            textManager.VerticalLetter("本当の、", 354699, 358488);
            textManager.VerticalLetter("夜明けは。そこに―", 359278, 364488);
        }
        public void Particles(int start, int end, int start2, int end2, string layer = "particles")
        {
            for (var i = 0; i < 80; i++)
            {
                var sprite = GetLayer(layer).CreateSprite("SB/p.jpg", OsbOrigin.Centre);

                var fade = Random(0.5, 1);
                var fadeTime = Random(200, 500);
                var duration = Random(1500, 5000);
                var startX = Random(50, 590);
                var middleX = startX + Random(-100, 100);
                var endX = middleX + Random(-50, 50);

                sprite.StartLoopGroup(start + (i * 50), (end - start) / duration);
                sprite.Additive(0, duration);
                sprite.Fade(0, fadeTime, 0, fade);
                sprite.Fade(duration - fadeTime, duration, fade, 0);
                sprite.Scale(0, duration, Random(0.8, 1), Random(0.5, 1.2));
                sprite.MoveY(0, duration, Random(400, 500), Random(-20, 0));

                var shift = Random(50, 150);
                if (startX >= 320)
                {
                    sprite.MoveX(OsbEasing.InOutSine, 0, duration / 2, startX + shift, middleX + shift);
                    sprite.MoveX(OsbEasing.InOutSine, duration / 2, duration, middleX + shift, endX + shift);
                }
                else if (startX < 320)
                {
                    sprite.MoveX(OsbEasing.InOutSine, 0, duration / 2, startX - shift, middleX - shift);
                    sprite.MoveX(OsbEasing.InOutSine, duration / 2, duration, middleX - shift, endX - shift);
                }
                sprite.EndGroup();

                //particles 2
                sprite.StartLoopGroup(start2 + (i * 50), (end2 - start2) / duration);
                sprite.Additive(0, duration);
                sprite.Fade(0, fadeTime, 0, fade);
                sprite.Fade(duration - fadeTime, duration, fade, 0);
                sprite.Scale(0, duration, Random(0.8, 1), Random(0.5, 1.2));
                sprite.MoveY(0, duration, Random(400, 500), Random(-20, 0));

                if (startX >= 320)
                {
                    sprite.MoveX(OsbEasing.InOutSine, 0, duration / 2, startX + shift, middleX + shift);
                    sprite.MoveX(OsbEasing.InOutSine, duration / 2, duration, middleX + shift, endX + shift);
                }
                else if (startX < 320)
                {
                    sprite.MoveX(OsbEasing.InOutSine, 0, duration / 2, startX - shift, middleX - shift);
                    sprite.MoveX(OsbEasing.InOutSine, duration / 2, duration, middleX - shift, endX - shift);
                }
                sprite.EndGroup();

            }
        }
        public void Background()
        {
            var bg = GetLayer("BG").CreateSprite("0.jpg", OsbOrigin.Centre);
            var bgKiai = GetLayer("BG").CreateSprite("SB/2.jpg", OsbOrigin.Centre);
            var bgBlur = GetLayer("BG").CreateSprite("SB/1.jpg", OsbOrigin.Centre);
            var bgWTF = GetLayer("BG").CreateSprite("SB/3.jpg", OsbOrigin.Centre);
            var flash = GetLayer("BG").CreateSprite("SB/p.jpg", OsbOrigin.Centre);

            bg.Fade(-253, 0);
            bg.Scale(21220, 0.7);
            bg.Fade(21220, 23746, 0, 1);
            bg.Move(21220, 113436, 270, 240, 370, 240);
            bg.Fade(113436, 114541, 1, 0);
            bg.Fade(155120, 159541, 0, 1);
            bg.Move(155120, 229646, 320, 220, 320, 270);
            bg.Fade(229646, 230751, 1, 0);
            bg.Fade(276383, 277383, 0, 1);
            bg.Fade(295172, 295962, 1, 0);
            bg.Move(359120, 379646, 320, 270, 320, 220);
            bg.Fade(359120, 359751, 0, 1);
            bg.Fade(379646, 0);

            bgKiai.Scale(114694, 0.7);
            bgKiai.Fade(114694, 1);
            bgKiai.Move(114694, 159536, 270, 240, 370, 240);
            bgKiai.Fade(123536, 124641, 1, 0);
            bgKiai.Fade(124799, 1);
            bgKiai.Fade(133641, 134746, 1, 0);
            bgKiai.Fade(134904, 1);
            bgKiai.Fade(155115, 159536, 1, 0);
            bgKiai.Fade(230904, 1);
            bgKiai.Move(230904, 275747, 370, 240, 270, 240);
            bgKiai.Fade(239746, 240851, 1, 0);
            bgKiai.Fade(241010, 1);
            bgKiai.Fade(249852, 250957, 1, 0);
            bgKiai.Fade(251115, 1);
            bgKiai.Fade(271326, 275747, 1, 0);
            bgKiai.Fade(319325, 1);
            bgKiai.Move(319325, 339383, 320, 220, 320, 270);
            bgKiai.Fade(328167, 329272, 1, 0);
            bgKiai.Fade(329431, 1);
            bgKiai.Fade(338273, 339378, 1, 0);
            bgKiai.Fade(339536, 1);
            bgKiai.Move(339541, 359593, 370, 220, 270, 270);
            bgKiai.Fade(349010, 349483, 1, 0);
            bgKiai.Fade(349646, 1);
            bgKiai.Fade(359120, 359593, 1, 0);

            bgBlur.Scale(123536, 0.6333333);
            bgBlur.Fade(123536, 124799, 0, 1);
            bgBlur.Fade(124799, 0);
            bgBlur.Fade(133641, 134904, 0, 1);
            bgBlur.Fade(134904, 0);
            bgBlur.Fade(239746, 241009, 0, 1);
            bgBlur.Fade(241009, 0);
            bgBlur.Fade(249852, 251115, 0, 1);
            bgBlur.Fade(251115, 0);
            bgBlur.Fade(328167, 329430, 0, 1);
            bgBlur.Fade(329430, 0);
            bgBlur.Fade(338278, 339541, 0, 1);
            bgBlur.Fade(339541, 0);
            bgBlur.Fade(349010, 349483, 0, 0.8);
            bgBlur.Fade(349483, 349641, 0.8, 1);
            bgBlur.Fade(349641, 0);
            bgBlur.Fade(359120, 359751, 0, 1);

            bgWTF.Scale(299120, 1.1);
            bgWTF.Fade(299120, 300067, 0, 1);
            bgWTF.Move(299120, 319015, 322, 240, 253, 240);
            bgWTF.Fade(300067, 1);
            bgWTF.Fade(318067, 319015, 1, 0);
            bgWTF.Move(379646, 320, 240);
            bgWTF.Fade(379646, 1);
            bgWTF.Scale(379646, 0.65);
            bgWTF.Fade(379646, 382488, 1, 0);

            flash.ScaleVec(114694, 854, 480);
            flash.Fade(114694, 115957, 1, 0);
            flash.Fade(124799, 126062, 1, 0);
            flash.Fade(134904, 136167, 1, 0);
            flash.Fade(230904, 232167, 1, 0);
            flash.Fade(241010, 242273, 1, 0);
            flash.Fade(251115, 252378, 1, 0);
            flash.Fade(319330, 320330, 1, 0);
            flash.Fade(329431, 330694, 1, 0);
            flash.Fade(339536, 340799, 1, 0);
            flash.Fade(349641, 350904, 1, 0);
            flash.Fade(359751, 361014, 1, 0);
            flash.Fade(364804, 366067, 1, 0);
            flash.Fade(369857, 371120, 1, 0);
            flash.Fade(374909, 376172, 1, 0);
            flash.Fade(377436, 378067, 1, 0);
            flash.Fade(377751, 378382, 1, 0);
            flash.Fade(378067, 378698, 1, 0);
            flash.Fade(378383, 379015, 1, 0);
            flash.Fade(379488, 379646, 1, 0);
            flash.Fade(379646, 380593, 1, 0);
        }
    }
}
