using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ARKViewer.Configuration
{
    [DataContract]
    public class ApiConfiguration
    {
        [DataMember] public List<ApiUserConfiguration> Clients { get; set; } = new List<ApiUserConfiguration>();
        [DataMember] public string Address { get; set; } = "http://localhost";
        [DataMember] public int Port { get; set; } = 8081;

        public ApiConfiguration()
        {
        }

        public void Save()
        {
            string jsonString = JsonConvert.SerializeObject(this);
            string configFilename = Path.Combine(AppContext.BaseDirectory, "api.config.json");
            File.WriteAllText(configFilename, jsonString);
        }

        public void Load()
        {
            string configFilename = Path.Combine(AppContext.BaseDirectory, "api.config.json");
            if (!File.Exists(configFilename)) return;

            string jsonString = File.ReadAllText(configFilename);
            ApiConfiguration loadedConfig = JsonConvert.DeserializeObject<ApiConfiguration>(jsonString);
            if (loadedConfig != null)
            {
                this.Port = loadedConfig.Port;
                this.Address = loadedConfig.Address;
                this.Clients = loadedConfig.Clients;
            }

        }
    }
}
