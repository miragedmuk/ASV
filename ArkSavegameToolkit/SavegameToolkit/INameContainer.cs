using SavegameToolkit.Types;

namespace SavegameToolkit {

    public interface INameContainer {
        void CollectNames(NameCollector collector);
    }

    public delegate void NameCollector(ArkName name);

    public delegate int NameSizeCalculator(ArkName name);

}
