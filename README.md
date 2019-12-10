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
Documentation can be found online here: [https://valvesoftware.github.io/steamvr_unity_plugin/](https://valvesoftware.github.io/steamvr_unity_plugin/)

### Quick Start

 * Follow the [Quickstart guide on this site](https://valvesoftware.github.io/steamvr_unity_plugin/articles/Quickstart.html)

 * If you want to explore the [Interaction System](https://valvesoftware.github.io/steamvr_unity_plugin/articles/Interaction-System.html) scene you'll need to open the SteamVR Input window (under the Window Menu), click yes to copy example jsons, then click Save and Generate to create input actions.

 * For the most simple example of VR with tracked controllers see the sample scene at /SteamVR/Simple Sample

 * For a more extensive example including picking up, throwing objects, and animated hands see the Interaction System example at /SteamVR/Interaction System/Samples/Interactions_Example


### Support
 If you're having trouble with the plugin the best place to discuss issues is our github here: https://github.com/ValveSoftware/steamvr_unity_plugin/issues/

 If you'd like to discuss features, post guides, and give general feedback please post on the steam forum here: https://steamcommunity.com/app/250820/discussions/7/
