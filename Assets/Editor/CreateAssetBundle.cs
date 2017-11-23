using UnityEditor;

public class CreateAssetBundle {

	[MenuItem ("Assets/Build AssetBundles")]
	static void BuildAllAssetBundles () {
		BuildPipeline.BuildAssetBundles( "AssetBundles", BuildAssetBundleOptions.None, BuildTarget.StandaloneOSXUniversal );
	}
}
