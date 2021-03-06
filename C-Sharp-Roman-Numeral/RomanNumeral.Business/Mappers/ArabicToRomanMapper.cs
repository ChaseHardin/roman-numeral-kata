﻿using System.Collections.Generic;

namespace RomanNumeral.Business.Mappers
{
    public static class ArabicToRomanMapper
    {
        public static Dictionary<int, string> Mapper = new Dictionary<int, string>
        {
            { 1, "I" },
            { 4, "IV" },
            { 5, "V" },
            { 9, "IX"},
            { 10, "X"},
            { 40, "XL"},
            { 50, "L"},
            { 90, "XC"},
            { 100, "C"},
            { 400, "LD" },
            { 500, "D" },
            { 900, "CM" },
            { 1000, "M" }
        };
    }
}