namespace Optimizely_Project.Middleware
{
	public static class PageRedirectionMiddleware
	{
		public static IApplicationBuilder UsePageRedirectionMiddleware(this IApplicationBuilder app)
		{
			//Use when want to redirect it to the controller action and when MVC services are activated.
			app.UseStatusCodePagesWithReExecute("/500Error");
			app.UseExceptionHandler("/500Error");

			//Use when want to Display 500 Internal Server Error from CMS Controller Action.
			app.UseStatusCodePagesWithReExecute("/ErrorPage/500Error");
			app.UseExceptionHandler("/ErrorPage/500Error");

			return app.Use(async (ctx, next) =>
			{
				await next();

				if (ctx.Response.StatusCode == 404 && !ctx.Response.HasStarted)
				{
					string originalPath = ctx.Request.Path.Value;
					ctx.Items["originalPath"] = originalPath;
					ctx.Request.Path = $"/en/{ctx.Response.StatusCode}";
					await next();
				}
			});
		}
	}
}
