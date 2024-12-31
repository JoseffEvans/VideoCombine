using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace VideoCombine {
    public class SettingsManager {
        public const string SettingsPath = "./settings.json";

        public SettingsManager() {
            CreateSettings();
        }

        public Settings Get() {
            try {
                return JsonSerializer.Deserialize<Settings>(File.ReadAllText(SettingsPath))
                    ?? throw new Exception();
            } catch(Exception) {
                if(File.Exists(SettingsPath))
                    File.Delete(SettingsPath);
                CreateSettings();
                return new Settings();
            }
        }

        public void Save(Settings settings) {
            CreateSettings();
            File.WriteAllText(SettingsPath, JsonSerializer.Serialize(settings));
        }

        void CreateSettings() {
            if(!File.Exists(SettingsPath)) {
                File.WriteAllText(SettingsPath, JsonSerializer.Serialize(new Settings()));
            }
        }
    }
}
