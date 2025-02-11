using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packt.Shared;

public interface IPlayable
{
    void Play();
    void Pause();

    void Stop() // реализация интерфейса по умолчанию
    {
        WriteLine("Default implementation of Stop.");
    }
}
