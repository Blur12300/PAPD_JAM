using UnityEngine;
using UnityEngine.EventSystems;

public class Mask_Wearer : MonoBehaviour,
    IPointerEnterHandler, 
    IPointerExitHandler
{
    public GameObject mask;

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Mouse entered image");
        if (!mask.gameObject.activeInHierarchy)
        {
            mask.gameObject.SetActive(true);
        }
        else
        {
            mask.gameObject.SetActive(false);
        }
        Debug.Log(mask.gameObject.activeInHierarchy);
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Mouse exited image");
    }
}
