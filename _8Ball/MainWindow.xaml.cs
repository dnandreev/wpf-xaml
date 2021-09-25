using System;
using System.Windows;
using System.Windows.Input;

namespace _8Ball{
	public partial class MainWindow : Window{
		public MainWindow() => InitializeComponent();

		void act(object sender, RoutedEventArgs e){
			Cursor = Cursors.Wait;
			System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
			answer.Text = AnswerGenerator.GetRandomAnswer();
			Cursor = Cursors.Arrow;
		}
	}

	class AnswerGenerator{
		readonly static Random R = new Random();
		public static string GetRandomAnswer() => R.Next(2) > 0 ? "Да" : "Нет";
	}
}