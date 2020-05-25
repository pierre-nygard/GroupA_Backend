﻿using AutoMapper;
using HorrorMovieAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HorrorMovieAPI.Configuration
{
    public class MappedProfile  : Profile 
    {
        public MappedProfile()
        {
            CreateMap<Movie, MovieDTO>()
                .ReverseMap();

            CreateMap<Actor, ActorDTO>()
                .ReverseMap();

            CreateMap<Casting, CastingDTO>()
                .ReverseMap();

            CreateMap<Director, DirectorDTO>()
                .ReverseMap();

            CreateMap<Genre, GenreDTO>()
                .ReverseMap();

        }
    }
}
