using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootChest : MonoBehaviour
{
    [SerializeField] ParticleSystem lootParticle;
    private Animator _anim;
    public AudioClip ChestSound;
    public AudioSource audioSource;
    public bool alreadyPlayed = false;

    private void Start()
    {
        _anim = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();

    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            
            OpenChest();
            audioSource.PlayOneShot(ChestSound);
        }
    }

    public void OpenChest()
    {
        
        _anim.SetTrigger("Open");
        Invoke("lootEffect", 2.8f);
        

    }

    private void lootEffect()
    {
        lootParticle.Play();
    }
    
}
