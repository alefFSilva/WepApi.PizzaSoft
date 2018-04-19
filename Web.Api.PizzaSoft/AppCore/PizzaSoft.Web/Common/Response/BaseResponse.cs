using Newtonsoft.Json;
using System.Collections.Generic;

namespace AppCore.PizzaSoft.Web.Common.Response
{
    [JsonObject]
    public class BaseResponse<T> where T : new()
    {
        [JsonProperty(PropertyName = "sucess")]
        public bool Success { get; set; }

        [JsonProperty(PropertyName = "messages")]
        public List<string> Messages { get; set; }

        [JsonProperty(PropertyName = "data")]
        public T Data {get;set;}
    }
}
