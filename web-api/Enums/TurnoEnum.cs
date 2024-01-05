using System.Text.Json.Serialization;

namespace web_api.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TurnoEnum
    {
        Manha,
        Tarde,
        Noite
          
    }
}
