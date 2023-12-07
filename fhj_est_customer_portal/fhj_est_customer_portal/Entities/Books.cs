using fhj_est_customer_portal.Data;
using Microsoft.EntityFrameworkCore;


namespace fhj_est_customer_portal.Entities
{
    public class Books
    {
        public int Id { get; set; }
        public string? Title { get; set; }

      
        public string? UserId { get; set; }
        public virtual ApplicationUser? User { get; set; }

    }
}
