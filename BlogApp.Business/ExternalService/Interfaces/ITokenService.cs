using BlogApp.Business.DTOs.AccountDTOs;
using BlogApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Business.ExternalService.Interfaces
{
    public interface ITokenService
    {
        TokenResponseDto CreateToken(AppUser user, int expiredate = 60);

    }
}