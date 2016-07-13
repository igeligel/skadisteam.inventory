using Newtonsoft.Json;

namespace skadisteam.inventory.Models.Json
{
    internal class Item
    {
        [JsonProperty(PropertyName = "id")]
        public long Id { get; set; }

        [JsonProperty(PropertyName = "classid")]
        public long ClassId { get; set; }

        [JsonProperty(PropertyName = "instanceid")]
        public long InstanceId { get; set; }

        [JsonProperty(PropertyName = "amount")]
        public int Amount { get; set; }

        [JsonProperty(PropertyName = "pos")]
        public int Pos { get; set; }
    }
}
