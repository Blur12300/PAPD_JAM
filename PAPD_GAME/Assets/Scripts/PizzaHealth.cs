using UnityEngine;
using UnityEngine.UI;

public class PizzaHealth : MonoBehaviour
{
    public float pizzaHealth;

    public Sprite[] sprites;
    Image img;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        img = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        img.sprite = sprites[(int)(pizzaHealth-1)];
    }
    public void LowerHealth()
    {
        pizzaHealth = pizzaHealth - 0.5f;
        Debug.Log("pizza");
    }
}
