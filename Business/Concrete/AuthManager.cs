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
        private IUserService _userPService;
        private ITokenHelper _tokenHelper;

        public AuthManager(IUserService userPService, ITokenHelper tokenHelper)
        {
            _userPService = userPService;
            _tokenHelper = tokenHelper;
        }

        public IDataResult<User> Register(UserPForRegisterDto userForRegisterDto, string password)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHacsh(password, out passwordHash, out passwordSalt);
            var user = new User
            {
                Email = userForRegisterDto.Email,
                FirstName = userForRegisterDto.FirstName,
                LastName = userForRegisterDto.LastName,
                PasswordHach = passwordHash,
                PasswordSalt = passwordSalt,
                Status = true
            };
            _userPService.Add(user);
            return new SuccessDataResult<User>(user, "kayıt oldu");
        }

        public IDataResult<User> Login(UserPForLoginDto userForLoginDto)
        {
            var userToCheck = _userPService.GetByMail(userForLoginDto.Email);
            if (userToCheck == null)
            {
                return new ErrorDataResult<User>("kullanıcı bulunamadı");
            }

            if (!HashingHelper.VerifyPasswordHach(userForLoginDto.Password, userToCheck.PasswordHach, userToCheck.PasswordSalt))
            {
                return new ErrorDataResult<User>("parola hatası");
            }

            return new SuccessDataResult<User>(userToCheck, "başarılı giriş ");
        }

        public IResult UserExists(string email)
        {
            if (_userPService.GetByMail(email) != null)
            {
                return new ErrorResult("kullanıcı mevcut");
            }
            return new SuccessResult();
        }

        public IDataResult<AccessToken> CreateAccessToken(User user)
        {
            var claims = _userPService.GetClaims(user);
            var accessToken = _tokenHelper.CreateToken(user, claims);
            return new SuccessDataResult<AccessToken>(accessToken, "asd");
        }
    }
}
