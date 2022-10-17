using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    [SerializeField] private GameObject[] _particles;
    [SerializeField] private Text _textInfo;

    private int _counter;

    private void Start()
    {
        _counter = 0;
        ChangeParticle(0);
    }

    public void ChangeParticle(int offset)
    {
        if((offset == -1 && _counter <= 0) || (offset == +1 && _counter >= _particles.Length - 1))
        {
            return;
        }

        _counter += offset;

        foreach (GameObject obj in _particles)
        {
            obj.SetActive(false);
        }

        _particles[_counter].SetActive(true);
        _textInfo.text = _particles[_counter].name.ToString();
    }
}