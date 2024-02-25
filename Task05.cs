//using System;
//using System.IO;

//public class Person
//{
//    private int age;
//    private string name;
//    private List<string> email;

//    public Person() 
//    {
//        email = new List<string>();
//    } 
//    public List<string> Email
//    {
//        get { return email; }
//        set { email = value; }
//    }

//    public string Name
//    {
//        get { return name; }
//        set { name = value; }
//    }

//    public int Age
//    {
//        get { return age; }
//        set { age = value; }
//    }


//    public void saveToFile(string filename)
//    {
//        FileStream fin = new FileStream(filename, FileMode.Create);
//        StreamWriter sw = new StreamWriter(fin);
//        string data = "Name of Person " + name + " Age " + age+" \nEmails : \n";
//        int i = 1;

//        foreach(string e in Email)
//        {
//            data=data+" Email "+i+" : " + e;
//            i++;
//        }
//        Console.WriteLine(data);
//        sw.WriteLine(data);
//        sw.Close();
//        fin.Close();
//    }
//}

//class Program
//{
//    static public void Main(string[] args)
//    {
//        Person p = new Person
//        {
//            Name = "Asra",
//            Age = 20,
//            Email = "masra037@gmail.com"
//        };

//        p.saveToFile("MyFile.txt");
//    }
//}
