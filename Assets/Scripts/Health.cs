using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Health : MonoBehaviour
{
    public static int health = 3;
    public TextMeshProUGUI healthText;
    public GameObject gameObject;

    public GameObject endingPanel;
    void Update()
    {
        healthText.text = "Health : " + health.ToString();
        if (health == 0)
        {
            endingPanel.SetActive(true);
            Time.timeScale = 0;
        }
        void OnCollisionEnter2D(Collision2D collision)
        {

            if (collision.gameObject.tag == "ControlBlock")
            {
                Destroy(gameObject, 0.5f);
            }
        }

    }
}