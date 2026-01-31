using UnityEngine;
using UnityEngine.EventSystems;

public class Mask_Wearer : MonoBehaviour,
    IPointerEnterHandler, 
    IPointerExitHandler
{
    public GameObject mask;
    public Health_And_O2 healthO2;

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Mouse entered image");
        if (!mask.gameObject.activeInHierarchy)
        {
            mask.gameObject.SetActive(true);
            healthO2.MaskOn();
        }
        else
        {
            mask.gameObject.SetActive(false);
            healthO2.MaskOff();
        }
        Debug.Log(mask.gameObject.activeInHierarchy);
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Mouse exited image");
    }
}
