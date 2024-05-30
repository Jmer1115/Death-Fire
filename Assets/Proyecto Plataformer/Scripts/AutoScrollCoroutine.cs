using MoreMountains.CorgiEngine;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AutoScrollCoroutine : CambiarNivel
{
    public float scrollSpeed = 2f;
    public Vector2 directionBounds = new Vector2(1, 1);
    public float startDelay = 4f;
    public string nombreNivel;

    static private Vector3 startPosition;

    private GameObject player;
    private Health salud_personaje;

    private bool terminarAutoScroll = false;

    void Start()
    {
        startPosition = new Vector3(-14.1f, 4.51f, 0f);

        StartCoroutine(StartDelay());
    }

    public Health getHealth() 
    {
        player = LevelManager.Instance.Players[0].gameObject;

        return player.GetComponent<Health>();
    }

    IEnumerator StartDelay()
    {
        yield return new WaitForSeconds(startDelay);

        StartCoroutine(MoveLevelBounds());
    }

    IEnumerator MoveLevelBounds()
    {
        salud_personaje = getHealth();

        while (terminarAutoScroll == false)
        {
            if (salud_personaje.CurrentHealth <= 0f)
            {
                SceneManager.LoadScene(nombreNivel);
                break;
            }
            if (transform.position.y > 52)
            {
                terminarAutoScroll = true;
                directionBounds = new Vector2(0, 0);

                transform.position += (Vector3)directionBounds * 1 * Time.deltaTime;

                break;
            }

            transform.position += (Vector3)directionBounds * scrollSpeed * Time.deltaTime;

            yield return null;
        }
    }
}
