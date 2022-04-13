using System;
using UniRx;
using UniRx.Triggers;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public sealed class ViewWrapper : MonoBehaviour
{
    [SerializeField] private Button upButton;
    [SerializeField] private Button showButton;
    [SerializeField] private Text showText;
    [SerializeField] private Text backendText;

    private IObservable<Unit> upButtonResponseObservable;
    private IObservable<Unit> showButtonResponseObservable;

    public IObservable<Unit> UpButtonResponseObservable => upButtonResponseObservable ??= upButton.OnClickAsObservable();
    public IObservable<Unit> ShowButtonResponseObservable => showButtonResponseObservable ??= showButton.OnClickAsObservable();
    
    public void RefreshShow(int clickCount)
    {
        showText.text = clickCount.ToString();
    }

    public void RefreshBackend(int clickCount)
    {
        backendText.text = clickCount.ToString();
    }
}
