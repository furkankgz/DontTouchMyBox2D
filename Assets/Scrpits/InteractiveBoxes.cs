using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractiveBoxes : MonoBehaviour
{
    private float _health = 100f;
    [SerializeField] private Image _healthBar;
    [SerializeField] private GameObject _healthCanvas;

    public void TakeDamage(float damage)
    {
        _health -= damage;
        _healthBar.fillAmount = _health / 100f; // 0.9

        if (_health <= 0)
        {
            Destroy(gameObject);
        }
        else
        {
            StartCoroutine(EnableCanvas());
        }
    }

    IEnumerator EnableCanvas()
    {
        if (!_healthCanvas.activeInHierarchy)
        {
            _healthCanvas.SetActive(true);
            yield return new WaitForSeconds(2);
            _healthCanvas.SetActive(false);
        }
    }
}
