using System;
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
                    "Некорректный рост! Рост должен быть в пределах от 0 до 250 см!",
                    "Height",
                    value.ToString()
                );
        }

        public static void WidthValidation(double value)
        {
            if (value <= 0 || value > 300)
                throw new PersonValidationException(
                    "Некорректный вес! Вес должен быть в пределах от 0 до 300 кг!",
                    "Weight",
                    value.ToString()
                );
        }

        public static void AgeValidation(int value)
        {
            if (value < 0 || value > 120)
                throw new PersonValidationException(
                    "Некорректный возраст! Возраст должен быть в пределах от 0 до 120 лет!",
                    "Age",
                    value.ToString()
                );
        }
    }
}
