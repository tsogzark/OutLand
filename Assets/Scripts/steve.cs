using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class steve : MonoBehaviour
{
    private Animator anim;
    public Transform target;
    public float speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate((Quaternion.Euler(0f, 90f, 0f)*transform.forward) * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate((Quaternion.Euler(0f,-90f, 0f)*transform.forward) * speed * Time.deltaTime);
        }
        CheckKey("walk", "idle", KeyCode.W, 0.1f, 0, 0.1f);
        CheckKey("walk_back", "idle", KeyCode.S, 0.1f, 0, 0.1f);
        CheckKey("left_attack", "idle", 0, 0.1f, 0, 0.1f);
        CheckKey("right_attack", "idle", 1, 0.01f, 0, 0.01f);
    }

    public void CheckKey(string animName, string outAnimName, KeyCode key, float transitionDuration, int layer, float fadeoutTime)
    {
        bool isKeyDown = Input.GetKeyDown(key);
        if (isKeyDown)
        {
            anim.CrossFade(animName, transitionDuration, layer, fadeoutTime);
        }
        bool isKeyUp = Input.GetKeyUp(key);
        if (isKeyUp)
        {
            anim.CrossFade(outAnimName, transitionDuration, layer, fadeoutTime);
        }
    }

    public void CheckKey(string animName, string outAnimName, int mouseButton, float transitionDuration, int layer, float fadeoutTime)
    {
        bool isKeyDown = Input.GetMouseButtonDown(mouseButton);
        if (isKeyDown)
        {
            anim.CrossFade(animName, transitionDuration, layer, fadeoutTime);
        }
        bool isKeyUp = Input.GetMouseButtonUp(mouseButton);
        if (isKeyUp)
        {
            anim.CrossFade(outAnimName, transitionDuration, layer, fadeoutTime);
        }
 
    }
}
