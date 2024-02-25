////Params

//using System;
//using System.Collections;
//using System.Collections.Generic;

//public class Person
//{
//    private int age;
//    private string name;
//    private List<string> emails;


//    public Person()
//    {
//        emails = new List<string>();
//    }

//    public List<string> Email
//    {
//        get
//        {
//            return emails;
//        }
//        set
//        {
//            emails = value;
//        }
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

//    public void AddEmails(params string[] email)
//    {
//        for (int i = 0; i < email.Length; i++)
//        {
//            emails.Add(email[i]);
//        }
//    }

//    public override string ToString()
//    {
//        string data = string.Empty;
//        data = Name + age;

//        foreach(string email in emails)
//        {
//            data = data + email;
//        }
//        return data;
//    }
    

//}

//class Program
//{
//    static public void Main(string[] args)
//    {
//        Person p = new Person
//        {
//            Name = "Asra",
//            Age = 20
//        };

//        Console.WriteLine("Enter Emails\nPress 'quit' to finish");
//        while (true)
//        {
//            string inputEmail = string.Empty;
//            inputEmail = Console.ReadLine();
//            if (inputEmail == "quit")
//            {
//                break;
//            }

//            p.AddEmails(inputEmail);
//        }

//        string data=p.ToString();
//        Console.WriteLine(data);


//    }
//}
