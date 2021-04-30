using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Dice : MonoBehaviour
{
    [SerializeField]
    private Sprite[] diceSides;

    private SpriteRenderer rend;
    private int whosTurn = 1;
    private bool coroutineAllowed = true;


    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        rend.sprite = diceSides[5];

    }

    public void OnDataReceived()
    {
        if (!GameControl.gameOver && coroutineAllowed)
        {
            StartCoroutine("RollTheDice");
        }
    }

    public void OnMouseDown()
    {
       //For debugging purposed only. 
    }

    private IEnumerator RollTheDice()
    {
        coroutineAllowed = false;
        int randomDiceSide = 1;
        for (int i = 0; i <= 20; i++)
        {
            randomDiceSide = Random.Range(0, 6);
            rend.sprite = diceSides[randomDiceSide];
            yield return new WaitForSeconds(0.05f);
        }

        GameControl.diceSideThrown = randomDiceSide + 1;
        if (whosTurn == 1)
        {
            GameControl.MovePlayer(1);
        }
        else if (whosTurn == -1)
        {
            GameControl.MovePlayer(2);
        }
        whosTurn *= -1;
        coroutineAllowed = true;


    }
}
