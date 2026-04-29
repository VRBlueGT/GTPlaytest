using UnityEngine;
using XLua;

public class LuaRunner : MonoBehaviour
{
    public TextAsset luaFile;
    private LuaEnv luaEnv;

    void Awake()
    {
        luaEnv = new LuaEnv();
    }

    void Start()
    {
        if (luaFile != null)
        {
            luaEnv.DoString(luaFile.text);
        }
        else
        {
            Debug.LogError("No Lua TextAsset assigned");
        }
    }

    void OnDestroy()
    {
        if (luaEnv != null)
        {
            luaEnv.Dispose();
        }
    }
}