﻿using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using MuziekInVlaanderen.DTOs;

namespace MuziekInVlaanderen.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        //private readonly ICustomerRepository _customerRepository;
        private readonly IConfiguration _config;
        public AccountController(SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager
                                //,ICustomerRepository customerRepository, Configuration config
                                )
        {
            _signInManager = signInManager;
            _userManager = userManager;
            //_customerRepository = customerRepository;
            //_config = config;
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<ActionResult<String>> CreateToken(LoginDTO model)
        {
            var user = await _userManager.FindByNameAsync(model.Email); if (user != null)
            {
                var result = await _signInManager.CheckPasswordSignInAsync(user, model.Password, false); if (result.Succeeded)
                {
                    string token = GetToken(user);
                    return Created("", token); //returns only the token
                }
            }
            return BadRequest();
        }

        private String GetToken(IdentityUser user)
        {      // Createthetoken
            var claims = new[]{
                new Claim(JwtRegisteredClaimNames.Sub, user.Email),
                new Claim(JwtRegisteredClaimNames.UniqueName, user.UserName)
            };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Tokens:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(null, null, claims, expires: DateTime.Now.AddMinutes(30), signingCredentials: creds);
            return new JwtSecurityTokenHandler().WriteToken(token);

        }
        /*
        [AllowAnonymous]
        [HttpPost("register")]
        public async Task<ActionResult<String>> Register(RegisterDTOmodel)
        {
            IdentityUser user = new IdentityUser {
                UserName = model.Email,
                Email = model.Email
            };
            Customer customer = new Customer {
                Email = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName
            };
            var result = await_userManager.CreateAsync(user, model.Password);
            if (result.Succeeded) {
                _customerRepository.Add(customer);
                _customerRepository.SaveChanges();
                string token = GetToken(user);
                return Created("", token);
            }

            return BadRequest();
        }

        [HttpGet("Favorites")]
        public IEnumerable<Recipe> GetFavorites()
        {
            Customer customer = _customerRepository.GetBy(User.Identity.Name);
            return customer.FavoriteRecipes;
        }
        */

    }
}