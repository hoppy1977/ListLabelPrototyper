using System;
using System.Collections.Generic;

namespace ListLabelPrototyper.Operations.BlisterPackDemo
{
	public class BlisterPack
    {
        public Patient Patient { get; set; }
		public Facility Facility { get; set; }
		public Pharmacy PreparedBy { get; set; }
		public Doctor Doctor { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime ExpiryDate { get; set; }
		public int TrayNumber { get; set; }
		public string Allergies { get; set; }
		public string OtherMedications { get; set; }

		public string RowHeader1 { get; set; }
		public string RowHeader2 { get; set; }
		public string RowHeader3 { get; set; }
		public string RowHeader4 { get; set; }
		public string RowHeader5 { get; set; }
		public string RowHeader6 { get; set; }
		public string RowHeader7 { get; set; }

		public string ColumnHeader1 { get; set; }
		public string ColumnHeader2 { get; set; }
		public string ColumnHeader3 { get; set; }
		public string ColumnHeader4 { get; set; }

		public List<BlisterDose> Doses { get; set; }
		public List<BlisterSummaryItem> MedicationSummary { get; set; }
	}
}
