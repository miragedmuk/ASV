using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SavegameToolkit.Propertys;
using SavegameToolkit.Types;

namespace SavegameToolkit.Arrays {

    public abstract class ArkArrayBase<T> : List<T>, IArkArray<T> {

        public abstract ArkName Type { get; }

        public abstract void Init(ArkArchive archive, PropertyArray property);

        public virtual void Init(JArray node, PropertyArray property) {
            AddRange(node.Values<T>());
        }

        public abstract int CalculateSize(NameSizeCalculator nameSizer);

        public virtual void WriteJson(JsonTextWriter generator, WritingOptions writingOptions) {
            JsonSerializer.CreateDefault().Serialize(generator, this);
        }

        public abstract void WriteBinary(ArkArchive archive);

        public virtual void CollectNames(NameCollector collector) { }

    }

}
