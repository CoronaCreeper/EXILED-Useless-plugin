using Exiled.API.Interfaces;
using System.ComponentModel;

namespace CreepyWtyczkaOwO
{
    public sealed class Config : IConfig
    {
        [Description("Opcja poniżej włącza plugin. Zaznaczając ową opcję na true, załączasz n/- Witanie się n/- zapraszanie na discorda")]
        public bool IsEnabled { get; set; } = true;

        
    }
}
