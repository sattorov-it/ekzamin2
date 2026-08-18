using Domain.Entities;
using Infrastructure;

DoctorService dcDoctor = new DoctorService();

var doctor1 = new Doctor
{
    Id = 1,
    FullName = "sattorov",
    Specialization = "zxcvb"
};
var doctor2 = new Doctor
{
    Id = 2,
    FullName = "nazarov",
    Specialization = "dddddddddddd"
};
var doctor3 = new Doctor
{
    Id = 4,
    FullName = "Hamidov",
    Specialization = "vvvvvvvvv"
};

dcDoctor.Create(doctor1);
dcDoctor.Create(doctor2);
dcDoctor.Create(doctor3);

var doctors = dcDoctor.GetAll();

System.Console.WriteLine("Aввал");
System.Console.WriteLine($"Id\tFullName\t");

foreach (var doctor in doctors)
{
    Console.WriteLine($"{doctor.Id}\t{doctor.FullName}\t{doctor.Specialization}");
}
var doctorForUpdate = new Doctor
{
    Id = 3,
    FullName = "valijooon",
    Specialization = "sdfghj"
};
dcDoctor.Update(doctorForUpdate);

System.Console.WriteLine("\nБади Update");
System.Console.WriteLine($"Id\tFullName\t\tSpecialization");

foreach (var doctor in doctors)
{
    Console.WriteLine($"{doctor.Id}\t{doctor.FullName}\t{doctor.Specialization}");
}
