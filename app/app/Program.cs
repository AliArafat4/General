
Console.WriteLine("how many students");
int num = Console.Read();
float grade;
gradeBook[] stuGrades = new gradeBook[num];
gradeBook stuGrade = new gradeBook(null, 0);
string name;

for (int i = 0; i <= num; i++)
{
    Console.WriteLine($"enter the {i} student name");
    name = Console.ReadLine();

    Console.WriteLine($"enter the {i} student grade");
    grade = Console.Read();

    stuGrade = new gradeBook(name, grade);
    stuGrades[i] = stuGrade;
}
stuGrade.avg(stuGrades);
string text = Console.ReadLine();

Console.WriteLine($"Your name is {text}");

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
            grade[i].grade += x;
        }

        return x / grade.Length;
    }
}