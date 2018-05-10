using Newtonsoft.Json;

namespace AppCore.PizzaSoft.Web.Contracts.POCOs
{
    public class UserInfoPOCO
    {
        [JsonProperty(PropertyName = "nome")]
        public string Nome { get; set; }

        [JsonProperty(PropertyName = "sobrenome")]
        public string Sobrenome { get; set; }
    }
}
