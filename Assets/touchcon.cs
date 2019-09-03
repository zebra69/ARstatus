using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchcon : MonoBehaviour
{
    public AudioClip[] aClips;
    public AudioSource myAudioSource;
    string btnName;
    // Start is called before the first frame update
    void Start()
    {
     myAudioSource = GetComponent<AudioSource>();   
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit Hit;
            if (Physics.Raycast(ray, out Hit)) {
               btnName = Hit.transform.name;
               switch (btnName)
               {
                   case "Cube1":
                    myAudioSource.clip = aClips[0];
                    myAudioSource.Play();
                    Debug.Log("Button 1 Pressed");
                    break;
                   case "Cube2":
                    myAudioSource.clip = aClips[1];
                    myAudioSource.Play();
                    Debug.Log("Button 2 Pressed");
                    break;
                   default:
                    Debug.Log("NOT Pressed");
                    break;
               }
            }
        }
        
    }
}
