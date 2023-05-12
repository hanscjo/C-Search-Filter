namespace Uke2
{
    internal class Program
    {
        private static Student[] students;
        static void Main(string[] args)
        {
            InitializeStudents();
            ViewCourseDistribution();
        }

        private static void InitializeStudents()
        {
            Student student1 = new Student("Kjellbjørg", 46, new string[]{"Padling", "Symaskinreparasjon", "Kryssord"});
            Student student2 = new Student("Gullfrid", 58, new string[] { "Kattepass", "Symaskinreparasjon", "Kryssord"});
            Student student3 = new Student("Julius", 23, new string[] { "Erobring", "Kattepass", "Show-business"});
            Student student4 = new Student("Alexander", 35, new string[] { "Erobring", "Symaskinreparasjon", "Padling" });

            students = new Student[] {student1, student2, student3, student4};
        }

        private static void ViewCourseDistribution()
        {
            while (true)
            {
                Console.WriteLine("Skriv inn et kurs for å se hvilke studenter som tar det...");
                CheckGivenCourse();
                
                Console.WriteLine(" ");
            }
            
        }

        private static void CheckGivenCourse()
        {
            string chosenCourse = Console.ReadLine();
            int courseTakerCount = 0;
            Console.WriteLine("Sjekker etter følgende kurs: " + chosenCourse + "...");

            foreach (Student student in students)
            {
                if (Array.Exists(student.Kurs, course => course == chosenCourse))
                {
                    if (courseTakerCount == 0)
                    {
                        Console.WriteLine("Følgende studenter tar " + chosenCourse + ":");
                    }
                    courseTakerCount++;
                    PrintGivenStudent(student);
                }

            }

            if (courseTakerCount == 0)
            {
                Console.WriteLine("Ingen tar " + chosenCourse + ".");
            }
        }

        private static void PrintGivenStudent(Student givenStudent)
        {
            Console.WriteLine("Navn: " + givenStudent.Navn + ", alder: " + givenStudent.Alder);
        }
    }
}
