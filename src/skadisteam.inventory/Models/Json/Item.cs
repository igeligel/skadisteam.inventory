using Newtonsoft.Json;

namespace skadisteam.inventory.Models.Json
{
    internal class Item
    {
        [JsonProperty(PropertyName = "id")]
        internal long Id { get; set; }

        [JsonProperty(PropertyName = "classid")]
        internal long ClassId { get; set; }

        [JsonProperty(PropertyName = "instanceid")]
        internal long InstanceId { get; set; }

        [JsonProperty(PropertyName = "amount")]
        internal int Amount { get; set; }

        [JsonProperty(PropertyName = "pos")]
        internal int Pos { get; set; }
    }
}
