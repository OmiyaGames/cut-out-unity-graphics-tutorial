using UnityEngine;
using UnityEngine.UI;

public class ChangeRenderTexture : MonoBehaviour
{
    [SerializeField]
    Camera renderCamera;
    [SerializeField]
    RawImage targetImage;

    // Use this for initialization
    void Start ()
    {
	    if(renderCamera != null)
        {
            renderCamera.targetTexture = RenderTextureGenerator.MaskTexture;
        }
        if(targetImage != null)
        {
            targetImage.texture = RenderTextureGenerator.MaskTexture;
        }
	}
}
