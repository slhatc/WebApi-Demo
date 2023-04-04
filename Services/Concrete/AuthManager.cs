using Azure;
using DataAccess.Abstract;
using Entities.Dtos;
using Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Concrete
{
    public class AuthManager : IAuthService
    {
        //private readonly List<Client> _clients;
        private readonly ITokenService _tokenService;
        //private readonly UserManager<UserApp> _userManager;
        private readonly IUnitOfWork _unitOfWork;
        //private readonly IGenericRepository<UserRefreshToken> _userRefreshTokenService;
        public AuthManager(ITokenService tokenService,IUnitOfWork unitOfWork)
        {
            _tokenService = tokenService;
            _unitOfWork = unitOfWork;
        }
        public async Task<TokenDto> CreateTokenAsync()
        {
            //if (loginDto == null) throw new ArgumentNullException(nameof(loginDto));

            //var user = await _userManager.FindByEmailAsync(loginDto.Email);

            //if (user == null) return Response<TokenDto>.Fail("Email or Password is wrong", 400, true);

            //if (!await _userManager.CheckPasswordAsync(user, loginDto.Password))
            //{
            //    return Response<TokenDto>.Fail("Email or Password is wrong", 400, true);
            //}
            var token = _tokenService.CreateToken();

            //var userRefreshToken = await _userRefreshTokenService.Where(x => x.UserId == user.Id).SingleOrDefaultAsync();

            //if (userRefreshToken == null)
            //{
            //    await _userRefreshTokenService.AddAsync(new UserRefreshToken { UserId = user.Id, Code = token.RefreshToken, Expiration = token.RefreshTokenExpiration });
            //}
            //else
            //{
            //    userRefreshToken.Code = token.RefreshToken;
            //    userRefreshToken.Expiration = token.RefreshTokenExpiration;
            //}

            //await _unitOfWork.CommmitAsync();

            return token;
        }
    }
}
