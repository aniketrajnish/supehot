using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperHot : MonoBehaviour
{
    bool yeet;
    // start the couroutine Yeet wherever minor actions like picking and throwing objects are to be performed!
    public IEnumerator Yeet(float time)
    {
        yeet = true;
        yield return new WaitForSecondsRealtime(.06f);
        yeet = false;
    }
    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        float time = (x != 0 || y != 0) ? 1f : 0.02f;
        float lerpTime = (x != 0 || y != 0) ? .5f : .05f;

        time = yeet ? 1 : time;
        lerpTime = yeet ? .1f : lerpTime;

        Time.timeScale = Mathf.Lerp(Time.timeScale, time, lerpTime);
    }
}
