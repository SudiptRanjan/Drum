using UnityEngine;
using UnityEngine.UI;

public class scroll : MonoBehaviour
{
    public Camera mainCamera;
    public Slider zoomSlider;

    public float minZoom = 10f;   
    public float maxZoom = 60f;   

    void Start()
    {
        zoomSlider.minValue = minZoom;
        zoomSlider.maxValue = maxZoom;
        zoomSlider.onValueChanged.AddListener(ChangeFOV);
    }

    void ChangeFOV(float newFOV)
    {
        mainCamera.fieldOfView = newFOV;
    }

    public void SetZoom(float zoomLevel)
    {
        float clampedZoom = Mathf.Clamp(zoomLevel, minZoom, maxZoom);
        zoomSlider.value = clampedZoom;
        mainCamera.fieldOfView = clampedZoom;
    }
}

