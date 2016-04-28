using UnityEngine;

public static class RenderTextureGenerator
{
    static RenderTexture maskTexture = null;
    static RenderTexture insideWorldTexture = null;

    public static RenderTexture MaskTexture
    {
        get
        {
            if(maskTexture == null)
            {
                maskTexture = new RenderTexture(Screen.width, Screen.height, 16);
                maskTexture.name = "Mask Texture";
            }
            return maskTexture;
        }
    }
    public static RenderTexture InsideWorldTexture
    {
        get
        {
            if (insideWorldTexture == null)
            {
                insideWorldTexture = new RenderTexture(Screen.width, Screen.height, 16);
                insideWorldTexture.name = "Inside-World Texture";
            }
            return insideWorldTexture;
        }
    }
}
