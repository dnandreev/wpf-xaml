using System;
using System.Windows;
using System.Windows.Input;

namespace Variant6{
	public partial class MainWindow : Window{
		public MainWindow() => InitializeComponent();

		void convert(object sender, RoutedEventArgs e){
			try{
				kibibytes.Text = Math.Round(Convert.ToUInt64(bytes.Text) / 1024D, 3).ToString();
			}
			catch(Exception exception){
				MessageBox.Show(exception.Message);
			}
		}

		bool isNaturalNumber(string text) => System.Text.RegularExpressions.Regex.IsMatch(text, @"^\d+$");

		void unhandleNumbers(object sender, TextCompositionEventArgs e) => e.Handled = !isNaturalNumber(e.Text);

		void enhandleSpaces(object sender, KeyEventArgs e) => e.Handled = e.Key == Key.Space;

		void handlePasting(object sender, DataObjectPastingEventArgs e){
			if(!e.DataObject.GetDataPresent(typeof(String)))
				e.CancelCommand();
			else if(!isNaturalNumber((String)e.DataObject.GetData(typeof(String))))
				e.CancelCommand();
		}
	}
}