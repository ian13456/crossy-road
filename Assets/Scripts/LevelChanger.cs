﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
  public Animator animator;

  private int levelToLoad;

  public void FadeToLevel(int levelIndex)
  {
    levelToLoad = levelIndex;
    animator.SetTrigger("Fade Out");
  }

  public void OnFadeComplete()
  {
    SceneManager.LoadScene(levelToLoad);
  }
}
