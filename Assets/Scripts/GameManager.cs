using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;

    public Text ChMana, ChHP, ChDescription;
    public Image ChImage;

    void Awake()
    {
        if (GameManager.gameManager != null && GameManager.gameManager != this)
        {
            Destroy(this.gameObject);
        }
        gameManager = this;
    }
}
