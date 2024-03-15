using System.Text.Json;

public interface IStudent {
    string Name { get; set;}
    string Id { get; }
}

class Student : IStudent{
    public string Id{get;}
    public string Name{get; set;}
    public int Age {get; set;}
    readonly int RollNumber;
    public int Grade {get; set;}

    public Student(string id, string name, int age, int rollNumber, int grade) {
        Id = id;
        Name = name;
        Age = age;
        RollNumber = rollNumber;
        Grade = grade;
    }

    public override string ToString()
    {
        return $"{Id} {Name}";
    }
}


class StudentList<T> where T : IStudent{
    List<T> studentList;

    
    public StudentList(){
        studentList = new List<T>();
    }

    public void SearchByNameorAge(string search){
        IEnumerable<T> searched = 
        from student in studentList
        where student.Id == search || student.Name == search
        select student;
        Display(searched.ToList());
    }

    public T Add(T t){
        studentList.Add(t);
        return t;
    }

    public string Xerilizer(){
        string jsonstring = JsonSerializer.Serialize<List<T>>(studentList);
        return jsonstring;
    }

    public void Display() {
        foreach(T t in studentList) {
            Console.WriteLine(t.ToString());
        }
    }

    public void Display(List<T> searched) {
        foreach(T t in searched) {
            Console.WriteLine(t.ToString());
        }
    }
}


// Implementation on Main


// Student student = new Student("1", "yohanse", 23, 32, 100);
//         Student student1 = new Student("2", "Z", 23, 32, 100);
//         Student student2 = new Student("3", "Z", 23, 32, 100);
//         Student student3 = new Student("4", "A", 23, 32, 100);
//         Student student4 = new Student("5", "B", 23, 32, 100);
//         Student student5 = new Student("6", "B", 23, 32, 100);

//         StudentList<Student> studentList = new StudentList<Student>();
//         studentList.Add(student);
//         studentList.Add(student1);
//         studentList.Add(student2);
//         studentList.Add(student3);
//         studentList.Add(student4);
//         studentList.Add(student5);
//         Console.WriteLine("Yohanse");
//         studentList.Display();
//         Console.WriteLine("--------------------");
//         studentList.SearchByNameorAge("Z");
//         Console.WriteLine("----------");
//         studentList.SearchByNameorAge("1");
//         Console.WriteLine("--------------------");
//         Console.WriteLine(studentList.Xerilizer());