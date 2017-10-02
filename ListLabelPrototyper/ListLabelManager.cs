using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using combit.ListLabel22;
using combit.ListLabel22.DataProviders;

namespace ListLabelPrototyper
{
	public class ListLabelManager
	{
		private const string ListLabelLicenseString = "vAlqEQ";

		public static string Design(string labelDefinition, IEnumerable<object> data, string parentEntity)
		{
			using (var listLabel = new ListLabel())
			{
				listLabel.LicensingInfo = ListLabelLicenseString;
				listLabel.Core.LlSetOption(LlOption.Metric, 1);
				listLabel.Core.LlSetOption(LlOption.Wizard_FileNew, 0);
				listLabel.Core.LlSetOption(LlOption.RibbonDefaultEnabledState, 1);
				listLabel.Core.LlSetOption(LlOption.NoFileVersionUpgradeWarning, 1);

				// Set up the dataset
				listLabel.DataSource = new ObjectDataProvider(data)
				{
					FlattenStructure = true,
				};
				listLabel.DataMember = parentEntity;
				listLabel.AutoMasterMode = LlAutoMasterMode.AsVariables;

				// Configure the designer to read the report design from a memoryStream
				var memoryStream = new MemoryStream();
				if (labelDefinition != null)
				{
					var stringBytes = Encoding.Unicode.GetBytes(labelDefinition);
					memoryStream.Write(stringBytes, 0, stringBytes.Length);
				}

				// Launch the designer
				listLabel.Design(LlProject.List, memoryStream);

				// Now convert the resulting report stream into a string
				var streamReader = new StreamReader(memoryStream);
				var updatedLabelDefinition = streamReader.ReadToEnd();

				return updatedLabelDefinition;
			}
		}

		public static bool Print(string labelDefinition, IEnumerable<Object> data, string parentEntity)
		{
			try
			{
				using (var listLabel = new ListLabel())
				{
					listLabel.LicensingInfo = ListLabelLicenseString;

					// Set up the dataset
					listLabel.DataSource = new ObjectDataProvider(data)
					{
						FlattenStructure = true,
					};
					listLabel.DataMember = parentEntity;
					listLabel.AutoMasterMode = LlAutoMasterMode.AsVariables;

					// Configure the designer to read the report design from a memoryStream
					var memoryStream = new MemoryStream();
					if (labelDefinition != null)
					{
						var stringBytes = Encoding.Unicode.GetBytes(labelDefinition);
						memoryStream.Write(stringBytes, 0, stringBytes.Length);
					}

					// Launch the designer
					listLabel.Print(LlProject.List, memoryStream);

					return true;
				}
			}
			catch (LL_User_Aborted_Exception)
			{
				// Ignore user abort
			}

			return false;
		}

		public static void ExportAsPdf(string labelDefinition, IEnumerable<Object> data, string parentEntity, string targetFilePath)
		{
			using (var listLabel = new ListLabel())
			{
				listLabel.LicensingInfo = ListLabelLicenseString;

				// Set up the dataset
				listLabel.DataSource = new ObjectDataProvider(data)
				{
					FlattenStructure = true,
				};
				listLabel.DataMember = parentEntity;
				listLabel.AutoMasterMode = LlAutoMasterMode.AsVariables;

				// Configure the designer to read the report design from a memoryStream
				var memoryStream = new MemoryStream();
				if (labelDefinition != null)
				{
					var stringBytes = Encoding.Unicode.GetBytes(labelDefinition);
					memoryStream.Write(stringBytes, 0, stringBytes.Length);
				}

				// Launch the designer
				var exportConfiguration = new ExportConfiguration(
					LlExportTarget.Pdf,
					targetFilePath,
					memoryStream)
				{
					ShowResult = false,
				};
				listLabel.Export(exportConfiguration);
			}
		}
	}
}
