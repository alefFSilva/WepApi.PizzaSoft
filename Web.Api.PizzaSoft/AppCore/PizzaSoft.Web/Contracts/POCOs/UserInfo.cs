using Newtonsoft.Json;

namespace AppCore.PizzaSoft.Web.Contracts.POCOs
{
    public class UserInfo
    {
        [JsonProperty(PropertyName = "nome")]
        public string Nome { get; set; }

        [JsonProperty(PropertyName = "sobrenome")]
        public string Sobrenome { get; set; }
    }
}
