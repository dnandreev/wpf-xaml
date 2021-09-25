using System.Windows;

namespace WpfApplication{
	public partial class MainWindow : Window{
		public MainWindow() => InitializeComponent();

		private void showHello(object sender, RoutedEventArgs e) => MessageBox.Show(name.Text == "" ? "Вы не ввели своё имя!" : "Здравствуйте, " + name.Text + '!');
	}
}