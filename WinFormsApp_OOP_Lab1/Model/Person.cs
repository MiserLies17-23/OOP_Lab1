using WinFormsApp_OOP_Lab1.util;

namespace WinFormsApp_OOP_Lab1.Model
{
    public class Person
    {
        private static int _count;
        private Gender _gen;
        private string _name;
        private float _height;
        private float _width;
        private string _city;
        private string _country;
        private int _age;

        public int Count { get => _count; set => _count = value; }

        public Gender Gen { get => _gen; set => _gen = value; }

        public string Name
        {
            get => _name;
            set
            {
                Validation.StringParamValidation(value); // Таким же образом заменить везде
                _name = value;
            }
        }

        public float Height
        {
            get => _height;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Рост не может быть отрицательным!");
                if (value > 250)
                    throw new ArgumentException("Слишком большой рост!");
                _height = value;
            }
        }

        public float Width
        {
            get => _width;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Вес не может быть отрицательным!");
                _width = value;

            }
        }

        public int Age
        {
            get => _age;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Возраст не может быть отрицательным!");
                if (value > 120)
                    throw new ArgumentException("Слишком большой возраст!");
                _age = value;
            }
        }

        public string Country
        {
            get => _country;
            set
            {
                if (value == "")
                    throw new ArgumentNullException("Название страны не может быть пустым!");
                _country = value;
            }
        }

        public string City 
        { 
            get => _city;
            set
            {
                if (value == "")
                    throw new ArgumentNullException("Название страны не может быть пустым!");
                _city = value;
            }
        }

        public Person()
        {
            Gen = Gender.MALE;
            Name = "Undefinded";
            Height = 170;
            Width = 65;
            Age = 20;
            Country = "Undefinded";
            City = "Undefinded";
            Count++;
        }

        public Person(Gender gender) : this()
        {
            Gen = gender;
        }

        public Person(Gender gender, string name) : this()
        {
            
            Gen = gender;
            Name = name;
        }

        public Person(Gender gender, string name, float height, float width, int age,
            string country, string city) : this()
        {
            Gen = gender;
            Name = name;
            Height = height;
            Width = width;
            Age = age;
            Country = country;
            City = city;
        }

        public string GetMaleToString()
        {
            if (Gen == Gender.FEMALE)
                return "Жен";
            return "Муж";
        }

        public override string ToString()
        {
            return Name;
        }
    }
}