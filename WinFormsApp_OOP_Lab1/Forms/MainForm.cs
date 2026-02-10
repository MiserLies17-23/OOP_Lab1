using System.Drawing.Text;
using WinFormsApp_OOP_Lab1.Model;

namespace WinFormsApp_OOP_Lab1
{
    public partial class MainForm : Form
    {
        private Person Person;

        public MainForm()
        {
            InitializeComponent();
            Person = new Person();
        }

        private void CreateForm_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            try
            {
                EditForm editForm = new EditForm(Person);
                editForm.ShowDialog();
                ShowData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Asterisk);
            }
        }

        private void ShowData()
        {
            GenderTextBox.Text = Person.GetMaleToString(); // Вывод поля через специальный метод
            NameTextBox.Text = Person.ToString(); // Вывод поля через переопределённый метод ToString()
            HeightTextBox.Text = Person.Height.ToString();
            WidthTextBox.Text = Person.Width.ToString(); // Вывод поля через метод ToString()
            CountryTextBox.Text = Person.Country; // Непосредственнный вывод поля
            CityTextBox.Text = Person.City;
            AgeTextBox.Text = "0x" + Person.Age.ToString("x");
        }
    }
}
