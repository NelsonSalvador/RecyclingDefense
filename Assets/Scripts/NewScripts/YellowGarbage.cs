using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YellowGarbage : MonoBehaviour
{
    public GameState gameState;
    public int garbageValue;
    public Data data;
    private Rigidbody2D rb;
    private Animator pipeanimator;

    [HideInInspector]
    public bool underGarbage = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (underGarbage == false)
            rb.velocity = new Vector2(0, -data.speed * Time.deltaTime) ;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag != "End")
            pipeanimator = collision.transform.Find("pipe_collect_up").GetComponent<Animator>();

        if (garbageValue == 1)
        {
            if (collision.tag == "GarbageYellow1")
            {
                pipeanimator.SetTrigger("PickUp");
                Destroy(gameObject);
                gameState.tutorialFase1 = true;
                gameState.canSpawn = true;
            }
            else
            {
                StartCoroutine(ReloadScene());
            }
        }
        else if (garbageValue == 2)
        {
            if (collision.tag == "GarbageYellow2")
            {
                pipeanimator.SetTrigger("PickUp");
                Destroy(gameObject);
                gameState.tutorialFase1 = true;
                gameState.canSpawn = true;
            }
            else
            {
                StartCoroutine(ReloadScene());
            }
        }
        else if (garbageValue == 3)
        {
            if (collision.tag == "GarbageYellow3")
            {
                pipeanimator.SetTrigger("PickUp");
                Destroy(gameObject);
                gameState.tutorialFase1 = true;
                gameState.canSpawn = true;
            }
            else
            {
                StartCoroutine(ReloadScene());
            }
        }
        else if (collision.tag == "End")
        {
            StartCoroutine(ReloadScene());
        }

    }
    IEnumerator ReloadScene()
    {
        gameState.lost = true;
        yield return new WaitForSeconds(1f);
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
}
