# Oculus 3 app made by tutorial

### Tutorial source:
https://www.youtube.com/playlist?list=PLpEoiloH-4eMPHceEECeG0Qyb0lT0Eeti

## Step 1

### Setup
- Edit -> Project Settings -> XR Plugin Managm
- Install Unity Editor with modules **OpenJDK** and **Android SDK & NDK Tools**- Create new 3D Core projectent -> Install
- Enable PC - Oculus and Android - Oculus
- Download and import **Oculus Integration** asset
- Oculus - Tools - Project Setup Tool - Fix and Apply all for android and pc
- File - Build Settings - Android - Switch platform

### Make a scene
- Remove main camera
- Put OVRCameraRig on the scene
- Put OVRControllerPrefab into both LeftControllerAnchor and RightControllerAnchor
- Choose controller property as L Touch and R Touch
- Same with RightHandAnchor and LeftHandAnchor with OVRHandPrefab
- Create empty object called Passthrough as 0,0,0, add script OVRPassthroughLayer, change placement to underlay
- Select CenterEyeAnchor, change Clear Flags property to Solid color and change color to black
- Select OVRCameraRig, enable checkbox for Oculus 3, Hand Tracking Support - Controllers and Hands, Passthrough support - supported, insight passthrough - enable
- Create a cube in front of camera for test
- Build and Run
