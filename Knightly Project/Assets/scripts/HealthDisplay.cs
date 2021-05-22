using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthDisplay : MonoBehaviour
{

    public GameObject[] healthIcons;

    PlayerHealth player;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        int iconHealth = 0;

        foreach (GameObject icon in healthIcons)
        {
            iconHealth = iconHealth + 1;

            if (player.GetHealth() >= iconHealth)
            {
                icon.SetActive(true);
            }
            else
            {
                icon.SetActive(false);
            }
        }
    }
}
