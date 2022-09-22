using Encapsulation_CS;





student s1 = new student();
//student s2 = new student();
//s1.totalmarks = 1100;
Console.Write("enter name: ");
s1.name = Console.ReadLine();
Console.WriteLine("enter marks you got:");
s1.marks = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("percentage="+s1.percentage);


