namespace ClinicalManagement.Models
{
	public class Patients
	{

        public int Id { get; set; }
        public string Name { get; set; }

		public string Email { get; set; }

		public string Phone { get; set; }

		public string Document { get; set; }

		public int Age { get; set; }

		public string Illnesses { get; set; }

		public string Observations { get; set; }

		public bool HealthInsurance { get; set; }

	}
}
