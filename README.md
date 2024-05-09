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

## Step 2

### Add irl scene support

- Add OVRSceneManager into the scene
- Set Place Prefab and Volume Prefab properties with Assets/Oculus/SampleFramework/Usage/SceneManager/Prefabs/Plane and Volume
- In OVRCameraRig set Scene Support=Supported
- Build and Run to test
- Replace Place and Volume with Invisible Place and Invisible Volume to hide them

### Add spawning balls

- Add script to RightHandAnchor spawning balls
- Add ball prefab, add material with red color and physic material with high bounceness, apply them to the ball prefab
- Edit -> Project Settings -> Time, set Fixed Timestep to 0.00833333
- In OVRSceneManager set Prefab Overrides: GLOBAL_MESH=Global Mesh Collider from assets

## Step 3

# First way

- Create material, set shader = SelectivePassthrough, Render Queue = 4000, Inflation = 0.003, Blend Color = Substract
- Apply it to OVRHandPrefab's Skinned Mesh Renderer's Materials
- Make a copy of Global Mesh Renderer Collider, name it Global Mesh Renderer Collider Depth
- Make a copy of previously created passthrough material
- Enter in previously created prefab and apply our new material to Mesh Renderer -> materials
- Replace OVR Scene manager's GLOBAL MESH with our new Global Mesh Renderer Collider Depth

