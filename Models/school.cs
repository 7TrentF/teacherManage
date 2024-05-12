using System.ComponentModel.DataAnnotations;

namespace teacherMnage.Models
{
    public class school
    {
        public int Id { get; set; }
        public required string PrincipalName { get; set; }
        public string SchoolName { get; set; }

        public string SchoolAdress { get; set; }

        public string phone { get; set; } = String.Empty;


}
}
