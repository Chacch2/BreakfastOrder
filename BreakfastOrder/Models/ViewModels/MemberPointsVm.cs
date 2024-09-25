using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BreakfastOrder.Models.ViewModels
{
    public class MemberPointsVm
    {
        public int CurrentPoints { get; set; }
        public List<PointsDetailVm> RankList { get; set; }
    }
}