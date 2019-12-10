# **SteamVR Load Level**

This is the load level utility extracted from the [Steam VR plugin](https://github.com/ValveSoftware/steamvr_unity_plugin). 
All unused code has been removed and only leaved the minimum necessary.

**This package is not compatible with SteamVR**, if you install SteamVR use their 
[SteamVR_LoadLevel](https://github.com/ValveSoftware/steamvr_unity_plugin/blob/master/Assets/SteamVR/Scripts/SteamVR_LoadLevel.cs) class instead. 
There will be compilation errors if not.

To install add to your [package manifest](https://docs.unity3d.com/Manual/upm-manifestPrj.html) the following:
`"eu.innerspace.loadlevelvr":  "https://github.com/innerspacetrainings/LoadLevelVR.git#1.0.0"`

### Requirements

Unity 2018+

### Documentation
Documentation can be found online here: [https://valvesoftware.github.io/steamvr_unity_plugin/api/Valve.VR.SteamVR_LoadLevel.html](https://valvesoftware.github.io/steamvr_unity_plugin/api/Valve.VR.SteamVR_LoadLevel.html)

### Quick Start

* Add the component `VR_LoadLevel` to a GameObject. Be aware, this gameObject will became of type `DontDestroyOnLoad`.

* Set the level name to load.

* Enable `Auto Trigger On Enable`.

* Test!


You can also use the call `Trigger` to start a level transition and set the values from a script.

Another posible use, is to call `VR_LoadLevel.Begin` which will spawn a new component.

---

This project was done by Valve. Innerspace doesn't own the code nor is responsible for it's use. 