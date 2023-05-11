using AutoMapper;
using Domain.Models;
using Domain.Models.Albums;

namespace App.Mapping;

/// <inheritdoc />
public class ResourceToModelProfile: Profile
{
    /// <inheritdoc />
    public ResourceToModelProfile()
    {
        CreateMap<AlbumRequest, AlbumModel>();
        
        CreateMap<FileRequest, FileModel>();

        CreateMap<SettingsRequest, SettingsModel>();

        CreateMap<StringRequest, StringModel>();

        CreateMap<UserRequest, UserModel>();
    }
}