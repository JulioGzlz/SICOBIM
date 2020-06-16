using AutoMapper;
using SICOBIM_B.Entities;
using SICOBIM_B.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SICOBIM_B.Helpers
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserModel>();
            CreateMap<ModeloRegistro, User>();
            //CreateMap<UpdateModel, User>();
        }
    }
}
