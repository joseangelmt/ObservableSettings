# ObservableSettings

Creating a Universal Windows App and can't found the Settings template in Visual Studio?

This base class helps you to create an observable, strongly typed settings class.



## Usage

To use it follow the next steps:

1. Reference the Common library proyect.
2. Create a new class inheriting from ObservableSettings
3. Call to the base class constructor indicating if you want to store the settings in LocalSettings or in RoamingSettings.
4. Add all your properties calling the base class members 
Set and Get in the getter and in the setter.

Optionally you can set a default value decorating the property with DefaultSettingValue attribute.

Here an example of use:

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

            [DefaultSettingValue(Value = 115200)]
            public int Bauds
            {
                get { return Get<int>(); }
                set { Set(value); }
            }
        }
    }


## Contributing

1. Fork it!
2. Create your feature branch: `git checkout -b my-new-feature`
3. Commit your changes: `git commit -am 'Add some feature'`
4. Push to the branch: `git push origin my-new-feature`
5. Submit a pull request :D

## History

No history jet.

## Credits

Thanks to Tamás Deme (http://stackoverflow.com/users/4788286/tam%c3%a1s-deme) for helping me about reflection in Universal Windows Platform (http://stackoverflow.com/questions/35449747/why-my-uwp-app-cant-call-to-type-getproperties-method/35455271#35455271)

## License

No license. Use it. Modify it. Enjoy it.
