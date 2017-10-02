using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ListLabelPrototyper.Operations.BlisterPackDemo
{
	public class BlisterPackDemo : BaseDemo
	{
		private const int MaximumNumberOfRows = 7;
		private const int MaximumNumberOfColumns = 4;

		public BlisterPackDemo()
		{
			Name = "Blister Pack Demo";
			Description = "Used for testing blister pack templates.";

			DefinitionFileName = "BlisterPack.list";
			ParentEntity = "BlisterPack";
			Data = CreateDataSet_BlisterPack();
		}

		private IEnumerable<Object> CreateDataSet_BlisterPack()
		{
			var foils = new List<BlisterPack>
			{
				GenerateFoil1(),
				GenerateFoil2(),
				GenerateFoil3(),
				GenerateFoil4(),
				GenerateFoil5(),
			};
			return foils;
		}

		private BlisterPack GenerateFoil1()
		{
			var foil = new BlisterPack
			{
				Patient = new Patient
				{
					FirstName = "Robert",
					LastName = "Quinn",
					Address = new Address
					{
						Line1 = "55 Rose Street",
						Line2 = "",
						Town = "Rythdale",
						State = "Vic",
						Postcode = "3810",
					},
					//Image = GetCustomerImage(),
				},
				StartDate = DateTime.Now.Date,
				ExpiryDate = DateTime.Now.AddMonths(1).Date,
				TrayNumber = 1,
			};

			PopulateFacility(foil);
			PopulatePreparedBy(foil);
			PopulateDoctor(foil);
			PopulateRowHeaders(foil);
			PopulateColumnHeaders(foil);
			PopulateDoses(foil);
			PopulateMedicationSummary(foil);
			PopulateAllergies(foil);
			PopulateOtherMedications(foil);

			return foil;
		}

		private BlisterPack GenerateFoil2()
		{
			var foil = new BlisterPack
			{
				Patient = new Patient
				{
					FirstName = "Margaret",
					LastName = "Trujillo",
					Address = new Address
					{
						Line1 = "62 Bayfield Street",
						Line2 = "",
						Town = "Copping",
						State = "Tas",
						Postcode = "7174",
					},
					//Image = GetCustomerImage(),
				},
				StartDate = DateTime.Now.Date,
				ExpiryDate = DateTime.Now.AddMonths(1).Date,
				TrayNumber = 1,
			};

			PopulateFacility(foil);
			PopulatePreparedBy(foil);
			PopulateDoctor(foil);
			PopulateRowHeaders(foil);
			PopulateColumnHeaders(foil);
			PopulateDoses(foil);
			PopulateMedicationSummary(foil);
			PopulateAllergies(foil);
			PopulateOtherMedications(foil);

			return foil;
		}

		private BlisterPack GenerateFoil3()
		{
			var foil = new BlisterPack
			{
				Patient = new Patient
				{
					FirstName = "Robyn",
					LastName = "Mathis",
					Address = new Address
					{
						Line1 = "16 Wharf Street",
						Line2 = "",
						Town = "Somersby",
						State = "NSW",
						Postcode = "2250",
					},
					//Image = GetCustomerImage(),
				},
				StartDate = DateTime.Now.Date,
				ExpiryDate = DateTime.Now.AddMonths(1).Date,
				TrayNumber = 1,
			};

			PopulateFacility(foil);
			PopulatePreparedBy(foil);
			PopulateDoctor(foil);
			PopulateRowHeaders(foil);
			PopulateColumnHeaders(foil);
			PopulateDoses(foil);
			PopulateMedicationSummary(foil);
			PopulateAllergies(foil);
			PopulateOtherMedications(foil);

			return foil;
		}

		private BlisterPack GenerateFoil4()
		{
			var foil = new BlisterPack
			{
				Patient = new Patient
				{
					FirstName = "Deborah",
					LastName = "Whatley",
					Address = new Address
					{
						Line1 = "72 Warren Avenue",
						Line2 = "",
						Town = "Barnsley",
						State = "NSW",
						Postcode = "2278",
					},
					//Image = GetCustomerImage(),
				},
				StartDate = DateTime.Now.Date,
				ExpiryDate = DateTime.Now.AddMonths(1).Date,
				TrayNumber = 1,
			};

			PopulateFacility(foil);
			PopulatePreparedBy(foil);
			PopulateDoctor(foil);
			PopulateRowHeaders(foil);
			PopulateColumnHeaders(foil);
			PopulateDoses(foil);
			PopulateMedicationSummary(foil);
			PopulateAllergies(foil);
			PopulateOtherMedications(foil);

			return foil;
		}

		private BlisterPack GenerateFoil5()
		{
			var foil = new BlisterPack
			{
				Patient = new Patient
				{
					FirstName = "Robert",
					LastName = "Rivers",
					Address = new Address
					{
						Line1 = "42 Marlin Avenue",
						Line2 = "",
						Town = "Collector",
						State = "NSW",
						Postcode = "2581",
					},
					//Image = GetCustomerImage(),
				},
				StartDate = DateTime.Now.Date,
				ExpiryDate = DateTime.Now.AddMonths(1).Date,
				TrayNumber = 1,
			};

			PopulateFacility(foil);
			PopulatePreparedBy(foil);
			PopulateDoctor(foil);
			PopulateRowHeaders(foil);
			PopulateColumnHeaders(foil);
			PopulateDoses(foil);
			PopulateMedicationSummary(foil);
			PopulateAllergies(foil);
			PopulateOtherMedications(foil);

			return foil;
		}

		private void PopulateFacility(BlisterPack foil)
		{
			foil.Facility = new Facility
			{
				Name = "Senectus Retirement Village",
				Address = new Address
				{
					Line1 = "456 Retirement St",
					Line2 = "",
					Town = "Faketon",
					State = "Vic",
					Postcode = "8000",
				}
			};
		}

		private void PopulatePreparedBy(BlisterPack foil)
		{
			foil.PreparedBy = new Pharmacy
			{
				Name = "MyOwn Community Pharmacy",
				Address = new Address
				{
					Line1 = "567 MyOwn St",
					Line2 = "",
					Town = "MyOwn Town",
					State = "Vic",
					Postcode = "7000",
				},
				PhoneNumber = "1234 567 890",
			};
		}

		private void PopulateDoctor(BlisterPack foil)
		{
			foil.Doctor = new Doctor
			{
				Name = "Dr William Osler",
			};
		}

		private void PopulateRowHeaders(BlisterPack foil)
		{
			foil.RowHeader1 = DateTime.Now.AddDays(1).Date.ToString(CultureInfo.InvariantCulture);
			foil.RowHeader2 = DateTime.Now.AddDays(2).Date.ToString(CultureInfo.InvariantCulture);
			foil.RowHeader3 = DateTime.Now.AddDays(3).Date.ToString(CultureInfo.InvariantCulture);
			foil.RowHeader4 = DateTime.Now.AddDays(4).Date.ToString(CultureInfo.InvariantCulture);
			foil.RowHeader5 = DateTime.Now.AddDays(5).Date.ToString(CultureInfo.InvariantCulture);
			foil.RowHeader6 = DateTime.Now.AddDays(6).Date.ToString(CultureInfo.InvariantCulture);
			foil.RowHeader7 = DateTime.Now.AddDays(7).Date.ToString(CultureInfo.InvariantCulture);
		}

		private void PopulateColumnHeaders(BlisterPack foil)
		{
			foil.ColumnHeader1 = "Breakfast";
			foil.ColumnHeader2 = "Lunch";
			foil.ColumnHeader3 = "Dinner";
			foil.ColumnHeader4 = "Bedtime";
		}

		private void PopulateDoses(BlisterPack foil)
		{
			foil.Doses = new List<BlisterDose>();

			for (var i = 1; i <= MaximumNumberOfRows; i++)
			{
				for (var j = 1; j <= MaximumNumberOfColumns; j++)
				{
					var dose1 = new BlisterDose
					{
						BlisterProduct = new BlisterProduct
						{
							Name = "STEMETIL TAB 5MG 25",
							GenericName = "PROCHLORPERAZINE",
							Form = "TAB",
							Strength = "5MG",
							GenericNameFormStrength = "PROCHLORPERAZINE TAB 5MG",
						},

						DoseAmount = 1.1m,

						RowNumber = i,
						ColumnNumber = j,
					};

					var dose2 = new BlisterDose
					{
						BlisterProduct = new BlisterProduct
						{
							Name = "LIPEX TAB 20MG 30",
							GenericName = "SIMVASTATIN",
							Form = "TAB",
							Strength = "20MG",
							GenericNameFormStrength = "SIMVASTATIN TAB 20MG",
						},

						DoseAmount = 2m,

						RowNumber = i,
						ColumnNumber = j,
					};

					foil.Doses.Add(dose1);

					if ((i + j) % 2 == 0)
					{
						foil.Doses.Add(dose2);
					}
				}
			}
		}

		private void PopulateMedicationSummary(BlisterPack foil)
		{
			foil.MedicationSummary = new List<BlisterSummaryItem>();

			foreach (var dose in foil.Doses)
			{
				// Add the row if it doesn't already exist
				if (foil.MedicationSummary.All(x => x.BlisterProduct.Name != dose.BlisterProduct.Name))
				{
					foil.MedicationSummary.Add(new BlisterSummaryItem
					{
						BlisterProduct = dose.BlisterProduct,
					});
				}

				var currentItem = foil.MedicationSummary.Find(x => x.BlisterProduct.Name == dose.BlisterProduct.Name);

				if (dose.ColumnNumber == 1)
				{
					var oldValue = decimal.Parse(currentItem.TotalDose1 ?? "0");
					currentItem.TotalDose1 = (oldValue + dose.DoseAmount).ToString(CultureInfo.InvariantCulture);
				}

				if (dose.ColumnNumber == 2)
				{
					var oldValue = decimal.Parse(currentItem.TotalDose2 ?? "0");
					currentItem.TotalDose2 = (oldValue + dose.DoseAmount).ToString(CultureInfo.InvariantCulture);
				}

				if (dose.ColumnNumber == 3)
				{
					var oldValue = decimal.Parse(currentItem.TotalDose3 ?? "0");
					currentItem.TotalDose3 = (oldValue + dose.DoseAmount).ToString(CultureInfo.InvariantCulture);
				}

				if (dose.ColumnNumber == 4)
				{
					var oldValue = decimal.Parse(currentItem.TotalDose4 ?? "0");
					currentItem.TotalDose4 = (oldValue + dose.DoseAmount).ToString(CultureInfo.InvariantCulture);
				}
			}
		}

		private void PopulateAllergies(BlisterPack foil)
		{
			foil.Allergies
				= "Penicillin" + Environment.NewLine
				  + "Biofoam" + Environment.NewLine
				  + "Allopurinol";
		}

		private void PopulateOtherMedications(BlisterPack foil)
		{
			foil.OtherMedications
				= "AMOXIL CAP 500MG 20" + Environment.NewLine
				  + "LIPITOR TAB 40MG 30" + Environment.NewLine
				  + "JURNISTA TAB-MR 32MG 10";
		}
	}
}
