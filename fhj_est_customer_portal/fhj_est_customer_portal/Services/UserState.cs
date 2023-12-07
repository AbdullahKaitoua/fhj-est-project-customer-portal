
namespace fhj_est_customer_portal.Services
{
    public class UserState
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserState(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
            FullName = _httpContextAccessor.HttpContext.User.GetFullName();
        }

        public string FullName { get; private set; }

        public event Action OnChange;
        public string GetFullName()
        {
            return FullName;
        }
    }
}