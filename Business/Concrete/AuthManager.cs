using Business.Abstract;
using Business.Constanst;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Security.JWT;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Security.Hashing;

namespace Business.Concrete
{
    public class AuthManager : IAuthService
    {
        private IUserPService _userPService;
        private ITokenHelper _tokenHelper;

        public AuthManager(IUserPService userPService, ITokenHelper tokenHelper)
        {
            _userPService = userPService;
            _tokenHelper = tokenHelper;
        }

        public IDataResult<UserP> Register(UserPForRegisterDto userForRegisterDto, string password)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHacsh(password, out passwordHash, out passwordSalt);
            var user = new UserP
            {
                Email = userForRegisterDto.Email,
                FirstName = userForRegisterDto.FirstName,
                LastName = userForRegisterDto.LastName,
                PasswordHach = passwordHash,
                PasswordSalt = passwordSalt,
                Status = true
            };
            _userPService.Add(user);
            return new SuccessDataResult<UserP>(user, "kayıt oldu");
        }

        public IDataResult<UserP> Login(UserPForLoginDto userForLoginDto)
        {
            var userToCheck = _userPService.GetByMail(userForLoginDto.Email);
            if (userToCheck == null)
            {
                return new ErrorDataResult<UserP>("kullanıcı bulunamadı");
            }

            if (!HashingHelper.VerifyPasswordHach(userForLoginDto.Password, userToCheck.PasswordHach, userToCheck.PasswordSalt))
            {
                return new ErrorDataResult<UserP>("parola hatası");
            }

            return new SuccessDataResult<UserP>(userToCheck, "başarılı giriş ");
        }

        public IResult UserExists(string email)
        {
            if (_userPService.GetByMail(email) != null)
            {
                return new ErrorResult("kullanıcı mevcut");
            }
            return new SuccessResult();
        }

        public IDataResult<AccessToken> CreateAccessToken(UserP user)
        {
            var claims = _userPService.GetClaims(user);
            var accessToken = _tokenHelper.CreateToken(user, claims);
            return new SuccessDataResult<AccessToken>(accessToken, "asd");
        }
    }
}
