using System.Net.NetworkInformation;
using UnityEngine;
using System.Collections;

public class evilfuckingspagety : MonoBehaviour
{
    public float fadeDuration = 0;
    float efn = 0;
    float efn2 = 0;
    private Material mat;
    private Color baseColor;
    private bool isVisible = false;

    void Start()
    {
        mat = GetComponent<Renderer>().material;
        baseColor = mat.color;

        // Start invisible
        baseColor.a = 0f;
        mat.color = baseColor;
    }

    void Update()
    {
            efn = ballsackcancer.idx;
        efn = efn * 0.1f;
        if (efn != efn2)
        {
            StartCoroutine(FadeTo(efn));
            efn2 = efn;
        }
    }

    IEnumerator FadeTo(float targetAlpha)
    {
        float startAlpha = mat.color.a;
        float time = 0f;

        while (time < fadeDuration)
        {
            time += Time.deltaTime;
            float alpha = Mathf.Lerp(startAlpha, targetAlpha, time / fadeDuration);

            Color c = mat.color;
            c.a = alpha;
            mat.color = c;

            yield return null;
        }
    }
    //public Transform player;
    //public Vector3 offset = new Vector3(4f, 1f, 0f); // Behind & above
    //public float moveSmooth = 5f;      
    //public float rotateSmooth = 5f;      // How fast it rotates

    //void LateUpdate()
    //{
    //    // --- Position ---
    //    Vector3 targetPos = player.position + offset;
    //    transform.position = Vector3.Lerp(transform.position, targetPos, moveSmooth * Time.deltaTime);

    //    // --- Rotation ---

    //    transform.rotation = Camera.main.transform.rotation;
    //}
}
