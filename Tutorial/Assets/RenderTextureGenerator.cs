using UnityEngine;
using System.Collections;

public static class RenderTextureGenerator
{
    static RenderTexture maskTexture = null;

    public static RenderTexture MaskTexture
    {
        get
        {
            if(maskTexture == null)
            {
                maskTexture = new RenderTexture(Screen.width, Screen.height, 16);
            }
            return maskTexture;
        }
    }
}
