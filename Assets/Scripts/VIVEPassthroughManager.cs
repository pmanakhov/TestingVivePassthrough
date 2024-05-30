using UnityEngine;
using VIVE.OpenXR.CompositionLayer.Passthrough;
using VIVE.OpenXR.CompositionLayer;

public class VIVEPassthroughManager : MonoBehaviour
{
    private int _passthroughID;

    private void Start() => _passthroughID = CompositionLayerPassthroughAPI.CreatePlanarPassthrough(LayerType.Underlay);

    private void OnDisable()
    {
        if (_passthroughID != 0)
            CompositionLayerPassthroughAPI.DestroyPassthrough(_passthroughID);
    }
}
