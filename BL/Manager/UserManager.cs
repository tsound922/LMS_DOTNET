﻿using BL.Manager.Interfaces;
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
    public class UserManager : IUserManager
    {
        private IUserRepository _userRepository;

        public UserManager(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public UserDisplayDto CreateUser(UserRegisterDto user)
        {
            User createdUser = new User
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                PasswordHash = Util.HashHelper.GetMD5HashData(user.Password),
                UserName = user.UserName,
                CreatedOn = DateTime.Now
            };
            createdUser = _userRepository.Add(createdUser);

            if (createdUser != null)
            {
                return AutoMapper.Mapper.Map<User, UserDisplayDto>(createdUser);
            }

            return null;
        }

        public User FindUser(string userName, string password)
        {
            var passwordHash = Util.HashHelper.GetMD5HashData(password);
            return _userRepository.FindUser(userName, passwordHash);
        }
    }

}
