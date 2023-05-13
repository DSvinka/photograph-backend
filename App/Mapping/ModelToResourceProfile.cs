using AutoMapper;
using Domain.Models;
using Domain.Models.Albums;

namespace App.Mapping;

/// <inheritdoc />
public class ModelToResourceProfile: Profile
{
    /// <inheritdoc />
    public ModelToResourceProfile()
    {
        CreateMap<AlbumModel, AlbumResponse>();
        CreateMap<AlbumFileRelation, FileResponse>();

        CreateMap<ReviewModel, ReviewResponse>();
        CreateMap<ReviewModel, ReviewWithUserResponse>()
            .ForMember(member => member.User, options => options.MapFrom(model => model.User));
        
        CreateMap<FileModel, FileResponse>();

        CreateMap<UserModel, UserResponse>();

        CreateMap<StringModel, StringResponse>();
        
        CreateMap<SettingsModel, SettingsResponse>();
        CreateMap<SettingsModel, SettingsAdminResponse>();
    }
}