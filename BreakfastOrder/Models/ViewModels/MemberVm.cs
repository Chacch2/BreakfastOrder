using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BreakfastOrder.Models.ViewModels
{
    public class MemberVm
    {
        public int Id { get; set; }  // 會員 ID
        public string Name { get; set; }  // 會員名稱
        public string Account { get; set; }  // 電子郵件
        public string EncryptedPassword { get; set; }
        public string Phone { get; set; }  // 電話號碼
        public string ProfilePhoto { get; set; }  // 大頭照
        public int Points { get; set; }  // 點數
        public DateTime RegistrationDate { get; set; }  // 註冊日期
        public bool BlackList { get; set; }  // 是否在黑名單
        public bool IsConfirmed { get; set; }
    }
}