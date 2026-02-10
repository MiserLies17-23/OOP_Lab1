using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_OOP_Lab1.util
{
    public static class Validation
    {
        public static void StringParamValidation(string name)
        {
            if (name == "")
                throw new ArgumentNullException("Значение не может быть пустым!");
            if (name.Length <= 1)
                throw new ArgumentException("Длина значения не может быть меньше одного символа!");
            // Добавить про цифры

        }
    }
}
