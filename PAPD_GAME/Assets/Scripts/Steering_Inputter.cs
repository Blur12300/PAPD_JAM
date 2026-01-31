using UnityEngine;

public class Steering_Inputter : MonoBehaviour
{
    public bool isHoldingOn = false;

    public float leftRight = 0;
    public float lockedY;
    public float lockedLeftLimit;
    public float lockedRightLimit;

    public RectTransform rt;
    public float offSet = 960f;
    public float rotOffSet;

    public GameObject hand;

    private void Update()
    {
        if (isHoldingOn)
        {
            float mouseX = Input.GetAxis("Mouse X");
            leftRight += mouseX * 5f;
            leftRight = Mathf.Clamp(leftRight, lockedLeftLimit, lockedRightLimit);

            //rt.position = new Vector3((leftRight * 10) + offSet, rt.position.y, rt.position.z);
            //rt.rotation = new Quaternion(0, 0, 0, rotOffSet);

            if (Input.GetMouseButtonDown(0))
            {
                ChangeMonitoring();
            }
        }
    }
    private void FixedUpdate()
    {
        if (isHoldingOn)
        {
            rt.rotation = Quaternion.Euler(0f, 0f, (-leftRight ));
        }
    }
    public void ChangeMonitoring()
    {
        isHoldingOn = !isHoldingOn;

        if (isHoldingOn)
        {
            UnityEngine.Cursor.lockState = CursorLockMode.Locked;
            UnityEngine.Cursor.visible = false;
            hand.SetActive(true);
        }
        else
        {
            UnityEngine.Cursor.lockState = CursorLockMode.None;
            UnityEngine.Cursor.visible = true;
            hand.SetActive(false);
        }
    }
    public float GetLeftRight() 
    {
        return leftRight;
    }
}