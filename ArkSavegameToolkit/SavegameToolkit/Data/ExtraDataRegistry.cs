using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace SavegameToolkit.Data {

    public static class ExtraDataRegistry {
        /// <summary>
        /// Contains ExtraDataHandler in reverse Order
        /// </summary>
        private static readonly IList<IExtraDataHandler> extraDataHandlers = new List<IExtraDataHandler>();

        private static readonly ExtraDataFallbackHandler fallbackHandler = new ExtraDataFallbackHandler();

        static ExtraDataRegistry() {
            extraDataHandlers.Add(new ExtraDataZeroHandler());
            extraDataHandlers.Add(new ExtraDataCharacterHandler());
            extraDataHandlers.Add(new ExtraDataFoliageHandler());
        }

        /// <summary>
        /// Searches <see cref="extraDataHandlers"/> in reverse Order and terminates on the first
        /// <see cref="IExtraDataHandler"/> which can handle given <see cref="GameObject"/>
        /// </summary>
        /// <param name="gameObject"></param>
        /// <param name="archive">The source archive of object</param>
        /// <param name="length">Amount of bytes of extra data</param>
        /// <returns></returns>
        public static IExtraData GetExtraData(GameObject gameObject, ArkArchive archive, int length) {
            long position = archive.Position;
            try {
                foreach (IExtraDataHandler handler in extraDataHandlers.Reverse()) {
                    if (handler.CanHandle(gameObject, length)) {
                        return handler.ReadBinary(gameObject, archive, length);
                    }
                }
            } catch (UnexpectedDataException ude) {
                archive.Position = position;
                Debug.WriteLine(ude);
            }

            return fallbackHandler.ReadBinary(gameObject, archive, length);
        }

        /// <summary>
        /// Searches <see cref="extraDataHandlers"/> in reverse Order and terminates on the first
        /// <see cref="IExtraDataHandler"/> which can handle given <see cref="GameObject"/>
        /// </summary>
        /// <param name="gameObject"></param>
        /// <param name="node"></param>
        /// <returns></returns>
        public static IExtraData GetExtraData(GameObject gameObject, JToken node) {
            foreach (IExtraDataHandler handler in extraDataHandlers.Reverse()) {
                if (handler.CanHandle(gameObject, node)) {
                    return handler.ReadJson(gameObject, node);
                }
            }

            return fallbackHandler.ReadJson(gameObject, node);
        }
    }

}
