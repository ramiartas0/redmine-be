namespace Redmine.API
{
    public class AuthMiddleware
    {
        private readonly RequestDelegate _requestDelegate;

        public AuthMiddleware(RequestDelegate requestDelegate)
        {
            _requestDelegate = requestDelegate;
        }

        public async Task Invoke(HttpContext context)
        {
            await Task.Delay(1000);
            await _requestDelegate(context);
        }
    }
}
