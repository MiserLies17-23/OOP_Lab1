using System;
using System.Windows.Forms;
using WinFormsApp_OOP_Lab1.Exceptions;
using WinFormsApp_OOP_Lab1.Model;

namespace WinFormsApp_OOP_Lab1
{
    public partial class EditForm : Form
    {
        private Person _person;

        public EditForm()
        {
            InitializeComponent();
            Load_ComboBox();
            _person = new Person();
        }

        public EditForm(Person person)
        {
            InitializeComponent();
            Load_ComboBox();
            _person = person;
        }

        private void Load_ComboBox()
        {
            var displayValues = new Dictionary<Gender, string>
            {
                { Gender.MALE, "Муж" },
                { Gender.FEMALE, "Жен" },

            };
            GenderComboBox.DataSource = new BindingSource(displayValues, null);
            GenderComboBox.DisplayMember = "Value";
            GenderComboBox.ValueMember = "Key";
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        public void ShowData()
        {
            GenderComboBox.SelectedValue = _person.Gen;
            NameTextBox.Text = _person.Name; 
            HeightTextBox.Text = _person.Height.ToString();
            WidthTextBox.Text = _person.Width.ToString();
            CountryTextBox.Text = _person.Country; 
            CityTextBox.Text = _person.City;
            AgeTextBox.Text = _person.Age.ToString();
            CurrentLabel.Text += Person.Persons.IndexOf(_person).ToString();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                _person.Gen = (Gender)GenderComboBox.SelectedValue;
                _person.Name = NameTextBox.Text;
                _person.Height = Convert.ToDouble(HeightTextBox.Text);
                _person.Width = Convert.ToDouble(WidthTextBox.Text);
                _person.Age = Convert.ToInt32(AgeTextBox.Text);
                _person.City = CityTextBox.Text;
                _person.Country = CountryTextBox.Text;

                MessageBox.Show("Данные успешно обновлены!");
                Close();
            }
            catch (PersonValidationException ex)
            {
                ExceptionHandler.MessageBox(
                    IntPtr.Zero,
                    ex.ToString(),
                    "Ошибка валидации",
                    16);
            }

        }
    }
}
