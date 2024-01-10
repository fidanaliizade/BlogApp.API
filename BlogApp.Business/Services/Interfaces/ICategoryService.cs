using BlogApp.Business.DTOs.AccountDTOs;
using BlogApp.Business.DTOs.CategryDTOs;
using BlogApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Business.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<ICollection<Category>> GetAllAsync();
        Task<Category> GetByIdAsync(int id);
        Task<Category> Create(CategoryCreateDto Category);
        Task<bool> Register(RegisterDto registerDtos);
        Task<bool> Update(CategoryUpdateDto categorydto);
        Task Delete(int id);
        Task<TokenResponseDto> LoginAsync(LoginDto dto);

    }

}

