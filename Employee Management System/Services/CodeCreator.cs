using Employee_Management_System.Context;

namespace Employee_Management_System.Services
{
    public class CodeCreator
    {
        public static string CreateCode()
        {
            using DataContext dataContext = new DataContext();

            var list = dataContext.Employees.Where(b => true).Select(b => b.Code).ToList();

            Random random = new Random();
            string Code;
            bool notFound;

            do
            {
                notFound = false;
                int num = random.Next(10000, 99999);
                Code = $"E{num}";

                foreach (var item in list)
                {
                    if (item == Code)
                    {
                        notFound = true;
                    }
                }
            } while (notFound);

            return Code;

        }
    }
}
