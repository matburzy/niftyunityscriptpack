using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    [Tooltip("Name of scene to load.")]
    [Header("Name of scene to load")]
    public string SceneName;
    [Header("Single keypress will initiate load, ex. Space.")]
    [Tooltip("Which keypress to press to initiate the scene load e.g. Space")]
    public KeyCode Key;
    [Header("Which two key combination to press to initiate the scene load (Debug)")]
    [Tooltip("Which two key combination to press to initiate the scene load")]
    public KeyCode Key1;
    public KeyCode Key2;
    [Header("Load new scene automatically after X seconds. Type 0 to disable.")]
    [Tooltip("Delay to load level in seconds. 0 for instant load.")]
    public int Delay;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DelaySceneLoader());
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(Key) && Delay == 0)
        {
            SceneManager.LoadScene(SceneName);
        }

        if (Input.GetKeyDown(Key1) && Input.GetKeyDown(Key2) &&  Delay == 0)
        {
            SceneManager.LoadScene(SceneName);
        }

    }

    IEnumerator DelaySceneLoader()
    {
        if (Delay > 0) { 
            yield return new WaitForSeconds(Delay);
            SceneManager.LoadScene(SceneName);
        }
        }





}
