using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using wvse.Service.Data;
using wvse.Service.Data.Entities;

namespace wvse.Service.Data
{
    public class FileDataProvider
    {
        public Version GetVersion()
        {
            Version version;
            
            using (var fs = new FileStream("/data/Version.json", FileMode.Open))
            using (var r = new StreamReader(fs))
            {
                string json = r.ReadToEnd();
                version = JsonConvert.DeserializeObject<Version>>(json);
            }
            
            return version;
        }
    }
}
