public class Program
{
    private static void Main(string[] args)
    {
        //Khai bao mang
        string[] students = {
            "Christian", "Michael",
            "Camila", "Sienna",
            "Tanya", "Connor",
            "Zachariah"
            };
        //Khai bao bien luu ten tim kiem
        Console.Write("Enter a student's name: ");
        string inputName = Console.ReadLine();

        //Duyet mang
        bool isExist = false;
        for (int i = 0; i < students.Length; i++)
        {
            if (students[i].Equals(inputName))
            {
                Console.WriteLine($"Position of the student in the list {inputName} " + (i + 1));
                isExist = true;
                break;
            }
        }
        if (!isExist)
        {
            Console.WriteLine($"Student {inputName} was not found in the list.");
        }
    }
}