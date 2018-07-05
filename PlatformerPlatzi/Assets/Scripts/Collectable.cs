using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectable : MonoBehaviour {

    public static int collectableQuantity = 0;
    Text collectableText;

    ParticleSystem collectablePart;
    AudioSource collectableAudio;

	// Use this for initialization
	void Start () {
        collectableQuantity = 0;
        collectableText = GameObject.Find("CollectableQuantityText").GetComponent<Text>();
        collectablePart = GameObject.Find("CollectableParticle").GetComponent<ParticleSystem>();
        collectableAudio = GetComponentInParent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Player")
        {
            collectablePart.transform.position = transform.position;
            collectablePart.Play();
            collectableAudio.Play();
            gameObject.SetActive(false);
            collectableQuantity++;
            collectableText.text = collectableQuantity.ToString();
        }
    }
}
