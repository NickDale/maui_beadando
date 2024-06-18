using System.Collections.ObjectModel;

namespace todo
{
    public partial class MainPage : ContentPage
    {
        ObservableCollection<string> todos;

        public MainPage()
        {
            InitializeComponent();
            todos = new ObservableCollection<string>();
            todoView.ItemsSource = todos;
        }


         private void add(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(todoEntry.Text))
            {
                todos.Add(todoEntry.Text);
                todoEntry.Text = string.Empty;
            }
        }
    }

}
