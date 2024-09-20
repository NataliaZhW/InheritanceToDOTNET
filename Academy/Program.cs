//#define INHERITANCE_1
//#define WRITE_TO_FILE
//#define READ_FROM_FILE

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if INHERITANCE_1
            Human human = new Human("Vercetti", "Tommy", 30);
            //human.Info();
            Console.WriteLine(human);

            Student student = new Student("Pinkman", "Jessie", 25, "Chemistry", "WW_220", 95, 98);
            Console.WriteLine(student);

            Teacher teacher = new Teacher("White", "Walter", 50, "Chemistry", 20);
            //teacher.Info();
            Console.WriteLine(teacher);
#endif //INHERITANCE_1

            Human tommy = new Human("Vercetty", "Tommy", 30);            
            Console.WriteLine(tommy);

            Student student_tommy = new Student(tommy, "Theft", "Vice", 95, 98);
            Console.WriteLine(student_tommy);

            Human ricardo = new Human("Diaz", "Ricardo", 50);
            Console.WriteLine(ricardo);
            
            Teacher teacher = new Teacher(ricardo, "Weapons distribution", 20);
            Console.WriteLine(teacher);

            
            Graduate graduate = new Graduate("Schreder", "Hank", 40, "Criminalistic", "OBN", 70, 40, "How to catch Heisenberg");
            Console.WriteLine(graduate);



            //StreamWriter sw = new StreamWriter(filename);
            /////
            //sw.Close();
            
            //StreamReader sr = new StreamReader(filename);
            //while (!sr.EndOfStream)
            //{
            //    string buffer = sr.ReadLine();
            //   ///
            //}
            //sr.Close();
        }
    }
}
