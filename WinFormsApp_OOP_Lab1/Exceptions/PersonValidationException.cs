using System;

namespace WinFormsApp_OOP_Lab1.Exceptions
{
    public class PersonValidationException : Exception
    {
        public string FieldName { get; }
        public string InvalidValue { get; }
        public DateTime ErrorTime { get; }

        public PersonValidationException(string message,
                                         string fieldName,
                                         string invalidValue)
            : base(message)
        {
            FieldName = fieldName;
            InvalidValue = invalidValue;
            ErrorTime = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{Message}\nПоле: {FieldName}\nЗначение: {InvalidValue}\nВремя: {ErrorTime}";
        }
    }
}
