using CodingChallenge.Data.Classes;
using CodingChallenge.Data.Entities;
using System;

namespace CodingChallenge.Data.Contracts
{
    public class LanguageFactory
    {
        public static ILanguage GetLanguage(ELanguages eLanguages) {
            ILanguage _iLanguage;

            switch (eLanguages)
            {
                case ELanguages.English:
                    _iLanguage = new English();
                    break;

                case ELanguages.Spanish:
                    _iLanguage = new Spanish();
                    break;
                    
                default:
                    throw new Exception("Unsupported Language.");
            }

            return _iLanguage;
        }
    }
}