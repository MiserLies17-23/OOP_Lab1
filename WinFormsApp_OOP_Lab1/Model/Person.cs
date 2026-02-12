using WinFormsApp_OOP_Lab1.util;

namespace WinFormsApp_OOP_Lab1.Model
{
    public class Person
    {
        private static int _count = 0;
        private static List<Person> _persons = [];

        private Gender _gen;
        private string _name;
        private double _height;
        private double _width;
        private string _city;
        private string _country;
        private int _age;

        public static int Count { get => _count; set => _count = value; }

        public Gender Gen { get => _gen; set => _gen = value; }

        public string Name
        {
            get => _name;
            set
            {
                Validation.StringParamValidation(value, nameof(Name)); 
                _name = value;
            }
        }

        public double Height
        {
            get => _height;
            set
            {
                Validation.HeightValidation(value);
                _height = value;
            }
        }

        public double Width
        {
            get => _width;
            set
            {
                Validation.WidthValidation(value);
                _width = value;

            }
        }

        public int Age
        {
            get => _age;
            set
            {
                Validation.AgeValidation(value);
                _age = value;
            }
        }

        public string Country
        {
            get => _country;
            set
            {
                Validation.StringParamValidation(value, nameof(Country));
                _country = value;
            }
        }

        public string City 
        { 
            get => _city;
            set
            {
                Validation.StringParamValidation(value, nameof(City));
                _city = value;
            }
        }

        public static List<Person> Persons
        {
            get => _persons;
            set => _persons = value;
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
            Persons.Add(this);
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