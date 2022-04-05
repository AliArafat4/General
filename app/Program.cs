Console.WriteLine("how many students");

//int num = Console.Read();
int num = Convert.ToInt32(Console.ReadLine());
float grade;
string name = " ";
gradeBook[] stuGrades = new gradeBook[num];
gradeBook stuGrade = new gradeBook(name, 0);

for (int i = 0; i < stuGrades.Length; i++)
{
    Console.WriteLine($"enter the {i + 1} student name");
    name = Console.ReadLine();

    Console.WriteLine($"enter the {i + 1} student grade");
    grade = Convert.ToInt32(Console.ReadLine());

    stuGrade = new gradeBook(name, grade);
    stuGrades[i] = stuGrade;
}
Console.WriteLine(
    $"Average is {stuGrade.avg(stuGrades)}\nMax is {stuGrade.max(stuGrades)}\nMin is {stuGrade.min(stuGrades)}"
);

class gradeBook
{
    string name;
    float grade;

    public gradeBook(string name, float grade)
    {
        this.name = name;
        this.grade = grade;
    }

    public float avg(gradeBook[] grade)
    {
        float x = 0;
        for (int i = 0; i < grade.Length; i++)
        {
            x += grade[i].grade;
        }

        return x / grade.Length;
    }

    public float max(gradeBook[] grade)
    {
        float x = grade[0].grade;
        for (int i = 0; i < grade.Length; i++)
        {
            if (x <= grade[i].grade)
                x = grade[i].grade;
        }
        return x;
    }

    public float min(gradeBook[] grade)
    {
        float x = grade[0].grade;
        for (int i = 0; i < grade.Length; i++)
        {
            if (x >= grade[i].grade)
                x = grade[i].grade;
        }
        return x;
    }
}
