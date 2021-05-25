using System;
using Xunit;

namespace Chinese.Words.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var lexicon = new ChineseLexicon(Additional.CommonWords, Builtin.ChineseChars);
            using (var scope = lexicon.BeginScope())
            {
                var pinyin = Pinyin.GetString("�������������������ѡ��");
            }
        }
    }
}
