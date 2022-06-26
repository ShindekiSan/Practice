try
{
  Student[] students = new Student[10];
  for (int i = 0; i < 10; i++) 
  {
    Console.Write("Введите имя и инициалы = ");
    string name = Console.ReadLine();
    Console.Write("Введите номер группы = ");
    int group = Convert.ToInt32(Console.ReadLine());
    Console.Write("Оценка 1 = ");
    int mark1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Оценка 2 = ");
    int mark2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Оценка 3 = ");
    int mark3 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Оценка 4 = ");
    int mark4 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Оценка 5 = ");
    int mark5 = Convert.ToInt32(Console.ReadLine());

    int[] marks = new int[] { mark1, mark2, mark3, mark4, mark5 };
    students[i] = new Student(name, group, marks);
  }
  var sorted = students.OrderBy(student => student.groupNumber).ToArray();

  int studentsCount = 0;
  for (int i = 0; i < 10; i++) 
  {
    if ((sorted[i].marks.Sum() / 5) >= 4) 
    {
      Console.WriteLine(sorted[i]);
      studentsCount += 1;
    }
  }

  if (studentsCount == 0)
  {
    Console.WriteLine("Нет студентов со средним баллом выше 4.0");
  }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

public struct Student
{
    public string nameWithInitials;
    public int groupNumber;
    public int[] marks;

    public Student(string name, int group, int[] marksArray) : this()
    {
        nameWithInitials = name;
        groupNumber = group;
        marks = marksArray;
    }

    public override string ToString()
    {
        return string.Format("Имя: {0}, номер группы: {1}", nameWithInitials, groupNumber);
    }
}
