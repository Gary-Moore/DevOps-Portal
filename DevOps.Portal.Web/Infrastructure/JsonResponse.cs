using System;
using System.IO;
using System.Web.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace DevOps.Portal.Web.Infrastructure
{
    public class JsonResponse : JsonResult
    {
        private readonly JsonSerializerSettings _jsonSerializerSettings;

        public JsonResponse(object data, JsonRequestBehavior behavior)
        {
            Data = data;
            JsonRequestBehavior = behavior;

            _jsonSerializerSettings = new JsonSerializerSettings()
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };
        }

        public override void ExecuteResult(ControllerContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            if (JsonRequestBehavior == JsonRequestBehavior.DenyGet &&
                string.Equals(context.HttpContext.Request.HttpMethod, "GET", StringComparison.OrdinalIgnoreCase))
            {
                throw new InvalidOperationException(
                    "GET requests have been blocked. To allow GET requests, set JsonRequestBehavior to AllowGet.");
            }

            var response = context.HttpContext.Response;
            response.ContentType = string.IsNullOrEmpty(ContentType) ? "application/json" : ContentType;

            if (ContentEncoding != null)
            {
                response.ContentEncoding = ContentEncoding;
            }

            var serializer = JsonSerializer.CreateDefault(_jsonSerializerSettings);
            using (var writer = new StringWriter())
            {
                serializer.Serialize(writer, Data);
                response.Write(writer.ToString());
            }
        }
    }
}