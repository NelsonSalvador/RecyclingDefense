using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public GameState gameState;
    public Transform spawnPoint;
    public Transform leftLine;
    public Transform rightLine;
    public GameObject[] waves;
    public GameObject image1;
    public GameObject image2;
    public GameObject image3;
    public GameObject lostPannel;
    public GameObject winPannel;
    public Sprite glassBottle;
    public Sprite plasticBottle;
    public int level = 1;

    private int spawnIndex = 0;
    private GameObject currentGarbage;
    
    Controls inputs;
    // Start is called before the first frame update
    void Awake()
    {
        inputs = new Controls();
        inputs.Gameplay.Left.performed += ctx => LeftTurn();
        inputs.Gameplay.Right1.performed += ctx => RightTurn();
        gameState.canSpawn = false;
        gameState.canSpawnTut = false;
        gameState.levelpassed = false;
        gameState.lost = false;

        //if (level != 1)
        //    ShowNextWave();

    }
    public void MainMenu()
    {
        SceneManager.LoadScene("menu");
    }

    private void ShowNextWave()
    {
        if (spawnIndex + 1 >= waves.Length)
        {
            
            image1.SetActive(false);
            image2.SetActive(false);
            image3.SetActive(false);
        }
        else if (waves[spawnIndex + 1].name == "GreenGarbage_Val1")
        {
            image1.GetComponent<Image>().sprite = glassBottle;
            image2.GetComponent<Image>().sprite = glassBottle;
            image3.GetComponent<Image>().sprite = glassBottle;
            image1.SetActive(false);
            image2.SetActive(true);
            image3.SetActive(false);
        }
        else if (waves[spawnIndex + 1].name == "GreenGarbage_Val2")
        {
            image1.GetComponent<Image>().sprite = glassBottle;
            image2.GetComponent<Image>().sprite = glassBottle;
            image3.GetComponent<Image>().sprite = glassBottle;
            image1.SetActive(true);
            image2.SetActive(true);
            image3.SetActive(false);
        }
        else if (waves[spawnIndex + 1].name == "GreenGarbage_Val3")
        {
            image1.GetComponent<Image>().sprite = glassBottle;
            image2.GetComponent<Image>().sprite = glassBottle;
            image3.GetComponent<Image>().sprite = glassBottle;
            image1.SetActive(true);
            image2.SetActive(true);
            image3.SetActive(true);
        }
        else if (waves[spawnIndex + 1].name == "YellowGarbage_Val1")
        {
            image1.GetComponent<Image>().sprite = plasticBottle;
            image2.GetComponent<Image>().sprite = plasticBottle;
            image3.GetComponent<Image>().sprite = plasticBottle;
            image1.SetActive(false);
            image2.SetActive(true);
            image3.SetActive(false);
        }
        else if (waves[spawnIndex + 1].name == "YellowGarbage_Val2")
        {
            image1.GetComponent<Image>().sprite = plasticBottle;
            image2.GetComponent<Image>().sprite = plasticBottle;
            image3.GetComponent<Image>().sprite = plasticBottle;
            image1.SetActive(true);
            image2.SetActive(true);
            image3.SetActive(false);
        }
        else if (waves[spawnIndex + 1].name == "YellowGarbage_Val3")
        {
            image1.GetComponent<Image>().sprite = plasticBottle;
            image2.GetComponent<Image>().sprite = plasticBottle;
            image3.GetComponent<Image>().sprite = plasticBottle;
            image1.SetActive(true);
            image2.SetActive(true);
            image3.SetActive(true);
        }

        if(image1.GetComponent<Image>().sprite == plasticBottle)
        {
            image1.transform.localScale = new Vector3(0.6f, 1, 1);
        }
        else
        {
            image1.transform.localScale = new Vector3(1, 1, 1);
        }

        if (image2.GetComponent<Image>().sprite == plasticBottle)
        {
            image2.transform.localScale = new Vector3(0.6f, 1, 1);
        }
        else
        {
            image2.transform.localScale = new Vector3(1, 1, 1);
        }

        if (image3.GetComponent<Image>().sprite == plasticBottle)
        {
            image3.transform.localScale = new Vector3(0.6f, 1, 1);
        }
        else
        {
            image3.transform.localScale = new Vector3(1, 1, 1);
        }
    }

    public void LeftTurn()
    {
        if (currentGarbage != null)
        {
            if (currentGarbage.transform.position.x == spawnPoint.position.x)
                currentGarbage.transform.position = new Vector3( leftLine.transform.position.x, currentGarbage.transform.position.y, currentGarbage.transform.position.z);
            else if(currentGarbage.transform.position.x == rightLine.position.x)
                currentGarbage.transform.position = new Vector3(spawnPoint.transform.position.x, currentGarbage.transform.position.y, currentGarbage.transform.position.z);
        }
    }

    public void RightTurn()
    {
        if (currentGarbage != null)
        {
            if (currentGarbage.transform.position.x == spawnPoint.position.x)
                currentGarbage.transform.position = new Vector3(rightLine.transform.position.x, currentGarbage.transform.position.y, currentGarbage.transform.position.z);
            else if (currentGarbage.transform.position.x == leftLine.position.x)
                currentGarbage.transform.position = new Vector3(spawnPoint.transform.position.x, currentGarbage.transform.position.y, currentGarbage.transform.position.z);
        }
    }

    private void Update()
    {
        if(gameState.canSpawn == true)
        {
            if (spawnIndex < waves.Length)
            {
                currentGarbage = Instantiate(waves[spawnIndex], spawnPoint.position, Quaternion.identity);
                if (level != 1)
                    ShowNextWave();
                gameState.canSpawn = false;
            }
            spawnIndex += 1; 
        }

        if (spawnIndex == waves.Length + 1)
        {
            gameState.levelpassed = true;
        }

        if (gameState.lost)
        {
            lostPannel.SetActive(true);
        }
        if (gameState.levelpassed && level != 1)
        {
            StartCoroutine(NextLevel());
        }
    }

    IEnumerator NextLevel()
    {
        winPannel.SetActive(true);
        yield return new WaitForSeconds(1f);
        if (level == 2)
        {
            SceneManager.LoadScene("Level_3");
        }
        if (level == 3)
        {
            SceneManager.LoadScene("Level_4");
        }
        if (level == 4)
        {
            SceneManager.LoadScene("Level_5");
        }
        if (level == 5)
        {
            SceneManager.LoadScene("Level_6");
        }
        if (level == 6)
        {
            SceneManager.LoadScene("menu");
        }

    }
    private void OnEnable()
    {
        inputs.Gameplay.Enable();
    }
    private void OnDisable()
    {
        inputs.Gameplay.Disable();
    }
}
