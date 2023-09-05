using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SavegameToolkit.Propertys;
using SavegameToolkit.Types;

namespace SavegameToolkit {

    public sealed class ArkSavFile : GameObjectContainerMixin, IConversionSupport, IPropertyContainer {

        private string className;

        public List<IProperty> Properties { get; } = new List<IProperty>();

        public void ReadBinary(ArkArchive archive, ReadingOptions options) {
            className = archive.ReadString();

            


            Properties.Clear();
            try {
                IProperty property = PropertyRegistry.ReadBinary(archive);

                while (property != null) {
                    Properties.Add(property);
                    property = PropertyRegistry.ReadBinary(archive);
                }
            } catch (UnreadablePropertyException upe) {
                Debug.WriteLine(upe.Message);
                Debug.WriteLine(upe.StackTrace);
            }

            // TODO: verify 0 int at end
        }

    }

}
