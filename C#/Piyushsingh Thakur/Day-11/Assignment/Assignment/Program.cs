using Assignment.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment
{
    public class Hospital
    {
        //add doctor
        public void AddDoctor()
        {
            // Display current data
            Hospital h1 = new Hospital();
            h1.DisplayDoctors();

            int id, phoneNumber, deptID;
            string fname, lname, qualification, address, specialist;

            // Enter new data from user
            Console.Write("Enter ID : ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter First Name : ");
            fname = Console.ReadLine();
            Console.Write("Enter Last Name : ");
            lname = Console.ReadLine();
            Console.Write("Enter Phone Number : ");
            phoneNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Qualification : ");
            qualification = Console.ReadLine();
            Console.Write("Enter Address : ");
            address = Console.ReadLine();
            Console.Write("Enter Specialist in : ");
            specialist = Console.ReadLine();
            Console.Write("Enter Department ID : ");
            deptID = Convert.ToInt32(Console.ReadLine());

            using (var context = new HospitalContext())
            {
                //Add data in Table
                var add = new Doctor() { DocId = id, DocFname = fname, DocLname = lname, DocPhoneNumber = phoneNumber, DocQualification = qualification, DocAddress = address, DocSpecialist = specialist, DeptId = deptID };
                context.Add(add);
                context.SaveChanges();
            }

            // Display data after adding 
            Console.WriteLine("Data added successfully, have a look....");
            h1.DisplayDoctors();
            Console.WriteLine();
        }

        //display doctor
        public void DisplayDoctors()
        {
            using (var context = new HospitalContext())
            {
                // Displays data from tables
                var doc = context.Doctor.OrderBy(d => d.DocId);
                Console.WriteLine("Doctor Id\tName\t\tPhone Number\tQualification\tAddress\t\tSpecialist in\tDepartment Id");
                foreach (var item in doc)
                {
                    Console.WriteLine($"\t{item.DocId}\t{item.DocFname + " " + item.DocLname}\t{item.DocPhoneNumber}\t{item.DocQualification}\t\t{item.DocAddress}\t{item.DocSpecialist}\t\t{item.DeptId}");
                }
            }
        }

        //delete doctor
        public void DeleteDoctor()
        {
            // Display current data
            Hospital h1 = new Hospital();
            h1.DisplayDoctors();

            int id;

            // User input for which data to delete
            Console.Write("Enter ID to be updated : ");
            id = Convert.ToInt32(Console.ReadLine());

            using (var context = new HospitalContext())
            {
                // Deleting the specified data 
                var del = context.Doctor.Single(d => d.DocId == id);
                context.Remove(del);
                context.SaveChanges();
            }

            // Display data after deleting
            Console.WriteLine("Data deleted successfully, have a look....");
            h1.DisplayDoctors();
            Console.WriteLine();
        }

        //update doctor
        public void UpdateDoctor()
        {
            // Display current data
            Hospital h1 = new Hospital();
            h1.DisplayDoctors();

            int id, phoneNumber, deptID;
            string fname, lname, qualification, address, specialist;

            Console.Write("Enter ID to be updated : ");
            id = Convert.ToInt32(Console.ReadLine());

            // Enter new data from user for updating
            Console.WriteLine("Please enter updated data : ");
            Console.Write("Enter First Name : ");
            fname = Console.ReadLine();
            Console.Write("Enter Last Name : ");
            lname = Console.ReadLine();
            Console.Write("Enter Phone Number : ");
            phoneNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Qualification : ");
            qualification = Console.ReadLine();
            Console.Write("Enter Address : ");
            address = Console.ReadLine();
            Console.Write("Enter Specialist in : ");
            specialist = Console.ReadLine();
            Console.Write("Enter Department ID : ");
            deptID = Convert.ToInt32(Console.ReadLine());

            using (var context = new HospitalContext())
            {
                // Update data in table
                var update = context.Doctor.Single(d => d.DocId == id);
                update.DocFname = fname;
                update.DocLname = lname;
                update.DocPhoneNumber = phoneNumber;
                update.DocQualification = qualification;
                update.DocAddress = address;
                update.DocSpecialist = specialist;
                update.DeptId = deptID;
                context.SaveChanges();
            }

            // Display data after updating
            Console.WriteLine("Data updated successfully, have a look....");
            h1.DisplayDoctors();
            Console.WriteLine();
        }

        //report
        public void ReportSummary()
        {
            using (var context = new HospitalContext())
            {
                Console.WriteLine();

                // Find a report of patient assigned to a particular doctor
                var dt = context.Doctor.ToList();
                var pt = context.Patient.ToList();
                var doc = dt.GroupJoin(pt,
                   a => a.DocId,
                   b => b.DocId,
                   (a, newGroup) => new
                   {
                       Patients = newGroup,
                       DocName = a.DocFname
                   }).ToList();
                foreach (var item in doc)
                {
                    Console.WriteLine($"Doctor Name : { item.DocName}");
                    foreach (var item2 in item.Patients)
                    {
                        Console.WriteLine($"Patient Name : {item2.PatFname}");
                    }
                }
                Console.WriteLine();


                // Find a report of medicine list for a particular patient
                Console.Write("Enter patient Id to view his/her medicine list");
                int ch = Convert.ToInt32(Console.ReadLine());
                var second = context.Prescription.Include(x => x.Drug).Where(x => x.PatId == ch).ToList();
                var medicineList = context.Patient.Include(x => x.Prescription).Where(x => x.PatId == ch).ToList();
                foreach (var i in medicineList)
                {
                    foreach (var j in second)
                    {
                        foreach (var k in j.Drug)
                        {
                            Console.WriteLine($"Patient's Id : {i.PatId}, Patient's Name : {i.PatFname}, Medicine Name : {k.DrugName}");
                        }
                    }
                }
                Console.WriteLine();

                // Display summary report of Doctor and patient (use Include method)
                Console.WriteLine("Summary report of Doctor and patient : ");
                var inc = context.Doctor.Include(d => d.Patient);
                foreach (var item in inc)
                {
                    foreach (var item1 in item.Patient)
                    {
                        Console.WriteLine($"Doctor's Name : {item.DocFname}, Patient's Name : {item1.PatFname}");
                    }
                }
                Console.WriteLine();
            }
        }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;

            while (!endApp)
            {
                int ch;

                Console.WriteLine("Press 1 to Add");
                Console.WriteLine("Press 2 to Update");
                Console.WriteLine("Press 3 to Delete");
                Console.WriteLine("Press 4 for Report summary");
                Console.WriteLine("Press 5 to Display data");
                Console.WriteLine("Press 6 to Exit");
                Console.Write("Enter your choice : ");
                ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        var add = new Hospital();
                        add.AddDoctor();   // Add method called
                        break;
                    case 2:
                        var update = new Hospital();
                        update.UpdateDoctor();   // Update method called
                        break;
                    case 3:
                        var del = new Hospital();
                        del.DeleteDoctor();   // Delete method called
                        break;
                    case 4:
                        var rep = new Hospital();
                        rep.ReportSummary();   // Report Summary method called
                        break;
                    case 5:
                        var dis = new Hospital();
                        dis.DisplayDoctors();
                        break;
                    case 6:
                        endApp = true;
                        break;
                    default:
                        break;
                }
            }

        }

        //public static IHostBuilder CreateHostBuilder(string[] args) =>
        //    Host.CreateDefaultBuilder(args)
        //        .ConfigureWebHostDefaults(webBuilder =>
        //        {
        //            webBuilder.UseStartup<Startup>();
        //        });
    }
}
