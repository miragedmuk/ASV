using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SavegameToolkit.Types;

namespace SavegameToolkit.Propertys {

    public interface IProperty : INameContainer {
        ArkName Name { get; }
        string NameString { get; }

        ArkName Type { get; }
        string TypeString { get; }

        int DataSize { get; }

        int Index { get; }

        void Init(ArkArchive archive, ArkName name);

        void Init(JObject node);

        /// <summary>
        /// Calculates the amount of bytes required to serialize this property.
        ///
        /// Includes everything contained in this property.
        /// </summary>
        /// <param name="nameSizer">function to calculate the size of a name in bytes in the current context</param>
        /// <returns>amount of bytes required to write this property in raw binary representation</returns>
        int CalculateSize(NameSizeCalculator nameSizer);

    }

    public interface IProperty<out T> : IProperty {
        T Value { get; }
    }



}
