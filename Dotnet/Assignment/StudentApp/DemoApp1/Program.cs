
using StudentApp;

Student s1 = new Undergrad("Shreya", 22,"pune");
double ugrade = 70.9;

Student s2 = new Grad("AK" , 10 , "Mumbai");
double ggrade = 65.2;

Console.WriteLine("Student created..");
Console.WriteLine("ID = {0} , Name = {1} , Place = {2} , Passing Status = {3}",s1.Id,s1.Name,s1.Address,s1.isPassed(ugrade));
Console.WriteLine("ID = {0} , Name = {1} , Place = {2} , Passing Status = {3}",s2.Id,s2.Name,s2.Address,s2.isPassed(ggrade));

Console.WriteLine("New Version..");
Student s3 = StudentFactory.OpenUnderGrad("SRK", 20,"NYC");
Console.WriteLine("ID = {0} , Name = {1} , Place = {2} , Passing Status = {3}",s3.Id,s3.Name,s3.Address,s3.isPassed(ugrade));

Student s4 = StudentFactory.OpenUnderGrad("Frooti", 25,"FYC");
Console.WriteLine("ID = {0} , Name = {1} , Place = {2} , Passing Status = {3}",s4.Id,s4.Name,s4.Address,s4.isPassed(ggrade));
