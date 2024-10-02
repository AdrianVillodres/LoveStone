using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CharacterCard : Card
{
    public CharacterSO characterSO;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Invoke(Token token)
    {

    }

    public void PassData()
    {
        GameManager.gameManager.ChMana.text = this.mana.ToString();
        GameManager.gameManager.ChHP.text = this.characterSO.hp.ToString();
        GameManager.gameManager.ChDamage.text = this.characterSO.damage.ToString();
        GameManager.gameManager.ChDescription.text = this.characterSO.description.ToString();
        GameManager.gameManager.ChImage.sprite = this.characterSO.design;
    }
}
