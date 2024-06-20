using AutoMapper;

namespace loggerservice.RequestHelpers;

public class MappingProfiles: Profile
{
    public MappingProfiles(){
        CreateMap<CustomError,CustomErrorDto>().IncludeMembers();
    }
}
