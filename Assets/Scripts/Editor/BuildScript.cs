using UnityEditor;
using UnityEngine;

public static class BuildScript {
    public static void BuildAndroid() {
        BuildPlayerOptions options = new BuildPlayerOptions();
        options.scenes = new[] { "Assets/Scenes/Main.unity" };
        options.locationPathName = "Builds/Android/SkyForce.apk";
        options.target = BuildTarget.Android;
        options.options = BuildOptions.None;
        
        BuildPipeline.BuildPlayer(options);
    }
}
