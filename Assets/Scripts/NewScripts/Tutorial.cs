using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Tutorial : MonoBehaviour
{
    public GameState gameState;
    public Text tutorialText;
    public GameObject waveArrow;
    public GameObject bottleArrow;
    public int level = 1;

    private int tutStage = 0;
    private bool conlusionText = false;
    Controls inputs;
    // Start is called before the first frame update
    void Awake()
    {
        waveArrow.SetActive(false);
        bottleArrow.SetActive(false);
        inputs = new Controls();
        inputs.Gameplay.PassTurn.performed += ctx => TutorialNext();
        gameState.tutorialFase1 = false;
    }

    private void Update()
    {
        if (gameState.tutorialFase1 && level == 1 && conlusionText == false)
        {
            tutorialText.text = " “Boa! Conseguiste impedir o lixo de chegar ao mar”";
            conlusionText = true;
        }
    }


    private void TutorialNext()
    {
        if ( level == 1)
        {
            switch (tutStage)
            {
                case 0:
                    tutorialText.text = "“Este é o radar, ele mostra o próximo objeto que vai ser levado pela corrente”";
                    tutStage += 1;
                    waveArrow.SetActive(true);
                    break;
                case 1:
                    tutorialText.text = " “Parece que em primeiro vem 1 garrafa de vidro”";
                    tutStage += 1;
                    break;
                case 2:
                    tutorialText.text = "“Vês o símbolo no ecoponto? Significa que este ecoponto consegue recolher 1 garrafa.";
                    waveArrow.SetActive(false);
                    bottleArrow.SetActive(true);
                    tutStage += 1;
                    break;
                case 3:
                    tutorialText.text = "”Nas setas, controla o lixo com o cano que o puxa para o ecoponto”";
                    gameState.canSpawn = true;
                    bottleArrow.SetActive(false);
                    tutStage += 1;
                    break;
            }

            if (gameState.levelpassed == true)
            {
                switch (tutStage)
                {
                    case 4:
                        tutorialText.text = "“Lembra - te que tens que ser rápido a puxá - lo enquanto está a descer ou o lixo vai " +
                    "continuar pelo rio, antes que sejas capaz de recolhê-lo”";
                        tutStage += 1;
                        break;
                    case 5:
                        tutorialText.text = "”De qualquer forma, muito bom trabalho! Conseguiste salvar os peixes.”";
                        tutStage += 1;
                        break;
                    case 6:
                        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                        break;
                }
                

            }

            
        }
        else if (level == 2 || level == 3 || level == 4 || level == 5 || level == 6)
        {
            gameState.canSpawn = true;
            gameObject.SetActive(false);
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
