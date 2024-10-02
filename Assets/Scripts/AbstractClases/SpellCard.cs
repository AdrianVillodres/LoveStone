using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class SpellCard : Card
{
    public EntitySO entitySO;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PassData()
    {
        GameManager.gameManager.SCMana.text = this.mana.ToString();
        GameManager.gameManager.SCDescription.text = this.entitySO.description.ToString();
        GameManager.gameManager.SPCImage.sprite = this.entitySO.design;

    }
}
