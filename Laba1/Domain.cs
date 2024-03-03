

namespace Laba1.Domain
{
    public class Politic
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        //public 


    };

    public class Republic : Politic
    {
        public string Type { get; set; } = string.Empty;

        public string President { get; set; } = string.Empty;

        public string Prime { get; set; } = string.Empty;

        public string Party { get; set; } = string.Empty;


    }

    public class Monarchy : Politic
    {
        public string Type { get; set; } = string.Empty;

        public string RuleDinasty { get; set; } = string.Empty;

        public string Monarch { get; set; } = string.Empty;

        public string Prime { get; set; } = string.Empty;
    }

    public class State : Politic 
    {
        public string Regime { get; set; } = string.Empty;

        public string Form { get; set; } = string.Empty;

        public string TerritoryStruct { get; set; } = string.Empty;

        public string Ideology { get; set; } = string.Empty;

        public int Years { get; set; }

    }
}
