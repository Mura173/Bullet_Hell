using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoDamage : MonoBehaviour
{
    public int damage = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        CharacterHealth character = other.GetComponent<CharacterHealth>();
        if (character != null)
        {
            character.TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}
