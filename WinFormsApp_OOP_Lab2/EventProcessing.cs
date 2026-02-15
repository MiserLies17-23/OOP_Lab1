namespace WinFormsApp_OOP_Lab2
{
    public class EventProcessing
    {
        private Label label;
        public EventProcessing(Label l, PersonStack ps) 
        {
            label = l;
            ps.Add += (message) => { l.Text = "Последнее действие: " + message; };
            ps.Remove += (message) => { l.Text = "Последнее действие: " + message; };
        }
    }
}
