#define USE_UNITY5_X_BUILD
// #define USE_LOWERCHAR
#define USE_HAS_EXT
#define USE_DEP_BINARY
#define USE_DEP_BINARY_AB
#define USE_ABFILE_ASYNC

// 是否使用LoadFromFile读取压缩AB
#define USE_LOADFROMFILECOMPRESS

//#define USE_WWWCACHE

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class AssetLoader : IResourceLoader
{
    public override RuntimeAnimatorController LoadAniController(string fileName)
    {
        throw new NotImplementedException();
    }

    public override bool LoadAniControllerAsync(string fileName, Action<float, bool, RuntimeAnimatorController> onProcess, int priority = 0)
    {
        throw new NotImplementedException();
    }

    public override AnimationClip LoadAnimationClip(string fileName)
    {
        throw new NotImplementedException();
    }

    public override bool LoadAnimationClipAsync(string fileName, Action<float, bool, AnimationClip> onProcess, int priority = 0)
    {
        throw new NotImplementedException();
    }

    public override AudioClip LoadAudioClip(string fileName)
    {
        throw new NotImplementedException();
    }

    public override bool LoadAudioClipAsync(string fileName, Action<float, bool, AudioClip> onProcess, int priority = 0)
    {
        throw new NotImplementedException();
    }

    public override byte[] LoadBytes(string fileName)
    {
        throw new NotImplementedException();
    }

    public override Font LoadFont(string fileName)
    {
        throw new NotImplementedException();
    }

    public override bool LoadFontAsync(string fileName, Action<float, bool, Font> onProcess, int priority = 0)
    {
        throw new NotImplementedException();
    }

    public override Material LoadMaterial(string fileName)
    {
        throw new NotImplementedException();
    }

    public override bool LoadMaterialAsync(string fileName, Action<float, bool, Material> onProcess, int priority = 0)
    {
        throw new NotImplementedException();
    }

    public override GameObject LoadPrefab(string fileName)
    {
        throw new NotImplementedException();
    }

    public override bool LoadPrefabAsync(string fileName, Action<float, bool, GameObject> onProcess, int priority = 0)
    {
        throw new NotImplementedException();
    }

    public override ScriptableObject LoadScriptableObject(string fileName)
    {
        throw new NotImplementedException();
    }

    public override bool LoadScriptableObjectAsync(string fileName, Action<float, bool, ScriptableObject> onProcess, int priority = 0)
    {
        throw new NotImplementedException();
    }

    public override Shader LoadShader(string fileName)
    {
        throw new NotImplementedException();
    }

    public override bool LoadShaderAsync(string fileName, Action<float, bool, Shader> onProcess, int priority = 0)
    {
        throw new NotImplementedException();
    }

    public override ShaderVariantCollection LoadShaderVarCollection(string fileName)
    {
        throw new NotImplementedException();
    }

    public override bool LoadShaderVarCollectionAsync(string fileName, Action<float, bool, ShaderVariantCollection> onProcess, int priority = 0)
    {
        throw new NotImplementedException();
    }

    public override Sprite[] LoadSprites(string fileName)
    {
        throw new NotImplementedException();
    }

    public override bool LoadSpritesAsync(string fileName, Action<float, bool, UnityEngine.Object[]> onProcess, int priority = 0)
    {
        throw new NotImplementedException();
    }

    public override string LoadText(string fileName)
    {
        throw new NotImplementedException();
    }

    public override bool LoadTextAsync(string fileName, Action<float, bool, TextAsset> onProcess, int priority = 0)
    {
        throw new NotImplementedException();
    }

    public override Texture LoadTexture(string fileName)
    {
        throw new NotImplementedException();
    }

    public override bool LoadTextureAsync(string fileName, Action<float, bool, Texture> onProcess, int priority = 0)
    {
        throw new NotImplementedException();
    }

    public override bool OnSceneClose(string sceneName)
    {
        throw new NotImplementedException();
    }

    public override bool OnSceneLoad(string sceneName)
    {
        throw new NotImplementedException();
    }

    public override bool OnSceneLoadAsync(string sceneName, Action onEnd, int priority = 0)
    {
        throw new NotImplementedException();
    }
}
