using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Token : Fighter
{
    public int position;
    public int currentDamage;
    public int currentHp;
    public CharacterSO characterSO;

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
        GameManager.gameManager.TDamage.text = this.damage.ToString();
        GameManager.gameManager.THP.text = this.hp.ToString();
        GameManager.gameManager.TOImage.sprite = this.characterSO.design;
    }
}
