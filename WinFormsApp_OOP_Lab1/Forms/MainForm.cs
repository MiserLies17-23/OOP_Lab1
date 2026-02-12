using System;
using System.Windows.Forms;
using WinFormsApp_OOP_Lab1.Exceptions;
using WinFormsApp_OOP_Lab1.Model;

namespace WinFormsApp_OOP_Lab1
{
    public partial class MainForm : Form
    {
        private Person _person;

        private HelloForm _helloForm;

        private EditForm _editForm;
        public MainForm()
        {
            InitializeComponent();
            _person = new Person();
            _helloForm = new HelloForm();
            _editForm = new EditForm(_person);


        }

        private void CreateForm_Load(object sender, EventArgs e)
        {
            _helloForm.ShowDialog();
            ShowData();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            try
            {

                _editForm.ShowDialog();
                ShowData();
            }
            catch (PersonValidationException ex)
            {
                ExceptionHandler.MessageBox(
                    IntPtr.Zero,
                    ex.ToString(),
                    "Ошибка валидации",
                    16);
            }
            catch (OutOfMemoryException ex)
            {
                ExceptionHandler.MessageBox(
                    IntPtr.Zero,
                    ex.ToString(),
                    "Ошибка переполнения памяти",
                    16);
            }
        }

        private void ShowData()
        {
            CountLabel.Text += Person.Count;
            GenderTextBox.Text = _person.GetMaleToString(); // Вывод поля через специальный метод
            NameTextBox.Text = _person.ToString(); // Вывод поля через переопределённый метод ToString()
            HeightTextBox.Text = _person.Height.ToString();
            WidthTextBox.Text = _person.Width.ToString(); // Вывод поля через метод ToString()
            CountryTextBox.Text = _person.Country; // Непосредственнный вывод поля
            CityTextBox.Text = _person.City;
            AgeTextBox.Text = "0x" + _person.Age.ToString("x");
            CurrentLabel.Text += Person.Persons.IndexOf(_person).ToString();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
