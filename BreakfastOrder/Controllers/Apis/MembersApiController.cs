using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BreakfastOrder.Models.EFModels;
using BreakfastOrder.Models.ViewModels;

namespace BreakfastOrder.Controllers.Apis
{
    public class MembersApiController : ApiController
    {
        [HttpGet]
        [Route("api/membersapi/members")]
        public IHttpActionResult GetAllMembers(int memberId)
        {
            var db = new AppDbContext();

            var data = db.Members
                .Where(m => m.Id == memberId)
                .Select(x => new MemberVm
                {
                    Id = x.Id,
                    Name = x.Name,
                    Account = x.Account, // 這裡用 Account 對應 Email
                    EncryptedPassword = x.EncryptedPassword, // 使用加密的密碼
                    Phone = x.Phone,
                    ProfilePhoto = x.ProfilePhoto,
                    Points = x.Points,
                    RegistrationDate = x.RegistrationDate,
                    BlackList = x.BlackList
                })
                .FirstOrDefault(); // 根據 MemberId 返回單一會員資料

            if (data == null)
            {
                return NotFound(); // 如果找不到該會員，返回 404 錯誤
            }

            return Ok(data); // 返回會員資料
        }
    }
}
