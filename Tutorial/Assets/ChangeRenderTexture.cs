using UnityEngine;
using UnityEngine.UI;

public class ChangeRenderTexture : MonoBehaviour
{
    public enum TextureType
    {
        Mask,
        InsideWorld
    }

    [SerializeField]
    TextureType type = TextureType.Mask;
    [SerializeField]
    Camera renderCamera;
    [SerializeField]
    RawImage targetImage;

    // Use this for initialization
    void Start ()
    {
	    if(renderCamera != null)
        {
            if(type == TextureType.Mask)
            {
                renderCamera.targetTexture = RenderTextureGenerator.MaskTexture;
            }
            else
            {
                renderCamera.targetTexture = RenderTextureGenerator.InsideWorldTexture;
            }
        }
        if(targetImage != null)
        {
            if (type == TextureType.Mask)
            {
                targetImage.texture = RenderTextureGenerator.MaskTexture;
            }
            else
            {
                targetImage.texture = RenderTextureGenerator.InsideWorldTexture;
            }
        }
    }
}
