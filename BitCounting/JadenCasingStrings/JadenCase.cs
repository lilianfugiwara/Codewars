using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JadenCasingStrings
{
    public static class JadenCase
    {
        public static string ToJadenCase(this string phrase)
        {
            char[] phraseArray = phrase.ToCharArray();
            for (int i = 0; i < phraseArray.Length; i++)
            {
                if (i == 0 || phraseArray[i-1]==' ')
                {
                    phraseArray[i] = char.ToUpper(phraseArray[i]);
                }
            }
            string jadenPhrase = new string(phraseArray);
            return jadenPhrase;
        }
    }
}
