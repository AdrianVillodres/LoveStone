using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Avatar : Fighter
{
    public Power power;
    public int armor;
    public EntitySO entitySO;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Interact()
    {
        
    }
    public void PassData()
    {
        GameManager.gameManager.AVImage.sprite = this.entitySO.design;
    }
}
