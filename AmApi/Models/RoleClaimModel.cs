using Microsoft.AspNetCore.Identity;

namespace AmApi.Models
{
    public class RoleClaimModel :IdentityRoleClaim<int>
    {
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public int? CreateUserId { get; set; }
        public int? UpdateUserId { get; set; }
    }
}
