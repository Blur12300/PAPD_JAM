using UnityEngine;
using UnityEngine.UI;

public class Health_And_O2 : MonoBehaviour
{
    public Text healthText;
    public Text o2Text;

    public bool maskOn;
    public bool inGas;

    public float maxHealth = 100;
    public float maxO2 = 100;

    public float health = 100;
    public float oxygen = 100;

    public float healingTime = 1;
    public float O2RechargeTime = 1;

    // Update is called once per frame
    void Update()
    {
        if (maskOn)
        {
            oxygen = (Mathf.MoveTowards(oxygen, 0, O2RechargeTime * Time.deltaTime));
        }
        else
        {
            oxygen = (Mathf.MoveTowards(oxygen, maxO2, O2RechargeTime * Time.deltaTime));
        }
        if (inGas)
        {
            if (maskOn && oxygen == 0)
            {
                health = (Mathf.MoveTowards(health, 0, healingTime * Time.deltaTime));
            }
            if (!maskOn)
            {
                health = (Mathf.MoveTowards(health, 0, healingTime * Time.deltaTime));
            }

        }

        o2Text.text = "O2: " + Mathf.Round(oxygen);
        healthText.text = "Health: " + Mathf.Round(health);

    }
    public void MaskOn()
    {
        maskOn = true;
    }
    public void MaskOff()
    {
        maskOn = false;
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Gas"))
        {
            inGas = true;
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Gas"))
        {
            inGas = false;
        }
    }
}
