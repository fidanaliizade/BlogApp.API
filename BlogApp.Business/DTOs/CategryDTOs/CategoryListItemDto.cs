﻿using BlogApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Business.DTOs.CategryDTOs
{
    public record CategoryListItemDto
    {
        public List<Category> Categories { get; set; }
    }
}
