using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class IconsFactory : MonoBehaviour
{
    private GameObject _imagePrefab;
    private Transform _groupLayout;

    public void Initialize(GameObject iconPrefab, Transform groupLayout)
    {
        _imagePrefab = iconPrefab;
        _groupLayout = groupLayout;
    }

    public GameObject CreateIcon()
    {
        GameObject image = Instantiate(_imagePrefab, _groupLayout);
        return image;
    }
}
