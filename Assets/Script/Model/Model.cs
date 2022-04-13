using UniRx;
using UnityEngine;

public class Model
{
    public Model()
    {
        Debug.Log("Model Initialize");
    }
    private readonly ReactiveProperty<int> clickCount = new ReactiveProperty<int>(0);
    public ReactiveProperty<int> ClickCount => clickCount;
}
