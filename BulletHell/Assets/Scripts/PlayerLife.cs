using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    public int lives = 3;
    public float spawnTime;
    public float invenciblityTime;

    private bool isDead;
    private SpriteRenderer sprite;
    private Vector3 startPos;

    PlayerFire playerFire;

    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        playerFire = GetComponent<PlayerFire>();
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Respawn()
    {
        lives--;
        if(lives > 0)
        {
            StartCoroutine(Spawning());
        }
        else
        {
            lives = 0;
            isDead = true;
            sprite.enabled = false;
        }
    }

    IEnumerator Spawning()
    {
        isDead = true;
        sprite.enabled = false;
        playerFire.fireLevel = 0;
        gameObject.layer = 8;
        yield return new WaitForSeconds(spawnTime);
        isDead = false;
        transform.position = startPos;

        for (float i = 0; i < invenciblityTime; i += 0.1f)
        {
            // Se estiver ativado vai pra desativado e se tiver desativado vai pra ativado
            sprite.enabled = !sprite.enabled;
            yield return new WaitForSeconds(0.1f);
        }
        gameObject.layer = 6;
        sprite.enabled = true;
    }
}
