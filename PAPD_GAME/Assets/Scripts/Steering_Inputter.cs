using UnityEngine;
using UnityEngine.UIElements;

public class Steering_Inputter : MonoBehaviour
{
    bool shouldMonitorMouse = false;

    public float leftRight = 0;
    public float lockedY;
    public float lockedLeftLimit;
    public float lockedRightLimit;

    public RectTransform rt;
    public float offSet = 960f;

    private void Update()
    {
        if (shouldMonitorMouse)
        {
            //Debug.Log(Input.mousePosition);

            float mouseX = Input.GetAxis("Mouse X");
            leftRight += mouseX * 5f;
            leftRight = Mathf.Clamp(leftRight, lockedLeftLimit, lockedRightLimit);


            rt.position = new Vector3((leftRight * 10) + offSet, rt.position.y, rt.position.z);
            Debug.Log(leftRight);

        }

    }
    public void ChangeMonitoring()
    {
        shouldMonitorMouse = !shouldMonitorMouse;

        if (shouldMonitorMouse)
        {
            UnityEngine.Cursor.lockState = CursorLockMode.Locked;
            UnityEngine.Cursor.visible = false;
        }
        else
        {
            UnityEngine.Cursor.lockState = CursorLockMode.None;
            UnityEngine.Cursor.visible = true;
        }
    }
}