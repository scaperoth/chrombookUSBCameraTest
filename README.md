# Chromebook USB Camera Test

### Overview
Simply lists out the cameras available from WebCamTexture.devices in Unity. Main script is in ```Assets/Scripts/TestController```

### Dependencies
- Unity 2017.2.0f3 64bit
- internal and/or external webcam

### Usage
Start app from Scenes/Main.unity

### Examples
Using WebCamTextures we search for devices with the loop: 

```
for (int cameraIndex = 0; cameraIndex < WebCamTexture.devices.Length; cameraIndex++) {
    ...
}
```

To view results on both Mac and Chromebook, view the gifs in the root of this project. These show how the application behaves while plugging in and unplugging a USB camera.

### External References
- https://developer.android.com/topic/arc/manifest.html ("Unsupported hardware features" section)
- https://answers.unity.com/questions/1113199/possible-to-use-an-external-camera-usb-inside-unit.html
- [chromebook camera test](https://github.com/scaperoth/chrombookUSBCameraTest/blob/master/cameraTestChromebook.gif)
- [Mac camera test (Expected behavior)](https://github.com/scaperoth/chrombookUSBCameraTest/blob/master/cameraTestMac.gif)

### Conclusion
Chromebook does not currently show USB connected web cams in WebCamTexture.devices list. Tested with [Logitech® HD Pro Webcam C920](http://a.co/fz7YqEZ) and [HUE HD (black) USB camera for Windows and Mac](http://a.co/079bMOH)
