using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace tablesmock
{
    class Program
    {
        static void Main(string[] args)

        {
            using (var context = new SchoolDB()) 
            {
                //var student2 = new Student
                //{
                //    FirstName = "xosoiduo",
                //    LastName = "xosoiduo",
                //    FullName = "xosoiduoxosoiduo",
                //    Adress = "psarwn 3",


                //};

                //context.Student.Add(student2);

                //var student = new Student
                //{
                //    FirstName = "xosoiena",
                //    LastName = "xosoiena",
                //    FullName = "xosoiena",
                //    Adress = "psarwn 3",


                //};
                //context.Student.Add(student);



                //var parent = new Parent
                //{
                //    ParentName = "xosoi 2 mpast",
                //    Phone = 21043344,


                //};
                //context.Parent.Add(parent);

                //var family = new StudentParent
                //{
                //    Parent = parent,
                //    Student = student
                //};

                //var family2 = new StudentParent
                //{
                //    Parent = parent,
                //    Student = student2
                //};
                //context.StudentParent.Add(family);
                //context.StudentParent.Add(family2);
                //context.SaveChanges();














                //parent.Students.Add(new StudentParent
                //{
                //    Student = student2
                //});




                //context.StudentParent.Where(x => x.ParentId == 1).Where(x => x.StudentId == 1);

                //var testpar = new StudentParent
                //{
                //    Parent = parent,
                //    Student = student,
                //};
                //var testpar2 = new StudentParent
                //{
                //    Parent = parent,
                //    Student = student2,
                //};

                //context.StudentParent.Add(testpar);
                //context.StudentParent.Add(testpar2);






                // var testq = context.Student.Include(x => x.Parents).Where(c => c.Id == 1).Select(x => x.Parents).ToList();

                //var test2 = context.StudentParent.Include(x=>x.Student).Include(x=>x.Parent).Where(x => x.Id == 2).Select(x=>x.Student).SingleOrDefault();



                //var test = context.Parent.Include(x=>x.Students).Where(x => x.Id == 1).ToList();
                //var test = context.Parent.Where(x => x.Id == 1).Include(x => x.Students).ThenInclude(x=>x.Student).ToList();

                var test = context.Parent.Include(x => x.Students).ThenInclude(x=>x.Student).Where(x=>x.Students.Any()).SingleOrDefault();


            
                    
                    foreach (var t in test.Students)
                    {
                        var ok = t.Student.FirstName;
                        Console.WriteLine(ok);
                            

                    }
                 








            }

        }
    }
}
