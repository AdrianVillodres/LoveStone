using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Power : Invocable
{
    public EntitySO entitySO;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PassData()
    {
        GameManager.gameManager.PMana.text = this.mana.ToString();
        GameManager.gameManager.POImage.sprite = this.entitySO.design;
    }
}
