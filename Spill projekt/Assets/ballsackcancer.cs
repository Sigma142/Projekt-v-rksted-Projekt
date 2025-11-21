using System;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] List<Sprite> images;
    [SerializeField] Image comp;
    [NonSerialized] public int idx = 0;
    int shake = 0;
    float timer = 0f;
    void Start()
    {
        comp = GetComponent<Image>();
        if (comp == null)
        {
            Debug.LogError("No Image component found on this GameObject!");
        }
        if (images.Count == 0)
        {
            Debug.LogError("No images assigned in the inspector!");
        }


    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 10)
        {
            Debug.Log("jews");
            idx++;
            if (idx == images.Count) idx = 0;
            comp.sprite = images[idx];
            shake = (1) + idx;
            timer = 0f;
        }
        transform.position = new Vector2(UnityEngine.Random.Range(-shake, shake) + Screen.width * 0.8f, UnityEngine.Random.Range(-shake, shake) + Screen.height * 0.8f);
    }
}
