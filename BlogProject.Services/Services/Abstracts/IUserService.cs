﻿using BlogProject.Entity.DTOs.Users;
using BlogProject.Entity.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Services.Services.Abstracts
{
    public interface IUserService
    {
        Task<List<UserDto>> GetAllUsersWithRoleAsync();
        Task<List<AppRole>> GetAllRolesAsync();
        Task<IdentityResult> AddUserAsync(UserAddDto userAddDto);
        Task<AppUser> GetUserByIdAsync(Guid userId);
        Task<IdentityResult> UpdateUserAsync(UserUpdateDto userUpdateDto);
        Task<string> GetUserRoleAsync(AppUser appUser);
        Task<(IdentityResult identityResult, string? email)> DeleteUserAsync(Guid userId);
        Task<UserProfileDto> GetUserProfileAsync();
        Task<bool> UserProfileUpdateAsync(UserProfileDto userProfileDto);
        Task<string> GetUsername();

    }
}
