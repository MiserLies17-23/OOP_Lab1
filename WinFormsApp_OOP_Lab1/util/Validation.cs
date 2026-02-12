using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp_OOP_Lab1.Exceptions;

namespace WinFormsApp_OOP_Lab1.util
{
    public static class Validation
    {
        public static void StringParamValidation(string value, string typeName)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new PersonValidationException(
                    "Строка не может быть пустой!",
                    typeName,
                    value
                );
            if (value.Length < 2) 
                throw new PersonValidationException(
                    "Минимальная длина — 2 символа!",
                    typeName,
                    value
                );
            if (value.Any(char.IsDigit))
                throw new PersonValidationException(
                    "Строка не должна содержать цифры!", 
                    typeName, 
                    value);
        }

        public static void HeightValidation (double value)
        {
            if (value <= 0 || value > 250)
                throw new PersonValidationException(
                    "Некорректный рост!",
                    "Height",
                    value.ToString()
                );
        }

        public static void WidthValidation(double value)
        {
            if (value <= 0 || value > 300)
                throw new PersonValidationException(
                    "Некорректный вес!",
                    "Weight",
                    value.ToString()
                );
        }

        public static void AgeValidation(int value)
        {
            if (value < 0 || value > 120)
                throw new PersonValidationException(
                    "Некорректный возраст!",
                    "Age",
                    value.ToString()
                );
        }
    }
}
