using PodkarpackiLekarz.Core.Users.Exceptions;

namespace PodkarpackiLekarz.Core.Users.Doctors;
public class DoctorType
{
    public Guid Id { get; private set; }
    public string Speciality { get; private set; }

    public DoctorType(Guid id, string speciality)
    {
        Id = id;
        Speciality = speciality;
    }

    public DoctorType()
    {

    }

    public static DoctorType Create(
        string speciality)
    {
        if (string.IsNullOrEmpty(speciality))
            throw new FieldCannotBeNullOrEmptyException("Speciality");

        return new DoctorType(Guid.NewGuid(), speciality);
    }
}
