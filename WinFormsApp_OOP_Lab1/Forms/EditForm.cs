using System;
using System.Windows.Forms;
using WinFormsApp_OOP_Lab1.Model;

namespace WinFormsApp_OOP_Lab1
{
    public partial class EditForm : Form
    {
        private Person Person;

        public EditForm()
        {
            InitializeComponent();
            Load_ComboBox();
            Person = new Person();
        }

        public EditForm(Person person)
        {
            InitializeComponent();
            Load_ComboBox();
            this.Person = person;
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
            GenderComboBox.SelectedValue = Person.Gen;
            NameTextBox.Text = Person.Name; 
            HeightTextBox.Text = Person.Height.ToString();
            WidthTextBox.Text = Person.Width.ToString();
            CountryTextBox.Text = Person.Country; 
            CityTextBox.Text = Person.City;
            AgeTextBox.Text = Person.Age.ToString();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                Person.Gen = (Gender)GenderComboBox.SelectedValue;
                Person.Name = NameTextBox.Text;
                Person.Height = Convert.ToInt32(HeightTextBox.Text);
                Person.Width = Convert.ToInt32(WidthTextBox.Text);
                Person.Age = Convert.ToInt32(AgeTextBox.Text);
                Person.City = CityTextBox.Text;
                Person.Country = CountryTextBox.Text;

                MessageBox.Show("Данные успешно обновлены!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Asterisk);
            }
        }
    }
}
