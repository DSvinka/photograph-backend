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
        
        CreateMap<FileModel, FileResponse>();
        
        CreateMap<UserModel, UserResponse>();

        CreateMap<StringModel, StringResponse>();
        
        CreateMap<SettingsModel, SettingsResponse>();
        CreateMap<SettingsModel, SettingsAdminResponse>();
    }
}