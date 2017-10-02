using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using ListLabelPrototyper.Operations;
using ListLabelPrototyper.Operations.BlisterPackDemo;

namespace ListLabelPrototyper
{
	public class MainViewModel
	{
		public ObservableCollection<BaseDemo> DemoList { get; set; }

		public BaseDemo SelectedItem { get; set; }

		public string VersionText { get; set; }

		public MainViewModel()
		{
			DemoList = new ObservableCollection<BaseDemo>
			{
				new BlisterPackDemo(),
			};

			CloseCommand = new DelegateCommand(
				execute: x =>
				{
					Application.Current.MainWindow.Close();
				},
				canExecute: x => true);

			VersionText = "Version: " + "SAMPLE FOR COMBIT";
		}

		public ICommand CloseCommand { get; set; }
	}
}
