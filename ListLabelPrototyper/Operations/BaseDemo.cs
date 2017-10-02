using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Input;

namespace ListLabelPrototyper.Operations
{
	public abstract class BaseDemo
	{
		public string Name { get; set; }
		public string Description { get; set; }

		protected string DefinitionFileName { get; set; }
		protected string ParentEntity { get; set; }
		protected IEnumerable<object> Data { get; set; }

		protected BaseDemo()
		{
			DesignCommand = new DelegateCommand(
				execute: y =>
				{
					var definition = ReadLabelDefinition(DefinitionFileName);
					var updatedDefinition = ListLabelManager.Design(definition, Data, ParentEntity);
					WriteLabelDefinition(DefinitionFileName, updatedDefinition);
				},
				canExecute: x => true);

			PrintCommand = new DelegateCommand(
				execute: y =>
				{
					var definition = ReadLabelDefinition(DefinitionFileName);
					ListLabelManager.Print(definition, Data, ParentEntity);
				},
				canExecute: x => true);

			ExportCommand = new DelegateCommand(
				execute: y =>
				{
					var pdfFileName = Path.ChangeExtension(DefinitionFileName, ".pdf");
					var targetPath = Path.Combine(Directory.GetCurrentDirectory(), pdfFileName);

					var definition = ReadLabelDefinition(DefinitionFileName);
					ListLabelManager.ExportAsPdf(definition, Data, ParentEntity, targetPath);
				},
				canExecute: x => true);
		}

		public ICommand DesignCommand { get; set; }
		public ICommand PrintCommand { get; set; }
		public ICommand ExportCommand { get; set; }

		private string ReadLabelDefinition(string filename)
		{
			using (var streamReader = new StreamReader(filename, Encoding.Unicode))
			{
				var fileText = streamReader.ReadToEnd();
				return fileText;
			}
		}

		private void WriteLabelDefinition(string filename, string definition)
		{
			using (var streamWriter = new StreamWriter(filename, false, Encoding.Unicode))
			{
				streamWriter.Write(definition);
			}
		}
	}
}
