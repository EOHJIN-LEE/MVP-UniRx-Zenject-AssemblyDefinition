using UniRx;
using Zenject;

public sealed class Presenter
{
    private const int PlusValue = 1;
    
    [Inject]
    public void Setup(ViewWrapper viewWrapper, Model model)
    {
        //Model => View
        model.ClickCount.Subscribe(clickCount =>
        {
            viewWrapper.RefreshBackend(clickCount);
        });

        //View => Model
        viewWrapper.UpButtonResponseObservable.Subscribe(_ =>
        {
            model.ClickCount.Value += PlusValue;
        });
        viewWrapper.ShowButtonResponseObservable.Subscribe(_ =>
        {
            var nowClickCount = model.ClickCount;
            viewWrapper.RefreshShow(nowClickCount.Value);
        });
    }
}
