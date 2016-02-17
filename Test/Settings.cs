using Common;
using Windows.Storage;

namespace Test
{
    public class Settings : ObservableSettings
    {
        private static Settings settings = new Settings();
        public static Settings Default
        {
            get { return settings; }
        }

        public Settings()
            : base(ApplicationData.Current.LocalSettings)
        {
        }

        [DefaultSettingValue(Value = (uint)115200)]
        public uint Bauds
        {
            get { return Get<uint>(); }
            set { Set(value); }
        }

        [DefaultSettingValue(Value = "")]
        public string Path
        {
            get { return Get<string>(); }
            set { Set(value); }
        }

        [DefaultSettingValue(Value = 200.0)]
        public double Width
        {
            get { return Get<double>(); }
            set { Set(value); }
        }

        [DefaultSettingValue(Value = true)]
        public bool Show
        {
            get { return Get<bool>(); }
            set { Set(value); }
        }

    }
}
