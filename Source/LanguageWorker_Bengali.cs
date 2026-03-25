// ==== Source/LanguageWorker_Bengali.cs ====
using System;
using System.Collections.Generic;
using Verse;

namespace BetterRimworlds
{
    public class LanguageWorker_Bengali : LanguageWorker
    {
        // Bengali grammar notes:
        // - Script: Bengali script (বাংলা লিপি), written Left-to-Right.
        // - Articles: Bengali has no indefinite or definite articles (like Hindi/Urdu).
        //   Definiteness is expressed via demonstratives or context, not a separate word.
        // - Plurals: Two-case system (singular for 1, plural for everything else).
        //   Plural often formed with suffixes like -রা (-ra) for people, -গুলো (-gulo)
        //   for objects — but in RimWorld context, pre-pluralized strings are used.
        // - Ordinals: Generally gender-neutral in standard modern Bengali.
        //   Formed with suffix -তম (-tôm) for most numbers; first few are irregular.

        public override string WithIndefiniteArticle(
            string str,
            Gender gender,
            bool plural = false,
            bool name = false
        )
        {
            if (str.NullOrEmpty())
                return "";

            // Bengali has no indefinite article equivalent to "a/an".
            // Indefiniteness is conveyed through context or the numeral এক (ek, "one").
            return str;
        }

        public override string WithDefiniteArticle(
            string str,
            Gender gender,
            bool plural = false,
            bool name = false
        )
        {
            if (str.NullOrEmpty())
                return "";

            // Bengali has no definite article equivalent to "the".
            // Definiteness is conveyed through demonstratives like এই (ei) or সেই (sei).
            return str;
        }

        public override string PostProcessed(string str)
        {
            // Bengali is LTR; standard space merging from base class is sufficient.
            return base.PostProcessed(str);
        }

        public override string ResolveNumCase(float number, List<string> args)
        {
            if (args == null || args.Count == 0)
                return null;

            List<string> forms = new List<string>(args.Count);
            for (int i = 0; i < args.Count; i++)
                forms.Add(args[i]?.Trim('\'') ?? "");

            // Decimal numbers are treated as plural/other in Bengali.
            if (number - (float)Math.Floor(number) > float.Epsilon)
            {
                string form = forms.Count > 1 ? forms[1] : forms[0];
                return $"{number} {form}";
            }

            int n = (int)number;

            // Bengali plural rule: 1 is singular, everything else is plural.
            if (forms.Count == 1)
                return $"{n} {forms[0]}";

            // If 3 forms are provided (one, several, many), map them logically.
            if (forms.Count >= 3)
            {
                string result = GetFormForNumber(n, forms[0], forms[1], forms[2]);
                return $"{n} {result}";
            }

            // Standard 2-form fallback (one, other).
            string chosen = (n == 1) ? forms[0] : forms[1];
            return $"{n} {chosen}";
        }

        protected override string GetFormForNumber(
            int num,
            string formOne,
            string formSeveral,
            string formMany
        )
        {
            // Bengali mapping for RimWorld's internal 3-form logic.
            if (num == 1)
                return formOne;

            // Use "several" form for small counts (2–10).
            if (num >= 2 && num <= 10)
                return formSeveral;

            return formMany;
        }

        public override string OrdinalNumber(int number, Gender gender = Gender.None)
        {
            // Bengali ordinals are largely gender-neutral in modern standard Bengali.
            // The first few are irregular; beyond that, -তম (-tôm) is the standard suffix.
            return number switch
            {
                1 => "প্রথম",    // prôthôm  — first
                2 => "দ্বিতীয়",  // dwitiyo  — second
                3 => "তৃতীয়",    // tritiyô  — third
                4 => "চতুর্থ",    // côturthô — fourth
                5 => "পঞ্চম",    // pônchôm  — fifth
                6 => "ষষ্ঠ",     // shôsthô  — sixth
                7 => "সপ্তম",    // shôptôm  — seventh
                8 => "অষ্টম",    // ôshtôm   — eighth
                9 => "নবম",     // nôbôm    — ninth
                10 => "দশম",    // dôshôm   — tenth
                _ => number + "তম" // General ordinal suffix -তম (-tôm)
            };
        }
    }
}
