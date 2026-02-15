using WinFormsApp_OOP_Lab1.Exceptions;
using WinFormsApp_OOP_Lab1.Model;

namespace WinFormsApp_OOP_Lab2
{
    public partial class MainForm : Form
    {
        
        private PersonStack personStack;

        private EventProcessing eventProcessing;
        public MainForm()
        {
            InitializeComponent();
            personStack = new PersonStack();
            eventProcessing = new(ActivityLabel, personStack);
            ShowStackContent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Бригада 13: Пономарев П., Толстоухов В.\n Вариант 13: Человек. Stack",
                "Лабораторная работа №2");
            MeasureListView_Load();
        }
        private void MeasureListView_Load()
        {
            MeasureListView.Columns.Clear();

            MeasureListView.Columns.Add("Структура", 100);
            MeasureListView.Columns.Add("Время вставки (мс)", 150);
            MeasureListView.Columns.Add("Последовательная выборка (мс)", 250);
            MeasureListView.Columns.Add("Случайная выборка (мс)", 190);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (personStack.Stack.Count > 0)
                    personStack.RemoveItem();
                else
                    MessageBox.Show("Нельзя удалить элемент: стэк пуст!", "Ошибка удаления");
                ShowStackContent();
            }
            catch (Exception ex)
            {
                ExceptionHandler.MessageBox(
                    IntPtr.Zero,
                    ex.ToString(),
                    "Ошибка удаления",
                    16);
            }
        }

        private void AddButton_Click(Object sender, EventArgs e)
        {
            try
            {
                Person p = RandomValuesGenerator.CreateRandomPerson();
                personStack.AddItem(p);
                ShowStackContent();
            }
            catch (Exception ex)
            {
                ExceptionHandler.MessageBox(
                    IntPtr.Zero,
                    ex.ToString(),
                    "Ошибка добавления",
                    16);
            }
        }

        private void CompareButton_Click (object sender, EventArgs e)
        {
            MeasureListView.Items.Clear();
            ListViewItem stackItem = new("Cтэк");
            stackItem.SubItems.Add(MeasureComponent.InsertInStack().ToString());
            stackItem.SubItems.Add(MeasureComponent.ConsistentStackSelection().ToString());
            stackItem.SubItems.Add(MeasureComponent.RandomStackSelection().ToString());
            MeasureListView.Items.Add(stackItem);

            ListViewItem arrayItem = new("Массив");
            arrayItem.SubItems.Add(MeasureComponent.InsertInArray().ToString());
            arrayItem.SubItems.Add(MeasureComponent.ConsistentArraySelection().ToString());
            arrayItem.SubItems.Add(MeasureComponent.RandomArraySelection().ToString());
            MeasureListView.Items.Add(arrayItem);
        }
        private void ShowStackContent()
        {
            if (personStack.Stack.Count == 0)
            {
                ContentLabel.Text = "Содержимое стэка: стэк пуст!";
                return;
            }
            string text = "Содержимое стэка: ";
            foreach (Person p in personStack.Stack)
            {
                text += p.ToString() + ", ";
            }
            ContentLabel.Text = text.Trim().Substring(0, text.Length-2);
        }
    }
}
