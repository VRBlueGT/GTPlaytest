using UnityEngine;
using XLua;
using System.IO;

public class LuaRunner : MonoBehaviour
{
    public string filePath;
    private LuaEnv luaEnv;

    void Start()
    {
        luaEnv = new LuaEnv();

        if (File.Exists(filePath))
        {
            string luaCode = File.ReadAllText(filePath);
            luaEnv.DoString(luaCode);
        }
        else
        {
            Debug.LogError("Lua file not found: " + filePath);
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