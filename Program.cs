using System;
class BTVNBuoi3 {
    public static void Main() {
        Console.WriteLine("Ket qua bai 1: " + Bai1("03:03:00PM"));

        string[] name = {"A", "B", "C", "D", "E"};
        float[] grade = {3.8F, 7.9F, 6.5F, 2.8F, 5.0F};
        Console.WriteLine("Ket qua bai 2: " + Bai2(name, grade));
    }

    public static string Bai1(string ampm)
    {
        string []time = ampm.Split(":");
        string hours = time[0],minutes = time[1],seconds = time[2];


        if(seconds.Contains("PM")){
            hours = (int.Parse(hours)+12).ToString();
        }
        return string.Format("{0}:{1}:{2}",hours,minutes,seconds.Substring(0,2));
    }

    public static string Bai2(string[] name, float[] grade)
    {
        List<Student> students = new List<Student>();
        List<Student> results = new List<Student>();
        string result="";
        for(int i = 0; i < name.Length; i++)
        {
            students.Add(new Student(name[i], grade[i]));
        }
        foreach(Student student in students)
        {
            int check = (int)(student.getGrade()+0.2F);
            if (check == (int)student.getGrade())
            {
                results.Add(student);
            }
            else
            {
                results.Add(new Student(student.getName(), (float)check));
            }
        }
        for(int i = 0; i < results.Count; i++)
        {
            result += "\n"+results[i].toString();
        }

        return result;
    }
}