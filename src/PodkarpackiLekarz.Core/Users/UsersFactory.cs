using PodkarpackiLekarz.Core.Users.Doctors;

namespace PodkarpackiLekarz.Core.Users;
public static class UsersFactory
{
    public static Doctor CreateDoctor(
        string firstName,
        string lastName,
        string email,
        DoctorType doctorType,
        string description)
        => Doctor.Create(
            firstName,
            lastName,
            email,
            doctorType,
            description);
}
