using Microsoft.AspNet.Identity;
using NguyenGiaHuy_2080600024_BigSchool.DTOs;
using NguyenGiaHuy_2080600024_BigSchool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NguyenGiaHuy_2080600024_BigSchool.Controllers
{
    public class FollowingsController : ApiController
    {

        private readonly ApplicationDbContext _dbContext;

        public FollowingsController()
        {
            _dbContext = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult Follow(FollowingDto folowingDto)
        {
            var userId = User.Identity.GetUserId();
            if (_dbContext.Followings.Any(f => f.FollowerId == userId && f.FolloweeId == folowingDto.FolloweeId))
                return BadRequest("Following already exists!");

            var folowing = new Following
            {
                FollowerId = userId,
                FolloweeId = folowingDto.FolloweeId,
            };

            _dbContext.Followings.Add(folowing);
            _dbContext.SaveChanges();

            return Ok();
        }
    }
}
