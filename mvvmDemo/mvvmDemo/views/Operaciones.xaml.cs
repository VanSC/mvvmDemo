using mvvmDemo.viewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace mvvmDemo.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Operaciones : ContentPage
    {
        public Operaciones()
        {
            InitializeComponent();

            this.BindingContext = new viewModels.OperacionesViewModel();
        }
    }
}