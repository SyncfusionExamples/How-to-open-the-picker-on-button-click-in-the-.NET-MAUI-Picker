namespace PickerDialogMode
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object? sender, EventArgs e)
        {
            picker.IsOpen = true;
        }
    }
}
