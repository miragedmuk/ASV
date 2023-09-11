using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SavegameToolkit.Structs {

    public abstract class StructBase : IStruct {

        public bool IsNative => true;

        public virtual void CollectNames(NameCollector collector) { }

        public abstract int Size(NameSizeCalculator nameSizer);

        public abstract void Init(ArkArchive archive);
        
    }

}
