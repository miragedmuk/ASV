using ASVPack.Extensions;
using SavegameToolkit;
using SavegameToolkit.Arrays;
using SavegameToolkit.Propertys;
using SavegameToolkit.Structs;
using SavegameToolkitAdditions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ASVPack.Models
{
    public class ContentLocalProfile
    {

        public List<ContentTamedCreature> UploadedTames { get; set; } = new List<ContentTamedCreature>();
        public List<ContentPlayer> UploadedCharacters { get; set; } = new List<ContentPlayer>();
        public List<ContentMarker> MapMarkers { get; set; } = new List<ContentMarker>();

        public ContentLocalProfile()
        {

        }

        public ContentLocalProfile(ArkLocalProfile profile)
        {
            var playerMapMarkers = (ArkArrayStruct)profile.LocalProfile.GetTypedProperty<PropertyArray>("MapMarkersPerMaps").Value;
            if (playerMapMarkers != null && playerMapMarkers.Count > 0)
            {
                foreach (StructPropertyList playerMaps in playerMapMarkers)
                {
                    string mapName = playerMaps.GetPropertyValue<string>("MapName");
                    var mapMarkers = (ArkArrayStruct)playerMaps.GetTypedProperty<PropertyArray>("MapMarkers").Value;
                    foreach (StructPropertyList markerProperties in mapMarkers)
                    {
                        var newMarker = new ContentMarker();

                        string markerName = markerProperties.GetPropertyValue<string>("Name");
                        float lat = markerProperties.GetPropertyValue<float>("coord2f");
                        float lon = markerProperties.GetPropertyValue<float>("coord1f");

                        newMarker.Displayed = true;
                        newMarker.Lat = lat;
                        newMarker.Lon = lon;
                        newMarker.Name = markerName;
                        newMarker.Map = mapName;
                        newMarker.InGameMarker = true;

                        var markerColor = markerProperties.GetTypedProperty<PropertyStruct>("OverrideMarkerTextColor")?.Value;
                        if (markerColor != null)
                        {
                            if (markerColor is StructColor structColor)
                            {
                                Color c = Color.FromArgb((int)structColor.A, (int)structColor.R, (int)structColor.G, (int)structColor.B);
                                newMarker.Colour = c.ToArgb();
                            }
                        }

                        MapMarkers.Add(newMarker);
                    }
                }
            }

            var uploadedData = profile.GetTypedProperty<PropertyStruct>("MyArkData");
            if (uploadedData != null)
            {
                var uploadedProperties = (StructPropertyList)uploadedData.Value;
                if (uploadedProperties != null)
                {
                    var uploadedItemData = uploadedProperties.GetTypedProperty<PropertyArray>("ArkItems");
                    if (uploadedItemData != null)
                    {

                    }

                    var uploadedTameData = uploadedProperties.GetTypedProperty<PropertyArray>("ArkTamedDinosData");
                    if (uploadedTameData != null)
                    {
                        var tameProperties = (ArkArrayStruct)uploadedTameData.Value;
                        foreach (StructPropertyList tame in tameProperties)
                        {

                            PropertyArray byteArrays = tame.GetTypedProperty<PropertyArray>("DinoData");

                            ArkArrayUInt8? creatureBytes = byteArrays.Value as ArkArrayUInt8;
                            if (creatureBytes != null)
                            {
                                var creatureStream = new System.IO.MemoryStream(creatureBytes.ToArray<byte>());

                                using (ArkArchive creatureArchive = new ArkArchive(creatureStream))
                                {
                                    // number of serialized objects
                                    int objCount = creatureArchive.ReadInt();
                                    if (objCount != 0)
                                    {
                                        var storedGameObjects = new List<GameObject>(objCount);
                                        for (int oi = 0; oi < objCount; oi++)
                                        {
                                            storedGameObjects.Add(new GameObject(creatureArchive));
                                        }

                                        foreach (var ob in storedGameObjects)
                                        {
                                            ob.LoadProperties(creatureArchive, new GameObject(), 0);
                                        }

                                        var creatureObject = storedGameObjects[0];
                                        var statusObject = storedGameObjects[1];

                                        // assume the first object is the creature object
                                        string creatureActorId = creatureObject.Names[0].ToString();

                                        // the tribe name is stored in `TamerString`, non-cryoed creatures have the property `TribeName` for that.
                                        if (creatureObject.GetPropertyValue<string>("TribeName")?.Length == 0 && creatureObject.GetPropertyValue<string>("TamerString")?.Length > 0)
                                            creatureObject.Properties.Add(new PropertyString("TribeName", creatureObject.GetPropertyValue<string>("TamerString")));


                                        var tamedCreature = creatureObject.AsTamedCreature(statusObject);
                                        if (tamedCreature != null) UploadedTames.Add(tamedCreature);

                                    }

                                }

                            }
                        }
                    }


                    var uploadedCharacterData = uploadedProperties.GetTypedProperty<PropertyArray>("ArkPlayerData");
                    if (uploadedCharacterData != null)
                    {

                        var playerProperties = (ArkArrayStruct)uploadedCharacterData.Value;
                        foreach (StructPropertyList playerProp in playerProperties)
                        {

                            PropertyArray byteArrays = playerProp.GetTypedProperty<PropertyArray>("PlayerDataBytes");

                            ArkArrayUInt8? playerBytes = byteArrays.Value as ArkArrayUInt8;
                            if (playerBytes != null)
                            {
                                var playerStream = new System.IO.MemoryStream(playerBytes.ToArray<byte>());

                                using (ArkArchive playerArchive = new ArkArchive(playerStream))
                                {
                                    // number of serialized objects
                                    int objCount = playerArchive.ReadInt();
                                    if (objCount != 0)
                                    {
                                        var storedGameObjects = new List<GameObject>(objCount);
                                        for (int oi = 0; oi < objCount; oi++)
                                        {
                                            storedGameObjects.Add(new GameObject(playerArchive));
                                        }

                                        foreach (var ob in storedGameObjects)
                                        {
                                            ob.LoadProperties(playerArchive, new GameObject(), 0);
                                        }



                                        var playerObject = storedGameObjects[0];
                                        var contentPlayer = new ContentPlayer(playerObject);

                                        if (contentPlayer != null)
                                        {
                                            UploadedCharacters.Add(contentPlayer);
                                        }

                                    }

                                }

                            }
                        }
                    }

                }

            }

        }

    }
}
