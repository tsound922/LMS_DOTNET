﻿using AutoMapper;
using BL.Manager.Interfaces;
using Data.Repositories.interfaces;
using Model.Dto;
using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Manager
{
    public class StudentManager : IStudentManager
            return Mapper.Map<Student, StudentDto>(_studentRepository.GetById(id));
        }
}