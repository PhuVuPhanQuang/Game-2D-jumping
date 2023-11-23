using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int cherries = 0;
    private int pineapples = 0;
    [SerializeField] private Text cherriesText;
    [SerializeField] private Text pineapplesText;

    [SerializeField] private AudioSource collectionSoundEffect;

    /// <summary>
    /// tac dung count trai cherry
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Cherry"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            cherries++;
            cherriesText.text = "Cherries: " + cherries;
        }

        if (collision.gameObject.CompareTag("Pineapple"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            pineapples++;
            pineapplesText.text = "Pineapples: " + pineapples;
        }
    }
}
