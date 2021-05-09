using System.Text;

namespace InvitationConsoleApp.Models
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string SurnamePrefix { get; set; }
        public string Surname { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }


        public Person()
        {
            StoreName();
        }

        public enum GenderEnum
        {
            Male,
            Female,
            Neutral,
            Unknown
        }

        private void StoreName()
        {
            string[] nameParts = FullName.Split(' ');
            FirstName = nameParts[0];
            Surname = nameParts[nameParts.Length];
            StringBuilder sb = new StringBuilder();
            if (nameParts.Length >= 3)
            {
                for (int i = 1; i < (nameParts.Length - 1); i++)
                {
                    sb.Append(nameParts[i]);
                    sb.Append(' ');
                }
                SurnamePrefix = sb.ToString();
            }
            Gender = GenderEnum.Unknown.ToString();
        }
        public string FormalName()
        {
            string formName = $"{Surname}, {FirstName} {SurnamePrefix}";
            formName.Replace("  ", " ");
            return formName.ToString();
        }

    }
}