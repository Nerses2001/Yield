﻿
using System.Collections;

namespace Yield
{
    internal class UseerCollection
    {
       public static  IEnumerable Power() 
        {
            yield return "Hello Word";
            yield return "Hello Word";
            yield return "Hello Word";
            yield return "Hello Word";
            yield return "Hello Word";
        }

        public static IEnumerable NoPower()
        {
            yield break;
        }

        public static IEnumerable InragerIenum()
        {
            yield return 5562;
            yield return 62;
            yield return 212;
            yield return 51;
            yield return 254;
        }

        public static IEnumerable Objejcts()
        {
            yield return 5562;
            yield return "sad";
            yield return "asda";
            yield return false;
            yield return 56.5;
        }

    }
}
