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
    }

    public T Add(T t){
        studentList.Append(t);
        return t;
    }

    public string Xerilizer(){
        string jsonstring = JsonSerializer.Serialize<List<T>>(studentList);
        return jsonstring;
    }
}