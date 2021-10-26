using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameState", menuName = "GameState")]
public class GameState : ScriptableObject
{
    public bool gameTutorial = false;

    public bool canSpawnTut = false;

    public bool tutorialFase1 = false;

    public bool canSpawn = false;

    public bool levelpassed = false;
    public bool lost = false;

    public GameObject bottleValue1;
}
