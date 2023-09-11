using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SavegameToolkit.Structs {

    [JsonObject(MemberSerialization.OptIn)]
    public class StructUniqueNetIdRepl : StructBase {

        [JsonProperty(Order = 0)]
        public int Unk { get; private set; }

        [JsonProperty(Order = 1)]
        public string NetId { get; private set; }

        public override void Init(ArkArchive archive) {
            Unk = archive.ReadInt();
            NetId = archive.ReadString();
        }



        public override int Size(NameSizeCalculator nameSizer) => sizeof(int) + ArkArchive.GetStringLength(NetId);
    }

}
