using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class glitch : MonoBehaviour
{

    public float glitchChance = .1f;

    private Renderer renderer;
    private WaitForSeconds GlitchLoopWait = new WaitForSeconds(.1f);
    private WaitForSeconds GlitchDuration = new WaitForSeconds(.1f);

    private void Awake()
    {   
        renderer = GetComponent<Renderer>();
    }



    IEnumerator Start()
    {
        while (true)
        {
            float glitchTest = Random.Range(0f, 1f);
            if (glitchTest <= glitchChance)
            {
                StartCoroutine(Glitch());
            }
            yield return GlitchLoopWait;
        }


        IEnumerator Glitch()
        {
            GlitchDuration = new WaitForSeconds(Random.Range(.05f, .25f));
            renderer.material.SetFloat("_amount", 1f);
            renderer.material.SetFloat("_CutoutThresh", .29f);
            renderer.material.SetFloat("_Amplitude", Random.Range(100, 250));
            renderer.material.SetFloat("_speed", Random.Range(1, 10));
            yield return GlitchDuration;
            renderer.material.SetFloat("_amount", 0f);
            renderer.material.SetFloat("_CutoutTresh", 1f);
        }

    }
}
