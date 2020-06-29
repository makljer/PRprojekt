using webapi.Controllers.Models;

namespace webapi.Dtos.Character
{
    public class AddCharacterDto
    {
        public string Name { get; set; } = "Rycerz";
        public int HitPoints { get; set; } = 185;
        public int ManaPoints { get; set; } = 90;
        public int Capacity { get; set; } = 470;
        public int Experience { get; set; } = 4200;
        public Vocation Class { get; set; } = Vocation.Knight;
    }
}