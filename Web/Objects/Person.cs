using System;

namespace Web.Objects
{
    public class Person
    {
        public int Id { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }
        public string FullName => $"{Forename} {Surname}";
        public DateTime LastActivityDateTime { get; set; }
        public bool IsActive => LastActivityDateTime > DateTime.Now.AddDays(-30);

        public Person(int id, string forename, string surname, DateTime lastActivityDateTime)
        {
            Id = id;
            Forename = forename;
            Surname = surname;
            LastActivityDateTime = lastActivityDateTime;
        }
    }
}