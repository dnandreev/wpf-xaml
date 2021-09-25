using System.Windows;
using System.Windows.Input;

namespace EventsInMarkup{
	public partial class MainWindow : Window{
		public MainWindow() => InitializeComponent();

		void enpaint(object sender, MouseEventArgs e) => (sender as System.Windows.Shapes.Rectangle).Fill = System.Windows.Media.Brushes.Yellow;

		void unpaint(object sender, MouseEventArgs e) => (sender as System.Windows.Shapes.Rectangle).Fill = System.Windows.Media.Brushes.Black;
	}
}