using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packt.Shared;

public class DvdPlayer : IPlayable
{
    public void Pause()
    {
        WriteLine("Dvd player is pausing.");
    }

    public void Play()
    {
        WriteLine("Dvd player is playing");
    }
}
