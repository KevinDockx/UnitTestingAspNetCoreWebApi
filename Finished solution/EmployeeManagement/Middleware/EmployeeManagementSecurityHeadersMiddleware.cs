namespace EmployeeManagement.Middleware;

public class EmployeeManagementSecurityHeadersMiddleware(RequestDelegate next)
{
    private readonly RequestDelegate _next = next;

    public async Task InvokeAsync(HttpContext context)
    {
        IHeaderDictionary headers = context.Response.Headers;
         
        // Add CSP + X-Content-Type
        headers.ContentSecurityPolicy = "default-src 'self';frame-ancestors 'none';"; 
        headers.XContentTypeOptions = "nosniff"; 

        await _next(context);
    }
}

