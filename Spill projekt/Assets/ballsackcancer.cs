using System;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class ballsackcancer : MonoBehaviour
{
    [NonSerialized] public int idx = 0;
    float shake = 0;
    float timer = 0f;
    float karl = 0;
    float timer2 = 0f;
    private Vector3 basePosition;
    public bool isShaking = false;
    private Vector3 originalPos;
    float var = 0f;

    void Start()
    {
        originalPos = transform.localPosition;
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.E))
        {
            isShaking = false;
        }
        timer += Time.deltaTime;
        if (timer > 10)
        {
            Debug.Log($"{shake}");
            idx++;
            karl = (1) * idx;
            shake = karl * 0.001f;
            timer = 0f;
            var++;
            Debug.Log($"{var}");
            if (var == 5f)
            {
                isShaking = true;
            }
        }
        if (isShaking == true)
        {
            float offsetX = UnityEngine.Random.Range(-shake, shake);
            float offsetY = UnityEngine.Random.Range(-shake, shake);

            transform.localPosition = originalPos + new Vector3(offsetX, offsetY, 0);
        }
        else
        {
            // Return to original position when done
            transform.localPosition = originalPos;
        }
    }
}
