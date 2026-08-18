using Domain.Entities;

namespace Infrastructure;

public class DoctorService
{
    private List<Doctor> _doctors = [];

    public List<Doctor> GetAll()
    {
        return _doctors;
    }
    public void Create(Doctor doctor)
    {
        if (doctor.FullName.Length < 5)
        {
            System.Console.WriteLine("Name is too short");
            return;
        }
        if (doctor.FullName.Length > 15)
        {
            System.Console.WriteLine("Name is too long");
            return;
        }
        _doctors.Add(doctor);
    }
    public void GetDoctorById(int id)
    {
        foreach (var item in _doctors)
        {
            if (item.Id == id)
            {
                System.Console.WriteLine("Correct");
                return;
            }
        }
    }
    public void Update(Doctor doctor)
    {
        foreach (var item in _doctors)
        {
            if (item.Id == doctor.Id)
            {
                item.Id = doctor.Id;
                item.FullName = doctor.FullName;
                item.Specialization = doctor.Specialization;
                return;
            }
        }
        System.Console.WriteLine("Doctor not found");
    }
    public void Delete(int id)
    {
        foreach (var item in _doctors)
        {
            if (item.Id == id)
            {
                _doctors.Remove(item);
                return;
            }
        }
        System.Console.WriteLine("");
    }
}