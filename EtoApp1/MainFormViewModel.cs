using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EtoApp1
{
    class MainFormViewModel : BindableBase
    {
        private string _testLabel = "test";
        public string TestLabel
        {
            get { return _testLabel; }
            set { SetProperty(ref _testLabel, value); }
        }

        private DelegateCommand _testCommand;
        public DelegateCommand TestCommand
        {
            get { return _testCommand ?? (_testCommand = new DelegateCommand(Test)); }
        }

        private void Test()
        {
            TestLabel += "a";
        }
    }
}
