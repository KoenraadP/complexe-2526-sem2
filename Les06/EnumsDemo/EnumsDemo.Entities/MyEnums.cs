using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsDemo.Entities
{
    public enum Season
    {
        Spring, 
        Summer,
        Autumn,
        Winter
    }

    // bij enum dag veranderen we de cijfer waarde
    // zodat deze niet meer bij 0 start
    public enum Dag
    {
        Maandag = 1,
        Dinsdag,
        Woensdag,
        Donderdag,
        Vrijdag,
        Zaterdag,
        Zondag
    }
}
