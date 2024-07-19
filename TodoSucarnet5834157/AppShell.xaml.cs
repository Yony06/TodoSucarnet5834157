using TodoSucarnet5834157.Views;

namespace TodoSucarnet5834157
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(TodoItemPage), typeof(TodoItemPage));
        }
    }
}
