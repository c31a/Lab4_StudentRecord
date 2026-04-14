using System;//                    %@@@&@@@@@@@&@@@@@@@@@@@@@@@
//                                 @@#                       @@
class Student //                   &@(                       @@
{   //                             @@&%####(           ...   @@
    private string name;//           ***//((           &&@@@@@
    public string Name
    {//                            %@@@&@@@@@@@&@@@@
        get { return name; }//     &@      *@.     &@
        set { name = value; }//    @@      /@      @@
    } //                           @@@@&   /@@@&@@@@&


    //                             @@@@&@@@&@@@&&@@@@@@&&@@@&@@           
    private int id;//              @@ 
    public int Id//                @@

    {
        get { return id; }//       @@@@&@@@&@@@&@@@@@@@&&@@@@@@         
        set { id = value; }//      @@                        @@
    }//                            @@                        @@                              
    //                             @@@@&@@@@@@@&@@@@@@@@@@@@@@@          

    private double gpa;
    public double GPA

    {
        get { return gpa; }
        set
        {
            if (value >= 0 && value <= 4)
            {
                gpa = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("GPA must be between 0 and 4.");
            }
        }
    }


    public void DisplayRecord()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("ID: " + Id);
        Console.WriteLine("GPA: " + gpa);
        Console.WriteLine("---------------------------------------------------");
    }
}
class Program
{

    static void Main(string[] args)
    {

        Student stu1 = new Student();
        Student stu2 = new Student();
        stu1.Name = "Maya";
        stu1.Id = 101;
        stu1.GPA = 3.5;
        stu1.DisplayRecord();
        try
        {
            stu2.Name = "Lana";
            stu2.Id = 102;
            stu2.GPA = 6;
            stu2.DisplayRecord();
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Error: GPA must be between 0 and 4.");
        }
    }
}
