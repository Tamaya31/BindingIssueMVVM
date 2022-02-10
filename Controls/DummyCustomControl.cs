using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Threading;

namespace BindingIssueMVVM.Controls
{
    public class DummyCustomControl : Control
    {
        public ADummyClass ADummyInstance
        {
            get => _aDummyInstance;
            set => SetAndRaise(ADummyInstanceProperty, ref _aDummyInstance, value);
        }

        public static readonly DirectProperty<DummyCustomControl, ADummyClass> ADummyInstanceProperty =
            AvaloniaProperty.RegisterDirect<DummyCustomControl, ADummyClass>(
                nameof(DummyCustomControl), o => o.ADummyInstance,
                (o, v) => o.ADummyInstance = v);

        private ADummyClass _aDummyInstance;

        public DummyCustomControl()
        {
            ADummyInstance = new ADummyClass();
        }
        
        public override void Render(DrawingContext context)
        {
            base.Render(context);

            context.FillRectangle(Brushes.IndianRed, Bounds);
            Dispatcher.UIThread.Post(InvalidateVisual);
        }
    }
}