using CommunityToolkit.Mvvm.ComponentModel;
using HanoriMvvm.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanoriMvvm.Core.ViewModels.MainWindow
{
    public class MainWindowViewModel : ObservableObject
    {
        IEnumerable<ITestService> testservices;
        public MainWindowViewModel(IEnumerable<ITestService> _testservices)
        {
            testservices= _testservices;
            SeriviceTest();
        }

        public void SeriviceTest()
        {
            foreach(ITestService testservice in testservices)
            {
                var test = testservice.GetString();
            }
        }

    }
}
