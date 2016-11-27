using System;
using UnityEngine;

/// <summary>
/// 资源加载器定义
/// </summary>
public abstract class IResourceLoader
{
	#region public function
	public abstract bool OnSceneLoad(string sceneName);
	public abstract bool OnSceneLoadAsync(string sceneName, Action onEnd, int priority = 0);
	public abstract bool OnSceneClose(string sceneName);
	public abstract Font LoadFont (string fileName);
	public abstract bool LoadFontAsync (string fileName, Action<float, bool, Font> onProcess, int priority = 0);
	public abstract GameObject LoadPrefab(string fileName);
	public abstract bool LoadPrefabAsync(string fileName, Action<float, bool, GameObject> onProcess, int priority = 0);
	public abstract Material LoadMaterial(string fileName);
	public abstract bool LoadMaterialAsync(string fileName, Action<float, bool, Material> onProcess, int priority = 0);
	public abstract Texture LoadTexture(string fileName);
	public abstract bool LoadTextureAsync(string fileName, Action<float, bool, Texture> onProcess, int priority = 0);
	public abstract AudioClip LoadAudioClip(string fileName);
	public abstract bool LoadAudioClipAsync(string fileName, Action<float, bool, AudioClip> onProcess, int priority = 0);
	public abstract string LoadText(string fileName);
	public abstract byte[] LoadBytes(string fileName);
	public abstract bool LoadTextAsync(string fileName, Action<float, bool, TextAsset> onProcess, int priority = 0);
	public abstract RuntimeAnimatorController LoadAniController(string fileName);
	public abstract bool LoadAniControllerAsync(string fileName, Action<float, bool, RuntimeAnimatorController> onProcess, int priority = 0);
	public abstract AnimationClip LoadAnimationClip(string fileName);
	public abstract bool LoadAnimationClipAsync(string fileName, Action<float, bool, AnimationClip> onProcess, int priority = 0);
	public abstract Shader LoadShader(string fileName);
	public abstract bool LoadShaderAsync(string fileName, Action<float, bool, Shader> onProcess, int priority = 0);
	public abstract Sprite[] LoadSprites(string fileName);
	public abstract bool LoadSpritesAsync(string fileName, Action<float, bool, UnityEngine.Object[]> onProcess, int priority = 0);
	public abstract ScriptableObject LoadScriptableObject (string fileName);
	public abstract bool LoadScriptableObjectAsync (string fileName, Action<float, bool, UnityEngine.ScriptableObject> onProcess, int priority = 0);
#if UNITY_5
	public abstract ShaderVariantCollection LoadShaderVarCollection(string fileName);
	public abstract bool LoadShaderVarCollectionAsync(string fileName, Action<float, bool, ShaderVariantCollection> onProcess, int priority = 0);
#endif
	#endregion public function 
}
