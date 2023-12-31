﻿using AutoMapper;
using BlogProject.Entity.DTOs.Users;
using BlogProject.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Services.AutoMapper
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserDto, AppUser>().ReverseMap();
            CreateMap<UserAddDto, AppUser>().ReverseMap();
            CreateMap<UserUpdateDto, AppUser>().ReverseMap();
            CreateMap<UserUpdateDto, UserDto>().ReverseMap();
            CreateMap<UserProfileDto, AppUser>().ReverseMap();
        }
    }
}
