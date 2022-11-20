namespace Employee_Management_System.ViewModels
{
    public class ListViewModel
    {
        
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FatherName { get; set; }
        public string Code { get; set; }
        public bool IsDeleted { get; set; }
        public ListViewModel(string name, string surname, string fathername, string emloyecode, bool isdeleted)
        {
            Name = name;
            Surname = surname;
            FatherName = fathername;
            Code = emloyecode;
            IsDeleted = isdeleted;
        }
    }
}
