using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong.Core
{
    public interface ICommando
    {
        void Execute(object? parameter);

        bool CanExecute(object? parameter);
    }
}
