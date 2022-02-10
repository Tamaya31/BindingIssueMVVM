using System;

namespace BindingIssueMVVM.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public ADummyClass? DummyInstance { get; set; }

        public void TestButtonClickCommand()
        {
            if (null == DummyInstance)
                throw new NullReferenceException("DummyInstance is null!");
        }
    }
}