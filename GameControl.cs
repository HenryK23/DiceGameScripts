using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{

    private static GameObject whoWinsText, player1MoveText, player2MoveText;

    private static GameObject player1, player2;

    public static int diceSideThrown = 0;
    public static int player1StartWaypoint = 0;
    public static int player2StartWaypoint = 0;

    public static bool gameOver = false; 
    
    void Start()
    {
        diceSideThrown = 0;
        player1StartWaypoint = 0;
        player2StartWaypoint = 0;
        gameOver = false;  

        whoWinsText = GameObject.Find("WhoWinsText");
        player1MoveText = GameObject.Find("Player1MoveText");
        player2MoveText = GameObject.Find("Player2MoveText");

        player1 = GameObject.Find("Player1");
        player2 = GameObject.Find("Player2");

        player1.GetComponent<PathFollower>().moveAllowed = false;
        player2.GetComponent<PathFollower>().moveAllowed = false;

        whoWinsText.gameObject.SetActive(false);
        player1MoveText.gameObject.SetActive(true);
        player2MoveText.gameObject.SetActive(false);

    }

   
    void Update()
    {
        
        if (player1.GetComponent<PathFollower>().waypointIndex ==
            player1StartWaypoint + diceSideThrown + 1)   
        {
            //snake from 16 to 2
            if (player1.GetComponent<PathFollower>().waypointIndex == 16)
            {
                player1.GetComponent<PathFollower>().waypointIndex = 1;
                diceSideThrown = 1 - player1StartWaypoint;
            }
            //snake from 20 to 5
            if (player1.GetComponent<PathFollower>().waypointIndex == 20)
            {
                player1.GetComponent<PathFollower>().waypointIndex = 4;
                diceSideThrown = 4 - player1StartWaypoint;
            }
            //snake from 25 to 11
            if (player1.GetComponent<PathFollower>().waypointIndex == 25)
            {
                player1.GetComponent<PathFollower>().waypointIndex = 11;
                diceSideThrown = 11 - player1StartWaypoint;
            }
            //snake from 31 to 20
            if (player1.GetComponent<PathFollower>().waypointIndex == 31)
            {
                player1.GetComponent<PathFollower>().waypointIndex = 19;
                diceSideThrown = 19 - player1StartWaypoint;
            }
            //snake from 34 to 22
            if (player1.GetComponent<PathFollower>().waypointIndex == 34)
            {
                player1.GetComponent<PathFollower>().waypointIndex = 21;
                diceSideThrown = 21 - player1StartWaypoint;
            }


            //ladder from 6 to 18
            if (player1.GetComponent<PathFollower>().waypointIndex == 6)
            {
                player1.GetComponent<PathFollower>().waypointIndex = 17;
                diceSideThrown = 17 - player1StartWaypoint;
            }
            //ladder from 11 to 14
            if (player1.GetComponent<PathFollower>().waypointIndex == 11)
            {
                player1.GetComponent<PathFollower>().waypointIndex = 13;
                diceSideThrown = 13 - player1StartWaypoint;
            }
            //ladder from 15 to 22
            if (player1.GetComponent<PathFollower>().waypointIndex == 15)
            {
                player1.GetComponent<PathFollower>().waypointIndex = 21;
                diceSideThrown = 21 - player1StartWaypoint;
            }

            //ladder from 21 to 28
            if (player1.GetComponent<PathFollower>().waypointIndex == 21)
            {
                player1.GetComponent<PathFollower>().waypointIndex = 27;
                diceSideThrown = 27 - player1StartWaypoint;
            }
            //ladder from 23 to 35
            if (player1.GetComponent<PathFollower>().waypointIndex == 23)
            {
                player1.GetComponent<PathFollower>().waypointIndex = 34;
                diceSideThrown = 34 - player1StartWaypoint;
            }

        }

        if (player2.GetComponent<PathFollower>().waypointIndex ==
           player2StartWaypoint + diceSideThrown + 1)
        {
            //snake from 4 to 0
            if (player2.GetComponent<PathFollower>().waypointIndex == 16)
            {
                player2.GetComponent<PathFollower>().waypointIndex = 1;
                diceSideThrown = 1 - player2StartWaypoint;
            }
            //snake from 20 to 5
            if (player2.GetComponent<PathFollower>().waypointIndex == 20)
            {
                player2.GetComponent<PathFollower>().waypointIndex = 4;
                diceSideThrown = 4 - player2StartWaypoint;
            }
            //snakes from 25 to 12
            if (player2.GetComponent<PathFollower>().waypointIndex == 25)
            {
                player2.GetComponent<PathFollower>().waypointIndex = 11;
                diceSideThrown = 11 - player2StartWaypoint;
            }
            //snake from 31 to 20
            if (player2.GetComponent<PathFollower>().waypointIndex == 31)
            {
                player2.GetComponent<PathFollower>().waypointIndex = 19;
                diceSideThrown = 19 - player2StartWaypoint;
            }
            //snake from 34 to 22
            if (player2.GetComponent<PathFollower>().waypointIndex == 34)
            {
                player2.GetComponent<PathFollower>().waypointIndex = 21;
                diceSideThrown = 21 - player2StartWaypoint;
            }
          

            //ladder from 6 to 18
            if (player2.GetComponent<PathFollower>().waypointIndex == 6)
            {
                player2.GetComponent<PathFollower>().waypointIndex = 17;
                diceSideThrown = 17 - player2StartWaypoint;
            }
            //ladder from 11 to 14
            if (player2.GetComponent<PathFollower>().waypointIndex == 11)
            {
                player2.GetComponent<PathFollower>().waypointIndex = 13;
                diceSideThrown = 13 - player2StartWaypoint;
            }
            //ladder from 15 to 22
            if (player2.GetComponent<PathFollower>().waypointIndex == 15)
            {
                player2.GetComponent<PathFollower>().waypointIndex = 21;
                diceSideThrown = 21 - player2StartWaypoint;
            }
            //ladder from 21 to 28
            if (player2.GetComponent<PathFollower>().waypointIndex == 21)
            {
                player2.GetComponent<PathFollower>().waypointIndex = 27;
                diceSideThrown = 27 - player2StartWaypoint;
            }
            //ladder from 23 to 35
            if (player2.GetComponent<PathFollower>().waypointIndex == 23)
            {
                player2.GetComponent<PathFollower>().waypointIndex = 34;
                diceSideThrown = 34 - player2StartWaypoint;
            }
        }

        


        if (player1.GetComponent<PathFollower>().waypointIndex >
            player1StartWaypoint + diceSideThrown)
        {
            player1.GetComponent<PathFollower>().moveAllowed = false;
            player1MoveText.gameObject.SetActive(false);
            player2MoveText.gameObject.SetActive(true);
            player1StartWaypoint = player1.GetComponent<PathFollower>().waypointIndex - 1;
        }

        if (player2.GetComponent<PathFollower>().waypointIndex >
           player2StartWaypoint + diceSideThrown)
        {
            player2.GetComponent<PathFollower>().moveAllowed = false;
            player2MoveText.gameObject.SetActive(false);
            player1MoveText.gameObject.SetActive(true);
            player2StartWaypoint = player2.GetComponent<PathFollower>().waypointIndex - 1;
        }

        if(player1.GetComponent<PathFollower>().waypointIndex ==
            player1.GetComponent<PathFollower>().Waypoints.Length)
        {
            whoWinsText.gameObject.SetActive(true);
            player1MoveText.gameObject.SetActive(false);
            player2MoveText.gameObject.SetActive(false);
            whoWinsText.GetComponent<Text>().text = "player 1 wins";
            gameOver = true;
        }

        if (player2.GetComponent<PathFollower>().waypointIndex ==
            player2.GetComponent<PathFollower>().Waypoints.Length)
        {
            whoWinsText.gameObject.SetActive(true);
            player1MoveText.gameObject.SetActive(false);
            player2MoveText.gameObject.SetActive(false);
            whoWinsText.GetComponent<Text>().text = "player 2 wins";
            gameOver = true;
        }

    }

    public static void MovePlayer(int playerToMove)
    {
        switch (playerToMove)
        {
            case 1:
                player1.GetComponent<PathFollower>().moveAllowed = true;
                break;

            case 2:
                player2.GetComponent<PathFollower>().moveAllowed = true;
                break;


        }
    }
}
