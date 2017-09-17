﻿using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelExit : MonoBehaviour {
  private int _currentlevel = 0;
  
  void OnTriggerEnter(Collider other) {
    if (other.name.ToLower().Equals("human")) {
      _currentlevel += 1;
      SceneManager.LoadScene(_currentlevel.ToString("000"));
    }
  }
  
  void Start() {
    _currentlevel = Int32.Parse(SceneManager.GetActiveScene().name);
  }
}