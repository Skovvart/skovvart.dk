import type { RequestHandler } from './__types/web.config';
export const GET: RequestHandler = async () => {
	return {
		headers:{
			"content-type": "text/xml"
		},
		body: `<?xml version="1.0" encoding="utf-8"?>
<configuration>
	<system.webServer>
		<httpErrors errorMode="Custom" defaultResponseMode="File" >
			<remove statusCode="404" />
			<error statusCode="404" path="404\index.html" />
		</httpErrors>
		<staticContent> 
			<mimeMap fileExtension=".webp" mimeType="image/webp" /> 
		</staticContent>
	</system.webServer>
</configuration>`
	};
};
