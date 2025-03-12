namespace Brain_Tumor_Classification.Helper;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<ApplicationUser, RegisterDto>();
        CreateMap<ApplicationUser, UserDetailsDto>();
        CreateMap<RegisterDto, ApplicationUser>();
        CreateMap<ApplicationUser, UpdateUserDto>();
    }
}
