using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextLevelButton : MonoBehaviour
{
    [SerializeField] private string _name;
    [SerializeField] private Button _button;

    private void OnEnable()
    {
        _button.onClick.AddListener(LoadLevel);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(LoadLevel);
    }

    private void LoadLevel()
    {
        Debug.Log("GO");
        SceneManager.LoadScene(_name);
    }
}
