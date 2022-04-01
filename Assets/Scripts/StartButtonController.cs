using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartButtonController : MonoBehaviour
{

    [SerializeField] private Button button;
    [SerializeField] private Animator animator;
    private bool clicked = false;
    // Start is called before the first frame update
    private void OnEnable()
    {
        button.onClick.AddListener(OnClick);
    }

    private void OnDisable() {
        button.onClick.RemoveListener(OnClick);
    }

    private void OnClick()
    {
        if(clicked) return;
        clicked = true;
        animator.Play("OnClick");
        StartCoroutine("Animate");
    }

    private IEnumerator Animate()
    {
        yield return new WaitForSeconds(1.17f);
        SceneManager.LoadScene(1);
    }
}
